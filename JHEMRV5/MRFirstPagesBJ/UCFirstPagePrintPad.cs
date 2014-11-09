using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysUserCtl;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.MRFirstPagesBJ
{
    public partial class UCFirstPagePrintPad : UCEMRPad30
    {
        private MRFirstPageDAL m_MRFirstPageDAL = new MRFirstPageDAL();
        private bool mb_pat_is_open_state = false;
        private string m_strFileName;
        public string m_strPatientID;
        public int m_nVisitID;
        public static string strTemp = string.Empty;
        public UCFirstPagePrintPad()
        {
            InitializeComponent(); base.PadSetDocumentMode(2);
            base.PadShowToolbar(false);
        }
        public bool open_mr_file(string strFileName)
        {
            bool result;
            if (this.m_strFileName == strFileName && this.mb_pat_is_open_state)
            {
                result = true;
            }
            else
            {
                base.PadCleanPadDocumentMircoFieldElemValue();
                if (base.PadOpenFile(EmrSysPubVar.getTempFileFullName()))
                {
                    base.PadSetDocumentMode(2);
                    base.PadShowToolbar(false);
                    this.m_strFileName = strFileName;
                    this.mb_pat_is_open_state = true;
                    result = true;
                }
                else
                {
                    MessageBox.Show("错误信息", "打开不可识别格式的文件!");
                    result = false;
                }
            }
            return result;
        }
        public bool open_templet_file()
        {
            this.m_MRFirstPageDAL.fillPatientFirstPageData(this.m_strPatientID, this.m_nVisitID);
            base.PadCleanPadDocumentMircoFieldElemValue();
            string text = string.Empty;
            string sQLString = string.Empty;
            sQLString = "select inp_no from pat_master_index where patient_id='" + this.m_strPatientID + "'";
            DataSet dataSet = DALUse.Query(sQLString);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                text = dataSet.Tables[0].Rows[0]["inp_no"].ToString();
            }
            else
            {
                text = this.m_strPatientID;
            }
            base.PadSetMicroField("条码", "*" + text + "*");
            base.PadSetMicroField("病案号", text.ToString());
            base.PadSetMicroField("住院次", " " + this.m_nVisitID.ToString().Trim() + " ");
            sQLString = "SELECT MEDICAL_PAY_WAY FROM PAT_VISIT WHERE PATIENT_ID='" + this.m_strPatientID + "' AND VISIT_ID=" + this.m_nVisitID.ToString();
            object single = DALUse.GetSingle(sQLString);
            if (single != null)
            {
                base.PadSetMicroField("医疗付费方式", " " + single.ToString() + " ");
            }
            base.PadUpdateMicroField(true);
            bool result;
            if (!base.PadOpenFile(EmrSysPubVar.getTempFileFullName()))
            {
                MessageBox.Show("打开文件出错!");
                result = false;
            }
            else
            {
                base.PadSetDocumentMode(1);
                base.PadShowToolbar(true);
                this.fillFirstPageData();
                base.PadSetDocumentMode(2);
                base.PadShowToolbar(false);
                base.PadEnsureVisibleTopLine();
                base.PadSetFocus();
                base.PadCleanUndoBuffer();
                result = true;
            }
            return result;
        }
        public static int getascii(char c)
        {
            return (int)c;
        }
        public int save_mr_file()
        {
            int result;
            if (!base.PadFileSaveAs(EmrSysPubVar.getTempFileFullName(), 0, 0))
            {
                MessageBox.Show("保存文件出错。");
                result = -1;
            }
            else
            {
                result = 1;
            }
            return result;
        }
        private void fillFirstPageData()
        {
            DateTime serverNow = EmrSysPubFunction.getServerNow();
            DateTime dtBirth = serverNow;
            if (this.m_MRFirstPageDAL.m_dsPatientMasterIndex.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsPatientMasterIndex.Tables.Count == 1)
                {
                    if (this.m_MRFirstPageDAL.m_dsPatientMasterIndex.Tables[0].Rows.Count == 1)
                    {
                        DataRow dataRow = this.m_MRFirstPageDAL.m_dsPatientMasterIndex.Tables[0].Rows[0];
                        if (base.PadFindField("姓名", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, dataRow["NAME"].ToString());
                        }
                        if (base.PadFindField("性别", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, dataRow["SEX"].ToString());
                        }
                        if (dataRow["Date_of_birth"] != DBNull.Value)
                        {
                            if (base.PadFindField("出生年", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["Date_of_birth"].ToString()).ToString("yyyy"));
                            }
                            if (base.PadFindField("出生月", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["Date_of_birth"].ToString()).ToString("MM"));
                            }
                            if (base.PadFindField("出生日", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["Date_of_birth"].ToString()).ToString("dd"));
                            }
                            dtBirth = Convert.ToDateTime(dataRow["Date_of_birth"].ToString());
                        }
                        if (dataRow["BIRTH_PLACE"] != DBNull.Value)
                        {
                            if (dataRow["BIRTH_PLACE"].ToString().Length > 10)
                            {
                                if (base.PadFindField("出生地", -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, dataRow["BIRTH_PLACE"].ToString().Substring(0, 10));
                                }
                            }
                            else
                            {
                                if (base.PadFindField("出生地", -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, dataRow["BIRTH_PLACE"].ToString());
                                }
                            }
                        }
                        if (dataRow["JIGUAN"] != DBNull.Value)
                        {
                            if (base.PadFindField("籍贯", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["JIGUAN"].ToString());
                            }
                        }
                        if (dataRow["BABYAGE"] != DBNull.Value)
                        {
                            if (base.PadFindField("新生儿年龄", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["BABYAGE"].ToString());
                            }
                        }
                        if (dataRow["NATION"] != DBNull.Value)
                        {
                            if (base.PadFindField("民族", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["NATION"].ToString());
                            }
                        }
                        if (dataRow["CITIZENSHIP"] != DBNull.Value)
                        {
                            if (base.PadFindField("国籍", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["CITIZENSHIP"].ToString());
                            }
                        }
                        if (dataRow["ID_NO"] != DBNull.Value)
                        {
                            if (base.PadFindField("身份证号", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["ID_NO"].ToString());
                            }
                        }
                        if (base.PadFindField("婴儿性别", -1, 1, true))
                        {
                            UCFirstPagePrintPad.strTemp = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("SEX", UCFirstPagePrintPad.strTemp);
                            if (!(UCFirstPagePrintPad.strTemp == "1"))
                            {
                                if (!(UCFirstPagePrintPad.strTemp == "2"))
                                {
                                    UCFirstPagePrintPad.strTemp = "－";
                                }
                            }
                            base.PadSetFieldText(-1, -1, -1, -1, " " + (UCFirstPagePrintPad.strTemp.Equals("－") ? "-" : UCFirstPagePrintPad.strTemp) + " ");
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
                        if (dataRow["MARITAL_STATUS"] != DBNull.Value)
                        {
                            string text = dataRow["MARITAL_STATUS"].ToString();
                            string text2 = text;
                            if (text2 != null)
                            {
                                if (!(text2 == "未婚"))
                                {
                                    if (!(text2 == "已婚"))
                                    {
                                        if (!(text2 == "丧偶"))
                                        {
                                            if (!(text2 == "离婚"))
                                            {
                                                if (text2 == "其他")
                                                {
                                                    text = "9";
                                                }
                                            }
                                            else
                                            {
                                                text = "4";
                                            }
                                        }
                                        else
                                        {
                                            text = "3";
                                        }
                                    }
                                    else
                                    {
                                        text = "2";
                                    }
                                }
                                else
                                {
                                    text = "1";
                                }
                            }
                            if (base.PadFindField("婚姻", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, text);
                            }
                        }
                        if (dataRow["OCCUPATION"] != DBNull.Value)
                        {
                            if (base.PadFindField("职业", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["OCCUPATION"].ToString().Equals("不便分类的其他从业人员") ? "-" : dataRow["OCCUPATION"].ToString());
                            }
                        }
                        if (dataRow["SERVICE_AGENCY"] != DBNull.Value)
                        {
                            if (base.PadFindField("工作单位", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["SERVICE_AGENCY"].ToString());
                            }
                        }
                        if (dataRow["NEXT_OF_KIN"] != DBNull.Value)
                        {
                            if (base.PadFindField("联系人姓名", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["NEXT_OF_KIN"].ToString());
                            }
                        }
                        if (dataRow["NEXT_OF_KIN_ADDR"] != DBNull.Value)
                        {
                            if (base.PadFindField("联系人地址", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["NEXT_OF_KIN_ADDR"].ToString());
                            }
                        }
                        if (dataRow["NEXT_OF_KIN_PHONE"] != DBNull.Value)
                        {
                            if (base.PadFindField("联系人电话", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["NEXT_OF_KIN_PHONE"].ToString());
                            }
                        }
                        if (dataRow["RELATIONSHIP"] != DBNull.Value)
                        {
                            if (base.PadFindField("关系", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["RELATIONSHIP"].ToString());
                            }
                        }
                        if (dataRow["ADMISSION_DATE_TIME"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院年", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["ADMISSION_DATE_TIME"].ToString()).ToString("yyyy"));
                            }
                            if (base.PadFindField("入院月", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["ADMISSION_DATE_TIME"].ToString()).ToString("MM"));
                            }
                            if (base.PadFindField("入院日", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["ADMISSION_DATE_TIME"].ToString()).ToString("dd"));
                            }
                            if (base.PadFindField("入院时", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["ADMISSION_DATE_TIME"].ToString()).ToString("HH"));
                            }
                        }
                        if (dataRow["DEPT_ADMISSION_TO"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院科别", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, EmrSysPubFunction.getDeptName(dataRow["DEPT_ADMISSION_TO"].ToString(), false));
                            }
                        }
                        UCFirstPagePrintPad.strTemp = "床";
                        if (dataRow["BED_ADMISSION_TO"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp = dataRow["BED_ADMISSION_TO"].ToString() + UCFirstPagePrintPad.strTemp;
                        }
                        if (base.PadFindField("入院病室", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp.Equals("床") ? " " : UCFirstPagePrintPad.strTemp);
                        }
                        if (base.PadFindField("出院病室", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp.Equals("床") ? " " : UCFirstPagePrintPad.strTemp);
                        }
                        if (dataRow["DISCHARGE_DATE_TIME"] != DBNull.Value)
                        {
                            if (base.PadFindField("出院年", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["DISCHARGE_DATE_TIME"].ToString()).ToString("yyyy"));
                            }
                            if (base.PadFindField("出院月", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["DISCHARGE_DATE_TIME"].ToString()).ToString("MM"));
                            }
                            if (base.PadFindField("出院日", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["DISCHARGE_DATE_TIME"].ToString()).ToString("dd"));
                            }
                            if (base.PadFindField("出院时", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["DISCHARGE_DATE_TIME"].ToString()).ToString("HH"));
                            }
                            if (base.PadFindField("实际住院日", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, " " + EmrSysPubFunction.GetBetweenDays(Convert.ToDateTime(dataRow["ADMISSION_DATE_TIME"].ToString()), Convert.ToDateTime(dataRow["DISCHARGE_DATE_TIME"].ToString())));
                            }
                            string age = UCMRFirstPage.GetAge(Convert.ToDateTime(dataRow["DISCHARGE_DATE_TIME"].ToString()), dtBirth);
                            if (age.Contains("/"))
                            {
                                if (base.PadFindField("新生儿年龄", -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, UCMRFirstPage.GetAge(Convert.ToDateTime(dataRow["DISCHARGE_DATE_TIME"].ToString()), dtBirth));
                                }
                            }
                            else
                            {
                                if (base.PadFindField("年龄", -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, UCMRFirstPage.GetAge(Convert.ToDateTime(dataRow["DISCHARGE_DATE_TIME"].ToString()), dtBirth));
                                }
                            }
                        }
                        else
                        {
                            if (base.PadFindField("实际住院日", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, EmrSysPubFunction.GetBetweenDays(Convert.ToDateTime(dataRow["ADMISSION_DATE_TIME"].ToString()), Convert.ToDateTime(EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd") + " 00:00:00")).ToString());
                            }
                            string age = UCMRFirstPage.GetAge(Convert.ToDateTime(EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd") + " 00:00:00"), dtBirth);
                            if (age.Contains("/"))
                            {
                                if (base.PadFindField("新生儿年龄", -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, UCMRFirstPage.GetAge(Convert.ToDateTime(EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd") + " 00:00:00"), dtBirth));
                                }
                            }
                            else
                            {
                                if (base.PadFindField("年龄", -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, UCMRFirstPage.GetAge(Convert.ToDateTime(EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd") + " 00:00:00"), dtBirth));
                                }
                            }
                        }
                        if (dataRow["DIAGNOSIS_DATE"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院后确诊日期", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["DIAGNOSIS_DATE"].ToString()).ToString("yyyy年MM月dd日"));
                            }
                        }
                        if (dataRow["RUYUAN_PASS"] != DBNull.Value)
                        {
                            string text3 = dataRow["RUYUAN_PASS"].ToString();
                            string text2 = text3;
                            if (text2 != null)
                            {
                                if (!(text2 == "急诊"))
                                {
                                    if (!(text2 == "门诊"))
                                    {
                                        if (!(text2 == "其他医疗机构转入"))
                                        {
                                            if (text2 == "其他")
                                            {
                                                text3 = "9";
                                            }
                                        }
                                        else
                                        {
                                            text3 = "3";
                                        }
                                    }
                                    else
                                    {
                                        text3 = "2";
                                    }
                                }
                                else
                                {
                                    text3 = "1";
                                }
                            }
                            if (base.PadFindField("入院途径", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, text3);
                            }
                        }
                        if (dataRow["ZYMC"] != DBNull.Value)
                        {
                            if (base.PadFindField("转院名称", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["ZYMC"].ToString());
                            }
                        }
                        if (dataRow["ZYJG"] != DBNull.Value)
                        {
                            if (base.PadFindField("转院机构", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["ZYJG"].ToString());
                            }
                        }
                        if (dataRow["RUYUAN_THING"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院病情", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["RUYUAN_THING"].ToString());
                            }
                        }
                        if (dataRow["ZYMD"] != DBNull.Value)
                        {
                            if (base.PadFindField("住院目的", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["ZYMD"].ToString());
                            }
                        }
                        if (dataRow["LNSS_P_HOSPITAL_DAYS"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院前天", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["LNSS_P_HOSPITAL_DAYS"].ToString());
                            }
                        }
                        if (dataRow["LNSS_P_HOSPITAL_HOURS"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院前小时", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["LNSS_P_HOSPITAL_HOURS"].ToString());
                            }
                        }
                        if (dataRow["LNSS_P_HOSPITAL_MIN"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院前分钟", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["LNSS_P_HOSPITAL_MIN"].ToString());
                            }
                        }
                        if (dataRow["LNSS_A_HOSPITAL_DAYS"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院后天", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["LNSS_A_HOSPITAL_DAYS"].ToString());
                            }
                        }
                        if (dataRow["LNSS_A_HOSPITAL_HOURS"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院后小时", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["LNSS_A_HOSPITAL_HOURS"].ToString());
                            }
                        }
                        if (dataRow["LNSS_A_HOSPITAL_MIN"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院后分钟", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["LNSS_A_HOSPITAL_MIN"].ToString());
                            }
                        }
                        UCFirstPagePrintPad.strTemp = "";
                        if (dataRow["REGISTERED_P_R_ADDRESS"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp = dataRow["REGISTERED_P_R_ADDRESS"].ToString();
                        }
                        if (dataRow["REGISTERED_P_R_ADDRESS_DETAIL"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp += dataRow["REGISTERED_P_R_ADDRESS_DETAIL"].ToString();
                        }
                        if (UCFirstPagePrintPad.strTemp.Length > 0)
                        {
                            if (base.PadFindField("户口地址", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp);
                            }
                        }
                        if (dataRow["REGISTERED_P_R_ADDRESS_ZIP"] != DBNull.Value)
                        {
                            if (base.PadFindField("户口邮编", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["REGISTERED_P_R_ADDRESS_ZIP"].ToString());
                            }
                        }
                        UCFirstPagePrintPad.strTemp = "";
                        if (dataRow["CURRENT_ADDRESS"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp = dataRow["CURRENT_ADDRESS"].ToString();
                        }
                        if (dataRow["CURRENT_ADDRESS_DETAIL"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp += dataRow["CURRENT_ADDRESS_DETAIL"].ToString();
                        }
                        if (UCFirstPagePrintPad.strTemp.Length > 0)
                        {
                            if (base.PadFindField("现住址", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp);
                            }
                        }
                        if (dataRow["CURRENT_ADDRESS_ZIP_CODE"] != DBNull.Value)
                        {
                            if (base.PadFindField("住址邮编", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["CURRENT_ADDRESS_ZIP_CODE"].ToString());
                            }
                        }
                        if (dataRow["CURRENT_ADDRESS_PHOTO"] != DBNull.Value)
                        {
                            if (base.PadFindField("住址电话", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["CURRENT_ADDRESS_PHOTO"].ToString());
                            }
                        }
                        if (dataRow["PHONE_NUMBER_BUSINESS"] != DBNull.Value)
                        {
                            if (base.PadFindField("单位电话", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["PHONE_NUMBER_BUSINESS"].ToString());
                            }
                        }
                        if (dataRow["ZIP_CODE"] != DBNull.Value)
                        {
                            if (base.PadFindField("单位邮编", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["ZIP_CODE"].ToString());
                            }
                        }
                        if (dataRow["RESPIRATOR_USE_TIME"] != DBNull.Value)
                        {
                            if (base.PadFindField("呼吸机使用时间", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["RESPIRATOR_USE_TIME"].ToString());
                            }
                        }
                        if (dataRow["BABY_BIRTH_WEIGHT"] != DBNull.Value)
                        {
                            if (base.PadFindField("新生儿出生体重", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["BABY_BIRTH_WEIGHT"].ToString());
                            }
                        }
                        if (dataRow["BABY_ADMIN_WEIGHT"] != DBNull.Value)
                        {
                            if (base.PadFindField("新生儿入院体重", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["BABY_ADMIN_WEIGHT"].ToString());
                            }
                        }
                        if (dataRow["TUMOR_STAGE_T"] != DBNull.Value)
                        {
                            if (base.PadFindField("肿瘤分期T", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["TUMOR_STAGE_T"].ToString());
                            }
                        }
                        if (dataRow["TUMOR_STAGE_N"] != DBNull.Value)
                        {
                            if (base.PadFindField("肿瘤分期N", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["TUMOR_STAGE_N"].ToString());
                            }
                        }
                        if (dataRow["TUMOR_STAGE_M"] != DBNull.Value)
                        {
                            if (base.PadFindField("肿瘤分期M", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["TUMOR_STAGE_M"].ToString());
                            }
                        }
                        if (dataRow["ADL_ADMISSION"] != DBNull.Value)
                        {
                            if (base.PadFindField("日常生活能力_入院", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["ADL_ADMISSION"].ToString());
                            }
                        }
                        if (dataRow["ADL_DISCHARGE"] != DBNull.Value)
                        {
                            if (base.PadFindField("日常生活能力_出院", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["ADL_DISCHARGE"].ToString());
                            }
                        }
                        if (dataRow["YWGM"] != DBNull.Value)
                        {
                            if (base.PadFindField("药物过敏", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, " " + this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("HAVENO", dataRow["YWGM"].ToString()) + " ");
                            }
                        }
                        if (dataRow["BLH"] != DBNull.Value)
                        {
                            if (base.PadFindField("病理号", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["BLH"].ToString());
                            }
                        }
                        if (base.PadFindField("出院科别", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, EmrSysPubFunction.getDeptName(dataRow["DEPT_DISCHARGE_FROM"].ToString(), false));
                        }
                        if (dataRow["PAT_ADM_CONDITION"] != DBNull.Value)
                        {
                            if (base.PadFindField("入院情况", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["PAT_ADM_CONDITION"].ToString());
                            }
                        }
                        UCFirstPagePrintPad.strTemp = "－";
                        if (dataRow["TOTAL_PAYMENTS"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp = string.Format("{0:F2}", Convert.ToDouble(dataRow["TOTAL_PAYMENTS"].ToString()));
                        }
                        if (dataRow["TOTAL_COSTS"] != DBNull.Value)
                        {
                            if (base.PadFindField("总费用", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["TOTAL_COSTS"].ToString());
                            }
                        }
                        if (dataRow["ALERGY_DRUGS"] != DBNull.Value && dataRow["ALERGY_DRUGS"].ToString() != "－")
                        {
                            if (base.PadFindField("过敏药物", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["ALERGY_DRUGS"].ToString());
                            }
                        }
                        UCFirstPagePrintPad.strTemp = " ";
                        if (dataRow["MR_QUALITY"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("MR_QUALITY", dataRow["MR_QUALITY"].ToString());
                        }
                        if (base.PadFindField("病案质量", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, " " + UCFirstPagePrintPad.strTemp + " ");
                        }
                        if (dataRow["DOCTOR_OF_CONTROL_QUALITY"] != DBNull.Value)
                        {
                            if (base.PadFindField("质控医师", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["DOCTOR_OF_CONTROL_QUALITY"].ToString());
                            }
                        }
                        if (dataRow["NURSE_OF_CONTROL_QUALITY"] != DBNull.Value)
                        {
                            if (base.PadFindField("质控护士", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["NURSE_OF_CONTROL_QUALITY"].ToString());
                            }
                        }
                        if (dataRow["DATE_OF_CONTROL_QUALITY"] != DBNull.Value)
                        {
                            if (base.PadFindField("质控年", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["DATE_OF_CONTROL_QUALITY"].ToString()).ToString("yyyy"));
                            }
                            if (base.PadFindField("质控月", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["DATE_OF_CONTROL_QUALITY"].ToString()).ToString("MM"));
                            }
                            if (base.PadFindField("质控日", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow["DATE_OF_CONTROL_QUALITY"].ToString()).ToString("dd"));
                            }
                        }
                        UCFirstPagePrintPad.strTemp = "－";
                        if (dataRow["AUTOPSY_INDICATOR"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp = dataRow["AUTOPSY_INDICATOR"].ToString();
                            if (UCFirstPagePrintPad.strTemp.Equals("3"))
                            {
                                UCFirstPagePrintPad.strTemp = "0";
                            }
                            if (UCFirstPagePrintPad.strTemp.Equals("0") || UCFirstPagePrintPad.strTemp.Length == 0)
                            {
                                UCFirstPagePrintPad.strTemp = "－";
                            }
                        }
                        if (base.PadFindField("尸检", -1, 1, true))
                        {
                            UCFirstPagePrintPad.strTemp = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("YESNO", UCFirstPagePrintPad.strTemp);
                            base.PadSetFieldText(-1, -1, -1, -1, " " + UCFirstPagePrintPad.strTemp + " ");
                        }
                        UCFirstPagePrintPad.strTemp = "－";
                        if (dataRow["ZRYJH"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp = dataRow["ZRYJH"].ToString();
                            if (UCFirstPagePrintPad.strTemp.Equals("3"))
                            {
                                UCFirstPagePrintPad.strTemp = "0";
                            }
                            if (UCFirstPagePrintPad.strTemp.Equals("0") || UCFirstPagePrintPad.strTemp.Length == 0)
                            {
                                UCFirstPagePrintPad.strTemp = "－";
                            }
                        }
                        if (base.PadFindField("住院计划", -1, 1, true))
                        {
                            UCFirstPagePrintPad.strTemp = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("HAVENO", UCFirstPagePrintPad.strTemp);
                            if (!(UCFirstPagePrintPad.strTemp == "1"))
                            {
                                if (!(UCFirstPagePrintPad.strTemp == "2"))
                                {
                                    UCFirstPagePrintPad.strTemp = "－";
                                }
                            }
                            base.PadSetFieldText(-1, -1, -1, -1, " " + (UCFirstPagePrintPad.strTemp.Equals("－") ? "-" : UCFirstPagePrintPad.strTemp) + " ");
                        }
                        UCFirstPagePrintPad.strTemp = "－";
                        if (dataRow["DISCHARGE_PASS"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp = dataRow["DISCHARGE_PASS"].ToString();
                            if (UCFirstPagePrintPad.strTemp.Equals("3"))
                            {
                                UCFirstPagePrintPad.strTemp = "0";
                            }
                            if (UCFirstPagePrintPad.strTemp.Equals("0") || UCFirstPagePrintPad.strTemp.Length == 0)
                            {
                                UCFirstPagePrintPad.strTemp = "－";
                            }
                        }
                        if (base.PadFindField("离院方式", -1, 1, true))
                        {
                            UCFirstPagePrintPad.strTemp = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("DISCHARGE_PASS", UCFirstPagePrintPad.strTemp);
                            base.PadSetFieldText(-1, -1, -1, -1, " " + UCFirstPagePrintPad.strTemp + " ");
                        }
                        UCFirstPagePrintPad.strTemp = "－";
                        if (dataRow["BLOOD_TYPE"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp = dataRow["BLOOD_TYPE"].ToString();
                            if (UCFirstPagePrintPad.strTemp.Equals("QT"))
                            {
                                UCFirstPagePrintPad.strTemp = "其它";
                            }
                            UCFirstPagePrintPad.strTemp = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("BLOOD_TYPE", UCFirstPagePrintPad.strTemp);
                            if (UCFirstPagePrintPad.strTemp.Equals("0") || UCFirstPagePrintPad.strTemp.Length == 0)
                            {
                                UCFirstPagePrintPad.strTemp = "－";
                            }
                        }
                        if (base.PadFindField("血型", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, " " + UCFirstPagePrintPad.strTemp + " ");
                        }
                        UCFirstPagePrintPad.strTemp = "－";
                        if (dataRow["BLOOD_TYPE_RH"] != DBNull.Value)
                        {
                            UCFirstPagePrintPad.strTemp = dataRow["BLOOD_TYPE_RH"].ToString();
                            UCFirstPagePrintPad.strTemp = this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("BLOOD_TYPE_RH", UCFirstPagePrintPad.strTemp);
                            if (UCFirstPagePrintPad.strTemp.Equals("0") || UCFirstPagePrintPad.strTemp.Length == 0)
                            {
                                UCFirstPagePrintPad.strTemp = "-";
                            }
                        }
                        if (base.PadFindField("RH", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, " " + UCFirstPagePrintPad.strTemp + " ");
                        }
                        if (dataRow["BLH"] != DBNull.Value)
                        {
                            if (base.PadFindField("病理号", -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow["BLH"].ToString());
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
                        string strText = this.m_MRFirstPageDAL.m_dsAdtLog.Tables[0].Rows[0]["DEPT_NAME"].ToString();
                        if (this.m_MRFirstPageDAL.m_dsAdtLog.Tables[0].Rows.Count > 1)
                        {
                            strText = "→";
                        }
                        if (base.PadFindField("转科科别", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, strText);
                        }
                    }
                }
            }
            if (this.m_MRFirstPageDAL.m_dsDiagnosis.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsDiagnosis.Tables.Count == 1)
                {
                    UCFirstPagePrintPad.strTemp = "";
                    string text4 = string.Empty;
                    DataTable dataTable = this.m_MRFirstPageDAL.getDiagnosisByType(this.m_strPatientID, this.m_nVisitID, "1");
                    if (dataTable.IsInitialized)
                    {
                        foreach (DataRow dataRow2 in dataTable.Rows)
                        {
                            if (UCFirstPagePrintPad.strTemp.Length > 0)
                            {
                                UCFirstPagePrintPad.strTemp += "、";
                            }
                            if (text4.Length > 0)
                            {
                                text4 += "、";
                            }
                            UCFirstPagePrintPad.strTemp += dataRow2["diagnosis_desc"].ToString();
                            if (dataRow2["DIAGNOSIS_DESC_PART"] != DBNull.Value)
                            {
                                UCFirstPagePrintPad.strTemp = UCFirstPagePrintPad.strTemp + "(" + dataRow2["DIAGNOSIS_DESC_PART"].ToString() + ")";
                            }
                            text4 += dataRow2["DIAGNOSIS_CODE"].ToString();
                        }
                    }
                    if (base.PadFindField("diagnosis_desc1", -1, 1, true))
                    {
                        base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp);
                    }
                    if (base.PadFindField("diagnosis_code1", -1, 1, true))
                    {
                        base.PadSetFieldText(-1, -1, -1, -1, text4);
                    }
                    UCFirstPagePrintPad.strTemp = "";
                    int num = 2;
                    int num2 = 0;
                    dataTable = this.m_MRFirstPageDAL.getDiagnosisByType(this.m_strPatientID, this.m_nVisitID, "3");
                    if (dataTable.IsInitialized)
                    {
                        if (dataTable.Rows.Count > 0)
                        {
                            UCFirstPagePrintPad.strTemp = dataTable.Rows[0]["diagnosis_desc"].ToString();
                            if (base.PadFindField("diagnosis_desc" + num.ToString(), -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp);
                            }
                            if (dataTable.Rows[0]["diagnosis_code"] != DBNull.Value)
                            {
                                if (base.PadFindField("diagnosis_code" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, dataTable.Rows[0]["diagnosis_code"].ToString());
                                }
                            }
                            if (dataTable.Rows[0]["ADMISSION_CONDITIONS"] != DBNull.Value)
                            {
                                if (base.PadFindField("ADMISSION_CONDITIONS" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("RUYUAN_THING", dataTable.Rows[0]["ADMISSION_CONDITIONS"].ToString()));
                                }
                            }
                        }
                    }
                    num = 3;
                    dataTable = this.m_MRFirstPageDAL.getDiagnosisByType(this.m_strPatientID, this.m_nVisitID, "4");
                    if (dataTable.IsInitialized)
                    {
                        if (dataTable.Rows.Count > 0)
                        {
                            num2 = dataTable.Rows.Count;
                            foreach (DataRow dataRow2 in dataTable.Rows)
                            {
                                UCFirstPagePrintPad.strTemp = dataRow2["diagnosis_desc"].ToString();
                                if (dataRow2["DIAGNOSIS_DESC_PART"] != DBNull.Value)
                                {
                                    UCFirstPagePrintPad.strTemp = UCFirstPagePrintPad.strTemp + "(" + dataRow2["DIAGNOSIS_DESC_PART"].ToString() + ")";
                                }
                                if (base.PadFindField("diagnosis_desc" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp);
                                }
                                if (dataRow2["diagnosis_desc"].ToString().Equals("-") || dataRow2["diagnosis_desc"].ToString().Equals("－"))
                                {
                                    num++;
                                }
                                else
                                {
                                    if (dataRow2["diagnosis_code"] != DBNull.Value)
                                    {
                                        if (base.PadFindField("diagnosis_code" + num.ToString(), -1, 1, true))
                                        {
                                            base.PadSetFieldText(-1, -1, -1, -1, dataRow2["diagnosis_code"].ToString());
                                        }
                                    }
                                    if (dataRow2["ADMISSION_CONDITIONS"] != DBNull.Value)
                                    {
                                        if (base.PadFindField("ADMISSION_CONDITIONS" + num.ToString(), -1, 1, true))
                                        {
                                            base.PadSetFieldText(-1, -1, -1, -1, this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("RUYUAN_THING", dataRow2["ADMISSION_CONDITIONS"].ToString()));
                                        }
                                    }
                                    num++;
                                }
                            }
                        }
                    }
                    UCFirstPagePrintPad.strTemp = "";
                    dataTable = this.m_MRFirstPageDAL.getDiagnosisByType(this.m_strPatientID, this.m_nVisitID, "8");
                    if (dataTable.IsInitialized)
                    {
                        if (dataTable.Rows.Count > 0)
                        {
                            num = 25;
                            foreach (DataRow dataRow2 in dataTable.Rows)
                            {
                                if (num <= 25)
                                {
                                    if (dataRow2["diagnosis_desc"] != DBNull.Value)
                                    {
                                        UCFirstPagePrintPad.strTemp = dataRow2["diagnosis_desc"].ToString();
                                        if (dataRow2["DIAGNOSIS_DESC_PART"] != DBNull.Value)
                                        {
                                            UCFirstPagePrintPad.strTemp = UCFirstPagePrintPad.strTemp + "(" + dataRow2["DIAGNOSIS_DESC_PART"].ToString() + ")";
                                        }
                                    }
                                    if (base.PadFindField("diagnosis_desc25", -1, 1, true))
                                    {
                                        base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp);
                                    }
                                    if (dataRow2["diagnosis_code"] != DBNull.Value)
                                    {
                                        if (base.PadFindField("diagnosis_code25", -1, 1, true))
                                        {
                                            base.PadSetFieldText(-1, -1, -1, -1, dataRow2["diagnosis_code"].ToString());
                                        }
                                    }
                                    num++;
                                }
                            }
                        }
                    }
                    UCFirstPagePrintPad.strTemp = "";
                    dataTable = this.m_MRFirstPageDAL.getDiagnosisByType(this.m_strPatientID, this.m_nVisitID, "7");
                    if (dataTable.IsInitialized)
                    {
                        if (dataTable.Rows.Count > 0)
                        {
                            num = 24;
                            foreach (DataRow dataRow2 in dataTable.Rows)
                            {
                                if (num <= 24)
                                {
                                    if (dataRow2["diagnosis_desc"] != DBNull.Value)
                                    {
                                        UCFirstPagePrintPad.strTemp += dataRow2["diagnosis_desc"].ToString();
                                        if (dataRow2["DIAGNOSIS_DESC_PART"] != DBNull.Value)
                                        {
                                            UCFirstPagePrintPad.strTemp = UCFirstPagePrintPad.strTemp + "(" + dataRow2["DIAGNOSIS_DESC_PART"].ToString() + ")";
                                        }
                                    }
                                    if (base.PadFindField("diagnosis_desc24", -1, 1, true))
                                    {
                                        base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp);
                                    }
                                    if (dataRow2["diagnosis_code"] != DBNull.Value)
                                    {
                                        if (base.PadFindField("diagnosis_code24", -1, 1, true))
                                        {
                                            base.PadSetFieldText(-1, -1, -1, -1, dataRow2["diagnosis_code"].ToString());
                                        }
                                    }
                                    num++;
                                }
                            }
                        }
                    }
                    UCFirstPagePrintPad.strTemp = "";
                    dataTable = this.m_MRFirstPageDAL.getDiagnosisByType(this.m_strPatientID, this.m_nVisitID, "5");
                    if (dataTable.IsInitialized)
                    {
                        if (dataTable.Rows.Count > 0)
                        {
                            num = 3 + num2;
                            DataTable diagnosisByType = this.m_MRFirstPageDAL.getDiagnosisByType(this.m_strPatientID, this.m_nVisitID, "3','4");
                            foreach (DataRow dataRow2 in dataTable.Rows)
                            {
                                if (num <= 23)
                                {
                                    if (diagnosisByType.IsInitialized && diagnosisByType.Rows.Count > 0)
                                    {
                                        DataRow[] array = diagnosisByType.Select("DIAGNOSIS_CODE='" + dataRow2["DIAGNOSIS_CODE"].ToString() + "'");
                                        if (array.Length <= 0)
                                        {
                                            if (dataRow2["diagnosis_desc"] != DBNull.Value)
                                            {
                                                UCFirstPagePrintPad.strTemp += dataRow2["diagnosis_desc"].ToString();
                                                if (dataRow2["DIAGNOSIS_DESC_PART"] != DBNull.Value)
                                                {
                                                    UCFirstPagePrintPad.strTemp = UCFirstPagePrintPad.strTemp + "(" + dataRow2["DIAGNOSIS_DESC_PART"].ToString() + ")";
                                                }
                                            }
                                            if (base.PadFindField("diagnosis_desc" + num.ToString(), -1, 1, true))
                                            {
                                                base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp);
                                            }
                                            if (dataRow2["diagnosis_code"] != DBNull.Value)
                                            {
                                                if (base.PadFindField("diagnosis_code" + num.ToString(), -1, 1, true))
                                                {
                                                    base.PadSetFieldText(-1, -1, -1, -1, dataRow2["diagnosis_code"].ToString());
                                                }
                                            }
                                            if (dataRow2["ADMISSION_CONDITIONS"] != DBNull.Value)
                                            {
                                                if (base.PadFindField("ADMISSION_CONDITIONS" + num.ToString(), -1, 1, true))
                                                {
                                                    base.PadSetFieldText(-1, -1, -1, -1, this.m_MRFirstPageDAL.getEMRFirstPageItemTextByValue("RUYUAN_THING", dataRow2["ADMISSION_CONDITIONS"].ToString()));
                                                }
                                            }
                                            num++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (this.m_MRFirstPageDAL.m_dsOperation.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsOperation.Tables.Count == 1)
                {
                    DataTable dataTable = this.m_MRFirstPageDAL.m_dsOperation.Tables[0];
                    int num = 1;
                    foreach (DataRow dataRow2 in dataTable.Rows)
                    {
                        if (dataRow2["operation_desc"] != DBNull.Value)
                        {
                            if (base.PadFindField("operation_desc" + num.ToString(), -1, 1, true))
                            {
                                UCFirstPagePrintPad.strTemp = dataRow2["operation_desc"].ToString();
                                if (dataRow2["OPERATION_DESC_PART"] != DBNull.Value)
                                {
                                    UCFirstPagePrintPad.strTemp = UCFirstPagePrintPad.strTemp + "(" + dataRow2["OPERATION_DESC_PART"].ToString() + ")";
                                }
                                base.PadSetFieldText(-1, -1, -1, -1, UCFirstPagePrintPad.strTemp);
                            }
                            if (dataRow2["operation_code"] != DBNull.Value)
                            {
                                if (base.PadFindField("operation_code" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, dataRow2["operation_code"].ToString());
                                }
                            }
                            if (dataRow2["operating_date"] != DBNull.Value)
                            {
                                if (base.PadFindField("operating_date" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow2["operating_date"].ToString()).ToString("yyyy/MM/dd"));
                                }
                            }
                            if (dataRow2["OPERATING_GRADE"] != DBNull.Value)
                            {
                                if (base.PadFindField("OPERATING_GRADE" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, dataRow2["OPERATING_GRADE"].ToString());
                                }
                            }
                            if (dataRow2["operator"] != DBNull.Value)
                            {
                                if (base.PadFindField("operator" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, dataRow2["operator"].ToString());
                                }
                            }
                            if (dataRow2["first_assistant"] != DBNull.Value)
                            {
                                if (base.PadFindField("first_assistant" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, dataRow2["first_assistant"].ToString());
                                }
                            }
                            if (dataRow2["second_assistant"] != DBNull.Value)
                            {
                                if (base.PadFindField("second_assistant" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, dataRow2["second_assistant"].ToString());
                                }
                            }
                            if (dataRow2["anaesthesia_method"] != DBNull.Value)
                            {
                                if (base.PadFindField("anaesthesia_method" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, dataRow2["anaesthesia_method"].ToString());
                                }
                            }
                            if (dataRow2["anesthesia_doctor"] != DBNull.Value)
                            {
                                if (base.PadFindField("anesthesia_doctor" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, dataRow2["anesthesia_doctor"].ToString());
                                }
                            }
                            if (dataRow2["wound_grade"] != DBNull.Value)
                            {
                                if (base.PadFindField("wound_grade" + num.ToString(), -1, 1, true))
                                {
                                    if (dataRow2["wound_grade"].ToString() == "0")
                                    {
                                        base.PadSetFieldText(-1, -1, -1, -1, dataRow2["wound_grade"].ToString());
                                    }
                                    else
                                    {
                                        base.PadSetFieldText(-1, -1, -1, -1, dataRow2["wound_grade"].ToString() + "/" + dataRow2["heal"].ToString());
                                    }
                                }
                            }
                        }
                        num++;
                    }
                    if (num == 1)
                    {
                        if (base.PadFindField("operation_code1", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, "－");
                            base.PadLineAlignCenter();
                        }
                        if (base.PadFindField("operation_desc1", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, "－");
                            base.PadLineAlignCenter();
                        }
                        if (base.PadFindField("operating_date1", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, "－");
                            base.PadLineAlignCenter();
                        }
                        if (base.PadFindField("operator1", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, "－");
                            base.PadLineAlignCenter();
                        }
                        if (base.PadFindField("OPERATING_GRADE1", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, "－");
                            base.PadLineAlignCenter();
                        }
                        if (base.PadFindField("first_assistant1", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, "－");
                            base.PadLineAlignCenter();
                        }
                        if (base.PadFindField("second_assistant1", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, "－");
                            base.PadLineAlignCenter();
                        }
                        if (base.PadFindField("anaesthesia_method1", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, "－");
                            base.PadLineAlignCenter();
                        }
                        if (base.PadFindField("anesthesia_doctor1", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, "－");
                            base.PadLineAlignCenter();
                        }
                        if (base.PadFindField("wound_grade1", -1, 1, true))
                        {
                            base.PadSetFieldText(-1, -1, -1, -1, "－");
                            base.PadLineAlignCenter();
                        }
                    }
                }
            }
            if (this.m_MRFirstPageDAL.m_dsGraveWard.IsInitialized)
            {
                if (this.m_MRFirstPageDAL.m_dsGraveWard.Tables.Count == 1)
                {
                    DataTable dataTable = this.m_MRFirstPageDAL.m_dsGraveWard.Tables[0];
                    int num = 1;
                    foreach (DataRow dataRow2 in dataTable.Rows)
                    {
                        if (dataRow2["WARD_NAME"] != DBNull.Value)
                        {
                            if (base.PadFindField("WARD_NAME" + num.ToString(), -1, 1, true))
                            {
                                base.PadSetFieldText(-1, -1, -1, -1, dataRow2["WARD_NAME"].ToString());
                            }
                            if (dataRow2["ENTER_TIME"] != DBNull.Value)
                            {
                                if (base.PadFindField("ENTER_TIME" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow2["ENTER_TIME"].ToString()).ToString("yyyy年MM月dd日hh时mm分"));
                                }
                            }
                            if (dataRow2["EXIT_TIME"] != DBNull.Value)
                            {
                                if (base.PadFindField("EXIT_TIME" + num.ToString(), -1, 1, true))
                                {
                                    base.PadSetFieldText(-1, -1, -1, -1, Convert.ToDateTime(dataRow2["EXIT_TIME"].ToString()).ToString("yyyy年MM月dd日hh时mm分"));
                                }
                            }
                            num++;
                        }
                    }
                }
            }
        }
    }
}
