using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using JHEMR.EmrSysDAL;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysAdaper;
using EmrSysWebservices;
using System.Windows.Forms;
using System.IO;

namespace JHEMR.EMREdit
{
    public class EMREditMrPadByHospital
    {


        /// <summary>
        ///函数名称: getPatDiagnosisType
        ///    功能: 获取诊断类别记录
        ///    创建: 陈联忠  2007年1月22日
        ///最后修改:     
        /// </summary>
        /// <param name="strTypeCode"></param>
        /// <returns></returns>
        public static DataSet getPatDiagnosisType(string strTypeClass)
        {
            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("SELECT SERIAL_NO,PAT_DIAGNOSIS_TYPE_CODE,PAT_DIAGNOSIS_TYPE_NAME,PAT_DIAGNOSIS_TYPE_CLASS");
            strSQL.Append(" FROM EMR_PAT_DIAGNOSIS_TYPE ");
            strSQL.Append(" WHERE ( PAT_DIAGNOSIS_TYPE_CLASS ='" + strTypeClass + "') ");
            strSQL.Append(" order by SERIAL_NO");
            return DALUse.Query(strSQL.ToString());
        }

        /// <summary>
        ///函数名称: getPatDiagnosis
        ///    功能: 获取指定诊断记录
        ///    创建: 陈联忠  2007年1月22日
        ///最后修改:     
        /// </summary>
        /// <param name="strDiagClass"></param>
        /// <param name="strDiagnosisTypeName"></param>
        /// <returns></returns>
        public static DataSet getPatDiagnosis(string strDiagClass, string strDiagnosisTypeName)
        {
            string strDiagnosisTypeNameList = strDiagnosisTypeName;
            if (strDiagnosisTypeName.Length > 0)
                strDiagnosisTypeNameList = "'" + strDiagnosisTypeName + "'";

            /*
            if (strDiagnosisTypeName != null)
            {
                for (int i = 0; i < strDiagnosisTypeName.Length; i++)
                {
                    if (strDiagnosisTypeNameList.Length > 0) strDiagnosisTypeNameList += ",";
                    strDiagnosisTypeNameList += "'" + strDiagnosisTypeName[i] + "'";
                }
            }
            */

            StringBuilder strSQL = new StringBuilder();
            strSQL.Append("SELECT  DIAGNOSIS_TYPE_NAME as 诊断类型,DIAGNOSIS_NO as 序号,DIAGNOSIS_SUB_NO as 子号,");
            strSQL.Append(" DIAGNOSIS_DESC as 诊断名称 ,CONFIRMED_INDICATOR,DIAGNOSIS_DATE as 诊断日期,DIAGNOSIS_CODE as 诊断编码,DIAGNOSTICIAN_ID as 医师,");
            strSQL.Append(" HOUSEMAN as 实习医师,MODIFIER_ID as 上级医师,LAST_MODIFY_DATE as 上级审签日期,");
            strSQL.Append(" SUPER_ID as 主任医师, SUPER_SIGN_DATE as 主任审签日期,DIAGNOSIS_CLASS,FLAG, PATIENT_ID,VISIT_ID,DIAGNOSIS_TYPE,ID,PARENTID ");
            strSQL.Append(" FROM PAT_DIAGNOSIS ");
            strSQL.Append(" WHERE ( PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "') ");
            strSQL.Append("   AND  ( VISIT_ID =" + EmrSysPubVar.getCurPatientVisitID().ToString() + ") ");
            strSQL.Append("   AND  ( DIAGNOSIS_TYPE ='" + strDiagClass + "') ");
            if (strDiagnosisTypeNameList.Length > 0)
                strSQL.Append("   AND  ( diagnosis_type_name in (" + strDiagnosisTypeNameList + ")) ");
            return DALUse.Query(strSQL.ToString());
        }

        //当是借阅工作站进入时检验是否显示姓名等病人信息
        public static bool DisplayInfo(string strPATIENT_ID, string strVISIT_ID, string strBORROW_DOCTOR_ID, string strBORROW_DEPT)
        {
            DateTime dtNow = EmrSysCom.EmrSysPubFunction.getServerNow();
            string strSQL = "select patient_id from emr_mr_borrow where patient_id='" + strPATIENT_ID + "' and visit_id=" + strVISIT_ID + " and BORROW_DOCTOR_ID='" + strBORROW_DOCTOR_ID + "' ";
            strSQL += " and BORROW_DEPT='" + strBORROW_DEPT + "' and APPLY_DATE<to_date('" + dtNow.ToString() + "','YYYY-MM-DD HH24:MI:SS') and AUTO_APPLY=0";
            DataSet dsBorrow = new DataSet();
            dsBorrow = DALUse.Query(strSQL);
            if (dsBorrow.Tables.Count > 0)
            {
                if (dsBorrow.Tables[0].Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
       


        #region 替换病历中现在已经存在的内容

        /// <summary>
        /// 
        /// 最后修改：单鹏飞
        /// 添加借阅站权限控制
        /// </summary>
        /// <param name="objPad"></param>
        /// <param name="bIsTemplet"></param>
        public static void updatePadMicroField(JHEMR.EmrSysUserCtl.UCEMRPad30 objPad, bool bIsTemplet)
        {
            
            
            //控制借阅站宏可替换
            bool blMrBorrow = false;
            if (EmrSysPubVar.getStationName() == "MRBORROWWS")
                blMrBorrow = true;
            bool blFlag = DisplayInfo(EmrSysPubVar.getCurPatientID(), EmrSysPubVar.getCurPatientVisitID().ToString(), EmrSysPubVar.getDbUser(), EmrSysPubVar.getDeptCode());
            if (blMrBorrow)
            {
                if (!(objPad is EMREdit.UCEMREditMrPad))
                {
                    if (blFlag)
                        return;
                }
            }

            //1.病人基本信息内容
            string ls_INP_NO = "", ls_BIRTH_PLACE = "", ls_NATION = "", ls_BIRTH_PLACE_NAME = "", ls_phone_number_home = "", ls_phone_number_business = "", ls_next_of_kin_phone="";
            string ls_JIGUAN = ""; string ls_XIAN_PLACE = "";
            DateTime ldt_DATE_OF_BIRTH = DateTime.Today;
            string ls_age = "";

            Object objReturn = null;

            string strSQL;
            strSQL = "SELECT INP_NO,BIRTH_PLACE,NATION,DATE_OF_BIRTH,phone_number_home,PHONE_NUMBER_BUSINESS,NEXT_OF_KIN_PHONE,JIGUAN,XIAN_PLACE";  //李坤楠 2014-2-17 籍贯,现住址
            strSQL += " from pat_master_index ";
            strSQL += " WHERE (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "')  ";

            DataSet pDataSetPatMasterIndex = new DataSet();
            pDataSetPatMasterIndex = DALUse.Query(strSQL);
            if (pDataSetPatMasterIndex.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = pDataSetPatMasterIndex.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    DataRow drCurrent;
                    drCurrent = objTable.Rows[0];
                    #region 李坤楠
                    if (drCurrent["JIGUAN"] != DBNull.Value) 
                        ls_JIGUAN = drCurrent["JIGUAN"].ToString();
                    if (drCurrent["XIAN_PLACE"] != DBNull.Value)
                        ls_XIAN_PLACE = drCurrent["XIAN_PLACE"].ToString();
                    #endregion
                    if (drCurrent["INP_NO"]!=DBNull.Value)
                        ls_INP_NO = drCurrent["INP_NO"].ToString();
                    if (drCurrent["BIRTH_PLACE"] != DBNull.Value)
                        ls_BIRTH_PLACE = drCurrent["BIRTH_PLACE"].ToString();
                    if (drCurrent["NATION"] != DBNull.Value)
                        ls_NATION = drCurrent["NATION"].ToString();
                    if (drCurrent["DATE_OF_BIRTH"] != DBNull.Value)
                        ldt_DATE_OF_BIRTH = Convert.ToDateTime(drCurrent["DATE_OF_BIRTH"].ToString());
                    if (drCurrent["phone_number_home"] != DBNull.Value)
                        ls_phone_number_home = drCurrent["phone_number_home"].ToString();
                    if (drCurrent["PHONE_NUMBER_BUSINESS"] != DBNull.Value)
                    {
                        ls_phone_number_business = drCurrent["PHONE_NUMBER_BUSINESS"].ToString().Trim();
                    }
                    if (drCurrent["NEXT_OF_KIN_PHONE"] != DBNull.Value)
                    {
                        ls_next_of_kin_phone = drCurrent["NEXT_OF_KIN_PHONE"].ToString().Trim();
                    }
                    if (ls_INP_NO == null) ls_INP_NO = "";                //住院号
                    if (ls_BIRTH_PLACE == null) ls_BIRTH_PLACE = "";      //出生地代码

                    ls_BIRTH_PLACE = ls_BIRTH_PLACE.Trim();
                    ls_BIRTH_PLACE_NAME=ls_BIRTH_PLACE;

                    /* 
                    strSQL = "select dict_name from emr_dict_detail where class_code='AREA' and dict_code='" + ls_BIRTH_PLACE + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_BIRTH_PLACE_NAME = objReturn.ToString();
                    */

                    if (ls_BIRTH_PLACE_NAME == null) ls_BIRTH_PLACE_NAME = "不详";     //出生地
                    if (ls_phone_number_home == null) ls_phone_number_home = "不详";      //联系电话
                    if (ls_NATION == null) ls_NATION = "";                //民族 
                    if (ls_JIGUAN == null) ls_JIGUAN = ""; //籍贯
                    if (ls_XIAN_PLACE == null) ls_XIAN_PLACE = "";//现住址
                }
            }

            ls_age = "";

            //2.住院信息

            string ls_MARITAL_STATUS = "", ls_OCCUPATION = "", ls_OCCUPATION_NAME = "", ls_MAILING_ADDRESS = "", ls_CHARGE_TYPE = "", ls_SERVICE_AGENCY = "", ls_PAT_ADM_CONDITION = "", ls_PAT_ADM_CONDITION_NAME = "", ls_ADMISSION_CAUSE = "";
            string ls_IDENTITY = "", ls_DEPT_DISCHARGE_FROM = "", ls_DEPT_ADMISSION_TO = "", ls_BED_LABEL = "", ls_DISCHARGE_DATE_TIME = "", ls_DEATH_DATE_TIME="";
            DateTime ld_ADMISSION_DATE_TIME = DateTime.Today;
            DateTime ldt_ADM_WARD_DATE_TIME = DateTime.Today;
            DateTime dtDischarge = DateTime.MinValue;
            strSQL = "SELECT MARITAL_STATUS,OCCUPATION,ADMISSION_DATE_TIME,DISCHARGE_DATE_TIME,MAILING_ADDRESS,CHARGE_TYPE,SERVICE_AGENCY,PAT_ADM_CONDITION,ADMISSION_CAUSE,IDENTITY,DEPT_DISCHARGE_FROM,DEPT_ADMISSION_TO,BED_LABEL,WARD_DATE_TIME,DISCHARGE_DATE_TIME,DEATH_DATE_TIME "; //2013-12-4 李坤楠 出院日期  2014-2-17 李坤楠 死亡时间
            strSQL += " from pat_visit ";
            strSQL += " WHERE (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "')  and VISIT_ID=" + EmrSysPubVar.getCurPatientVisitID().ToString();

            DataSet pDataSetPatVisit = new DataSet();
            pDataSetPatVisit = DALUse.Query(strSQL);
            if (pDataSetPatVisit.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = pDataSetPatVisit.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    DataRow drCurrent;
                    drCurrent = objTable.Rows[0];
                    #region  李坤楠  
                    if (drCurrent["DISCHARGE_DATE_TIME"] != DBNull.Value)  
                    {
                        ls_DISCHARGE_DATE_TIME = drCurrent["DISCHARGE_DATE_TIME"].ToString();      
                    }

                    if (drCurrent["DEATH_DATE_TIME"] != DBNull.Value)
                        ls_DEATH_DATE_TIME = drCurrent["DEATH_DATE_TIME"].ToString();

                    #endregion

                    if (drCurrent["MARITAL_STATUS"] != DBNull.Value)
                        ls_MARITAL_STATUS = drCurrent["MARITAL_STATUS"].ToString();
                    if (drCurrent["OCCUPATION"] != DBNull.Value)
                        ls_OCCUPATION = drCurrent["OCCUPATION"].ToString();
                    if (drCurrent["ADMISSION_DATE_TIME"] != DBNull.Value)
                    {
                        ld_ADMISSION_DATE_TIME = Convert.ToDateTime(drCurrent["ADMISSION_DATE_TIME"].ToString());
                        ldt_ADM_WARD_DATE_TIME = ld_ADMISSION_DATE_TIME;
                    }
                   
                    if (drCurrent["DISCHARGE_DATE_TIME"] != DBNull.Value)  //赵凤东 2014-2-27
                    {
                        dtDischarge = Convert.ToDateTime(drCurrent["DISCHARGE_DATE_TIME"].ToString());
                        ls_age = GetAge(dtDischarge, ldt_DATE_OF_BIRTH);
                    }
                    else
                    {
                        DateTime dtNow = Convert.ToDateTime(EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd") + " 00:00:00");
                        ls_age = GetAge(dtNow, ldt_DATE_OF_BIRTH);
                    }

                    if (drCurrent["WARD_DATE_TIME"] != DBNull.Value)
                        ldt_ADM_WARD_DATE_TIME = Convert.ToDateTime(drCurrent["WARD_DATE_TIME"].ToString());
                    
                    if (drCurrent["MAILING_ADDRESS"] != DBNull.Value)
                        ls_MAILING_ADDRESS = drCurrent["MAILING_ADDRESS"].ToString();
                    if (drCurrent["CHARGE_TYPE"] != DBNull.Value)
                        ls_CHARGE_TYPE = drCurrent["CHARGE_TYPE"].ToString();
                    if (drCurrent["SERVICE_AGENCY"] != DBNull.Value)
                        ls_SERVICE_AGENCY = drCurrent["SERVICE_AGENCY"].ToString();
                    if (drCurrent["PAT_ADM_CONDITION"] != DBNull.Value)
                        ls_PAT_ADM_CONDITION = drCurrent["PAT_ADM_CONDITION"].ToString();
                    if (drCurrent["ADMISSION_CAUSE"] != DBNull.Value)
                        ls_ADMISSION_CAUSE = drCurrent["ADMISSION_CAUSE"].ToString();
                    if (drCurrent["IDENTITY"] != DBNull.Value)
                        ls_IDENTITY = drCurrent["IDENTITY"].ToString();
                    if (drCurrent["DEPT_DISCHARGE_FROM"] != DBNull.Value)
                        ls_DEPT_DISCHARGE_FROM = drCurrent["DEPT_DISCHARGE_FROM"].ToString();
                    if (drCurrent["DEPT_ADMISSION_TO"] != DBNull.Value)
                        ls_DEPT_ADMISSION_TO = drCurrent["DEPT_ADMISSION_TO"].ToString();
                    if (drCurrent["BED_LABEL"] != DBNull.Value)
                        ls_BED_LABEL = drCurrent["BED_LABEL"].ToString();
                    
                    //值处理
                    if (ls_DISCHARGE_DATE_TIME == null) ls_DISCHARGE_DATE_TIME = "不详";    //出院时间 李坤楠 2013-12-4
                    if (ls_DEATH_DATE_TIME == null) ls_DEATH_DATE_TIME = "不详"; //李坤楠 2014-2-17 死亡时间 
                    if (ls_MARITAL_STATUS == null) ls_MARITAL_STATUS = "不详";      //婚姻状况
                    if (ls_OCCUPATION == null) ls_OCCUPATION = "不详";              //职业代码
                    
                    strSQL = "select dict_name from emr_dict_detail where class_code='OCCUPATION' and dict_code='" + ls_OCCUPATION + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_OCCUPATION_NAME = objReturn.ToString();
                    else
                        ls_OCCUPATION_NAME = ls_OCCUPATION;

                    if ((ls_OCCUPATION_NAME == null) || ls_OCCUPATION_NAME == "") ls_OCCUPATION_NAME = "不详";      //职业
                    if (ls_MAILING_ADDRESS == null) ls_MAILING_ADDRESS = "不详";    //地址
                    if (ls_CHARGE_TYPE == null) ls_CHARGE_TYPE = "不详";            //费别
                    if (ls_SERVICE_AGENCY == null) ls_SERVICE_AGENCY = "不详";      //工作单位
                    if (ls_ADMISSION_CAUSE == null) ls_ADMISSION_CAUSE = "不详";    //住院目的
                    if (ls_IDENTITY == null) ls_IDENTITY = "不详";   				  //身份
                    //
                    //if (ldt_DATE_OF_BIRTH != null) //年龄
                        //ls_age = EmrSysPubFunction.GetAge(ld_ADMISSION_DATE_TIME, ldt_DATE_OF_BIRTH);


                    if (ls_PAT_ADM_CONDITION == null) ls_PAT_ADM_CONDITION = " "; //入院情况代码
                    strSQL = "select dict_name from emr_dict_detail where class_code='RYBQ' and dict_code='" + ls_PAT_ADM_CONDITION + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_PAT_ADM_CONDITION_NAME = objReturn.ToString();
                    if (ls_PAT_ADM_CONDITION_NAME == null) ls_PAT_ADM_CONDITION_NAME = "";    //入院情况
                }
            }


            //3.在院信息
            bool lb_is_in_hospital = false;   //判断是否有在院记录
            string ls_WARD_CODE = "", ls_DEPT_CODE = "", ls_DIAGNOSIS = "", ls_DEPT_NAME = "",ls_WARD_NAME = "",ls_DEPT_NAME_ALIAS="";
            int ll_BED_NO = 0;

            strSQL = "SELECT WARD_CODE,DEPT_CODE,DIAGNOSIS,BED_NO,ADM_WARD_DATE_TIME ";
            strSQL += " from PATS_IN_HOSPITAL ";
            strSQL += " WHERE (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "')  and VISIT_ID=" + EmrSysPubVar.getCurPatientVisitID().ToString();

            DataSet pDataSetPatInHospital = new DataSet();
            pDataSetPatInHospital = DALUse.Query(strSQL);
            if (pDataSetPatInHospital.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = pDataSetPatInHospital.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    lb_is_in_hospital = true;
                    DataRow drCurrent;
                    drCurrent = objTable.Rows[0];
                    if (drCurrent["WARD_CODE"] != DBNull.Value)
                        ls_WARD_CODE = drCurrent["WARD_CODE"].ToString();
                    if (drCurrent["DEPT_CODE"] != DBNull.Value)
                        ls_DEPT_CODE = drCurrent["DEPT_CODE"].ToString();
                    if (drCurrent["DIAGNOSIS"] != DBNull.Value)
                        ls_DIAGNOSIS = drCurrent["DIAGNOSIS"].ToString();
                    if (drCurrent["BED_NO"] != DBNull.Value)
                        ll_BED_NO = Convert.ToInt32(drCurrent["BED_NO"].ToString());
                    //if (drCurrent["ADM_WARD_DATE_TIME"] != DBNull.Value)
                    //    ldt_ADM_WARD_DATE_TIME = Convert.ToDateTime(drCurrent["ADM_WARD_DATE_TIME"].ToString());

                    if (ls_DIAGNOSIS == null) ls_DIAGNOSIS = " ";    //入院诊断
                    if (ll_BED_NO < 0) ll_BED_NO = 0;           //床号

                    if (ls_DEPT_CODE == null)
                    {
                        //选出出院科室
                        ls_DEPT_CODE = ls_DEPT_DISCHARGE_FROM;    //科室代码
                        lb_is_in_hospital = false;
                        if (ls_DEPT_CODE == null)
                            ls_DEPT_CODE = " ";    //科室代码
                    }

                }
            }

            if (EmrSysPubVar.getCurPatientVisitID() <= 0)
                ls_DEPT_CODE = ls_DEPT_ADMISSION_TO;

            //提取科室名称
            strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_DEPT_CODE + "'";
            objReturn = DALUse.GetSingle(strSQL);//科室名称
            if (objReturn != null)
                ls_DEPT_NAME = objReturn.ToString();
            //长海提取科室别名作为科别
            strSQL = "select DEPT_ALIAS from dept_dict where DEPT_CODE='" + ls_DEPT_CODE + "'";
            objReturn = DALUse.GetSingle(strSQL);//科室别名
            if (objReturn != null)
                ls_DEPT_NAME_ALIAS = objReturn.ToString();
            

            //提取病区名称
            strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_WARD_CODE + "'";
            //长海医院修改,病区直接提取病区的编码,便于书写
            objReturn = DALUse.GetSingle(strSQL);//科室名称
            if (objReturn != null)
                ls_WARD_NAME = objReturn.ToString();

            //4.诊断信息             

            string is_diagnose = null;
            strSQL = "SELECT diagnosis_desc ";
            strSQL += " from pat_diagnosis ";
            strSQL += " WHERE (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "')  and VISIT_ID=" + EmrSysPubVar.getCurPatientVisitID().ToString();
            strSQL += " order by DIAGNOSIS_TYPE,DIAGNOSIS_NO,DIAGNOSIS_SUB_NO  ";

            DataSet pDataSetPatDiagnosis = new DataSet();
            pDataSetPatDiagnosis = DALUse.Query(strSQL);
            if (pDataSetPatDiagnosis.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = pDataSetPatDiagnosis.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    DataRow drCurrent;
                    drCurrent = objTable.Rows[0];
                    if (drCurrent["diagnosis_desc"] != DBNull.Value)
                        is_diagnose = drCurrent["diagnosis_desc"].ToString();
                }
            }


            if (is_diagnose == null) is_diagnose = "暂未确诊";


            //5.附页中的信息  表emr_fuye
            #region  李坤楠 2014-2-17
            string ls_DEADREASON = "";
            strSQL = "SELECT DEADREASON ";
            strSQL += " from emr_fuye ";
            strSQL += " WHERE (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "')  and VISIT_ID=" + EmrSysPubVar.getCurPatientVisitID().ToString();

            DataSet pDataSetEmr_Fuye = new DataSet();
            pDataSetEmr_Fuye = DALUse.Query(strSQL);
            if (pDataSetEmr_Fuye.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = pDataSetEmr_Fuye.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    DataRow drCurrent;
                    drCurrent = objTable.Rows[0];
                    if (drCurrent["DEADREASON"] != DBNull.Value)  
                        ls_DEADREASON = drCurrent["DEADREASON"].ToString();
                }
            }
            if (ls_DEADREASON == null) ls_DEADREASON = "";
            #endregion
            //////////////////////////////////////////////////////////////////////////////////////
            objPad.PadSetMicroField("主要诊断", is_diagnose);


            //if (EmrSysPubVar.getStationName() == "MRBORROWWS")
            if (blMrBorrow)
            {
                //if (DisplayInfo(EmrSysPubVar.getCurPatientID(), EmrSysPubVar.getCurPatientVisitID().ToString(), EmrSysPubVar.getDbUser(), EmrSysPubVar.getDeptCode()))
                if (blFlag)
                {
                    objPad.PadSetMicroField("姓名", EmrSysPubVar.getCurPatientName());
                    objPad.PadSetMicroField("单位", ls_SERVICE_AGENCY);
                    objPad.PadSetMicroField("工作单位", ls_SERVICE_AGENCY);
                    objPad.PadSetMicroField("住址", ls_MAILING_ADDRESS);
                    objPad.PadEditReplaceInternal("[住址]", ls_MAILING_ADDRESS, 1);
                    objPad.PadSetMicroField("电话", ls_phone_number_home);
                    objPad.PadSetMicroField("工作电话",ls_phone_number_business);
                    objPad.PadSetMicroField("联系人电话", ls_next_of_kin_phone);
                }
                else
                {
                    objPad.PadSetMicroField("姓名", "XXXXXX");
                    objPad.PadSetMicroField("单位", "XXXXXX");
                    objPad.PadSetMicroField("工作单位", "XXXXXX");
                    objPad.PadSetMicroField("住址", "XXXXXX");
                    objPad.PadEditReplaceInternal("[住址]", "XXXXXX", 1);
                    objPad.PadSetMicroField("电话", "XXXXXX");
                    objPad.PadSetMicroField("工作电话", "XXXXXX");
                    objPad.PadSetMicroField("联系人电话", "XXXXXX");
                }
            }
            else
            {
                objPad.PadSetMicroField("姓名", EmrSysPubVar.getCurPatientName());
                objPad.PadSetMicroField("单位", ls_SERVICE_AGENCY);
                objPad.PadSetMicroField("工作单位", ls_SERVICE_AGENCY);
                objPad.PadSetMicroField("住址", ls_MAILING_ADDRESS);
                objPad.PadEditReplaceInternal("[住址]", ls_MAILING_ADDRESS, 1);
                objPad.PadSetMicroField("电话", ls_phone_number_home);
                objPad.PadSetMicroField("工作电话", ls_phone_number_business);
                objPad.PadSetMicroField("联系人电话", ls_next_of_kin_phone);

            }
            //objPad.PadSetMicroField("姓名", EmrSysPubVar.getCurPatientName());
            objPad.PadSetMicroField("性别", EmrSysPubVar.getCurPatientSex());
            objPad.PadSetMicroField("年龄", ls_age);
            objPad.PadSetMicroField("住院号", ls_INP_NO);
            objPad.PadSetMicroField("ID号", EmrSysPubVar.getCurPatientID());
            objPad.PadSetMicroField("婚姻状况", ls_MARITAL_STATUS);
            objPad.PadSetMicroField("民族", ls_NATION);
            objPad.PadSetMicroField("职业", ls_OCCUPATION_NAME);
            objPad.PadSetMicroField("职别", ls_OCCUPATION_NAME);
            objPad.PadSetMicroField("出生地", ls_BIRTH_PLACE_NAME);
            objPad.PadSetMicroField("入院日期", ld_ADMISSION_DATE_TIME.ToString("yyyy-MM-dd"));
            objPad.PadSetMicroField("入院日期中", ld_ADMISSION_DATE_TIME.ToString("yyyy年MM月dd日"));
            objPad.PadSetMicroField("入院时间", ld_ADMISSION_DATE_TIME.ToString("yyyy-MM-dd HH:mm"));
            objPad.PadSetMicroField("住院目的", ls_ADMISSION_CAUSE);
            objPad.PadSetMicroField("入院情况", ls_PAT_ADM_CONDITION_NAME);
            //objPad.PadSetMicroField("单位", ls_SERVICE_AGENCY);
            objPad.PadSetMicroField("身份", ls_IDENTITY);
            //objPad.PadSetMicroField("工作单位", ls_SERVICE_AGENCY);
           // objPad.PadSetMicroField("住址", ls_MAILING_ADDRESS);
           // objPad.PadEditReplaceInternal("[住址]", ls_MAILING_ADDRESS, 1);
            //objPad.PadSetMicroField("电话", ls_phone_number_home);
            objPad.PadSetMicroField("出生日期", ldt_DATE_OF_BIRTH.ToString("yyyy年MM月dd日"));  
            objPad.PadSetMicroField("籍贯",ls_JIGUAN);
            objPad.PadSetMicroField("现住址",ls_XIAN_PLACE);  
            objPad.PadSetMicroField("死亡时间",ls_DEATH_DATE_TIME);
            objPad.PadSetMicroField("死亡原因", ls_DEADREASON);

            //在院部分的内容
            if (lb_is_in_hospital)
            {
                if (bIsTemplet)//2010-10-30 判断病历文件是否新建，非新建不更新
                {
                    if (EmrSysPubVar.getCurPatientVisitID() > 0)
                        objPad.PadSetMicroField("床号", EmrSysPubFunction.getBedLabelByWard(ll_BED_NO, EmrSysPubVar.getCurPatientWardCode()));
                    objPad.PadSetMicroField("科室", ls_DEPT_NAME);
                    objPad.PadSetMicroField("科别", ls_DEPT_NAME_ALIAS);
                    objPad.PadSetMicroField("病区", ls_WARD_NAME);
                    objPad.PadSetMicroField("病别", ls_WARD_CODE);
                    objPad.PadSetMicroField("临床诊断", ls_DIAGNOSIS);
                    objPad.PadSetMicroField("入院诊断", ls_DIAGNOSIS);
                    objPad.PadSetMicroField("入科日期", ldt_ADM_WARD_DATE_TIME.ToString("yyyy-MM-dd"));
                    objPad.PadSetMicroField("入科时间", ldt_ADM_WARD_DATE_TIME.ToString("yyyy-MM-dd HH:mm"));
                } 
            }
            else
            {
                if (bIsTemplet)   //出院的床号为空 判断病历文件是否新建，非新建不更新
                {
                    if (EmrSysPubVar.getCurPatientVisitID() > 0 && !string.IsNullOrEmpty(ls_BED_LABEL))
                        objPad.PadSetMicroField("床号", ls_BED_LABEL);
                    else
                        objPad.PadSetMicroField("床号", " ");
                    //提取科室名称
                    strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_DEPT_DISCHARGE_FROM + "'";
                    objReturn = DALUse.GetSingle(strSQL);//科室名称
                    if (objReturn != null)
                        ls_DEPT_NAME = objReturn.ToString();
                    //提取科别
                    strSQL = "select DEPT_ALIAS from dept_dict where DEPT_CODE='" + ls_DEPT_DISCHARGE_FROM + "'";
                    objReturn = DALUse.GetSingle(strSQL);//科室名称
                    if (objReturn != null)
                        ls_DEPT_NAME_ALIAS = objReturn.ToString();
                    objPad.PadSetMicroField("科室", ls_DEPT_NAME);
                    objPad.PadSetMicroField("科别", ls_DEPT_NAME_ALIAS);
                    //objPad.PadSetMicroField("病区", ls_DEPT_NAME);
                }
            }


            //仅针对模板起作用
            if (bIsTemplet)
            {
                objPad.PadSetMicroField("通知时间", EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd HH:mm"));
                //2007.8.23 强制入院记录的记录时间必须在入院时间的24小时内
                if (lb_is_in_hospital)
                {
                    DateTime dtWrite = EmrSysPubFunction.getServerNow();
                    TimeSpan dtSpan = EmrSysPubFunction.getServerNow() - ldt_ADM_WARD_DATE_TIME;
                    if (dtSpan.TotalHours >= 24)
                        dtWrite = ldt_ADM_WARD_DATE_TIME.AddHours(23);

                    objPad.PadSetMicroField("记录日期", dtWrite.ToString("yyyy-MM-dd"));
                    objPad.PadSetMicroField("记录时间", dtWrite.ToString("yyyy-MM-dd HH:mm"));
                }
                else
                {
                    DateTime dtWrite = EmrSysPubFunction.getServerNow();
                    TimeSpan dtSpan = EmrSysPubFunction.getServerNow() - ldt_ADM_WARD_DATE_TIME;
                    if (dtSpan.TotalHours >= 24)
                        dtWrite = ldt_ADM_WARD_DATE_TIME.AddHours(23);

                    objPad.PadSetMicroField("记录日期", dtWrite.ToString("yyyy-MM-dd"));
                    objPad.PadSetMicroField("记录时间", dtWrite.ToString("yyyy-MM-dd HH:mm"));

                }
                objPad.PadSetMicroField("签名", EmrSysPubVar.getOperator());
            }


            //2008-11-10 填充模板住院日，出院日期 单鹏飞
            //DateTime draaaa = EmrSysPubVar.getCurVisitAdmissionDateTime();
            //DateTime dtDischarge = EmrSysPubVar.getCurVisitDischargeDateTime();//0001-1-1 0:00:00
            string patInHospDays = "";
            if (dtDischarge != DateTime.MinValue)
            {
                //计算实际住院日
                patInHospDays = EmrSysPubFunction.GetBetweenDays(ld_ADMISSION_DATE_TIME, dtDischarge).ToString();
            }
            else
            {
                patInHospDays = EmrSysPubFunction.GetBetweenDays(ld_ADMISSION_DATE_TIME, EmrSysPubFunction.getServerNow()).ToString();
            }
            objPad.PadSetMicroField("住院天数", patInHospDays);
            objPad.PadSetMicroField("出院日期", dtDischarge.ToString("yyyy-MM-dd"));
            objPad.PadSetMicroField("出院日期中", dtDischarge.ToString("yyyy年MM月dd日"));
            objPad.PadSetMicroField("出院时间", dtDischarge.ToString("yyyy-MM-dd HH:mm"));


            objPad.PadUpdateMicroField(true);
        }


        // 赵凤东 2014-2-27 年龄算法与首页一致
        public static string GetAge(DateTime dtCurrent, DateTime dtBirth)
        {
            //年龄
            string strReturn = "";
            int nyears = dtCurrent.Year - dtBirth.Year;
            TimeSpan dtAge = dtCurrent - dtBirth;
            //TimeSpan dtAge = Convert.ToDateTime(dtCurrent.ToShortDateString() + " 00:00:00") - Convert.ToDateTime(dtBirth.ToShortDateString() + " 00:00:00");
            int nYears = 0;
            int nMonth = 0;
            int nDay = 0;
            nYears = dtAge.Days / 365;
            nMonth = (dtAge.Days - 365 * nYears) / 30;
            nDay = dtAge.Days - 365 * nYears - 30 * nMonth;
            if (nYears > 1)
            {
                //strReturn = nYears.ToString() + "岁";
                strReturn = nyears.ToString() + "岁";
            }
            else
            {
                if (nYears > 0)
                {
                    strReturn = nYears.ToString() + "岁" + nMonth.ToString() + "月";

                }
                else if (nMonth > 0)
                    strReturn = nMonth.ToString() + " " + nDay.ToString() + "/30" + "月";
                else if (nDay > 0)
                    strReturn = nDay.ToString() + "/30月";
                else
                    strReturn = "1/30月";
            }

            return strReturn;
        }
        /// <summary>
        /// 
        /// 
        /// 检查申请单用
        /// </summary>
        /// <param name="objPad"></param>
        /// <param name="bIsTemplet"></param>
        public static void updatePadMicroField1(JHEMR.EmrSysUserCtl.UCEMRPad30 objPad, bool bIsTemplet)
        {
            ////控制借阅站宏可替换
            //bool blMrBorrow = false;
            //if (EmrSysPubVar.getStationName() == "MRBORROWWS")
            //    blMrBorrow = true;
            //bool blFlag = DisplayInfo(EmrSysPubVar.getCurPatientID(), EmrSysPubVar.getCurPatientVisitID().ToString(), EmrSysPubVar.getDbUser(), EmrSysPubVar.getDeptCode());
            //if (!(objPad is EMREdit.UCEMREditMrPad))
            //{
            //    if (!blMrBorrow)
            //        return;
            //    else if (blFlag)
            //        return;
            //}

            //1.病人基本信息内容
            string ls_INP_NO = "", ls_BIRTH_PLACE = "", ls_NATION = "", ls_BIRTH_PLACE_NAME = "", ls_phone_number_home = "";
            DateTime ldt_DATE_OF_BIRTH = DateTime.Today;
            string ls_age = "";

            Object objReturn = null;

            string strSQL;
            strSQL = "SELECT INP_NO,BIRTH_PLACE,NATION,DATE_OF_BIRTH,phone_number_home ";
            strSQL += " from pat_master_index ";
            strSQL += " WHERE (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "')  ";

            DataSet pDataSetPatMasterIndex = new DataSet();
            pDataSetPatMasterIndex = DALUse.Query(strSQL);
            if (pDataSetPatMasterIndex.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = pDataSetPatMasterIndex.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    DataRow drCurrent;
                    drCurrent = objTable.Rows[0];
                    if (drCurrent["INP_NO"] != DBNull.Value)
                        ls_INP_NO = drCurrent["INP_NO"].ToString();
                    if (drCurrent["BIRTH_PLACE"] != DBNull.Value)
                        ls_BIRTH_PLACE = drCurrent["BIRTH_PLACE"].ToString();
                    if (drCurrent["NATION"] != DBNull.Value)
                        ls_NATION = drCurrent["NATION"].ToString();
                    if (drCurrent["DATE_OF_BIRTH"] != DBNull.Value)
                        ldt_DATE_OF_BIRTH = Convert.ToDateTime(drCurrent["DATE_OF_BIRTH"].ToString());
                    if (drCurrent["phone_number_home"] != DBNull.Value)
                        ls_phone_number_home = drCurrent["phone_number_home"].ToString();


                    if (ls_INP_NO == null) ls_INP_NO = "";                //住院号
                    if (ls_BIRTH_PLACE == null) ls_BIRTH_PLACE = "";      //出生地代码

                    ls_BIRTH_PLACE = ls_BIRTH_PLACE.Trim();
                    ls_BIRTH_PLACE_NAME = ls_BIRTH_PLACE;

                    /* 
                    strSQL = "select dict_name from emr_dict_detail where class_code='AREA' and dict_code='" + ls_BIRTH_PLACE + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_BIRTH_PLACE_NAME = objReturn.ToString();
                    */

                    if (ls_BIRTH_PLACE_NAME == null) ls_BIRTH_PLACE_NAME = "不详";     //出生地
                    if (ls_phone_number_home == null) ls_phone_number_home = "不详";      //联系电话
                    if (ls_NATION == null) ls_NATION = "";                //民族 
                }
            }

            ls_age = "";

            //2.住院信息

            string ls_MARITAL_STATUS = "", ls_OCCUPATION = "", ls_OCCUPATION_NAME = "", ls_MAILING_ADDRESS = "", ls_CHARGE_TYPE = "", ls_SERVICE_AGENCY = "", ls_PAT_ADM_CONDITION = "", ls_PAT_ADM_CONDITION_NAME = "", ls_ADMISSION_CAUSE = "";
            string ls_IDENTITY = "", ls_DEPT_DISCHARGE_FROM = "", ls_DEPT_ADMISSION_TO = "", ls_BED_LABEL = "", ls_DISCHARGE_DATE_TIME = "";  //2013-12-4 李坤楠
            DateTime ld_ADMISSION_DATE_TIME = DateTime.Today;
            DateTime ldt_ADM_WARD_DATE_TIME = DateTime.Today;
            DateTime dtDischarge = DateTime.MinValue;
            strSQL = "SELECT MARITAL_STATUS,OCCUPATION,ADMISSION_DATE_TIME,DISCHARGE_DATE_TIME,MAILING_ADDRESS,CHARGE_TYPE,SERVICE_AGENCY,PAT_ADM_CONDITION,ADMISSION_CAUSE,IDENTITY,DEPT_DISCHARGE_FROM,DEPT_ADMISSION_TO,BED_LABEL,WARD_DATE_TIME，DISCHARGE_DATE_TIME";
            strSQL += " from pat_visit ";
            strSQL += " WHERE (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "')  and VISIT_ID=" + EmrSysPubVar.getCurPatientVisitID().ToString();

            DataSet pDataSetPatVisit = new DataSet();
            pDataSetPatVisit = DALUse.Query(strSQL);
            if (pDataSetPatVisit.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = pDataSetPatVisit.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    DataRow drCurrent;
                    drCurrent = objTable.Rows[0];
                    if(drCurrent["DISCHARGE_DATE_TIME"] != DBNull.Value)
                        ls_DISCHARGE_DATE_TIME =  drCurrent["DISCHARGE_DATE_TIME"].ToString(); //李坤楠 2013-12-4
                    if (drCurrent["MARITAL_STATUS"] != DBNull.Value)
                        ls_MARITAL_STATUS = drCurrent["MARITAL_STATUS"].ToString();
                    if (drCurrent["OCCUPATION"] != DBNull.Value)
                        ls_OCCUPATION = drCurrent["OCCUPATION"].ToString();
                    if (drCurrent["ADMISSION_DATE_TIME"] != DBNull.Value)
                    {
                        ld_ADMISSION_DATE_TIME = Convert.ToDateTime(drCurrent["ADMISSION_DATE_TIME"].ToString());
                        ldt_ADM_WARD_DATE_TIME = ld_ADMISSION_DATE_TIME;
                    }

                    if (drCurrent["DISCHARGE_DATE_TIME"] != DBNull.Value) // 赵凤东 2014-2-27
                    {
                        dtDischarge = Convert.ToDateTime(drCurrent["DISCHARGE_DATE_TIME"].ToString());
                        ls_age = GetAge(dtDischarge, ldt_DATE_OF_BIRTH);

                    }
                    else
                    {
                        DateTime dtNow = Convert.ToDateTime(EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd") + " 00:00:00");
                        ls_age = GetAge(dtNow, ldt_DATE_OF_BIRTH);
                    }
                    if (drCurrent["WARD_DATE_TIME"] != DBNull.Value)
                        ldt_ADM_WARD_DATE_TIME = Convert.ToDateTime(drCurrent["WARD_DATE_TIME"].ToString());

                    if (drCurrent["MAILING_ADDRESS"] != DBNull.Value)
                        ls_MAILING_ADDRESS = drCurrent["MAILING_ADDRESS"].ToString();
                    if (drCurrent["CHARGE_TYPE"] != DBNull.Value)
                        ls_CHARGE_TYPE = drCurrent["CHARGE_TYPE"].ToString();
                    if (drCurrent["SERVICE_AGENCY"] != DBNull.Value)
                        ls_SERVICE_AGENCY = drCurrent["SERVICE_AGENCY"].ToString();
                    if (drCurrent["PAT_ADM_CONDITION"] != DBNull.Value)
                        ls_PAT_ADM_CONDITION = drCurrent["PAT_ADM_CONDITION"].ToString();
                    if (drCurrent["ADMISSION_CAUSE"] != DBNull.Value)
                        ls_ADMISSION_CAUSE = drCurrent["ADMISSION_CAUSE"].ToString();
                    if (drCurrent["IDENTITY"] != DBNull.Value)
                        ls_IDENTITY = drCurrent["IDENTITY"].ToString();
                    if (drCurrent["DEPT_DISCHARGE_FROM"] != DBNull.Value)
                        ls_DEPT_DISCHARGE_FROM = drCurrent["DEPT_DISCHARGE_FROM"].ToString();
                    if (drCurrent["DEPT_ADMISSION_TO"] != DBNull.Value)
                        ls_DEPT_ADMISSION_TO = drCurrent["DEPT_ADMISSION_TO"].ToString();
                    if (drCurrent["BED_LABEL"] != DBNull.Value)
                        ls_BED_LABEL = drCurrent["BED_LABEL"].ToString();

                    //值处理
                    if (ls_DISCHARGE_DATE_TIME == null) ls_DISCHARGE_DATE_TIME = "不详";    //李坤楠   2013-12-4 
                    if (ls_MARITAL_STATUS == null) ls_MARITAL_STATUS = "不详";      //婚姻状况
                    if (ls_OCCUPATION == null) ls_OCCUPATION = "不详";              //职业代码
                    
                    strSQL = "select dict_name from emr_dict_detail where class_code='OCCUPATION' and dict_code='" + ls_OCCUPATION + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_OCCUPATION_NAME = objReturn.ToString();
                    else
                        ls_OCCUPATION_NAME = ls_OCCUPATION;

                    if ((ls_OCCUPATION_NAME == null) || ls_OCCUPATION_NAME == "") ls_OCCUPATION_NAME = "不详";      //职业
                    if (ls_MAILING_ADDRESS == null) ls_MAILING_ADDRESS = "不详";    //地址
                    if (ls_CHARGE_TYPE == null) ls_CHARGE_TYPE = "不详";            //费别
                    if (ls_SERVICE_AGENCY == null) ls_SERVICE_AGENCY = "不详";      //工作单位
                    if (ls_ADMISSION_CAUSE == null) ls_ADMISSION_CAUSE = "不详";    //住院目的
                    if (ls_IDENTITY == null) ls_IDENTITY = "不详";   				  //身份
                    if (ls_PAT_ADM_CONDITION == null) ls_PAT_ADM_CONDITION = " "; //入院情况代码
                    strSQL = "select dict_name from emr_dict_detail where class_code='RYBQ' and dict_code='" + ls_PAT_ADM_CONDITION + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_PAT_ADM_CONDITION_NAME = objReturn.ToString();
                    if (ls_PAT_ADM_CONDITION_NAME == null) ls_PAT_ADM_CONDITION_NAME = "";    //入院情况
                }
            }


            //3.在院信息
            bool lb_is_in_hospital = false;   //判断是否有在院记录
            string ls_WARD_CODE = "", ls_DEPT_CODE = "", ls_DIAGNOSIS = "", ls_DEPT_NAME = "", ls_WARD_NAME = "", ls_DEPT_NAME_ALIAS = "";
            int ll_BED_NO = 0;

            strSQL = "SELECT WARD_CODE,DEPT_CODE,DIAGNOSIS,BED_NO,ADM_WARD_DATE_TIME ";
            strSQL += " from PATS_IN_HOSPITAL ";
            strSQL += " WHERE (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "')  and VISIT_ID=" + EmrSysPubVar.getCurPatientVisitID().ToString();

            DataSet pDataSetPatInHospital = new DataSet();
            pDataSetPatInHospital = DALUse.Query(strSQL);
            if (pDataSetPatInHospital.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = pDataSetPatInHospital.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    lb_is_in_hospital = true;
                    DataRow drCurrent;
                    drCurrent = objTable.Rows[0];
                    if (drCurrent["WARD_CODE"] != DBNull.Value)
                        ls_WARD_CODE = drCurrent["WARD_CODE"].ToString();
                    if (drCurrent["DEPT_CODE"] != DBNull.Value)
                        ls_DEPT_CODE = drCurrent["DEPT_CODE"].ToString();
                    if (drCurrent["DIAGNOSIS"] != DBNull.Value)
                        ls_DIAGNOSIS = drCurrent["DIAGNOSIS"].ToString();
                    if (drCurrent["BED_NO"] != DBNull.Value)
                        ll_BED_NO = Convert.ToInt32(drCurrent["BED_NO"].ToString());
                    //if (drCurrent["ADM_WARD_DATE_TIME"] != DBNull.Value)
                    //    ldt_ADM_WARD_DATE_TIME = Convert.ToDateTime(drCurrent["ADM_WARD_DATE_TIME"].ToString());

                    if (ls_DIAGNOSIS == null) ls_DIAGNOSIS = " ";    //入院诊断
                    if (ll_BED_NO < 0) ll_BED_NO = 0;           //床号

                    if (ls_DEPT_CODE == null)
                    {
                        //选出出院科室
                        ls_DEPT_CODE = ls_DEPT_DISCHARGE_FROM;    //科室代码
                        lb_is_in_hospital = false;
                        if (ls_DEPT_CODE == null)
                            ls_DEPT_CODE = " ";    //科室代码
                    }

                }
            }

