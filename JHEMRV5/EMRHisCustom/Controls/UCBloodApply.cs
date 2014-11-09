using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using System.Runtime.InteropServices;
using DevExpress.XtraGrid.Views.Base;
using JHEMR.EmrSysDAL;
using EmrSysWebservices;

namespace JHEMR.EMRHisCustom
{
    public partial class UCBloodApply : UserControl, EmrEditUCInterface
    {
        private string m_strDBConnet = "HISConnect";
        private DataTable m_dtPatVisitBlood = new DataTable();
        private DataTable m_dtBloodCapacity = new DataTable();
        private DataTable m_dtBloodApply = new DataTable();
        private DataTable m_dtBloodTypeDict = new DataTable();
        private DataTable m_dtBloodFastSlow = new DataTable();
        private DataTable m_dtBloodUnit = new DataTable();
        private int m_nVisitID = 1;
        private int m_nRole = 0;
        public string IsUpdate = "";
        public UCBloodApply()
        {
            InitializeComponent();
        }

        [DllImport("notice.dll")]
        public static extern bool MessageNotice(string MarchineName, string mesg);
        public new void Update()
        {
            this.IsUpdate = "UPDATE";
        }
        private void UCBloodApply_Load(object sender, EventArgs e)
        {
            if (EmrSysPubVar.getCurVisitDischargeDateTime() > EmrSysPubVar.getCurVisitAdmissionDateTime())
            {
                foreach (Control control in base.Controls)
                {
                    control.Enabled = false;
                }
            }
            else
            {
                this.cmbRH.SelectedIndex = 1;
                this.cmbBLOOD_HISTORY.SelectedIndex = 1;
                this.cmbBLOOD_PURPOSE.SelectedIndex = 1;
                string sQLString = "select role_value from users_vs_app_special_role a,app_special_role b where b.app_special_role_id=a.app_special_role_id and b.application='DOCTWS' and a.user_id='" + EmrSysPubVar.getUserID() + "'";
                object single = DALUse.GetSingle(sQLString);
                if (single != null)
                {
                    this.m_nRole = Convert.ToInt32(single.ToString());
                }
                if (this.m_nRole > 1)
                {
                    this.sptnConfirm.Enabled = true;
                }
                this.FillPatVisitBlood();
                this.FillBloodCapacity();
                this.FillBloodTypeDict();
                if (this.IsUpdate.Length < 1)
                {
                    this.spbtnNewApply_Click(sender, e);
                }
                if (this.txtPAT_SEX.Text == "男")
                {
                    this.txtBlood_Gestation.Enabled = false;
                }
                if (this.cmbBLOOD_HISTORY.Text == "无" || this.cmbBLOOD_HISTORY.Text == "")
                {
                    this.txtBLOOD_TABOO.Enabled = false;
                }
                try
                {
                    string text = EmrSysWebservicesUse.myEmrGenralStr(new string[]
					{
						"BLOODAPPLYLIS",
						"HGB",
						EmrSysPubVar.getCurPatientID(),
						EmrSysPubVar.getCurPatientVisitID().ToString()
					});
                    if (text != "")
                    {
                        this.txtHEMATIN.Text = text;
                    }
                    text = EmrSysWebservicesUse.myEmrGenralStr(new string[]
					{
						"BLOODAPPLYLIS",
						"PLT",
						EmrSysPubVar.getCurPatientID(),
						EmrSysPubVar.getCurPatientVisitID().ToString()
					});
                    if (text != "")
                    {
                        this.txtPLATELET.Text = text;
                    }
                    text = EmrSysWebservicesUse.myEmrGenralStr(new string[]
					{
						"BLOODAPPLYLIS",
						"HCT",
						EmrSysPubVar.getCurPatientID(),
						EmrSysPubVar.getCurPatientVisitID().ToString()
					});
                    if (text != "")
                    {
                        this.txtHCT.Text = text;
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }
        private void FillPatVisitBlood()
        {
            string sQLString = string.Concat(new string[]
			{
				"select * from blood_apply  where apply_date>to_date('",
				EmrSysPubVar.getCurVisitAdmissionDateTime().ToString(),
				"','YYYY-MM-DD HH24:MI:SS') and patient_id='",
				EmrSysPubVar.getCurPatientID(),
				"' order by apply_date desc"
			});
            DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                this.txtAPPLY_NUM.Text = dataRow["APPLY_NUM"].ToString();
                if (dataRow["GATHER_DATE"] != DBNull.Value)
                {
                    this.dtpGATHER_DATE.Text = dataRow["GATHER_DATE"].ToString();
                }
                this.txtPATIENT_ID.Text = dataRow["PATIENT_ID"].ToString();
                this.txtINP_NO.Text = dataRow["INP_NO"].ToString();
                this.txtCHARGE_TYPE.Text = EmrSysPubVar.getCurPatientChargeType();
                if (dataRow["DEPT_CODE"] != DBNull.Value)
                {
                    this.txtDEPT_CODE.Tag = dataRow["DEPT_CODE"].ToString();
                    this.txtDEPT_CODE.Text = EmrSysPubFunction.getDeptName(dataRow["DEPT_CODE"].ToString(), false);
                }
                if (dataRow["PAT_NAME"] != DBNull.Value)
                {
                    this.txtPAT_NAME.Text = dataRow["PAT_NAME"].ToString();
                }
                if (dataRow["PAT_SEX"] != DBNull.Value)
                {
                    this.txtPAT_SEX.Text = dataRow["PAT_SEX"].ToString();
                }
                if (dataRow["BIRTHDAY"] != DBNull.Value)
                {
                    this.txtBIRTHDAY.Text = dataRow["BIRTHDAY"].ToString();
                }
                if (dataRow["PAT_SOURCE"] != DBNull.Value)
                {
                    this.cmbPAT_SOURCE.Text = dataRow["PAT_SOURCE"].ToString();
                }
                if (dataRow["PAT_BLOOD_GROUP"] != DBNull.Value)
                {
                    this.cmbPAT_BLOOD_GROUP.Text = dataRow["PAT_BLOOD_GROUP"].ToString();
                }
                if (dataRow["RH"] != DBNull.Value)
                {
                    this.cmbRH.Text = dataRow["RH"].ToString();
                }
                if (dataRow["BLOOD_INUSE"] != DBNull.Value)
                {
                    this.cmbBLOOD_INUSE.Text = dataRow["BLOOD_INUSE"].ToString();
                }
                if (dataRow["BLOOD_HISTORY"] != DBNull.Value)
                {
                    this.cmbBLOOD_HISTORY.SelectedIndex = Convert.ToInt32(dataRow["BLOOD_HISTORY"].ToString());
                }
                if (dataRow["APPLY_DATE"] != DBNull.Value)
                {
                    this.dtpAPPLY_DATE.Text = dataRow["APPLY_DATE"].ToString();
                }
                if (dataRow["BLOOD_DIAGNOSE"] != DBNull.Value)
                {
                    this.txtBLOOD_DIAGNOSE.Text = dataRow["BLOOD_DIAGNOSE"].ToString();
                }
                if (dataRow["BLOOD_TABOO"] != DBNull.Value)
                {
                    this.txtBLOOD_TABOO.Text = dataRow["BLOOD_TABOO"].ToString();
                }
                if (dataRow["HEMATIN"] != DBNull.Value)
                {
                    this.txtHEMATIN.Text = dataRow["HEMATIN"].ToString();
                }
                if (dataRow["PLATELET"] != DBNull.Value)
                {
                    this.txtPLATELET.Text = dataRow["PLATELET"].ToString();
                }
                if (dataRow["LEUCOCYTE"] != DBNull.Value)
                {
                    this.txtHCT.Text = dataRow["LEUCOCYTE"].ToString();
                }
                if (dataRow["DIRECTOR"] != DBNull.Value)
                {
                    this.txtDIRECTOR.Text = dataRow["DIRECTOR"].ToString();
                }
                if (dataRow["DOCTOR"] != DBNull.Value)
                {
                    this.txtDOCTOR.Text = dataRow["DOCTOR"].ToString();
                }
                if (dataRow["BLOOD_PURPOSE"] != DBNull.Value)
                {
                    this.cmbBLOOD_PURPOSE.Text = dataRow["BLOOD_PURPOSE"].ToString();
                }
                if (dataRow["BLOOD_Gestation"] != DBNull.Value)
                {
                    this.txtBlood_Gestation.Text = dataRow["BLOOD_Gestation"].ToString();
                }
                if (dataRow["BLOOD_ELSE"] != DBNull.Value)
                {
                    this.txtElse.Text = dataRow["BLOOD_ELSE"].ToString();
                }
                if (dataRow["CONFIRM_FLAG"].ToString() == "1")
                {
                    this.sbtnPrint.Enabled = true;
                }
            }
            else
            {
                sQLString = "SELECT *  FROM BLOOD_RESULT WHERE ( ITEM_NO = 1 ) AND (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "') order by ITEM_SUB_NO";
                this.m_dtPatVisitBlood = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (this.m_dtPatVisitBlood.Rows.Count > 0)
                {
                    this.cmbPAT_BLOOD_GROUP.Text = ((this.m_dtPatVisitBlood.Rows[0]["EXAM_RESULT"] == DBNull.Value) ? "" : this.m_dtPatVisitBlood.Rows[0]["EXAM_RESULT"].ToString());
                    this.cmbRH.Text = ((this.m_dtPatVisitBlood.Rows[1]["EXAM_RESULT"] == DBNull.Value) ? "" : this.m_dtPatVisitBlood.Rows[0]["EXAM_RESULT"].ToString());
                }
                this.txtPATIENT_ID.Text = EmrSysPubVar.getCurPatientID();
                this.txtPAT_NAME.Text = EmrSysPubVar.getCurPatientName();
                this.txtPAT_SEX.Text = EmrSysPubVar.getCurPatientSex();
                this.txtINP_NO.Text = EmrSysPubVar.getCurPatientInpNo();
                this.txtDEPT_CODE.Text = EmrSysPubVar.getDeptName();
                this.txtDEPT_CODE.Tag = EmrSysPubVar.getDeptCode();
                this.txtBIRTHDAY.Text = EmrSysPubVar.getCurPatientBirthDate().ToString();
                this.dtpAPPLY_DATE.Text = EmrSysPubFunction.getServerNow().ToString();
                this.txtCHARGE_TYPE.Text = EmrSysPubVar.getCurPatientChargeType();
                this.txtBLOOD_DIAGNOSE.Text = EmrSysPubVar.getCurPatientClinicDiag();
                this.txtDOCTOR.Text = EmrSysPubVar.getOperator();
                if (this.m_nRole > 1)
                {
                    this.txtPHYSICIAN.Text = EmrSysPubVar.getOperator();
                }
                if (this.m_nRole > 2)
                {
                    this.txtDIRECTOR.Text = EmrSysPubVar.getOperator();
                }
                this.cmbPAT_SOURCE.SelectedIndex = 0;
                this.cmbBLOOD_INUSE.SelectedIndex = 0;
            }
        }
        private void FillPatVisitBloodNew()
        {
            string sQLString = "SELECT *  FROM BLOOD_RESULT WHERE ( ITEM_NO = 1 ) AND (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "') order by ITEM_SUB_NO";
            this.m_dtPatVisitBlood = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (this.m_dtPatVisitBlood.Rows.Count > 0)
            {
                this.cmbPAT_BLOOD_GROUP.Text = ((this.m_dtPatVisitBlood.Rows[0]["EXAM_RESULT"] == DBNull.Value) ? "" : this.m_dtPatVisitBlood.Rows[0]["EXAM_RESULT"].ToString());
                this.cmbRH.Text = ((this.m_dtPatVisitBlood.Rows[1]["EXAM_RESULT"] == DBNull.Value) ? "" : this.m_dtPatVisitBlood.Rows[0]["EXAM_RESULT"].ToString());
            }
            this.txtPATIENT_ID.Text = EmrSysPubVar.getCurPatientID();
            this.txtPAT_NAME.Text = EmrSysPubVar.getCurPatientName();
            this.txtPAT_SEX.Text = EmrSysPubVar.getCurPatientSex();
            this.txtINP_NO.Text = EmrSysPubVar.getCurPatientInpNo();
            this.txtCHARGE_TYPE.Text = EmrSysPubVar.getCurVisitChargeType();
            this.txtDEPT_CODE.Text = EmrSysPubVar.getDeptName();
            this.txtDEPT_CODE.Tag = EmrSysPubVar.getDeptCode();
            this.txtBIRTHDAY.Text = EmrSysPubVar.getCurPatientBirthDate().ToString();
            this.dtpAPPLY_DATE.Text = EmrSysPubFunction.getServerNow().ToString();
            this.txtCHARGE_TYPE.Text = EmrSysPubVar.getCurPatientChargeType();
            this.txtBLOOD_DIAGNOSE.Text = EmrSysPubVar.getCurPatientClinicDiag();
            this.txtDOCTOR.Text = EmrSysPubVar.getOperator();
            if (this.m_nRole > 1)
            {
                this.txtPHYSICIAN.Text = EmrSysPubVar.getOperator();
            }
            if (this.m_nRole > 2)
            {
                this.txtDIRECTOR.Text = EmrSysPubVar.getOperator();
            }
            this.cmbPAT_SOURCE.SelectedIndex = 0;
            this.cmbBLOOD_INUSE.SelectedIndex = 0;
        }
        private void FillBloodTypeDict()
        {
            string sQLString = "select blood_type ,blood_type_name  from BLOOD_COMPONENT where blood_match=1";
            this.m_dtBloodTypeDict = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            this.m_dtBloodTypeDict.Columns[0].ColumnName = "代码";
            this.m_dtBloodTypeDict.Columns[1].ColumnName = "名称";
            if (this.m_dtBloodTypeDict.Rows.Count > 0)
            {
                this.repositoryItemLookUpEdit1.DataSource = this.m_dtBloodTypeDict;
            }
            this.m_dtBloodFastSlow.Columns.Add(new DataColumn("名称"));
            this.m_dtBloodFastSlow.Columns.Add(new DataColumn("代码"));
            DataRow dataRow = this.m_dtBloodFastSlow.NewRow();
            dataRow["名称"] = "急诊";
            dataRow["代码"] = "1";
            this.m_dtBloodFastSlow.Rows.Add(dataRow);
            DataRow dataRow2 = this.m_dtBloodFastSlow.NewRow();
            dataRow2["名称"] = "计划";
            dataRow2["代码"] = "2";
            this.m_dtBloodFastSlow.Rows.Add(dataRow2);
            DataRow dataRow3 = this.m_dtBloodFastSlow.NewRow();
            dataRow3["名称"] = "备血";
            dataRow3["代码"] = "3";
            this.m_dtBloodFastSlow.Rows.Add(dataRow3);
            this.repositoryItemLookUpEdit2.DataSource = this.m_dtBloodFastSlow;
            this.m_dtBloodUnit.Columns.Add(new DataColumn("单位"));
            DataRow dataRow4 = this.m_dtBloodUnit.NewRow();
            dataRow4["单位"] = "ml";
            this.m_dtBloodUnit.Rows.Add(dataRow4);
            this.repositoryItemLookUpEdit3.DataSource = this.m_dtBloodUnit;
        }
        private void FillBloodCapacity()
        {
            string sQLString = "SELECT a.FAST_SLOW,a.TRANS_DATE,a.TRANS_CAPACITY,a.APPLY_NUM,a.BLOOD_TYPE, a.MATCH_SUB_NUM,a.OPERATOR,b.BLOOD_TYPE_NAME,b.UNIT  FROM BLOOD_CAPACITY a , BLOOD_COMPONENT b WHERE (a.BLOOD_TYPE = b.BLOOD_TYPE) and ((a.APPLY_NUM= '" + this.txtAPPLY_NUM.Text + "') and (b.BLOOD_MATCH = '1' ))  ";
            this.m_dtBloodCapacity = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            this.gcBLOODCAPACITY.DataSource = this.m_dtBloodCapacity;
        }
        private void FillBloodApply()
        {
            string sQLString = "SELECT  APPLY_NUM,INP_NO,PATIENT_ID,DEPT_CODE,PAT_NAME,PAT_SEX,BIRTHDAY,FEE_TYPE,PAT_SOURCE,BLOOD_PAPER,BLOOD_INUSE, BLOOD_TABOO,HEMATIN,PLATELET,LEUCOCYTE,PAT_BLOOD_GROUP,RH,BLOOD_SUM,APPLY_DATE,GATHER_DATE,DIRECTOR,PHYSICIAN,DOCTOR,BLOOD_DIAGNOSE,PRICE  FROM BLOOD_APPLY  WHERE (APPLY_NUM ='' )";
            this.m_dtBloodApply = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (this.m_dtBloodApply.Rows.Count > 0)
            {
            }
        }
        private DataTable GetBloodApply()
        {
            return new DataTable();
        }
        private void sbtnClose_Click(object sender, EventArgs e)
        {
        }
        private void sbtnPrint_Click(object sender, EventArgs e)
        {
            if (this.txtAPPLY_NUM.Text == "")
            {
                MessageBox.Show("用血申请单号为空,用血申请没有保存,不能打印!");
            }
            else
            {
                if (this.cmbPAT_BLOOD_GROUP.Text.Trim() == "")
                {
                    MessageBox.Show("血型不能为空!");
                    this.cmbPAT_BLOOD_GROUP.Focus();
                }
                else
                {
                    if (this.cmbRH.Text.Trim() == "")
                    {
                        MessageBox.Show("血液RH不能为空!");
                        this.cmbRH.Focus();
                    }
                    else
                    {
                        DataTable dataTable = new DataTable();
                        DataTable dataTable2 = new DataTable();
                        for (int i = 0; i <= 1; i++)
                        {
                            dataTable.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                            dataTable2.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                        }
                        frmPrint frmPrint = new frmPrint();
                        dataTable.Rows.Clear();
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = "ID号";
                        dataRow[1] = this.txtPATIENT_ID.Text;
                        dataTable.Rows.Add(dataRow);
                        DataRow dataRow2 = dataTable.NewRow();
                        dataRow2[0] = "姓名";
                        dataRow2[1] = this.txtPAT_NAME.Text;
                        dataTable.Rows.Add(dataRow2);
                        DataRow dataRow3 = dataTable.NewRow();
                        dataRow3[0] = "年龄";
                        dataRow3[1] = EmrSysPubFunction.GetAge(EmrSysPubVar.getCurVisitAdmissionDateTime(), EmrSysPubVar.getCurPatientBirthDate());
                        dataTable.Rows.Add(dataRow3);
                        DataRow dataRow4 = dataTable.NewRow();
                        dataRow4[0] = "性别";
                        dataRow4[1] = this.txtPAT_SEX.Text;
                        dataTable.Rows.Add(dataRow4);
                        DataRow dataRow5 = dataTable.NewRow();
                        dataRow5[0] = "科室";
                        dataRow5[1] = this.txtDEPT_CODE.Text;
                        dataTable.Rows.Add(dataRow5);
                        DataRow dataRow6 = dataTable.NewRow();
                        dataRow6[0] = "病区";
                        dataRow6[1] = this.txtDEPT_CODE.Text;
                        dataTable.Rows.Add(dataRow6);
                        DataRow dataRow7 = dataTable.NewRow();
                        dataRow7[0] = "床号";
                        dataRow7[1] = ((EmrSysPubVar.getCurPatientBedLabel() == "") ? "  " : EmrSysPubVar.getCurPatientBedLabel());
                        dataTable.Rows.Add(dataRow7);
                        DataRow dataRow8 = dataTable.NewRow();
                        dataRow8[0] = "输血史";
                        dataRow8[1] = ((this.cmbBLOOD_HISTORY.Text == "") ? "无" : this.cmbBLOOD_HISTORY.Text);
                        dataTable.Rows.Add(dataRow8);
                        DataRow dataRow9 = dataTable.NewRow();
                        dataRow9[0] = "妊娠史";
                        dataRow9[1] = ((this.txtBlood_Gestation.Text == "") ? "  " : this.txtBlood_Gestation.Text);
                        dataTable.Rows.Add(dataRow9);
                        DataRow dataRow10 = dataTable.NewRow();
                        dataRow10[0] = "临床诊断";
                        dataRow10[1] = ((this.txtBLOOD_DIAGNOSE.Text == "") ? " " : this.txtBLOOD_DIAGNOSE.Text);
                        dataTable.Rows.Add(dataRow10);
                        DataRow dataRow11 = dataTable.NewRow();
                        dataRow11[0] = "血红值";
                        dataRow11[1] = ((this.txtHEMATIN.Text == "") ? " " : this.txtHEMATIN.Text);
                        dataTable.Rows.Add(dataRow11);
                        DataRow dataRow12 = dataTable.NewRow();
                        dataRow12[0] = "血小板";
                        dataRow12[1] = ((this.txtPLATELET.Text == "") ? " " : this.txtPLATELET.Text);
                        dataTable.Rows.Add(dataRow12);
                        DataRow dataRow13 = dataTable.NewRow();
                        dataRow13[0] = "HCT";
                        dataRow13[1] = ((this.txtHCT.Text == "") ? " " : this.txtHCT.Text);
                        dataTable.Rows.Add(dataRow13);
                        DataRow dataRow14 = dataTable.NewRow();
                        dataRow14[0] = "用血目的";
                        dataRow14[1] = this.cmbBLOOD_PURPOSE.Text;
                        dataTable.Rows.Add(dataRow14);
                        DataRow dataRow15 = dataTable.NewRow();
                        dataRow15[0] = "需要1";
                        dataRow15[1] = "  ";
                        dataTable.Rows.Add(dataRow15);
                        DataRow dataRow16 = dataTable.NewRow();
                        dataRow16[0] = "需要2";
                        dataRow16[1] = "  ";
                        dataTable.Rows.Add(dataRow16);
                        DataRow dataRow17 = dataTable.NewRow();
                        dataRow17[0] = "需要3";
                        dataRow17[1] = "  ";
                        dataTable.Rows.Add(dataRow17);
                        DataRow dataRow18 = dataTable.NewRow();
                        dataRow18[0] = "需要4";
                        dataRow18[1] = "  ";
                        dataTable.Rows.Add(dataRow18);
                        DataRow dataRow19 = dataTable.NewRow();
                        dataRow19[0] = "申请医师签名";
                        dataRow19[1] = ((this.txtDOCTOR.Text == "") ? "  " : this.txtDOCTOR.Text);
                        dataTable.Rows.Add(dataRow19);
                        DataRow dataRow20 = dataTable.NewRow();
                        dataRow20[0] = "主治医师签名";
                        dataRow20[1] = ((this.txtPHYSICIAN.Text == "") ? "  " : this.txtPHYSICIAN.Text);
                        dataTable.Rows.Add(dataRow20);
                        DataRow dataRow21 = dataTable.NewRow();
                        dataRow21[0] = "申请日期";
                        dataRow21[1] = Convert.ToDateTime(this.dtpAPPLY_DATE.Text).ToString("yyyy年MM月dd日");
                        dataTable.Rows.Add(dataRow21);
                        dataTable2.Rows.Clear();
                        for (int j = 1; j <= 6; j++)
                        {
                            DataRow dataRow22 = dataTable2.NewRow();
                            dataRow22[0] = "[成分" + Convert.ToString(j) + "]";
                            dataRow22[1] = " ";
                            dataTable2.Rows.Add(dataRow22);
                            DataRow dataRow23 = dataTable2.NewRow();
                            dataRow23[0] = "[分量" + Convert.ToString(j) + "]";
                            dataRow23[1] = " ";
                            dataTable2.Rows.Add(dataRow23);
                            DataRow dataRow24 = dataTable2.NewRow();
                            dataRow24[0] = "[单位" + Convert.ToString(j) + "]";
                            dataRow24[1] = " ";
                            dataTable2.Rows.Add(dataRow24);
                        }
                        for (int k = 0; k < this.m_dtBloodCapacity.Rows.Count; k++)
                        {
                            dataTable2.Rows[k * 3][1] = this.m_dtBloodCapacity.Rows[k]["BLOOD_TYPE_NAME"].ToString();
                            dataTable2.Rows[k * 3 + 1][1] = this.m_dtBloodCapacity.Rows[k]["TRANS_CAPACITY"].ToString();
                            dataTable2.Rows[2 + k * 3][1] = this.m_dtBloodCapacity.Rows[k]["UNIT"].ToString();
                        }
                        frmPrint.PrintLabExam("输血申请", dataTable, dataTable2);
                    }
                }
            }
        }
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (!this.BloodApplyOrder())
            {
                MessageBox.Show("请先做输血前的检验(HIV、丙肝和梅毒)！");
            }
            else
            {
                if (this.dtpAPPLY_DATE.Value < EmrSysPubVar.getCurVisitAdmissionDateTime())
                {
                    MessageBox.Show("申请日期不能少于入院日期！");
                }
                else
                {
                    if (this.txtAPPLY_NUM.Text == "")
                    {
                        if (this.cmbPAT_BLOOD_GROUP.Text.Trim() == "")
                        {
                            MessageBox.Show("血型不能为空!");
                            this.cmbPAT_BLOOD_GROUP.Focus();
                        }
                        else
                        {
                            if (this.cmbBLOOD_INUSE.Text.Trim() == "")
                            {
                                MessageBox.Show("血源不能为空!");
                                this.cmbBLOOD_INUSE.Focus();
                            }
                            else
                            {
                                if (this.cmbPAT_SOURCE.Text.Trim() == "")
                                {
                                    MessageBox.Show("属地不能为空!");
                                    this.cmbPAT_SOURCE.Focus();
                                }
                                else
                                {
                                    if (this.gvBLOODCAPACITY.RowCount < 1)
                                    {
                                        MessageBox.Show("没有血液记录的申请单为无效申请单!");
                                    }
                                    else
                                    {
                                        foreach (DataRow dataRow in this.m_dtBloodCapacity.Rows)
                                        {
                                            if (dataRow["TRANS_CAPACITY"] == DBNull.Value || dataRow["BLOOD_TYPE"] == DBNull.Value)
                                            {
                                                MessageBox.Show("血液信息中的血液要求或者血量不能为空!");
                                                return;
                                            }
                                        }
                                        string sQLString = "SELECT apply_num.NEXTVAL as apply_num FROM DUAL";
                                        string text = Convert.ToString(DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet));
                                        text = text.PadLeft(5, '0');
                                        this.txtAPPLY_NUM.Text = text;
                                        int num = this.m_dtBloodCapacity.Rows.Count + 1;
                                        string[] array = new string[num];
                                        array[0] = string.Concat(new string[]
										{
											"insert into blood_apply(APPLY_NUM,INP_NO,PATIENT_ID,DEPT_CODE,PAT_NAME,PAT_SEX,BIRTHDAY,FEE_TYPE,PAT_SOURCE,BLOOD_INUSE,BLOOD_DIAGNOSE,BLOOD_TABOO,HEMATIN,PLATELET,LEUCOCYTE,PAT_BLOOD_GROUP,RH,APPLY_DATE,DIRECTOR,PHYSICIAN,DOCTOR,BLOOD_HISTORY,Blood_Gestation,BLOOD_PURPOSE,BLOOD_ELSE,CONFIRM_FLAG) values('",
											this.txtAPPLY_NUM.Text,
											"','",
											EmrSysPubVar.getCurPatientInpNo(),
											"','",
											EmrSysPubVar.getCurPatientID(),
											"','",
											this.txtDEPT_CODE.Tag.ToString(),
											"','",
											this.txtPAT_NAME.Text,
											"','",
											this.txtPAT_SEX.Text,
											"',to_date('",
											this.txtBIRTHDAY.Text,
											"','YYYY-MM-DD HH24:MI:SS'),'",
											this.txtCHARGE_TYPE.Text,
											"','",
											Convert.ToString(this.cmbPAT_SOURCE.SelectedIndex + 1),
											"','",
											this.cmbBLOOD_INUSE.Text,
											"','",
											this.txtBLOOD_DIAGNOSE.Text.Replace("'", "''"),
											"','",
											this.txtBLOOD_TABOO.Text.Replace("'", "''"),
											"','",
											this.txtHEMATIN.Text,
											"','",
											this.txtPLATELET.Text,
											"','",
											this.txtHCT.Text,
											"','",
											this.cmbPAT_BLOOD_GROUP.Text,
											"','",
											this.cmbRH.Text,
											"',to_date('",
											this.dtpAPPLY_DATE.Text,
											"','YYYY-MM-DD HH24:MI:SS'),'",
											this.txtDIRECTOR.Text,
											"','",
											this.txtPHYSICIAN.Text,
											"','",
											this.txtDOCTOR.Text,
											"',",
											this.cmbBLOOD_HISTORY.SelectedIndex.ToString(),
											",'",
											this.txtBlood_Gestation.Text.Trim(),
											"','",
											this.cmbBLOOD_PURPOSE.Text,
											"','",
											this.txtElse.Text.Replace("'", "''"),
											"',"
										});
                                        if (this.m_nRole > 1)
                                        {
                                            string[] array2;
                                            (array2 = array)[0] = array2[0] + "1)";
                                        }
                                        else
                                        {
                                            string[] array2;
                                            (array2 = array)[0] = array2[0] + "0)";
                                        }
                                        for (int i = 0; i < this.m_dtBloodCapacity.Rows.Count; i++)
                                        {
                                            array[i + 1] = string.Concat(new string[]
											{
												"insert into BLOOD_CAPACITY(APPLY_NUM,MATCH_SUB_NUM,FAST_SLOW,TRANS_DATE,TRANS_CAPACITY,BLOOD_TYPE,OPERATOR) values('",
												this.txtAPPLY_NUM.Text,
												"',",
												Convert.ToString(i + 1),
												",'",
												(this.m_dtBloodCapacity.Rows[i]["FAST_SLOW"] == DBNull.Value) ? "" : this.m_dtBloodCapacity.Rows[i]["FAST_SLOW"].ToString(),
												"',to_date('",
												this.m_dtBloodCapacity.Rows[i]["TRANS_DATE"].ToString(),
												"','YYYY-MM-DD HH24:MI:SS'),",
												this.m_dtBloodCapacity.Rows[i]["TRANS_CAPACITY"].ToString(),
												",'",
												this.m_dtBloodCapacity.Rows[i]["BLOOD_TYPE"].ToString(),
												"','",
												EmrSysPubVar.getOperator(),
												"') "
											});
                                        }
                                        if (DALUseSpecial.ExecuteSqlTran(array, this.m_strDBConnet))
                                        {
                                            MessageBox.Show("保存成功!");
                                            if (this.m_nRole > 1)
                                            {
                                                this.sbtnPrint.Enabled = true;
                                                this.sptnConfirm.Enabled = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        string sQLString2 = string.Concat(new object[]
						{
							"update blood_apply set PAT_SOURCE='",
							Convert.ToUInt32(this.cmbPAT_SOURCE.SelectedIndex + 1),
							"',BLOOD_INUSE='",
							this.cmbBLOOD_INUSE.Text,
							"',BLOOD_DIAGNOSE='",
							this.txtBLOOD_DIAGNOSE.Text.Replace("'", "''"),
							"',BLOOD_TABOO='",
							this.txtBLOOD_TABOO.Text.Replace("'", "''"),
							"',HEMATIN='",
							this.txtHEMATIN.Text,
							"',PLATELET='",
							this.txtPLATELET.Text,
							"',LEUCOCYTE='",
							this.txtHCT.Text,
							"',PAT_BLOOD_GROUP='",
							this.cmbPAT_BLOOD_GROUP.Text,
							"',RH='",
							this.cmbRH.Text,
							"',APPLY_DATE=to_date('",
							this.dtpAPPLY_DATE.Text,
							"','YYYY-MM-DD HH24:MI:SS'),DIRECTOR='",
							this.txtDIRECTOR.Text,
							"',PHYSICIAN='",
							this.txtPHYSICIAN.Text,
							"',DOCTOR='",
							this.txtDOCTOR.Text,
							"',BLOOD_HISTORY='",
							this.cmbBLOOD_HISTORY.SelectedIndex.ToString(),
							"',BLOOD_PURPOSE='",
							this.cmbBLOOD_PURPOSE.Text,
							"', BLOOD_GESTATION='",
							this.txtBlood_Gestation.Text.Replace("'", "''"),
							"',BLOOD_ELSE='",
							this.txtElse.Text,
							"' where APPLY_NUM='",
							this.txtAPPLY_NUM.Text,
							"'"
						});
                        DALUseSpecial.ExecuteSql(sQLString2, this.m_strDBConnet);
                        sQLString2 = "delete from BLOOD_CAPACITY where APPLY_NUM='" + this.txtAPPLY_NUM.Text + "'";
                        DALUseSpecial.ExecuteSql(sQLString2, this.m_strDBConnet);
                        string[] array3 = new string[this.m_dtBloodCapacity.Rows.Count];
                        for (int i = 0; i < this.m_dtBloodCapacity.Rows.Count; i++)
                        {
                            array3[i] = string.Concat(new string[]
							{
								"insert into BLOOD_CAPACITY(APPLY_NUM,MATCH_SUB_NUM,FAST_SLOW,TRANS_DATE,TRANS_CAPACITY,BLOOD_TYPE,OPERATOR) values('",
								this.txtAPPLY_NUM.Text,
								"',",
								Convert.ToString(i + 1),
								",'",
								(this.m_dtBloodCapacity.Rows[i]["FAST_SLOW"] == DBNull.Value) ? "" : this.m_dtBloodCapacity.Rows[i]["FAST_SLOW"].ToString(),
								"',to_date('",
								this.m_dtBloodCapacity.Rows[i]["TRANS_DATE"].ToString(),
								"','YYYY-MM-DD HH24:MI:SS'),",
								this.m_dtBloodCapacity.Rows[i]["TRANS_CAPACITY"].ToString(),
								",'",
								this.m_dtBloodCapacity.Rows[i]["BLOOD_TYPE"].ToString(),
								"','",
								EmrSysPubVar.getOperator(),
								"') "
							});
                        }
                        if (DALUseSpecial.ExecuteSqlTran(array3, this.m_strDBConnet))
                        {
                            MessageBox.Show("修改成功!");
                        }
                    }
                }
            }
        }
        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = this.m_dtBloodCapacity.NewRow();
            this.m_dtBloodCapacity.Rows.Add(row);
            this.gvBLOODCAPACITY.FocusedRowHandle = this.m_dtBloodCapacity.Rows.Count - 1;
        }
        private void sbtnDel_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = this.gvBLOODCAPACITY.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                this.m_dtBloodCapacity.Rows.RemoveAt(focusedRowHandle);
            }
        }
        private void gvBLOODCAPACITY_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string text = e.Column.FieldName.ToUpper();
            }
        }
        private void spbtnNewApply_Click(object sender, EventArgs e)
        {
            this.txtAPPLY_NUM.Text = "";
            this.FillPatVisitBloodNew();
            this.FillBloodCapacity();
            this.txtHEMATIN.Text = "";
            this.txtPLATELET.Text = "";
            this.txtHCT.Text = "";
            this.txtDIRECTOR.Text = "";
            this.txtBlood_Gestation.Text = "";
            this.txtBLOOD_TABOO.Text = "";
            this.txtElse.Text = "";
        }
        private void spbtnBefore_Click(object sender, EventArgs e)
		{
			string sQLString = "select count(*) from blood_apply where patient_id='" + EmrSysPubVar.getCurPatientID() + "' ";
			object single = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
			int num = 0;
			if (single != null)
			{
				num = Convert.ToInt32(single);
			}
			if (num > 0)
			{
                frmBloodComponent frm=new frmBloodComponent ();
                frm.m_strPatientID=EmrSysPubVar.getCurPatientID();
                frm.ShowDialog();
                //new frmBloodComponent
                //{
                //    m_strPatientID = EmrSysPubVar.getCurPatientID()
                //}.ShowDialog();
			}
			else
			{
				MessageBox.Show("该病人以前没有输血申请!");
			}
		}
        private void txtBLOOD_DIAGNOSE_Enter(object sender, EventArgs e)
        {
            this.tssl.Text = "提示:按F9调用拼音诊断字典操作";
        }
        private void txtBLOOD_DIAGNOSE_Leave(object sender, EventArgs e)
        {
            this.tssl.Text = "提示:";
        }
        private void txtBLOOD_DIAGNOSE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                this.txtBLOOD_DIAGNOSE.Text = "";
                foreach (Control control in this.gbPatInfo.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.gbPatInfo.Controls, (TextBox)sender);
                instance.loadData("DIAGNOSIS", "DIAGNOSIS", "");
                instance.Name = "input";
                this.gbPatInfo.Controls.Add(instance);
                this.gbPatInfo.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.gbPatInfo.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.gbPatInfo.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
                instance.BringToFront();
            }
        }
        private void txtDIRECTOR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.gbPatInfo.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.gbPatInfo.Controls, (TextBox)sender);
                instance.loadData("USERS", this.txtDEPT_CODE.Tag.ToString(), "");
                instance.Name = "input";
                this.gbPatInfo.Controls.Add(instance);
                this.gbPatInfo.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.gbPatInfo.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.gbPatInfo.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtDIRECTOR_Leave(object sender, EventArgs e)
        {
            this.tssl.Text = "提示:";
        }
        private void txtDIRECTOR_Enter(object sender, EventArgs e)
        {
            this.tssl.Text = "提示:按F9或者空格调用拼音字典操作";
        }
        private void txtDIRECTOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.gbPatInfo.Controls)
                {
                    if (control.Name == "input")
                    {
                        e.KeyChar = '\0';
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.gbPatInfo.Controls, (TextBox)sender);
                instance.loadData("USERS", this.txtDEPT_CODE.Tag.ToString(), "");
                instance.Name = "input";
                this.gbPatInfo.Controls.Add(instance);
                this.gbPatInfo.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.gbPatInfo.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                e.KeyChar = '\0';
                instance.filter();
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
        }
        private void sptnConfirm_Click(object sender, EventArgs e)
        {
            if (!(this.txtAPPLY_NUM.Text == ""))
            {
                string sQLString = string.Concat(new string[]
				{
					"update blood_apply set CONFIRM_FLAG=1,PHYSICIAN='",
					EmrSysPubVar.getOperator(),
					"' where apply_num='",
					this.txtAPPLY_NUM.Text,
					"'"
				});
                if (DALUseSpecial.ExecuteSql(sQLString, this.m_strDBConnet) > 0)
                {
                    MessageBox.Show("审核成功!");
                    this.txtPHYSICIAN.Text = EmrSysPubVar.getOperator();
                    this.sbtnPrint.Enabled = true;
                }
            }
        }
        private void txtYun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtChan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtHEMATIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtPLATELET_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtHCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtALT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private bool BloodApplyOrder()
        {
            string sQLString = string.Concat(new string[]
			{
				" select * from doctor_orders where  patient_id='",
				EmrSysPubVar.getCurPatientID(),
				"' and visit_id=",
				EmrSysPubVar.getCurPatientVisitID().ToString(),
				" and order_class='C' and (ORDER_TEXT like '%HIV%' or ORDER_TEXT LIKE '%丙肝%' or ORDER_TEXT LIKE '%梅毒%' ) "
			});
            DataSet dataSet = new DataSet();
            dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
            return dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0;
        }
        private void ApplyLisBloodJCPX()
        {
            string text = "";
            string sQLString = string.Concat(new string[]
			{
				"select count(*) from lab_test_master where patient_id='",
				EmrSysPubVar.getCurPatientID(),
				"' and visit_id=",
				EmrSysPubVar.getCurPatientVisitID().ToString(),
				" and subject='交叉配血'"
			});
            int num = 0;
            object single = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
            if (single != null)
            {
                num = Convert.ToInt32(single.ToString());
            }
            if (num <= 0)
            {
                sQLString = "select test_no.nextval as ls_no from dual";
                object single2 = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
                if (single2 != null)
                {
                    text = single2.ToString();
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
                string text2 = EmrSysPubFunction.getServerNow().ToString("yyMMdd") + text;
                int num2 = 0;
                string text3 = "";
                DateTime serverNow = EmrSysPubFunction.getServerNow();
                int curPatientVisitID = EmrSysPubVar.getCurPatientVisitID();
                string text4 = EmrSysPubVar.getCurPatientClinicDiag().Replace("'", "''");
                string curPatientDeptCode = EmrSysPubVar.getCurPatientDeptCode();
                string curPatientWardCode = EmrSysPubVar.getCurPatientWardCode();
                string curPatientNamePhonetic = EmrSysPubVar.getCurPatientNamePhonetic();
                string curPatientChargeType = EmrSysPubVar.getCurPatientChargeType();
                DateTime curPatientBirthDate = EmrSysPubVar.getCurPatientBirthDate();
                int num3 = EmrSysPubFunction.getServerNow().Year - curPatientBirthDate.Year;
                string text5 = "血液";
                string text6 = "4303";
                string text7 = "交叉配血";
                if (text7.Length >= 40)
                {
                    text7 = text7.Substring(0, 39);
                }
                sQLString = string.Concat(new string[]
				{
					"insert into lab_test_master (test_no,priority_indicator,patient_id,visit_id,working_id,execute_date,name,name_phonetic,charge_type, sex, age,test_cause,relevant_clinic_diag,specimen,notes_for_spcm,spcm_received_date_time,spcm_sample_date_time,requested_date_time,ordering_dept,ordering_provider,performed_by,result_status,results_rpt_date_time,transcriptionist,verified_by,costs,charges,billing_indicator,print_indicator,subject,prt_flag)  values ('",
					text2,
					"',",
					num2.ToString(),
					",'",
					EmrSysPubVar.getCurPatientID(),
					"',",
					curPatientVisitID.ToString(),
					",'',null,'",
					EmrSysPubVar.getCurPatientName(),
					"','",
					curPatientNamePhonetic,
					"','",
					curPatientChargeType,
					"','",
					EmrSysPubVar.getCurPatientSex(),
					"','",
					num3.ToString(),
					"','','",
					text4,
					"','",
					text5,
					"','',null,null,TO_DATE('",
					serverNow.ToString(),
					"','YYYY-MM-DD HH24:MI:SS'),'",
					curPatientDeptCode,
					"','",
					EmrSysPubVar.getOperator(),
					"','",
					text6,
					"','1',null,'','','','','','','",
					text7,
					"','0')"
				});
                DALUseSpecial.ExecuteSql(sQLString, this.m_strDBConnet);
                string text8 = "交叉配血";
                string text9 = "C100.0018";
                sQLString = string.Concat(new string[]
				{
					"insert into LAB_TEST_ITEMS (TEST_NO,ITEM_NO,ITEM_NAME,ITEM_CODE) values('",
					text2,
					"','1','",
					text8,
					"','",
					text9,
					"')"
				});
                DALUseSpecial.ExecuteSql(sQLString, this.m_strDBConnet);
                sQLString = "SELECT CLIENT_NAME,IP_ADDRESS  FROM CLIENT_INSTALLATION WHERE LOCATION = '" + curPatientWardCode + "' and application='NURSWS'";
                DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (dataTable.Rows.Count < 1)
                {
                    MessageBox.Show("消息发送出错:参数不完全", "错误");
                }
                else
                {
                    string mesg = string.Concat(new string[]
					{
						"-----------------Start-----------------\r\n医生：",
						EmrSysPubFunction.getUserName(EmrSysPubVar.getDbUser(), false),
						"床：",
						EmrSysPubVar.getCurPatientBedNo().ToString(),
						"病人：",
						EmrSysPubVar.getCurPatientName(),
						"下达新检验单:\r\n",
						text3,
						text7
					});
                    if (!UCBloodApply.MessageNotice(dataTable.Rows[0]["IP_ADDRESS"].ToString(), mesg))
                    {
                        MessageBox.Show("请通知护士工作站有新下检验单！", "提示");
                    }
                }
            }
        }
        private void ApplyLisBloodSXQJC()
        {
            string text = "";
            string sQLString = string.Concat(new string[]
			{
				"select count(*) from lab_test_master where patient_id='",
				EmrSysPubVar.getCurPatientID(),
				"' and visit_id=",
				EmrSysPubVar.getCurPatientVisitID().ToString(),
				" and subject='输血前检测'"
			});
            int num = 0;
            object single = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
            if (single != null)
            {
                num = Convert.ToInt32(single.ToString());
            }
            if (num <= 0)
            {
                sQLString = "select test_no.nextval as ls_no from dual";
                object single2 = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
                if (single2 != null)
                {
                    text = single2.ToString();
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
                string text2 = EmrSysPubFunction.getServerNow().ToString("yyMMdd") + text;
                int num2 = 0;
                string text3 = "";
                DateTime serverNow = EmrSysPubFunction.getServerNow();
                int curPatientVisitID = EmrSysPubVar.getCurPatientVisitID();
                string text4 = EmrSysPubVar.getCurPatientClinicDiag().Replace("'", "''");
                string curPatientDeptCode = EmrSysPubVar.getCurPatientDeptCode();
                string curPatientWardCode = EmrSysPubVar.getCurPatientWardCode();
                string curPatientNamePhonetic = EmrSysPubVar.getCurPatientNamePhonetic();
                string curPatientChargeType = EmrSysPubVar.getCurPatientChargeType();
                DateTime curPatientBirthDate = EmrSysPubVar.getCurPatientBirthDate();
                int num3 = EmrSysPubFunction.getServerNow().Year - curPatientBirthDate.Year;
                string text5 = "血液";
                string text6 = "4303";
                string text7 = "输血前检测";
                if (text7.Length >= 40)
                {
                    text7 = text7.Substring(0, 39);
                }
                sQLString = string.Concat(new string[]
				{
					"insert into lab_test_master (test_no,priority_indicator,patient_id,visit_id,working_id,execute_date,name,name_phonetic,charge_type, sex, age,test_cause,relevant_clinic_diag,specimen,notes_for_spcm,spcm_received_date_time,spcm_sample_date_time,requested_date_time,ordering_dept,ordering_provider,performed_by,result_status,results_rpt_date_time,transcriptionist,verified_by,costs,charges,billing_indicator,print_indicator,subject,prt_flag)  values ('",
					text2,
					"',",
					num2.ToString(),
					",'",
					EmrSysPubVar.getCurPatientID(),
					"',",
					curPatientVisitID.ToString(),
					",'',null,'",
					EmrSysPubVar.getCurPatientName(),
					"','",
					curPatientNamePhonetic,
					"','",
					curPatientChargeType,
					"','",
					EmrSysPubVar.getCurPatientSex(),
					"','",
					num3.ToString(),
					"','','",
					text4,
					"','",
					text5,
					"','',null,null,TO_DATE('",
					serverNow.ToString(),
					"','YYYY-MM-DD HH24:MI:SS'),'",
					curPatientDeptCode,
					"','",
					EmrSysPubVar.getOperator(),
					"','",
					text6,
					"','1',null,'','','','','','','",
					text7,
					"','0')"
				});
                DALUseSpecial.ExecuteSql(sQLString, this.m_strDBConnet);
                string text8 = "输血前检测";
                string text9 = "C100.0019";
                sQLString = string.Concat(new string[]
				{
					"insert into LAB_TEST_ITEMS (TEST_NO,ITEM_NO,ITEM_NAME,ITEM_CODE) values('",
					text2,
					"','1','",
					text8,
					"','",
					text9,
					"')"
				});
                DALUseSpecial.ExecuteSql(sQLString, this.m_strDBConnet);
                sQLString = "SELECT CLIENT_NAME,IP_ADDRESS  FROM CLIENT_INSTALLATION WHERE LOCATION = '" + curPatientWardCode + "' and application='NURSWS'";
                DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (dataTable.Rows.Count < 1)
                {
                    MessageBox.Show("消息发送出错:参数不完全", "错误");
                }
                else
                {
                    string mesg = string.Concat(new string[]
					{
						"-----------------Start-----------------\r\n医生：",
						EmrSysPubFunction.getUserName(EmrSysPubVar.getDbUser(), false),
						"床：",
						EmrSysPubVar.getCurPatientBedNo().ToString(),
						"病人：",
						EmrSysPubVar.getCurPatientName(),
						"下达新检验单:\r\n",
						text3,
						text7
					});
                    if (!UCBloodApply.MessageNotice(dataTable.Rows[0]["IP_ADDRESS"].ToString(), mesg))
                    {
                        MessageBox.Show("请通知护士工作站有新下检验单！", "提示");
                    }
                }
            }
        }
        private void txtDOCTOR_TextChanged(object sender, EventArgs e)
        {
        }
        private void cmbBLOOD_HISTORY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbBLOOD_HISTORY.SelectedIndex == 0)
            {
                this.txtBLOOD_TABOO.Enabled = true;
            }
            else
            {
                if (this.cmbBLOOD_HISTORY.SelectedIndex == 1)
                {
                    this.txtBLOOD_TABOO.Enabled = false;
                }
            }
        }
	
    }
}
