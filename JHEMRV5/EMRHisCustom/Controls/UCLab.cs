using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using JHEMR.EmrSysDAL;
using System.IO;
using DevExpress.XtraEditors;

namespace JHEMR.EMRHisCustom
{
    public partial class UCLab : UserControl, EmrEditUCInterface
    {
        private string m_strDBConnet = "HISConnect";
        private s_pat_info m_pat_info = EmrSysPubVar.getCurPatientInfo();
        private DataTable m_dtLabSheetClass = new DataTable();
        private DataTable m_dtLabSheetMaster1 = new DataTable();
        private DataTable m_dtLabSheetMaster2 = new DataTable();
        private DataTable m_dtLabSheetMaster3 = new DataTable();
        private DataTable m_dtLabSheetMaster4 = new DataTable();
        private DataTable m_dtLabSheetMaster5 = new DataTable();
        private DataTable m_dtLabSheetMaster6 = new DataTable();
        private DataTable m_dtLabSheetMaster7 = new DataTable();
        private DataTable m_dtLabSheetItems = new DataTable();
        private DataTable m_dtSpecimanDict = new DataTable();
        private DataTable m_dtLabSheetDetail = new DataTable();
        private TreeView m_CurTreeView;
        private string strSheetTitle = string.Empty;
        public DateTime dtDischargeDate = default(DateTime);
        private int m_nCPID;
        private int m_nCPExcuteNodeIndex;
        private int m_nClinicPathStatus;
        private bool m_bIsUseClinicPath = false;
        public DataTable m_dtCpLabItem = new DataTable();
        public DataTable m_dtCpLabApply = new DataTable();
		