            if (EmrSysPubVar.getCurPatientVisitID() <= 0)
                ls_DEPT_CODE = ls_DEPT_ADMISSION_TO;

            //提取科室名称
            strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_DEPT_CODE + "'";
            objReturn = DALUse.GetSingle(strSQL);//科室名称
            if (objReturn != null)
                ls_DEPT_NAME = objReturn.ToString();
            //长海提取科室别名作为科别
            strSQL = "select DEPT_ALIAS from dept_dict where DEPT_CODE='" + ls_DEPT_CODE + "'";
            objReturn = DALUse.GetSingle(strSQL);//科室别名
            if (objReturn != null)
                ls_DEPT_NAME_ALIAS = objReturn.ToString();


            //提取病区名称
            strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_WARD_CODE + "'";
            //长海医院修改,病区直接提取病区的编码,便于书写
            objReturn = DALUse.GetSingle(strSQL);//科室名称
            if (objReturn != null)
                ls_WARD_NAME = objReturn.ToString();

            //4.诊断信息             

            string is_diagnose = null;
            strSQL = "SELECT diagnosis_desc ";
            strSQL += " from pat_diagnosis ";
            strSQL += " WHERE (PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "')  and VISIT_ID=" + EmrSysPubVar.getCurPatientVisitID().ToString();
            strSQL += " order by DIAGNOSIS_TYPE,DIAGNOSIS_NO,DIAGNOSIS_SUB_NO  ";

