using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.MRFirstPagesBJ
{
    public partial class frmReturnVisit : Form
    {
        private bool isPrint = false;
        private string diagnose = "";
        public frmReturnVisit()
        {
            InitializeComponent();
        }
        private void frmReturnVisit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isPrint)
            {
                MessageBox.Show("请先打印预约信息!");
            }
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            if (this.txtPATIENT_NAME.Text.Trim() == "" || this.txtDIAGNOSE.Text.Trim() == "" || this.txtYEAR.Text.Trim() == "" || this.txtMONTH.Text.Trim() == "" || this.txtDAY.Text.Trim() == "" || this.txtDEPT.Text.Trim() == "")
            {
                MessageBox.Show("预约基本信息不能为空！");
            }
            else
            {
                bool isSpecialist = true;
                string text;
                if (!this.rdbSPECIALIST.Checked)
                {
                    if (!this.rdbCOMMON.Checked)
                    {
                        MessageBox.Show("请选择门诊类型！");
                        return;
                    }
                    text = "专家门诊，医生";
                    isSpecialist = true;
                }
                else
                {
                    if (this.txtDOCTOR.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入专家门诊医生姓名！");
                        return;
                    }
                    text = "专家门诊，医生  " + this.txtDOCTOR.Text;
                    isSpecialist = false;
                }
                string sQLString = "";
                try
                {
                    string strSQL = string.Concat(new string[]
					{
						"select count(*) from fu_return_visit_order where patient_id = '",
						EmrSysPubVar.getCurPatientID().Trim(),
						"' and inp_no = '",
						EmrSysPubVar.getCurPatientInpNo().Trim(),
						"'"
					});
                    int count = DALUse.GetCount(strSQL);
                    if (count > 0)
                    {
                        sQLString = string.Concat(new string[]
						{
							"update fu_return_visit_order set datetime_year = '",
							this.txtYEAR.Text.Trim(),
							"', datetime_month = '",
							this.txtMONTH.Text.Trim(),
							"', \r\n                                                             datetime_day = '",
							this.txtDAY.Text.Trim(),
							"', datetime_noon = '",
							this.comNOON.Text.Trim(),
							"', \r\n                                                             return_visit_dept = '",
							this.txtDEPT.Text.ToString().Trim(),
							"', return_visit_user = '",
							EmrSysPubVar.getUserID(),
							"', \r\n                                                             return_visit_time = sysdate,return_visit_type = '",
							text,
							"' \r\n                                                       where patient_id = '",
							EmrSysPubVar.getCurPatientID(),
							"' and inp_no = '",
							EmrSysPubVar.getCurPatientInpNo(),
							"'"
						});
                    }
                    else
                    {
                        if (count != 0)
                        {
                            MessageBox.Show("数据库连接错误！");
                            return;
                        }
                        sQLString = string.Concat(new string[]
						{
							"insert into fu_return_visit_order (patient_id, inp_no, patient_name, outhospital_diagnose, datetime_year, datetime_month, datetime_day, datetime_noon, return_visit_dept, return_visit_user, return_visit_time, return_visit_type)\r\n                                                       values ('",
							EmrSysPubVar.getCurPatientID().Trim(),
							"','",
							EmrSysPubVar.getCurPatientInpNo().Trim(),
							"',\r\n                                                               '",
							EmrSysPubVar.getCurPatientName(),
							"','",
							this.txtDIAGNOSE.Text.Trim(),
							"',\r\n                                                               '",
							this.txtYEAR.Text.Trim(),
							"','",
							this.txtMONTH.Text.Trim(),
							"',\r\n                                                               '",
							this.txtDAY.Text.Trim(),
							"','",
							this.comNOON.Text.Trim(),
							"',\r\n                                                               '",
							this.txtDEPT.Text.ToString().Trim(),
							"','",
							EmrSysPubVar.getUserID(),
							"',sysdate,'",
							text,
							"')"
						});
                    }
                }
                catch (Exception var_5_42C)
                {
                    MessageBox.Show("数据库连接错误！");
                    return;
                }
                DALUse.ExecuteSql(sQLString);
                frmReturnVisitPrint frmReturnVisitPrint = new frmReturnVisitPrint();
                frmReturnVisitPrint.m_strPatientID = EmrSysPubVar.getCurPatientID().Trim();
                frmReturnVisitPrint.m_strPatientName = EmrSysPubVar.getCurPatientName().Trim();
                frmReturnVisitPrint.m_nVisitID = EmrSysPubVar.getCurPatientInpNo().Trim();
                frmReturnVisitPrint.isSpecialist = isSpecialist;
                frmReturnVisitPrint.ShowDialog();
                frmReturnVisitPrint.toolStripButtonPrint_Click(sender, e);
                frmReturnVisitPrint.Close();
                this.isPrint = true;
                base.Close();
            }
        }
        private void txtYEAR_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtYEAR_KeyDown(sender, e2);
        }
        private void txtYEAR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string text = "";
                string text2 = "";
                string text3 = "";
                frmTimeSel frmTimeSel = new frmTimeSel();
                if (frmTimeSel.ShowDialog() == DialogResult.OK)
                {
                    string longTimeSel = frmTimeSel.m_longTimeSel;
                    try
                    {
                        if (longTimeSel != "")
                        {
                            text = Convert.ToDateTime(longTimeSel).Year.ToString();
                            text2 = Convert.ToDateTime(longTimeSel).Month.ToString();
                            text3 = Convert.ToDateTime(longTimeSel).Day.ToString();
                        }
                    }
                    catch (Exception var_5_B4)
                    {
                    }
                }
                this.txtYEAR.Text = text;
                this.txtMONTH.Text = text2;
                this.txtDAY.Text = text3;
            }
        }
        private void txtMONTH_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtYEAR_KeyDown(sender, e2);
        }
        private void txtMONTH_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtYEAR_KeyDown(sender, e2);
        }
        private void txtDAY_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtYEAR_KeyDown(sender, e2);
        }
        private void txtDAY_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtYEAR_KeyDown(sender, e2);
        }
        private void txtDictInput(KeyEventArgs e, ref TextBox txt, string strDictName, string strSubclass)
        {
            if (e.KeyCode == Keys.F9 || e.KeyCode == Keys.Return)
            {
                codeStruc codeStruc = new codeStruc();
                codeStruc = EmrSysPubFunction.openCodeInput(strDictName, strSubclass);
                if (codeStruc.codename.Length > 0)
                {
                    txt.Text = codeStruc.codename;
                    txt.Tag = codeStruc.codeitem;
                }
            }
        }
        private void txtDEPT_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtDictInput(e2, ref this.txtDEPT, "dept", "");
        }
        private void txtDEPT_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDictInput(e, ref this.txtDEPT, "dept", "");
        }
        private void frmReturnVisit_Load(object sender, EventArgs e)
        {
            string text = "";
            try
            {
                object single = DALUse.GetSingle("select diagnosis_desc \r\n                                                             from pat_diagnosis t \r\n                                                            where patient_id = '" + EmrSysPubVar.getCurPatientID() + "' \r\n                                                                  and diagnosis_type = '2'\r\n                                                                  and diagnosis_no = 1");
                if (single != null)
                {
                    text = single.ToString().Trim();
                }
            }
            catch (Exception var_3_43)
            {
            }
            try
            {
                string sQLString = "SELECT * FROM PAT_VISIT WHERE PATIENT_ID='" + EmrSysPubVar.getCurPatientID() + "' order by  VISIT_ID desc";
                string sQLString2 = "select * from fu_visit t where t.patient_id = '" + EmrSysPubVar.getCurPatientID() + "' order by t.fu_times desc";
                DataSet dataSet = new DataSet();
                DataSet dataSet2 = new DataSet();
                dataSet = DALUse.Query(sQLString);
                dataSet2 = DALUse.Query(sQLString2);
                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    this.txtDEPT.Tag = dataSet.Tables[0].Rows[0]["dept_discharge_from"].ToString();
                    this.txtDEPT.Text = EmrSysPubFunction.getDeptName(dataSet.Tables[0].Rows[0]["dept_discharge_from"].ToString(), false);
                }
                if (dataSet2.Tables.Count > 0 && dataSet2.Tables[0].Rows.Count > 0)
                {
                    DateTime dateTime = default(DateTime);
                    dateTime = Convert.ToDateTime(dataSet2.Tables[0].Rows[0]["fu_date_time"].ToString().Trim());
                    this.txtYEAR.Text = dateTime.Year.ToString();
                    this.txtMONTH.Text = dateTime.Month.ToString();
                    this.txtDAY.Text = dateTime.Day.ToString();
                }
            }
            catch (Exception var_3_43)
            {
            }
            this.txtPATIENT_NAME.Text = EmrSysPubVar.getCurPatientName();
            this.txtDIAGNOSE.Text = text;
            this.comNOON.SelectedIndex = 0;
        }
        public void FillDeptInfo(string dept_code, string dept_name)
        {
            this.txtDEPT.Tag = dept_code;
            this.txtDEPT.Text = dept_name;
        }
        private void rdbSPECIALIST_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbSPECIALIST.Checked)
            {
                this.txtDOCTOR.Enabled = true;
            }
            else
            {
                this.txtDOCTOR.Enabled = false;
                this.txtDOCTOR.Text = "";
            }
        }
        private void txtDOCTOR_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtDOCTOR_KeyDown(sender, e2);
        }
        private void txtDoctorListSelKeyDown(ref KeyEventArgs e, ref TextBox txt)
        {
            if (e.KeyCode == Keys.Return)
            {
                frmSelectDeptUser frmSelectDeptUser = new frmSelectDeptUser();
                if (frmSelectDeptUser.ShowDialog() == DialogResult.OK)
                {
                    txt.Text = frmSelectDeptUser.m_strName;
                    txt.Tag = frmSelectDeptUser.m_strDBUser;
                }
            }
        }
        private void txtDOCTOR_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtDOCTOR);
        }
    }
}