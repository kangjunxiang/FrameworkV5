using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EmrSysWebservices;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;
using JHEMR.EmrSysUserCtl;
using System.IO;
using System.Collections;
using EmrSysWebservices.EMR_Services;


namespace JHEMR.MRFirstPages
{
    public partial class UCMRFirstPage : UserControl
    {
        private MRFirstPageDAL m_MRFirstPageDAL = new MRFirstPageDAL();
        private string m_strPatientID = "";
        private int m_nVisitID = 0;
        private bool m_bReadOnly = false;
        private string m_strFieldName = "";
        private bool m_bFirstPageIsCommit = false;
        private int intdia = 1;
        private byte[] m_btUser = new byte[0];
        public UCMRFirstPage()
        {
            InitializeComponent();
            SetControlsBorderStyle();
        }
        private void SetControlsBorderStyle()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).BorderStyle = BorderStyle.None;
                if (c is PictureBox)
                    ((PictureBox)c).BorderStyle = BorderStyle.FixedSingle;
            }
        }
        
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            this.m_strPatientID = strPatientID;
            this.m_nVisitID = nVisitID;
            this.m_MRFirstPageDAL.fillPatientFirstPageData(this.m_strPatientID, this.m_nVisitID);
            this.fillFirstPageData();
        }
        public void setReadOnly(bool bReadOnly)
        {
            this.m_bReadOnly = bReadOnly;
        }
        public bool Print()
		{
			this.Save();
			bool result;
			if (this.txtDISCHARGE_CONDITIONS.Text == "" || this.txtDISCHARGE_CONDITIONS.Text.Trim() == "－" || this.txtDISCHARGE_CONDITIONS.Text.Trim() == "-")
			{
				MessageBox.Show("请添出院情况！");
				this.txtDISCHARGE_CONDITIONS.Focus();
				result = false;
			}
			else
			{
				if (this.txtRUYUAN_PASS.Text == "" || this.txtRUYUAN_PASS.Text.Trim() == "－" || this.txtRUYUAN_PASS.Text.Trim() == "-")
				{
					MessageBox.Show("请添写入院途径！");
					this.txtRUYUAN_PASS.Focus();
					result = false;
				}
				else
				{
					if (this.txtDISCHARGE_CONDITIONS.Text == "4")
					{
						string sQLString = "select DEATH_DATE_TIME from pat_visit where PATIENT_ID='" + this.m_strPatientID + "' AND visit_id=" + this.m_nVisitID.ToString();
						object single = DALUse.GetSingle(sQLString);
						if (single == null)
						{
							MessageBox.Show("附页中的死亡日期、死亡原因、死亡类型请添写!");
							result = false;
							return result;
						}
						string sQLString2 = "select DEADREASON from emr_fuye where PATIENT_ID='" + this.m_strPatientID + "' AND visit_id=" + this.m_nVisitID.ToString();
						object single2 = DALUse.GetSingle(sQLString2);
						if (single2 == null)
						{
							MessageBox.Show("附页中的死亡日期、死亡原因、死亡类型请添写!");
							result = false;
							return result;
						}
						string sQLString3 = "select DEADCODE from emr_fuye where PATIENT_ID='" + this.m_strPatientID + "' AND visit_id=" + this.m_nVisitID.ToString();
						object single3 = DALUse.GetSingle(sQLString3);
						if (single3 == null)
						{
							MessageBox.Show("附页中的死亡日期、死亡原因、死亡类型请添写!");
							result = false;
							return result;
						}
					}
                    frmMRFirstPagePrint frm=new frmMRFirstPagePrint ();
                    frm.m_strPatientID=this.m_strPatientID;
                    frm.m_nVisitID=this.m_nVisitID;
                    frm.ShowDialog();
					result = true;
				}
			}
			return result;
		}
        public bool UpdatePatInfo(string strFieldName, string strFieldValue)
        {
            if (strFieldName != null)
            {
                if (!(strFieldName == "MR_QUALITY"))
                {
                    if (!(strFieldName == "DOCTOR_OF_CONTROL_QUALITY"))
                    {
                        if (!(strFieldName == "NURSE_OF_CONTROL_QUALITY"))
                        {
                            if (!(strFieldName == "DATE_OF_CONTROL_QUALITY"))
                            {
                                if (strFieldName == "CATALOGER")
                                {
                                    this.txtCATALOGER.Text = strFieldValue;
                                }
                            }
                            else
                            {
                                this.txtDATE_OF_CONTROL_QUALITY.Text = strFieldValue;
                            }
                        }
                        else
                        {
                            this.txtNURSE_OF_CONTROL_QUALITY.Text = strFieldValue;
                        }
                    }
                    else
                    {
                        this.txtDOCTOR_OF_CONTROL_QUALITY.Text = strFieldValue;
                    }
                }
                else
                {
                    this.txtMR_QUALITY.Tag = strFieldValue;
                    this.txtMR_QUALITY.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("MR_QUALITY", strFieldValue);
                }
            }
            return true;
        }
        private void UCMRFirstPage_Load(object sender, EventArgs e)
        {
            this.txtHospitalName.Text = EmrSysPubVar.getHospitalName();
            this.dgvDiagnose.RegisterExistHeaderColumn();
            this.dgvOperation.RegisterExistHeaderColumn();
        }
        public static string GetAge(DateTime dtCurrent, DateTime dtBirth)
        {
            int num = dtCurrent.Year - dtBirth.Year;
            TimeSpan timeSpan = dtCurrent - dtBirth;
            int num2 = timeSpan.Days / 365;
            int num3 = (timeSpan.Days - 365 * num2) / 30;
            int num4 = timeSpan.Days - 365 * num2 - 30 * num3;
            string result;
            if (num2 > 1)
            {
                result = num.ToString() + "岁";
            }
            else
            {
                if (num2 > 0)
                {
                    result = num2.ToString() + "岁" + num3.ToString() + "月";
                }
                else
                {
                    if (num3 > 0)
                    {
                        result = num3.ToString() + " " + num4.ToString() + "/30月";
                    }
                    else
                    {
                        if (num4 > 0)
                        {
                            result = num4.ToString() + "/30月";
                        }
                        else
                        {
                            result = "1/30月";
                        }
                    }
                }
            }
            return result;
        }
        private void fillFirstPageData()
        {
            foreach (DataRow dataRow in this.m_MRFirstPageDAL.getAnaesthesiaMethod().Rows)
            {
                this.anaesthesia_method.Items.Add(dataRow[0]);
            }
            string text = string.Empty;
            DateTime dateTime = EmrSysPubFunction.getServerNow();
            if (this.m_MRFirstPageDAL.m_dsPatientMasterIndex.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsPatientMasterIndex.Tables.Count == 1)
                {
                    if (this.m_MRFirstPageDAL.m_dsPatientMasterIndex.Tables[0].Rows.Count == 1)
                    {
                        DataRow dataRow = this.m_MRFirstPageDAL.m_dsPatientMasterIndex.Tables[0].Rows[0];
                        this.txtInp_no.Text = dataRow["INP_NO"].ToString();
                        this.txtName.Text = dataRow["NAME"].ToString();
                        text = dataRow["SEX"].ToString();
                        this.txtSex.Tag = text;
                        this.txtSex.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("SEX", text);
                        if (dataRow["Date_of_birth"] != DBNull.Value)
                        {
                            this.txtDate_of_birth.Text = Convert.ToDateTime(dataRow["Date_of_birth"].ToString()).ToString("yyyy年MM月dd日");
                            this.txtDate_of_birth.Tag = dataRow["Date_of_birth"].ToString();
                        }
                        if (dataRow["BIRTH_PLACE"] != DBNull.Value)
                        {
                            this.txtBIRTH_PLACE.Text = dataRow["BIRTH_PLACE"].ToString();
                        }
                        if (dataRow["JIGUAN"] != DBNull.Value)
                        {
                            this.txtJIGUAN.Text = dataRow["JIGUAN"].ToString();
                        }
                        if (dataRow["XIAN_PLACE"] != DBNull.Value)
                        {
                            this.txtXIAN_PLACE.Text = dataRow["XIAN_PLACE"].ToString();
                        }
                        if (dataRow["XIAN_PHOTO"] != DBNull.Value)
                        {
                            this.txtXIAN_PHOTO.Text = dataRow["XIAN_PHOTO"].ToString();
                        }
                        if (dataRow["XIAN_CODE"] != DBNull.Value)
                        {
                            this.txtXIAN_CODE.Text = dataRow["XIAN_CODE"].ToString();
                        }
                        if (dataRow["NATION"] != DBNull.Value)
                        {
                            this.txtNATION.Text = dataRow["NATION"].ToString();
                        }
                        if (dataRow["CITIZENSHIP"] != DBNull.Value)
                        {
                            this.txtCITIZENSHIP.Text = dataRow["CITIZENSHIP"].ToString();
                        }
                        if (dataRow["ID_NO"] != DBNull.Value)
                        {
                            this.txtID_NO.Text = dataRow["ID_NO"].ToString();
                        }
                        if (dataRow["PHONE_NUMBER_BUSINESS"] != DBNull.Value)
                        {
                            this.txtPHONE_NUMBER_BUSINESS.Text = dataRow["PHONE_NUMBER_BUSINESS"].ToString();
                        }
                        if (dataRow["ZIP_CODE"] != DBNull.Value)
                        {
                            this.txtZIP_CODE.Text = dataRow["ZIP_CODE"].ToString();
                        }
                        if (dataRow["BABY_WEIGHT"] != DBNull.Value)
                        {
                            this.txtBABY_WEIGHT.Text = dataRow["BABY_WEIGHT"].ToString();
                        }
                        if (dataRow["BABY_R_WEIGHT"] != DBNull.Value)
                        {
                            this.txtBABY_R_WEIGHT.Text = dataRow["BABY_R_WEIGHT"].ToString();
                        }
                        if (dataRow["BABY_WEIGHT"] != DBNull.Value)
                        {
                            this.txtBABY_WEIGHT.Text = dataRow["BABY_WEIGHT"].ToString();
                        }
                        else
                        {
                            this.txtBABY_WEIGHT.Text = "－";
                        }
                        if (dataRow["BABY_R_WEIGHT"] != DBNull.Value)
                        {
                            this.txtBABY_R_WEIGHT.Text = dataRow["BABY_R_WEIGHT"].ToString();
                        }
                        else
                        {
                            this.txtBABY_R_WEIGHT.Text = "－";
                        }
                    }
                }
            }
            if (this.m_MRFirstPageDAL.m_dsPatientVisit.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsPatientVisit.Tables.Count == 1)
                {
                    if (this.m_MRFirstPageDAL.m_dsPatientVisit.Tables[0].Rows.Count == 1)
                    {
                        DataRow dataRow = this.m_MRFirstPageDAL.m_dsPatientVisit.Tables[0].Rows[0];
                        this.txtVisit_id.Text = dataRow["VISIT_ID"].ToString();
                        if (dataRow["MARITAL_STATUS"] != DBNull.Value)
                        {
                            text = dataRow["MARITAL_STATUS"].ToString();
                            this.txtMARITAL_STATUS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("MARITAL_STATUS", text);
                            this.txtMARITAL_STATUS.Tag = text;
                        }
                        if (dataRow["ZIP_CODE"] != DBNull.Value)
                        {
                            this.txtHKZIP_CODE.Text = dataRow["ZIP_CODE"].ToString();
                        }
                        if (dataRow["CHARGE_TYPE"] != DBNull.Value)
                        {
                            text = dataRow["CHARGE_TYPE"].ToString();
                            this.txtMedical_pay_way.Tag = text;
                            this.txtMedical_pay_way.Text = text;
                        }
                        if (dataRow["OCCUPATION"] != DBNull.Value)
                        {
                            if (dataRow["OCCUPATION"].ToString() == "不便分类的其他从业人员")
                            {
                                this.txtOCCUPATION.Text = "-";
                            }
                            else
                            {
                                this.txtOCCUPATION.Text = dataRow["OCCUPATION"].ToString().Trim();
                            }
                        }
                        if (dataRow["SERVICE_AGENCY"] != DBNull.Value)
                        {
                            this.txtSERVICE_AGENCY.Text = dataRow["SERVICE_AGENCY"].ToString();
                        }
                        if (dataRow["MAILING_ADDRESS"] != DBNull.Value)
                        {
                            this.txtMAILING_ADDRESS.Text = dataRow["MAILING_ADDRESS"].ToString();
                        }
                        if (dataRow["total_costs"] != DBNull.Value)
                        {
                            this.txtTOTAL_PAYMENTS.Text = dataRow["total_costs"].ToString();
                        }
                        if (dataRow["NEXT_OF_KIN"] != DBNull.Value)
                        {
                            this.txtNEXT_OF_KIN.Text = dataRow["NEXT_OF_KIN"].ToString();
                        }
                        if (dataRow["NEXT_OF_KIN_ADDR"] != DBNull.Value)
                        {
                            this.txtNEXT_OF_KIN_ADDR.Text = dataRow["NEXT_OF_KIN_ADDR"].ToString();
                        }
                        if (dataRow["NEXT_OF_KIN_PHONE"] != DBNull.Value)
                        {
                            this.txtNEXT_OF_KIN_PHONE.Text = dataRow["NEXT_OF_KIN_PHONE"].ToString();
                        }
                        if (dataRow["RELATIONSHIP"] != DBNull.Value)
                        {
                            this.txtRELATIONSHIP.Text = dataRow["RELATIONSHIP"].ToString();
                        }
                        if (dataRow["DISCHARGE_CONDITIONS"] != DBNull.Value)
                        {
                            text = dataRow["DISCHARGE_CONDITIONS"].ToString();
                            this.txtDISCHARGE_CONDITIONS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("DISCHARGE_CONDITIONS", text);
                            this.txtDISCHARGE_CONDITIONS.Tag = text;
                        }
                        if (dataRow["ADMISSION_DATE_TIME"] != DBNull.Value)
                        {
                            this.txtADMISSION_DATE_TIME.Text = Convert.ToDateTime(dataRow["WARD_DATE_TIME"].ToString()).ToString("yyyy-MM-dd HH:mm");
                            this.txtADMISSION_DATE_TIME.Tag = dataRow["WARD_DATE_TIME"].ToString();
                            this.txtAge.Text = UCMRFirstPage.GetAge(Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Tag.ToString()), Convert.ToDateTime(this.txtDate_of_birth.Tag.ToString()));
                        }
                        if (dataRow["DEPT_ADMISSION_TO"] != DBNull.Value)
                        {
                            text = dataRow["DEPT_ADMISSION_TO"].ToString();
                            this.txtDEPT_ADMISSION_TO.Text = EmrSysPubFunction.getDeptName(text, false);
                            this.txtDEPT_ADMISSION_TO.Tag = text;
                        }
                        if (dataRow["DEPT_DISCHARGE_FROM"] != DBNull.Value)
                        {
                            text = dataRow["DEPT_DISCHARGE_FROM"].ToString();
                            this.txtDEPT_DISCHARGE_FROM.Text = EmrSysPubFunction.getDeptName(text, false);
                            this.txtDEPT_DISCHARGE_FROM.Tag = text;
                        }
                        if (dataRow["bed_label"] != DBNull.Value)
                        {
                            text = dataRow["bed_label"].ToString();
                            this.txtward_admission_to.Text = text;
                            this.txtward_admission_to.Tag = text;
                            this.txtward_discharge_from.Text = text;
                            this.txtward_discharge_from.Tag = text;
                        }
                        this.txtdept_transfer.Text = "";
                        if (dataRow["DISCHARGE_DATE_TIME"] != DBNull.Value)
                        {
                            this.txtDISCHARGE_DATE_TIME.Text = Convert.ToDateTime(dataRow["DISCHARGE_DATE_TIME"].ToString()).ToString("yyyy-MM-dd HH:mm");
                            this.txtDISCHARGE_DATE_TIME.Tag = dataRow["DISCHARGE_DATE_TIME"].ToString();
                            if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
                            {
                                dateTime = Convert.ToDateTime(dataRow["DISCHARGE_DATE_TIME"].ToString());
                                Control arg_B19_0 = this.txtInhospitaldays;
                                int betweenDays = EmrSysPubFunction.GetBetweenDays(Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Tag.ToString()), Convert.ToDateTime(this.txtDISCHARGE_DATE_TIME.Tag.ToString()));
                                arg_B19_0.Text = betweenDays.ToString();
                            }
                            this.txtAge.Text = UCMRFirstPage.GetAge(Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Tag.ToString()), Convert.ToDateTime(this.txtDate_of_birth.Tag.ToString()));
                        }
                        else
                        {
                            this.txtAge.Text = UCMRFirstPage.GetAge(Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Tag.ToString()), Convert.ToDateTime(this.txtDate_of_birth.Tag.ToString()));
                            if (this.m_MRFirstPageDAL.m_dsMoniterPatient.IsInitialized)
                            {
                                if (this.m_MRFirstPageDAL.m_dsMoniterPatient.Tables.Count == 1)
                                {
                                    if (this.m_MRFirstPageDAL.m_dsMoniterPatient.Tables[0].Rows.Count == 1)
                                    {
                                        DataRow dataRow2 = this.m_MRFirstPageDAL.m_dsMoniterPatient.Tables[0].Rows[0];
                                        if (dataRow2["start_date_time"] != DBNull.Value)
                                        {
                                            this.txtDISCHARGE_DATE_TIME.Text = Convert.ToDateTime(dataRow2["start_date_time"].ToString()).ToString("yyyy-MM-dd HH:mm");
                                            this.txtDISCHARGE_DATE_TIME.Tag = dataRow2["start_date_time"].ToString();
                                            if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
                                            {
                                                dateTime = Convert.ToDateTime(dataRow2["start_date_time"].ToString());
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (dataRow["BLH"] != DBNull.Value)
                        {
                            this.txtBLH.Text = dataRow["BLH"].ToString();
                        }
                        if (dataRow["RUYUAN_PASS"] != DBNull.Value)
                        {
                            text = dataRow["RUYUAN_PASS"].ToString();
                            this.txtRUYUAN_PASS.Tag = text;
                            this.txtRUYUAN_PASS.Text = text;
                        }
                        if (dataRow["LNSS_P_HOSPITAL_DAYS"] != DBNull.Value)
                        {
                            text = dataRow["LNSS_P_HOSPITAL_DAYS"].ToString();
                            this.txtLNSS_P_HOSPITAL_DAYS.Tag = text;
                            this.txtLNSS_P_HOSPITAL_DAYS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("LNSS_P_HOSPITAL_DAYS", text);
                        }
                        if (dataRow["LNSS_P_HOSPITAL_HOURS"] != DBNull.Value)
                        {
                            text = dataRow["LNSS_P_HOSPITAL_HOURS"].ToString();
                            this.txtLNSS_P_HOSPITAL_HOURS.Tag = text;
                            this.txtLNSS_P_HOSPITAL_HOURS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("LNSS_P_HOSPITAL_HOURS", text);
                        }
                        if (dataRow["LNSS_P_HOSPITAL_MIN"] != DBNull.Value)
                        {
                            text = dataRow["LNSS_P_HOSPITAL_MIN"].ToString();
                            this.txtLNSS_P_HOSPITAL_MIN.Tag = text;
                            this.txtLNSS_P_HOSPITAL_MIN.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("LNSS_P_HOSPITAL_MIN", text);
                        }
                        if (dataRow["LNSS_A_HOSPITAL_DAYS"] != DBNull.Value)
                        {
                            text = dataRow["LNSS_A_HOSPITAL_DAYS"].ToString();
                            this.txtLNSS_A_HOSPITAL_DAYS.Tag = text;
                            this.txtLNSS_A_HOSPITAL_DAYS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("LNSS_A_HOSPITAL_DAYS", text);
                        }
                        if (dataRow["LNSS_A_HOSPITAL_HOURS"] != DBNull.Value)
                        {
                            text = dataRow["LNSS_A_HOSPITAL_HOURS"].ToString();
                            this.txtLNSS_A_HOSPITAL_HOURS.Tag = text;
                            this.txtLNSS_A_HOSPITAL_HOURS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("LNSS_A_HOSPITAL_HOURS", text);
                        }
                        if (dataRow["LNSS_A_HOSPITAL_MIN"] != DBNull.Value)
                        {
                            text = dataRow["LNSS_A_HOSPITAL_MIN"].ToString();
                            this.txtLNSS_A_HOSPITAL_MIN.Tag = text;
                            this.txtLNSS_A_HOSPITAL_MIN.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("LNSS_A_HOSPITAL_MIN", text);
                        }
                        if (dataRow["ZYMC"] != DBNull.Value)
                        {
                            text = dataRow["ZYMC"].ToString();
                            this.txtZYMC.Tag = text;
                            this.txtZYMC.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("ZYMC", text);
                        }
                        if (dataRow["YWGM"] != DBNull.Value)
                        {
                            text = dataRow["YWGM"].ToString();
                            this.txtYWGM.Tag = text;
                            this.txtYWGM.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("HAVENO", text);
                        }
                        if (dataRow["ZYJG"] != DBNull.Value)
                        {
                            text = dataRow["ZYJG"].ToString();
                            this.txtZYJG.Tag = text;
                            this.txtZYJG.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("ZYJG", text);
                        }
                        if (dataRow["ZYMD"] != DBNull.Value)
                        {
                            text = dataRow["ZYMD"].ToString();
                            this.txtZYMD.Tag = text;
                            this.txtZYMD.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("ZYMD", text);
                        }
                        if (dataRow["WZYMD"] != DBNull.Value)
                        {
                            this.txtWZYMD.Tag = dataRow["WZYMD"].ToString();
                            this.txtWZYMD.Text = dataRow["WZYMD"].ToString();
                        }
                        if (dataRow["DISCHARGE_DISPOSITION"] != DBNull.Value)
                        {
                            text = dataRow["DISCHARGE_DISPOSITION"].ToString();
                            this.txtdischarge_disposition.Tag = text;
                            this.txtdischarge_disposition.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("DISCHARGE_DISPOSITION", text);
                        }
                        else
                        {
                            this.txtdischarge_disposition.Tag = "正常";
                            this.txtdischarge_disposition.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("DISCHARGE_DISPOSITION", "正常");
                        }
                        if (dataRow["ALERGY_DRUGS"] != DBNull.Value)
                        {
                            this.txtALERGY_DRUGS.Text = dataRow["ALERGY_DRUGS"].ToString();
                        }
                        if (dataRow["DIRECTOR"] != DBNull.Value)
                        {
                            this.txtDIRECTOR.Text = dataRow["DIRECTOR"].ToString();
                        }
                        if (dataRow["DIRECTOR_ID"] != DBNull.Value && UCMRFirstPage.IsCAUser(dataRow["DIRECTOR_ID"].ToString().Trim()))
                        {
                            this.txtDIRECTOR.Tag = dataRow["DIRECTOR_ID"].ToString().Trim();
                            this.picDIRECTOR.Image = this.getUserImage(this.txtDIRECTOR.Tag.ToString());
                        }
                        else
                        {
                            this.picDIRECTOR.Visible = false;
                        }
                        if (dataRow["CHIEF_DOCTOR"] != DBNull.Value)
                        {
                            this.txtCHIEF_DOCTOR.Text = dataRow["CHIEF_DOCTOR"].ToString();
                        }
                        if (dataRow["CHIEF_DOCTOR_ID"] != DBNull.Value && UCMRFirstPage.IsCAUser(dataRow["CHIEF_DOCTOR_ID"].ToString().Trim()))
                        {
                            this.txtCHIEF_DOCTOR.Tag = dataRow["CHIEF_DOCTOR_ID"].ToString();
                            this.picCHIEF_DOCTOR.Image = this.getUserImage(this.txtCHIEF_DOCTOR.Tag.ToString());
                        }
                        else
                        {
                            this.picCHIEF_DOCTOR.Visible = false;
                        }
                        if (dataRow["ATTENDING_DOCTOR"] != DBNull.Value)
                        {
                            this.txtATTENDING_DOCTOR.Text = dataRow["ATTENDING_DOCTOR"].ToString();
                        }
                        if (dataRow["ATTENDING_DOCTOR_ID"] != DBNull.Value && UCMRFirstPage.IsCAUser(dataRow["ATTENDING_DOCTOR_ID"].ToString().Trim()))
                        {
                            this.txtATTENDING_DOCTOR.Tag = dataRow["ATTENDING_DOCTOR_ID"].ToString();
                            this.picATTENDING_DOCTOR.Image = this.getUserImage(this.txtATTENDING_DOCTOR.Tag.ToString());
                        }
                        else
                        {
                            this.picATTENDING_DOCTOR.Visible = false;
                        }
                        if (dataRow["DOCTOR_IN_CHARGE"] != DBNull.Value)
                        {
                            this.txtDOCTOR_IN_CHARGE.Text = dataRow["DOCTOR_IN_CHARGE"].ToString();
                        }
                        if (dataRow["DOCTOR_IN_CHARGE_ID"] != DBNull.Value && UCMRFirstPage.IsCAUser(dataRow["DOCTOR_IN_CHARGE_ID"].ToString().Trim()))
                        {
                            this.txtDOCTOR_IN_CHARGE.Tag = dataRow["DOCTOR_IN_CHARGE_ID"].ToString();
                            this.picDOCTOR_IN_CHARGE.Image = this.getUserImage(this.txtDOCTOR_IN_CHARGE.Tag.ToString());
                        }
                        else
                        {
                            this.picDOCTOR_IN_CHARGE.Visible = false;
                        }
                        if (dataRow["ADVANCED_STUDIES_DOCTOR"] != DBNull.Value)
                        {
                            this.txtADVANCED_STUDIES_DOCTOR.Text = dataRow["ADVANCED_STUDIES_DOCTOR"].ToString();
                        }
                        if (dataRow["ADVANCED_STUDIES_DOCTOR_ID"] != DBNull.Value && UCMRFirstPage.IsCAUser(dataRow["ADVANCED_STUDIES_DOCTOR_ID"].ToString().Trim()))
                        {
                            this.txtADVANCED_STUDIES_DOCTOR.Tag = dataRow["ADVANCED_STUDIES_DOCTOR_ID"].ToString();
                            this.picADVANCED_STUDIES_DOCTOR.Image = this.getUserImage(this.txtADVANCED_STUDIES_DOCTOR.Tag.ToString());
                        }
                        else
                        {
                            this.picADVANCED_STUDIES_DOCTOR.Visible = false;
                        }
                        if (dataRow["PRACTICE_DOCTOR"] != DBNull.Value)
                        {
                            this.txtPRACTICE_DOCTOR.Text = dataRow["PRACTICE_DOCTOR"].ToString();
                        }
                        if (dataRow["PRACTICE_DOCTOR_ID"] != DBNull.Value && UCMRFirstPage.IsCAUser(dataRow["PRACTICE_DOCTOR_ID"].ToString().Trim()))
                        {
                            this.txtPRACTICE_DOCTOR.Tag = dataRow["PRACTICE_DOCTOR_ID"].ToString();
                            this.picPRACTICE_DOCTOR.Image = this.getUserImage(this.txtPRACTICE_DOCTOR.Tag.ToString());
                        }
                        else
                        {
                            this.picPRACTICE_DOCTOR.Visible = false;
                        }
                        if (dataRow["LIABILITY_NURSE"] != DBNull.Value)
                        {
                            this.txtLIABILITY_NURSE_ID.Text = dataRow["LIABILITY_NURSE"].ToString();
                        }
                        if (dataRow["LIABILITY_NURSE_ID"] != DBNull.Value && UCMRFirstPage.IsCAUser(dataRow["LIABILITY_NURSE_ID"].ToString().Trim()))
                        {
                            this.txtLIABILITY_NURSE_ID.Tag = dataRow["LIABILITY_NURSE_ID"].ToString();
                            this.picLIABILITY_NURSE_ID.Image = this.getUserImage(this.txtLIABILITY_NURSE_ID.Tag.ToString());
                        }
                        else
                        {
                            this.picLIABILITY_NURSE_ID.Visible = false;
                        }
                        if (dataRow["CATALOGER"] != DBNull.Value)
                        {
                            this.txtCATALOGER.Text = dataRow["CATALOGER"].ToString();
                        }
                        if (dataRow["MR_QUALITY"] != DBNull.Value)
                        {
                            text = dataRow["MR_QUALITY"].ToString();
                            this.txtMR_QUALITY.Tag = text;
                            this.txtMR_QUALITY.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("MR_QUALITY", text);
                        }
                        if (dataRow["DOCTOR_OF_CONTROL_QUALITY"] != DBNull.Value)
                        {
                            this.txtDOCTOR_OF_CONTROL_QUALITY.Text = dataRow["DOCTOR_OF_CONTROL_QUALITY"].ToString();
                            if (UCMRFirstPage.IsCAUser(MRFirstPageDAL.getUserId(dataRow["DOCTOR_OF_CONTROL_QUALITY"].ToString())))
                            {
                                this.picDOCTOR_OF_CONTROL_QUALITY.Image = this.getUserImage(MRFirstPageDAL.getUserId(dataRow["DOCTOR_OF_CONTROL_QUALITY"].ToString()));
                            }
                            else
                            {
                                this.picDOCTOR_OF_CONTROL_QUALITY.Visible = false;
                            }
                        }
                        if (dataRow["NURSE_OF_CONTROL_QUALITY"] != DBNull.Value)
                        {
                            this.txtNURSE_OF_CONTROL_QUALITY.Text = dataRow["NURSE_OF_CONTROL_QUALITY"].ToString();
                            if (UCMRFirstPage.IsCAUser(MRFirstPageDAL.getUserId(dataRow["NURSE_OF_CONTROL_QUALITY"].ToString())))
                            {
                                this.picNURSE_OF_CONTROL_QUALITY.Image = this.getUserImage(MRFirstPageDAL.getUserId(dataRow["NURSE_OF_CONTROL_QUALITY"].ToString()));
                            }
                            else
                            {
                                this.picNURSE_OF_CONTROL_QUALITY.Visible = false;
                            }
                        }
                        if (dataRow["DATE_OF_CONTROL_QUALITY"] != DBNull.Value)
                        {
                            this.txtDATE_OF_CONTROL_QUALITY.Text = Convert.ToDateTime(dataRow["DATE_OF_CONTROL_QUALITY"].ToString()).ToString();
                        }
                        else
                        {
                            if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
                            {
                                this.txtDATE_OF_CONTROL_QUALITY.Text = Convert.ToDateTime(this.txtDISCHARGE_DATE_TIME.Text).ToString();
                            }
                        }
                        if (dataRow["AUTOPSY_INDICATOR"] != DBNull.Value)
                        {
                            this.txtAUTOPSY_INDICATOR.Text = dataRow["AUTOPSY_INDICATOR"].ToString();
                            if (this.txtAUTOPSY_INDICATOR.Text.Equals("3"))
                            {
                                this.txtAUTOPSY_INDICATOR.Text = "0";
                            }
                            if (this.txtAUTOPSY_INDICATOR.Text.Equals("0") || this.txtAUTOPSY_INDICATOR.Text.Length == 0)
                            {
                                this.txtAUTOPSY_INDICATOR.Text = "－";
                            }
                        }
                        else
                        {
                            this.txtAUTOPSY_INDICATOR.Text = "－";
                        }
                        if (dataRow["ZRYJH"] != DBNull.Value)
                        {
                            this.txtZRYJH.Text = dataRow["ZRYJH"].ToString();
                            if (this.txtZRYJH.Text.Equals("3"))
                            {
                                this.txtZRYJH.Text = "0";
                            }
                            if (this.txtZRYJH.Text.Equals("0") || this.txtZRYJH.Text.Length == 0)
                            {
                                this.txtZRYJH.Text = "－";
                            }
                        }
                        else
                        {
                            this.txtZRYJH.Text = "－";
                        }
                        if (dataRow["WZRYJH"] != DBNull.Value)
                        {
                            this.txtWZRYJH.Text = dataRow["WZRYJH"].ToString();
                            if (this.txtWZRYJH.Text.Equals("3"))
                            {
                                this.txtWZRYJH.Text = "0";
                            }
                            if (this.txtWZRYJH.Text.Equals("0") || this.txtWZRYJH.Text.Length == 0)
                            {
                                this.txtWZRYJH.Text = "－";
                            }
                        }
                        else
                        {
                            this.txtWZRYJH.Text = "－";
                        }
                        if (dataRow["DISCHARGE_PASS"] != DBNull.Value)
                        {
                            this.txtDISCHARGE_PASS.Text = dataRow["DISCHARGE_PASS"].ToString();
                        }
                        if (dataRow["BLOOD_TYPE"] != DBNull.Value)
                        {
                            text = dataRow["BLOOD_TYPE"].ToString();
                            if (text.Equals("QT"))
                            {
                                text = "其它";
                            }
                            this.txtBLOOD_TYPE.Tag = text;
                            this.txtBLOOD_TYPE.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("BLOOD_TYPE", text);
                            if (this.txtBLOOD_TYPE.Text.Equals("0") || this.txtBLOOD_TYPE.Text.Length == 0)
                            {
                                this.txtBLOOD_TYPE.Text = "－";
                            }
                        }
                        if (dataRow["BLOOD_TYPE_RH"] != DBNull.Value)
                        {
                            text = dataRow["BLOOD_TYPE_RH"].ToString();
                            this.txtBLOOD_TYPE_RH.Tag = text;
                            this.txtBLOOD_TYPE_RH.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("BLOOD_TYPE_RH", text);
                            if (this.txtBLOOD_TYPE_RH.Text.Equals("0") || this.txtBLOOD_TYPE_RH.Text.Length == 0)
                            {
                                this.txtBLOOD_TYPE_RH.Text = "－";
                            }
                        }
                    }
                }
            }
            if (this.m_MRFirstPageDAL.m_dsAdtLog.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsAdtLog.Tables.Count == 1)
                {
                    if (this.m_MRFirstPageDAL.m_dsAdtLog.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dataRow3 in this.m_MRFirstPageDAL.m_dsAdtLog.Tables[0].Rows)
                        {
                            if (this.txtdept_transfer.Text.Trim().Length > 0)
                            {
                                TextBox expr_1DC9 = this.txtdept_transfer;
                                expr_1DC9.Text = expr_1DC9.Text + "→" + dataRow3["dept_name"].ToString();
                            }
                            else
                            {
                                this.txtdept_transfer.Text = dataRow3["dept_name"].ToString();
                            }
                        }
                    }
                }
            }
            if (this.m_MRFirstPageDAL.m_dsMedicalCosts.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsMedicalCosts.Tables.Count == 1)
                {
                    foreach (DataRow dataRow4 in this.m_MRFirstPageDAL.m_dsMedicalCosts.Tables[0].Rows)
                    {
                        string text2 = dataRow4["casecode"].ToString().Trim();
                        double num = Convert.ToDouble(dataRow4["qe"].ToString().Trim());
                        string text3 = string.Format("{0:F2}", num);
                        string text4 = text2;
                        switch (text4)
                        {
                            case "COST_OWNPAY":
                                this.txtCOST_OWNPAY.Text = text3;
                                break;
                            case "COST_ZH_YBYL":
                                this.txtCOST_ZH_YBYL.Text = text3;
                                break;
                            case "COST_ZH_YBZL":
                                this.txtCOST_ZH_YBZL.Text = text3;
                                break;
                            case "COST_ZH_HL":
                                this.txtCOST_ZH_HL.Text = text3;
                                break;
                            case "COST_ZH_OTHER":
                                this.txtCOST_ZH_OTHER.Text = text3;
                                break;
                            case "COST_ZD_BL":
                                this.txtCOST_ZD_BL.Text = text3;
                                break;
                            case "COST_ZD_SYS":
                                this.txtCOST_ZD_SYS.Text = text3;
                                break;
                            case "COST_ZD_YXX":
                                this.txtCOST_ZD_YXX.Text = text3;
                                break;
                            case "COST_ZD_LCXM":
                                this.txtCOST_ZD_LCXM.Text = text3;
                                break;
                            case "COST_ZL_FSSZLXM":
                                this.txtCOST_ZL_FSSZLXM.Text = text3;
                                break;
                            case "COST_ZL_LCWLZL":
                                this.txtCOST_ZL_LCWLZL.Text = text3;
                                break;
                            case "COST_ZL_SSZL":
                                this.txtCOST_ZL_SSZL.Text = text3;
                                break;
                            case "COST_ZL_MZ":
                                this.txtCOST_ZL_MZ.Text = text3;
                                break;
                            case "COST_ZL_SS":
                                this.txtCOST_ZL_SS.Text = text3;
                                break;
                            case "COST_KF_KF":
                                this.txtCOST_KF_KF.Text = text3;
                                break;
                            case "COST_ZY_ZYZL":
                                this.txtCOST_ZY_ZYZL.Text = text3;
                                break;
                            case "COST_XY_XY":
                                this.txtCOST_XY_XY.Text = text3;
                                break;
                            case "COST_XY_KJYW":
                                this.txtCOST_XY_KJYW.Text = text3;
                                break;
                            case "COST_ZY_ZCHY":
                                this.txtCOST_ZY_ZCHY.Text = text3;
                                break;
                            case "COST_ZY_ZCAOY":
                                this.txtCOST_ZY_ZCAOY.Text = text3;
                                break;
                            case "COST_XY_XF":
                                this.txtCOST_XY_XF.Text = text3;
                                break;
                            case "COST_XY_BDB":
                                this.txtCOST_XY_BDB.Text = text3;
                                break;
                            case "COST_XY_QDB":
                                this.txtCOST_XY_QDB.Text = text3;
                                break;
                            case "COST_XY_NXYZ":
                                this.txtCOST_XY_NXYZ.Text = text3;
                                break;
                            case "COST_XY_XBYZ":
                                this.txtCOST_XY_XBYZ.Text = text3;
                                break;
                            case "COST_HC_JC":
                                this.txtCOST_HC_JC.Text = text3;
                                break;
                            case "COST_HC_ZL":
                                this.txtCOST_HC_ZL.Text = text3;
                                break;
                            case "COST_HC_SS":
                                this.txtCOST_HC_SS.Text = text3;
                                break;
                            case "COST_OTHER":
                                this.txtCOST_OTHER.Text = text3;
                                break;
                        }
                    }
                }
            }
            this.txtCOST_TOTAL.Text = this.m_MRFirstPageDAL.GetTotalPay(this.m_strPatientID, this.m_nVisitID);
            string sQLString = string.Concat(new object[]
			{
				"SELECT * FROM HQMS_TEMP WHERE P3 = '",
				EmrSysPubVar.getCurPatientID().Trim(),
				"' AND P2 = ",
				EmrSysPubVar.getCurPatientVisitID()
			});
            DataSet dataSet = DALUse.Query(sQLString);
            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    sQLString = string.Concat(new object[]
					{
						"insert into hqms_temp(P900,P6891,P782,P751,P752,P754,P755,P756,P757,P758,P759,P760,P761,P762,P763,P764,P765,P767,P768,P769,P770,P771,P772,P773,P774,P775,P776,P777,P778,P779,P780,P781,P3,P2,p4,p5,p8) values ('46063143615220111A1011','兴安盟人民医院','",
						(this.txtCOST_TOTAL.Text == "") ? "0.00" : this.txtCOST_TOTAL.Text,
						"','",
						this.txtCOST_OWNPAY.Text,
						"','",
						this.txtCOST_ZH_YBYL.Text,
						"','",
						this.txtCOST_ZH_HL.Text,
						"','",
						this.txtCOST_ZH_HL.Text,
						"','",
						this.txtCOST_ZH_OTHER.Text,
						"','",
						this.txtCOST_ZD_BL.Text,
						"','",
						this.txtCOST_ZD_SYS.Text,
						"','",
						this.txtCOST_ZD_YXX.Text,
						"','",
						this.txtCOST_ZD_LCXM.Text,
						"','",
						this.txtCOST_ZL_FSSZLXM.Text,
						"','",
						this.txtCOST_ZL_LCWLZL.Text,
						"','",
						this.txtCOST_ZL_SSZL.Text,
						"','",
						this.txtCOST_ZL_MZ.Text,
						"','",
						this.txtCOST_ZL_SS.Text,
						"','",
						this.txtCOST_KF_KF.Text,
						"','",
						this.txtCOST_ZY_ZYZL.Text,
						"','",
						this.txtCOST_XY_XY.Text,
						"','",
						this.txtCOST_XY_KJYW.Text,
						"','",
						this.txtCOST_ZY_ZCHY.Text,
						"','",
						this.txtCOST_ZY_ZCAOY.Text,
						"','",
						this.txtCOST_XY_XF.Text,
						"','",
						this.txtCOST_XY_BDB.Text,
						"','",
						this.txtCOST_XY_QDB.Text,
						"','",
						this.txtCOST_XY_NXYZ.Text,
						"','",
						this.txtCOST_XY_XBYZ.Text,
						"','",
						this.txtCOST_HC_JC.Text,
						"','",
						this.txtCOST_HC_ZL.Text,
						"','",
						this.txtCOST_HC_SS.Text,
						"','",
						this.txtCOST_OTHER.Text,
						"','",
						EmrSysPubVar.getCurPatientID().Trim().Trim(),
						"',",
						EmrSysPubVar.getCurPatientVisitID(),
						",'",
						this.txtName.Text,
						"','",
						this.txtSex.Text.Trim(),
						"','",
						this.txtMARITAL_STATUS.Text.Trim(),
						"')"
					});
                }
                else
                {
                    sQLString = string.Concat(new object[]
					{
						"UPDATE HQMS_TEMP SET P782 = '",
						(this.txtCOST_TOTAL.Text == "") ? "0.00" : this.txtCOST_TOTAL.Text,
						"',P751 = '",
						this.txtCOST_OWNPAY.Text,
						"',P752 = '",
						this.txtCOST_ZH_YBZL.Text,
						"',P754 = '",
						this.txtCOST_ZH_YBYL.Text,
						"',P755 = '",
						this.txtCOST_ZH_HL.Text,
						"',P756 = '",
						this.txtCOST_ZH_OTHER.Text,
						"',P757 = '",
						this.txtCOST_ZD_BL.Text,
						"',P758 = '",
						this.txtCOST_ZD_SYS.Text,
						"',P759 = '",
						this.txtCOST_ZD_YXX.Text,
						"',P760 = '",
						this.txtCOST_ZD_LCXM.Text,
						"',P761 = '",
						this.txtCOST_ZL_FSSZLXM.Text,
						"',P762 = '",
						this.txtCOST_ZL_LCWLZL.Text,
						"',P763 = '",
						this.txtCOST_ZL_SSZL.Text,
						"',P764 = '",
						this.txtCOST_ZL_MZ.Text,
						"',P765 = '",
						this.txtCOST_ZL_SS.Text,
						"',P767 = '",
						this.txtCOST_KF_KF.Text,
						"',P768 = '",
						this.txtCOST_ZY_ZYZL.Text,
						"',P769 = '",
						this.txtCOST_XY_XY.Text,
						"',P770 = '",
						this.txtCOST_XY_KJYW.Text,
						"',P771 = '",
						this.txtCOST_ZY_ZCHY.Text,
						"',P772 = '",
						this.txtCOST_ZY_ZCAOY.Text,
						"',P773 = '",
						this.txtCOST_XY_XF.Text,
						"',P774 = '",
						this.txtCOST_XY_BDB.Text,
						"',P775 = '",
						this.txtCOST_XY_QDB.Text,
						"',P776 = '",
						this.txtCOST_XY_NXYZ.Text,
						"',P777 = '",
						this.txtCOST_XY_XBYZ.Text,
						"',P778 = '",
						this.txtCOST_HC_JC.Text,
						"',P779 = '",
						this.txtCOST_HC_ZL.Text,
						"',P780 = '",
						this.txtCOST_HC_SS.Text,
						"',P781 = '",
						this.txtCOST_OTHER.Text,
						"'WHERE P3 = '",
						EmrSysPubVar.getCurPatientID().Trim().Trim(),
						"'AND P2 = ",
						EmrSysPubVar.getCurPatientVisitID()
					});
                }
                try
                {
                    DALUse.ExecuteSql(sQLString);
                }
                catch (Exception e)
                {
                    Log.WriteLog(e);
                }
            }
            if (this.m_MRFirstPageDAL.m_dsDiagnosis.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables.Count == 1)
                {
                    this.arrangeDiagnose();
                    this.insertDiagnoseType();
                    this.dgvDiagnose.DataSource = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].DefaultView;
                }
            }
            if (this.m_MRFirstPageDAL.m_dsOperation.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsOperation.Tables.Count == 1)
                {
                    DataTable dataTable = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
                    int count = dataTable.Rows.Count;
                    if (!this.m_bFirstPageIsCommit)
                    {
                        for (int i = 0; i < 3 - count; i++)
                        {
                            DataRow dataRow5 = dataTable.NewRow();
                            dataRow5["patient_id"] = this.m_strPatientID;
                            dataRow5["visit_id"] = this.m_nVisitID;
                            dataRow5["operation_no"] = count + i + 1;
                            dataTable.Rows.Add(dataRow5);
                        }
                    }
                    this.dgvOperation.DataSource = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
                }
            }
        }
        private void arrangeDiagnose()
        {
            if (this.m_MRFirstPageDAL.m_dsDiagnosis.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables.Count == 1)
                {
                    DataTable dataTable = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0];
                    int count = dataTable.Rows.Count;
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        string text = dataRow["diagnosis_type"].ToString();
                        string strDiagnosisNo = dataRow["diagnosis_no"].ToString();
                        dataRow["diagnosis_type_name"] = this.m_MRFirstPageDAL.getDiagnosisTypeName(text);
                        DataSet diagnosisCode = this.m_MRFirstPageDAL.getDiagnosisCode(this.m_strPatientID, this.m_nVisitID.ToString(), text, strDiagnosisNo);
                        if (diagnosisCode.Tables[0].Rows.Count == 1)
                        {
                            string value = diagnosisCode.Tables[0].Rows[0]["diagnosis_code"].ToString();
                            dataRow["code1"] = value;
                        }
                    }
                }
            }
        }
        private void insertDiagnoseType()
        {
            DataTable dtDiagnosisTypeDict = this.m_MRFirstPageDAL.m_dtDiagnosisTypeDict;
            if (dtDiagnosisTypeDict.IsInitialized)
            {
                if (dtDiagnosisTypeDict.Rows.Count > 0)
                {
                    DataTable dataTable = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0];
                    int count = dtDiagnosisTypeDict.Rows.Count;
                    int count2;
                    for (int i = 0; i < count; i++)
                    {
                        count2 = dataTable.Rows.Count;
                        DataRow dataRow = dtDiagnosisTypeDict.Rows[i];
                        string text = dataRow["DICT_CODE"].ToString();
                        bool flag = false;
                        for (int j = 0; j < count2; j++)
                        {
                            DataRow dataRow2 = dataTable.Rows[j];
                            string text2 = dataRow2["diagnosis_type"].ToString();
                            if (text2.Equals(text))
                            {
                                if (flag)
                                {
                                    dataRow2["diagnosis_type_name"] = "";
                                }
                                else
                                {
                                    if (text2.Equals("2"))
                                    {
                                    }
                                    flag = true;
                                }
                            }
                            else
                            {
                                if (flag)
                                {
                                    break;
                                }
                            }
                        }
                        if (!flag && !this.m_bFirstPageIsCommit)
                        {
                            DataRow dataRow3 = dataTable.NewRow();
                            dataRow3["patient_id"] = this.m_strPatientID;
                            dataRow3["visit_id"] = this.m_nVisitID;
                            dataRow3["diagnosis_type"] = text;
                            dataRow3["diagnosis_type_name"] = this.m_MRFirstPageDAL.getDiagnosisTypeName(text);
                            dataRow3["DIAGNOSIS_NO"] = 1;
                            int j;
                            for (j = 0; j < count2; j++)
                            {
                                DataRow dataRow2 = dataTable.Rows[j];
                                string text2 = dataRow2["diagnosis_type"].ToString();
                                if (Convert.ToInt32(text2) > Convert.ToInt32(text))
                                {
                                    break;
                                }
                            }
                            if (j == count2)
                            {
                                dataTable.Rows.Add(dataRow3);
                            }
                            else
                            {
                                dataTable.Rows.InsertAt(dataRow3, j);
                            }
                        }
                    }
                    dataTable.DefaultView.Sort = "DIAGNOSIS_TYPE,DIAGNOSIS_NO";
                    DateTime dateTime = Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Text.Substring(0, 10) + " 00:00:00");
                    DateTime dateTime2;
                    if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
                    {
                        dateTime2 = Convert.ToDateTime(this.txtDISCHARGE_DATE_TIME.Text.Substring(0, 10) + " 23:59:59");
                    }
                    else
                    {
                        dateTime2 = EmrSysPubFunction.getServerNow();
                    }
                    count2 = dataTable.Rows.Count;
                    for (int j = 0; j < count2; j++)
                    {
                        DataRow dataRow2 = dataTable.Rows[j];
                        DateTime dtAfter;
                        if (dataRow2["DIAGNOSIS_TYPE"].ToString().Equals("1"))
                        {
                            dtAfter = dateTime;
                        }
                        else
                        {
                            dtAfter = dateTime2;
                        }
                        if (dataRow2["diagnosis_date"] == DBNull.Value)
                        {
                            dataRow2["diagnosis_date"] = dtAfter.Date.ToShortDateString();
                        }
                        else
                        {
                            if (dataRow2["diagnosis_date"].ToString().Length == 0)
                            {
                                dataRow2["diagnosis_date"] = dtAfter.Date.ToShortDateString();
                            }
                            else
                            {
                                dtAfter = Convert.ToDateTime(dataRow2["diagnosis_date"].ToString());
                            }
                        }
                        if (dataRow2["treat_days"] == DBNull.Value)
                        {
                            dataRow2["treat_days"] = EmrSysPubFunction.GetBetweenDays(dateTime, dtAfter);
                        }
                        else
                        {
                            if (dataRow2["treat_days"].ToString().Length == 0)
                            {
                                dataRow2["treat_days"] = EmrSysPubFunction.GetBetweenDays(dateTime, dtAfter);
                            }
                        }
                    }
                }
            }
        }
        private void dgvDiagnose_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.m_bFirstPageIsCommit)
            {
                if (this.dgvDiagnose.SelectedRows.Count == 1)
                {
                    string name = this.dgvDiagnose.Columns[e.ColumnIndex].Name;
                    if (name.Equals("diagnosis_date"))
                    {
                        frmTimeSel frmTimeSel = new frmTimeSel();
                        if (frmTimeSel.ShowDialog() == DialogResult.OK)
                        {
                            if (DateTime.Parse(frmTimeSel.m_timeSel) < DateTime.Parse(this.txtADMISSION_DATE_TIME.Text.Substring(0, 10)))
                            {
                                MessageBox.Show("诊断日期不能在入院日期之前!");
                            }
                            else
                            {
                                if (this.txtDISCHARGE_DATE_TIME.Text != "")
                                {
                                    if (DateTime.Parse(frmTimeSel.m_timeSel) > DateTime.Parse(this.txtDISCHARGE_DATE_TIME.Text))
                                    {
                                        MessageBox.Show("诊断日期不能在出院日期之后!");
                                    }
                                    else
                                    {
                                        this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["diagnosis_date"] = frmTimeSel.m_timeSel;
                                    }
                                }
                                else
                                {
                                    this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["diagnosis_date"] = frmTimeSel.m_timeSel;
                                }
                            }
                        }
                    }
                    if (name.Equals("diagnosis_desc") || name.Equals("code1"))
                    {
                        codeStruc codeStruc = new codeStruc();
                        if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["DIAGNOSIS_TYPE"].ToString() == "8")
                        {
                            string text = "select a.diagnosis_code,a.clinic_diagnosis_name,a.input_code from emr_clinic_diagnosis a where a.Diagnosis_Code like 'M%/%' ";
                            text += "union select b.diagnosis_code,b.diagnosis_name,b.input_code from diagnosis_dict b ";
                            text += "where  b.diagnosis_code not in (select diagnosis_code from emr_clinic_diagnosis ) and b.Diagnosis_Code like 'M%/%'";
                            codeStruc = EmrSysPubFunction.openCodeInput(text);
                        }
                        else
                        {
                            if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["DIAGNOSIS_TYPE"].ToString() == "7")
                            {
                                string text = "select a.diagnosis_code,a.clinic_diagnosis_name,a.input_code from emr_clinic_diagnosis a ";
                                text += "where a.Diagnosis_Code like 'V%' or a.Diagnosis_Code like 'W%' or a.Diagnosis_Code like 'X%' or a.Diagnosis_Code like 'Y%' or a.Diagnosis_Code like 'v%' or a.Diagnosis_Code like 'w%' or a.Diagnosis_Code like 'x%' or a.Diagnosis_Code like 'y%' ";
                                text += "union select b.diagnosis_code,b.diagnosis_name,b.input_code from diagnosis_dict b where  b.diagnosis_code not in (select diagnosis_code from emr_clinic_diagnosis ) ";
                                text += "and b.Diagnosis_Code like 'V%' or b.Diagnosis_Code like 'W%' or b.Diagnosis_Code like 'X%' or b.Diagnosis_Code like 'Y%' or b.Diagnosis_Code like 'v%' or b.Diagnosis_Code like 'w%' or b.Diagnosis_Code like 'x%' or b.Diagnosis_Code like 'y%'";
                                codeStruc = EmrSysPubFunction.openCodeInput(text);
                            }
                            else
                            {
                                if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["DIAGNOSIS_TYPE"].ToString() == "1" || this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["DIAGNOSIS_TYPE"].ToString() == "2" || this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["DIAGNOSIS_TYPE"].ToString() == "3" || this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["DIAGNOSIS_TYPE"].ToString() == "4")
                                {
                                    string text = "select a.diagnosis_code,a.clinic_diagnosis_name,a.input_code from emr_clinic_diagnosis a ";
                                    text += "where a.Diagnosis_Code not like 'v%' and a.Diagnosis_Code not like 'w%' and a.Diagnosis_Code not like 'x%' and a.Diagnosis_Code not like 'y%' and a.Diagnosis_Code not like 'V%' and a.Diagnosis_Code not like 'W%' and a.Diagnosis_Code not like 'X%' and a.Diagnosis_Code not like 'Y%' and a.Diagnosis_Code not like 'M%/%' ";
                                    text += "union select b.diagnosis_code,b.diagnosis_name,b.input_code from diagnosis_dict b where  b.diagnosis_code not in (select diagnosis_code from emr_clinic_diagnosis ) ";
                                    text += "and b.Diagnosis_Code not like 'v%' and b.Diagnosis_Code not like 'w%' and b.Diagnosis_Code not like 'x%' and b.Diagnosis_Code not like 'y%' and b.Diagnosis_Code not like 'V%' and b.Diagnosis_Code not like 'W%' and b.Diagnosis_Code not like 'X%' and b.Diagnosis_Code not like 'Y%' and b.Diagnosis_Code not like 'M%/%'";
                                    codeStruc = EmrSysPubFunction.openCodeInput(text);
                                }
                                else
                                {
                                    string text = "select a.diagnosis_code,a.clinic_diagnosis_name,a.input_code from emr_clinic_diagnosis a  ";
                                    text += "union select b.diagnosis_code,b.diagnosis_name,b.input_code from diagnosis_dict b ";
                                    text += "where  b.diagnosis_code not in (select diagnosis_code from emr_clinic_diagnosis )";
                                    codeStruc = EmrSysPubFunction.openCodeInput(text);
                                }
                            }
                        }
                        if (codeStruc.codename.Length > 0)
                        {
                            if (name.Equals("diagnosis_desc"))
                            {
                                this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["diagnosis_desc"] = codeStruc.codename;
                                this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["code1"] = codeStruc.codeitem;
                            }
                            else
                            {
                                if (name.Equals("code1"))
                                {
                                    if (EmrSysPubVar.getStationName() != "MRCATALOG")
                                    {
                                        this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["diagnosis_desc"] = codeStruc.codename;
                                    }
                                    this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[e.RowIndex]["code1"] = codeStruc.codeitem;
                                }
                            }
                        }
                    }
                }
            }
        }
        private bool isOnlyRowOfType()
        {
            bool result;
            if (this.dgvDiagnose.SelectedRows.Count != 1)
            {
                result = true;
            }
            else
            {
                if (!this.m_MRFirstPageDAL.m_dsDiagnosis.IsInitialized)
                {
                    result = true;
                }
                else
                {
                    if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables.Count != 1)
                    {
                        result = true;
                    }
                    else
                    {
                        DataGridViewRow dataGridViewRow = this.dgvDiagnose.SelectedRows[0];
                        string text = dataGridViewRow.Cells["diagnosis_type_name"].Value.ToString();
                        result = (text.Length != 0);
                    }
                }
            }
            return result;
        }
        private bool sortDiagnoseNo(bool bDeleteEmptyRow)
        {
            DataTable dataTable = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0];
            if (bDeleteEmptyRow)
            {
                int num = dataTable.Rows.Count;
                int i = 0;
                while (i < num)
                {
                    DataRow dataRow = dataTable.Rows[i];
                    if (dataRow["diagnosis_desc"] == DBNull.Value)
                    {
                        dataTable.Rows.Remove(dataRow);
                        num--;
                    }
                    else
                    {
                        string text = dataRow["diagnosis_desc"].ToString().Trim();
                        if (text.Length == 0 || text == "-")
                        {
                            dataTable.Rows.Remove(dataRow);
                            num--;
                        }
                        else
                        {
                            dataRow["diagnosis_desc"] = text;
                            i++;
                        }
                    }
                }
            }
            int num2 = 1;
            string value = "";
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string text2 = dataRow["diagnosis_type"].ToString();
                if (text2.Equals(value))
                {
                    num2++;
                }
                else
                {
                    value = text2;
                    num2 = 1;
                }
                dataRow["diagnosis_no"] = num2;
            }
            return true;
        }
        private bool validateDiagnose()
        {
            string text = "";
            DateTime dtBefore = Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Text.Substring(0, 10) + " 00:00:00");
            DateTime dtAfter;
            if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
            {
                dtAfter = Convert.ToDateTime(Convert.ToDateTime(this.txtDISCHARGE_DATE_TIME.Text.ToString()).ToShortDateString() + " 23:59:59");
            }
            else
            {
                dtAfter = EmrSysPubFunction.getServerNow();
            }
            int betweenDays = EmrSysPubFunction.GetBetweenDays(dtBefore, dtAfter);
            DataTable dataTable = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0];
            bool result;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string text2 = dataRow["diagnosis_type"].ToString();
                string text3 = dataRow["diagnosis_desc"].ToString();
                text3 = text3.Replace("'", "''");
                if (dataRow["code1"] != DBNull.Value)
                {
                    text = dataRow["code1"].ToString();
                }
                if (text.Trim().Length > 0)
                {
                    if (this.m_MRFirstPageDAL.ValidICDCode(text, "1"))
                    {
                        if (this.intdia == 1)
                        {
                            if (!this.m_MRFirstPageDAL.ICDNameAndCode(text, text3))
                            {
                                MessageBox.Show("" + text3 + "和诊断编码不一致！");
                                result = false;
                                return result;
                            }
                        }
                    }
                    else
                    {
                        if (this.intdia == 1)
                        {
                            MessageBox.Show("" + text + "编码不在ICD库中，请注意！");
                            result = false;
                            return result;
                        }
                    }
                }
                string text4 = text2;
                if (text4 == null)
                {
                    goto IL_1FE;
                }
                if (!(text4 == "8"))
                {
                    goto IL_1FE;
                }
                continue;
            IL_1FE:
                if (text2.Equals("3"))
                {
                    if (dataRow["oper_treat_indicator"] != DBNull.Value)
                    {
                        if (dataRow["oper_treat_indicator"].ToString().Length > 0 && Convert.ToInt32(dataRow["oper_treat_indicator"].ToString()) == 1)
                        {
                            result = true;
                            return result;
                        }
                    }
                }
            }
            result = true;
            return result;
        }
        private bool saveDiagnose()
        {
            IEnumerator enumerator;
            string text;
            if (this.txtCATALOGER.Text.Length > 0)
            {
                enumerator = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        text = string.Concat(new string[]
						{
							"select count(*) from DIAGNOSIS where PATIENT_ID='",
							this.m_strPatientID,
							"' AND visit_id=",
							this.m_nVisitID.ToString(),
							" AND diagnosis_desc='",
							dataRow["diagnosis_desc"].ToString(),
							"'"
						});
                        if (DALUse.GetCount(text) < 1)
                        {
                            text = "update pat_visit set CATALOGER='' where PATIENT_ID='" + this.m_strPatientID + "' AND visit_id=" + this.m_nVisitID.ToString();
                            DALUse.ExecuteSql(text);
                            this.txtCATALOGER.Text = "";
                            break;
                        }
                    }
                }
                finally
                {
                    IDisposable disposable = enumerator as IDisposable;
                    if (disposable != null)
                    {
                        disposable.Dispose();
                    }
                }
            }
            text = "DELETE FROM DIAGNOSIS WHERE PATIENT_ID='" + this.m_strPatientID + "' AND visit_id=" + this.m_nVisitID.ToString();
            DALUse.ExecuteSql(text);
            text = "DELETE FROM DIAGNOSTIC_CATEGORY WHERE PATIENT_ID='" + this.m_strPatientID + "' AND visit_id=" + this.m_nVisitID.ToString();
            DALUse.ExecuteSql(text);
            bool result = true;
            DataTable dataTable = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0];
            enumerator = dataTable.Rows.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    DataRow dataRow = (DataRow)enumerator.Current;
                    string str = dataRow["diagnosis_type"].ToString();
                    DateTime dateTime = Convert.ToDateTime(EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd"));
                    if (dataRow["diagnosis_date"] != DBNull.Value)
                    {
                        dateTime = Convert.ToDateTime(dataRow["diagnosis_date"].ToString());
                    }
                    string text2 = dataRow["diagnosis_desc"].ToString();
                    text2 = text2.Replace("'", "’");
                    string str2 = dataRow["diagnosis_desc_part"].ToString().Replace("'", "’");
                    string str3 = dataRow["treat_result"].ToString();
                    int num = Convert.ToInt32(dataRow["diagnosis_no"].ToString());
                    int num2 = 0;
                    if (dataRow["oper_treat_indicator"] != DBNull.Value && dataRow["oper_treat_indicator"].ToString().Length > 0)
                    {
                        num2 = Convert.ToInt32(dataRow["oper_treat_indicator"].ToString());
                    }
                    string text3 = "";
                    if (dataRow["code1"] != DBNull.Value)
                    {
                        text3 = dataRow["code1"].ToString();
                    }
                    string str4 = dataRow["ADMISSION_CONDITIONS"].ToString();
                    text = "INSERT INTO DIAGNOSIS (PATIENT_ID,VISIT_ID,DIAGNOSIS_TYPE,DIAGNOSIS_NO,";
                    text += "DIAGNOSIS_DESC,DIAGNOSIS_DESC_PART,OPER_TREAT_INDICATOR,TREAT_RESULT,DIAGNOSIS_DATE,ADMISSION_CONDITIONS) VALUES (";
                    text = text + "'" + this.m_strPatientID + "',";
                    text = text + "'" + this.m_nVisitID.ToString() + "',";
                    text = text + "'" + str + "',";
                    text = text + num + ",";
                    text = text + "'" + text2 + "',";
                    text = text + "'" + str2 + "',";
                    text = text + num2.ToString() + ",";
                    text = text + "'" + str3 + "',";
                    text = text + DBCustomFunctionUse.ToDate(dateTime.ToShortDateString(), true, false) + ",";
                    text = text + "'" + str4 + "')";
                    DALUse.ExecuteSql(text);
                    if (text3 != "")
                    {
                        text = "INSERT INTO DIAGNOSTIC_CATEGORY (PATIENT_ID,VISIT_ID,DIAGNOSIS_TYPE,DIAGNOSIS_NO,DIAGNOSIS_CODE) ";
                        text += "VALUES (";
                        text = text + "'" + this.m_strPatientID + "',";
                        text = text + "'" + this.m_nVisitID.ToString() + "',";
                        text = text + "'" + str + "',";
                        text = text + num + ",";
                        text = text + "'" + text3 + "')";
                        DALUse.ExecuteSql(text);
                    }
                }
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            }
            return result;
        }
        private void dgvDiagnose_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (!this.m_bFirstPageIsCommit)
                {
                    DataTable dataTable = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0];
                    DataRow dataRow = dataTable.Rows[e.RowIndex];
                    string text = this.dgvDiagnose.Columns[e.ColumnIndex].Name.ToLower();
                    DateTime dtBefore = Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Text.Substring(0, 10) + " 00:00:00");
                    DateTime dtAfter;
                    if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
                    {
                        dtAfter = Convert.ToDateTime(this.txtDISCHARGE_DATE_TIME.Text.Substring(0, 10) + " 00:00:00");
                    }
                    else
                    {
                        dtAfter = EmrSysPubFunction.getServerNow();
                    }
                    int betweenDays = EmrSysPubFunction.GetBetweenDays(dtBefore, dtAfter);
                    DataGridViewCell dataGridViewCell = this.dgvDiagnose.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (dataGridViewCell != null)
                    {
                        string text2 = text;
                        if (text2 != null)
                        {
                            if (!(text2 == "diagnosis_desc"))
                            {
                            }
                        }
                    }
                }
            }
        }
        private void dgvOperation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvOperation.SelectedRows.Count == 1)
            {
                if (!this.m_bFirstPageIsCommit)
                {
                    DataTable dataTable = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
                    DataRow dataRow = dataTable.Rows[e.RowIndex];
                    string name = this.dgvOperation.Columns[e.ColumnIndex].Name;
                    if (name.Equals("operation_desc") || name.Equals("operation_code"))
                    {
                        codeStruc codeStruc = new codeStruc();
                        codeStruc = EmrSysPubFunction.openCodeInput("operc", "");
                        if (codeStruc.codename.Length > 0)
                        {
                            if (name.Equals("operation_desc"))
                            {
                                dataRow["operation_desc"] = codeStruc.codename;
                                dataRow["operation_code"] = codeStruc.codeitem;
                            }
                            else
                            {
                                if (name.Equals("operation_code"))
                                {
                                    if (EmrSysPubVar.getStationName() != "MRCATALOG")
                                    {
                                        dataRow["operation_desc"] = codeStruc.codename;
                                    }
                                    dataRow["operation_code"] = codeStruc.codeitem;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (name.Equals("OPERATION_DEPT_CODE"))
                        {
                            codeStruc codeStruc = new codeStruc();
                            string strSql = "select distinct  转科后科室 as code,转科后科室 as name,'' as input_code from 住院转科记录@dl_his where 住院号='" + this.m_strPatientID + "' and 住院序号=" + this.m_nVisitID.ToString();
                            codeStruc = EmrSysPubFunction.openCodeInput(strSql);
                            if (codeStruc.codename.Length > 0)
                            {
                                dataRow["OPERATION_DEPT"] = codeStruc.codename;
                                dataRow["OPERATION_DEPT_CODE"] = codeStruc.codeitem;
                                return;
                            }
                        }
                        if (name.Equals("operating_date"))
                        {
                            frmTimeSel frmTimeSel = new frmTimeSel();
                            if (frmTimeSel.ShowDialog() == DialogResult.OK)
                            {
                                if (DateTime.Parse(frmTimeSel.m_timeSel) < DateTime.Parse(this.txtADMISSION_DATE_TIME.Text.Substring(0, 10)))
                                {
                                    MessageBox.Show("手术日期不能在入院日期之前!");
                                }
                                else
                                {
                                    if (this.txtDISCHARGE_DATE_TIME.Text != "")
                                    {
                                        if (DateTime.Parse(frmTimeSel.m_timeSel) > DateTime.Parse(this.txtDISCHARGE_DATE_TIME.Text))
                                        {
                                            MessageBox.Show("手术日期不能在出院日期之后!");
                                        }
                                        else
                                        {
                                            dataRow["operating_date"] = frmTimeSel.m_timeSel;
                                        }
                                    }
                                    else
                                    {
                                        dataRow["operating_date"] = frmTimeSel.m_timeSel;
                                    }
                                }
                            }
                        }
                        if (name.Equals("operator1"))
                        {
                            frmSelectDeptUser frmSelectDeptUser = new frmSelectDeptUser();
                            if (frmSelectDeptUser.ShowDialog() == DialogResult.OK)
                            {
                                dataRow["operator"] = frmSelectDeptUser.m_strName.Trim();
                            }
                        }
                        if (name.Equals("first_assistant"))
                        {
                            frmSelectDeptUser frmSelectDeptUser = new frmSelectDeptUser();
                            if (frmSelectDeptUser.ShowDialog() == DialogResult.OK)
                            {
                                dataRow["first_assistant"] = frmSelectDeptUser.m_strName.Trim();
                            }
                        }
                        if (name.Equals("second_assistant"))
                        {
                            frmSelectDeptUser frmSelectDeptUser = new frmSelectDeptUser();
                            if (frmSelectDeptUser.ShowDialog() == DialogResult.OK)
                            {
                                dataRow["second_assistant"] = frmSelectDeptUser.m_strName.Trim();
                            }
                        }
                        if (name.Equals("anesthesia_doctor"))
                        {
                            frmSelectDeptUser frmSelectDeptUser = new frmSelectDeptUser();
                            frmSelectDeptUser.m_nanesthesia_doctor = 1;
                            if (frmSelectDeptUser.ShowDialog() == DialogResult.OK)
                            {
                                dataRow["anesthesia_doctor"] = frmSelectDeptUser.m_strName.Trim();
                            }
                        }
                    }
                }
            }
        }
        private void dgvOperation_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!this.m_bFirstPageIsCommit)
                {
                    DateTime t = Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Text.Substring(0, 10) + " 00:00:00");
                    DateTime dateTime;
                    if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
                    {
                        dateTime = Convert.ToDateTime(Convert.ToDateTime(this.txtDISCHARGE_DATE_TIME.Text.ToString()).ToShortDateString().Substring(0, 10) + " 00:00:00");
                    }
                    else
                    {
                        dateTime = EmrSysPubFunction.getServerNow();
                    }
                    DataTable dataTable = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
                    DataRow dataRow = dataTable.Rows[e.RowIndex];
                    string text = this.dgvOperation.Columns[e.ColumnIndex].Name.ToLower();
                    string text2 = text;
                    if (text2 != null)
                    {
                        if (text2 == "operating_date")
                        {
                            if (dataRow["operating_date"] != DBNull.Value)
                            {
                                if (dataRow["operating_date"].ToString().Length == 0)
                                {
                                    MessageBox.Show("手术日期不能为空!");
                                    dataRow["operating_date"] = DBNull.Value;
                                }
                                else
                                {
                                    DateTime t2 = Convert.ToDateTime(dataRow["operating_date"].ToString());
                                    if (t2 < t || t2 > dateTime)
                                    {
                                        MessageBox.Show("手术的日期应在入院日期与出院日期之间!");
                                        dataRow["operating_date"] = dateTime;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void sortOperation()
        {
            DataTable dataTable = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
            int num = dataTable.Rows.Count;
            int i = 0;
            while (i < num)
            {
                DataRow dataRow = dataTable.Rows[i];
                if (dataRow["operation_desc"] == DBNull.Value)
                {
                    dataTable.Rows.Remove(dataRow);
                    num--;
                }
                else
                {
                    string text = dataRow["operation_desc"].ToString().Trim();
                    if (text.Length == 0)
                    {
                        dataTable.Rows.Remove(dataRow);
                        num--;
                    }
                    else
                    {
                        dataRow["operation_desc"] = text;
                        i++;
                    }
                }
            }
            int num2 = 1;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                dataRow["OPERATION_NO"] = num2;
                num2++;
            }
        }
        private bool validateOperation()
        {
            DateTime t = Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Text.Substring(0, 10) + " 00:00:00");
            DateTime t2;
            if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
            {
                t2 = Convert.ToDateTime(Convert.ToDateTime(this.txtDISCHARGE_DATE_TIME.Text.ToString()).ToShortDateString() + " 23:59:59");
            }
            else
            {
                t2 = EmrSysPubFunction.getServerNow();
            }
            DataTable dataTable = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
            bool result;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["operating_date"] != DBNull.Value)
                {
                    if (dataRow["operating_date"].ToString().Length == 0)
                    {
                        MessageBox.Show("手术日期不能为空!");
                        result = false;
                        return result;
                    }
                    DateTime t3 = Convert.ToDateTime(dataRow["operating_date"].ToString());
                    if (t3 < t || t3 > t2)
                    {
                        MessageBox.Show("手术的日期应在入院日期与出院日期之间!");
                        result = false;
                        return result;
                    }
                    if (dataRow["operator"] == DBNull.Value)
                    {
                        MessageBox.Show("请填写手术医师!");
                        result = false;
                        return result;
                    }
                    if (dataRow["operator"].ToString().Length > 4)
                    {
                        MessageBox.Show("手术医师长度为" + dataRow["operator"].ToString().Length + "，超出打印范围，请重新录入！");
                        result = false;
                        return result;
                    }
                    if (dataRow["operator"].ToString().Trim().Length == 0)
                    {
                        MessageBox.Show("请填写手术医师!");
                        result = false;
                        return result;
                    }
                }
            }
            result = true;
            return result;
        }
        private bool saveOpertation()
        {
            bool result = true;
            IEnumerator enumerator;
            string text;
            if (this.txtCATALOGER.Text.Length > 0)
            {
                enumerator = this.m_MRFirstPageDAL.m_dsOperation.Tables[0].Rows.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        text = string.Concat(new string[]
						{
							"select count(*) from operation where PATIENT_ID='",
							this.m_strPatientID,
							"' AND visit_id=",
							this.m_nVisitID.ToString(),
							" AND operation_desc='",
							dataRow["operation_desc"].ToString(),
							"'"
						});
                        if (DALUse.GetCount(text) < 1)
                        {
                            text = "update pat_visit set CATALOGER='' where PATIENT_ID='" + this.m_strPatientID + "' AND visit_id=" + this.m_nVisitID.ToString();
                            DALUse.ExecuteSql(text);
                            this.txtCATALOGER.Text = "";
                            break;
                        }
                    }
                }
                finally
                {
                    IDisposable disposable = enumerator as IDisposable;
                    if (disposable != null)
                    {
                        disposable.Dispose();
                    }
                }
            }
            text = "DELETE FROM operation WHERE PATIENT_ID='" + this.m_strPatientID + "' AND visit_id=" + this.m_nVisitID.ToString();
            DALUse.ExecuteSql(text);
            DataTable dataTable = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
            enumerator = dataTable.Rows.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    DataRow dataRow = (DataRow)enumerator.Current;
                    string str = dataRow["operation_no"].ToString();
                    string str2 = "";
                    if (dataRow["operation_code"] != DBNull.Value)
                    {
                        str2 = dataRow["operation_code"].ToString();
                    }
                    string str3 = "";
                    if (dataRow["operation_desc_part"] != DBNull.Value)
                    {
                        str3 = dataRow["operation_desc_part"].ToString().Replace("'", "’");
                    }
                    string text2 = dataRow["operation_desc"].ToString();
                    text2 = text2.Replace("'", "’");
                    string str4 = "";
                    if (dataRow["wound_grade"] != DBNull.Value)
                    {
                        str4 = dataRow["wound_grade"].ToString();
                    }
                    string str5 = "";
                    if (dataRow["first_assistant"] != DBNull.Value)
                    {
                        str5 = dataRow["first_assistant"].ToString();
                    }
                    string str6 = "";
                    if (dataRow["OPERATING_GRADE"] != DBNull.Value)
                    {
                        str6 = dataRow["OPERATING_GRADE"].ToString();
                    }
                    string str7 = "";
                    if (dataRow["STERILE_HEAL"] != DBNull.Value)
                    {
                        str7 = dataRow["STERILE_HEAL"].ToString();
                    }
                    string str8 = "";
                    if (dataRow["second_assistant"] != DBNull.Value)
                    {
                        str8 = dataRow["second_assistant"].ToString();
                    }
                    string str9 = "";
                    if (dataRow["anesthesia_doctor"] != DBNull.Value)
                    {
                        str9 = dataRow["anesthesia_doctor"].ToString();
                    }
                    DateTime dateTime = Convert.ToDateTime(EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd"));
                    if (dataRow["operating_date"] != DBNull.Value)
                    {
                        dateTime = Convert.ToDateTime(dataRow["operating_date"].ToString());
                    }
                    string str10 = "";
                    if (dataRow["anaesthesia_method"] != DBNull.Value)
                    {
                        str10 = dataRow["anaesthesia_method"].ToString();
                    }
                    string str11 = "";
                    if (dataRow["OPERATOR"] != DBNull.Value)
                    {
                        str11 = dataRow["OPERATOR"].ToString();
                    }
                    string str12 = "";
                    if (dataRow["OPERATION_DEPT_CODE"] != DBNull.Value)
                    {
                        str12 = dataRow["OPERATION_DEPT_CODE"].ToString();
                    }
                    if (dataRow["OPERATION_DEPT"] != DBNull.Value)
                    {
                        string text3 = dataRow["OPERATION_DEPT"].ToString();
                    }
                    string str13 = "";
                    if (dataRow["OPERATION_TYPE"] != DBNull.Value)
                    {
                        str13 = dataRow["OPERATION_TYPE"].ToString();
                    }
                    string str14 = "";
                    if (dataRow["HEAL"] != DBNull.Value)
                    {
                        str14 = dataRow["HEAL"].ToString();
                    }
                    string str15 = "";
                    if (dataRow["ISMAIN"] != DBNull.Value)
                    {
                        str15 = dataRow["ISMAIN"].ToString();
                    }
                    string str16 = "";
                    if (dataRow["INFFECT"] != DBNull.Value)
                    {
                        str16 = dataRow["INFFECT"].ToString();
                    }
                    string str17 = "";
                    if (dataRow["OPERACCORD"] != DBNull.Value)
                    {
                        str17 = dataRow["OPERACCORD"].ToString();
                    }
                    string str18 = "";
                    if (dataRow["ILLNESS"] != DBNull.Value)
                    {
                        str17 = dataRow["ILLNESS"].ToString();
                    }
                    text = "INSERT INTO operation (PATIENT_ID,VISIT_ID,OPERATION_NO, OPERATION_DESC,OPERATION_CODE,HEAL,WOUND_GRADE,OPERATING_DATE,ANAESTHESIA_METHOD,OPERATOR,first_assistant,second_assistant,anesthesia_doctor,OPERATION_DESC_PART,OPERATION_DEPT_CODE,OPERATING_GRADE,OPERATION_TYPE,ISMAIN,INFFECT,ILLNESS,STERILE_HEAL,OPERACCORD) VALUES(";
                    text = text + "'" + this.m_strPatientID + "',";
                    text = text + this.m_nVisitID.ToString() + ",";
                    text = text + str + ",";
                    text = text + "'" + text2 + "',";
                    text = text + "'" + str2 + "',";
                    text = text + "'" + str14 + "',";
                    text = text + "'" + str4 + "',";
                    text = text + DBCustomFunctionUse.ToDate(dateTime.ToShortDateString(), true, false) + ",";
                    text = text + "'" + str10 + "',";
                    text = text + "'" + str11 + "',";
                    text = text + "'" + str5 + "',";
                    text = text + "'" + str8 + "',";
                    text = text + "'" + str9 + "',";
                    text = text + "'" + str3 + "',";
                    text = text + "'" + str12 + "',";
                    text = text + "'" + str6 + "',";
                    text = text + "'" + str13 + "',";
                    text = text + "'" + str15 + "',";
                    text = text + "'" + str16 + "',";
                    text = text + "'" + str18 + "',";
                    text = text + "'" + str7 + "',";
                    text = text + "'" + str17 + "')";
                    DALUse.ExecuteSql(text);
                }
            }
            finally
            {
                IDisposable disposable = enumerator as IDisposable;
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            }
            return result;
        }
        private bool validatePatvisit()
        {
            if (this.txtAUTOPSY_INDICATOR.Text == "1")
            {
                this.txtdischarge_disposition.Text = "死亡";
                this.txtdischarge_disposition.Tag = "死亡";
            }
            bool result;
            if (this.txtID_NO.Text.ToString().Length > 18)
            {
                MessageBox.Show("身份证号码不能大于18位!请重新输入");
                result = false;
            }
            else
            {
                if (this.txtZIP_CODE.Text.ToString().Length > 6)
                {
                    MessageBox.Show("工作单位的邮政编码不能大于6位");
                    result = false;
                }
                else
                {
                    if (this.txtHKZIP_CODE.Text.ToString().Length > 6)
                    {
                        MessageBox.Show("户口邮政编码不能大于6位");
                        result = false;
                    }
                    else
                    {
                        if (this.txtNATION.Text.ToString().Length > 10)
                        {
                            MessageBox.Show("民族超出数据库定义10个汉字，请重新录入！");
                            result = false;
                        }
                        else
                        {
                            if (this.txtBIRTH_PLACE.Text.ToString().Length > 40)
                            {
                                MessageBox.Show("出生地超出数据库定义40个汉字！");
                                result = false;
                            }
                            else
                            {
                                if (this.txtRELATIONSHIP.Text.ToString().Length > 14)
                                {
                                    MessageBox.Show("与联系人关系超出数据库定义14个汉字！");
                                    result = false;
                                }
                                else
                                {
                                    if (this.txtPHONE_NUMBER_BUSINESS.Text.ToString().Length > 16)
                                    {
                                        MessageBox.Show("联系电话超出数据库定义16个字符！");
                                        result = false;
                                    }
                                    else
                                    {
                                        if (this.txtSERVICE_AGENCY.Text.ToString().Length > 50)
                                        {
                                            MessageBox.Show("工作单位及地址超出数据库定义50个汉字！");
                                            result = false;
                                        }
                                        else
                                        {
                                            if (this.txtOCCUPATION.Text.Length > 20)
                                            {
                                                MessageBox.Show("职业超出数据库定义20个汉字！");
                                                result = false;
                                            }
                                            else
                                            {
                                                if (this.txtMAILING_ADDRESS.Text.Length > 80)
                                                {
                                                    MessageBox.Show("户口地址超出数据库定义80个汉字！");
                                                    result = false;
                                                }
                                                else
                                                {
                                                    if (this.txtCITIZENSHIP.Text.Length > 28)
                                                    {
                                                        MessageBox.Show("国籍超出数据库定义28个汉字！");
                                                        result = false;
                                                    }
                                                    else
                                                    {
                                                        if (this.txtNEXT_OF_KIN.Text.Length > 30)
                                                        {
                                                            MessageBox.Show("联系人超出数据库定义30个汉字！");
                                                            result = false;
                                                        }
                                                        else
                                                        {
                                                            if (this.txtNEXT_OF_KIN_ADDR.Text.Length > 80)
                                                            {
                                                                MessageBox.Show("联系人地址超出数据库定义80个汉字！");
                                                                result = false;
                                                            }
                                                            else
                                                            {
                                                                if (this.txtALERGY_DRUGS.Text != "")
                                                                {
                                                                    this.txtALERGY_DRUGS.Text = this.txtALERGY_DRUGS.Text.Trim();
                                                                }
                                                                if (this.txtDIRECTOR.Text != "")
                                                                {
                                                                    this.txtDIRECTOR.Text = this.txtDIRECTOR.Text.Trim();
                                                                }
                                                                if (this.txtATTENDING_DOCTOR.Text != "")
                                                                {
                                                                    this.txtATTENDING_DOCTOR.Text = this.txtATTENDING_DOCTOR.Text.Trim();
                                                                }
                                                                if (this.txtDOCTOR_IN_CHARGE.Text != "")
                                                                {
                                                                    this.txtDOCTOR_IN_CHARGE.Text = this.txtDOCTOR_IN_CHARGE.Text.Trim();
                                                                }
                                                                DateTime dateTime = Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Text.Substring(0, 10) + " 00:00:00");
                                                                DateTime dateTime2;
                                                                if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
                                                                {
                                                                    dateTime2 = Convert.ToDateTime(Convert.ToDateTime(this.txtDISCHARGE_DATE_TIME.Text.ToString()).ToString("yyyy-MM-dd HH:mm").ToString());
                                                                }
                                                                else
                                                                {
                                                                    dateTime2 = Convert.ToDateTime(EmrSysPubFunction.getServerNow().ToString());
                                                                }
                                                                if (this.txtDATE_OF_CONTROL_QUALITY.Text.Length > 0)
                                                                {
                                                                    DateTime t = Convert.ToDateTime(this.txtDATE_OF_CONTROL_QUALITY.Text);
                                                                    if (t < dateTime2)
                                                                    {
                                                                        MessageBox.Show("质控日期不能小于出院日期!");
                                                                        result = false;
                                                                        return result;
                                                                    }
                                                                }
                                                                if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
                                                                {
                                                                    dateTime2 = Convert.ToDateTime(this.txtDISCHARGE_DATE_TIME.Text);
                                                                    dateTime = Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Text);
                                                                    if (dateTime2 < dateTime)
                                                                    {
                                                                        MessageBox.Show("出院时间不能大于入院时间!");
                                                                        result = false;
                                                                        return result;
                                                                    }
                                                                }
                                                                int betweenDays = EmrSysPubFunction.GetBetweenDays(dateTime, dateTime2);
                                                                if (this.txtDIRECTOR.Text.Trim().Length > 0)
                                                                {
                                                                    if (this.txtDIRECTOR.Tag == null)
                                                                    {
                                                                        this.txtDIRECTOR.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtDIRECTOR.Text.Trim());
                                                                    }
                                                                }
                                                                if (this.txtCHIEF_DOCTOR.Text.Trim().Length > 0)
                                                                {
                                                                    if (this.txtCHIEF_DOCTOR.Tag == null)
                                                                    {
                                                                        this.txtCHIEF_DOCTOR.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtCHIEF_DOCTOR.Text.Trim());
                                                                    }
                                                                }
                                                                if (this.txtATTENDING_DOCTOR.Text.Trim().Length > 0)
                                                                {
                                                                    if (this.txtATTENDING_DOCTOR.Tag == null)
                                                                    {
                                                                        this.txtATTENDING_DOCTOR.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtATTENDING_DOCTOR.Text.Trim());
                                                                    }
                                                                }
                                                                if (this.txtDOCTOR_IN_CHARGE.Text.Trim().Length > 0)
                                                                {
                                                                    if (this.txtDOCTOR_IN_CHARGE.Tag == null)
                                                                    {
                                                                        this.txtDOCTOR_IN_CHARGE.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtDOCTOR_IN_CHARGE.Text.Trim());
                                                                    }
                                                                }
                                                                if (this.txtLIABILITY_NURSE_ID.Text.Trim().Length > 0)
                                                                {
                                                                    if (this.txtLIABILITY_NURSE_ID.Tag == null)
                                                                    {
                                                                        this.txtLIABILITY_NURSE_ID.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtLIABILITY_NURSE_ID.Text.Trim());
                                                                    }
                                                                }
                                                                if (this.txtPRACTICE_DOCTOR.Text.Trim().Length > 0)
                                                                {
                                                                    if (this.txtPRACTICE_DOCTOR.Tag == null)
                                                                    {
                                                                        this.txtPRACTICE_DOCTOR.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtPRACTICE_DOCTOR.Text.Trim());
                                                                    }
                                                                }
                                                                result = true;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool Save()
        {
            bool result;
            if (this.m_bFirstPageIsCommit)
            {
                result = false;
            }
            else
            {
                if (!this.validatePatvisit())
                {
                    result = false;
                }
                else
                {
                    this.dgvOperation.EndEdit();
                    this.sortOperation();
                    if (!this.validateOperation())
                    {
                        result = false;
                    }
                    else
                    {
                        this.dgvDiagnose.EndEdit();
                        if (!this.sortDiagnoseNo(true))
                        {
                            result = false;
                        }
                        else
                        {
                            if (!this.validateDiagnose())
                            {
                                this.insertDiagnoseType();
                                result = false;
                            }
                            else
                            {
                                this.saveOpertation();
                                string text = "UPDATE PAT_MASTER_INDEX SET name='" + this.txtName.Text + "',";
                                text = text + "CHARGE_TYPE='" + this.txtMedical_pay_way.Text.ToString() + "',";
                                text = text + "sex='" + this.txtSex.Tag.ToString() + "',";
                                text = text + "date_of_birth= " + DBCustomFunctionUse.ToDate(this.txtDate_of_birth.Tag.ToString(), false, false) + ",";
                                text = text + "BIRTH_PLACE='" + this.txtBIRTH_PLACE.Text + "',";
                                text = text + "XIAN_PLACE='" + this.txtXIAN_PLACE.Text + "',";
                                text = text + "XIAN_PHOTO='" + this.txtXIAN_PHOTO.Text + "',";
                                text = text + "XIAN_CODE='" + this.txtXIAN_CODE.Text + "',";
                                text = text + "JIGUAN='" + this.txtJIGUAN.Text + "',";
                                text = text + "NATION='" + this.txtNATION.Text + "',";
                                text = text + "CITIZENSHIP='" + this.txtCITIZENSHIP.Text + "',";
                                text = text + "ID_NO='" + this.txtID_NO.Text + "',";
                                text = text + "BABY_WEIGHT='" + this.txtBABY_WEIGHT.Text + "',";
                                text = text + "BABY_R_WEIGHT='" + this.txtBABY_R_WEIGHT.Text + "',";
                                text = text + "PHONE_NUMBER_BUSINESS='" + this.txtPHONE_NUMBER_BUSINESS.Text + "',";
                                string text2 = text;
                                text = string.Concat(new string[]
								{
									text2,
									"ZIP_CODE='",
									this.txtZIP_CODE.Text,
									"' WHERE PATIENT_ID='",
									this.m_strPatientID,
									"'"
								});
                                DALUse.ExecuteSql(text);
                                text = "UPDATE PAT_VISIT SET MARITAL_STATUS='" + this.txtMARITAL_STATUS.Tag + "',";
                                text = text + "CHARGE_TYPE='" + this.txtMedical_pay_way.Text.ToString() + "',";
                                text = text + "DISCHARGE_CONDITIONS='" + this.txtDISCHARGE_CONDITIONS.Text + "',";
                                text = text + "MEDICAL_PAY_WAY='" + this.txtMedical_pay_way.Text.ToString() + "',";
                                text = text + "INSURANCE_TYPE='" + this.txtMedical_pay_way.Text.ToString() + "',";
                                text = text + "OCCUPATION='" + this.txtOCCUPATION.Text + "',";
                                text = text + "SERVICE_AGENCY='" + this.txtSERVICE_AGENCY.Text + "',";
                                text = text + "ZIP_CODE='" + this.txtHKZIP_CODE.Text + "',";
                                text = text + "NEXT_OF_KIN='" + this.txtNEXT_OF_KIN.Text + "',";
                                text = text + "NEXT_OF_KIN_ADDR='" + this.txtNEXT_OF_KIN_ADDR.Text + "',";
                                text = text + "NEXT_OF_KIN_PHONE='" + this.txtNEXT_OF_KIN_PHONE.Text + "',";
                                text = text + "RELATIONSHIP='" + this.txtRELATIONSHIP.Text + "',";
                                text = text + "MAILING_ADDRESS='" + this.txtMAILING_ADDRESS.Text + "',";
                                text = text + "bed_label='" + this.txtward_discharge_from.Text.ToString() + "',";
                                if (this.txtDISCHARGE_DATE_TIME.Text.Length > 0)
                                {
                                    text = text + "DISCHARGE_DATE_TIME=to_date('" + this.txtDISCHARGE_DATE_TIME.Text + "', 'YYYY-MM-DD HH24:MI:SS'),";
                                }
                                else
                                {
                                    text += "DISCHARGE_DATE_TIME=null,";
                                }
                                if (this.txtDEPT_DISCHARGE_FROM.Text.Length > 0)
                                {
                                    text = text + "DEPT_DISCHARGE_FROM='" + MRFirstPageDAL.getDeptCode(this.txtDEPT_DISCHARGE_FROM.Text.ToString()) + "',";
                                }
                                else
                                {
                                    text += "DEPT_DISCHARGE_FROM=null,";
                                }
                                text = text + "RUYUAN_PASS='" + this.txtRUYUAN_PASS.Tag.ToString() + "',";
                                text = text + "ALERGY_DRUGS='" + this.txtALERGY_DRUGS.Text + "',";
                                text = text + "ZYMC='" + this.txtZYMC.Text + "',";
                                text = text + "ZYJG='" + this.txtZYJG.Text + "',";
                                text = text + "ZYMD='" + this.txtZYMD.Text + "',";
                                text = text + "WZYMD='" + this.txtWZYMD.Text + "',";
                                text = text + "ADVANCED_STUDIES_DOCTOR='" + this.txtADVANCED_STUDIES_DOCTOR.Text.Replace("'", "''") + "',";
                                if (this.txtADVANCED_STUDIES_DOCTOR.Text.Length == 0)
                                {
                                    text += "ADVANCED_STUDIES_DOCTOR_ID=null,";
                                }
                                else
                                {
                                    object obj = text;
                                    text = string.Concat(new object[]
									{
										obj,
										"ADVANCED_STUDIES_DOCTOR_ID='",
										this.txtADVANCED_STUDIES_DOCTOR.Tag,
										"',"
									});
                                }
                                text = text + "DIRECTOR='" + this.txtDIRECTOR.Text.Replace("'", "''") + "',";
                                if (this.txtDIRECTOR.Text.Length == 0)
                                {
                                    text += "DIRECTOR_ID=null,";
                                }
                                else
                                {
                                    object obj = text;
                                    text = string.Concat(new object[]
									{
										obj,
										"DIRECTOR_ID='",
										this.txtDIRECTOR.Tag,
										"',"
									});
                                }
                                text = text + "CHIEF_DOCTOR='" + this.txtCHIEF_DOCTOR.Text.Replace("'", "''") + "',";
                                if (this.txtCHIEF_DOCTOR.Text.Length == 0)
                                {
                                    text += "CHIEF_DOCTOR_ID=null,";
                                }
                                else
                                {
                                    object obj = text;
                                    text = string.Concat(new object[]
									{
										obj,
										"CHIEF_DOCTOR_ID='",
										this.txtCHIEF_DOCTOR.Tag,
										"',"
									});
                                }
                                text = text + "ATTENDING_DOCTOR='" + this.txtATTENDING_DOCTOR.Text.Replace("'", "''") + "',";
                                if (this.txtATTENDING_DOCTOR.Text.Length == 0)
                                {
                                    text += "ATTENDING_DOCTOR_ID=null,";
                                }
                                else
                                {
                                    object obj = text;
                                    text = string.Concat(new object[]
									{
										obj,
										"ATTENDING_DOCTOR_ID='",
										this.txtATTENDING_DOCTOR.Tag,
										"',"
									});
                                }
                                text = text + "DOCTOR_IN_CHARGE='" + this.txtDOCTOR_IN_CHARGE.Text.Replace("'", "''") + "',";
                                if (this.txtDOCTOR_IN_CHARGE.Text.Length == 0)
                                {
                                    text += "DOCTOR_IN_CHARGE_ID=null,";
                                }
                                else
                                {
                                    object obj = text;
                                    text = string.Concat(new object[]
									{
										obj,
										"DOCTOR_IN_CHARGE_ID='",
										this.txtDOCTOR_IN_CHARGE.Tag,
										"',"
									});
                                }
                                text = text + "LIABILITY_NURSE='" + this.txtLIABILITY_NURSE_ID.Text.Replace("'", "''") + "',";
                                if (this.txtLIABILITY_NURSE_ID.Text.Length == 0)
                                {
                                    text += "LIABILITY_NURSE_ID=null,";
                                }
                                else
                                {
                                    object obj = text;
                                    text = string.Concat(new object[]
									{
										obj,
										"LIABILITY_NURSE_ID='",
										this.txtLIABILITY_NURSE_ID.Tag,
										"',"
									});
                                }
                                text = text + "PRACTICE_DOCTOR='" + this.txtPRACTICE_DOCTOR.Text.Replace("'", "''") + "',";
                                if (this.txtPRACTICE_DOCTOR.Text.Length == 0)
                                {
                                    text += "PRACTICE_DOCTOR_ID=null,";
                                }
                                else
                                {
                                    object obj = text;
                                    text = string.Concat(new object[]
									{
										obj,
										"PRACTICE_DOCTOR_ID='",
										this.txtPRACTICE_DOCTOR.Tag,
										"',"
									});
                                }
                                text = text + "LNSS_P_HOSPITAL_DAYS = '" + this.txtLNSS_P_HOSPITAL_DAYS.Text.ToString().Trim() + "',";
                                text = text + "LNSS_P_HOSPITAL_HOURS = '" + this.txtLNSS_P_HOSPITAL_HOURS.Text.ToString().Trim() + "',";
                                text = text + "LNSS_P_HOSPITAL_MIN = '" + this.txtLNSS_P_HOSPITAL_MIN.Text.ToString().Trim() + "',";
                                text = text + "LNSS_A_HOSPITAL_DAYS = '" + this.txtLNSS_A_HOSPITAL_DAYS.Text.ToString().Trim() + "',";
                                text = text + "LNSS_A_HOSPITAL_HOURS = '" + this.txtLNSS_A_HOSPITAL_HOURS.Text.ToString().Trim() + "',";
                                text = text + "LNSS_A_HOSPITAL_MIN = '" + this.txtLNSS_A_HOSPITAL_MIN.Text.ToString().Trim() + "',";
                                text = text + "CATALOGER='" + this.txtCATALOGER.Text + "',";
                                if (!EmrSysPubVar.getStationName().Equals("MRCATALOG"))
                                {
                                    if (this.txtMR_QUALITY.Tag != null)
                                    {
                                        text = text + "MR_QUALITY='" + this.txtMR_QUALITY.Tag.ToString() + "',";
                                    }
                                }
                                text = text + "DOCTOR_OF_CONTROL_QUALITY='" + this.txtDOCTOR_OF_CONTROL_QUALITY.Text + "',";
                                text = text + "NURSE_OF_CONTROL_QUALITY='" + this.txtNURSE_OF_CONTROL_QUALITY.Text + "',";
                                if (this.txtDATE_OF_CONTROL_QUALITY.Text.Length > 0)
                                {
                                    text = text + "DATE_OF_CONTROL_QUALITY=" + DBCustomFunctionUse.ToDate(this.txtDATE_OF_CONTROL_QUALITY.Text, false, false) + ",";
                                }
                                else
                                {
                                    text += "DATE_OF_CONTROL_QUALITY=null,";
                                }
                                if (this.txtdischarge_disposition.Text.Length > 0)
                                {
                                    text = text + "DISCHARGE_DISPOSITION='" + this.txtdischarge_disposition.Text + "',";
                                }
                                text = text + "AUTOPSY_INDICATOR=" + (this.txtAUTOPSY_INDICATOR.Text.Trim().Equals("－") ? "0" : ((this.txtAUTOPSY_INDICATOR.Text.Length > 0) ? this.txtAUTOPSY_INDICATOR.Text : "0")) + ",";
                                text = text + "DISCHARGE_PASS=" + (this.txtDISCHARGE_PASS.Text.Trim().Equals("－") ? "0" : ((this.txtDISCHARGE_PASS.Text.Length > 0) ? this.txtDISCHARGE_PASS.Text : "0")) + ",";
                                text = text + "ZRYJH=" + (this.txtZRYJH.Text.Trim().Equals("－") ? "0" : ((this.txtZRYJH.Text.Length > 0) ? this.txtZRYJH.Text : "0")) + ",";
                                text = text + "WZRYJH=" + (this.txtWZRYJH.Text.Trim().Equals("－") ? "0" : ((this.txtWZRYJH.Text.Length > 0) ? this.txtWZRYJH.Text : "0")) + ",";
                                text = text + "YWGM='" + this.txtYWGM.Tag.ToString() + "',";
                                text = text + "BLH = '" + this.txtBLH.Text.ToString() + "',";
                                text = text + "BLOOD_TYPE='" + this.txtBLOOD_TYPE.Tag.ToString() + "',";
                                text = text + "BLOOD_TYPE_RH='" + (this.txtBLOOD_TYPE_RH.Text.ToString().Trim().Equals("－") ? "0" : this.txtBLOOD_TYPE_RH.Text) + "'";
                                text2 = text;
                                text = string.Concat(new string[]
								{
									text2,
									" WHERE PATIENT_ID='",
									this.m_strPatientID,
									"' AND VISIT_ID=",
									this.m_nVisitID.ToString()
								});
                                DALUse.ExecuteSql(text);
                                if (this.m_MRFirstPageDAL.m_dsBloodTransfusion.Tables.Count == 0)
                                {
                                    text = string.Concat(new string[]
									{
										"INSERT INTO  BLOOD_TRANSFUSION (PATIENT_ID,VISIT_ID) VALUES ('",
										this.m_strPatientID,
										"',",
										this.m_nVisitID.ToString(),
										")"
									});
                                    DALUse.ExecuteSql(text);
                                    this.m_MRFirstPageDAL.getBloodTransfusion(this.m_strPatientID, this.m_nVisitID);
                                }
                                else
                                {
                                    if (this.m_MRFirstPageDAL.m_dsBloodTransfusion.Tables[0].Rows.Count == 0)
                                    {
                                        text = string.Concat(new string[]
										{
											"INSERT INTO  BLOOD_TRANSFUSION (PATIENT_ID,VISIT_ID) VALUES ('",
											this.m_strPatientID,
											"',",
											this.m_nVisitID.ToString(),
											")"
										});
                                        DALUse.ExecuteSql(text);
                                        this.m_MRFirstPageDAL.getBloodTransfusion(this.m_strPatientID, this.m_nVisitID);
                                    }
                                }
                                this.saveDiagnose();
                                this.setPatientInfo(this.m_strPatientID, this.m_nVisitID);
                                EmrSysWebservicesUse.myEmrToHis(this.m_strPatientID, this.m_nVisitID.ToString(), "1");
                                result = true;
                            }
                        }
                    }
                }
            }
            return result;
        }
        private bool isHaveE()
        {
            bool result = true;
            DataTable dataTable = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0];
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["diagnosis_type"].ToString().Equals("3") || dataRow["diagnosis_type"].ToString().Equals("1") || dataRow["diagnosis_type"].ToString().Equals("2"))
                {
                    if (dataRow["code1"] != DBNull.Value)
                    {
                        if (dataRow["code1"].ToString().ToUpper().Length > 0)
                        {
                            if (dataRow["code1"].ToString().ToUpper().Substring(0, 1).Equals("S") || dataRow["code1"].ToString().ToUpper().Substring(0, 1).Equals("T"))
                            {
                                result = false;
                            }
                        }
                    }
                }
                if (dataRow["diagnosis_type"].ToString().Equals("7"))
                {
                    result = true;
                }
            }
            return result;
        }
        private void txtDoctorListSelKeyDown(ref KeyEventArgs e, ref TextBox txt)
        {
            if (!this.m_bFirstPageIsCommit)
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
        }
        private void txtListSelKeyDown(ref KeyEventArgs e, ref TextBox txt, string strFieldName)
        {
            if (!this.m_bFirstPageIsCommit)
            {
                if (e.KeyCode == Keys.Return)
                {
                    DataSet eMRFirstPageItemDict = this.m_MRFirstPageDAL.getEMRFirstPageItemDict();
                    if (eMRFirstPageItemDict.Tables.Count != 0)
                    {
                        DataTable dataTable = eMRFirstPageItemDict.Tables[0];
                        if (dataTable.Rows.Count != 0)
                        {
                            strFieldName = strFieldName.ToUpper();
                            string text = "";
                            if (txt.Tag != null)
                            {
                                text = txt.Tag.ToString();
                            }
                            this.m_strFieldName = strFieldName;
                            this.lbItemSel.Items.Clear();
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                if (dataRow["FIELD_NAME"].ToString().Equals(this.m_strFieldName))
                                {
                                    this.lbItemSel.Items.Add(dataRow["ITEM_VALUE"].ToString());
                                    if (text.Equals(dataRow["ITEM_VALUE"].ToString()))
                                    {
                                        this.lbItemSel.SelectedIndex = this.lbItemSel.Items.Count - 1;
                                    }
                                }
                            }
                            this.lbItemSel.Left = txt.Left;
                            this.lbItemSel.Top = txt.Bottom;
                            this.lbItemSel.Visible = true;
                            this.lbItemSel.Focus();
                            this.lbItemSel.Tag = txt;
                        }
                    }
                }
            }
        }
        private void lbItemSel_DoubleClick(object sender, EventArgs e)
        {
            this.lbItemSel.Visible = false;
            TextBox textBox = (TextBox)this.lbItemSel.Tag;
            textBox.Tag = this.lbItemSel.Items[this.lbItemSel.SelectedIndex].ToString();
            textBox.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, textBox.Tag.ToString());
            textBox.Focus();
            SendKeys.Send("{tab}");
        }
        private void lbItemSel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.lbItemSel.Visible = false;
                TextBox textBox = (TextBox)this.lbItemSel.Tag;
                textBox.Focus();
            }
            if (e.KeyCode == Keys.Return)
            {
                this.lbItemSel_DoubleClick(sender, e);
            }
        }
        private void lbItemSel_Leave(object sender, EventArgs e)
        {
            this.lbItemSel.Visible = false;
        }
        private void txtDictInput(KeyEventArgs e, ref TextBox txt, string strDictName, string strSubclass)
        {
            if (!this.m_bFirstPageIsCommit)
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
        }
        private void txtTimeKeyDown(ref object sender, ref KeyEventArgs e, ref TextBox txt)
        {
            if (!this.m_bFirstPageIsCommit)
            {
                if (e.KeyCode == Keys.Return)
                {
                    frmTimeSel frmTimeSel = new frmTimeSel();
                    if (frmTimeSel.ShowDialog() == DialogResult.OK)
                    {
                        string timeSel = frmTimeSel.m_timeSel;
                        txt.Text = timeSel;
                        txt.Tag = timeSel;
                    }
                }
            }
        }
        private void txtMedical_pay_way_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comMedical_pay_way.Focus();
                this.comMedical_pay_way.DroppedDown = true;
            }
        }
        private void txtSex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comSex.Focus();
                this.comSex.DroppedDown = true;
            }
        }
        private void txtMARITAL_STATUS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comMARITAL_STATUS.Focus();
                this.comMARITAL_STATUS.DroppedDown = true;
            }
        }
        private void txtRUYUAN_PASS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comRUYUAN_PASS.Focus();
                this.comRUYUAN_PASS.DroppedDown = true;
            }
        }
        private void txtMR_QUALITY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comMR_QUALITY.Focus();
                this.comMR_QUALITY.DroppedDown = true;
            }
        }
        private void txtBLOOD_TYPE_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtAUTOPSY_INDICATOR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comAUTOPSY_INDICATOR.Focus();
                this.comAUTOPSY_INDICATOR.DroppedDown = true;
            }
        }
        private void txtZRYJH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comZRYJH.Focus();
                this.comZRYJH.DroppedDown = true;
            }
        }
        private void txtDISCHARGE_PASS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comDISCHARGE_PASS.Focus();
                this.comDISCHARGE_PASS.DroppedDown = true;
            }
        }
        private void txtYWGM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comYWGM.Focus();
                this.comYWGM.DroppedDown = true;
            }
        }
        private void txtBLOOD_TYPE_RH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comBLOOD_TYPE_RH.Focus();
                this.comBLOOD_TYPE_RH.DroppedDown = true;
            }
        }
        private void txtDISCHARGE_DATE_TIME_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.m_bFirstPageIsCommit)
            {
                this.txtTimeKeyDown(ref sender, ref e, ref this.txtDISCHARGE_DATE_TIME);
                if (this.txtDISCHARGE_DATE_TIME.Text != "" && this.txtADMISSION_DATE_TIME.Text != "")
                {
                    this.txtInhospitaldays.Text = EmrSysPubFunction.GetBetweenDays(Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Tag.ToString()), Convert.ToDateTime(this.txtDISCHARGE_DATE_TIME.Tag.ToString())).ToString();
                }
            }
        }
        private void txtDATE_OF_CONTROL_QUALITY_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtTimeKeyDown(ref sender, ref e, ref this.txtDATE_OF_CONTROL_QUALITY);
        }
        private void txtdept_transfer_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtDEPT_DISCHARGE_FROM_KeyDown(object sender, KeyEventArgs e)
        {
            string text = EmrSysPubVar.getDeptName().ToString();
            this.txtDEPT_DISCHARGE_FROM.Text = text;
        }
        private void txtDEPT_ADMISSION_TO_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtRELATIONSHIP_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDictInput(e, ref this.txtRELATIONSHIP, "emr_dict", "SHGX");
        }
        private void txtDISCHARGE_DATE_TIME_KeyDown1(object sender, KeyEventArgs e)
        {
            if (!this.m_bFirstPageIsCommit)
            {
                if (e.KeyCode == Keys.Return)
                {
                    frmTimeSel frmTimeSel = new frmTimeSel();
                    if (frmTimeSel.ShowDialog() == DialogResult.OK)
                    {
                        string longTimeSel = frmTimeSel.m_longTimeSel;
                        DateTime t = Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Text.Substring(0, 10));
                        DateTime t2 = Convert.ToDateTime(longTimeSel.Substring(0, 10));
                        if (t2 < t)
                        {
                            MessageBox.Show("出院日期不能小于入院时间");
                        }
                        else
                        {
                            this.txtDISCHARGE_DATE_TIME.Text = t2.ToString();
                            this.txtDISCHARGE_DATE_TIME.Tag = t2.ToString();
                        }
                    }
                }
            }
        }
        private void txtALERGY_DRUGS_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDictInput(e, ref this.txtALERGY_DRUGS, "ALERGY_DRUGS", "");
        }
        private void txtBABY_WEIGHT_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDictInput(e, ref this.txtBABY_WEIGHT, "BABY_WEIGHT", "");
        }
        private void txtBABYAGE_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDictInput(e, ref this.txtBABYAGE, "BABYAGE", "");
        }
        private void txtOCCUPATION_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDictInput(e, ref this.txtOCCUPATION, "emr_dict", "OCCUPATION");
        }
        private void txtBIRTH_PLACE_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDictInput(e, ref this.txtBIRTH_PLACE, "emr_dict", "AREA");
        }
        private void txtJIGUAN_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDictInput(e, ref this.txtJIGUAN, "emr_dict", "AREA");
        }
        private void txtNATION_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDictInput(e, ref this.txtNATION, "emr_dict", "NATION");
        }
        private void txtCITIZENSHIP_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDictInput(e, ref this.txtCITIZENSHIP, "emr_dict", "COUNTRY");
        }
        private void txtDIRECTOR_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtDIRECTOR);
        }
        private void txtADVANCED_STUDIES_DOCTOR_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtADVANCED_STUDIES_DOCTOR);
        }
        private void txtCHIEF_DOCTOR_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtCHIEF_DOCTOR);
        }
        private void txtATTENDING_DOCTOR_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtATTENDING_DOCTOR);
        }
        private void txtDOCTOR_IN_CHARGE_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtDOCTOR_IN_CHARGE);
        }
        private void txtPRACTICE_DOCTOR_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtPRACTICE_DOCTOR);
        }
        private void txtPRACTICE_DOCTOR_OF_GRADUATE_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtLIABILITY_NURSE_ID);
        }
        private void txtCATALOGER_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtDOCTOR_OF_CONTROL_QUALITY_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtDOCTOR_OF_CONTROL_QUALITY);
        }
        private void txtNURSE_OF_CONTROL_QUALITY_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtNURSE_OF_CONTROL_QUALITY);
        }
        private void txtDate_of_birth_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.m_bFirstPageIsCommit)
            {
                if (e.KeyCode == Keys.Return)
                {
                    frmTimeSel frmTimeSel = new frmTimeSel();
                    if (frmTimeSel.ShowDialog() == DialogResult.OK)
                    {
                        string timeSel = frmTimeSel.m_timeSel;
                        this.txtDate_of_birth.Text = Convert.ToDateTime(timeSel).ToString("yyyy年MM月dd日");
                        this.txtDate_of_birth.Tag = timeSel;
                        this.txtAge.Text = UCMRFirstPage.GetAge(Convert.ToDateTime(this.txtADMISSION_DATE_TIME.Tag.ToString()), Convert.ToDateTime(this.txtDate_of_birth.Tag.ToString()));
                    }
                }
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (this.m_MRFirstPageDAL.m_dsDiagnosis.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables.Count == 1)
                {
                    if (this.dgvDiagnose.SelectedRows.Count == 1)
                    {
                        DataTable dataTable = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0];
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["patient_id"] = EmrSysPubVar.getCurPatientID();
                        dataRow["visit_id"] = EmrSysPubVar.getCurPatientVisitID();
                        DataGridViewRow dataGridViewRow = this.dgvDiagnose.SelectedRows[0];
                        dataRow["diagnosis_type"] = dataGridViewRow.Cells["diagnosis_type"].Value;
                        dataRow["diagnosis_date"] = dataGridViewRow.Cells["diagnosis_date"].Value;
                        dataRow["treat_days"] = dataGridViewRow.Cells["treat_days"].Value;
                        dataRow["treat_result"] = dataGridViewRow.Cells["treat_result1"].Value;
                        dataRow["DIAGNOSIS_NO"] = Convert.ToInt32(dataGridViewRow.Cells["DIAGNOSIS_NO"].Value.ToString()) + 1;
                        dataTable.Rows.InsertAt(dataRow, dataGridViewRow.Index + 1);
                        this.sortDiagnoseNo(false);
                        dataTable.DefaultView.Sort = "DIAGNOSIS_TYPE,DIAGNOSIS_NO";
                    }
                }
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvDiagnose.SelectedRows.Count == 1)
            {
                if (this.m_MRFirstPageDAL.m_dsDiagnosis.IsInitialized)
                {
                    if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables.Count == 1)
                    {
                        DataTable dataTable = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0];
                        if (this.isOnlyRowOfType())
                        {
                            DataGridViewRow dataGridViewRow = this.dgvDiagnose.SelectedRows[0];
                            dataGridViewRow.Cells["diagnosis_desc"].Value = "";
                            dataGridViewRow.Cells["code1"].Value = "";
                        }
                        else
                        {
                            DataGridViewRow dataGridViewRow2 = this.dgvDiagnose.SelectedRows[0];
                            dataTable.Rows.RemoveAt(dataGridViewRow2.Index);
                        }
                    }
                }
            }
        }
        private void btnAddCustomDiag_Click(object sender, EventArgs e)
        {
            if (this.dgvDiagnose.SelectedRows.Count == 1)
            {
                if (this.m_MRFirstPageDAL.m_dsDiagnosis.IsInitialized)
                {
                    if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables.Count == 1)
                    {
                        DataGridViewRow dataGridViewRow = this.dgvDiagnose.SelectedRows[0];
                        if (dataGridViewRow.Cells["code1"].Value == null)
                        {
                            MessageBox.Show("当前选中的诊断没有编码!");
                        }
                        else
                        {
                            if (dataGridViewRow.Cells["code1"].Value != null)
                            {
                                if (this.m_MRFirstPageDAL.InsertDiagToDoctorCustomDict(dataGridViewRow.Cells["code1"].Value.ToString()))
                                {
                                    MessageBox.Show("新增常用诊断成功!");
                                }
                                else
                                {
                                    MessageBox.Show("诊断编码" + dataGridViewRow.Cells["code1"].Value.ToString() + "不存在,添加失败!");
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btnAddCustomOper_Click(object sender, EventArgs e)
        {
            if (this.dgvOperation.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = this.dgvOperation.SelectedRows[0];
                if (dataGridViewRow.Cells["operation_code"].Value == null)
                {
                    MessageBox.Show("选中的手术没有编码，不能添加");
                }
                else
                {
                    if (this.m_MRFirstPageDAL.InsertOperationToDoctorCustomDict(dataGridViewRow.Cells["operation_code"].Value.ToString()))
                    {
                        MessageBox.Show("新增常用手术成功!");
                    }
                    else
                    {
                        MessageBox.Show("手术编码" + dataGridViewRow.Cells["operation_code"].Value.ToString() + "不存在,添加失败!");
                    }
                }
            }
        }
        private void txtMedical_pay_way_Enter(object sender, EventArgs e)
        {
            this.txtMedical_pay_way.BackColor = Color.Gold;
        }
        private void txtMedical_pay_way_Leave(object sender, EventArgs e)
        {
            this.txtMedical_pay_way.BackColor = Color.White;
        }
        private void btnOperInsert_Click(object sender, EventArgs e)
        {
            if (this.m_MRFirstPageDAL.m_dsOperation.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsOperation.Tables.Count == 1)
                {
                    DataTable dataTable = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["patient_id"] = EmrSysPubVar.getCurPatientID();
                    dataRow["visit_id"] = EmrSysPubVar.getCurPatientVisitID();
                    if (this.dgvOperation.SelectedRows.Count == 1)
                    {
                        DataGridViewRow dataGridViewRow = this.dgvOperation.SelectedRows[0];
                        dataTable.Rows.InsertAt(dataRow, dataGridViewRow.Index + 1);
                    }
                    else
                    {
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
        }
        private void btnOperDel_Click(object sender, EventArgs e)
        {
            if (this.dgvOperation.SelectedRows.Count == 1)
            {
                if (this.m_MRFirstPageDAL.m_dsOperation.IsInitialized)
                {
                    if (this.m_MRFirstPageDAL.m_dsOperation.Tables.Count == 1)
                    {
                        DataTable dataTable = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
                        DataGridViewRow dataGridViewRow = this.dgvOperation.SelectedRows[0];
                        dataTable.Rows.RemoveAt(dataGridViewRow.Index);
                    }
                }
            }
        }
        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (this.dgvDiagnose.SelectedRows.Count == 1)
            {
                frmICDCode frmICDCode = new frmICDCode();
                frmICDCode.Text = "常用诊断";
                frmICDCode.ShowDialog();
                this.dgvDiagnose.SelectedRows[0].Cells["diagnosis_desc"].Value = frmICDCode.GetName();
                this.dgvDiagnose.SelectedRows[0].Cells["code1"].Value = frmICDCode.GetCode();
            }
        }
        private void btnCustomOper_Click(object sender, EventArgs e)
        {
            if (this.dgvOperation.SelectedRows.Count == 1)
            {
                frmICDCode frmICDCode = new frmICDCode();
                frmICDCode.Text = "常用手术";
                frmICDCode.ShowDialog();
                this.dgvOperation.SelectedRows[0].Cells["operation_desc"].Value = frmICDCode.GetName();
                this.dgvOperation.SelectedRows[0].Cells["operation_code"].Value = frmICDCode.GetCode();
            }
        }
        private void txtMedical_pay_way_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtSex_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtMARITAL_STATUS_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtOCCUPATION_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtOCCUPATION_KeyDown(sender, e2);
        }
        private void txtBIRTH_PLACE_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtBIRTH_PLACE_KeyDown(sender, e2);
        }
        private void txtNATION_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtNATION_KeyDown(sender, e2);
        }
        private void txtCITIZENSHIP_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtCITIZENSHIP_KeyDown(sender, e2);
        }
        private void txtRELATIONSHIP_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtRELATIONSHIP_KeyDown(sender, e2);
        }
        private void txtDISCHARGE_DATE_TIME_DoubleClick1(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtDISCHARGE_DATE_TIME_KeyDown(sender, e2);
        }
        private void txtDEPT_DISCHARGE_FROM_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtDEPT_DISCHARGE_FROM_KeyDown(sender, e2);
        }
        private void txtPAT_ADM_CONDITION_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtRUYUAN_PASS_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtRUYUAN_THING_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtDISCHARGE_DATE_TIME_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtDISCHARGE_DATE_TIME_KeyDown(sender, e2);
        }
        private void txtdischarge_disposition_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtHBSAG_INDICATOR_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtHCV_AB_INDICATOR_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtHIV_AB_INDICATOR_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtDIAG_COMPARE_GROUP1_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtDIAG_COMPARE_GROUP4_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtDIAG_COMPARE_GROUP3_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtDIAG_COMPARE_GROUP6_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtDIAG_COMPARE_GROUP2_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtMR_QUALITY_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtDATE_OF_CONTROL_QUALITY_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtDATE_OF_CONTROL_QUALITY_KeyDown(sender, e2);
        }
        private void txtAUTOPSY_INDICATOR_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtFIRST_CASE_INDICATOR_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtFOLLOW_INDICATOR_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtMR_VALUE_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtBLOOD_TYPE_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtInfect_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtBLOOD_TYPE_RH_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtBLOOD_TRAN_REACT_TIMES_DoubleClick(object sender, EventArgs e)
        {
        }
        private void dgvOperation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void txtRtMode_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtRtMode_Enter(object sender, EventArgs e)
        {
        }
        private void txtRtMode_Leave(object sender, EventArgs e)
        {
        }
        private void txtRtProcess_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtRtProcess_Enter(object sender, EventArgs e)
        {
        }
        private void txtRtProcess_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtRtProcess_Leave(object sender, EventArgs e)
        {
        }
        private void txtRtDevice_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtRtDevice_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtRtDevice_Enter(object sender, EventArgs e)
        {
        }
        private void txtRtDevice_Leave(object sender, EventArgs e)
        {
        }
        private void txtOriginalTimes_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtOriginalTimes_Enter(object sender, EventArgs e)
        {
        }
        private void txtOriginalTimes_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtOriginalTimes_Leave(object sender, EventArgs e)
        {
        }
        private void txtCmtrMode_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtCmtrMode_Enter(object sender, EventArgs e)
        {
        }
        private void txtCmtrMode_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtCmtrMode_Leave(object sender, EventArgs e)
        {
        }
        private void txtCmtrWay_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtCmtrWay_Enter(object sender, EventArgs e)
        {
        }
        private void txtCmtrWay_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtCmtrWay_Leave(object sender, EventArgs e)
        {
        }
        private void txtRlnTimes_DoubleClick(object sender, EventArgs e)
        {
        }
        private void txtRlnTimes_Enter(object sender, EventArgs e)
        {
        }
        private void txtRlnTimes_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtRlnTimes_Leave(object sender, EventArgs e)
        {
        }
        private void txtOriginalDosageGy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtOriginalDosageTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtOriginalDosageDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtRlnDosageGy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtRlnDosageTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtRlnDosageDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtRlnTransDosageGy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtRlnTransDosageTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtRlnTransDosageDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtFOLLOW_INTERVAL_UNITS_DoubleClick(object sender, EventArgs e)
        {
        }
        private void btnDosage_Click(object sender, EventArgs e)
        {
        }
        private void dgvTumourDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void dgvBaby_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void txtDate_of_birth_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtDate_of_birth_KeyDown(sender, e2);
        }
        private void dgvTumourDetail_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }
        private void dgvBaby_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvDiagnose_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = this.dgvDiagnose.Rows[rowIndex];
                if (dataGridViewRow.Cells["diagnosis_desc"].Value.ToString() == "")
                {
                    dataGridViewRow.Cells["diagnosis_desc"].Value = "-";
                }
            }
        }
        private void btnMrDiagnose_Click(object sender, EventArgs e)
        {
            if (this.dgvDiagnose.SelectedRows.Count == 1)
            {
                DataGridViewRow dataGridViewRow = this.dgvDiagnose.SelectedRows[0];
                frmPatientMrDiagnose frmPatientMrDiagnose = new frmPatientMrDiagnose();
                frmPatientMrDiagnose.setPatientInfo(this.m_strPatientID, this.m_nVisitID);
                if (frmPatientMrDiagnose.ShowDialog() == DialogResult.OK)
                {
                    if (frmPatientMrDiagnose.dtDiagnosis.Rows.Count > 0)
                    {
                        if (frmPatientMrDiagnose.dtDiagnosis.Rows.Count == 1)
                        {
                            if (frmPatientMrDiagnose.dtDiagnosis.Rows[0]["诊断名称"].ToString().Length > 24)
                            {
                                this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index]["diagnosis_desc"] = frmPatientMrDiagnose.dtDiagnosis.Rows[0]["诊断名称"].ToString().Substring(0, 24);
                            }
                            else
                            {
                                this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index]["diagnosis_desc"] = frmPatientMrDiagnose.dtDiagnosis.Rows[0]["诊断名称"];
                            }
                            this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index]["code1"] = frmPatientMrDiagnose.dtDiagnosis.Rows[0]["诊断编码"];
                            if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index]["diagnosis_type"].ToString().Equals("3") || this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index]["diagnosis_type"].ToString().Equals("4"))
                            {
                                if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index]["treat_result"] == DBNull.Value)
                                {
                                    if (this.txtdischarge_disposition.Text.ToString().Trim() == "死亡")
                                    {
                                        this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index]["treat_result"] = "死亡";
                                    }
                                    else
                                    {
                                        this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index]["treat_result"] = "治愈";
                                    }
                                }
                            }
                            else
                            {
                                this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index]["treat_result"] = DBNull.Value;
                            }
                        }
                        else
                        {
                            for (int i = 1; i < frmPatientMrDiagnose.dtDiagnosis.Rows.Count; i++)
                            {
                                if (!this.m_MRFirstPageDAL.m_dsDiagnosis.IsInitialized)
                                {
                                    return;
                                }
                                if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables.Count != 1)
                                {
                                    return;
                                }
                                if (this.dgvDiagnose.SelectedRows.Count != 1)
                                {
                                    return;
                                }
                                DataTable dataTable = this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0];
                                DataRow dataRow = dataTable.NewRow();
                                dataRow["patient_id"] = EmrSysPubVar.getCurPatientID();
                                dataRow["visit_id"] = EmrSysPubVar.getCurPatientVisitID();
                                DataGridViewRow dataGridViewRow2 = this.dgvDiagnose.SelectedRows[0];
                                dataRow["diagnosis_type"] = dataGridViewRow2.Cells["diagnosis_type"].Value;
                                dataRow["diagnosis_date"] = dataGridViewRow2.Cells["diagnosis_date"].Value;
                                dataRow["treat_days"] = dataGridViewRow2.Cells["treat_days"].Value;
                                dataRow["treat_result"] = dataGridViewRow2.Cells["treat_result1"].Value;
                                dataRow["DIAGNOSIS_NO"] = Convert.ToInt32(dataGridViewRow2.Cells["DIAGNOSIS_NO"].Value.ToString()) + 1;
                                dataTable.Rows.InsertAt(dataRow, dataGridViewRow2.Index + 1);
                                this.sortDiagnoseNo(false);
                                dataTable.DefaultView.Sort = "DIAGNOSIS_TYPE,DIAGNOSIS_NO";
                            }
                            for (int j = 0; j < frmPatientMrDiagnose.dtDiagnosis.Rows.Count; j++)
                            {
                                if (frmPatientMrDiagnose.dtDiagnosis.Rows[j]["诊断名称"].ToString().Length > 24)
                                {
                                    this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index + j]["diagnosis_desc"] = frmPatientMrDiagnose.dtDiagnosis.Rows[j]["诊断名称"].ToString().Substring(0, 24);
                                }
                                else
                                {
                                    this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index + j]["diagnosis_desc"] = frmPatientMrDiagnose.dtDiagnosis.Rows[j]["诊断名称"];
                                }
                                this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index + j]["code1"] = frmPatientMrDiagnose.dtDiagnosis.Rows[j]["诊断编码"];
                                if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index + j]["diagnosis_type"].ToString().Equals("3") || this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index + j]["diagnosis_type"].ToString().Equals("4"))
                                {
                                    if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index + j]["treat_result"] == DBNull.Value)
                                    {
                                        if (this.txtdischarge_disposition.Text.ToString().Trim() == "死亡")
                                        {
                                            this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index + j]["treat_result"] = "死亡";
                                        }
                                        else
                                        {
                                            this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index + j]["treat_result"] = "治愈";
                                        }
                                    }
                                }
                                else
                                {
                                    this.m_MRFirstPageDAL.m_dsDiagnosis.Tables[0].Rows[dataGridViewRow.Index + j]["treat_result"] = DBNull.Value;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void txtDIRECTOR_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtDIRECTOR_KeyDown(sender, e2);
        }
        private void txtADVANCED_STUDIES_DOCTOR_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtADVANCED_STUDIES_DOCTOR_KeyDown(sender, e2);
        }
        private void txtCHIEF_DOCTOR_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtCHIEF_DOCTOR_KeyDown(sender, e2);
        }
        private void txtATTENDING_DOCTOR_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtATTENDING_DOCTOR_KeyDown(sender, e2);
        }
        private void txtDOCTOR_IN_CHARGE_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtDOCTOR_IN_CHARGE_KeyDown(sender, e2);
        }
        private void txtPRACTICE_DOCTOR_OF_GRADUATE_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtPRACTICE_DOCTOR_OF_GRADUATE_KeyDown(sender, e2);
        }
        private void txtPRACTICE_DOCTOR_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtPRACTICE_DOCTOR_KeyDown(sender, e2);
        }
        private void comboBoxDropDown(ref ComboBox mycbb, string strFieldName)
        {
            DataSet eMRFirstPageItemDict = this.m_MRFirstPageDAL.getEMRFirstPageItemDict();
            if (eMRFirstPageItemDict.Tables.Count != 0)
            {
                DataTable dataTable = eMRFirstPageItemDict.Tables[0];
                if (dataTable.Rows.Count != 0)
                {
                    if (this.txt.Tag != null)
                    {
                        string text = this.txt.Tag.ToString();
                    }
                    this.m_strFieldName = strFieldName;
                    mycbb.Items.Clear();
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        if (dataRow["FIELD_NAME"].ToString().Equals(this.m_strFieldName))
                        {
                            mycbb.Items.Add(dataRow["ITEM_VALUE"].ToString());
                        }
                    }
                }
            }
        }
        private void comMR_QUALITY_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtMR_QUALITY.Tag = this.comMR_QUALITY.Text;
            this.txtMR_QUALITY.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtMR_QUALITY.Tag.ToString());
        }
        private void comMR_QUALITY_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comMR_QUALITY, "MR_QUALITY");
        }
        private void comAUTOPSY_INDICATOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtAUTOPSY_INDICATOR.Tag = this.comAUTOPSY_INDICATOR.Text;
            this.txtAUTOPSY_INDICATOR.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtAUTOPSY_INDICATOR.Tag.ToString().Trim());
        }
        private void comAUTOPSY_INDICATOR_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comAUTOPSY_INDICATOR, "YESNO");
        }
        private void comZRYJH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtZRYJH.Tag = this.comZRYJH.Text;
            this.txtZRYJH.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtZRYJH.Tag.ToString());
        }
        private void comZRYJH_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comZRYJH, "HAVENO");
        }
        private void comDISCHARGE_PASS_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDISCHARGE_PASS.Tag = this.comDISCHARGE_PASS.Text;
            this.txtDISCHARGE_PASS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtDISCHARGE_PASS.Tag.ToString());
        }
        private void comDISCHARGE_PASS_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comDISCHARGE_PASS, "DISCHARGE_PASS");
        }
        private void comYWGM_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtYWGM.Tag = this.comYWGM.Text;
            this.txtYWGM.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtYWGM.Tag.ToString());
        }
        private void comYWGM_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comYWGM, "HAVENO");
        }
        private void comBLOOD_TYPE_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comBLOOD_TYPE, "BLOOD_TYPE");
        }
        private void comBLOOD_TYPE_RH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBLOOD_TYPE_RH.Tag = this.comBLOOD_TYPE_RH.Text;
            this.txtBLOOD_TYPE_RH.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtBLOOD_TYPE_RH.Tag.ToString());
        }
        private void comBLOOD_TYPE_RH_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comBLOOD_TYPE_RH, "BLOOD_TYPE_RH");
        }
        private void comRUYUAN_PASS_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtRUYUAN_PASS.Tag = this.comRUYUAN_PASS.Text;
            this.txtRUYUAN_PASS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtRUYUAN_PASS.Tag.ToString());
        }
        private void comRUYUAN_PASS_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comRUYUAN_PASS, "RUYUAN_PASS");
        }
        private void comSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSex.Tag = this.comSex.Text;
            this.txtSex.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtSex.Tag.ToString());
        }
        private void comSex_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comSex, "SEX");
        }
        private void comMARITAL_STATUS_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comMARITAL_STATUS, "MARITAL_STATUS");
        }
        private void comMARITAL_STATUS_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtMARITAL_STATUS.Tag = this.comMARITAL_STATUS.Text;
            this.txtMARITAL_STATUS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtMARITAL_STATUS.Tag.ToString());
        }
        private void comMedical_pay_way_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtMedical_pay_way.Tag = this.comMedical_pay_way.Text;
            this.txtMedical_pay_way.Text = this.comMedical_pay_way.Text;
        }
        private void comMedical_pay_way_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comMedical_pay_way, "MEDICAL_PAY_WAY");
        }
        private void comMedical_pay_way_DropDownClosed(object sender, EventArgs e)
        {
            this.txtMedical_pay_way.Focus();
        }
        private void comSex_DropDownClosed(object sender, EventArgs e)
        {
            this.txtSex.Focus();
            SendKeys.Send("{tab}");
        }
        private void comMARITAL_STATUS_DropDownClosed(object sender, EventArgs e)
        {
        }
        private void comRUYUAN_PASS_DropDownClosed(object sender, EventArgs e)
        {
            this.txtRUYUAN_PASS.Focus();
            SendKeys.Send("{tab}");
        }
        private void comdischarge_disposition_DropDownClosed(object sender, EventArgs e)
        {
            this.txtdischarge_disposition.Focus();
            SendKeys.Send("{tab}");
        }
        private void comAUTOPSY_INDICATOR_DropDownClosed(object sender, EventArgs e)
        {
            this.txtAUTOPSY_INDICATOR.Focus();
            SendKeys.Send("{tab}");
        }
        private void comZRYJH_DropDownClosed(object sender, EventArgs e)
        {
            this.txtZRYJH.Focus();
            SendKeys.Send("{tab}");
        }
        private void comDISCHARGE_PASS_DropDownClosed(object sender, EventArgs e)
        {
            this.txtDISCHARGE_PASS.Focus();
            SendKeys.Send("{tab}");
        }
        private void comYWGM_DropDownClosed(object sender, EventArgs e)
        {
            this.txtYWGM.Focus();
            SendKeys.Send("{tab}");
        }
        private void comBLOOD_TYPE_DropDownClosed(object sender, EventArgs e)
        {
            this.txtBLOOD_TYPE.Focus();
            SendKeys.Send("{tab}");
        }
        private void comBLOOD_TYPE_RH_DropDownClosed(object sender, EventArgs e)
        {
            this.txtBLOOD_TYPE_RH.Focus();
        }
        private void txtFOLLOW_INTERVAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtPLATELET_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtPLASMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtWHOLE_BLOOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtALBUMIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtGAMMA_GLOBULIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtOTHERS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtin_consult_times_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtfar_consult_times_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtSpec_level_nurs_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtFirst_level_nurs_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtSecond_level_nurs_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtThird_level_nurs_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txticu_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtccu_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtcritical_cond_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtserious_cond_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtdecubital_ulcer_times_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtEMER_TREAT_TIMES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtESC_EMER_TIMES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void label57_Click(object sender, EventArgs e)
        {
        }
        private void txtFIRST_CASE_INDICATOR_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtInhospitaldays_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtPHONE_NUMBER_BUSINESS_TextChanged(object sender, EventArgs e)
        {
        }
        private void comMR_VALUE_DropDown(object sender, DragEventArgs e)
        {
        }
        private void dgvOperation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void txtDIRECTOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            if ((e.KeyChar > 'A' && e.KeyChar < 'Z') || (e.KeyChar > 'a' && e.KeyChar < 'z'))
            {
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(base.Controls, (TextBox)sender);
                instance.Name = "input";
                instance.loadData();
                base.Controls.Add(instance);
                base.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(base.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void dgvOperation_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (!this.m_bFirstPageIsCommit)
                {
                    DataTable dataTable = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
                    DataRow dataRow = dataTable.Rows[e.RowIndex];
                    string text = this.dgvOperation.Columns[e.ColumnIndex].Name.ToLower();
                    DataGridViewCell dataGridViewCell = this.dgvOperation.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (dataGridViewCell != null)
                    {
                        string text2 = text;
                        if (text2 != null)
                        {
                            if (text2 == "operation_code")
                            {
                                if (EmrSysPubVar.getStationName() == "MRCATALOG")
                                {
                                    if (dataGridViewCell.Value.ToString().Length > 0)
                                    {
                                        if (!this.m_MRFirstPageDAL.ValidICDCode(dataGridViewCell.Value.ToString(), "2"))
                                        {
                                            MessageBox.Show("该编码不在手术编码库中，请注意！");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("手术编码不能为空，请注意！");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void dgvDiagnose_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex > -1)
            {
                if (this.dgvDiagnose.Columns[e.ColumnIndex].Name == "oper_treat_indicator")
                {
                    if (this.dgvDiagnose.Rows[e.RowIndex].Cells["diagnosis_type_name"].Value.ToString() != "出院诊断")
                    {
                        e.Cancel = true;
                    }
                }
                if (this.dgvDiagnose.Columns[e.ColumnIndex].Name == "treat_result" || this.dgvDiagnose.Columns[e.ColumnIndex].Name == "treat_days")
                {
                    if (this.dgvDiagnose.Rows[e.RowIndex].Cells["DIAGNOSIS_TYPE"].Value.ToString() == "1")
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
        private void txtDIRECTOR_Leave(object sender, EventArgs e)
        {
            if (this.txtDIRECTOR.Text.Trim().Length > 0)
            {
                if (this.txtDIRECTOR.Tag == null)
                {
                    this.txtDIRECTOR.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtDIRECTOR.Text.Trim());
                }
            }
        }
        private void txtADVANCED_STUDIES_DOCTOR_Leave(object sender, EventArgs e)
        {
            if (this.txtADVANCED_STUDIES_DOCTOR.Text.Trim().Length > 0)
            {
                if (this.txtADVANCED_STUDIES_DOCTOR.Tag == null)
                {
                    this.txtADVANCED_STUDIES_DOCTOR.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtADVANCED_STUDIES_DOCTOR.Text.Trim());
                }
            }
        }
        private void txtCHIEF_DOCTOR_Leave(object sender, EventArgs e)
        {
            if (this.txtCHIEF_DOCTOR.Text.Trim().Length > 0)
            {
                if (this.txtCHIEF_DOCTOR.Tag == null)
                {
                    this.txtCHIEF_DOCTOR.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtCHIEF_DOCTOR.Text.Trim());
                }
            }
        }
        private void txtATTENDING_DOCTOR_Leave(object sender, EventArgs e)
        {
            if (this.txtATTENDING_DOCTOR.Text.Trim().Length > 0)
            {
                if (this.txtATTENDING_DOCTOR.Tag == null)
                {
                    this.txtATTENDING_DOCTOR.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtATTENDING_DOCTOR.Text.Trim());
                }
            }
        }
        private void txtDOCTOR_IN_CHARGE_Leave(object sender, EventArgs e)
        {
            if (this.txtDOCTOR_IN_CHARGE.Text.Trim().Length > 0)
            {
                if (this.txtDOCTOR_IN_CHARGE.Tag == null)
                {
                    this.txtDOCTOR_IN_CHARGE.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtDOCTOR_IN_CHARGE.Text.Trim());
                }
            }
        }
        private void txtPRACTICE_DOCTOR_OF_GRADUATE_Leave(object sender, EventArgs e)
        {
            if (this.txtLIABILITY_NURSE_ID.Text.Trim().Length > 0)
            {
                if (this.txtLIABILITY_NURSE_ID.Tag == null)
                {
                    this.txtLIABILITY_NURSE_ID.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtLIABILITY_NURSE_ID.Text.Trim());
                }
            }
        }
        private void txtPRACTICE_DOCTOR_Leave(object sender, EventArgs e)
        {
            if (this.txtPRACTICE_DOCTOR.Text.Trim().Length > 0)
            {
                if (this.txtPRACTICE_DOCTOR.Tag == null)
                {
                    this.txtPRACTICE_DOCTOR.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtPRACTICE_DOCTOR.Text.Trim());
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            object[] array = new object[]
			{
				"BASICPATINFO",
				this.m_strPatientID,
				this.m_nVisitID
			};
            EmrService emrService = new EmrService();
            emrService.EmrSynchroPatMedicalCostById(this.m_strPatientID, this.m_nVisitID);
            this.setPatientInfo(this.m_strPatientID, this.m_nVisitID);
            this.m_MRFirstPageDAL.fillPatientFirstPageData(this.m_strPatientID, this.m_nVisitID);
        }
        private void txtFAR_CONSULT_TIMES_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void cmbX_EXAM_NO_DropDown(object sender, EventArgs e)
        {
            string sQLString = "select * from emr_dict_detail where class_code='DBZXX' order by input_code";
            DataTable dataTable = DALUse.Query(sQLString).Tables[0];
            if (dataTable.Rows.Count < 1)
            {
            }
        }
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtDISCHARGE_DATE_TIME_DragOver(object sender, DragEventArgs e)
        {
        }
        private void dgvOperation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comAUTOPSY_INDICATOR, "YESNO");
        }
        private void txtUseTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void dgvOperation_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.m_MRFirstPageDAL.getPatientIsOut(this.m_strPatientID, this.m_nVisitID.ToString()).Equals(true))
            {
                this.txtDISCHARGE_DATE_TIME.Text = "";
                this.txtDEPT_DISCHARGE_FROM.Text = "";
                this.Save();
            }
            else
            {
                MessageBox.Show("病人已出院，需临床大夫修改出院日期！");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtSy_TextChanged(object sender, EventArgs e)
        {
        }
        private void pictureBox50_Click(object sender, EventArgs e)
        {
        }
        private void textdiagnosis_desc28_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtDISCHARGE_PASS_TextChanged(object sender, EventArgs e)
        {
        }
        private void cmdBLOOD_TYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBLOOD_TYPE.Tag = this.cmdBLOOD_TYPE.Text;
            this.txtBLOOD_TYPE.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtBLOOD_TYPE.Tag.ToString());
        }
        private void cmdBLOOD_TYPE_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.cmdBLOOD_TYPE, "BLOOD_TYPE");
        }
        private void cmdBLOOD_TYPE_DropDownClosed(object sender, EventArgs e)
        {
            this.cmdBLOOD_TYPE.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtADVANCED_STUDIES_DOCTOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            if ((e.KeyChar > 'A' && e.KeyChar < 'Z') || (e.KeyChar > 'a' && e.KeyChar < 'z'))
            {
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(base.Controls, (TextBox)sender);
                instance.Name = "input";
                instance.loadData();
                base.Controls.Add(instance);
                base.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(base.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtPRACTICE_DOCTOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            if ((e.KeyChar > 'A' && e.KeyChar < 'Z') || (e.KeyChar > 'a' && e.KeyChar < 'z'))
            {
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(base.Controls, (TextBox)sender);
                instance.Name = "input";
                instance.loadData();
                base.Controls.Add(instance);
                base.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(base.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtLIABILITY_NURSE_ID_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtLIABILITY_NURSE_ID_KeyDown(sender, e2);
        }
        private void txtLIABILITY_NURSE_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            if ((e.KeyChar > 'A' && e.KeyChar < 'Z') || (e.KeyChar > 'a' && e.KeyChar < 'z'))
            {
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(base.Controls, (TextBox)sender);
                instance.Name = "input";
                instance.loadData();
                base.Controls.Add(instance);
                base.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(base.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtLIABILITY_NURSE_ID_Leave(object sender, EventArgs e)
        {
            if (this.txtLIABILITY_NURSE_ID.Text.Trim().Length > 0)
            {
                if (this.txtLIABILITY_NURSE_ID.Tag == null)
                {
                    this.txtLIABILITY_NURSE_ID.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtLIABILITY_NURSE_ID.Text.Trim());
                }
            }
        }
        private void txtLIABILITY_NURSE_ID_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtDoctorListSelKeyDown(ref e, ref this.txtLIABILITY_NURSE_ID);
        }
        private void txtDOCTOR_OF_CONTROL_QUALITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            if ((e.KeyChar > 'A' && e.KeyChar < 'Z') || (e.KeyChar > 'a' && e.KeyChar < 'z'))
            {
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(base.Controls, (TextBox)sender);
                instance.Name = "input";
                instance.loadData();
                base.Controls.Add(instance);
                base.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(base.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtDOCTOR_OF_CONTROL_QUALITY_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtDOCTOR_OF_CONTROL_QUALITY_KeyDown(sender, e2);
        }
        private void txtDOCTOR_OF_CONTROL_QUALITY_Leave(object sender, EventArgs e)
        {
            if (this.txtDOCTOR_OF_CONTROL_QUALITY.Text.Trim().Length > 0)
            {
                if (this.txtDOCTOR_OF_CONTROL_QUALITY.Tag == null)
                {
                    this.txtDOCTOR_OF_CONTROL_QUALITY.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtDOCTOR_OF_CONTROL_QUALITY.Text.Trim());
                }
            }
        }
        private void txtNURSE_OF_CONTROL_QUALITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            if ((e.KeyChar > 'A' && e.KeyChar < 'Z') || (e.KeyChar > 'a' && e.KeyChar < 'z'))
            {
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(base.Controls, (TextBox)sender);
                instance.Name = "input";
                instance.loadData();
                base.Controls.Add(instance);
                base.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(base.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtNURSE_OF_CONTROL_QUALITY_Leave(object sender, EventArgs e)
        {
            if (this.txtNURSE_OF_CONTROL_QUALITY.Text.Trim().Length > 0)
            {
                if (this.txtNURSE_OF_CONTROL_QUALITY.Tag == null)
                {
                    this.txtNURSE_OF_CONTROL_QUALITY.Tag = this.m_MRFirstPageDAL.getDoctorID(this.txtNURSE_OF_CONTROL_QUALITY.Text.Trim());
                }
            }
        }
        private void txtNURSE_OF_CONTROL_QUALITY_DoubleClick(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control.Name == "input")
                {
                    base.Controls.Remove(control);
                    return;
                }
            }
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtNURSE_OF_CONTROL_QUALITY_KeyDown(sender, e2);
        }
        private void dgvOperation_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvDiagnose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void txtOCCUPATION_DoubleClick_1(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtOCCUPATION_KeyDown(sender, e2);
        }
        private void txtBIRTH_PLACE_DoubleClick_1(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtBIRTH_PLACE_KeyDown(sender, e2);
        }
        private void txtJIGUAN_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtJIGUAN_KeyDown(sender, e2);
        }
        private void txtNATION_DoubleClick_1(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtNATION_KeyDown(sender, e2);
        }
        private void txtDISCHARGE_DATE_TIME_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtVisit_id_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtBIRTH_PLACE_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtJIGUAN_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtADVANCED_STUDIES_DOCTOR_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtNURSE_OF_CONTROL_QUALITY_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnFY_Click(object sender, EventArgs e)
		{
            frmMrfirstFY frm=new frmMrfirstFY ();
            frm.m_strPatientID = this.m_strPatientID;
            frm.m_nVisitID = this.m_nVisitID;
            frm.ShowDialog();
		}
        private void comDISCHARGE_CONDITIONS_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDISCHARGE_CONDITIONS.Tag = this.comDISCHARGE_CONDITIONS.Text;
            this.txtDISCHARGE_CONDITIONS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtDISCHARGE_CONDITIONS.Tag.ToString());
        }
        private void comDISCHARGE_CONDITIONS_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comDISCHARGE_CONDITIONS, "DISCHARGE_CONDITIONS");
        }
        private void comDISCHARGE_CONDITIONS_DropDownClosed(object sender, EventArgs e)
        {
            this.txtDISCHARGE_CONDITIONS.Focus();
        }
        private Image getUserImage(string strUserId)
        {
            DataTable dataTable = new DataTable();
            dataTable = UCMRFirstPage.getUserPic(strUserId);
            Image result;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                if (dataTable.Rows[0]["USER_NAME_PIC"].ToString() != "")
                {
                    this.m_btUser = (byte[])dataTable.Rows[0]["USER_NAME_PIC"];
                    MemoryStream stream = new MemoryStream(this.m_btUser);
                    result = Image.FromStream(stream);
                    return result;
                }
            }
            result = null;
            return result;
        }
        public static DataTable getUserPic(string strUserId)
        {
            string sQLString = "select * from users_pic  t  where t.user_id = '" + strUserId + "'";
            DataTable dataTable = DALUse.Query(sQLString).Tables[0];
            DataTable result;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                result = dataTable;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static bool IsCAUser(string ID)
        {
            string text = string.Empty;
            bool result;
            try
            {
                text = "select * from users_ca t where t.user_id='" + ID + "'";
                DataTable dataTable = DALUse.Query(text).Tables[0];
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception e)
            {
                Log.WriteLog(e, text);
                result = false;
            }
            return result;
        }
        private void picDIRECTOR_DoubleClick(object sender, EventArgs e)
        {
            this.txtDIRECTOR_DoubleClick(null, EventArgs.Empty);
            if (this.txtDIRECTOR.Tag != null && UCMRFirstPage.IsCAUser(this.txtDIRECTOR.Tag.ToString()))
            {
                this.picDIRECTOR.Visible = true;
                this.picDIRECTOR.Image = this.getUserImage(this.txtDIRECTOR.Tag.ToString());
            }
            else
            {
                this.picDIRECTOR.Visible = false;
            }
        }
        private void picCHIEF_DOCTOR_DoubleClick(object sender, EventArgs e)
        {
            this.txtCHIEF_DOCTOR_DoubleClick(null, EventArgs.Empty);
            if (this.txtCHIEF_DOCTOR.Tag != null && UCMRFirstPage.IsCAUser(this.txtCHIEF_DOCTOR.Tag.ToString()))
            {
                this.picCHIEF_DOCTOR.Image = this.getUserImage(this.txtCHIEF_DOCTOR.Tag.ToString());
                this.picCHIEF_DOCTOR.Visible = true;
            }
            else
            {
                this.picCHIEF_DOCTOR.Visible = false;
            }
        }
        private void picATTENDING_DOCTOR_DoubleClick(object sender, EventArgs e)
        {
            this.txtATTENDING_DOCTOR_DoubleClick(null, EventArgs.Empty);
            if (this.txtATTENDING_DOCTOR.Tag != null && UCMRFirstPage.IsCAUser(this.txtATTENDING_DOCTOR.Tag.ToString()))
            {
                this.picATTENDING_DOCTOR.Image = this.getUserImage(this.txtATTENDING_DOCTOR.Tag.ToString());
                this.picATTENDING_DOCTOR.Visible = true;
            }
            else
            {
                this.picATTENDING_DOCTOR.Visible = false;
            }
        }
        private void picDOCTOR_IN_CHARGE_Click(object sender, EventArgs e)
        {
        }
        private void picDOCTOR_IN_CHARGE_DoubleClick(object sender, EventArgs e)
        {
            this.picDOCTOR_IN_CHARGE.Visible = true;
            this.txtDOCTOR_IN_CHARGE_DoubleClick(null, EventArgs.Empty);
            if (this.txtDOCTOR_IN_CHARGE.Tag != null && UCMRFirstPage.IsCAUser(this.txtDOCTOR_IN_CHARGE.Tag.ToString()))
            {
                this.picDOCTOR_IN_CHARGE.Image = this.getUserImage(this.txtDOCTOR_IN_CHARGE.Tag.ToString());
                this.picDOCTOR_IN_CHARGE.Visible = true;
            }
            else
            {
                this.picDOCTOR_IN_CHARGE.Visible = false;
            }
        }
        private void picLIABILITY_NURSE_ID_DoubleClick(object sender, EventArgs e)
        {
            this.picLIABILITY_NURSE_ID.Visible = true;
            this.txtLIABILITY_NURSE_ID_DoubleClick(null, EventArgs.Empty);
            if (this.txtLIABILITY_NURSE_ID.Tag != null && UCMRFirstPage.IsCAUser(this.txtLIABILITY_NURSE_ID.Tag.ToString()))
            {
                this.picLIABILITY_NURSE_ID.Image = this.getUserImage(this.txtLIABILITY_NURSE_ID.Tag.ToString());
                this.picLIABILITY_NURSE_ID.Visible = true;
            }
            else
            {
                this.picLIABILITY_NURSE_ID.Visible = false;
            }
        }
        private void picADVANCED_STUDIES_DOCTOR_DoubleClick(object sender, EventArgs e)
        {
            this.txtADVANCED_STUDIES_DOCTOR_DoubleClick(null, EventArgs.Empty);
            if (this.txtADVANCED_STUDIES_DOCTOR.Tag != null && UCMRFirstPage.IsCAUser(this.txtADVANCED_STUDIES_DOCTOR.Tag.ToString()))
            {
                this.picADVANCED_STUDIES_DOCTOR.Image = this.getUserImage(this.txtADVANCED_STUDIES_DOCTOR.Tag.ToString());
                this.picADVANCED_STUDIES_DOCTOR.Visible = true;
            }
            else
            {
                this.picADVANCED_STUDIES_DOCTOR.Visible = false;
            }
        }
        private void picPRACTICE_DOCTOR_DoubleClick(object sender, EventArgs e)
        {
            this.txtPRACTICE_DOCTOR_DoubleClick(null, EventArgs.Empty);
            if (this.txtPRACTICE_DOCTOR.Tag != null && UCMRFirstPage.IsCAUser(this.txtPRACTICE_DOCTOR.Tag.ToString()))
            {
                this.picPRACTICE_DOCTOR.Image = this.getUserImage(this.txtPRACTICE_DOCTOR.Tag.ToString());
                this.picPRACTICE_DOCTOR.Visible = true;
            }
            else
            {
                this.picPRACTICE_DOCTOR.Visible = false;
            }
        }
        private void picDOCTOR_OF_CONTROL_QUALITY_DoubleClick(object sender, EventArgs e)
        {
            this.txtDOCTOR_OF_CONTROL_QUALITY_DoubleClick(null, EventArgs.Empty);
            string userId = MRFirstPageDAL.getUserId(this.txtDOCTOR_OF_CONTROL_QUALITY.Text);
            if (userId != null && UCMRFirstPage.IsCAUser(userId))
            {
                this.picDOCTOR_OF_CONTROL_QUALITY.Image = this.getUserImage(userId);
                this.picDOCTOR_OF_CONTROL_QUALITY.Visible = true;
            }
            else
            {
                this.picDOCTOR_OF_CONTROL_QUALITY.Visible = false;
            }
        }
        private void picNURSE_OF_CONTROL_QUALITY_DoubleClick(object sender, EventArgs e)
        {
            this.txtNURSE_OF_CONTROL_QUALITY_DoubleClick(null, EventArgs.Empty);
            string userId = MRFirstPageDAL.getUserId(this.txtNURSE_OF_CONTROL_QUALITY.Text);
            if (userId != null && UCMRFirstPage.IsCAUser(userId))
            {
                this.picNURSE_OF_CONTROL_QUALITY.Image = this.getUserImage(userId);
                this.picNURSE_OF_CONTROL_QUALITY.Visible = true;
            }
            else
            {
                this.picNURSE_OF_CONTROL_QUALITY.Visible = false;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtWZRYJH.Tag = this.comboBox2.Text;
            this.txtWZRYJH.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtWZRYJH.Tag.ToString());
        }
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comboBox2, "HAVENO");
        }
        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            this.txtWZRYJH.Focus();
            SendKeys.Send("{tab}");
        }
    }
}