            DataSet pDataSetPatDiagnosis = new DataSet();
            pDataSetPatDiagnosis = DALUse.Query(strSQL);
            if (pDataSetPatDiagnosis.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = pDataSetPatDiagnosis.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    DataRow drCurrent;
                    drCurrent = objTable.Rows[0];
                    if (drCurrent["diagnosis_desc"] != DBNull.Value)
                        is_diagnose = drCurrent["diagnosis_desc"].ToString();
                }
            }


            if (is_diagnose == null) is_diagnose = "暂未确诊";

            //////////////////////////////////////////////////////////////////////////////////////
            objPad.PadSetMicroField("主要诊断", is_diagnose);


          
                objPad.PadSetMicroField("姓名", EmrSysPubVar.getCurPatientName());
                objPad.PadSetMicroField("单位", ls_SERVICE_AGENCY);
                objPad.PadSetMicroField("工作单位", ls_SERVICE_AGENCY);
                objPad.PadSetMicroField("住址", ls_MAILING_ADDRESS);
                objPad.PadEditReplaceInternal("[住址]", ls_MAILING_ADDRESS, 1);
                objPad.PadSetMicroField("电话", ls_phone_number_home);

            objPad.PadSetMicroField("性别", EmrSysPubVar.getCurPatientSex());
            objPad.PadSetMicroField("年龄", ls_age);
            objPad.PadSetMicroField("住院号", ls_INP_NO);
            objPad.PadSetMicroField("ID号", EmrSysPubVar.getCurPatientID());
            objPad.PadSetMicroField("婚姻状况", ls_MARITAL_STATUS);
            objPad.PadSetMicroField("民族", ls_NATION);
            objPad.PadSetMicroField("职业", ls_OCCUPATION_NAME);
            objPad.PadSetMicroField("职别", ls_OCCUPATION_NAME);
            objPad.PadSetMicroField("出生地", ls_BIRTH_PLACE_NAME);
            objPad.PadSetMicroField("入院日期", ld_ADMISSION_DATE_TIME.ToString("yyyy-MM-dd"));
            objPad.PadSetMicroField("入院日期中", ld_ADMISSION_DATE_TIME.ToString("yyyy年MM月dd日"));
            objPad.PadSetMicroField("入院时间", ld_ADMISSION_DATE_TIME.ToString("yyyy-MM-dd HH:mm"));
            objPad.PadSetMicroField("住院目的", ls_ADMISSION_CAUSE);
            objPad.PadSetMicroField("入院情况", ls_PAT_ADM_CONDITION_NAME);
            //objPad.PadSetMicroField("单位", ls_SERVICE_AGENCY);
            objPad.PadSetMicroField("身份", ls_IDENTITY);
            //objPad.PadSetMicroField("工作单位", ls_SERVICE_AGENCY);
            // objPad.PadSetMicroField("住址", ls_MAILING_ADDRESS);
            // objPad.PadEditReplaceInternal("[住址]", ls_MAILING_ADDRESS, 1);
            //objPad.PadSetMicroField("电话", ls_phone_number_home);
            objPad.PadSetMicroField("出生日期", ldt_DATE_OF_BIRTH.ToString("yyyy年MM月dd日"));