        public UCLab()
        {
            InitializeComponent();
            this.gcItems.Dock = DockStyle.Fill;
            this.gcDetail.Dock = DockStyle.Fill;
            this.txtMemo.Dock = DockStyle.Fill;
        }
        private void UCLab_Load(object sender, EventArgs e)
        {
            this.dtDischargeDate = EmrSysPubVar.getCurVisitDischargeDateTime();
            string text = "select count(*) from pats_in_hospital where patient_id='" + EmrSysPubVar.getCurPatientID() + "' ";
            int count = DALUse.GetCount(text);
            if (count < 1)
            {
                MessageBox.Show("该病人已经出院,不能开检验申请！");
                this.spbtnSave.Enabled = false;
                this.spbtnNo.Enabled = false;
                this.spbtnAll.Enabled = false;
            }
            if (!this.FillPatInfo())
            {
                MessageBox.Show("该病人已经出院或者没有选中病人");
            }
            else
            {
                string value = EmrSysPubVar.getCurPatientDeptCode();
                text = "select dept_code from pats_in_hospital where patient_id='" + EmrSysPubVar.getCurPatientID() + "' ";
                object single = DALUseSpecial.GetSingle(text, this.m_strDBConnet);
                if (single != null)
                {
                    value = single.ToString();
                }
                else
                {
                    value = "";
                }
                if (!EmrSysPubVar.getDeptCode().Equals(value))
                {
                    MessageBox.Show("该病人已转科不能开检验申请单");
                }
                else
                {
                    frmLoadProgress frmLoadProgress = new frmLoadProgress();
                    frmLoadProgress.Show();
                    frmLoadProgress.setTipText("正在加载申请单数据，请稍候...");
                    frmLoadProgress.setRange(0, 5);
                    frmLoadProgress.setPos(1);
                    this.LoadLabClass();
                    frmLoadProgress.setPos(3);
                    this.LoadSpecimanDict();
                    frmLoadProgress.setPos(5);
                    frmLoadProgress.Close();
                }
            }
        }
        private bool FillPatInfo()
        {
            bool result;
            if (EmrSysPubVar.getCurPatientID().Length < 1)
            {
                result = false;
            }
            else
            {
                this.txtBed.Text = EmrSysPubVar.getCurPatientBedNo().ToString();
                this.txtName.Text = EmrSysPubVar.getCurPatientName();
                this.txtPatientId.Text = EmrSysPubVar.getCurPatientID();
                this.txtSex.Text = EmrSysPubVar.getCurPatientSex();
                this.txtDoctorCharge.Text = EmrSysPubFunction.getUserName(EmrSysPubVar.getCurPatientDoctorInCharge(), false);
                this.txtDoctorApply.Text = EmrSysPubFunction.getUserName(EmrSysPubVar.getUserID(), true);
                result = true;
                this.txtCPBedNo.Text = this.txtBed.Text;
                this.txtCPName.Text = this.txtName.Text;
                this.txtCPPatId.Text = this.txtPatientId.Text;
                this.txtCPSex.Text = this.txtSex.Text;
                this.txtCPDoctor.Text = this.txtDoctorCharge.Text;
                this.txtDoctorApply.Text = this.txtDoctorApply.Text;
            }
            return result;
        }
        private void LoadLabClass()
        {
            string sQLString = "select distinct(sheet_classname),sheet_classcode from lab_sheet_class order by sheet_classcode";
            this.m_dtLabSheetClass = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (this.m_dtLabSheetClass.Rows.Count > 0)
            {
                foreach (DataRow dataRow in this.m_dtLabSheetClass.Rows)
                {
                    string text = dataRow["sheet_classcode"].ToString();
                    switch (text)
                    {
                        case "1":
                            {
                                this.tabPage1.Tag = dataRow["sheet_classcode"].ToString();
                                this.tabPage1.Text = dataRow["sheet_classname"].ToString();
                                string sQLString2 = "select lab_sheet_id,sheet_title,performed_by,comp_type from lab_sheet_master where lab_sheet_id in (select lab_sheet_id from lab_sheet_class where sheet_classcode=" + dataRow["sheet_classcode"].ToString() + ") order by to_number(lab_sheet_id)";
                                this.m_dtLabSheetMaster1 = DALUseSpecial.Query(sQLString2, this.m_strDBConnet).Tables[0];
                                if (this.m_dtLabSheetMaster1.Rows.Count > 0)
                                {
                                    int num2 = 1;
                                    foreach (DataRow dataRow2 in this.m_dtLabSheetMaster1.Rows)
                                    {
                                        TreeNode treeNode = new TreeNode();
                                        treeNode.Text = num2.ToString().PadLeft(2, '0') + "." + dataRow2["sheet_title"].ToString();
                                        treeNode.Name = dataRow2["lab_sheet_id"].ToString();
                                        treeNode.Tag = dataRow2["comp_type"].ToString();
                                        treeNode.ImageIndex = 0;
                                        treeNode.SelectedImageIndex = 0;
                                        TreeNode treeNode2 = new TreeNode();
                                        treeNode2.Text = "检验单说明";
                                        treeNode2.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode2.ImageIndex = 1;
                                        treeNode2.SelectedImageIndex = 1;
                                        treeNode.Nodes.Add(treeNode2);
                                        TreeNode treeNode3 = new TreeNode();
                                        treeNode3.Text = "检验单细项";
                                        treeNode3.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode3.ImageIndex = 2;
                                        treeNode3.SelectedImageIndex = 2;
                                        treeNode.Nodes.Add(treeNode3);
                                        this.trv1.Nodes.Add(treeNode);
                                        num2++;
                                    }
                                }
                                break;
                            }
                        case "2":
                            {
                                this.tabPage2.Tag = dataRow["sheet_classcode"].ToString();
                                this.tabPage2.Text = dataRow["sheet_classname"].ToString();
                                string sQLString3 = "select * from lab_sheet_master where lab_sheet_id in (select lab_sheet_id from lab_sheet_class where sheet_classcode=" + dataRow["sheet_classcode"].ToString() + ") order by to_number(lab_sheet_id)";
                                this.m_dtLabSheetMaster2 = DALUseSpecial.Query(sQLString3, this.m_strDBConnet).Tables[0];
                                if (this.m_dtLabSheetMaster2.Rows.Count > 0)
                                {
                                    int num2 = 1;
                                    foreach (DataRow dataRow2 in this.m_dtLabSheetMaster2.Rows)
                                    {
                                        TreeNode treeNode = new TreeNode();
                                        treeNode.Text = num2.ToString().PadLeft(2, '0') + "." + dataRow2["sheet_title"].ToString();
                                        treeNode.Name = dataRow2["lab_sheet_id"].ToString();
                                        treeNode.Tag = dataRow2["comp_type"].ToString();
                                        treeNode.ImageIndex = 0;
                                        treeNode.SelectedImageIndex = 0;
                                        TreeNode treeNode2 = new TreeNode();
                                        treeNode2.Text = "检验单说明";
                                        treeNode2.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode2.ImageIndex = 1;
                                        treeNode2.SelectedImageIndex = 1;
                                        treeNode.Nodes.Add(treeNode2);
                                        TreeNode treeNode3 = new TreeNode();
                                        treeNode3.Text = "检验单细项";
                                        treeNode3.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode3.ImageIndex = 2;
                                        treeNode3.SelectedImageIndex = 2;
                                        treeNode.Nodes.Add(treeNode3);
                                        this.trv2.Nodes.Add(treeNode);
                                        num2++;
                                    }
                                }
                                break;
                            }
                        case "3":
                            {
                                this.tabPage3.Tag = dataRow["sheet_classcode"].ToString();
                                this.tabPage3.Text = dataRow["sheet_classname"].ToString();
                                string sQLString4 = "select * from lab_sheet_master where lab_sheet_id in (select lab_sheet_id from lab_sheet_class where sheet_classcode=" + dataRow["sheet_classcode"].ToString() + ") order by to_number(lab_sheet_id)";
                                this.m_dtLabSheetMaster3 = DALUseSpecial.Query(sQLString4, this.m_strDBConnet).Tables[0];
                                if (this.m_dtLabSheetMaster3.Rows.Count > 0)
                                {
                                    int num2 = 1;
                                    foreach (DataRow dataRow2 in this.m_dtLabSheetMaster3.Rows)
                                    {
                                        TreeNode treeNode = new TreeNode();
                                        treeNode.Text = num2.ToString().PadLeft(2, '0') + "." + dataRow2["sheet_title"].ToString();
                                        treeNode.Name = dataRow2["lab_sheet_id"].ToString();
                                        treeNode.Tag = dataRow2["comp_type"].ToString();
                                        treeNode.ImageIndex = 0;
                                        treeNode.SelectedImageIndex = 0;
                                        TreeNode treeNode2 = new TreeNode();
                                        treeNode2.Text = "检验单说明";
                                        treeNode2.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode2.ImageIndex = 1;
                                        treeNode2.SelectedImageIndex = 1;
                                        treeNode.Nodes.Add(treeNode2);
                                        TreeNode treeNode3 = new TreeNode();
                                        treeNode3.Text = "检验单细项";
                                        treeNode3.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode3.ImageIndex = 2;
                                        treeNode3.SelectedImageIndex = 2;
                                        treeNode.Nodes.Add(treeNode3);
                                        this.trv3.Nodes.Add(treeNode);
                                        num2++;
                                    }
                                }
                                break;
                            }
                        case "4":
                            {
                                this.tabPage4.Tag = dataRow["sheet_classcode"].ToString();
                                this.tabPage4.Text = dataRow["sheet_classname"].ToString();
                                string sQLString5 = "select * from lab_sheet_master where lab_sheet_id in (select lab_sheet_id from lab_sheet_class where sheet_classcode=" + dataRow["sheet_classcode"].ToString() + ") order by to_number(lab_sheet_id)";
                                this.m_dtLabSheetMaster4 = DALUseSpecial.Query(sQLString5, this.m_strDBConnet).Tables[0];
                                if (this.m_dtLabSheetMaster4.Rows.Count > 0)
                                {
                                    int num2 = 1;
                                    foreach (DataRow dataRow2 in this.m_dtLabSheetMaster4.Rows)
                                    {
                                        TreeNode treeNode = new TreeNode();
                                        treeNode.Text = num2.ToString().PadLeft(2, '0') + "." + dataRow2["sheet_title"].ToString();
                                        treeNode.Name = dataRow2["lab_sheet_id"].ToString();
                                        treeNode.Tag = dataRow2["comp_type"].ToString();
                                        treeNode.ImageIndex = 0;
                                        treeNode.SelectedImageIndex = 0;
                                        TreeNode treeNode2 = new TreeNode();
                                        treeNode2.Text = "检验单说明";
                                        treeNode2.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode2.ImageIndex = 1;
                                        treeNode2.SelectedImageIndex = 1;
                                        treeNode.Nodes.Add(treeNode2);
                                        TreeNode treeNode3 = new TreeNode();
                                        treeNode3.Text = "检验单细项";
                                        treeNode3.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode3.ImageIndex = 2;
                                        treeNode3.SelectedImageIndex = 2;
                                        treeNode.Nodes.Add(treeNode3);
                                        this.trv4.Nodes.Add(treeNode);
                                        num2++;
                                    }
                                }
                                break;
                            }
                        case "5":
                            {
                                this.tabPage5.Tag = dataRow["sheet_classcode"].ToString();
                                this.tabPage5.Text = dataRow["sheet_classname"].ToString();
                                string sQLString6 = "select * from lab_sheet_master where lab_sheet_id in (select lab_sheet_id from lab_sheet_class where sheet_classcode=" + dataRow["sheet_classcode"].ToString() + ") order by to_number(lab_sheet_id)";
                                this.m_dtLabSheetMaster5 = DALUseSpecial.Query(sQLString6, this.m_strDBConnet).Tables[0];
                                if (this.m_dtLabSheetMaster5.Rows.Count > 0)
                                {
                                    int num2 = 1;
                                    foreach (DataRow dataRow2 in this.m_dtLabSheetMaster5.Rows)
                                    {
                                        TreeNode treeNode = new TreeNode();
                                        treeNode.Text = num2.ToString().PadLeft(2, '0') + "." + dataRow2["sheet_title"].ToString();
                                        treeNode.Name = dataRow2["lab_sheet_id"].ToString();
                                        treeNode.Tag = dataRow2["comp_type"].ToString();
                                        treeNode.ImageIndex = 0;
                                        treeNode.SelectedImageIndex = 0;
                                        TreeNode treeNode2 = new TreeNode();
                                        treeNode2.Text = "检验单说明";
                                        treeNode2.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode2.ImageIndex = 1;
                                        treeNode2.SelectedImageIndex = 1;
                                        treeNode.Nodes.Add(treeNode2);
                                        TreeNode treeNode3 = new TreeNode();
                                        treeNode3.Text = "检验单细项";
                                        treeNode3.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode3.ImageIndex = 2;
                                        treeNode3.SelectedImageIndex = 2;
                                        treeNode.Nodes.Add(treeNode3);
                                        this.trv5.Nodes.Add(treeNode);
                                        num2++;
                                    }
                                }
                                break;
                            }
                        case "6":
                            {
                                this.tabPage6.Tag = dataRow["sheet_classcode"].ToString();
                                this.tabPage6.Text = dataRow["sheet_classname"].ToString();
                                string sQLString7 = "select * from lab_sheet_master where lab_sheet_id in (select lab_sheet_id from lab_sheet_class where sheet_classcode=" + dataRow["sheet_classcode"].ToString() + ") order by to_number(lab_sheet_id)";
                                this.m_dtLabSheetMaster6 = DALUseSpecial.Query(sQLString7, this.m_strDBConnet).Tables[0];
                                if (this.m_dtLabSheetMaster6.Rows.Count > 0)
                                {
                                    int num2 = 1;
                                    foreach (DataRow dataRow2 in this.m_dtLabSheetMaster6.Rows)
                                    {
                                        TreeNode treeNode = new TreeNode();
                                        treeNode.Text = num2.ToString().PadLeft(2, '0') + "." + dataRow2["sheet_title"].ToString();
                                        treeNode.Name = dataRow2["lab_sheet_id"].ToString();
                                        treeNode.Tag = dataRow2["comp_type"].ToString();
                                        treeNode.ImageIndex = 0;
                                        treeNode.SelectedImageIndex = 0;
                                        TreeNode treeNode2 = new TreeNode();
                                        treeNode2.Text = "检验单说明";
                                        treeNode2.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode2.ImageIndex = 1;
                                        treeNode2.SelectedImageIndex = 1;
                                        treeNode.Nodes.Add(treeNode2);
                                        TreeNode treeNode3 = new TreeNode();
                                        treeNode3.Text = "检验单细项";
                                        treeNode3.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode3.ImageIndex = 2;
                                        treeNode3.SelectedImageIndex = 2;
                                        treeNode.Nodes.Add(treeNode3);
                                        this.trv6.Nodes.Add(treeNode);
                                        num2++;
                                    }
                                }
                                break;
                            }
                        case "7":
                            {
                                this.tabPage7.Tag = dataRow["sheet_classcode"].ToString();
                                this.tabPage7.Text = dataRow["sheet_classname"].ToString();
                                string sQLString8 = "select * from lab_sheet_master where lab_sheet_id in (select lab_sheet_id from lab_sheet_class where sheet_classcode=" + dataRow["sheet_classcode"].ToString() + ") order by to_number(lab_sheet_id)";
                                this.m_dtLabSheetMaster7 = DALUseSpecial.Query(sQLString8, this.m_strDBConnet).Tables[0];
                                if (this.m_dtLabSheetMaster7.Rows.Count > 0)
                                {
                                    int num2 = 1;
                                    foreach (DataRow dataRow2 in this.m_dtLabSheetMaster7.Rows)
                                    {
                                        TreeNode treeNode = new TreeNode();
                                        treeNode.Text = num2.ToString().PadLeft(2, '0') + "." + dataRow2["sheet_title"].ToString();
                                        treeNode.Name = dataRow2["lab_sheet_id"].ToString();
                                        treeNode.Tag = dataRow2["comp_type"].ToString();
                                        treeNode.ImageIndex = 0;
                                        treeNode.SelectedImageIndex = 0;
                                        TreeNode treeNode2 = new TreeNode();
                                        treeNode2.Text = "检验单说明";
                                        treeNode2.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode2.ImageIndex = 1;
                                        treeNode2.SelectedImageIndex = 1;
                                        treeNode.Nodes.Add(treeNode2);
                                        TreeNode treeNode3 = new TreeNode();
                                        treeNode3.Text = "检验单细项";
                                        treeNode3.Tag = dataRow2["lab_sheet_id"].ToString();
                                        treeNode3.ImageIndex = 2;
                                        treeNode3.SelectedImageIndex = 2;
                                        treeNode.Nodes.Add(treeNode3);
                                        this.trv7.Nodes.Add(treeNode);
                                        num2++;
                                    }
                                }
                                break;
                            }
                    }
                }
            }
        }
        private void LoadSpecimanDict()
        {
            try
            {
                string sQLString = "select speciman_name from speciman_dict";
                this.m_dtSpecimanDict = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                foreach (DataRow dataRow in this.m_dtSpecimanDict.Rows)
                {
                    this.cmbSpecimen.Items.Add(dataRow["speciman_name"]);
                    this.CPcmbSpecimen.Items.Add(dataRow["speciman_name"]);
                }
                if (this.m_dtSpecimanDict.Rows.Count > 0)
                {
                    this.cmbSpecimen.SelectedIndex = 0;
                    this.CPcmbSpecimen.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "加载样本字典错误");
            }
        }
        public bool cmdCheckIsUnSave()
        {
            return false;
        }
        public bool getCloseFlag()
        {
            return false;
        }
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            this.getbIsUseClinicPath();
        }
        private void trv1_DoubleClick(object sender, EventArgs e)
        {
            TreeView treeView = (TreeView)sender;
            string name = treeView.Name;
            switch (name)
            {
                case "trv1":
                    this.TreeViewHandler(this.trv1);
                    this.m_CurTreeView = this.trv1;
                    break;
                case "trv2":
                    this.TreeViewHandler(this.trv2);
                    this.m_CurTreeView = this.trv2;
                    break;
                case "trv3":
                    this.TreeViewHandler(this.trv3);
                    this.m_CurTreeView = this.trv3;
                    break;
                case "trv4":
                    this.TreeViewHandler(this.trv4);
                    this.m_CurTreeView = this.trv4;
                    break;
                case "trv5":
                    this.TreeViewHandler(this.trv5);
                    this.m_CurTreeView = this.trv5;
                    break;
                case "trv6":
                    this.TreeViewHandler(this.trv6);
                    this.m_CurTreeView = this.trv6;
                    break;
                case "trv7":
                    this.TreeViewHandler(this.trv7);
                    this.m_CurTreeView = this.trv7;
                    break;
                case "trv8":
                    this.TreeViewHandler(this.trv8);
                    this.m_CurTreeView = this.trv8;
                    break;
                case "trv9":
                    this.TreeViewHandler(this.trv9);
                    this.m_CurTreeView = this.trv9;
                    break;
                case "trv10":
                    this.TreeViewHandler(this.trv10);
                    this.m_CurTreeView = this.trv10;
                    break;
            }
        }
        private void TreeViewHandler(TreeView trv)
        {
            try
            {
                if (trv.SelectedNode != null)
                {
                    if (trv.SelectedNode.Parent == null)
                    {
                        this.strSheetTitle = trv.SelectedNode.Text;
                        this.strSheetTitle = this.strSheetTitle.Substring(3, this.strSheetTitle.Length - 3);
                        string str = trv.SelectedNode.Name;
                        string sQLString = "select 0 as CHOOSE_FLAG,LAB_ITEM_NO,LAB_ITEM_NAME,LAB_SPECIMEN,LAB_ITEM_CODE, '临床意义' as CLINIC_MEMO,room,rack from lab_sheet_items where lab_sheet_id='" + str + "' order by lab_item_no";
                        this.m_dtLabSheetItems = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                        this.gcItems.DataSource = this.m_dtLabSheetItems;
                        this.gcItems.BringToFront();
                        this.spbtnSave.Enabled = true;
                    }
                    else
                    {
                        if (trv.SelectedNode.Text == "检验单说明")
                        {
                            string str = trv.SelectedNode.Tag.ToString();
                            string sQLString = "select distinct SAMPLE_NOTES,SAMPLE_TIME,LABORATORY_ADDRESS FROM LAB_ITEM_SUMMARY a,lab_sheet_items b where b.lab_item_code = a.item_code and b.lab_sheet_id = '" + str + "' ";
                            DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                            if (dataTable.Rows.Count > 0)
                            {
                                DataRow dataRow = dataTable.Rows[0];
                                StringBuilder stringBuilder = new StringBuilder();
                                stringBuilder.Append("样本量：\n\t" + dataRow["SAMPLE_NOTES"].ToString() + "\n\n\r");
                                stringBuilder.Append("检验时间：\n\t" + dataRow["SAMPLE_TIME"].ToString() + "\n\n\r");
                                stringBuilder.Append("检验地点：\n\t" + dataRow["LABORATORY_ADDRESS"].ToString() + "\n\n\r");
                                this.txtMemo.Text = stringBuilder.ToString();
                            }
                            else
                            {
                                this.txtMemo.Text = "暂无检验单说明信息";
                            }
                            this.txtMemo.BringToFront();
                        }
                        else
                        {
                            if (trv.SelectedNode.Text == "检验单细项")
                            {
                                string str = trv.SelectedNode.Tag.ToString();
                                string sQLString = "select 0 as CHOOSE_FLAG,LAB_ITEM_NO,LAB_ITEM_NAME,LAB_SPECIMEN,LAB_ITEM_CODE, '临床意义' as CLINIC_MEMO from lab_sheet_items where lab_sheet_id='" + str + "' order by lab_item_no";
                                this.m_dtLabSheetItems = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                                string text = "";
                                foreach (DataRow dataRow in this.m_dtLabSheetItems.Rows)
                                {
                                    object obj = text;
                                    text = string.Concat(new object[]
									{
										obj,
										"select b.item_code,b.item_name, '",
										dataRow["LAB_ITEM_NAME"],
										"' as LAB_ITEM_NAME,a.master_item_code as LAB_ITEM_CODE,'临床意义' as CLINIC_MEMO from lab_sheet_detail_items a,lab_report_item_dict b where a.sheet_item_code = b.item_code and a.master_item_code = '",
										dataRow["LAB_ITEM_CODE"].ToString(),
										"' union "
									});
                                }
                                if (text.Length < 10)
                                {
                                    this.m_dtLabSheetDetail.Clear();
                                    this.gcDetail.BringToFront();
                                }
                                else
                                {
                                    text = text.Substring(0, text.Length - 7);
                                    this.m_dtLabSheetDetail = DALUseSpecial.Query(text, this.m_strDBConnet).Tables[0];
                                    this.gcDetail.DataSource = this.m_dtLabSheetDetail;
                                    this.gcDetail.BringToFront();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "检验单数据填充错误");
            }
        }
        private void gvItems_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string text = e.Column.FieldName.ToUpper();
                if (text.Equals("CHOOSE_FLAG"))
                {
                    if (text.Length != 0)
                    {
                        DataRow dataRow = this.gvItems.GetDataRow(e.RowHandle);
                        dataRow["CHOOSE_FLAG"] = (decimal)e.Value;
                        dataRow.AcceptChanges();
                    }
                }
            }
        }
        private void spbtnAll_Click(object sender, EventArgs e)
        {
            if (this.gvItems.DataRowCount > 0)
            {
                for (int i = 0; i < this.gvItems.DataRowCount; i++)
                {
                    this.gvItems.GetDataRow(i)["CHOOSE_FLAG"] = 1m;
                }
            }
        }
        private void spbtnNo_Click(object sender, EventArgs e)
        {
            if (this.gvItems.DataRowCount > 0)
            {
                for (int i = 0; i < this.gvItems.DataRowCount; i++)
                {
                    this.gvItems.GetDataRow(i)["CHOOSE_FLAG"] = 0m;
                }
            }
        }
        private void spbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.m_CurTreeView.SelectedNode != null)
                {
                    List<string> list = new List<string>();
                    if (this.m_CurTreeView.SelectedNode.Parent == null)
                    {
                        string name = this.m_CurTreeView.SelectedNode.Name;
                        string a = this.m_CurTreeView.SelectedNode.Tag.ToString();
                        string sQLString = string.Concat(new object[]
						{
							"select max(ORDER_NO)  from doctor_orders where visit_id = ",
							EmrSysPubVar.getCurPatientVisitID(),
							" and patient_id='",
							this.txtPatientId.Text,
							"'"
						});
                        object single = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
                        int num = 1;
                        if (single != null)
                        {
                            num = int.Parse(single.ToString());
                        }
                        if (a == "1")
                        {
                            DataTable dtLabTest = new DataTable();
                            foreach (DataRow dataRow in this.m_dtLabSheetItems.Rows)
                            {
                                if (!(dataRow["CHOOSE_FLAG"].ToString() == "0"))
                                {
                                    string sQLString2 = string.Concat(new string[]
									{
										"select 1 AS CHOOSE_FLAG,LAB_ITEM_NO,LAB_ITEM_NAME,LAB_SPECIMEN,LAB_ITEM_CODE,room,rack from lab_sheet_items where lab_sheet_id='",
										name,
										"' and LAB_ITEM_CODE = '",
										dataRow["LAB_ITEM_CODE"].ToString(),
										"' order by lab_item_no"
									});
                                    dtLabTest = DALUseSpecial.Query(sQLString2, this.m_strDBConnet).Tables[0];
                                    this.getSaveLabSheetReqSQL(dtLabTest, ref list, ref num);
                                }
                            }
                            DALUseSpecial.ExecuteSqlTran(list.ToArray(), this.m_strDBConnet);
                            this.spbtnSave.Enabled = false;
                            MessageBox.Show("保存检验单成功");
                        }
                        else
                        {
                            this.getSaveLabSheetReqSQL(this.m_dtLabSheetItems, ref list, ref num);
                            DALUseSpecial.ExecuteSqlTran(list.ToArray(), this.m_strDBConnet);
                            this.spbtnSave.Enabled = false;
                            MessageBox.Show("保存检验单成功");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "保存申请单出错");
            }
        }
        private void SQLLog(List<string> list)
        {
            StringBuilder stringBuilder = new StringBuilder("写入数据库语句于(" + DateTime.Now.ToString("yyyyMMddhhmmss") + ")\n");
            string[] array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                stringBuilder.AppendLine(array[i]);
            }
            File.WriteAllText("d:\\spf\\labResults" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".sql", stringBuilder.ToString());
        }
        private void getSaveLabSheetReqSQL(DataTable dtLabTest, ref List<string> listSaveLabReq, ref int orderNo)
        {
            string text = "select test_no.nextval from dual";
            text = DALUseSpecial.GetSingle(text, this.m_strDBConnet).ToString();
            if (text.Length < 4)
            {
                string text2 = "000000";
                text = text2.Substring(0, 4 - text.Length) + text;
            }
            text = EmrSysPubFunction.getServerNow().ToString("yyMMdd") + text;
            int days = EmrSysPubFunction.getServerNow().Subtract(EmrSysPubVar.getCurPatientBirthDate()).Days;
            int num;
            string text3;
            if (days < 31)
            {
                num = days;
                text3 = "天";
            }
            else
            {
                if (days == 31)
                {
                    num = 1;
                    text3 = "月";
                }
                else
                {
                    if (days > 31 && days < 365)
                    {
                        num = days / 31 + 1;
                        text3 = "月";
                    }
                    else
                    {
                        if (days == 365)
                        {
                            num = 1;
                            text3 = "年";
                        }
                        else
                        {
                            num = days / 365 + 1;
                            text3 = "年";
                        }
                    }
                }
            }
            string text4 = this.txtSpecimenMemo.Text;
            string text5 = string.Empty;
            string text6 = string.Empty;
            orderNo++;
            int num2 = 1;
            bool flag = false;
            foreach (DataRow dataRow in dtLabTest.Rows)
            {
                if (!(dataRow["CHOOSE_FLAG"].ToString() == "0"))
                {
                    string text7 = this.cmbSpecimen.Text.ToString().Trim();
                    if (dataRow["LAB_SPECIMEN"] != DBNull.Value && dataRow["LAB_SPECIMEN"].ToString().Trim().Length > 0)
                    {
                        text7 = dataRow["LAB_SPECIMEN"].ToString();
                    }
                    if (!flag)
                    {
                        string diag = this.m_pat_info.diag;
                        if (diag.Contains("'"))
                        {
                            string text8 = diag.Replace("'", "’");
                            string item = string.Concat(new object[]
							{
								"insert into lab_test_master (TEST_NO,PRIORITY_INDICATOR,PATIENT_ID,VISIT_ID,NAME,NAME_PHONETIC,CHARGE_TYPE,SEX,AGE,RELEVANT_CLINIC_DIAG,SPECIMEN,NOTES_FOR_SPCM,REQUESTED_DATE_TIME,ORDERING_DEPT,ORDERING_PROVIDER,BED,AGE_TYPE,RESULT_STATUS) values( '",
								text,
								"',",
								this.chkBusy.Checked ? 1 : 0,
								",'",
								this.txtPatientId.Text,
								"',",
								EmrSysPubVar.getCurPatientVisitID(),
								",'",
								EmrSysPubVar.getCurPatientName(),
								"','",
								EmrSysPubVar.getCurPatientNamePhonetic(),
								"','",
								EmrSysPubVar.getCurPatientChargeType(),
								"','",
								EmrSysPubVar.getCurPatientSex(),
								"',",
								num,
								",'",
								text8,
								"','",
								text7,
								"','",
								this.txtSpecimenMemo.Text,
								"',to_date('",
								EmrSysPubFunction.getServerNow(),
								"','YYYY-MM-DD HH24:MI:SS'),'",
								EmrSysPubVar.getDeptCode(),
								"','",
								EmrSysPubFunction.getUserName(EmrSysPubVar.getUserID(), true),
								"','",
								EmrSysPubVar.getCurPatientBedNo(),
								"','",
								text3,
								"','1')"
							});
                            listSaveLabReq.Add(item);
                        }
                        else
                        {
                            string item = string.Concat(new object[]
							{
								"insert into lab_test_master (TEST_NO,PRIORITY_INDICATOR,PATIENT_ID,VISIT_ID,NAME,NAME_PHONETIC,CHARGE_TYPE,SEX,AGE,RELEVANT_CLINIC_DIAG,SPECIMEN,NOTES_FOR_SPCM,REQUESTED_DATE_TIME,ORDERING_DEPT,ORDERING_PROVIDER,BED,AGE_TYPE,RESULT_STATUS) values( '",
								text,
								"',",
								this.chkBusy.Checked ? 1 : 0,
								",'",
								this.txtPatientId.Text,
								"',",
								EmrSysPubVar.getCurPatientVisitID(),
								",'",
								EmrSysPubVar.getCurPatientName(),
								"','",
								EmrSysPubVar.getCurPatientNamePhonetic(),
								"','",
								EmrSysPubVar.getCurPatientChargeType(),
								"','",
								EmrSysPubVar.getCurPatientSex(),
								"',",
								num,
								",'",
								this.m_pat_info.diag,
								"','",
								text7,
								"','",
								this.txtSpecimenMemo.Text,
								"',to_date('",
								EmrSysPubFunction.getServerNow(),
								"','YYYY-MM-DD HH24:MI:SS'),'",
								EmrSysPubVar.getDeptCode(),
								"','",
								EmrSysPubFunction.getUserName(EmrSysPubVar.getUserID(), true),
								"','",
								EmrSysPubVar.getCurPatientBedNo(),
								"','",
								text3,
								"','1')"
							});
                            listSaveLabReq.Add(item);
                        }
                        string item2 = string.Concat(new string[]
						{
							"insert into lab_sheet_printed(test_no,printed,sheet) values('",
							text,
							"','0','",
							this.strSheetTitle,
							"')"
						});
                        listSaveLabReq.Add(item2);
                        if (dataRow["ROOM"] != DBNull.Value)
                        {
                            text5 = dataRow["ROOM"].ToString();
                        }
                        if (dataRow["RACK"] != DBNull.Value)
                        {
                            text6 = dataRow["RACK"].ToString();
                        }
                        string item3 = string.Concat(new string[]
						{
							"insert into lab_test_room_rack(test_no,sheet_title,room,rack) values('",
							text,
							"','",
							this.strSheetTitle,
							"','",
							text5,
							"','",
							text6,
							"')"
						});
                        listSaveLabReq.Add(item3);
                        flag = true;
                    }
                    string text9 = string.Empty;
                    if (this.chkBusy.Checked)
                    {
                        text9 = string.Concat(new object[]
						{
							"insert into doctor_orders (PATIENT_ID,VISIT_ID,ORDER_NO,ORDER_SUB_NO,ENTER_DATE_TIME,START_STOP_INDICATOR,REPEAT_INDICATOR,ORDER_CLASS,ORDER_TEXT,ORDER_CODE,ORDERING_DEPT,DOCTOR,ORDER_STATUS,PROCESSING_DATE_TIME,ORDER_PRINT_INDICATOR, RELATED_ORDER_NO,BILLING_ATTR,START_DATE_TIME,ADMINISTRATION) values( '",
							this.txtPatientId.Text,
							"',",
							EmrSysPubVar.getCurPatientVisitID(),
							",",
							orderNo,
							",",
							num2,
							",to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS'),0,0,'C','",
							dataRow["LAB_ITEM_NAME"].ToString(),
							"  急查','",
							dataRow["LAB_ITEM_CODE"].ToString(),
							"','",
							EmrSysPubVar.getDeptCode(),
							"','",
							EmrSysPubFunction.getUserName(EmrSysPubVar.getUserID(), true),
							"','1', to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS'),0,1,3,to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS')"
						});
                        text9 = text9 + ",'" + text7 + "')";
                    }
                    else
                    {
                        text9 = string.Concat(new object[]
						{
							"insert into doctor_orders (PATIENT_ID,VISIT_ID,ORDER_NO,ORDER_SUB_NO,ENTER_DATE_TIME,START_STOP_INDICATOR,REPEAT_INDICATOR,ORDER_CLASS,ORDER_TEXT,ORDER_CODE,ORDERING_DEPT,DOCTOR,ORDER_STATUS,PROCESSING_DATE_TIME,ORDER_PRINT_INDICATOR, RELATED_ORDER_NO,BILLING_ATTR,START_DATE_TIME,ADMINISTRATION) values( '",
							this.txtPatientId.Text,
							"',",
							EmrSysPubVar.getCurPatientVisitID(),
							",",
							orderNo,
							",",
							num2,
							",to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS'),0,0,'C','",
							dataRow["LAB_ITEM_NAME"].ToString(),
							"','",
							dataRow["LAB_ITEM_CODE"].ToString(),
							"','",
							EmrSysPubVar.getDeptCode(),
							"','",
							EmrSysPubFunction.getUserName(EmrSysPubVar.getUserID(), true),
							"','1', to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS'),0,1,3,to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS')"
						});
                        text9 = text9 + ",'" + text7 + "')";
                    }
                    listSaveLabReq.Add(text9);
                    string item4 = string.Concat(new string[]
					{
						"insert into lab_test_items (TEST_NO,ITEM_NO,ITEM_NAME,ITEM_CODE) values ('",
						text,
						"',",
						dataRow["LAB_ITEM_NO"].ToString(),
						",'",
						dataRow["LAB_ITEM_NAME"].ToString(),
						"','",
						dataRow["LAB_ITEM_CODE"].ToString(),
						"')"
					});
                    listSaveLabReq.Add(item4);
                    string item5 = string.Concat(new object[]
					{
						"insert into lab_order_notes (TEST_NO,ORDER_START,PATIENT_ID,VISIT_ID,ORDER_NO,ORDER_SUB_NO,ITEM_CODE) values ('",
						text,
						"',to_date('",
						EmrSysPubFunction.getServerNow(),
						"','YYYY-MM-DD HH24:MI:SS'),'",
						this.txtPatientId.Text,
						"',",
						EmrSysPubVar.getCurPatientVisitID(),
						",",
						orderNo,
						",",
						num2,
						",'",
						dataRow["LAB_ITEM_CODE"].ToString(),
						"')"
					});
                    listSaveLabReq.Add(item5);
                    orderNo++;
                }
            }
        }
        private void gvItems_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gvItems.SelectedRowsCount == 1)
                {
                    int[] selectedRows = this.gvItems.GetSelectedRows();
                    if (selectedRows.Length >= 1)
                    {
                        DataRow dataRow = this.gvItems.GetDataRow(selectedRows[0]);
                        string sQLString = "select clinic_hi,clinic_lo from lab_item_summary where item_code = '" + dataRow["LAB_ITEM_CODE"].ToString() + "' ";
                        DataSet dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
                        string clinicMemoText = "暂时没有临床意义数据!";
                        if (dataSet.Tables[0].Rows.Count > 0)
                        {
                            clinicMemoText = "升高：\n" + dataSet.Tables[0].Rows[0]["clinic_hi"].ToString() + "\n\r降低：\n" + dataSet.Tables[0].Rows[0]["clinic_lo"].ToString();
                        }
                        frmClinicMemo frmClinicMemo = new frmClinicMemo();
                        frmClinicMemo.SetClinicMemoText(clinicMemoText);
                        frmClinicMemo.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提取临床意义数据异常");
            }
        }
        private void gvDetail_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.gvDetail.SelectedRowsCount == 1)
                {
                    int[] selectedRows = this.gvDetail.GetSelectedRows();
                    if (selectedRows.Length >= 1)
                    {
                        DataRow dataRow = this.gvDetail.GetDataRow(selectedRows[0]);
                        string sQLString = "select clinic_hi,clinic_lo from lab_item_summary where item_code = '" + dataRow["LAB_ITEM_CODE"].ToString() + "' ";
                        DataSet dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
                        string clinicMemoText = "暂时没有临床意义数据!";
                        if (dataSet.Tables[0].Rows.Count > 0)
                        {
                            clinicMemoText = "升高：\n" + dataSet.Tables[0].Rows[0]["clinic_hi"].ToString() + "\n\r降低：\n" + dataSet.Tables[0].Rows[0]["clinic_lo"].ToString();
                        }
                        frmClinicMemo frmClinicMemo = new frmClinicMemo();
                        frmClinicMemo.SetClinicMemoText(clinicMemoText);
                        frmClinicMemo.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提取临床意义数据异常");
            }
        }
        private void rItemBtnEditSheetDetailClinicMemo_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (this.gvDetail.SelectedRowsCount == 1)
                {
                    int[] selectedRows = this.gvDetail.GetSelectedRows();
                    if (selectedRows.Length >= 1)
                    {
                        DataRow dataRow = this.gvDetail.GetDataRow(selectedRows[0]);
                        string sQLString = "select clinic_hi,clinic_lo from lab_item_summary where item_code = '" + dataRow["LAB_ITEM_CODE"].ToString() + "' ";
                        DataSet dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
                        string clinicMemoText = "暂时没有临床意义数据!";
                        if (dataSet.Tables[0].Rows.Count > 0)
                        {
                            clinicMemoText = "升高：\n" + dataSet.Tables[0].Rows[0]["clinic_hi"].ToString() + "\n\r降低：\n" + dataSet.Tables[0].Rows[0]["clinic_lo"].ToString();
                        }
                        frmClinicMemo frmClinicMemo = new frmClinicMemo();
                        frmClinicMemo.SetClinicMemoText(clinicMemoText);
                        frmClinicMemo.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提取临床意义数据异常");
            }
        }
        private void rItemBtnEditClinicMemo_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ButtonEdit buttonEdit = (ButtonEdit)sender;
            try
            {
                string sQLString = "select clinic_hi,clinic_lo from lab_item_summary where item_code = '" + buttonEdit.EditValue.ToString() + "' ";
                DataSet dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
                string clinicMemoText = "暂时没有临床意义数据!";
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    clinicMemoText = "偏高：\n\t" + dataSet.Tables[0].Rows[0]["clinic_hi"].ToString() + "\n\r偏低：\n\t" + dataSet.Tables[0].Rows[0]["clinic_lo"].ToString();
                }
                frmClinicMemo frmClinicMemo = new frmClinicMemo();
                frmClinicMemo.SetClinicMemoText(clinicMemoText);
                frmClinicMemo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提取临床意义数据异常");
            }
        }
        private void txtSpecimenMemo_TextChanged(object sender, EventArgs e)
        {
        }
        private void getbIsUseClinicPath()
        {
            string text = "select * from cp_middle_status t  where  t.patient_id='" + EmrSysPubVar.getCurPatientID() + "'and t.visit_id  = " + EmrSysPubVar.getCurPatientVisitID().ToString();
            DataSet dataSet = DALUseSpecial.Query(text, this.m_strDBConnet);
            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    if (dataSet.Tables[0].Rows[0]["PATH_STATUS"] != DBNull.Value)
                    {
                        this.m_nClinicPathStatus = Convert.ToInt32(dataSet.Tables[0].Rows[0]["PATH_STATUS"].ToString());
                        if (this.m_nClinicPathStatus == 1)
                        {
                            this.m_bIsUseClinicPath = true;
                        }
                    }
                    if (dataSet.Tables[0].Rows[0]["CP_ID"] != DBNull.Value)
                    {
                        this.m_nCPID = Convert.ToInt32(dataSet.Tables[0].Rows[0]["CP_ID"].ToString());
                    }
                    if (dataSet.Tables[0].Rows[0]["CP_EXCUTE_NODE_INDEX"] != DBNull.Value)
                    {
                        this.m_nCPExcuteNodeIndex = Convert.ToInt32(dataSet.Tables[0].Rows[0]["CP_EXCUTE_NODE_INDEX"].ToString());
                    }
                }
            }
            if (this.m_bIsUseClinicPath)
            {
                text = "SELECT 0 AS CHOOSE_FLAG,ITEM_NO AS LAB_ITEM_NO,ITEM_CODE AS LAB_ITEM_CODE,ITEM_NAME AS LAB_ITEM_NAME,ITEM_SPECIMEN AS LAB_SPECIMEN,'临床意义' as CLINIC_MEMO,room,rack,comp_type,LAB_SHEET_ID,STATUS FROM EMR_CP_PATIENT_NODE_APPLYITEMS T ";
                object obj = text;
                text = string.Concat(new object[]
				{
					obj,
					" where  t.patient_id='",
					EmrSysPubVar.getCurPatientID(),
					"'and t.visit_id  = ",
					EmrSysPubVar.getCurPatientVisitID().ToString(),
					" AND CP_EXCUTE_NODE_INDEX=",
					this.m_nCPExcuteNodeIndex
				});
                text = text + " AND CP_ID=" + this.m_nCPID;
                DataSet dataSet2 = new DataSet();
                dataSet2 = DALUse.Query(text);
                if (dataSet2 != null && dataSet2.Tables.Count > 0 && dataSet2.Tables[0].Rows.Count > 0)
                {
                    this.simpleButtonCancel.Visible = true;
                    this.panelControl1.Dock = DockStyle.Fill;
                    this.panelControl1.Visible = true;
                    this.m_dtCpLabItem = dataSet2.Tables[0];
                    this.gcLabList.DataSource = this.m_dtCpLabItem;
                    text = string.Concat(new object[]
					{
						"select ITEM_CODE,ITEM_NO from emr_cp_patient_lab_vs_record where patient_id='",
						this.txtPatientId.Text,
						"' and visit_id=",
						EmrSysPubVar.getCurPatientVisitID(),
						" and cp_id=",
						this.m_nCPID,
						" and cp_excute_node_index=",
						this.m_nCPExcuteNodeIndex
					});
                    this.m_dtCpLabApply = DALUse.Query(text).Tables[0];
                }
                else
                {
                    this.simpleButtonCancel.Visible = false;
                    this.panelControl1.Dock = DockStyle.Fill;
                    this.panelControl1.Visible = false;
                }
            }
            else
            {
                this.panelControl1.Visible = false;
            }
        }
        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.panelControl1.Visible = false;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.panelControl1.Dock = DockStyle.Fill;
            this.panelControl1.Visible = true;
        }
        private void cpbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                List<string> list2 = new List<string>();
                string sQLString = string.Concat(new object[]
				{
					"select max(ORDER_NO)  from doctor_orders where visit_id = ",
					EmrSysPubVar.getCurPatientVisitID(),
					" and patient_id='",
					this.txtPatientId.Text,
					"'"
				});
                object single = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
                int num = 1;
                if (single != null)
                {
                    num = int.Parse(single.ToString());
                }
                DataTable dataTable = this.m_dtCpLabItem.Clone();
                foreach (DataRow dataRow in this.m_dtCpLabItem.Rows)
                {
                    if (!(dataRow["CHOOSE_FLAG"].ToString() == "0"))
                    {
                        dataTable.Clear();
                        dataTable.ImportRow(dataRow);
                        if (dataRow["COMP_TYPE"].ToString() == "1")
                        {
                            DataTable dtLabTest = new DataTable();
                            string sQLString2 = string.Concat(new string[]
							{
								"select 1 AS CHOOSE_FLAG,LAB_ITEM_NO,LAB_ITEM_NAME,LAB_SPECIMEN,LAB_ITEM_CODE,room,rack from lab_sheet_items where lab_sheet_id='",
								dataRow["LAB_SHEET_ID"].ToString(),
								"' and LAB_ITEM_CODE = '",
								dataRow["LAB_ITEM_CODE"].ToString(),
								"' order by lab_item_no"
							});
                            dtLabTest = DALUseSpecial.Query(sQLString2, this.m_strDBConnet).Tables[0];
                            this.cpgetSaveLabSheetReqSQL(dtLabTest, ref list, ref num, ref list2);
                        }
                        else
                        {
                            this.cpgetSaveLabSheetReqSQL(dataTable, ref list, ref num, ref list2);
                        }
                    }
                }
                if (DALUseSpecial.ExecuteSqlTran(list.ToArray(), this.m_strDBConnet))
                {
                    DALUse.ExecuteSqlTran(list2.ToArray());
                    this.spbtnSave.Enabled = false;
                    MessageBox.Show("保存检验单成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "保存申请单出错");
            }
        }
        private void cpgetSaveLabSheetReqSQL(DataTable dtLabTest, ref List<string> listSaveLabReq, ref int orderNo, ref List<string> listCpLabReq)
        {
            string text = "select test_no.nextval from dual";
            text = DALUseSpecial.GetSingle(text, this.m_strDBConnet).ToString();
            if (text.Length < 4)
            {
                string text2 = "000000";
                text = text2.Substring(0, 4 - text.Length) + text;
            }
            text = EmrSysPubFunction.getServerNow().ToString("yyMMdd") + text;
            int days = EmrSysPubFunction.getServerNow().Subtract(EmrSysPubVar.getCurPatientBirthDate()).Days;
            int num;
            string text3;
            if (days < 31)
            {
                num = days;
                text3 = "天";
            }
            else
            {
                if (days == 31)
                {
                    num = 1;
                    text3 = "月";
                }
                else
                {
                    if (days > 31 && days < 365)
                    {
                        num = days / 31 + 1;
                        text3 = "月";
                    }
                    else
                    {
                        if (days == 365)
                        {
                            num = 1;
                            text3 = "年";
                        }
                        else
                        {
                            num = days / 365 + 1;
                            text3 = "年";
                        }
                    }
                }
            }
            string text4 = this.txtCPSpecimenMemo.Text;
            string text5 = string.Empty;
            string text6 = string.Empty;
            orderNo++;
            int num2 = 1;
            bool flag = false;
            foreach (DataRow dataRow in dtLabTest.Rows)
            {
                if (!(dataRow["CHOOSE_FLAG"].ToString() == "0"))
                {
                    string text7 = this.CPcmbSpecimen.Text.ToString().Trim();
                    if (dataRow["LAB_SPECIMEN"] != DBNull.Value && dataRow["LAB_SPECIMEN"].ToString().Trim().Length > 0)
                    {
                        text7 = dataRow["LAB_SPECIMEN"].ToString();
                    }
                    if (!flag)
                    {
                        string diag = this.m_pat_info.diag;
                        if (diag.Contains("'"))
                        {
                            string text8 = diag.Replace("'", "’");
                            string item = string.Concat(new object[]
							{
								"insert into lab_test_master (TEST_NO,PRIORITY_INDICATOR,PATIENT_ID,VISIT_ID,NAME,NAME_PHONETIC,CHARGE_TYPE,SEX,AGE,RELEVANT_CLINIC_DIAG,SPECIMEN,NOTES_FOR_SPCM,REQUESTED_DATE_TIME,ORDERING_DEPT,ORDERING_PROVIDER,BED,AGE_TYPE,RESULT_STATUS) values( '",
								text,
								"',",
								this.chkBusy.Checked ? 1 : 0,
								",'",
								this.txtPatientId.Text,
								"',",
								EmrSysPubVar.getCurPatientVisitID(),
								",'",
								EmrSysPubVar.getCurPatientName(),
								"','",
								EmrSysPubVar.getCurPatientNamePhonetic(),
								"','",
								EmrSysPubVar.getCurPatientChargeType(),
								"','",
								EmrSysPubVar.getCurPatientSex(),
								"',",
								num,
								",'",
								text8,
								"','",
								text7,
								"','",
								this.txtSpecimenMemo.Text,
								"',to_date('",
								EmrSysPubFunction.getServerNow(),
								"','YYYY-MM-DD HH24:MI:SS'),'",
								EmrSysPubVar.getDeptCode(),
								"','",
								EmrSysPubFunction.getUserName(EmrSysPubVar.getUserID(), true),
								"','",
								EmrSysPubVar.getCurPatientBedNo(),
								"','",
								text3,
								"','1')"
							});
                            listSaveLabReq.Add(item);
                        }
                        else
                        {
                            string item = string.Concat(new object[]
							{
								"insert into lab_test_master (TEST_NO,PRIORITY_INDICATOR,PATIENT_ID,VISIT_ID,NAME,NAME_PHONETIC,CHARGE_TYPE,SEX,AGE,RELEVANT_CLINIC_DIAG,SPECIMEN,NOTES_FOR_SPCM,REQUESTED_DATE_TIME,ORDERING_DEPT,ORDERING_PROVIDER,BED,AGE_TYPE,RESULT_STATUS) values( '",
								text,
								"',",
								this.chkBusy.Checked ? 1 : 0,
								",'",
								this.txtPatientId.Text,
								"',",
								EmrSysPubVar.getCurPatientVisitID(),
								",'",
								EmrSysPubVar.getCurPatientName(),
								"','",
								EmrSysPubVar.getCurPatientNamePhonetic(),
								"','",
								EmrSysPubVar.getCurPatientChargeType(),
								"','",
								EmrSysPubVar.getCurPatientSex(),
								"',",
								num,
								",'",
								this.m_pat_info.diag,
								"','",
								text7,
								"','",
								this.txtSpecimenMemo.Text,
								"',to_date('",
								EmrSysPubFunction.getServerNow(),
								"','YYYY-MM-DD HH24:MI:SS'),'",
								EmrSysPubVar.getDeptCode(),
								"','",
								EmrSysPubFunction.getUserName(EmrSysPubVar.getUserID(), true),
								"','",
								EmrSysPubVar.getCurPatientBedNo(),
								"','",
								text3,
								"','1')"
							});
                            listSaveLabReq.Add(item);
                        }
                        string item2 = string.Concat(new string[]
						{
							"insert into lab_sheet_printed(test_no,printed,sheet) values('",
							text,
							"','0','",
							this.strSheetTitle,
							"')"
						});
                        listSaveLabReq.Add(item2);
                        if (dataRow["ROOM"] != DBNull.Value)
                        {
                            text5 = dataRow["ROOM"].ToString();
                        }
                        if (dataRow["RACK"] != DBNull.Value)
                        {
                            text6 = dataRow["RACK"].ToString();
                        }
                        string item3 = string.Concat(new string[]
						{
							"insert into lab_test_room_rack(test_no,sheet_title,room,rack) values('",
							text,
							"','",
							this.strSheetTitle,
							"','",
							text5,
							"','",
							text6,
							"')"
						});
                        listSaveLabReq.Add(item3);
                        flag = true;
                    }
                    string text9 = string.Empty;
                    if (this.chkCpBusy.Checked)
                    {
                        text9 = string.Concat(new object[]
						{
							"insert into doctor_orders (PATIENT_ID,VISIT_ID,ORDER_NO,ORDER_SUB_NO,ENTER_DATE_TIME,START_STOP_INDICATOR,REPEAT_INDICATOR,ORDER_CLASS,ORDER_TEXT,ORDER_CODE,ORDERING_DEPT,DOCTOR,ORDER_STATUS,PROCESSING_DATE_TIME,ORDER_PRINT_INDICATOR, RELATED_ORDER_NO,BILLING_ATTR,START_DATE_TIME,ADMINISTRATION) values( '",
							this.txtPatientId.Text,
							"',",
							EmrSysPubVar.getCurPatientVisitID(),
							",",
							orderNo,
							",",
							num2,
							",to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS'),0,0,'C','",
							dataRow["LAB_ITEM_NAME"].ToString(),
							"  急查','",
							dataRow["LAB_ITEM_CODE"].ToString(),
							"','",
							EmrSysPubVar.getDeptCode(),
							"','",
							EmrSysPubFunction.getUserName(EmrSysPubVar.getUserID(), true),
							"','1', to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS'),0,1,3,to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS')"
						});
                        text9 = text9 + ",'" + text7 + "')";
                    }
                    else
                    {
                        text9 = string.Concat(new object[]
						{
							"insert into doctor_orders (PATIENT_ID,VISIT_ID,ORDER_NO,ORDER_SUB_NO,ENTER_DATE_TIME,START_STOP_INDICATOR,REPEAT_INDICATOR,ORDER_CLASS,ORDER_TEXT,ORDER_CODE,ORDERING_DEPT,DOCTOR,ORDER_STATUS,PROCESSING_DATE_TIME,ORDER_PRINT_INDICATOR, RELATED_ORDER_NO,BILLING_ATTR,START_DATE_TIME,ADMINISTRATION) values( '",
							this.txtPatientId.Text,
							"',",
							EmrSysPubVar.getCurPatientVisitID(),
							",",
							orderNo,
							",",
							num2,
							",to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS'),0,0,'C','",
							dataRow["LAB_ITEM_NAME"].ToString(),
							"','",
							dataRow["LAB_ITEM_CODE"].ToString(),
							"','",
							EmrSysPubVar.getDeptCode(),
							"','",
							EmrSysPubFunction.getUserName(EmrSysPubVar.getUserID(), true),
							"','1', to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS'),0,1,3,to_date('",
							EmrSysPubFunction.getServerNow(),
							"','YYYY-MM-DD HH24:MI:SS')"
						});
                        text9 = text9 + ",'" + text7 + "')";
                    }
                    listSaveLabReq.Add(text9);
                    string item4 = string.Concat(new string[]
					{
						"insert into lab_test_items (TEST_NO,ITEM_NO,ITEM_NAME,ITEM_CODE) values ('",
						text,
						"',",
						dataRow["LAB_ITEM_NO"].ToString(),
						",'",
						dataRow["LAB_ITEM_NAME"].ToString(),
						"','",
						dataRow["LAB_ITEM_CODE"].ToString(),
						"')"
					});
                    listSaveLabReq.Add(item4);
                    string item5 = string.Concat(new object[]
					{
						"insert into lab_order_notes (TEST_NO,ORDER_START,PATIENT_ID,VISIT_ID,ORDER_NO,ORDER_SUB_NO,ITEM_CODE) values ('",
						text,
						"',to_date('",
						EmrSysPubFunction.getServerNow(),
						"','YYYY-MM-DD HH24:MI:SS'),'",
						this.txtPatientId.Text,
						"',",
						EmrSysPubVar.getCurPatientVisitID(),
						",",
						orderNo,
						",",
						num2,
						",'",
						dataRow["LAB_ITEM_CODE"].ToString(),
						"')"
					});
                    listSaveLabReq.Add(item5);
                    string text10 = "insert into emr_cp_patient_lab_vs_record(patient_id,visit_id,cp_id,cp_excute_node_index,test_no,item_no,item_name,item_code) values ('" + this.txtPatientId.Text;
                    object obj = text10;
                    text10 = string.Concat(new object[]
					{
						obj,
						"',",
						EmrSysPubVar.getCurPatientVisitID(),
						",",
						this.m_nCPID,
						",",
						this.m_nCPExcuteNodeIndex,
						",",
						text,
						",",
						dataRow["LAB_ITEM_NO"].ToString(),
						",'",
						dataRow["LAB_ITEM_NAME"].ToString(),
						"','",
						dataRow["LAB_ITEM_CODE"].ToString(),
						"')"
					});
                    listCpLabReq.Add(text10);
                    orderNo++;
                }
            }
        }
        private void cpbtnNo_Click(object sender, EventArgs e)
        {
            if (this.gvLabList.DataRowCount > 0)
            {
                for (int i = 0; i < this.gvLabList.DataRowCount; i++)
                {
                    this.gvLabList.GetDataRow(i)["CHOOSE_FLAG"] = 0m;
                }
            }
        }
        private void cpbtnAll_Click(object sender, EventArgs e)
        {
            if (this.gvLabList.DataRowCount > 0)
            {
                for (int i = 0; i < this.gvLabList.DataRowCount; i++)
                {
                    this.gvLabList.GetDataRow(i)["CHOOSE_FLAG"] = 1m;
                }
            }
        }
        private void gvLabList_ShowingEditor(object sender, CancelEventArgs e)
        {
            int focusedRowHandle = this.gvLabList.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                DataRow dataRow = this.gvLabList.GetDataRow(focusedRowHandle);
                DataRow[] array = this.m_dtCpLabApply.Select(string.Concat(new object[]
				{
					"ITEM_CODE='",
					dataRow["LAB_ITEM_CODE"],
					"' AND ITEM_NO=",
					dataRow["LAB_ITEM_NO"]
				}));
                if (array.Length > 0)
                {
                    e.Cancel = true;
                }
            }
        }
        private void gvLabList_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            int focusedRowHandle = this.gvLabList.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                DataRow dataRow = this.gvLabList.GetDataRow(focusedRowHandle);
                DataRow[] array = this.m_dtCpLabApply.Select(string.Concat(new object[]
				{
					"ITEM_CODE='",
					dataRow["LAB_ITEM_CODE"],
					"' AND ITEM_NO=",
					dataRow["LAB_ITEM_NO"]
				}));
                if (array.Length > 0)
                {
                    e.Appearance.BackColor = Color.Green;
                }
            }
        }
		
    }
}
