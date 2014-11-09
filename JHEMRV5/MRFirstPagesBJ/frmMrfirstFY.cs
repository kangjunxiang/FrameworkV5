using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysDAL;
using JHEMR.EmrSysCom;

namespace JHEMR.MRFirstPagesBJ
{
    public partial class frmMrfirstFY : Form
    {
        public string m_strPatientID = "";
        public int m_nVisitID = 0;
        private string m_strFieldName = "";
        private DateTime? admission_date = new DateTime?(default(DateTime));
        private DateTime? discharge_date = new DateTime?(default(DateTime));
        public MRFirstPageDAL m_MRFirstPageDAL = new MRFirstPageDAL();
        public frmMrfirstFY()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.save())
            {
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            this.m_strPatientID = strPatientID;
            this.m_nVisitID = nVisitID;
            this.m_MRFirstPageDAL.fillPatientFirstPageData(this.m_strPatientID, this.m_nVisitID);
            this.fillFirstPageData();
        }
        public void fillFirstPageData()
        {
            string text = string.Empty;
            if (this.m_MRFirstPageDAL.m_dsFuYe.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsFuYe.Tables.Count == 1)
                {
                    if (this.m_MRFirstPageDAL.m_dsFuYe.Tables[0].Rows.Count == 1)
                    {
                        DataRow dataRow = this.m_MRFirstPageDAL.m_dsFuYe.Tables[0].Rows[0];
                        if (dataRow["SUFFSORCODE"] != DBNull.Value)
                        {
                            text = dataRow["SUFFSORCODE"].ToString();
                            this.txtSuffsorcode.Tag = text;
                            this.txtSuffsorcode.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("SUFFER", text);
                        }
                        else
                        {
                            this.txtSuffsorcode.Text = "1";
                        }
                        if (dataRow["BASENUM"] != DBNull.Value)
                        {
                            this.txtbaseNum.Text = dataRow["BASENUM"].ToString();
                        }
                        if (dataRow["OTHERNUM"] != DBNull.Value)
                        {
                            this.txtOthernum.Text = dataRow["OTHERNUM"].ToString();
                        }
                        if (dataRow["SUFFERCLASS"] != DBNull.Value)
                        {
                            text = dataRow["SUFFERCLASS"].ToString();
                            this.txtSufferclass.Tag = text;
                            this.txtSufferclass.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("SUFFERCLASS", text);
                        }
                        else
                        {
                            this.txtSufferclass.Text = "0";
                        }
                        if (dataRow["OUTIDEAL"] != DBNull.Value)
                        {
                            text = dataRow["OUTIDEAL"].ToString();
                            this.txtOutideal.Tag = text;
                            this.txtOutideal.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("OUTIDEAL", text);
                        }
                        if (dataRow["HAVEPREPARATION"] != DBNull.Value)
                        {
                            text = dataRow["HAVEPREPARATION"].ToString();
                            this.txtHavepreparation.Tag = text;
                            this.txtHavepreparation.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("ISZHONGYAO", text);
                        }
                        if (dataRow["INFONLYTYPE"] != DBNull.Value)
                        {
                            text = dataRow["INFONLYTYPE"].ToString();
                            this.txtIfonlytype.Tag = text;
                            this.txtIfonlytype.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("INFONLYTYPE", text);
                        }
                        if (dataRow["SALVAGEWAY"] != DBNull.Value)
                        {
                            text = dataRow["SALVAGEWAY"].ToString();
                            this.txtSalvageWay.Tag = text;
                            this.txtSalvageWay.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("SALVAGEWAY", text);
                        }
                        else
                        {
                            this.txtSalvageWay.Text = "2";
                        }
                        if (dataRow["DIFFCON"] != DBNull.Value)
                        {
                            text = dataRow["DIFFCON"].ToString();
                            this.txtDiffcon.Text = text;
                            this.txtDiffcon.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("INFONLYTYPE", text);
                        }
                        else
                        {
                            this.txtDiffcon.Text = "2";
                        }
                        if (dataRow["ISDANGER"] != DBNull.Value)
                        {
                            text = dataRow["ISDANGER"].ToString();
                            this.txtisDanger.Tag = text;
                            this.txtisDanger.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("INFONLYTYPE", text);
                        }
                        else
                        {
                            this.txtisDanger.Text = "2";
                        }
                        if (dataRow["FIRSTEXAM"] != DBNull.Value)
                        {
                            text = dataRow["FIRSTEXAM"].ToString();
                            this.txtFIRST_CASE_INDICATOR.Tag = text;
                            this.txtFIRST_CASE_INDICATOR.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("INFONLYTYPE", text);
                        }
                        if (dataRow["RELECTCOUNT"] != DBNull.Value)
                        {
                            this.txtrelectcount.Text = dataRow["RELECTCOUNT"].ToString();
                        }
                        if (dataRow["DEADREASON"] != DBNull.Value)
                        {
                            this.txtdeadreason.Text = dataRow["DEADREASON"].ToString();
                        }
                        if (dataRow["DEADCODE"] != DBNull.Value)
                        {
                            text = dataRow["DEADCODE"].ToString();
                            this.txtdeadcode.Tag = text;
                            this.txtdeadcode.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("DATETYPE", text);
                        }
                        else
                        {
                            this.txtdeadcode.Text = "";
                        }
                        if (dataRow["ZOPERATION"] != DBNull.Value)
                        {
                            this.txtzoperation.Text = dataRow["ZOPERATION"].ToString();
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
                        DataRow dataRow2 = this.m_MRFirstPageDAL.m_dsPatientVisit.Tables[0].Rows[0];
                        if (dataRow2["HBSAG_INDICATOR"] != DBNull.Value)
                        {
                            text = dataRow2["HBSAG_INDICATOR"].ToString();
                            this.txtHBSAG.Tag = text;
                            this.txtHBSAG.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("HBSAG_INDICATOR", text);
                        }
                        else
                        {
                            this.txtHBSAG.Text = "0";
                        }
                        if (dataRow2["HCV_AB_INDICATOR"] != DBNull.Value)
                        {
                            text = dataRow2["HCV_AB_INDICATOR"].ToString();
                            this.txtHCV_AB.Tag = text;
                            this.txtHCV_AB.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("HBSAG_INDICATOR", text);
                        }
                        else
                        {
                            this.txtHCV_AB.Text = "0";
                        }
                        if (dataRow2["HIV_AB_INDICATOR"] != DBNull.Value)
                        {
                            text = dataRow2["HIV_AB_INDICATOR"].ToString();
                            this.txtHIV_AB.Tag = text;
                            this.txtHIV_AB.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("HBSAG_INDICATOR", text);
                        }
                        else
                        {
                            this.txtHIV_AB.Text = "0";
                        }
                        if (dataRow2["EMER_TREAT_TIMES"] != DBNull.Value)
                        {
                            this.txtEMER_TREAT_TIMES.Text = dataRow2["EMER_TREAT_TIMES"].ToString();
                        }
                        if (dataRow2["ESC_EMER_TIMES"] != DBNull.Value)
                        {
                            this.txtsuccesscount.Text = dataRow2["ESC_EMER_TIMES"].ToString();
                        }
                        if (dataRow2["IS_THREE_DAY_DIAGNOSIS"] != DBNull.Value)
                        {
                            this.txtIS_THREE_DAY_DIAGNOSIS.Text = dataRow2["IS_THREE_DAY_DIAGNOSIS"].ToString();
                        }
                        if (dataRow2["CRITIACL_TREAT_TIMES"] != DBNull.Value)
                        {
                            this.txtCRITIACL_TREAT_TIMES.Text = dataRow2["CRITIACL_TREAT_TIMES"].ToString();
                        }
                        if (dataRow2["CRITIACL_EMER_TIMES"] != DBNull.Value)
                        {
                            this.txtCRITIACL_EMER_TIMES.Text = dataRow2["CRITIACL_EMER_TIMES"].ToString();
                        }
                        if (dataRow2["OPERAITON_ILL_TIMES"] != DBNull.Value)
                        {
                            this.txtOPERAITON_ILL_TIMES.Text = dataRow2["OPERAITON_ILL_TIMES"].ToString();
                        }
                        if (dataRow2["MR_VALUE"] != DBNull.Value)
                        {
                            text = dataRow2["MR_VALUE"].ToString();
                            this.txtMR_VALUE.Tag = text;
                            this.txtMR_VALUE.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("MR_VALUE", text);
                            if (this.txtMR_VALUE.Text.Equals("0") || this.txtMR_VALUE.Text.Length == 0 || this.txtMR_VALUE.Text.Length == 2)
                            {
                                this.txtMR_VALUE.Text = "－";
                            }
                            if (this.txtMR_VALUE.Text.Equals("否"))
                            {
                                this.txtMR_VALUE.Text = "2";
                            }
                        }
                        else
                        {
                            this.txtMR_VALUE.Text = "－";
                        }
                        if (dataRow2["BLOOD_TRAN_REACT_TIMES"] != DBNull.Value)
                        {
                            this.txtbloodrection.Text = dataRow2["BLOOD_TRAN_REACT_TIMES"].ToString();
                            if (this.txtbloodrection.Text.Equals("0") || this.txtbloodrection.Text.Length == 0)
                            {
                                this.txtbloodrection.Text = "－";
                            }
                        }
                        else
                        {
                            this.txtbloodrection.Text = "－";
                        }
                        if (dataRow2["DEATH_DATE_TIME"] != DBNull.Value)
                        {
                            this.txtdeadtime.Text = Convert.ToDateTime(dataRow2["DEATH_DATE_TIME"].ToString()).ToString("yyyy-MM-dd ");
                        }
                        if (dataRow2["PAT_ADM_CONDITION"] != DBNull.Value)
                        {
                            text = dataRow2["PAT_ADM_CONDITION"].ToString();
                            this.txtIncircs.Tag = text;
                            this.txtIncircs.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("PAT_ADM_CONDITION", text);
                        }
                        else
                        {
                            this.txtIncircs.Text = "3";
                        }
                        this.admission_date = null;
                        if (dataRow2["ADMISSION_DATE_TIME"] != DBNull.Value)
                        {
                            this.admission_date = new DateTime?(Convert.ToDateTime(dataRow2["ADMISSION_DATE_TIME"].ToString()));
                        }
                        this.discharge_date = null;
                        if (dataRow2["DISCHARGE_DATE_TIME"] != DBNull.Value)
                        {
                            this.discharge_date = new DateTime?(Convert.ToDateTime(dataRow2["DISCHARGE_DATE_TIME"].ToString()));
                        }
                    }
                }
            }
            if (this.m_MRFirstPageDAL.m_dsDiagComparing.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsDiagComparing.Tables.Count == 1)
                {
                    foreach (DataRow dataRow3 in this.m_MRFirstPageDAL.m_dsDiagComparing.Tables[0].Rows)
                    {
                        string text2 = dataRow3["DIAG_COMPARE_GROUP"].ToString();
                        string text3 = text2;
                        switch (text3)
                        {
                            case "1":
                                this.txtDIAG_COMPARE_GROUP1.Text = dataRow3["DIAG_CORRESPONDENCE"].ToString();
                                if (this.txtDIAG_COMPARE_GROUP1.Text.Equals("4"))
                                {
                                    this.txtDIAG_COMPARE_GROUP1.Text = "0";
                                }
                                break;
                            case "2":
                                this.txtDIAG_COMPARE_GROUP7.Text = dataRow3["DIAG_CORRESPONDENCE"].ToString();
                                if (this.txtDIAG_COMPARE_GROUP7.Text.Equals("4"))
                                {
                                    this.txtDIAG_COMPARE_GROUP7.Text = "0";
                                }
                                break;
                            case "3":
                                this.txtDIAG_COMPARE_GROUP3.Text = dataRow3["DIAG_CORRESPONDENCE"].ToString();
                                if (this.txtDIAG_COMPARE_GROUP3.Text.Equals("4"))
                                {
                                    this.txtDIAG_COMPARE_GROUP3.Text = "0";
                                }
                                break;
                            case "4":
                                this.txtDIAG_COMPARE_GROUP4.Text = dataRow3["DIAG_CORRESPONDENCE"].ToString();
                                if (this.txtDIAG_COMPARE_GROUP4.Text.Equals("4"))
                                {
                                    this.txtDIAG_COMPARE_GROUP4.Text = "0";
                                }
                                break;
                            case "6":
                                this.txtDIAG_COMPARE_GROUP6.Text = dataRow3["DIAG_CORRESPONDENCE"].ToString();
                                if (this.txtDIAG_COMPARE_GROUP6.Text.Equals("4"))
                                {
                                    this.txtDIAG_COMPARE_GROUP6.Text = "0";
                                }
                                break;
                            case "7":
                                this.txtDIAG_COMPARE_GROUP7.Text = dataRow3["DIAG_CORRESPONDENCE"].ToString();
                                if (this.txtDIAG_COMPARE_GROUP7.Text.Equals("7"))
                                {
                                    this.txtDIAG_COMPARE_GROUP7.Text = "0";
                                }
                                break;
                            case "8":
                                this.txtDIAG_COMPARE_GROUP8.Text = dataRow3["DIAG_CORRESPONDENCE"].ToString();
                                if (this.txtDIAG_COMPARE_GROUP8.Text.Equals("8"))
                                {
                                    this.txtDIAG_COMPARE_GROUP8.Text = "0";
                                }
                                break;
                        }
                    }
                }
            }
            if (this.m_MRFirstPageDAL.m_dsBloodTransfusion.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsBloodTransfusion.Tables.Count == 1)
                {
                    if (this.m_MRFirstPageDAL.m_dsBloodTransfusion.Tables[0].Rows.Count == 1)
                    {
                        DataRow dataRow = this.m_MRFirstPageDAL.m_dsBloodTransfusion.Tables[0].Rows[0];
                        if (dataRow["RED_CELL"] != DBNull.Value)
                        {
                            this.txtRED_CELL.Text = dataRow["RED_CELL"].ToString();
                        }
                        if (dataRow["PLATELET"] != DBNull.Value)
                        {
                            this.txtPLATELET.Text = dataRow["PLATELET"].ToString();
                        }
                        if (dataRow["PLASMA"] != DBNull.Value)
                        {
                            this.txtPLASMA.Text = dataRow["PLASMA"].ToString();
                        }
                        if (dataRow["WHOLE_BLOOD"] != DBNull.Value)
                        {
                            this.txtWHOLE_BLOOD.Text = dataRow["WHOLE_BLOOD"].ToString();
                        }
                        if (dataRow["OTHERS"] != DBNull.Value)
                        {
                            this.txtOTHERS.Text = dataRow["OTHERS"].ToString();
                        }
                    }
                }
            }
        }
        public bool save()
        {
            bool result;
            if (!this.validatePatvisit())
            {
                result = false;
            }
            else
            {
                string strSQL = "select count(*) from emr_fuye where patient_id='" + this.m_strPatientID + "' and visit_id=" + this.m_nVisitID.ToString().Trim();
                int count = DALUse.GetCount(strSQL);
                DateTime dateTime = default(DateTime);
                if (this.txtdeadtime.Text.Trim().Length > 0)
                {
                    dateTime = Convert.ToDateTime(this.txtdeadtime.Text.Substring(0, 10) + " 00:00:00");
                }
                else
                {
                    dateTime = Convert.ToDateTime("0001-1-1");
                }
                string text;
                if (count <= 0)
                {
                    text = "insert into emr_fuye (patient_id,visit_id,suffsorcode,basenum,othernum,sufferclass,havepreparation,infonlytype,salvageway,diffcon,isdanger,deadcode,relectcount,isfirst,deadreason,outideal,zoperation,firstexam) values(";
                    text = text + "'" + this.m_strPatientID + "',";
                    text = text + "'" + this.m_nVisitID.ToString().Trim() + "',";
                    text = text + this.txtSuffsorcode.Text.Trim() + ",";
                    text = text + "'" + this.txtbaseNum.Text.Trim() + "',";
                    text = text + "'" + this.txtOthernum.Text.Trim() + "',";
                    text = text + this.txtSufferclass.Text.Trim() + ",";
                    text = text + this.txtHavepreparation.Text.Trim() + ",";
                    text = text + this.txtIfonlytype.Text.Trim() + ",";
                    text = text + this.txtSalvageWay.Text.Trim() + ",";
                    if (this.txtDiffcon.Text.Trim().Length > 0)
                    {
                        text = text + this.txtDiffcon.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "null,";
                    }
                    if (this.txtisDanger.Text.Trim().Length > 0)
                    {
                        text = text + this.txtisDanger.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "null,";
                    }
                    if (this.txtdeadtime.ToString().Trim().Length > 0)
                    {
                        if (this.txtdeadcode.Text.Trim().Length > 0)
                        {
                            text = text + this.txtdeadcode.Text.Trim() + ",";
                        }
                        else
                        {
                            text += "null,";
                        }
                    }
                    else
                    {
                        text += "null,";
                    }
                    if (this.txtrelectcount.Text.Trim().Length > 0)
                    {
                        text = text + this.txtrelectcount.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "null,";
                    }
                    if (this.txtisfirst.Text.Trim().Length > 0)
                    {
                        text = text + this.txtisfirst.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "null,";
                    }
                    if (this.txtdeadreason.Text.Trim().Length > 0)
                    {
                        text = text + "'" + this.txtdeadreason.Text.Trim() + "',";
                    }
                    else
                    {
                        text += "null,";
                    }
                    if (this.txtOutideal.Text.Trim().Length > 0)
                    {
                        text = text + this.txtOutideal.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "null,";
                    }
                    if (this.txtzoperation.Text.Trim().Length > 0)
                    {
                        text = text + "'" + this.txtzoperation.Text.Trim() + "',";
                    }
                    else
                    {
                        text += "null,";
                    }
                    if (this.txtFIRST_CASE_INDICATOR.Text.Trim().Length > 0)
                    {
                        text = text + this.txtFIRST_CASE_INDICATOR.Text.Trim() + ")";
                    }
                    else
                    {
                        text += "null)";
                    }
                    DALUse.ExecuteSql(text);
                }
                else
                {
                    text = "update emr_fuye set  ";
                    if (this.txtrelectcount.Text.Length > 0)
                    {
                        text = text + " RELECTCOUNT= " + this.txtrelectcount.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "RELECTCOUNT=null";
                    }
                    text = text + "SUFFSORCODE =" + this.txtSuffsorcode.Text.Trim() + ",";
                    text = text + "BASENUM='" + this.txtbaseNum.Text.Trim() + "',";
                    text = text + "OTHERNUM ='" + this.txtOthernum.Text.Trim() + "',";
                    text = text + "SUFFERCLASS= " + this.txtSufferclass.Text.Trim() + ",";
                    text = text + "HAVEPREPARATION= " + this.txtHavepreparation.Text.Trim() + ",";
                    if (this.txtIfonlytype.Text.Length > 0)
                    {
                        text = text + "INFONLYTYPE =" + this.txtIfonlytype.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "INFONLYTYPE=null, ";
                    }
                    if (this.txtSalvageWay.Text.Length > 0)
                    {
                        text = text + "SALVAGEWAY =" + this.txtSalvageWay.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "SALVAGEWAY=null, ";
                    }
                    if (this.txtDiffcon.Text.Length > 0)
                    {
                        text = text + "DIFFCON=" + this.txtDiffcon.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "DIFFCON=null, ";
                    }
                    if (this.txtisDanger.Text.Length > 0)
                    {
                        text = text + "ISDANGER =" + this.txtisDanger.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "ISDANGER=null, ";
                    }
                    text = text + "ISFIRST=" + this.txtisfirst.Text.Trim() + ",";
                    if (this.txtFIRST_CASE_INDICATOR.Text.Length > 0)
                    {
                        text = text + "FIRSTEXAM=" + this.txtFIRST_CASE_INDICATOR.Text.Trim() + ",";
                    }
                    else
                    {
                        text += "FIRSTEXAM=null, ";
                    }
                    if (this.txtdeadtime.Text.Trim().Length > 0)
                    {
                        text = text + "DEADCODE='" + this.txtdeadcode.Text.Trim() + "',";
                    }
                    else
                    {
                        text += "DEADCODE=null,";
                    }
                    if (this.txtdeadreason.Text.Length > 0)
                    {
                        text = text + "DEADREASON='" + this.txtdeadreason.Text.Trim() + "',";
                    }
                    else
                    {
                        text += "DEADREASON=null, ";
                    }
                    if (this.txtzoperation.Text.Length > 0)
                    {
                        text = text + "ZOPERATION='" + this.txtzoperation.Text.Trim() + "'";
                    }
                    else
                    {
                        text += "ZOPERATION=null";
                    }
                    object obj = text;
                    text = string.Concat(new object[]
					{
						obj,
						" WHERE PATIENT_ID='",
						this.m_strPatientID,
						"' AND VISIT_ID=",
						this.m_nVisitID
					});
                    DALUse.ExecuteSql(text);
                }
                text = " update pat_visit set ";
                text = text + "  PAT_ADM_CONDITION=  '" + this.txtIncircs.Tag.ToString() + "',";
                if (this.txtHBSAG.Text.Length > 0)
                {
                    text = text + "HBSAG_INDICATOR=" + this.txtHBSAG.Text.Trim() + " ,";
                }
                else
                {
                    text += "HBSAG_INDICATOR=null ,";
                }
                if (this.txtHCV_AB.Text.Length > 0)
                {
                    object obj = text;
                    text = string.Concat(new object[]
					{
						obj,
						"HCV_AB_INDICATOR=",
						int.Parse(this.txtHCV_AB.Text.Trim()),
						","
					});
                }
                else
                {
                    text += "HCV_AB_INDICATOR=null,";
                }
                if (this.txtHIV_AB.Text.Length > 0)
                {
                    object obj = text;
                    text = string.Concat(new object[]
					{
						obj,
						"HIV_AB_INDICATOR=",
						int.Parse(this.txtHIV_AB.Text.Trim()),
						","
					});
                }
                else
                {
                    text += "HIV_AB_INDICATOR=null,";
                }
                if (dateTime.ToString() == "0001-1-1 0:00:00" || dateTime.ToString() == "0001/1/1 0:00:00" || dateTime.ToString() == "0001-1-1" || dateTime.ToString() == "0001/1/1")
                {
                    text += "DEATH_DATE_TIME=null,";
                }
                else
                {
                    text = text + "DEATH_DATE_TIME= " + DBCustomFunctionUse.ToDate(dateTime.ToShortDateString(), true, false) + ",";
                }
                text = text + "EMER_TREAT_TIMES=" + ((this.txtEMER_TREAT_TIMES.Text.Length > 0) ? this.txtEMER_TREAT_TIMES.Text : "0") + ",";
                text = text + "ESC_EMER_TIMES=" + ((this.txtsuccesscount.Text.Length > 0) ? this.txtsuccesscount.Text : "0") + ",";
                text = text + "MR_VALUE= '" + this.txtMR_VALUE.Text.Trim() + "',";
                text = text + "IS_THREE_DAY_DIAGNOSIS='" + this.txtIS_THREE_DAY_DIAGNOSIS.Text.Trim() + "',";
                text = text + "CRITIACL_TREAT_TIMES='" + this.txtCRITIACL_TREAT_TIMES.Text.Trim() + "',";
                text = text + "CRITIACL_EMER_TIMES='" + this.txtCRITIACL_EMER_TIMES.Text.Trim() + "',";
                text = text + "OPERAITON_ILL_TIMES='" + this.txtOPERAITON_ILL_TIMES.Text.Trim() + "',";
                text = text + "BLOOD_TRAN_REACT_TIMES=" + (this.txtbloodrection.Text.Equals("－") ? "0" : ((this.txtbloodrection.Text.Length > 0) ? this.txtbloodrection.Text : "0"));
                string text2 = text;
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
                text = "UPDATE BLOOD_TRANSFUSION SET RED_CELL=" + ((this.txtRED_CELL.Text.Length > 0) ? this.txtRED_CELL.Text : "0") + ",";
                text = text + "PLATELET=" + ((this.txtPLATELET.Text.ToString() != "—") ? this.txtPLATELET.Text : "0") + ",";
                text = text + "PLASMA=" + ((this.txtPLASMA.Text.ToString() != "—") ? this.txtPLASMA.Text : "0") + ",";
                text = text + "WHOLE_BLOOD=" + ((this.txtWHOLE_BLOOD.Text.ToString() != "—") ? this.txtWHOLE_BLOOD.Text : "0") + ",";
                text2 = text;
                text = string.Concat(new string[]
				{
					text2,
					"OTHERS=",
					(this.txtOTHERS.Text.ToString() != "—") ? this.txtOTHERS.Text : "0",
					" WHERE PATIENT_ID='",
					this.m_strPatientID,
					"' AND VISIT_ID=",
					this.m_nVisitID.ToString()
				});
                DALUse.ExecuteSql(text);
                text = "DELETE FROM diag_comparing WHERE PATIENT_ID='" + this.m_strPatientID + "' AND visit_id=" + this.m_nVisitID.ToString();
                DALUse.ExecuteSql(text);
                string text3 = "INSERT INTO DIAG_COMPARING(PATIENT_ID,VISIT_ID,DIAG_COMPARE_GROUP,DIAG_CORRESPONDENCE) VALUES(";
                text = text3;
                text = text + "'" + this.m_strPatientID + "',";
                text = text + this.m_nVisitID.ToString() + ",'1','";
                text += ((this.txtDIAG_COMPARE_GROUP1.Text.Length > 0) ? this.txtDIAG_COMPARE_GROUP1.Text.Trim() : "0");
                text += "')";
                DALUse.ExecuteSql(text);
                text = text3;
                text = text + "'" + this.m_strPatientID + "',";
                text = text + this.m_nVisitID.ToString() + ",'2','";
                text += ((this.txtDIAG_COMPARE_GROUP2.Text.Length > 0) ? this.txtDIAG_COMPARE_GROUP2.Text.Trim() : "0");
                text += "')";
                DALUse.ExecuteSql(text);
                text = text3;
                text = text + "'" + this.m_strPatientID + "',";
                text = text + this.m_nVisitID.ToString() + ",'3','";
                text += ((this.txtDIAG_COMPARE_GROUP3.Text.Length > 0) ? this.txtDIAG_COMPARE_GROUP3.Text.Trim() : "0");
                text += "')";
                DALUse.ExecuteSql(text);
                text = text3;
                text = text + "'" + this.m_strPatientID + "',";
                text = text + this.m_nVisitID.ToString() + ",'4','";
                text += ((this.txtDIAG_COMPARE_GROUP4.Text.Length > 0) ? this.txtDIAG_COMPARE_GROUP4.Text.Trim() : "0");
                text += "')";
                DALUse.ExecuteSql(text);
                text = text3;
                text = text + "'" + this.m_strPatientID + "',";
                text = text + this.m_nVisitID.ToString() + ",'6','";
                text += ((this.txtDIAG_COMPARE_GROUP6.Text.Length > 0) ? this.txtDIAG_COMPARE_GROUP6.Text.Trim() : "0");
                text += "')";
                DALUse.ExecuteSql(text);
                text = text3;
                text = text + "'" + this.m_strPatientID + "',";
                text = text + this.m_nVisitID.ToString() + ",'7','";
                text += ((this.txtDIAG_COMPARE_GROUP7.Text.Length > 0) ? this.txtDIAG_COMPARE_GROUP7.Text.Trim() : "0");
                text += "')";
                DALUse.ExecuteSql(text);
                text = text3;
                text = text + "'" + this.m_strPatientID + "',";
                text = text + this.m_nVisitID.ToString() + ",'8','";
                text += ((this.txtDIAG_COMPARE_GROUP8.Text.Length > 0) ? this.txtDIAG_COMPARE_GROUP8.Text.Trim() : "0");
                text += "')";
                DALUse.ExecuteSql(text);
                this.setPatientInfo(this.m_strPatientID, this.m_nVisitID);
                result = true;
            }
            return result;
        }
        private void txtDIAG_COMPARE_GROUP1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comDIAG_COMPARE_GROUP1.Focus();
                this.comDIAG_COMPARE_GROUP1.DroppedDown = true;
            }
        }
        private void txtDIAG_COMPARE_GROUP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comDIAG_COMPARE_GROUP2.Focus();
                this.comDIAG_COMPARE_GROUP2.DroppedDown = true;
            }
        }
        private void txtDIAG_COMPARE_GROUP3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comDIAG_COMPARE_GROUP3.Focus();
                this.comDIAG_COMPARE_GROUP3.DroppedDown = true;
            }
        }
        private void txtDIAG_COMPARE_GROUP4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comDIAG_COMPARE_GROUP4.Focus();
                this.comDIAG_COMPARE_GROUP4.DroppedDown = true;
            }
        }
        private void txtDIAG_COMPARE_GROUP6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comDIAG_COMPARE_GROUP6.Focus();
                this.comDIAG_COMPARE_GROUP6.DroppedDown = true;
            }
        }
        private void txtDIAG_COMPARE_GROUP7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comDIAG_COMPARE_GROUP7.Focus();
                this.comDIAG_COMPARE_GROUP7.DroppedDown = true;
            }
        }
        private void txtDIAG_COMPARE_GROUP8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comDIAG_COMPARE_GROUP8.Focus();
                this.comDIAG_COMPARE_GROUP8.DroppedDown = true;
            }
        }
        private void comDIAG_COMPARE_GROUP1_DropDownClosed(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP1.Focus();
            SendKeys.Send("{tab}");
        }
        private void comDIAG_COMPARE_GROUP4_DropDownClosed(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP4.Focus();
            SendKeys.Send("{tab}");
        }
        private void comDIAG_COMPARE_GROUP3_DropDownClosed(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP3.Focus();
            SendKeys.Send("{tab}");
        }
        private void comDIAG_COMPARE_GROUP6_DropDownClosed(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP6.Focus();
            SendKeys.Send("{tab}");
        }
        private void comDIAG_COMPARE_GROUP2_DropDownClosed(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP2.Focus();
            SendKeys.Send("{tab}");
        }
        private void comDIAG_COMPARE_GROUP7_DropDownClosed(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP7.Focus();
            SendKeys.Send("{tab}");
        }
        private void comDIAG_COMPARE_GROUP8_DropDownClosed(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP8.Focus();
            SendKeys.Send("{tab}");
        }
        private void comDIAG_COMPARE_GROUP1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP1.Tag = this.comDIAG_COMPARE_GROUP1.Text;
            this.txtDIAG_COMPARE_GROUP1.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtDIAG_COMPARE_GROUP1.Tag.ToString());
        }
        private void comDIAG_COMPARE_GROUP4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP4.Tag = this.comDIAG_COMPARE_GROUP4.Text;
            this.txtDIAG_COMPARE_GROUP4.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtDIAG_COMPARE_GROUP4.Tag.ToString());
        }
        private void comDIAG_COMPARE_GROUP3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP3.Tag = this.comDIAG_COMPARE_GROUP3.Text;
            this.txtDIAG_COMPARE_GROUP3.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtDIAG_COMPARE_GROUP3.Tag.ToString());
        }
        private void txtRED_CELL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtRED_CELL.Text.Length == 0)
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (this.txtRED_CELL.Text.IndexOf(".") > 0)
                {
                    if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (this.txtRED_CELL.Text.Length > 4)
                    {
                        if (e.KeyChar != '.' && e.KeyChar != '\b')
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
        private void txtPLATELET_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtPLATELET.Text.Length == 0)
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (this.txtPLATELET.Text.IndexOf(".") > 0)
                {
                    if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (this.txtPLATELET.Text.Length > 4)
                    {
                        if (e.KeyChar != '.' && e.KeyChar != '\b')
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
        private void txtPLASMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtPLASMA.Text.Length == 0)
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (this.txtPLASMA.Text.IndexOf(".") > 0)
                {
                    if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (this.txtPLASMA.Text.Length > 4)
                    {
                        if (e.KeyChar != '.' && e.KeyChar != '\b')
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
        private void txtWHOLE_BLOOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtWHOLE_BLOOD.Text.Length == 0)
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (this.txtWHOLE_BLOOD.Text.IndexOf(".") > 0)
                {
                    if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (this.txtWHOLE_BLOOD.Text.Length > 4)
                    {
                        if (e.KeyChar != '.' && e.KeyChar != '\b')
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
        private void txtOTHERS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtOTHERS.Text.Length == 0)
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (this.txtOTHERS.Text.IndexOf(".") > 0)
                {
                    if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (this.txtOTHERS.Text.Length > 4)
                    {
                        if (e.KeyChar != '.' && e.KeyChar != '\b')
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
        private void txtSufferclass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comSufferclass.Focus();
                this.comSufferclass.DroppedDown = true;
            }
        }
        private void comSufferclass_DropDownClosed(object sender, EventArgs e)
        {
            this.txtSufferclass.Focus();
            SendKeys.Send("{tab}");
        }
        private void comSufferclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSufferclass.Tag = this.comSufferclass.Text;
            this.txtSufferclass.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtSufferclass.Tag.ToString());
        }
        private void txtSuffsorcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comSuffsorcode.Focus();
                this.comSuffsorcode.DroppedDown = true;
            }
        }
        private void comSuffsorcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSuffsorcode.Tag = this.comSuffsorcode.Text;
            this.txtSuffsorcode.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtSuffsorcode.Tag.ToString());
        }
        private void comSuffsorcode_DropDownClosed(object sender, EventArgs e)
        {
            this.txtSuffsorcode.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtIncircs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comIncirs.Focus();
                this.comIncirs.DroppedDown = true;
            }
        }
        private void comIncirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtIncircs.Tag = this.comIncirs.Text;
            this.txtIncircs.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtIncircs.Tag.ToString());
        }
        private void comIncirs_DropDownClosed(object sender, EventArgs e)
        {
            this.txtIncircs.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtOutideal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comOutideal.Focus();
                this.comOutideal.DroppedDown = true;
            }
        }
        private void comOutideal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtOutideal.Tag = this.comOutideal.Text;
            this.txtOutideal.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtOutideal.Tag.ToString());
        }
        private void comOutideal_DropDownClosed(object sender, EventArgs e)
        {
            this.txtOutideal.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtHavepreparation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comHavepreparation.Focus();
                this.comHavepreparation.DroppedDown = true;
            }
        }
        private void comHavepreparation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtHavepreparation.Tag = this.comHavepreparation.Text;
            this.txtHavepreparation.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtHavepreparation.Tag.ToString());
        }
        private void comHavepreparation_DropDownClosed(object sender, EventArgs e)
        {
            this.txtHavepreparation.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtIfonlytype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comIfonlytype.Focus();
                this.comIfonlytype.DroppedDown = true;
            }
        }
        private void comIfonlytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtIfonlytype.Tag = this.comIfonlytype.Text;
            this.txtIfonlytype.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtIfonlytype.Tag.ToString());
        }
        private void txtHBSAG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comHBSAG.Focus();
                this.comHBSAG.DroppedDown = true;
            }
        }
        private void comHBSAG_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtHBSAG.Tag = this.comHBSAG.Text;
            this.txtHBSAG.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtHBSAG.Tag.ToString());
        }
        private void comHBSAG_DropDownClosed(object sender, EventArgs e)
        {
            this.txtHBSAG.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtHCV_AB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comHCV_AB.Focus();
                this.comHCV_AB.DroppedDown = true;
            }
        }
        private void comHCV_AB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtHCV_AB.Tag = this.comHCV_AB.Text;
            this.txtHCV_AB.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtHCV_AB.Tag.ToString());
        }
        private void comHCV_AB_DropDownClosed(object sender, EventArgs e)
        {
            this.txtHCV_AB.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtHIV_AB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comHIV_AB.Focus();
                this.comHIV_AB.DroppedDown = true;
            }
        }
        private void comHIV_AB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtHIV_AB.Tag = this.comHIV_AB.Text;
            this.txtHIV_AB.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtHIV_AB.Tag.ToString());
        }
        private void comHIV_AB_DropDownClosed(object sender, EventArgs e)
        {
            this.txtHIV_AB.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtDiffcon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comDiffcon.Focus();
                this.comDiffcon.DroppedDown = true;
            }
        }
        private void comDiffcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDiffcon.Tag = this.comDiffcon.Text;
            this.txtDiffcon.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtDiffcon.Tag.ToString());
        }
        private void comDiffcon_DropDownClosed(object sender, EventArgs e)
        {
            this.txtDiffcon.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtisDanger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comisDanger.Focus();
                this.comisDanger.DroppedDown = true;
            }
        }
        private void txtSalvageWay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comSalvageWay.Focus();
                this.comSalvageWay.DroppedDown = true;
            }
        }
        private void comisDanger_DropDownClosed(object sender, EventArgs e)
        {
            this.txtisDanger.Focus();
            SendKeys.Send("{tab}");
        }
        private void comisDanger_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtisDanger.Tag = this.comisDanger.Text;
            this.txtisDanger.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtisDanger.Tag.ToString());
        }
        private void comSalvageWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSalvageWay.Tag = this.comSalvageWay.Text;
            this.txtSalvageWay.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtSalvageWay.Tag.ToString());
        }
        private void comSalvageWay_DropDownClosed(object sender, EventArgs e)
        {
            this.txtSalvageWay.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtFIRST_CASE_INDICATOR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comFIRST_CASE_INDICATOR.Focus();
                this.comFIRST_CASE_INDICATOR.DroppedDown = true;
            }
        }
        private void comFIRST_CASE_INDICATOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFIRST_CASE_INDICATOR.Tag = this.comFIRST_CASE_INDICATOR.Text;
            this.txtFIRST_CASE_INDICATOR.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtFIRST_CASE_INDICATOR.Tag.ToString());
        }
        private void comFIRST_CASE_INDICATOR_DropDownClosed(object sender, EventArgs e)
        {
            this.txtFIRST_CASE_INDICATOR.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtdeadcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comdeadCode.Focus();
                this.comdeadCode.DroppedDown = true;
            }
        }
        private void comdeadCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtdeadcode.Tag = this.comdeadCode.Text;
            this.txtdeadcode.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtdeadcode.Tag.ToString());
        }
        private void comdeadCode_DropDownClosed(object sender, EventArgs e)
        {
            this.txtdeadcode.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtisfirst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comisfirst.Focus();
                this.comisfirst.DroppedDown = true;
            }
        }
        private void comisfirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtisfirst.Tag = this.comisfirst.Text;
            this.txtisfirst.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtisfirst.Tag.ToString());
        }
        private void comisfirst_DropDownClosed(object sender, EventArgs e)
        {
            this.txtisfirst.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtbloodrection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.combloodrection.Focus();
                this.combloodrection.DroppedDown = true;
            }
        }
        private void combloodrection_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtbloodrection.Tag = this.combloodrection.Text;
            this.txtbloodrection.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtbloodrection.Tag.ToString());
        }
        private void combloodrection_DropDownClosed(object sender, EventArgs e)
        {
            this.txtbloodrection.Focus();
            SendKeys.Send("{tab}");
        }
        private void txtMR_VALUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.comMR_VALUE.Focus();
                this.comMR_VALUE.DroppedDown = true;
            }
        }
        private void comMR_VALUE_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtMR_VALUE.Tag = this.comMR_VALUE.Text;
            this.txtMR_VALUE.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtMR_VALUE.Tag.ToString());
        }
        private void comMR_VALUE_DropDownClosed(object sender, EventArgs e)
        {
            this.txtMR_VALUE.Focus();
            SendKeys.Send("{tab}");
        }
        public bool validatePatvisit()
        {
            bool result;
            if (this.txtSufferclass.Text.Trim() == "")
            {
                MessageBox.Show("患者类型不能为空！");
                result = false;
            }
            else
            {
                if (this.txtHavepreparation.Text.Trim() == "")
                {
                    MessageBox.Show("请选择是否中药治疗！");
                    result = false;
                }
                else
                {
                    if (this.txtIfonlytype.Text.Trim() == "")
                    {
                        MessageBox.Show("请选择是否单病种！");
                        result = false;
                    }
                    else
                    {
                        if (this.txtSalvageWay.Text.Trim() == "")
                        {
                            MessageBox.Show("请选择抢救方式");
                            result = false;
                        }
                        else
                        {
                            if (this.txtFIRST_CASE_INDICATOR.Text.Trim() == "")
                            {
                                MessageBox.Show("请输入手术、诊断、治疗、检查是否是第一例！");
                                result = false;
                            }
                            else
                            {
                                if (this.txtisfirst.Text.Trim() == "")
                                {
                                    MessageBox.Show("请选择是否是是第一次！");
                                    result = false;
                                }
                                else
                                {
                                    if (this.txtMR_VALUE.Text.Trim() == "")
                                    {
                                        MessageBox.Show("请选择是否示教病历！");
                                        result = false;
                                    }
                                    else
                                    {
                                        if (this.txtbloodrection.Text.Trim() == "")
                                        {
                                            MessageBox.Show("请选择输血反应！");
                                            result = false;
                                        }
                                        else
                                        {
                                            if (this.m_MRFirstPageDAL.getPatientTemplet("C31", this.m_strPatientID, this.m_nVisitID.ToString()))
                                            {
                                                if ((this.txtRED_CELL.Text.Length == 0 || this.txtRED_CELL.Text == "0") && (this.txtPLATELET.Text.Length == 0 || this.txtPLATELET.Text == "0") && (this.txtPLASMA.Text.Length == 0 || this.txtPLASMA.Text == "0") && (this.txtWHOLE_BLOOD.Text.Length == 0 || this.txtWHOLE_BLOOD.Text == "0") && (this.txtOTHERS.Text.Length == 0 || this.txtOTHERS.Text == "0"))
                                                {
                                                    MessageBox.Show("有输血记录，请填写输血品种！");
                                                    result = false;
                                                    return result;
                                                }
                                            }
                                            if (this.txtSuffsorcode.Text.Trim() == "")
                                            {
                                                MessageBox.Show("请选择患者来源编码！");
                                                result = false;
                                            }
                                            else
                                            {
                                                if (Convert.ToInt32(this.txtsuccesscount.Text.Trim()) > Convert.ToInt32(this.txtEMER_TREAT_TIMES.Text.Trim()))
                                                {
                                                    MessageBox.Show("成功次数不能大于抢救次数！");
                                                    result = false;
                                                }
                                                else
                                                {
                                                    if (Convert.ToInt32(this.txtrelectcount.Text.Trim()) > Convert.ToInt32(this.txtEMER_TREAT_TIMES.Text.Trim()))
                                                    {
                                                        MessageBox.Show("抢救反应次数不能小于抢救次数");
                                                        result = false;
                                                    }
                                                    else
                                                    {
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
            return result;
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
        private void comSufferclass_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comSufferclass, "SUFFERCLASS");
        }
        private void comSuffsorcode_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comSuffsorcode, "SUFFER");
        }
        private void comIncirs_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comIncirs, "PAT_ADM_CONDITION");
        }
        private void comOutideal_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comOutideal, "OUTIDEAL");
        }
        private void comHavepreparation_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comHavepreparation, "ISZHONGYAO");
        }
        private void comIfonlytype_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comIfonlytype, "IFONLYTYPE");
        }
        private void comIfonlytype_DropDownClosed(object sender, EventArgs e)
        {
            this.txtIfonlytype.Focus();
            SendKeys.Send("{tab}");
        }
        private void comHBSAG_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comHBSAG, "HBSAG_INDICATOR");
        }
        private void comHCV_AB_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comHCV_AB, "HBSAG_INDICATOR");
        }
        private void comHIV_AB_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comHIV_AB, "HBSAG_INDICATOR");
        }
        private void comDIAG_COMPARE_GROUP1_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comDIAG_COMPARE_GROUP1, "DIAG_COMPARE_GROUP");
        }
        private void comDIAG_COMPARE_GROUP4_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comDIAG_COMPARE_GROUP4, "DIAG_COMPARE_GROUP");
        }
        private void comDIAG_COMPARE_GROUP3_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comDIAG_COMPARE_GROUP3, "DIAG_COMPARE_GROUP");
        }
        private void comDIAG_COMPARE_GROUP6_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comDIAG_COMPARE_GROUP6, "DIAG_COMPARE_GROUP");
        }
        private void comDIAG_COMPARE_GROUP2_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comDIAG_COMPARE_GROUP2, "DIAG_COMPARE_GROUP");
        }
        private void comDIAG_COMPARE_GROUP7_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comDIAG_COMPARE_GROUP7, "DIAG_COMPARE_GROUP");
        }
        private void comDIAG_COMPARE_GROUP8_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comDIAG_COMPARE_GROUP8, "DIAG_COMPARE_GROUP");
        }
        private void comDiffcon_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comDiffcon, "IFONLYTYPE");
        }
        private void comisDanger_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comisDanger, "IFONLYTYPE");
        }
        private void comSalvageWay_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comSalvageWay, "SALVAGEWAY");
        }
        private void comFIRST_CASE_INDICATOR_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comFIRST_CASE_INDICATOR, "IFONLYTYPE");
        }
        private void comdeadCode_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comdeadCode, "DEADTYPE");
        }
        private void comisfirst_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comisfirst, "IFONLYTYPE");
        }
        private void comMR_VALUE_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comMR_VALUE, "YESNO");
        }
        private void combloodrection_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.combloodrection, "OUTIDEAL");
        }
        private void txtdeadtime_DoubleClick(object sender, EventArgs e)
        {
            KeyEventArgs e2 = new KeyEventArgs(Keys.Return);
            this.txtdeadtime_KeyDown(sender, e2);
        }
        private void txtdeadtime_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtTimeKeyDown(ref sender, ref e, ref this.txtdeadtime);
        }
        private void txtTimeKeyDown(ref object sender, ref KeyEventArgs e, ref TextBox txt)
        {
            if (e.KeyCode == Keys.Return)
            {
                frmTimeSel frmTimeSel = new frmTimeSel();
                if (frmTimeSel.ShowDialog() == DialogResult.OK)
                {
                    string timeSel = frmTimeSel.m_timeSel;
                    if (DateTime.Parse(frmTimeSel.m_timeSel) < DateTime.Parse(this.admission_date.ToString().Substring(0, 10)))
                    {
                        MessageBox.Show("死亡日期不能在入院日期之前!");
                    }
                    else
                    {
                        if (this.discharge_date.ToString() != "")
                        {
                            if (DateTime.Parse(frmTimeSel.m_timeSel) > DateTime.Parse(this.discharge_date.ToString()))
                            {
                                MessageBox.Show("死亡日期不能在出院日期之后!");
                            }
                            else
                            {
                                txt.Text = timeSel;
                                txt.Tag = timeSel;
                            }
                        }
                        else
                        {
                            txt.Text = timeSel;
                            txt.Tag = timeSel;
                        }
                    }
                }
            }
        }
        private void frmMrfirstFY_Load(object sender, EventArgs e)
        {
            this.setPatientInfo(this.m_strPatientID, this.m_nVisitID);
        }
        private void comDIAG_COMPARE_GROUP6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP6.Tag = this.comDIAG_COMPARE_GROUP6.Text;
            this.txtDIAG_COMPARE_GROUP6.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtDIAG_COMPARE_GROUP6.Tag.ToString());
        }
        private void comDIAG_COMPARE_GROUP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP2.Tag = this.comDIAG_COMPARE_GROUP2.Text;
            this.txtDIAG_COMPARE_GROUP2.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtDIAG_COMPARE_GROUP2.Tag.ToString());
        }
        private void comDIAG_COMPARE_GROUP7_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP7.Tag = this.comDIAG_COMPARE_GROUP7.Text;
            this.txtDIAG_COMPARE_GROUP7.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtDIAG_COMPARE_GROUP7.Tag.ToString());
        }
        private void comDIAG_COMPARE_GROUP8_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtDIAG_COMPARE_GROUP8.Tag = this.comDIAG_COMPARE_GROUP8.Text;
            this.txtDIAG_COMPARE_GROUP8.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtDIAG_COMPARE_GROUP8.Tag.ToString());
        }
        private void comzoperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtzoperation.Text = this.comzoperation.Text;
        }
        private void comIS_THREE_DAY_DIAGNOSIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtIS_THREE_DAY_DIAGNOSIS.Tag = this.comIS_THREE_DAY_DIAGNOSIS.Text;
            this.txtIS_THREE_DAY_DIAGNOSIS.Text = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue(this.m_strFieldName, this.txtIS_THREE_DAY_DIAGNOSIS.Tag.ToString());
        }
        private void comIS_THREE_DAY_DIAGNOSIS_DropDown(object sender, EventArgs e)
        {
            this.comboBoxDropDown(ref this.comIS_THREE_DAY_DIAGNOSIS, "IFONLYTYPE");
        }
        private void comIS_THREE_DAY_DIAGNOSIS_DropDownClosed(object sender, EventArgs e)
        {
            this.txtIS_THREE_DAY_DIAGNOSIS.Focus();
            SendKeys.Send("{tab}");
        }
    }
}