            //在院部分的内容
            if (lb_is_in_hospital)
            {
                if (EmrSysPubVar.getCurPatientVisitID() > 0)
                    objPad.PadSetMicroField("床号", EmrSysPubFunction.getBedLabelByWard(ll_BED_NO, EmrSysPubVar.getCurPatientWardCode()));
                objPad.PadSetMicroField("科室", ls_DEPT_NAME);
                objPad.PadSetMicroField("科别", ls_DEPT_NAME_ALIAS);
                objPad.PadSetMicroField("病区", ls_WARD_NAME);
                objPad.PadSetMicroField("病别", ls_WARD_CODE);
                objPad.PadSetMicroField("临床诊断", ls_DIAGNOSIS);
                objPad.PadSetMicroField("入院诊断", ls_DIAGNOSIS);
                objPad.PadSetMicroField("入科日期", ldt_ADM_WARD_DATE_TIME.ToString("yyyy-MM-dd"));
                objPad.PadSetMicroField("入科时间", ldt_ADM_WARD_DATE_TIME.ToString("yyyy-MM-dd HH:mm"));
            }
            else
            {
                if (bIsTemplet)   //出院的床号为空
                {
                    if (EmrSysPubVar.getCurPatientVisitID() > 0 && !string.IsNullOrEmpty(ls_BED_LABEL))
                        objPad.PadSetMicroField("床号", ls_BED_LABEL);
                    else
                        objPad.PadSetMicroField("床号", " ");
                    //提取科室名称
                    strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_DEPT_DISCHARGE_FROM + "'";
                    objReturn = DALUse.GetSingle(strSQL);//科室名称
                    if (objReturn != null)
                        ls_DEPT_NAME = objReturn.ToString();
                    //提取科别
                    strSQL = "select DEPT_ALIAS from dept_dict where DEPT_CODE='" + ls_DEPT_DISCHARGE_FROM + "'";
                    objReturn = DALUse.GetSingle(strSQL);//科室名称
                    if (objReturn != null)
                        ls_DEPT_NAME_ALIAS = objReturn.ToString();
                    objPad.PadSetMicroField("科室", ls_DEPT_NAME);
                    objPad.PadSetMicroField("科别", ls_DEPT_NAME_ALIAS);
                    //objPad.PadSetMicroField("病区", ls_DEPT_NAME);
                }
            }


