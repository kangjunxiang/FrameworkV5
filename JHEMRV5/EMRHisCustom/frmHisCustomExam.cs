using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmHisCustomExam : DevExpress.XtraEditors.XtraForm
    {
        private string m_strDBConnet = "HISConnect";
        private DataTable m_dtReqItems = new DataTable();
        private int m_nFlag = -1;
        private DataTable m_dtReqPrint = new DataTable();
        private DataTable m_dtInfo = new DataTable();
        private DataTable m_dtExam = new DataTable();
        public frmHisCustomExam()
        {
            InitializeComponent();
        }
        private void frmHisCustomExam_Load(object sender, EventArgs e)
        {
            if (!this.FillPatInfo())
            {
                MessageBox.Show("该病人已经出院或者没有选中病人，不能进行检查申请！");
                base.Close();
            }
            else
            {
                this.rgpClass.SelectedIndex = 1;
                this.FillcmbSc();
                this.FillgvReqItems();
                this.FillReqPrint();
                for (int i = 0; i <= 1; i++)
                {
                    this.m_dtInfo.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                    this.m_dtExam.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                }
            }
        }
        private void FillReqPrint()
        {
            string sQLString = "select ROWID as NO,ITEM_SUB_CLASS,PART,ITEM_NAME from APPL_ITEM_DICT  where item_name=''";
            this.m_dtReqPrint = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
        }
        private void FillgvReqItems()
        {
            string sQLString = "select ROWID as NO,a.*,'' as DEPT_NAME,0 as COST from APPL_ITEM_DICT a where a.item_name=''";
            this.m_dtReqItems = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            this.gcReqItems.DataSource = this.m_dtReqItems;
        }
        private bool FillPatInfo()
        {
            bool result;
            if (EmrSysPubVar.getCurPatientID().Length < 1 || EmrSysPubVar.getCurVisitDischargeDateTime() != DateTime.MinValue)
            {
                result = false;
            }
            else
            {
                this.lblWard.Text = string.Concat(new object[]
				{
					EmrSysPubFunction.getDeptName(EmrSysPubVar.getCurPatientDeptCode(), false),
					" ",
					EmrSysPubVar.getCurPatientBedNo(),
					"床"
				});
                this.lblName.Text = "姓名：" + EmrSysPubVar.getCurPatientName();
                this.lblID.Text = "ID：" + EmrSysPubVar.getCurPatientID();
                this.lblSex.Text = "性别：" + EmrSysPubVar.getCurPatientSex();
                this.lblDoct.Text = "主管医生：" + EmrSysPubFunction.getUserName(EmrSysPubVar.getCurPatientDoctorInCharge(), false);
                result = true;
            }
            return result;
        }
        private void FillcmbSc()
        {
            string sQLString = "  SELECT DISTINCT ITEM_SUB_CLASS FROM APPL_ITEM_DICT WHERE ITEM_CLASS= '检查' ";
            DataTable dataTable = new DataTable();
            dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (dataTable.Rows.Count < 1)
            {
                MessageBox.Show("检索子分类出错!", "提示");
            }
            else
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    this.cmbSc.Items.Add(dataRow["ITEM_SUB_CLASS"].ToString());
                }
            }
        }
        private string CreateExamItemTree(ref TreeView trTree, int nFlag)
        {
            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();
            DataTable dataTable3 = new DataTable();
            DataTable dataTable4 = new DataTable();
            string text = "";
            string text2 = "";
            string text3 = "";
            int num = 0;
            int nOutpOrInp = 0;
            switch (nFlag)
            {
                case 0:
                    num = 0;
                    nOutpOrInp = 2;
                    break;
                case 1:
                    num = 1;
                    nOutpOrInp = 2;
                    break;
                case 2:
                    num = 0;
                    nOutpOrInp = 1;
                    break;
                case 3:
                    num = 1;
                    nOutpOrInp = 1;
                    break;
            }
            string result;
            switch (num)
            {
                case 0:
                    {
                        dataTable = this.getMenuOrderByDept("%%", "检查", nOutpOrInp);
                        if (dataTable.Rows.Count < 1)
                        {
                            result = "该科室没有检索到定制套餐";
                            return result;
                        }
                        int num2 = 0;
                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            string text4 = dataRow["menu_name"].ToString();
                            string text5 = dataRow["menu_code"].ToString();
                            TreeNode treeNode = new TreeNode();
                            treeNode.Text = text4;
                            treeNode.Name = text5;
                            treeNode.Tag = text5;
                            treeNode.ImageIndex = 0;
                            treeNode.SelectedImageIndex = 0;
                            trTree.Nodes.Add(treeNode);
                            dataTable2 = this.getItemByMenu("检查", text5);
                            if (dataTable2.Rows.Count < 1)
                            {
                                result = "套餐" + text4 + "没有检索到项目";
                                return result;
                            }
                            foreach (DataRow dataRow2 in dataTable2.Rows)
                            {
                                TreeNode treeNode2 = new TreeNode();
                                treeNode2.Text = dataRow2["item_name"].ToString();
                                treeNode2.Name = dataRow2["item_code"].ToString();
                                treeNode2.Tag = dataRow2["ITEM_SUB_CLASS"].ToString();
                                treeNode.ImageIndex = 0;
                                treeNode2.SelectedImageIndex = 0;
                                trTree.Nodes[num2].Nodes.Add(treeNode2);
                            }
                            num2++;
                        }
                        break;
                    }
                case 1:
                    {
                        dataTable3 = this.getItemList("检查", nOutpOrInp);
                        if (dataTable3.Rows.Count < 1)
                        {
                            result = "该科室没有检索到定制项目";
                            return result;
                        }
                        int num2 = 0;
                        int num3 = 0;
                        foreach (DataRow dataRow3 in dataTable3.Rows)
                        {
                            string text6 = dataRow3["item_sub_class"].ToString();
                            if (text6 != text || text == "")
                            {
                                TreeNode treeNode = new TreeNode();
                                treeNode.Text = text6;
                                treeNode.Name = text6;
                                treeNode.Tag = text6;
                                treeNode.ImageIndex = 0;
                                treeNode.SelectedImageIndex = 0;
                                trTree.Nodes.Add(treeNode);
                                text = text6;
                                num2++;
                                num3 = 0;
                                text2 = "";
                            }
                            string text7 = dataRow3["part"].ToString();
                            if (text7 != text2 || text2 == "")
                            {
                                TreeNode treeNode2 = new TreeNode();
                                treeNode2.Text = text7;
                                treeNode2.Name = text7;
                                treeNode2.Tag = text7;
                                treeNode2.ImageIndex = 0;
                                treeNode2.SelectedImageIndex = 0;
                                trTree.Nodes[num2 - 1].Nodes.Add(treeNode2);
                                text2 = text7;
                                num3++;
                                text3 = "";
                            }
                            string text8 = dataRow3["item_name"].ToString();
                            if (text8 != text3 || text3 == "")
                            {
                                TreeNode treeNode3 = new TreeNode();
                                treeNode3.Text = text8;
                                treeNode3.Name = dataRow3["item_code"].ToString();
                                treeNode3.Tag = dataRow3["ITEM_SUB_CLASS"].ToString();
                                treeNode3.ImageIndex = 0;
                                treeNode3.SelectedImageIndex = 0;
                                trTree.Nodes[num2 - 1].Nodes[num3 - 1].Nodes.Add(treeNode3);
                                text3 = text8;
                            }
                        }
                        break;
                    }
            }
            result = "成功";
            return result;
        }
        private DataTable getMenuOrderByDept(string strDeptCode, string strMenuClass, int nOutpOrInp)
        {
            string sQLString = string.Concat(new string[]
			{
				"  SELECT DISTINCT a.MENU_CLASS,a.MENU_NAME,a.MENU_CODE FROM APPL_GROUP_DICT a,APPL_ORDER_BY_DICT b WHERE ( b.COMP_CODE = a.MENU_CODE ) and   ( ( b.ORDERED_BY like '",
				strDeptCode,
				"' ) AND   ( b.PROPERTIY = ",
				nOutpOrInp.ToString(),
				" ) AND   ( a.MENU_CLASS = '",
				strMenuClass,
				"' ) AND   ( b.INDICATOR = 2 ) )  "
			});
            DataTable dataTable = new DataTable();
            return DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
        }
        private DataTable getItemByMenu(string strMenuClass, string strMenuCode)
        {
            string sQLString = string.Concat(new string[]
			{
				"  SELECT a.ITEM_NO,b.ITEM_NAME,b.ITEM_CODE,b.ITEM_SUB_CLASS,b.PART,b.ROOMNO,b.NOTICE,b.PERFORMED_BY  FROM APPL_GROUP_DICT a,APPL_ITEM_DICT b  WHERE ( a.ITEM_CODE = b.ITEM_CODE ) and  ( b.ITEM_CLASS = a.ITEM_CLASS ) and   ( ( a.MENU_CLASS = '",
				strMenuClass,
				"' ) AND (a.MENU_CODE='",
				strMenuCode,
				"'))"
			});
            DataTable dataTable = new DataTable();
            return DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
        }
        private DataTable getItemList(string strItemClass, int nOutpOrInp)
        {
            string sQLString = string.Concat(new string[]
			{
				"SELECT DISTINCT a.CLINIC_ITEM_CLASS,a.ITEM_CLASS,a.ITEM_NAME,a.ITEM_CODE,a.ITEM_SUB_CLASS,a.PART,a.PERFORMED_BY,a.NOTICE,a.ROOMNO,a.INPUT_CODE FROM APPL_ITEM_DICT a,APPL_ORDER_BY_DICT b  WHERE ( b.COMP_CODE = a.ITEM_CODE ) and   ( ( b.PROPERTIY = ",
				nOutpOrInp.ToString(),
				" ) AND   ( a.ITEM_CLASS = '",
				strItemClass,
				"' ) AND   ( b.INDICATOR = 3 ) ) order by a.ITEM_SUB_CLASS,a.PART,a.ITEM_NAME "
			});
            DataTable dataTable = new DataTable();
            return DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
        }
        private DataTable getItemDetail(string strDeptCode, string strItemClass, int nOutpOrInp, string strSubClass, string strPart, string strInputCode)
        {
            string sQLString = string.Concat(new string[]
			{
				" SELECT a.CLINIC_ITEM_CLASS,a.ITEM_CLASS,a.ITEM_SUB_CLASS,a.PART,a.ITEM_NAME,a.ITEM_CODE,a.PERFORMED_BY,a.NOTICE,a.PROPERTIY,a.ROOMNO,a.INPUT_CODE  FROM APPL_ITEM_DICT a,APPL_ORDER_BY_DICT b  WHERE ( b.COMP_CODE = a.ITEM_CODE ) and   ( ( b.ORDERED_BY = '",
				strDeptCode,
				"' ) AND   ( b.PROPERTIY = ",
				nOutpOrInp.ToString(),
				" ) AND   ( a.ITEM_CLASS = '",
				strItemClass,
				"' ) AND   ( a.ITEM_SUB_CLASS = '",
				strSubClass,
				"' ) AND   ( a.PART = '",
				strPart,
				"' ) AND   ( a.INPUT_CODE like '",
				strInputCode,
				"' ) ) "
			});
            DataTable dataTable = new DataTable();
            return DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
        }
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void cmbSc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(this.cmbSc.Text == ""))
            {
                string sQLString = "SELECT DISTINCT PART FROM APPL_ITEM_DICT   WHERE ( ITEM_CLASS = '检查' ) AND  ( ITEM_SUB_CLASS = '" + this.cmbSc.Text + "' ) ";
                DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (dataTable.Rows.Count < 1)
                {
                    MessageBox.Show(this.cmbSc.Text + "子分类没有检索到相应的项目部位", "错误");
                }
                else
                {
                    this.cmbPart.Items.Clear();
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        this.cmbPart.Items.Add(dataRow["PART"].ToString());
                    }
                    this.cmbPart.SelectedIndex = 0;
                }
            }
        }
        private void txtItem_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                if (this.cmbSc.Text == "" || this.cmbPart.Text == "")
                {
                    MessageBox.Show("请先选择项目子分类和项目部位", "错误：");
                }
                else
                {
                    this.txtItem.Text = "";
                    foreach (Control control in base.Controls)
                    {
                        if (control.Name == "input")
                        {
                            return;
                        }
                    }
                    UCInput instance = UCInput.GetInstance();
                    instance.setOwner(this.groupBox1.Controls, (TextBox)sender);
                    instance.loadData("ITEMCLASS", this.cmbSc.Text, this.cmbPart.Text);
                    instance.Name = "input";
                    this.groupBox1.Controls.Add(instance);
                    this.groupBox1.Controls.SetChildIndex(instance, 0);
                    if (((TextBox)sender).Location.X + instance.Width < this.groupBox1.Width)
                    {
                        instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                    }
                    else
                    {
                        instance.Location = new Point(this.groupBox1.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                    }
                    instance.filter();
                    this.m_nFlag = 0;
                }
            }
        }
        private void txtItem_Enter(object sender, EventArgs e)
        {
            this.toolSSLabel.Text = "按F9调用拼音字典进行操作！";
        }
        private void txtItem_Leave(object sender, EventArgs e)
        {
            this.toolSSLabel.Text = "Ready";
        }
        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            if (this.m_nFlag != -1)
            {
                if (!(this.txtItem.Text == ""))
                {
                    int nFlag = this.m_nFlag;
                    if (nFlag != 1)
                    {
                        bool flag = true;
                        int count = this.m_dtReqItems.Rows.Count;
                        if (count > 0)
                        {
                            foreach (DataRow dataRow in this.m_dtReqItems.Rows)
                            {
                                if (dataRow["item_name"].ToString() == this.txtItem.Text)
                                {
                                    flag = false;
                                }
                            }
                        }
                        if (flag)
                        {
                            if (this.txtItem.Tag == null)
                            {
                                MessageBox.Show("选择项目不是选中的，不能添加！请重新选择添加项目！");
                                this.txtItem.Text = "";
                                this.txtItem.Focus();
                                return;
                            }
                            string sQLString = "select a.* from APPL_ITEM_DICT a where a.item_code='" + this.txtItem.Tag.ToString() + "'";
                            DataTable dataTable = new DataTable();
                            dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                            if (dataTable.Rows.Count > 0)
                            {
                                DataRow dataRow2 = this.m_dtReqItems.NewRow();
                                dataRow2["ITEM_NAME"] = dataTable.Rows[0]["ITEM_NAME"].ToString();
                                dataRow2["ITEM_CODE"] = this.txtItem.Tag.ToString();
                                dataRow2["NO"] = Convert.ToString(count + 1);
                                dataRow2["ITEM_SUB_CLASS"] = dataTable.Rows[0]["ITEM_SUB_CLASS"].ToString();
                                dataRow2["PART"] = dataTable.Rows[0]["PART"].ToString();
                                dataRow2["ITEM_CLASS"] = dataTable.Rows[0]["ITEM_CLASS"].ToString();
                                dataRow2["PERFORMED_BY"] = dataTable.Rows[0]["PERFORMED_BY"].ToString();
                                dataRow2["NOTICE"] = this.txtMemo.Text.Trim();
                                dataRow2["DEPT_NAME"] = EmrSysPubFunction.getDeptName(dataTable.Rows[0]["PERFORMED_BY"].ToString(), false);
                                dataRow2["COST"] = this.GetTotalPrice("D", this.txtItem.Tag.ToString());
                                this.m_dtReqItems.Rows.Add(dataRow2);
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("是否下达检查套餐『" + this.txtItem.Text + "』", "注意", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        {
                            return;
                        }
                        if (this.rgpClass.SelectedIndex == 1)
                        {
                            return;
                        }
                        if (this.tvExam.SelectedNode.Parent != null)
                        {
                            return;
                        }
                        for (int i = 0; i < this.tvExam.SelectedNode.Nodes.Count; i++)
                        {
                            this.txtItem.Tag = this.tvExam.SelectedNode.Nodes[i].Name.ToString();
                            this.txtItem.Text = this.tvExam.SelectedNode.Nodes[i].Text;
                            bool flag = true;
                            int count = this.m_dtReqItems.Rows.Count;
                            if (count > 0)
                            {
                                foreach (DataRow dataRow in this.m_dtReqItems.Rows)
                                {
                                    if (dataRow["item_name"].ToString() == this.txtItem.Text)
                                    {
                                        flag = false;
                                    }
                                }
                            }
                            if (flag)
                            {
                                string sQLString = "select a.* from APPL_ITEM_DICT a where a.item_code='" + this.txtItem.Tag.ToString() + "'";
                                DataTable dataTable = new DataTable();
                                dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                                if (dataTable.Rows.Count > 0)
                                {
                                    DataRow dataRow2 = this.m_dtReqItems.NewRow();
                                    dataRow2["ITEM_NAME"] = dataTable.Rows[0]["ITEM_NAME"].ToString();
                                    dataRow2["ITEM_CODE"] = this.txtItem.Tag.ToString();
                                    dataRow2["NO"] = Convert.ToString(count + 1);
                                    dataRow2["ITEM_SUB_CLASS"] = dataTable.Rows[0]["ITEM_SUB_CLASS"].ToString();
                                    dataRow2["PART"] = dataTable.Rows[0]["PART"].ToString();
                                    dataRow2["ITEM_CLASS"] = dataTable.Rows[0]["ITEM_CLASS"].ToString();
                                    dataRow2["PERFORMED_BY"] = dataTable.Rows[0]["PERFORMED_BY"].ToString();
                                    dataRow2["NOTICE"] = this.txtMemo.Text.Trim();
                                    dataRow2["DEPT_NAME"] = EmrSysPubFunction.getDeptName(dataTable.Rows[0]["PERFORMED_BY"].ToString(), false);
                                    dataRow2["COST"] = this.GetTotalPrice("D", this.txtItem.Tag.ToString());
                                    this.m_dtReqItems.Rows.Add(dataRow2);
                                }
                            }
                        }
                    }
                    this.txtItem.Text = "";
                    this.txtMemo.Text = "";
                }
            }
        }
        private double GetTotalPrice(string strClass, string strItemCode)
        {
            double num = 0.0;
            DataTable dataTable = new DataTable();
            string sQLString = string.Concat(new string[]
			{
				"  SELECT a.AMOUNT,b.PRICE  FROM CLINIC_VS_CHARGE a, PRICE_LIST b  WHERE ( a.CHARGE_ITEM_CODE = b.ITEM_CODE ) and ( a.CHARGE_ITEM_CLASS = b.ITEM_CLASS ) and  ( ( a.CLINIC_ITEM_CLASS = '",
				strClass,
				"' ) AND  ( a.CLINIC_ITEM_CODE = '",
				strItemCode,
				"' ) ) "
			});
            dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["PRICE"] != DBNull.Value && dataRow["AMOUNT"] != DBNull.Value)
                {
                    double num2 = Convert.ToDouble(dataRow["PRICE"].ToString());
                    long num3 = (long)Convert.ToInt32(dataRow["AMOUNT"].ToString());
                    num += num2 * (double)num3;
                }
            }
            return num;
        }
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (this.m_dtReqItems.Rows.Count >= 1)
            {
                if (MessageBox.Show("申请项目提交后不能修改，是否继续？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string text = "";
                    string text2 = "";
                    string text3 = "";
                    DataTable dataTable = new DataTable();
                    DataTable dataTable2 = new DataTable();
                    int num = 1;
                    frmMrDescribe frmMrDescribe = new frmMrDescribe();
                    string text4 = "";
                    string text5 = "";
                    string text6 = "";
                    string text7 = "";
                    string text8 = "";
                    if (frmMrDescribe.ShowDialog() == DialogResult.OK)
                    {
                        text4 = frmMrDescribe.m_strclin_symp;
                        text5 = frmMrDescribe.m_strphys_sign;
                        text6 = frmMrDescribe.m_strr_labtest;
                        text7 = frmMrDescribe.m_strr_diag;
                        text8 = frmMrDescribe.m_strExam_Purpose;
                    }
                    DataTable dataTable3 = new DataTable();
                    string sQLString = "select * from pat_master_index where patient_id='" + EmrSysPubVar.getCurPatientID() + "'";
                    dataTable3 = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                    if (dataTable3.Rows.Count < 1)
                    {
                        MessageBox.Show("PAT_MASTER不存在该病人信息！");
                    }
                    else
                    {
                        DataRow dataRow = dataTable3.Rows[0];
                        foreach (DataRow dataRow2 in this.m_dtReqItems.Rows)
                        {
                            string text9 = dataRow2["ITEM_SUB_CLASS"].ToString();
                            bool flag;
                            if (text9 != text3 || text3 == "")
                            {
                                if (this.m_dtReqPrint.Rows.Count > 0 && this.chkPrint.Checked)
                                {
                                    frmPrint frmPrint = new frmPrint();
                                    this.m_dtExam.Rows.Clear();
                                    for (int i = 1; i <= 8; i++)
                                    {
                                        DataRow dataRow3 = this.m_dtExam.NewRow();
                                        dataRow3[0] = "[序号" + Convert.ToString(i) + "]";
                                        dataRow3[1] = " ";
                                        this.m_dtExam.Rows.Add(dataRow3);
                                        DataRow dataRow4 = this.m_dtExam.NewRow();
                                        dataRow4[0] = "[子分类" + Convert.ToString(i) + "]";
                                        dataRow4[1] = " ";
                                        this.m_dtExam.Rows.Add(dataRow4);
                                        DataRow dataRow5 = this.m_dtExam.NewRow();
                                        dataRow5[0] = "[部位" + Convert.ToString(i) + "]";
                                        dataRow5[1] = " ";
                                        this.m_dtExam.Rows.Add(dataRow5);
                                        DataRow dataRow6 = this.m_dtExam.NewRow();
                                        dataRow6[0] = "[项目" + Convert.ToString(i) + "]";
                                        dataRow6[1] = " ";
                                        this.m_dtExam.Rows.Add(dataRow6);
                                    }
                                    for (int j = 0; j < this.m_dtReqPrint.Rows.Count; j++)
                                    {
                                        this.m_dtExam.Rows[j + j * 4][1] = Convert.ToString(j + 1);
                                        this.m_dtExam.Rows[j + 1 + j * 4][1] = this.m_dtReqPrint.Rows[j]["ITEM_SUB_CLASS"].ToString();
                                        this.m_dtExam.Rows[j + 2 + j * 4][1] = this.m_dtReqPrint.Rows[j]["PART"].ToString();
                                        this.m_dtExam.Rows[j + 3 + j * 4][1] = this.m_dtReqPrint.Rows[j]["ITEM_NAME"].ToString();
                                    }
                                    frmPrint.PrintLabExam("检查申请单", this.m_dtInfo, this.m_dtExam);
                                    this.m_dtReqPrint.Rows.Clear();
                                }
                                sQLString = "select test_no.nextval test_no from dual";
                                object single = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
                                if (single != null)
                                {
                                    text = single.ToString();
                                }
                                if (text.Length < 4)
                                {
                                    switch (text.Length)
                                    {
                                        case 1:
                                            text = "000" + text;
                                            break;
                                        case 2:
                                            text = "00" + text;
                                            break;
                                        case 3:
                                            text = "0" + text;
                                            break;
                                    }
                                }
                                text2 = DateTime.Now.ToString("yyMMdd") + text;
                                this.m_dtInfo.Rows.Clear();
                                DataRow dataRow7 = this.m_dtInfo.NewRow();
                                dataRow7[0] = "申请单号";
                                dataRow7[1] = "*" + text2 + "*";
                                this.m_dtInfo.Rows.Add(dataRow7);
                                DataRow dataRow8 = this.m_dtInfo.NewRow();
                                dataRow8[0] = "姓名";
                                dataRow8[1] = EmrSysPubVar.getCurPatientName();
                                this.m_dtInfo.Rows.Add(dataRow8);
                                DataRow dataRow9 = this.m_dtInfo.NewRow();
                                dataRow9[0] = "ID号";
                                dataRow9[1] = EmrSysPubVar.getCurPatientID();
                                this.m_dtInfo.Rows.Add(dataRow9);
                                DataRow dataRow10 = this.m_dtInfo.NewRow();
                                dataRow10[0] = "性别";
                                dataRow10[1] = EmrSysPubVar.getCurPatientSex();
                                this.m_dtInfo.Rows.Add(dataRow10);
                                DataRow dataRow11 = this.m_dtInfo.NewRow();
                                dataRow11[0] = "";
                                dataRow11[1] = "";
                                this.m_dtInfo.Rows.Add(dataRow11);
                                DataRow dataRow12 = this.m_dtInfo.NewRow();
                                dataRow12[0] = "出生日期";
                                dataRow12[1] = EmrSysPubVar.getCurPatientBirthDate().ToShortDateString();
                                this.m_dtInfo.Rows.Add(dataRow12);
                                DataRow dataRow13 = this.m_dtInfo.NewRow();
                                dataRow13[0] = "年龄";
                                dataRow13[1] = Convert.ToString(EmrSysPubFunction.getServerNow().Year - EmrSysPubVar.getCurPatientBirthDate().Year);
                                this.m_dtInfo.Rows.Add(dataRow13);
                                DataRow dataRow14 = this.m_dtInfo.NewRow();
                                dataRow14[0] = "费别";
                                dataRow14[1] = EmrSysPubVar.getCurPatientChargeType();
                                this.m_dtInfo.Rows.Add(dataRow14);
                                DataRow dataRow15 = this.m_dtInfo.NewRow();
                                dataRow15[0] = "工作单位";
                                dataRow15[1] = dataRow["mailing_address"].ToString();
                                this.m_dtInfo.Rows.Add(dataRow15);
                                DataRow dataRow16 = this.m_dtInfo.NewRow();
                                dataRow16[0] = "电话";
                                dataRow16[1] = dataRow["phone_number_home"].ToString();
                                this.m_dtInfo.Rows.Add(dataRow16);
                                DataRow dataRow17 = this.m_dtInfo.NewRow();
                                dataRow17[0] = "入院诊断";
                                dataRow17[1] = EmrSysPubVar.getCurPatientClinicDiag();
                                this.m_dtInfo.Rows.Add(dataRow17);
                                DataRow dataRow18 = this.m_dtInfo.NewRow();
                                dataRow18[0] = "申请科室";
                                dataRow18[1] = EmrSysPubFunction.getDeptName(EmrSysPubVar.getDeptCode(), false);
                                this.m_dtInfo.Rows.Add(dataRow18);
                                DataRow dataRow19 = this.m_dtInfo.NewRow();
                                dataRow19[0] = "申请时间";
                                dataRow19[1] = EmrSysPubFunction.getServerNow().ToString();
                                this.m_dtInfo.Rows.Add(dataRow19);
                                DataRow dataRow20 = this.m_dtInfo.NewRow();
                                dataRow20[0] = "开单医生";
                                dataRow20[1] = EmrSysPubFunction.getUserName(EmrSysPubVar.getDbUser(), false);
                                this.m_dtInfo.Rows.Add(dataRow20);
                                DataRow dataRow21 = this.m_dtInfo.NewRow();
                                dataRow21[0] = "症状";
                                dataRow21[1] = text4;
                                this.m_dtInfo.Rows.Add(dataRow21);
                                DataRow dataRow22 = this.m_dtInfo.NewRow();
                                dataRow22[0] = "体征";
                                dataRow22[1] = text5;
                                this.m_dtInfo.Rows.Add(dataRow22);
                                DataRow dataRow23 = this.m_dtInfo.NewRow();
                                dataRow23[0] = "化验";
                                dataRow23[1] = text6;
                                this.m_dtInfo.Rows.Add(dataRow23);
                                DataRow dataRow24 = this.m_dtInfo.NewRow();
                                dataRow24[0] = "检查";
                                dataRow24[1] = text7;
                                this.m_dtInfo.Rows.Add(dataRow24);
                                string value = " ";
                                if (dataRow2["ITEM_SUB_CLASS"].ToString() == "ＣＴ")
                                {
                                    value = "住院部主楼二层东侧放射科";
                                }
                                else
                                {
                                    if (dataRow2["ITEM_SUB_CLASS"].ToString() == "放射")
                                    {
                                        value = "门诊二楼中部放射科";
                                    }
                                    else
                                    {
                                        if (dataRow2["ITEM_SUB_CLASS"].ToString() == "磁共振")
                                        {
                                            value = "核磁共振楼";
                                        }
                                        else
                                        {
                                            if (dataRow2["ITEM_SUB_CLASS"].ToString() == "超声")
                                            {
                                                value = "住院部主楼二层东侧放射科";
                                            }
                                            else
                                            {
                                                if (dataRow2["ITEM_SUB_CLASS"].ToString() == "DSA")
                                                {
                                                    value = "住院部主楼二层西侧侧放射科";
                                                }
                                            }
                                        }
                                    }
                                }
                                DataRow dataRow25 = this.m_dtInfo.NewRow();
                                dataRow25[0] = "检查地点";
                                dataRow25[1] = value;
                                this.m_dtInfo.Rows.Add(dataRow25);
                                DataRow dataRow26 = this.m_dtInfo.NewRow();
                                dataRow26[0] = "预约时间";
                                dataRow26[1] = " ";
                                this.m_dtInfo.Rows.Add(dataRow26);
                                DataRow dataRow27 = this.m_dtInfo.NewRow();
                                dataRow27[0] = "检查目的";
                                dataRow27[1] = text8;
                                this.m_dtInfo.Rows.Add(dataRow27);
                                sQLString = string.Concat(new object[]
								{
									"insert into exam_appoints (exam_no,patient_id,name,name_phonetic,sex,date_of_birth,birth_place,identity,charge_type,mailing_address,zip_code,phone_number,exam_class,exam_sub_class,clin_symp,phys_sign,relevant_lab_test,relevant_diag,clin_diag,exam_mode,exam_group,performed_by,patient_source,facility,req_date_time,req_dept,req_physician,req_memo,scheduled_date,notice,costs,charges,visit_id,local_id_class,patient_local_id,exam_reason ) values('",
									text2,
									"','",
									EmrSysPubVar.getCurPatientID(),
									"','",
									EmrSysPubVar.getCurPatientName(),
									"','",
									EmrSysPubVar.getCurPatientNamePhonetic(),
									"','",
									EmrSysPubVar.getCurPatientSex(),
									"',TO_DATE('",
									EmrSysPubVar.getCurPatientBirthDate(),
									"','YYYY-MM-DD HH24:MI:SS'),'",
									dataRow["birth_place"].ToString(),
									"','",
									dataRow["identity"],
									"','",
									dataRow["charge_type"].ToString(),
									"','",
									dataRow["mailing_address"].ToString(),
									"','",
									dataRow["zip_code"].ToString(),
									"','",
									dataRow["phone_number_home"].ToString(),
									"','",
									dataRow2["ITEM_SUB_CLASS"].ToString(),
									"','",
									dataRow2["PART"].ToString(),
									"','",
									text4,
									"','",
									text5,
									"','",
									text6,
									"','",
									text7,
									"','",
									EmrSysPubVar.getCurPatientClinicDiag(),
									"','','','",
									dataRow2["PERFORMED_BY"].ToString(),
									"','2','',sysdate,'",
									EmrSysPubVar.getDeptCode(),
									"','",
									EmrSysPubFunction.getUserName(EmrSysPubVar.getDbUser(), false),
									"','",
									dataRow2["NOTICE"].ToString(),
									"',null,'','",
									dataRow2["COST"].ToString(),
									"','",
									dataRow2["COST"].ToString(),
									"','",
									EmrSysPubVar.getCurPatientVisitID(),
									"','','','",
									text8,
									"')"
								});
                                DALUseSpecial.ExecuteSql(sQLString, this.m_strDBConnet);
                                text3 = text9;
                                flag = true;
                            }
                            else
                            {
                                flag = false;
                            }
                            if (flag)
                            {
                                num = 1;
                            }
                            sQLString = string.Concat(new string[]
							{
								"insert into exam_items (exam_no,exam_item_no,exam_item,exam_item_code,costs) values('",
								text2,
								"','",
								num.ToString(),
								"','",
								dataRow2["item_name"].ToString(),
								"','",
								dataRow2["item_code"].ToString(),
								"','",
								dataRow2["COST"].ToString(),
								"')"
							});
                            DALUseSpecial.ExecuteSql(sQLString, this.m_strDBConnet);
                            DataRow dataRow28 = this.m_dtReqPrint.NewRow();
                            dataRow28["NO"] = num.ToString();
                            dataRow28["ITEM_SUB_CLASS"] = dataRow2["ITEM_SUB_CLASS"].ToString();
                            dataRow28["PART"] = dataRow2["PART"].ToString();
                            dataRow28["ITEM_NAME"] = dataRow2["ITEM_NAME"].ToString();
                            this.m_dtReqPrint.Rows.Add(dataRow28);
                            num++;
                        }
                        MessageBox.Show("提交成功,您可以在【检查单状态查看】中完成打印申请单，报告和撤销未预约申请。", "提示");
                        if (this.m_dtReqPrint.Rows.Count > 0 && this.chkPrint.Checked)
                        {
                            frmPrint frmPrint = new frmPrint();
                            this.m_dtExam.Rows.Clear();
                            for (int i = 1; i <= 8; i++)
                            {
                                DataRow dataRow3 = this.m_dtExam.NewRow();
                                dataRow3[0] = "[序号" + Convert.ToString(i) + "]";
                                dataRow3[1] = " ";
                                this.m_dtExam.Rows.Add(dataRow3);
                                DataRow dataRow4 = this.m_dtExam.NewRow();
                                dataRow4[0] = "[子分类" + Convert.ToString(i) + "]";
                                dataRow4[1] = " ";
                                this.m_dtExam.Rows.Add(dataRow4);
                                DataRow dataRow5 = this.m_dtExam.NewRow();
                                dataRow5[0] = "[部位" + Convert.ToString(i) + "]";
                                dataRow5[1] = " ";
                                this.m_dtExam.Rows.Add(dataRow5);
                                DataRow dataRow6 = this.m_dtExam.NewRow();
                                dataRow6[0] = "[项目" + Convert.ToString(i) + "]";
                                dataRow6[1] = " ";
                                this.m_dtExam.Rows.Add(dataRow6);
                            }
                            for (int j = 0; j < this.m_dtReqPrint.Rows.Count; j++)
                            {
                                this.m_dtExam.Rows[j + j * 4][1] = Convert.ToString(j + 1);
                                this.m_dtExam.Rows[j + 1 + j * 4][1] = this.m_dtReqPrint.Rows[j]["ITEM_SUB_CLASS"].ToString();
                                this.m_dtExam.Rows[j + 2 + j * 4][1] = this.m_dtReqPrint.Rows[j]["PART"].ToString();
                                this.m_dtExam.Rows[j + 3 + j * 4][1] = this.m_dtReqPrint.Rows[j]["ITEM_NAME"].ToString();
                            }
                            frmPrint.PrintLabExam("检查申请单", this.m_dtInfo, this.m_dtExam);
                            this.m_dtReqPrint.Rows.Clear();
                        }
                        this.FillgvReqItems();
                        this.txtItem.Text = "";
                        this.lblDetail.Text = "项目详情";
                    }
                }
            }
        }
        private void rgpClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.rgpClass.SelectedIndex)
            {
                case 0:
                    {
                        this.tvExam.Nodes.Clear();
                        string text = this.CreateExamItemTree(ref this.tvExam, 0);
                        if (text != "成功")
                        {
                            MessageBox.Show(text, "错误");
                        }
                        break;
                    }
                case 1:
                    {
                        this.tvExam.Nodes.Clear();
                        string text = this.CreateExamItemTree(ref this.tvExam, 1);
                        if (text != "成功")
                        {
                            MessageBox.Show(text, "错误");
                        }
                        break;
                    }
            }
        }
        private void tvExam_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvExam.SelectedNode != null)
            {
                int num = 0;
                if (e.Node.Parent == null)
                {
                    num = 1;
                }
                else
                {
                    if (e.Node.Parent.Parent == null)
                    {
                        num = 2;
                    }
                    else
                    {
                        if (e.Node.Parent.Parent.Parent == null)
                        {
                            num = 3;
                        }
                    }
                }
                switch (this.rgpClass.SelectedIndex)
                {
                    case 0:
                        switch (num)
                        {
                            case 1:
                                this.lblDetail.Text = "『项目详情』 套餐名称：" + e.Node.Text;
                                this.txtItem.Tag = e.Node.Name.ToString();
                                this.txtItem.Text = e.Node.Text;
                                this.m_nFlag = 1;
                                break;
                            case 2:
                                this.lblDetail.Text = "『项目详情』 项目子分类：" + e.Node.Tag.ToString() + "    项目名称：" + e.Node.Text;
                                this.txtItem.Tag = e.Node.Name.ToString();
                                this.txtItem.Text = e.Node.Text;
                                this.m_nFlag = 2;
                                break;
                        }
                        break;
                    case 1:
                        if (num == 3)
                        {
                            this.txtItem.Tag = e.Node.Name.ToString();
                            this.txtItem.Text = e.Node.Text;
                            this.lblDetail.Text = string.Concat(new string[]
						{
							"『项目详情』 项目子分类：",
							e.Node.Parent.Parent.Text,
							"  项目部位：",
							e.Node.Parent.Text,
							"  项目名称：",
							e.Node.Text
						});
                            for (int i = 0; i < this.cmbSc.Items.Count; i++)
                            {
                                if (this.cmbSc.Items[i].ToString() == e.Node.Parent.Parent.Text)
                                {
                                    this.cmbSc.SelectedIndex = i;
                                    break;
                                }
                            }
                            for (int i = 0; i < this.cmbPart.Items.Count; i++)
                            {
                                if (this.cmbPart.Items[i].ToString() == e.Node.Parent.Text)
                                {
                                    this.cmbPart.SelectedIndex = i;
                                    break;
                                }
                            }
                            this.m_nFlag = 3;
                        }
                        break;
                }
            }
        }
        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            if (this.gvReqItems.SelectedRowsCount < 0)
            {
                MessageBox.Show("没有选中项目,请选中项目再进行删除");
            }
            else
            {
                this.m_dtReqItems.Rows.RemoveAt(this.gvReqItems.FocusedRowHandle);
                int num = 1;
                foreach (DataRow dataRow in this.m_dtReqItems.Rows)
                {
                    dataRow["NO"] = num.ToString();
                    num++;
                }
            }
        }
        private void gvReqItems_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                try
                {
                    if (e.RowHandle > 0)
                    {
                        if (this.gvReqItems.GetDataRow(e.RowHandle)["ITEM_SUB_CLASS"].ToString() == this.gvReqItems.GetDataRow(e.RowHandle - 1)["ITEM_SUB_CLASS"].ToString() && e.Column.FieldName == "ITEM_SUB_CLASS")
                        {
                            e.DisplayText = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
            }
        }
        private void sbtnLook_Click(object sender, EventArgs e)
        {
            frmHisCustomExamQuery frmHisCustomExamQuery = new frmHisCustomExamQuery();
            frmHisCustomExamQuery.ShowDialog();
        }
        private void frmHisCustomExam_Shown(object sender, EventArgs e)
        {
            this.cmbSc.Focus();
        }
    }
}