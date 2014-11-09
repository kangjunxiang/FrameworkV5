using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmHisCustomCrb : DevExpress.XtraEditors.XtraForm
    {
        private string m_strPatientID = "";
        private int m_nVisitID = 1;
        private int m_nNum = 1;
        private int m_nMaxNum = 1;
        private DataTable m_dtInfection = new DataTable();
        public int m_nQueryFlag = 0;
        public void FillPatInfo(string strPatientID, int nVisitID, int nNum)
        {
            this.m_strPatientID = strPatientID;
            this.m_nVisitID = nVisitID;
            this.m_nNum = nNum;
        }
        public frmHisCustomCrb()
        {
            this.InitializeComponent();
        }
        private void frmHisCustomCrb_Load(object sender, EventArgs e)
        {
            if (EmrSysPubVar.getStationName() == "DOCTWS")
            {
                if (this.m_nQueryFlag == 0)
                {
                    if (EmrSysPubVar.getCurPatientID().Length <= 0)
                    {
                        MessageBox.Show("没有选中病人，将退出！");
                        base.Close();
                        return;
                    }
                    this.m_strPatientID = EmrSysPubVar.getCurPatientID();
                    this.m_nVisitID = EmrSysPubVar.getCurPatientVisitID();
                    this.tbAdd.Enabled = true;
                }
            }
            else
            {
                this.spbtnConfirm.Visible = true;
                this.tbDelete.Enabled = true;
                this.spbtnQuery.Enabled = false;
            }
            this.FillPatientInfo();
            this.m_nMaxNum = this.GetMaxNum();
            if (this.m_nNum > 1)
            {
                this.tbBack.Enabled = true;
            }
            if (this.m_nNum < this.m_nMaxNum)
            {
                this.tbNext.Enabled = true;
            }
        }
        private void tbClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void spbtnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void spbtnQuery_Click(object sender, EventArgs e)
        {
            frmHisCustomCrbQuery frmHisCustomCrbQuery = new frmHisCustomCrbQuery();
            frmHisCustomCrbQuery.ShowDialog();
        }
        private void tbRead_Click(object sender, EventArgs e)
        {
            frmCrbReadMe frmCrbReadMe = new frmCrbReadMe();
            frmCrbReadMe.ShowDialog();
        }
        private bool FillPatientInfo()
        {
            string sQLString = string.Concat(new string[]
			{
				"select a.*, b.name,b.sex,b.date_of_birth,b.mailing_address,b.phone_number_business,b.id_no,c.occupation,c.service_agency,c.admission_date_time from pat_visit_contagion a,pat_master_index b,pat_visit c  where a.patient_id=b.patient_id and a.patient_id=c.patient_id and a.visit_id=c.visit_id and a.patient_id='",
				this.m_strPatientID,
				"' and a.visit_id=",
				this.m_nVisitID.ToString(),
				" and a.num=",
				this.m_nNum.ToString()
			});
            this.m_dtInfection = DALUse.Query(sQLString).Tables[0];
            if (this.m_dtInfection.Rows.Count > 0)
            {
                this.lblName.Text = "姓名：" + this.m_dtInfection.Rows[0]["name"].ToString();
                this.lblName.Tag = this.m_dtInfection.Rows[0]["name"].ToString();
                this.lblDept.Text = "科室：" + EmrSysPubFunction.getDeptName(this.m_dtInfection.Rows[0]["dept_code"].ToString(), false);
                this.lblDept.Tag = this.m_dtInfection.Rows[0]["dept_code"].ToString();
                this.lblCard_No.Text = "编号：" + this.m_dtInfection.Rows[0]["card_no"].ToString();
                this.lblCard_No.Tag = this.m_dtInfection.Rows[0]["card_no"].ToString();
                this.lblSex.Text = "性别：" + this.m_dtInfection.Rows[0]["sex"].ToString();
                this.lblSex.Tag = this.m_dtInfection.Rows[0]["sex"].ToString();
                this.lblBirthDate.Text = "出生日期：" + this.m_dtInfection.Rows[0]["date_of_birth"].ToString();
                this.lblBirthDate.Tag = this.m_dtInfection.Rows[0]["date_of_birth"].ToString();
                if (this.m_dtInfection.Rows[0]["ID_NO"] != DBNull.Value)
                {
                    this.txtID_NO.Text = this.m_dtInfection.Rows[0]["ID_NO"].ToString();
                }
                this.lblOccupation.Text = "职业：" + this.m_dtInfection.Rows[0]["occupation"].ToString();
                this.lblOccupation.Tag = this.m_dtInfection.Rows[0]["occupation"].ToString();
                if (this.m_dtInfection.Rows[0]["service_agency"] != DBNull.Value)
                {
                    this.lblService_Agency.Text = "工作单位：" + this.m_dtInfection.Rows[0]["service_agency"].ToString();
                    this.lblService_Agency.Tag = this.m_dtInfection.Rows[0]["service_agency"].ToString();
                }
                else
                {
                    this.lblService_Agency.Text = "工作单位：";
                    this.lblService_Agency.Tag = " ";
                }
                if (this.m_dtInfection.Rows[0]["phone_number_business"] != DBNull.Value)
                {
                    this.lblPhone_Number_Business.Text = "联系电话：" + this.m_dtInfection.Rows[0]["phone_number_business"].ToString();
                    this.lblPhone_Number_Business.Tag = this.m_dtInfection.Rows[0]["phone_number_business"].ToString();
                }
                else
                {
                    this.lblPhone_Number_Business.Text = "联系电话：";
                    this.lblPhone_Number_Business.Tag = " ";
                }
                if (this.m_dtInfection.Rows[0]["Mailing_Address"] != DBNull.Value)
                {
                    this.lblMailing_Address.Text = "现住址：" + this.m_dtInfection.Rows[0]["Mailing_Address"].ToString();
                    this.lblMailing_Address.Tag = this.m_dtInfection.Rows[0]["Mailing_Address"].ToString();
                }
                else
                {
                    this.lblMailing_Address.Text = "现住址：";
                    this.lblMailing_Address.Tag = " ";
                }
                this.cmbCard_Type.Text = this.m_dtInfection.Rows[0]["card_type"].ToString();
                if (this.m_dtInfection.Rows[0]["parent_name"] != DBNull.Value)
                {
                    this.txtParent_Name.Text = this.m_dtInfection.Rows[0]["parent_name"].ToString();
                }
                this.cmbPatient_Source.Text = this.m_dtInfection.Rows[0]["Patient_Source"].ToString();
                if (this.m_dtInfection.Rows[0]["Disease_Class"] != DBNull.Value)
                {
                    this.cmbDisease_Class.Text = this.m_dtInfection.Rows[0]["Disease_Class"].ToString();
                }
                if (this.m_dtInfection.Rows[0]["Disease_Type"] != DBNull.Value)
                {
                    this.cmbDisease_Type.Text = this.m_dtInfection.Rows[0]["Disease_Type"].ToString();
                }
                this.dtpDisease_Date.Text = this.m_dtInfection.Rows[0]["Disease_Date"].ToString();
                this.dtpDiag_Date.Text = this.m_dtInfection.Rows[0]["Diag_Date"].ToString();
                if (this.m_dtInfection.Rows[0]["dead_date"] != DBNull.Value)
                {
                    this.dtpDead_Date.Text = this.m_dtInfection.Rows[0]["dead_date"].ToString();
                }
                else
                {
                    this.dtpDead_Date.Text = "1800-01-01";
                }
                this.cmbContagion_Type.Text = this.m_dtInfection.Rows[0]["Contagion_Type"].ToString();
                this.cmbContagion_Type_Name.Text = this.m_dtInfection.Rows[0]["Contagion_Type_Name"].ToString();
                if (this.m_dtInfection.Rows[0]["Revise_Disease_Name"] != DBNull.Value)
                {
                    this.txtRevise_Disease_Name.Text = this.m_dtInfection.Rows[0]["Revise_Disease_Name"].ToString();
                }
                if (this.m_dtInfection.Rows[0]["Back_Card_Reason"] != DBNull.Value)
                {
                    this.txtBack_Card_Reason.Text = this.m_dtInfection.Rows[0]["Revise_Disease_Name"].ToString();
                }
                this.lblReport_Unit.Text = "报告单位：" + this.m_dtInfection.Rows[0]["Report_Unit"].ToString();
                this.lblReport_Unit.Tag = this.m_dtInfection.Rows[0]["Report_Unit"].ToString();
                if (this.m_dtInfection.Rows[0]["Telephone"] != DBNull.Value)
                {
                    this.txtTelephone.Text = this.m_dtInfection.Rows[0]["Telephone"].ToString();
                }
                this.lblReport_Doct.Text = "报告医生：" + this.m_dtInfection.Rows[0]["Report_Doct"].ToString();
                this.lblReport_Doct.Tag = this.m_dtInfection.Rows[0]["Report_Doct"].ToString();
                this.dtpReport_Date_Time.Text = this.m_dtInfection.Rows[0]["Report_Date_Time"].ToString();
                if (this.m_dtInfection.Rows[0]["memo"] != DBNull.Value)
                {
                    this.txtMemo.Text = this.m_dtInfection.Rows[0]["memo"].ToString();
                }
                if (this.m_dtInfection.Rows[0]["CONFIRM_FLAG"].ToString() == "0")
                {
                    this.tbDelete.Enabled = true;
                }
                else
                {
                    if (EmrSysPubVar.getStationName() == "DOCTWS")
                    {
                        MessageBox.Show("该病人的疫卡上报已经审核,不能进行修改和删除");
                        this.tbSave.Enabled = false;
                        this.spbtnSave.Enabled = false;
                        this.tbDelete.Enabled = false;
                    }
                    else
                    {
                        this.tbDelete.Enabled = true;
                    }
                }
            }
            else
            {
                if (EmrSysPubVar.getStationName() == "DOCTWS")
                {
                    this.lblName.Text = "姓名：" + EmrSysPubVar.getCurPatientName();
                    this.lblName.Tag = EmrSysPubVar.getCurPatientName();
                    if (EmrSysPubVar.getCurVisitDischargeDateTime() != DateTime.MinValue)
                    {
                        this.lblDept.Text = "科室：" + EmrSysPubFunction.getDeptName(EmrSysPubVar.getCurVisitDeptDischargeFrom(), false);
                        this.lblDept.Tag = EmrSysPubVar.getCurVisitDeptDischargeFrom();
                        this.lblReport_Unit.Text = "报告单位：" + EmrSysPubFunction.getDeptName(EmrSysPubVar.getCurVisitDeptDischargeFrom(), false);
                        this.lblReport_Unit.Tag = EmrSysPubFunction.getDeptName(EmrSysPubVar.getCurVisitDeptDischargeFrom(), false);
                    }
                    else
                    {
                        this.lblDept.Text = "科室：" + EmrSysPubFunction.getDeptName(EmrSysPubVar.getCurPatientDeptCode(), false);
                        this.lblDept.Tag = EmrSysPubVar.getCurPatientDeptCode();
                        this.lblReport_Unit.Text = "报告单位：" + EmrSysPubFunction.getDeptName(EmrSysPubVar.getCurPatientDeptCode(), false);
                        this.lblReport_Unit.Tag = EmrSysPubFunction.getDeptName(EmrSysPubVar.getCurPatientDeptCode(), false);
                    }
                    string sQLString2 = "select b.name,b.sex,b.date_of_birth,b.mailing_address,b.phone_number_business,b.id_no,c.occupation,c.service_agency,c.admission_date_time from pat_master_index b,pat_visit c  where c.patient_id=b.patient_id  and c.patient_id='" + this.m_strPatientID + "' and c.visit_id=" + this.m_nVisitID.ToString();
                    DataTable dataTable = DALUse.Query(sQLString2).Tables[0];
                    this.lblSex.Text = "性别：" + dataTable.Rows[0]["sex"].ToString();
                    this.lblSex.Tag = dataTable.Rows[0]["sex"].ToString();
                    this.lblBirthDate.Text = "出生日期：" + dataTable.Rows[0]["date_of_birth"].ToString();
                    this.lblBirthDate.Tag = dataTable.Rows[0]["date_of_birth"].ToString();
                    if (dataTable.Rows[0]["ID_NO"] != DBNull.Value)
                    {
                        this.txtID_NO.Text = dataTable.Rows[0]["ID_NO"].ToString();
                    }
                    this.lblOccupation.Text = "职业：" + dataTable.Rows[0]["occupation"].ToString();
                    this.lblOccupation.Tag = dataTable.Rows[0]["occupation"].ToString();
                    if (dataTable.Rows[0]["service_agency"] != DBNull.Value)
                    {
                        this.lblService_Agency.Text = "工作单位：" + dataTable.Rows[0]["service_agency"].ToString();
                        this.lblService_Agency.Tag = dataTable.Rows[0]["service_agency"].ToString();
                    }
                    else
                    {
                        this.lblService_Agency.Text = "工作单位：";
                        this.lblService_Agency.Tag = " ";
                    }
                    if (dataTable.Rows[0]["phone_number_business"] != DBNull.Value)
                    {
                        this.lblPhone_Number_Business.Text = "联系电话：" + dataTable.Rows[0]["phone_number_business"].ToString();
                        this.lblPhone_Number_Business.Tag = dataTable.Rows[0]["phone_number_business"].ToString();
                    }
                    else
                    {
                        this.lblPhone_Number_Business.Text = "联系电话：";
                        this.lblPhone_Number_Business.Tag = "";
                    }
                    if (dataTable.Rows[0]["Mailing_Address"] != DBNull.Value)
                    {
                        this.lblMailing_Address.Text = "现住址：" + dataTable.Rows[0]["Mailing_Address"].ToString();
                        this.lblMailing_Address.Tag = dataTable.Rows[0]["Mailing_Address"].ToString();
                    }
                    else
                    {
                        this.lblMailing_Address.Text = "现住址：";
                        this.lblMailing_Address.Tag = " ";
                    }
                    this.lblReport_Doct.Text = "报告医生：" + EmrSysPubFunction.getUserName(EmrSysPubVar.getDbUser(), false);
                    this.lblReport_Doct.Tag = EmrSysPubFunction.getUserName(EmrSysPubVar.getDbUser(), false);
                    this.lblCard_No.Text = "编号：" + this.GetCardNo(this.lblDept.Tag.ToString()).ToString();
                    this.lblCard_No.Tag = this.GetCardNo(this.lblDept.Tag.ToString()).ToString();
                    this.dtpDisease_Date.Text = EmrSysPubFunction.getServerNow().ToShortDateString();
                    this.dtpDiag_Date.Text = EmrSysPubFunction.getServerNow().ToShortDateString();
                    this.dtpDead_Date.Text = "1800-01-01";
                    this.dtpReport_Date_Time.Text = EmrSysPubFunction.getServerNow().ToString();
                    this.cmbCard_Type.SelectedIndex = 0;
                    this.cmbPatient_Source.SelectedIndex = 0;
                }
            }
            return true;
        }
        private int GetCardNo(string strDeptCode)
        {
            string sQLString = "select MAX(CARD_NO) as CARD_NO from pat_visit_contagion where dept_code='" + strDeptCode + "'";
            object single = DALUse.GetSingle(sQLString);
            int num;
            if (single != null)
            {
                num = Convert.ToInt32(single.ToString());
            }
            else
            {
                num = 0;
            }
            return num + 1;
        }
        private int GetMaxNum()
        {
            int result = 1;
            string sQLString = "select max(num) from pat_visit_contagion where patient_id='" + this.m_strPatientID + "' and visit_id=" + this.m_nVisitID.ToString();
            object single = DALUse.GetSingle(sQLString);
            if (single != null)
            {
                result = Convert.ToInt32(single.ToString());
            }
            return result;
        }
        private void cmbContagion_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbContagion_Type_Name.Text = "";
            this.cmbContagion_Type_Name.Items.Clear();
            string text = this.cmbContagion_Type.Text;
            if (text != null)
            {
                if (!(text == "甲类"))
                {
                    if (!(text == "乙类"))
                    {
                        if (!(text == "丙类"))
                        {
                            if (text == "其他")
                            {
                                this.cmbContagion_Type_Name.Items.Add("");
                            }
                        }
                        else
                        {
                            this.cmbContagion_Type_Name.Items.Add("流行性感冒");
                            this.cmbContagion_Type_Name.Items.Add("流行性腮腺炎");
                            this.cmbContagion_Type_Name.Items.Add("风疹");
                            this.cmbContagion_Type_Name.Items.Add("急性出血性结膜炎");
                            this.cmbContagion_Type_Name.Items.Add("麻风病");
                            this.cmbContagion_Type_Name.Items.Add("流行性和地方性斑疹伤寒");
                            this.cmbContagion_Type_Name.Items.Add("黑热病");
                            this.cmbContagion_Type_Name.Items.Add("包虫病");
                            this.cmbContagion_Type_Name.Items.Add("丝虫病");
                            this.cmbContagion_Type_Name.Items.Add("感染性腹泻病（急性肠炎）");
                            this.cmbContagion_Type_Name.Items.Add("感染性腹泻病（急性胃肠炎）");
                            this.cmbContagion_Type_Name.Items.Add("手足口病");
                        }
                    }
                    else
                    {
                        this.cmbContagion_Type_Name.Items.Add("传染性非典型肺炎");
                        this.cmbContagion_Type_Name.Items.Add("艾滋病");
                        this.cmbContagion_Type_Name.Items.Add("病毒性肝炎(甲型)");
                        this.cmbContagion_Type_Name.Items.Add("病毒性肝炎(乙型)");
                        this.cmbContagion_Type_Name.Items.Add("病毒性肝炎(丙型)");
                        this.cmbContagion_Type_Name.Items.Add("病毒性肝炎(戊型)");
                        this.cmbContagion_Type_Name.Items.Add("病毒性肝炎(未分型)");
                        this.cmbContagion_Type_Name.Items.Add("脊髓灰质炎");
                        this.cmbContagion_Type_Name.Items.Add("人感染高致性禽流感");
                        this.cmbContagion_Type_Name.Items.Add("麻疹");
                        this.cmbContagion_Type_Name.Items.Add("流行性出血热");
                        this.cmbContagion_Type_Name.Items.Add("狂犬病");
                        this.cmbContagion_Type_Name.Items.Add("流行性乙型脑炎");
                        this.cmbContagion_Type_Name.Items.Add("登革热");
                        this.cmbContagion_Type_Name.Items.Add("炭疽(肺炭疽)");
                        this.cmbContagion_Type_Name.Items.Add("炭疽(皮肤炭疽)");
                        this.cmbContagion_Type_Name.Items.Add("炭疽(未分型)");
                        this.cmbContagion_Type_Name.Items.Add("痢疾(细菌型)");
                        this.cmbContagion_Type_Name.Items.Add("痢疾(阿米巴型)");
                        this.cmbContagion_Type_Name.Items.Add("肺结核(涂阳)");
                        this.cmbContagion_Type_Name.Items.Add("肺结核(仅培阳)");
                        this.cmbContagion_Type_Name.Items.Add("肺结核(菌阴)");
                        this.cmbContagion_Type_Name.Items.Add("肺结核(未痰检)");
                        this.cmbContagion_Type_Name.Items.Add("伤寒(伤寒)");
                        this.cmbContagion_Type_Name.Items.Add("伤寒(副伤寒)");
                        this.cmbContagion_Type_Name.Items.Add("流行性脑脊髓炎");
                        this.cmbContagion_Type_Name.Items.Add("百日咳");
                        this.cmbContagion_Type_Name.Items.Add("白喉");
                        this.cmbContagion_Type_Name.Items.Add("新生儿破伤风");
                        this.cmbContagion_Type_Name.Items.Add("猩红热");
                        this.cmbContagion_Type_Name.Items.Add("布鲁氏菌病");
                        this.cmbContagion_Type_Name.Items.Add("淋病");
                        this.cmbContagion_Type_Name.Items.Add("梅毒(I期)");
                        this.cmbContagion_Type_Name.Items.Add("梅毒(II期)");
                        this.cmbContagion_Type_Name.Items.Add("梅毒(III期)");
                        this.cmbContagion_Type_Name.Items.Add("梅毒(胎传)");
                        this.cmbContagion_Type_Name.Items.Add("梅毒(隐性)");
                        this.cmbContagion_Type_Name.Items.Add("钩端螺旋体病");
                        this.cmbContagion_Type_Name.Items.Add("血吸虫病");
                        this.cmbContagion_Type_Name.Items.Add("疟疾(间日疟)");
                        this.cmbContagion_Type_Name.Items.Add("疟疾(恶性疟)");
                        this.cmbContagion_Type_Name.Items.Add("疟疾(未分型)");
                    }
                }
                else
                {
                    this.cmbContagion_Type_Name.Items.Add("鼠疫");
                    this.cmbContagion_Type_Name.Items.Add("霍乱");
                }
            }
        }
        private void tbSave_Click(object sender, EventArgs e)
        {
            this.spbtnSave_Click(sender, e);
        }
        private void spbtnSave_Click(object sender, EventArgs e)
        {
            if (this.cmbCard_Type.Text.Length < 1)
            {
                MessageBox.Show("报卡类别不能为空!");
            }
            else
            {
                if (this.cmbDisease_Class.Text.Length < 1)
                {
                    MessageBox.Show("病例分类(1)不能为空!");
                }
                else
                {
                    if (this.cmbContagion_Type.Text.Length < 1)
                    {
                        MessageBox.Show("传染病类型不能为空!");
                    }
                    else
                    {
                        if (this.cmbContagion_Type_Name.Text.Length < 1)
                        {
                            MessageBox.Show("传染病名称不能为空!");
                        }
                        else
                        {
                            if (EmrSysPubVar.getCurVisitAdmissionDateTime().Year - Convert.ToDateTime(this.lblBirthDate.Tag.ToString()).Year < 14)
                            {
                                if (this.txtParent_Name.Text.Length < 1)
                                {
                                    MessageBox.Show("患者年龄小于14岁，必须填写患者家长姓名!");
                                    return;
                                }
                            }
                            if (MessageBox.Show("确定要上报该病人或者修改该病人上报信息", "注意：", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                string[] array = new string[2];
                                if (this.m_dtInfection.Rows.Count > 0)
                                {
                                    string text = "";
                                    if (this.dtpDead_Date.Text != "1800-1-1")
                                    {
                                        text = this.dtpDead_Date.Text;
                                    }
                                    array[0] = string.Concat(new string[]
									{
										"update pat_visit_contagion set CARD_TYPE='",
										this.cmbCard_Type.Text,
										"',PARENT_NAME='",
										this.txtParent_Name.Text,
										"',PATIENT_SOURCE='",
										this.cmbPatient_Source.Text,
										"',DISEASE_CLASS='",
										this.cmbDisease_Class.Text,
										"',DISEASE_TYPE='",
										this.cmbDisease_Type.Text,
										"',DISEASE_DATE=to_date('",
										this.dtpDisease_Date.Text,
										"','YYYY-MM-DD HH24:MI:SS'),DIAG_DATE=TO_DATE('",
										this.dtpDiag_Date.Text,
										"','YYYY-MM-DD HH@$:MI:SS'),"
									});
                                    string[] array2;
                                    if (text != "")
                                    {
                                        (array2 = array)[0] = array2[0] + "DEAD_DATE=TO_DATE('" + text + "','YYYY-MM-DD HH24:MI:SS'),";
                                    }
                                    else
                                    {
                                        (array2 = array)[0] = array2[0] + "DEAD_DATE=null,";
                                    }
                                    string[] expr_28C = array2 = array;
                                    int arg_389_1 = 0;
                                    string text2 = array2[0];
                                    expr_28C[arg_389_1] = string.Concat(new string[]
									{
										text2,
										"CONTAGION_TYPE='",
										this.cmbContagion_Type.Text,
										"',CONTAGION_TYPE_NAME='",
										this.cmbContagion_Type_Name.Text,
										"',REVISE_DISEASE_NAME='",
										this.txtRevise_Disease_Name.Text,
										"',BACK_CARD_REASON='",
										this.txtBack_Card_Reason.Text,
										"',TELEPHONE='",
										this.txtTelephone.Text,
										"',MEMO='",
										this.txtMemo.Text,
										"'  where patient_id='",
										this.m_strPatientID,
										"' and visit_id=",
										this.m_nVisitID.ToString(),
										" and num=",
										this.m_nNum.ToString()
									});
                                }
                                else
                                {
                                    string text = "";
                                    if (this.dtpDead_Date.Text != "1800-1-1")
                                    {
                                        text = this.dtpDead_Date.Text;
                                    }
                                    array[0] = string.Concat(new string[]
									{
										"insert into pat_visit_contagion (PATIENT_ID,VISIT_ID,Num,DEPT_CODE,CARD_NO,CARD_TYPE,PARENT_NAME,PATIENT_SOURCE,DISEASE_CLASS,DISEASE_TYPE,DISEASE_DATE,DIAG_DATE,DEAD_DATE,CONTAGION_TYPE,CONTAGION_TYPE_NAME,REVISE_DISEASE_NAME,BACK_CARD_REASON,REPORT_UNIT,TELEPHONE,REPORT_DOCT,REPORT_DATE_TIME,MEMO) values('",
										this.m_strPatientID,
										"',",
										this.m_nVisitID.ToString(),
										",",
										this.m_nNum.ToString(),
										",'",
										this.lblDept.Tag.ToString(),
										"',",
										this.lblCard_No.Tag.ToString(),
										",'",
										this.cmbCard_Type.Text,
										"','",
										this.txtParent_Name.Text,
										"','",
										this.cmbPatient_Source.Text,
										"','",
										this.cmbDisease_Class.Text,
										"','",
										this.cmbDisease_Type.Text,
										"',TO_DATE('",
										this.dtpDisease_Date.Text,
										"','YYYY-MM-DD HH24:MI:SS'),TO_DATE('",
										this.dtpDiag_Date.Text,
										"','YYYY-MM-DD HH24:MI:SS'),"
									});
                                    string[] array2;
                                    if (text != "")
                                    {
                                        (array2 = array)[0] = array2[0] + "TO_DATE('" + text + "','YYYY-MM-DD HH24:MI:SS'),'";
                                    }
                                    else
                                    {
                                        (array2 = array)[0] = array2[0] + "null,'";
                                    }
                                    string[] expr_553 = array2 = array;
                                    int arg_65F_1 = 0;
                                    string text2 = array2[0];
                                    expr_553[arg_65F_1] = string.Concat(new string[]
									{
										text2,
										this.cmbContagion_Type.Text,
										"','",
										this.cmbContagion_Type_Name.Text,
										"','",
										this.txtRevise_Disease_Name.Text,
										"','",
										this.txtBack_Card_Reason.Text,
										"','",
										this.lblReport_Unit.Tag.ToString(),
										"','",
										this.txtTelephone.Text,
										"','",
										this.lblReport_Doct.Tag.ToString(),
										"',to_date('",
										this.dtpReport_Date_Time.Text,
										"','YYYY-MM-DD HH24:MI:SS'),'",
										this.txtMemo.Text,
										"')"
									});
                                }
                                array[1] = string.Concat(new string[]
								{
									"update pat_master_index set ID_NO='",
									this.txtID_NO.Text,
									"' where patient_id='",
									this.m_strPatientID,
									"'"
								});
                                if (DALUse.ExecuteSqlTran(array))
                                {
                                    MessageBox.Show("保存成功！");
                                    this.FillPatientInfo();
                                }
                            }
                        }
                    }
                }
            }
        }
        private void spbtnPrint_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            for (int i = 0; i <= 1; i++)
            {
                dataTable.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
            }
            DataRow dataRow = dataTable.NewRow();
            dataRow[0] = "报卡类别";
            dataRow[1] = this.cmbCard_Type.Text;
            dataTable.Rows.Add(dataRow);
            DataRow dataRow2 = dataTable.NewRow();
            dataRow2[0] = "卡片编号";
            dataRow2[1] = this.lblCard_No.Tag.ToString();
            dataTable.Rows.Add(dataRow2);
            DataRow dataRow3 = dataTable.NewRow();
            dataRow3[0] = "患者姓名";
            dataRow3[1] = this.lblName.Tag.ToString();
            dataTable.Rows.Add(dataRow3);
            DataRow dataRow4 = dataTable.NewRow();
            dataRow4[0] = "患儿家长姓名";
            dataRow4[1] = ((this.txtParent_Name.Text == "") ? " " : this.txtParent_Name.Text);
            dataTable.Rows.Add(dataRow4);
            DataRow dataRow5 = dataTable.NewRow();
            dataRow5[0] = "身份证号";
            dataRow5[1] = this.txtID_NO.Text;
            dataTable.Rows.Add(dataRow5);
            DataRow dataRow6 = dataTable.NewRow();
            dataRow6[0] = "性别";
            dataRow6[1] = this.lblSex.Tag.ToString();
            dataTable.Rows.Add(dataRow6);
            DataRow dataRow7 = dataTable.NewRow();
            dataRow7[0] = "出生日期";
            dataRow7[1] = this.lblBirthDate.Tag.ToString();
            dataTable.Rows.Add(dataRow7);
            DataRow dataRow8 = dataTable.NewRow();
            dataRow8[0] = "病人属于";
            dataRow8[1] = this.cmbPatient_Source.Text;
            dataTable.Rows.Add(dataRow8);
            DataRow dataRow9 = dataTable.NewRow();
            dataRow9[0] = "现住址";
            dataRow9[1] = this.lblMailing_Address.Tag.ToString();
            dataTable.Rows.Add(dataRow9);
            DataRow dataRow10 = dataTable.NewRow();
            dataRow10[0] = "患者职业";
            dataRow10[1] = ((this.lblOccupation.Tag.ToString() == "") ? " " : this.lblOccupation.Tag.ToString());
            dataTable.Rows.Add(dataRow10);
            DataRow dataRow11 = dataTable.NewRow();
            dataRow11[0] = "病例分类";
            dataRow11[1] = ((this.cmbDisease_Class.Text == "") ? " " : this.cmbDisease_Class.Text);
            dataTable.Rows.Add(dataRow11);
            DataRow dataRow12 = dataTable.NewRow();
            dataRow12[0] = "发病日期";
            dataRow12[1] = Convert.ToDateTime(this.dtpDisease_Date.Text).ToString("yyyy年MM月dd日");
            dataTable.Rows.Add(dataRow12);
            DataRow dataRow13 = dataTable.NewRow();
            dataRow13[0] = "诊断日期";
            dataRow13[1] = Convert.ToDateTime(this.dtpDiag_Date.Text).ToString("yyyy年MM月dd日");
            dataTable.Rows.Add(dataRow13);
            DataRow dataRow14 = dataTable.NewRow();
            dataRow14[0] = "死亡日期";
            if (this.dtpDead_Date.Text != "1800-1-1")
            {
                dataRow14[1] = Convert.ToDateTime(this.dtpDead_Date.Text).ToString("yyyy年MM月dd日");
            }
            else
            {
                dataRow14[1] = " ";
            }
            dataTable.Rows.Add(dataRow14);
            DataRow dataRow15 = dataTable.NewRow();
            DataRow dataRow16 = dataTable.NewRow();
            DataRow dataRow17 = dataTable.NewRow();
            DataRow dataRow18 = dataTable.NewRow();
            string text = this.cmbContagion_Type.Text;
            if (text != null)
            {
                if (text == "甲类")
                {
                    dataRow15[0] = "甲类传染病";
                    dataRow15[1] = this.cmbContagion_Type_Name.Text;
                    dataRow16[0] = "乙类传染病";
                    dataRow16[1] = " ";
                    dataRow17[0] = "丙类传染病";
                    dataRow17[1] = " ";
                    dataRow18[0] = "其他法定管理以及重点监测传染病";
                    dataRow18[1] = " ";
                    goto IL_708;
                }
                if (text == "乙类")
                {
                    dataRow15[0] = "甲类传染病";
                    dataRow15[1] = " ";
                    dataRow16[0] = "乙类传染病";
                    dataRow16[1] = this.cmbContagion_Type_Name.Text;
                    dataRow17[0] = "丙类传染病";
                    dataRow17[1] = " ";
                    dataRow18[0] = "其他法定管理以及重点监测传染病";
                    dataRow18[1] = " ";
                    goto IL_708;
                }
                if (text == "丙类")
                {
                    dataRow15[0] = "甲类传染病";
                    dataRow15[1] = " ";
                    dataRow16[0] = "乙类传染病";
                    dataRow16[1] = " ";
                    dataRow17[0] = "丙类传染病";
                    dataRow17[1] = this.cmbContagion_Type_Name.Text;
                    dataRow18[0] = "其他法定管理以及重点监测传染病";
                    dataRow18[1] = " ";
                    goto IL_708;
                }
                if (text == "其他")
                {
                    dataRow15[0] = "甲类传染病";
                    dataRow15[1] = " ";
                    dataRow16[0] = "乙类传染病";
                    dataRow16[1] = " ";
                    dataRow17[0] = "丙类传染病";
                    dataRow17[1] = " ";
                    dataRow18[0] = "其他法定管理以及重点监测传染病";
                    dataRow18[1] = this.cmbContagion_Type_Name.Text;
                    goto IL_708;
                }
            }
            dataRow15[0] = "甲类传染病";
            dataRow15[1] = " ";
            dataRow16[0] = "乙类传染病";
            dataRow16[1] = " ";
            dataRow17[0] = "丙类传染病";
            dataRow17[1] = " ";
            dataRow18[0] = "其他法定管理以及重点监测传染病";
            dataRow18[1] = " ";
        IL_708:
            dataTable.Rows.Add(dataRow15);
            dataTable.Rows.Add(dataRow16);
            dataTable.Rows.Add(dataRow17);
            dataTable.Rows.Add(dataRow18);
            DataRow dataRow19 = dataTable.NewRow();
            dataRow19[0] = "订正病名";
            dataRow19[1] = ((this.txtRevise_Disease_Name.Text == "") ? " " : this.txtRevise_Disease_Name.Text);
            dataTable.Rows.Add(dataRow19);
            DataRow dataRow20 = dataTable.NewRow();
            dataRow20[0] = "退卡原因";
            dataRow20[1] = ((this.txtBack_Card_Reason.Text == "") ? " " : this.txtBack_Card_Reason.Text);
            dataTable.Rows.Add(dataRow20);
            DataRow dataRow21 = dataTable.NewRow();
            dataRow21[0] = "报告单位";
            dataRow21[1] = this.lblReport_Unit.Tag.ToString();
            dataTable.Rows.Add(dataRow21);
            DataRow dataRow22 = dataTable.NewRow();
            dataRow22[0] = "联系电话";
            dataRow22[1] = ((this.txtTelephone.Text == "") ? " " : this.txtTelephone.Text);
            dataTable.Rows.Add(dataRow22);
            DataRow dataRow23 = dataTable.NewRow();
            dataRow23[0] = "报告医生";
            dataRow23[1] = this.lblReport_Doct.Tag.ToString();
            dataTable.Rows.Add(dataRow23);
            DataRow dataRow24 = dataTable.NewRow();
            dataRow24[0] = "填卡日期";
            dataRow24[1] = Convert.ToDateTime(this.dtpReport_Date_Time.Text).ToString("yyyy年MM月dd日 HH时");
            dataTable.Rows.Add(dataRow24);
            DataRow dataRow25 = dataTable.NewRow();
            dataRow25[0] = "备注";
            dataRow25[1] = ((this.txtMemo.Text == "") ? " " : this.txtMemo.Text);
            dataTable.Rows.Add(dataRow25);
            DataRow dataRow26 = dataTable.NewRow();
            dataRow26[0] = "电话";
            dataRow26[1] = ((this.lblPhone_Number_Business.Tag.ToString() == "") ? " " : this.lblPhone_Number_Business.Tag.ToString());
            dataTable.Rows.Add(dataRow26);
            DataRow dataRow27 = dataTable.NewRow();
            dataRow27[0] = "病例分类2";
            dataRow27[1] = ((this.cmbDisease_Type.Text == "") ? " " : this.cmbDisease_Type.Text);
            dataTable.Rows.Add(dataRow27);
            frmPrint frmPrint = new frmPrint();
            frmPrint.PrintLabExam("传染病报告卡", dataTable, null);
        }
        private void tbQuery_Click(object sender, EventArgs e)
        {
            this.spbtnQuery_Click(sender, e);
        }
        private void tbPrint_Click(object sender, EventArgs e)
        {
            this.spbtnPrint_Click(sender, e);
        }
        private void tbAdd_Click(object sender, EventArgs e)
        {
            if (this.m_dtInfection.Rows.Count >= 1)
            {
                this.m_nMaxNum = this.GetMaxNum();
                this.m_nNum = this.m_nMaxNum + 1;
                this.txtParent_Name.Text = "";
                this.cmbDisease_Class.Text = "";
                this.cmbContagion_Type.Text = "";
                this.cmbContagion_Type_Name.Text = "";
                this.cmbDisease_Class.Text = "";
                this.txtMemo.Text = "";
                this.FillPatientInfo();
                this.tbBack.Enabled = true;
                this.tbSave.Enabled = true;
                this.spbtnSave.Enabled = true;
            }
        }
        private void tbBack_Click(object sender, EventArgs e)
        {
            if (this.m_nNum - 1 > 0)
            {
                this.m_nNum--;
                this.FillPatientInfo();
                this.tbNext.Enabled = true;
            }
            if (this.m_nNum == 1)
            {
                this.tbBack.Enabled = false;
            }
        }
        private void tbNext_Click(object sender, EventArgs e)
        {
            this.m_nMaxNum = this.GetMaxNum();
            if (this.m_nNum + 1 <= this.m_nMaxNum)
            {
                this.m_nNum++;
                this.FillPatientInfo();
                this.tbBack.Enabled = true;
            }
            if (this.m_nNum == this.m_nMaxNum)
            {
                this.tbNext.Enabled = false;
            }
        }
        private void frmHisCustomCrb_Shown(object sender, EventArgs e)
        {
            this.cmbCard_Type.Focus();
        }
        private void spbtnConfirm_Click(object sender, EventArgs e)
        {
            if (this.cmbCard_Type.Text.Length < 1)
            {
                MessageBox.Show("报卡类别不能为空!");
            }
            else
            {
                if (this.cmbDisease_Class.Text.Length < 1)
                {
                    MessageBox.Show("病例分类(1)不能为空!");
                }
                else
                {
                    if (this.cmbContagion_Type.Text.Length < 1)
                    {
                        MessageBox.Show("传染病类型不能为空!");
                    }
                    else
                    {
                        if (this.cmbContagion_Type_Name.Text.Length < 1)
                        {
                            MessageBox.Show("传染病名称不能为空!");
                        }
                        else
                        {
                            if (EmrSysPubVar.getCurVisitAdmissionDateTime().Year - Convert.ToDateTime(this.lblBirthDate.Tag.ToString()).Year < 14)
                            {
                                if (this.txtParent_Name.Text.Length < 1)
                                {
                                    MessageBox.Show("患者年龄小于14岁，必须填写患者家长姓名!");
                                    return;
                                }
                            }
                            if (MessageBox.Show("确定要审核该病人上报信息，审核之后医生站的医生不能修改和删除该传染上报", "注意：", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                string[] array = new string[2];
                                if (this.m_dtInfection.Rows.Count > 0)
                                {
                                    string text = "";
                                    if (this.dtpDead_Date.Text != "1800-1-1")
                                    {
                                        text = this.dtpDead_Date.Text;
                                    }
                                    array[0] = string.Concat(new string[]
									{
										"update pat_visit_contagion set CARD_TYPE='",
										this.cmbCard_Type.Text,
										"',PARENT_NAME='",
										this.txtParent_Name.Text,
										"',PATIENT_SOURCE='",
										this.cmbPatient_Source.Text,
										"',DISEASE_CLASS='",
										this.cmbDisease_Class.Text,
										"',DISEASE_TYPE='",
										this.cmbDisease_Type.Text,
										"',DISEASE_DATE=to_date('",
										this.dtpDisease_Date.Text,
										"','YYYY-MM-DD HH24:MI:SS'),DIAG_DATE=TO_DATE('",
										this.dtpDiag_Date.Text,
										"','YYYY-MM-DD HH@$:MI:SS'),"
									});
                                    string[] array2;
                                    if (text != "")
                                    {
                                        (array2 = array)[0] = array2[0] + "DEAD_DATE=TO_DATE('" + text + "','YYYY-MM-DD HH24:MI:SS'),";
                                    }
                                    else
                                    {
                                        (array2 = array)[0] = array2[0] + "DEAD_DATE=null,";
                                    }
                                    string[] expr_28C = array2 = array;
                                    int arg_39D_1 = 0;
                                    string text2 = array2[0];
                                    expr_28C[arg_39D_1] = string.Concat(new string[]
									{
										text2,
										"CONTAGION_TYPE='",
										this.cmbContagion_Type.Text,
										"',CONTAGION_TYPE_NAME='",
										this.cmbContagion_Type_Name.Text,
										"',REVISE_DISEASE_NAME='",
										this.txtRevise_Disease_Name.Text,
										"',BACK_CARD_REASON='",
										this.txtBack_Card_Reason.Text,
										"',TELEPHONE='",
										this.txtTelephone.Text,
										"',MEMO='",
										this.txtMemo.Text,
										"',CONFIRM_FLAG=1,CONFIRM_TIME=sysdate,CONFIRM_USER_ID='",
										EmrSysPubVar.getUserID(),
										"'  where patient_id='",
										this.m_strPatientID,
										"' and visit_id=",
										this.m_nVisitID.ToString(),
										" and num=",
										this.m_nNum.ToString()
									});
                                }
                                array[1] = string.Concat(new string[]
								{
									"update pat_master_index set ID_NO='",
									this.txtID_NO.Text,
									"' where patient_id='",
									this.m_strPatientID,
									"'"
								});
                                if (DALUse.ExecuteSqlTran(array))
                                {
                                    MessageBox.Show("审核成功！");
                                    this.FillPatientInfo();
                                }
                            }
                        }
                    }
                }
            }
        }
        private void tbDelete_Click(object sender, EventArgs e)
        {
            if (this.m_dtInfection.Rows.Count > 0)
            {
                string sQLString = string.Concat(new string[]
				{
					"delete from pat_visit_contagion where patient_id='",
					this.m_strPatientID,
					"' and visit_id=",
					this.m_nVisitID.ToString(),
					" and num=",
					this.m_nNum.ToString()
				});
                if (DALUse.ExecuteSql(sQLString) > 0)
                {
                    MessageBox.Show("删除成功!");
                    this.FillPatientInfo();
                }
            }
            else
            {
                MessageBox.Show("还没有保存,不能进行删除!");
            }
        }
        private void tbHistory_Click(object sender, EventArgs e)
        {
            frmHisCustomHistory frmHisCustomHistory = new frmHisCustomHistory();
            frmHisCustomHistory.m_strPatient_ID = this.m_strPatientID;
            if (frmHisCustomHistory.ShowDialog() == DialogResult.OK)
            {
                this.FillPatInfo(frmHisCustomHistory.m_strPatient_ID, Convert.ToInt32(frmHisCustomHistory.m_strVisit_ID), Convert.ToInt32(frmHisCustomHistory.m_strNum));
                this.FillPatientInfo();
            }
        }
    }
}