            //仅针对模板起作用
            if (bIsTemplet)
            {
                objPad.PadSetMicroField("通知时间", EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd HH:mm"));
                //2007.8.23 强制入院记录的记录时间必须在入院时间的24小时内
                if (lb_is_in_hospital)
                {
                    DateTime dtWrite = EmrSysPubFunction.getServerNow();
                    TimeSpan dtSpan = EmrSysPubFunction.getServerNow() - ldt_ADM_WARD_DATE_TIME;
                    if (dtSpan.TotalHours >= 24)
                        dtWrite = ldt_ADM_WARD_DATE_TIME.AddHours(23);

                    objPad.PadSetMicroField("记录日期", dtWrite.ToString("yyyy-MM-dd"));
                    objPad.PadSetMicroField("记录时间", dtWrite.ToString("yyyy-MM-dd HH:mm"));
                }
                else
                {
                    DateTime dtWrite = EmrSysPubFunction.getServerNow();
                    TimeSpan dtSpan = EmrSysPubFunction.getServerNow() - ldt_ADM_WARD_DATE_TIME;
                    if (dtSpan.TotalHours >= 24)
                        dtWrite = ldt_ADM_WARD_DATE_TIME.AddHours(23);

                    objPad.PadSetMicroField("记录日期", dtWrite.ToString("yyyy-MM-dd"));
                    objPad.PadSetMicroField("记录时间", dtWrite.ToString("yyyy-MM-dd HH:mm"));

                }
                objPad.PadSetMicroField("签名", EmrSysPubVar.getOperator());
            }


            //2008-11-10 填充模板住院日，出院日期 单鹏飞
            //DateTime draaaa = EmrSysPubVar.getCurVisitAdmissionDateTime();
            //DateTime dtDischarge = EmrSysPubVar.getCurVisitDischargeDateTime();//0001-1-1 0:00:00
            string patInHospDays = "";
            if (dtDischarge != DateTime.MinValue)
            {
                //计算实际住院日
                patInHospDays = EmrSysPubFunction.GetBetweenDays(ld_ADMISSION_DATE_TIME, dtDischarge).ToString();
            }
            else
            {
                patInHospDays = EmrSysPubFunction.GetBetweenDays(ld_ADMISSION_DATE_TIME, EmrSysPubFunction.getServerNow()).ToString();
            }
            objPad.PadSetMicroField("住院天数", patInHospDays);
            objPad.PadSetMicroField("出院日期", dtDischarge.ToString("yyyy-MM-dd"));
            objPad.PadSetMicroField("出院日期中", dtDischarge.ToString("yyyy年MM月dd日"));
            objPad.PadSetMicroField("出院时间", dtDischarge.ToString("yyyy-MM-dd HH:mm"));


            objPad.PadUpdateMicroField(true);
        }
        /// <summary>
        ///函数名称: replaceVitalSignsRecExist
        ///    功能: 替换已经存在生命体征内容
        ///    创建: 陈联忠  2007年1月26日
        ///最后修改:     
        /// </summary>
        /// <param name="objPad"></param>
        /// <param name="strVitalSigns"></param>
        public static void replaceVitalSignsRecExist(JHEMR.EmrSysUserCtl.UCEMRPad30 objPad, string strVitalSigns)
        {
            //DataSet objDataSet = new DataSet();
            //string strSQL;
            //strSQL = "SELECT VITAL_SIGNS_VALUES,UNITS,TIME_POINT,VITAL_SIGNS_VALUES_C ";
            //strSQL += "   FROM VITAL_SIGNS_REC ";
            //strSQL += " WHERE PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "' ";
            //strSQL += "  AND  VISIT_ID =  " + EmrSysPubVar.getCurPatientVisitID().ToString();
            //strSQL += "  AND  vital_signs =  '" + strVitalSigns + "'";
            //strSQL += "  ORDER By  TIME_POINT ";
            //objDataSet = DALUse.Query(strSQL);
            //if (objDataSet.Tables.Count > 0)
            //{
            //    DataTable objTable;
            //    objTable = objDataSet.Tables[0];
            //    if (objTable.Rows.Count > 0)
            //    {
            //        DataRow drCurrent = objTable.Rows[0];
            //        string strValue = drCurrent["vital_signs_values_c"].ToString();
            //        if (objPad.PadFindField(strVitalSigns, -1, 1, true))
            //            objPad.PadSetFieldText(-1, -1, -1, -1, strValue);
            //    }
            //}            
            DataSet objDataSet = new DataSet();
            string [] strList=new string[4];
            strList[0]="VITAL";
            strList[1]=EmrSysPubVar.getCurPatientID() ;
            strList[2]=EmrSysPubVar.getCurPatientVisitID().ToString();
            if (strVitalSigns == "收缩压")
            {
                strList[3] = "血压high";
            }
            else if(strVitalSigns=="舒张压")
            {
                strList[3] = "血压Low";
            }
            else
            {
                strList[3] =strVitalSigns;
            }
            objDataSet = EmrSysWebservicesUse.myEmrGenralDataSet(strList);
            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    DataRow drCurrent = objTable.Rows[0];
                    try
                    {
                        string strValue = drCurrent["vital_signs_values_c"].ToString();
                        if(strValue.Length>0)
                        {
                            if(strVitalSigns=="体温")
                            {
                                double dTmp = Convert.ToDouble(strValue);
                                strValue= string.Format("{0:F1}", dTmp);
                            }
                            else
                            {
                                double dTmp = Convert.ToDouble(strValue);
                                strValue = string.Format("{0:F0}", dTmp);
                            }
                            if (objPad.PadFindField(strVitalSigns, -1, 1, true))
                                objPad.PadSetFieldText(-1, -1, -1, -1, strValue);
                        }                            
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }
            }
        }

        public static void replaceDiagnoseExist(JHEMR.EmrSysUserCtl.UCEMRPad30 objPad, string strDiagnoseClass)
        {
            try
            {
                //替换住院次
                objPad.PadEditReplaceInternal("[住院次]", EmrSysPubVar.getCurPatientVisitID().ToString(), 1);

                //替换初步诊断
                string strSQL = "select * from diagnosis where diagnosis_type=1 and patient_id='" + EmrSysPubVar.getCurPatientID() + "' and visit_id=" + EmrSysPubVar.getCurPatientVisitID().ToString();
                DataTable dtFirstDiag = DALUse.Query(strSQL).Tables[0];
                string strFirstDiag = " ";
                if (dtFirstDiag.Rows.Count > 0)
                    strFirstDiag = dtFirstDiag.Rows[0]["diagnosis_desc"].ToString();
                objPad.PadEditReplaceInternal("[门诊诊断]", strFirstDiag, 1);
                //替换其他诊断
                DataSet objDataSet = new DataSet();
                objDataSet = getPatDiagnosis(strDiagnoseClass, "");
                if (objDataSet.Tables.Count > 0)
                {
                    DataTable objTable;
                    objTable = objDataSet.Tables[0];
                    string strContent = "";
                    int nIndex = 1;
                    foreach (DataRow drCurrent in objTable.Rows)
                    {
                        strContent += nIndex.ToString() + "." + drCurrent["诊断名称"].ToString();
                        nIndex++;
                    }

                    switch (strDiagnoseClass)
                    {
                        case "2":
                            {
                                if (strContent.Length > 0)
                                    objPad.PadEditReplaceInternal("[初步诊断]", strContent, 1);
                                else
                                    objPad.PadEditReplaceInternal("[初步诊断]", " ", 1);
                            }
                            break;
                        case "3":
                            {
                                if (strContent.Length > 0)
                                    objPad.PadEditReplaceInternal("[最后诊断]", strContent, 1);
                                else
                                    objPad.PadEditReplaceInternal("[最后诊断]", " ", 1);
                            }
                            break;
                    }

                }
                //try
                //{
                DataSet objDataSetOperation = new DataSet();
                string[] strList = new string[4];
                strList[0] = "OPERATION_SCHEDULE";
                strList[1] = EmrSysPubVar.getCurPatientID();
                strList[2] = EmrSysPubVar.getCurPatientVisitID().ToString();
                objDataSetOperation = EmrSysWebservicesUse.myEmrGenralDataSet(strList);
                if (objDataSetOperation.Tables.Count > 0)
                {
                    if (objDataSetOperation.Tables[0].Rows.Count > 0)
                    {
                        DataRow drOperation = objDataSetOperation.Tables[0].Rows[0];
                        string strTmp = "";
                        if (drOperation["operation"] != DBNull.Value)
                            strTmp = drOperation["operation"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[拟施手术]", (strTmp == "" ? " " : strTmp), 1);

                        strTmp = "";
                        if (drOperation["surgeon"] != DBNull.Value)
                            strTmp = drOperation["surgeon"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[手术医生]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["first_assistant"] != DBNull.Value)
                            strTmp = drOperation["first_assistant"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[一助]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["second_assistant"] != DBNull.Value)
                            strTmp = drOperation["second_assistant"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[二助]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["third_assistant"] != DBNull.Value)
                            strTmp = drOperation["third_assistant"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[三助]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["first_operation_nurse"] != DBNull.Value)
                            strTmp = drOperation["first_operation_nurse"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[手术护士]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["anesthesia_method"] != DBNull.Value)
                            strTmp = drOperation["anesthesia_method"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[麻醉方法]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["anesthesia_doctor"] != DBNull.Value)
                            strTmp = drOperation["anesthesia_doctor"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[麻醉者]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["START_DATE_TIME"] != DBNull.Value)
                            strTmp = drOperation["START_DATE_TIME"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[手术日期]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["diag_before_operation"] != DBNull.Value)
                            strTmp = drOperation["diag_before_operation"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[术前诊断]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["diag_after_operation"] != DBNull.Value)
                            strTmp = drOperation["diag_after_operation"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[术后诊断]", (strTmp == "" ? " " : strTmp), 1);

                    }
                    else
                    {
                        objPad.PadEditReplaceInternal("[拟施手术]", " ", 1);
                        objPad.PadEditReplaceInternal("[手术医生]", " ", 1);
                        objPad.PadEditReplaceInternal("[一助]", " ", 1);
                        objPad.PadEditReplaceInternal("[二助]", " ", 1);
                        objPad.PadEditReplaceInternal("[三助]", " ", 1);
                        objPad.PadEditReplaceInternal("[手术护士]", " ", 1);
                        objPad.PadEditReplaceInternal("[麻醉方法]", " ", 1);
                        objPad.PadEditReplaceInternal("[麻醉者]", " ", 1);
                        objPad.PadEditReplaceInternal("[手术日期]", " ", 1);
                        objPad.PadEditReplaceInternal("[术前诊断]", " ", 1);
                        objPad.PadEditReplaceInternal("[术后诊断]", " ", 1);
                    }
                }
                else
                {
                    objPad.PadEditReplaceInternal("[拟施手术]", " ", 1);
                    objPad.PadEditReplaceInternal("[手术医生]", " ", 1);
                    objPad.PadEditReplaceInternal("[一助]", " ", 1);
                    objPad.PadEditReplaceInternal("[二助]", " ", 1);
                    objPad.PadEditReplaceInternal("[三助]", " ", 1);
                    objPad.PadEditReplaceInternal("[手术护士]", " ", 1);
                    objPad.PadEditReplaceInternal("[麻醉方法]", " ", 1);
                    objPad.PadEditReplaceInternal("[麻醉者]", " ", 1);
                    objPad.PadEditReplaceInternal("[手术日期]", " ", 1);
                    objPad.PadEditReplaceInternal("[术前诊断]", " ", 1);
                    objPad.PadEditReplaceInternal("[术后诊断]", " ", 1);
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }

        #endregion 替换病历中现在已经存在的内容

        #region 书写住院志的诊断(标准版)
        /// <summary>
        ///函数名称: writePadDiagnoseGEY
        ///    功能: 书写住院志的诊断(广东省第二人民医院)
        ///    创建: 李世伟  2007年10月22日
        ///最后修改: 李世伟  2008年02月28日
        /// </summary>
        /// <param name="objPad"></param>
        /// <returns></returns>
        public static bool writePadDiagnose(JHEMR.EmrSysUserCtl.UCEMRPad30 objPad)
        {
            //诊断签名改为CA签名   胡磊  20140312
            //1、判断是否为CA用户 flag1
            //2、所有签名增加CA签名
            bool flag1 = false;
            flag1 = IsCAUser();
            string strSQL = "select a.three_day_diagnosis_name from pat_visit a where a.patient_id='" + EmrSysPubVar.getCurPatientID() + "' and a.visit_id='" + EmrSysPubVar.getCurPatientVisitID().ToString() + "'";
            object obj = DALUse.GetSingle(strSQL);
            if (obj != null)
                objPad.PadEditReplaceInternal("[确定诊断]", obj.ToString(), 1);
            #region 诊断 (最后诊断，初步诊断)
            if (objPad.PadFindField("诊断", 1, 2, true))
            {
                //获取当前光标的表格
                int nbaselineindex = -1; 	//基行号
                int ncellindex = -1; 		//单元序号
                int nlineindex = -1; 		//行号
                int nfieldelemindex = -1; //元素序号
                int ncharpos = -1;		   //字符位置
                short ndiagnoselevel = -1; //设置诊断元素的级别,对于固定元素,如果级别不是<0的,则只作为节点输出,不输出内容

                objPad.PadGetCurCursorPos(ref nbaselineindex, ref ncellindex, ref nlineindex, ref nfieldelemindex, ref ncharpos, true);

                //要验证一下值是否有效
                if (nbaselineindex < 0)
                    return false;

                //看看当前是不是在表格内
                if (ncellindex < 0)
                    return false;

                //先删除表格中已经有的记录,然后把新记录写到表格中
                //得到当前行的行号
                int ntablerows = 0;
                int ntablecols = 0;
                ntablerows = objPad.PadGetObjectCount(nbaselineindex, ncellindex, nlineindex, 2);
                ntablecols = objPad.PadGetObjectCount(nbaselineindex, ncellindex, nlineindex, 3);
                //设置表格可编辑
                objPad.PadTableSelect();
                objPad.PadEditLineEditMode();

                for (int i = 0; i < ntablerows - 1; i++)
                {
                    objPad.PadSetSel(nbaselineindex, ntablecols, 0, 0, 0, nbaselineindex, ntablecols, 0, 0, 0);
                    objPad.PadTableDeleteRow();
                }
                ntablerows = 1;

                //清除表格第一行
                objPad.PadSetSel(nbaselineindex, 0, 0, 0, 0, nbaselineindex, 0, 0, 0, 0);
                objPad.PadTableInsertRowBottom();
                objPad.PadSetSel(nbaselineindex, 0, 0, 0, 0, nbaselineindex, 0, 0, 0, 0);
                objPad.PadTableDeleteRow();
                //定位到第一行
                objPad.PadSetSel(nbaselineindex, 0, 0, 0, 0, nbaselineindex, 0, 0, 0, 0);

                //审签诊断

                DateTime ls_sign_date = EmrSysPubFunction.getServerNow();
                //choose case g_user_priority
                //case 0
                //	update PAT_DIAGNOSIS set FLAG=1 where FLAG=0 and patient_id=:gu_us_data.patient_id and visit_id=:gu_us_data.visit_id;
                //case 1
                //	update PAT_DIAGNOSIS set FLAG=2,LAST_MODIFY_DATE=:ls_sign_date,MODIFIER_ID=:g_db_user where FLAG<2 and patient_id=:gu_us_data.patient_id and visit_id=:gu_us_data.visit_id;
                //case 2
                //	update PAT_DIAGNOSIS set FLAG=3,SUPER_SIGN_DATE=:ls_sign_date,SUPER_ID=:g_db_user where FLAG<3 and patient_id=:gu_us_data.patient_id and visit_id=:gu_us_data.visit_id;
                //end choose
                //	

                //诊断显示编排	
                int li_temp_row = 0;

                /////////------------------最后诊断-----------------////////////////
                int nrow = 0;
                int ntotalrow = 0;
                int nmainno = 0; //主诊断序号
                int nsubno = 0;//子诊断号
                string ndiagtext;  		//诊断显示的内容
                int nsigncount = 1;       //签名次数

                //填充类别明细
                DataSet objDatasetDiagnosisType = new DataSet();
                objDatasetDiagnosisType = getPatDiagnosisType("3");
                DataTable objTable = objDatasetDiagnosisType.Tables[0];
                string ls_diagnostician_id, ls_modifier_id, ls_supper_id, ls_temp;
                foreach (DataRow drCurrent in objTable.Rows)
                {

                    DataSet objDataset = new DataSet();
                    objDataset = getPatDiagnosis("3", drCurrent["PAT_DIAGNOSIS_TYPE_NAME"].ToString());
                    if (objDataset.Tables.Count > 0)
                    {
                        DataTable objTableDiagnosis = objDataset.Tables[0];
                        nrow = 1;

                        Boolean bModifier = false;
                        Boolean bSupper = false;
                        DataRow[] dr = objTableDiagnosis.Select("上级医师 is null");
                        if (dr.Length > 0)
                            bModifier = false;
                        else
                            bModifier = true;

                        dr = objTableDiagnosis.Select("主任医师 is null");
                        if (dr.Length > 0)
                            bSupper = false;
                        else
                            bSupper = true;
                        int x = 1;
                        foreach (DataRow drDiagnosis in objTableDiagnosis.Rows)
                        {
                            //插入行,并设置值
                            if (ntotalrow == ntablerows)
                            {
                                objPad.PadTableInsertRowBottom();
                                ntablerows++;
                            }
                            ntotalrow++;
                            //插入类别
                            if (nrow == 1)
                            {
                                objPad.PadSetSel(nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0, nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0);
                                //qzz20110408 去掉诊断日期
                                //objPad.PadInsertField(drDiagnosis["诊断类型"].ToString(), drDiagnosis["诊断类型"].ToString() +" (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                                objPad.PadInsertField(drDiagnosis["诊断类型"].ToString(), drDiagnosis["诊断类型"].ToString(), 2, 2, 1);//最后诊断时间spf
                                objPad.PadFontBold();
                                if (ntotalrow == ntablerows)
                                {
                                    objPad.PadTableInsertRowBottom();
                                    ntablerows++;
                                }
                                ntotalrow++;
                            }

                            objPad.PadSetSel(nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0, nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0);
                            ndiagtext = "";
                            nmainno = 1;
                            nsubno = 0;
                            //只有一个主诊断或子诊断不写序号
                            foreach (DataRow drCur in objTableDiagnosis.Rows)
                            {
                                if (Convert.ToInt32(drCur["序号"].ToString()) > 1)
                                {
                                    nmainno = Convert.ToInt32(drCur["序号"].ToString());
                                }
                                if (drCur["序号"].ToString() == drDiagnosis["序号"].ToString())
                                {
                                    if (Convert.ToInt32(drCur["子号"].ToString()) > 0)
                                    {
                                        nsubno = Convert.ToInt32(drCur["子号"].ToString());
                                    }
                                }
                            }
                            if (nmainno > 1)
                                ndiagtext = drDiagnosis["序号"].ToString() + ".";
                            int intLevel = 0;
                            string strSpace = "    ";
                            GetLevel(objTableDiagnosis, drDiagnosis["ID"].ToString(), ref intLevel);
                            for (int i = 1; i < intLevel; i++)
                            {
                                strSpace += "    ";
                            }

                            if (nsubno > 1 && drDiagnosis["子号"].ToString() != "0" && intLevel <= 2)
                            {

                                //ndiagtext = strSpace + x.ToString() + "." + drDiagnosis["诊断名称"].ToString() +" (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                                //x++;
                                ndiagtext = strSpace  + drDiagnosis["诊断名称"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                                x++;
                            }
                            else if (nsubno == 1 && drDiagnosis["子号"].ToString() != "0" || intLevel > 2)
                                ndiagtext = strSpace + drDiagnosis["诊断名称"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                            else
                            {
                                ndiagtext = strSpace + ndiagtext + drDiagnosis["诊断名称"].ToString() +" (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                            }
                            objPad.PadInsertField(drDiagnosis["诊断类型"].ToString() + nrow.ToString(), ndiagtext, ndiagnoselevel, 2, 1);
                            nrow++;
                            //////////////////////////////////////////////////////////////////////////////////////////////
                            if (nrow == objTableDiagnosis.Rows.Count+1)
                            {
                                //ls_temp = drDiagnosis["医师"].ToString();
                                //if (ls_temp.Length > 0)
                                //    ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);
                                ls_temp = drDiagnosis["医师"].ToString();
                                if (ls_temp.Length > 0)
                                    ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);

                                if (drDiagnosis["上级医师"] != DBNull.Value)
                                {
                                    if (drDiagnosis["上级医师"].ToString().Trim().Length > 0)
                                        ls_temp = EmrSysPubFunction.getUserName(drDiagnosis["上级医师"].ToString(),false) + "/" + ls_temp;
                                }

                                if (drDiagnosis["主任医师"] != DBNull.Value)
                                {
                                    if (drDiagnosis["主任医师"].ToString().Trim().Length > 0)
                                    {
                                        ls_temp = EmrSysPubFunction.getUserName(drDiagnosis["主任医师"].ToString(),false) + "/" + ls_temp;
                                    }
                                }
                                else
                                {
                                    if (drDiagnosis["实习医师"] != DBNull.Value)
                                    {
                                        if (drDiagnosis["实习医师"].ToString().Trim().Length > 0)
                                            ls_temp += "/" + drDiagnosis["实习医师"].ToString();
                                    }
                                }

                                if (ls_temp.Length > 0)
                                {
                                    //插入行,并设置值
                                    if (li_temp_row >= ntablerows)
                                    {
                                        objPad.PadTableInsertRowBottom();
                                        ntablerows++;
                                    }
                                    if (ntotalrow == ntablerows)
                                    {
                                        objPad.PadTableInsertRowBottom();
                                        ntablerows++;
                                    }
                                    ntotalrow++;
                                    //objPad.PadSetSel(nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0, nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0);
                                    objPad.PadSetSel(nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0, nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0);//2013-12-16  苏瑜  最后诊断签名的位置
                                    
                                       
                                    //CA用户图片签名   胡磊  20140312
                                        if (flag1)
                                        {
                                            insertSignPic(objPad, drDiagnosis["医师"].ToString(), EmrSysPubFunction.getUserName(drDiagnosis["医师"].ToString(), false));
                                        }
                                        else
                                        {
                                            objPad.PadInsertField("诊断签名" + nsigncount.ToString(), ls_temp, ndiagnoselevel, 2, 1);
                                        }
                                    objPad.PadLineAlignRight();
                                    //插入行,并设置值
                                    //nrow++;
                                    //li_temp_row++;
                                    //if (li_temp_row >= ntablerows)
                                    //{
                                    //    objPad.PadTableInsertRowBottom();
                                    //    ntablerows++;
                                    //}
                                    //objPad.PadSetSel(nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0, nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0);
                                    //objPad.PadInsertField("诊断签名时间" + nsigncount.ToString(), Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") , ndiagnoselevel, 2, 1);
                                    objPad.PadLineAlignRight();
                                    nsigncount++;
                                    li_temp_row++;
                                }
                            }
                        }// end of Diagnosis foreach
                    }//table>0
                }//end foreach of 初步诊断









                //            //医生签名20081120spf
                //            if (nrow == objTableDiagnosis.Rows.Count + 1)
                //            {
                //                ls_temp = drDiagnosis["医师"].ToString();
                //                if (ls_temp.Length > 0)
                //                    ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);



                //                //20100901签名 加实习医生
                //                if (drDiagnosis["实习医师"].ToString().Trim().Length > 0)
                //                {
                //                    ls_temp += "/" + drDiagnosis["实习医师"].ToString();
                //                }

                //                //qzz20110322取消诊断签名
                //                if (ls_temp.Length > 0)
                //                {
                //                    //插入行,并设置值
                //                    if (ntotalrow == ntablerows)
                //                    {
                //                        objPad.PadTableInsertRowBottom();
                //                        ntablerows++;
                //                    }
                //                    //ntotalrow++;
                //                    //objPad.PadSetSel(nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0, nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0);
                //                    //objPad.PadInsertField("诊断签名时间" + nsigncount.ToString(), Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy年MM月dd日"), ndiagnoselevel, 2, 1);
                //                    //objPad.PadLineAlignRight();

                //                    //nsigncount++;

                //                    if (ntotalrow == ntablerows)
                //                    {
                //                        objPad.PadTableInsertRowBottom();
                //                        ntablerows++;
                //                    }
                //                    ntotalrow++;
                //                    objPad.PadSetSel(nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0, nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0);
                //                    objPad.PadInsertField("诊断签名" + nsigncount.ToString(), ls_temp, ndiagnoselevel, 2, 1);
                //                    objPad.PadLineAlignRight();
                //                    nsigncount++;
                //                    li_temp_row++;
                //                }
                //            }


                //        }//end foreach
                //    }
                //}


                /////////------------------初步诊断-----------------////////////////

                li_temp_row = 0;

                objDatasetDiagnosisType = getPatDiagnosisType("2");
                objTable = objDatasetDiagnosisType.Tables[0];

                ls_diagnostician_id = "";
                ls_modifier_id = "";
                ls_supper_id = "";
                int y = 1;
                foreach (DataRow drCurrent in objTable.Rows)
                {
                    DataSet objDataset = new DataSet();
                    objDataset = getPatDiagnosis("2", drCurrent["PAT_DIAGNOSIS_TYPE_NAME"].ToString());
                    if (objDataset.Tables.Count > 0)
                    {
                        DataTable objTableDiagnosis;
                        objTableDiagnosis = objDataset.Tables[0];
                        nrow = 1;
                        foreach (DataRow drDiagnosis in objTableDiagnosis.Rows)
                        {
                            //插入行,并设置值
                            if (li_temp_row >= ntablerows)
                            {
                                objPad.PadTableInsertRowBottom();
                                ntablerows++;
                            }

                            //插入类别
                            if (nrow == 1)
                            {

                                objPad.PadSetSel(nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0, nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0);
                                //qzz20110408 去掉诊断日期
                                //objPad.PadInsertField(drDiagnosis["诊断类型"].ToString(), drDiagnosis["诊断类型"].ToString() + "：(" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")", 2, 2, 1);//初步诊断日期spf
                                objPad.PadInsertField(drDiagnosis["诊断类型"].ToString(), drDiagnosis["诊断类型"].ToString(), 2, 2, 1);//初步诊断日期spf
                                objPad.PadFontBold();
                                li_temp_row++;
                                if (li_temp_row >= ntablerows)
                                {
                                    objPad.PadTableInsertRowBottom();
                                    ntablerows++;
                                }
                            }

                            objPad.PadSetSel(nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0, nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0);

                            ndiagtext = "";
                            nmainno = 1;
                            nsubno = 0;
                            //只有一个主诊断或子诊断不写序号
                            foreach (DataRow drCur in objTableDiagnosis.Rows)
                            {
                                if (Convert.ToInt32(drCur["序号"].ToString()) > 1)
                                {
                                    nmainno = Convert.ToInt32(drCur["序号"].ToString());
                                }
                                if (drCur["序号"].ToString() == drDiagnosis["序号"].ToString())
                                {
                                    if (Convert.ToInt32(drCur["子号"].ToString()) > 0)
                                    {
                                        nsubno = Convert.ToInt32(drCur["子号"].ToString());
                                    }
                                }
                            }
                            if (nmainno > 1)
                                ndiagtext = drDiagnosis["序号"].ToString() + ".";
                            int intLevel = 0;
                            string strSpace = "    ";
                            GetLevel(objTableDiagnosis, drDiagnosis["ID"].ToString(), ref intLevel);
                            for (int i = 1; i < intLevel; i++)
                            {
                                strSpace += "    ";
                            }

                            if (nsubno > 1 && drDiagnosis["子号"].ToString() != "0" && intLevel <= 2)
                            {
                                //ndiagtext = strSpace + y.ToString() + "." + drDiagnosis["诊断名称"].ToString()+ " (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                                ndiagtext = strSpace  + drDiagnosis["诊断名称"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                                y++;
                            }
                            else if (nsubno == 1 && drDiagnosis["子号"].ToString() != "0" || intLevel > 2)
                                ndiagtext = strSpace + drDiagnosis["诊断名称"].ToString();
                            else
                            {
                                ndiagtext = strSpace + ndiagtext + drDiagnosis["诊断名称"].ToString() +"(" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                            }
                            objPad.PadInsertField(drDiagnosis["诊断类型"].ToString() + nrow.ToString(), ndiagtext, ndiagnoselevel, 2, 1);
                            nrow++;
                            li_temp_row++;
                            //if (nrow == objTableDiagnosis.Rows.Count + 1)
                            //{
                            //    ls_temp = drDiagnosis["医师"].ToString();
                            //    if (ls_temp.Length > 0)
                            //        ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);

                            //    //20100901签名 加实习医生
                            //    if (drDiagnosis["实习医师"].ToString().Trim().Length > 0)
                            //    {
                            //        ls_temp += "/" + drDiagnosis["实习医师"].ToString();
                            //    }





                                 if (nrow == objTableDiagnosis.Rows.Count+1)
                            {
                                //ls_temp = drDiagnosis["医师"].ToString();
                                //if (ls_temp.Length > 0)
                                //    ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);
                                ls_temp = drDiagnosis["医师"].ToString();
                                if (ls_temp.Length > 0)
                                    ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);

                                if (drDiagnosis["上级医师"] != DBNull.Value)
                                {
                                    if (drDiagnosis["上级医师"].ToString().Trim().Length > 0)
                                        ls_temp = EmrSysPubFunction.getUserName(drDiagnosis["上级医师"].ToString(),false) + "/" + ls_temp;
                                }

                                if (drDiagnosis["主任医师"] != DBNull.Value)
                                {
                                    if (drDiagnosis["主任医师"].ToString().Trim().Length > 0)
                                    {
                                        ls_temp = EmrSysPubFunction.getUserName(drDiagnosis["主任医师"].ToString(),false) + "/" + ls_temp;
                                    }
                                }
                                else
                                {
                                    if (drDiagnosis["实习医师"] != DBNull.Value)
                                    {
                                        if (drDiagnosis["实习医师"].ToString().Trim().Length > 0)
                                            ls_temp += "/" + drDiagnosis["实习医师"].ToString();
                                    }
                                }







                                if (ls_temp.Length > 0)
                                {
                                    //插入行,并设置值
                                    //qzz20110322取消诊断签名
                                    if (li_temp_row >= ntablerows)
                                    {
                                        objPad.PadTableInsertRowBottom();
                                        ntablerows++;
                                    }
                                    //objPad.PadSetSel(nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0, nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0);
                                    //objPad.PadInsertField("诊断签名时间" + nsigncount.ToString(), Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy年MM月dd日"), ndiagnoselevel, 2, 1);
                                    //objPad.PadLineAlignRight();
                                    //插入行,并设置值
                                    //nrow++;
                                    //li_temp_row++;
                                    if (li_temp_row >= ntablerows)
                                    {
                                        objPad.PadTableInsertRowBottom();
                                        ntablerows++;
                                    }
                                    objPad.PadSetSel(nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0, nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0);
                                  
                                    //CA用户图片签名   胡磊  20140312
                                    if (flag1)
                                    {
                                        insertSignPic(objPad, drDiagnosis["医师"].ToString(), EmrSysPubFunction.getUserName(drDiagnosis["医师"].ToString(), false));
                                    }
                                    else
                                    {
                                        objPad.PadInsertField("诊断签名" + nsigncount.ToString(), ls_temp, ndiagnoselevel, 2, 1);
                                    }
                                    objPad.PadLineAlignRight();
                                    nsigncount++;
                                    li_temp_row++;
                                }
                            }
                        }// end of Diagnosis foreach
                    }//table>0
                }//end foreach of 初步诊断

                objPad.PadSetSel(nbaselineindex, 0, 0, 0, 0, nbaselineindex, 0, 0, 0, 0);

                //要设置表格只读
                //设置表格可编辑
                //要清空编辑缓冲区，这个操作是不允许用户撤消的。
                objPad.PadCleanUndoBuffer();
                objPad.PadTableSelect();
                objPad.PadEditLineReadOnly();
                objPad.PadSetSel(nbaselineindex, 0, 0, 0, 0, nbaselineindex, 0, 0, 0, 0);
            }//诊断

            #endregion

            #region 入院诊断

            if (objPad.PadFindField("入院诊断", -1, 2, true))
            {
                /////////------------------入院诊断-----------------////////////////
                //获取当前光标的表格
                int nbaselineindex = -1; 	//基行号
                int ncellindex = -1; 		//单元序号
                int nlineindex = -1; 		//行号
                int nfieldelemindex = -1; //元素序号
                int ncharpos = -1;		   //字符位置

                objPad.PadGetCurCursorPos(ref nbaselineindex, ref ncellindex, ref nlineindex, ref nfieldelemindex, ref ncharpos, true);
                objPad.PadSetSel(nbaselineindex, ncellindex + 1, nlineindex, nfieldelemindex, ncharpos, nbaselineindex, ncellindex + 1, nlineindex, nfieldelemindex, ncharpos);
                int intDel = 0;
                while (intDel < 20)
                {
                    objPad.PadDeleteCurFieldElem();
                    intDel++;
                }
                DataSet objDatasetDiagnosisType = getPatDiagnosisType("2");
                DataTable objTable = objDatasetDiagnosisType.Tables[0];
                int i = 1;
                foreach (DataRow drCurrent in objTable.Rows)
                {
                    DataSet objDataset = new DataSet();
                    objDataset = getPatDiagnosis("2", drCurrent["PAT_DIAGNOSIS_TYPE_NAME"].ToString());
                    if (objDataset.Tables.Count > 0)
                    {
                        DataTable objTableDiagnosis;
                        objTableDiagnosis = objDataset.Tables[0];
                        foreach (DataRow drDiagnosis in objTableDiagnosis.Rows)
                        {
                            //只有一个主诊断或子诊断不写序号
                            int nmainno = 0; //主诊断序号
                            int nsubno = 0;//子诊断号
                            string ndiagtext = "";
                            foreach (DataRow drCur in objTableDiagnosis.Rows)
                            {
                                if (Convert.ToInt32(drCur["序号"].ToString()) > 1)
                                {
                                    nmainno = Convert.ToInt32(drCur["序号"].ToString());
                                }
                                if (drCur["序号"].ToString() == drDiagnosis["序号"].ToString())
                                {
                                    if (Convert.ToInt32(drCur["子号"].ToString()) > 0)
                                    {
                                        nsubno = Convert.ToInt32(drCur["子号"].ToString());
                                    }
                                }
                            }
                            if (nmainno > 1)
                                ndiagtext = drDiagnosis["序号"].ToString() + ".";
                            int intLevel = 0;
                            string strSpace = "    ";
                            GetLevel(objTableDiagnosis, drDiagnosis["ID"].ToString(), ref intLevel);
                            for (int ii = 1; ii < intLevel; ii++)
                            {
                                strSpace += "    ";
                            }

                            //if (nsubno > 1 && drDiagnosis["子号"].ToString() != "0")  两层以上不要序号 李世伟 2008-5-30
                            if (nsubno > 1 && drDiagnosis["子号"].ToString() != "0" && intLevel <= 2)

                                //ndiagtext = "　　　　" + Convert.ToInt32(drDiagnosis["子号"].ToString()) + "." + " " + drDiagnosis["诊断名称"].ToString();
                                ndiagtext = strSpace + drDiagnosis["诊断名称"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                            //else if (nsubno == 1 && drDiagnosis["子号"].ToString() != "0")    两层以上不要序号 李世伟 2008-5-30
                            else if (nsubno == 1 && drDiagnosis["子号"].ToString() != "0" || intLevel > 2)
                                //ndiagtext = "　　　　     " + drDiagnosis["诊断名称"].ToString();
                                ndiagtext = strSpace + drDiagnosis["诊断名称"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                            else
                            {
                                //ndiagtext = "　　" + ndiagtext + drDiagnosis["诊断名称"].ToString() + "(" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                                ndiagtext = strSpace + ndiagtext + drDiagnosis["诊断名称"].ToString() + "(" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                            }
                            objPad.PadInsertField("入院诊断" + i.ToString(), ndiagtext + " ", -1, 2, 1);
                            i++;
                        }
                    }
                }
            }//end if of 入院诊断
            #endregion

            #region 出院诊断

            if (objPad.PadFindField("出院诊断", -1, 1, true))
            {
                /////////------------------出院诊断-----------------////////////////
                //获取当前光标的表格
                int nbaselineindex = -1; 	//基行号
                int ncellindex = -1; 		//单元序号
                int nlineindex = -1; 		//行号
                int nfieldelemindex = -1; //元素序号
                int ncharpos = -1;		   //字符位置

                objPad.PadGetCurCursorPos(ref nbaselineindex, ref ncellindex, ref nlineindex, ref nfieldelemindex, ref ncharpos, true);
                objPad.PadSetSel(nbaselineindex, ncellindex + 1, nlineindex, nfieldelemindex, ncharpos, nbaselineindex, ncellindex + 1, nlineindex, nfieldelemindex, ncharpos);
                int intDel = 0;
                while (intDel < 20)
                {
                    objPad.PadDeleteCurFieldElem();
                    intDel++;
                }
                DataSet objDatasetDiagnosisType = getPatDiagnosisType("3");
                DataTable objTable = objDatasetDiagnosisType.Tables[0];
                int i = 1;
                foreach (DataRow drCurrent in objTable.Rows)
                {
                    DataSet objDataset = new DataSet();
                    objDataset = getPatDiagnosis("3", drCurrent["PAT_DIAGNOSIS_TYPE_NAME"].ToString());
                    if (objDataset.Tables.Count > 0)
                    {
                        DataTable objTableDiagnosis;
                        objTableDiagnosis = objDataset.Tables[0];
                        foreach (DataRow drDiagnosis in objTableDiagnosis.Rows)
                        {
                            //只有一个主诊断或子诊断不写序号
                            int nmainno = 0; //主诊断序号
                            int nsubno = 0;//子诊断号
                            string ndiagtext = "";
                            foreach (DataRow drCur in objTableDiagnosis.Rows)
                            {
                                if (Convert.ToInt32(drCur["序号"].ToString()) > 1)
                                {
                                    nmainno = Convert.ToInt32(drCur["序号"].ToString());
                                }
                                if (drCur["序号"].ToString() == drDiagnosis["序号"].ToString())
                                {
                                    if (Convert.ToInt32(drCur["子号"].ToString()) > 0)
                                    {
                                        nsubno = Convert.ToInt32(drCur["子号"].ToString());
                                    }
                                }
                            }
                            if (nmainno > 1)
                                ndiagtext = drDiagnosis["序号"].ToString() + ".";
                            //处理子诊断
                            //处理子诊断
                            int intLevel = 0;
                            string strSpace = "    ";
                            GetLevel(objTableDiagnosis, drDiagnosis["ID"].ToString(), ref intLevel);
                            for (int ii = 1; ii < intLevel; ii++)
                            {
                                strSpace += "    ";
                            }

                            //if (nsubno > 1 && drDiagnosis["子号"].ToString() != "0")  两层以上不要序号 李世伟 2008-5-30
                            if (nsubno > 1 && drDiagnosis["子号"].ToString() != "0" && intLevel <= 2)
                                //ndiagtext = "　　　　" + Convert.ToInt32(drDiagnosis["子号"].ToString()) + "." + " " + drDiagnosis["诊断名称"].ToString();
                                ndiagtext = strSpace + drDiagnosis["诊断名称"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                            //else if (nsubno == 1 && drDiagnosis["子号"].ToString() != "0")    两层以上不要序号 李世伟 2008-5-30
                            else if (nsubno == 1 && drDiagnosis["子号"].ToString() != "0" || intLevel > 2)
                                //ndiagtext = "　　　　     " + drDiagnosis["诊断名称"].ToString();
                                ndiagtext = strSpace + drDiagnosis["诊断名称"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                            else
                            {
                                //ndiagtext = "　　" + ndiagtext + drDiagnosis["诊断名称"].ToString() + "(" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                                ndiagtext = strSpace + ndiagtext + drDiagnosis["诊断名称"].ToString() + "(" + Convert.ToDateTime(drDiagnosis["诊断日期"].ToString()).ToString("yyyy-MM-dd") + ")";
                            }
                            objPad.PadInsertField("出院诊断" + i.ToString(), ndiagtext + " ", -1, 2, 1);
                            i++;
                        }
                    }
                }
            }//end if 出院诊断
            #endregion

            return true;
        }

        #endregion
        #region 判断是否CA用户并进行CA验证   胡磊   20140312
        public static bool IsCAUser()
        {
            if (EMRCA.CAAdapter.GetCatype() != EMRCA.CAType.NOCA)
            {
                if (EMRCA.CAAdapter.ReadKey())
                {
                    //验证CA
                    string i = ""; int j = 0;
                    string sql0, dataSource, signData;
                    DataTable dt1;
                    string sql1 = "select * from users_ca t where t.user_id='" + EmrSysPubVar.getUserID() + "'";
                    DataSet ds = new DataSet();
                    ds = DALUse.Query(sql1);
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                             sql0 = "select t.diagnosis_type,t.diagnosis_no,t.diagnosis_sub_no,t.diagnosis_date,t.diagnostician_id,t.diagnosis_code from pat_diagnosis t";
                            sql0 += " where t.PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "' and t.VISIT_ID =" + EmrSysPubVar.getCurPatientVisitID().ToString() + "";
                            dt1 = DALUse.Query(sql0).Tables[0];
                            foreach (DataRow dr1 in dt1.Rows)
                            {
                                if (j > 0 && j < dt1.Rows.Count)
                                    i += "^";
                                i += dr1["diagnosis_type"].ToString() + "@" + dr1["diagnosis_no"].ToString() + "@" + dr1["diagnosis_sub_no"].ToString() + "@";
                                i += dr1["diagnosis_date"].ToString() + "@" + dr1["diagnostician_id"].ToString() + "@" + dr1["diagnosis_code"].ToString();
                                j++;
                            }
                            dataSource = i.ToString();
                            signData = EMRCA.CAAdapter.CASignData(dataSource);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        #endregion
        #region 调图片签名  胡磊  20140312
        public static bool insertSignPic(JHEMR.EmrSysUserCtl.UCEMRPad30 emrpad30, string db_user, string user_name)
        {
            string strSql = "select * from users_pic,users where users_pic.user_id =users.user_id and users.db_user = '" + db_user + "'";
            DataTable dt = DALUse.Query(strSql).Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["user_name_pic"] != DBNull.Value)
                {
                    string strFile = Application.StartupPath + "\\tmp." + dt.Rows[0]["EXTENSION_FILE_NAME"].ToString();
                    byte[] b = (byte[])dt.Rows[0]["user_name_pic"];
                    File.WriteAllBytes(strFile, b);
                    emrpad30.PadcmdInsertFieldImage(strFile, true);
                    try
                    {
                        string strPicWidthAndHeight = "20|40";
                        string[] strWidthAndHeight = strPicWidthAndHeight.Split('|');
                        //if (strWidthAndHeight.Length == 2)
                        //{
                        //    emrpad30.PadsetFieldHeightAndWidth(Int32.Parse(strWidthAndHeight[0].ToString()), Int32.Parse(strWidthAndHeight[1].ToString()));
                        //}
                        //else
                        //{
                        emrpad30.PadsetFieldHeightAndWidth(EmrSysPubVar.getSignPicHeight(), EmrSysPubVar.getSignPicWidth());
                        //}
                    }
                    catch
                    {
                        emrpad30.PadsetFieldHeightAndWidth(EmrSysPubVar.getSignPicHeight(), EmrSysPubVar.getSignPicWidth());
                    }
                    File.Delete(strFile);
                }
                else
                {
                    emrpad30.PadInsertText(user_name);
                }
            }
            else
            {
                emrpad30.PadInsertText(user_name);
            }
            return true;
        }
        #endregion

        //得到诊断层次
        private static void GetLevel(DataTable dtDiag, string intId, ref int intLevel)
        {
            if (intId == "0")
                return;
            intLevel++;
            foreach (DataRow dr in dtDiag.Rows)
            {
                if (dr["id"].ToString() == intId)
                {
                    GetLevel(dtDiag, dr["PARENTID"].ToString(), ref intLevel);
                }
            }
        }
    
    
    }
}
