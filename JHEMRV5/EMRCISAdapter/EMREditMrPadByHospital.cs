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
        ///��������: getPatDiagnosisType
        ///    ����: ��ȡ�������¼
        ///    ����: ������  2007��1��22��
        ///����޸�:     
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
        ///��������: getPatDiagnosis
        ///    ����: ��ȡָ����ϼ�¼
        ///    ����: ������  2007��1��22��
        ///����޸�:     
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
            strSQL.Append("SELECT  DIAGNOSIS_TYPE_NAME as �������,DIAGNOSIS_NO as ���,DIAGNOSIS_SUB_NO as �Ӻ�,");
            strSQL.Append(" DIAGNOSIS_DESC as ������� ,CONFIRMED_INDICATOR,DIAGNOSIS_DATE as �������,DIAGNOSIS_CODE as ��ϱ���,DIAGNOSTICIAN_ID as ҽʦ,");
            strSQL.Append(" HOUSEMAN as ʵϰҽʦ,MODIFIER_ID as �ϼ�ҽʦ,LAST_MODIFY_DATE as �ϼ���ǩ����,");
            strSQL.Append(" SUPER_ID as ����ҽʦ, SUPER_SIGN_DATE as ������ǩ����,DIAGNOSIS_CLASS,FLAG, PATIENT_ID,VISIT_ID,DIAGNOSIS_TYPE,ID,PARENTID ");
            strSQL.Append(" FROM PAT_DIAGNOSIS ");
            strSQL.Append(" WHERE ( PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "') ");
            strSQL.Append("   AND  ( VISIT_ID =" + EmrSysPubVar.getCurPatientVisitID().ToString() + ") ");
            strSQL.Append("   AND  ( DIAGNOSIS_TYPE ='" + strDiagClass + "') ");
            if (strDiagnosisTypeNameList.Length > 0)
                strSQL.Append("   AND  ( diagnosis_type_name in (" + strDiagnosisTypeNameList + ")) ");
            return DALUse.Query(strSQL.ToString());
        }

        //���ǽ��Ĺ���վ����ʱ�����Ƿ���ʾ�����Ȳ�����Ϣ
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
       


        #region �滻�����������Ѿ����ڵ�����

        /// <summary>
        /// 
        /// ����޸ģ�������
        /// ��ӽ���վȨ�޿���
        /// </summary>
        /// <param name="objPad"></param>
        /// <param name="bIsTemplet"></param>
        public static void updatePadMicroField(JHEMR.EmrSysUserCtl.UCEMRPad30 objPad, bool bIsTemplet)
        {
            
            
            //���ƽ���վ����滻
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

            //1.���˻�����Ϣ����
            string ls_INP_NO = "", ls_BIRTH_PLACE = "", ls_NATION = "", ls_BIRTH_PLACE_NAME = "", ls_phone_number_home = "", ls_phone_number_business = "", ls_next_of_kin_phone="";
            string ls_JIGUAN = ""; string ls_XIAN_PLACE = "";
            DateTime ldt_DATE_OF_BIRTH = DateTime.Today;
            string ls_age = "";

            Object objReturn = null;

            string strSQL;
            strSQL = "SELECT INP_NO,BIRTH_PLACE,NATION,DATE_OF_BIRTH,phone_number_home,PHONE_NUMBER_BUSINESS,NEXT_OF_KIN_PHONE,JIGUAN,XIAN_PLACE";  //����� 2014-2-17 ����,��סַ
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
                    #region �����
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
                    if (ls_INP_NO == null) ls_INP_NO = "";                //סԺ��
                    if (ls_BIRTH_PLACE == null) ls_BIRTH_PLACE = "";      //�����ش���

                    ls_BIRTH_PLACE = ls_BIRTH_PLACE.Trim();
                    ls_BIRTH_PLACE_NAME=ls_BIRTH_PLACE;

                    /* 
                    strSQL = "select dict_name from emr_dict_detail where class_code='AREA' and dict_code='" + ls_BIRTH_PLACE + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_BIRTH_PLACE_NAME = objReturn.ToString();
                    */

                    if (ls_BIRTH_PLACE_NAME == null) ls_BIRTH_PLACE_NAME = "����";     //������
                    if (ls_phone_number_home == null) ls_phone_number_home = "����";      //��ϵ�绰
                    if (ls_NATION == null) ls_NATION = "";                //���� 
                    if (ls_JIGUAN == null) ls_JIGUAN = ""; //����
                    if (ls_XIAN_PLACE == null) ls_XIAN_PLACE = "";//��סַ
                }
            }

            ls_age = "";

            //2.סԺ��Ϣ

            string ls_MARITAL_STATUS = "", ls_OCCUPATION = "", ls_OCCUPATION_NAME = "", ls_MAILING_ADDRESS = "", ls_CHARGE_TYPE = "", ls_SERVICE_AGENCY = "", ls_PAT_ADM_CONDITION = "", ls_PAT_ADM_CONDITION_NAME = "", ls_ADMISSION_CAUSE = "";
            string ls_IDENTITY = "", ls_DEPT_DISCHARGE_FROM = "", ls_DEPT_ADMISSION_TO = "", ls_BED_LABEL = "", ls_DISCHARGE_DATE_TIME = "", ls_DEATH_DATE_TIME="";
            DateTime ld_ADMISSION_DATE_TIME = DateTime.Today;
            DateTime ldt_ADM_WARD_DATE_TIME = DateTime.Today;
            DateTime dtDischarge = DateTime.MinValue;
            strSQL = "SELECT MARITAL_STATUS,OCCUPATION,ADMISSION_DATE_TIME,DISCHARGE_DATE_TIME,MAILING_ADDRESS,CHARGE_TYPE,SERVICE_AGENCY,PAT_ADM_CONDITION,ADMISSION_CAUSE,IDENTITY,DEPT_DISCHARGE_FROM,DEPT_ADMISSION_TO,BED_LABEL,WARD_DATE_TIME,DISCHARGE_DATE_TIME,DEATH_DATE_TIME "; //2013-12-4 ����� ��Ժ����  2014-2-17 ����� ����ʱ��
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
                    #region  �����  
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
                   
                    if (drCurrent["DISCHARGE_DATE_TIME"] != DBNull.Value)  //�Էﶫ 2014-2-27
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
                    
                    //ֵ����
                    if (ls_DISCHARGE_DATE_TIME == null) ls_DISCHARGE_DATE_TIME = "����";    //��Ժʱ�� ����� 2013-12-4
                    if (ls_DEATH_DATE_TIME == null) ls_DEATH_DATE_TIME = "����"; //����� 2014-2-17 ����ʱ�� 
                    if (ls_MARITAL_STATUS == null) ls_MARITAL_STATUS = "����";      //����״��
                    if (ls_OCCUPATION == null) ls_OCCUPATION = "����";              //ְҵ����
                    
                    strSQL = "select dict_name from emr_dict_detail where class_code='OCCUPATION' and dict_code='" + ls_OCCUPATION + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_OCCUPATION_NAME = objReturn.ToString();
                    else
                        ls_OCCUPATION_NAME = ls_OCCUPATION;

                    if ((ls_OCCUPATION_NAME == null) || ls_OCCUPATION_NAME == "") ls_OCCUPATION_NAME = "����";      //ְҵ
                    if (ls_MAILING_ADDRESS == null) ls_MAILING_ADDRESS = "����";    //��ַ
                    if (ls_CHARGE_TYPE == null) ls_CHARGE_TYPE = "����";            //�ѱ�
                    if (ls_SERVICE_AGENCY == null) ls_SERVICE_AGENCY = "����";      //������λ
                    if (ls_ADMISSION_CAUSE == null) ls_ADMISSION_CAUSE = "����";    //סԺĿ��
                    if (ls_IDENTITY == null) ls_IDENTITY = "����";   				  //���
                    //
                    //if (ldt_DATE_OF_BIRTH != null) //����
                        //ls_age = EmrSysPubFunction.GetAge(ld_ADMISSION_DATE_TIME, ldt_DATE_OF_BIRTH);


                    if (ls_PAT_ADM_CONDITION == null) ls_PAT_ADM_CONDITION = " "; //��Ժ�������
                    strSQL = "select dict_name from emr_dict_detail where class_code='RYBQ' and dict_code='" + ls_PAT_ADM_CONDITION + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_PAT_ADM_CONDITION_NAME = objReturn.ToString();
                    if (ls_PAT_ADM_CONDITION_NAME == null) ls_PAT_ADM_CONDITION_NAME = "";    //��Ժ���
                }
            }


            //3.��Ժ��Ϣ
            bool lb_is_in_hospital = false;   //�ж��Ƿ�����Ժ��¼
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

                    if (ls_DIAGNOSIS == null) ls_DIAGNOSIS = " ";    //��Ժ���
                    if (ll_BED_NO < 0) ll_BED_NO = 0;           //����

                    if (ls_DEPT_CODE == null)
                    {
                        //ѡ����Ժ����
                        ls_DEPT_CODE = ls_DEPT_DISCHARGE_FROM;    //���Ҵ���
                        lb_is_in_hospital = false;
                        if (ls_DEPT_CODE == null)
                            ls_DEPT_CODE = " ";    //���Ҵ���
                    }

                }
            }

            if (EmrSysPubVar.getCurPatientVisitID() <= 0)
                ls_DEPT_CODE = ls_DEPT_ADMISSION_TO;

            //��ȡ��������
            strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_DEPT_CODE + "'";
            objReturn = DALUse.GetSingle(strSQL);//��������
            if (objReturn != null)
                ls_DEPT_NAME = objReturn.ToString();
            //������ȡ���ұ�����Ϊ�Ʊ�
            strSQL = "select DEPT_ALIAS from dept_dict where DEPT_CODE='" + ls_DEPT_CODE + "'";
            objReturn = DALUse.GetSingle(strSQL);//���ұ���
            if (objReturn != null)
                ls_DEPT_NAME_ALIAS = objReturn.ToString();
            

            //��ȡ��������
            strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_WARD_CODE + "'";
            //����ҽԺ�޸�,����ֱ����ȡ�����ı���,������д
            objReturn = DALUse.GetSingle(strSQL);//��������
            if (objReturn != null)
                ls_WARD_NAME = objReturn.ToString();

            //4.�����Ϣ             

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


            if (is_diagnose == null) is_diagnose = "��δȷ��";


            //5.��ҳ�е���Ϣ  ��emr_fuye
            #region  ����� 2014-2-17
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
            objPad.PadSetMicroField("��Ҫ���", is_diagnose);


            //if (EmrSysPubVar.getStationName() == "MRBORROWWS")
            if (blMrBorrow)
            {
                //if (DisplayInfo(EmrSysPubVar.getCurPatientID(), EmrSysPubVar.getCurPatientVisitID().ToString(), EmrSysPubVar.getDbUser(), EmrSysPubVar.getDeptCode()))
                if (blFlag)
                {
                    objPad.PadSetMicroField("����", EmrSysPubVar.getCurPatientName());
                    objPad.PadSetMicroField("��λ", ls_SERVICE_AGENCY);
                    objPad.PadSetMicroField("������λ", ls_SERVICE_AGENCY);
                    objPad.PadSetMicroField("סַ", ls_MAILING_ADDRESS);
                    objPad.PadEditReplaceInternal("[סַ]", ls_MAILING_ADDRESS, 1);
                    objPad.PadSetMicroField("�绰", ls_phone_number_home);
                    objPad.PadSetMicroField("�����绰",ls_phone_number_business);
                    objPad.PadSetMicroField("��ϵ�˵绰", ls_next_of_kin_phone);
                }
                else
                {
                    objPad.PadSetMicroField("����", "XXXXXX");
                    objPad.PadSetMicroField("��λ", "XXXXXX");
                    objPad.PadSetMicroField("������λ", "XXXXXX");
                    objPad.PadSetMicroField("סַ", "XXXXXX");
                    objPad.PadEditReplaceInternal("[סַ]", "XXXXXX", 1);
                    objPad.PadSetMicroField("�绰", "XXXXXX");
                    objPad.PadSetMicroField("�����绰", "XXXXXX");
                    objPad.PadSetMicroField("��ϵ�˵绰", "XXXXXX");
                }
            }
            else
            {
                objPad.PadSetMicroField("����", EmrSysPubVar.getCurPatientName());
                objPad.PadSetMicroField("��λ", ls_SERVICE_AGENCY);
                objPad.PadSetMicroField("������λ", ls_SERVICE_AGENCY);
                objPad.PadSetMicroField("סַ", ls_MAILING_ADDRESS);
                objPad.PadEditReplaceInternal("[סַ]", ls_MAILING_ADDRESS, 1);
                objPad.PadSetMicroField("�绰", ls_phone_number_home);
                objPad.PadSetMicroField("�����绰", ls_phone_number_business);
                objPad.PadSetMicroField("��ϵ�˵绰", ls_next_of_kin_phone);

            }
            //objPad.PadSetMicroField("����", EmrSysPubVar.getCurPatientName());
            objPad.PadSetMicroField("�Ա�", EmrSysPubVar.getCurPatientSex());
            objPad.PadSetMicroField("����", ls_age);
            objPad.PadSetMicroField("סԺ��", ls_INP_NO);
            objPad.PadSetMicroField("ID��", EmrSysPubVar.getCurPatientID());
            objPad.PadSetMicroField("����״��", ls_MARITAL_STATUS);
            objPad.PadSetMicroField("����", ls_NATION);
            objPad.PadSetMicroField("ְҵ", ls_OCCUPATION_NAME);
            objPad.PadSetMicroField("ְ��", ls_OCCUPATION_NAME);
            objPad.PadSetMicroField("������", ls_BIRTH_PLACE_NAME);
            objPad.PadSetMicroField("��Ժ����", ld_ADMISSION_DATE_TIME.ToString("yyyy-MM-dd"));
            objPad.PadSetMicroField("��Ժ������", ld_ADMISSION_DATE_TIME.ToString("yyyy��MM��dd��"));
            objPad.PadSetMicroField("��Ժʱ��", ld_ADMISSION_DATE_TIME.ToString("yyyy-MM-dd HH:mm"));
            objPad.PadSetMicroField("סԺĿ��", ls_ADMISSION_CAUSE);
            objPad.PadSetMicroField("��Ժ���", ls_PAT_ADM_CONDITION_NAME);
            //objPad.PadSetMicroField("��λ", ls_SERVICE_AGENCY);
            objPad.PadSetMicroField("���", ls_IDENTITY);
            //objPad.PadSetMicroField("������λ", ls_SERVICE_AGENCY);
           // objPad.PadSetMicroField("סַ", ls_MAILING_ADDRESS);
           // objPad.PadEditReplaceInternal("[סַ]", ls_MAILING_ADDRESS, 1);
            //objPad.PadSetMicroField("�绰", ls_phone_number_home);
            objPad.PadSetMicroField("��������", ldt_DATE_OF_BIRTH.ToString("yyyy��MM��dd��"));  
            objPad.PadSetMicroField("����",ls_JIGUAN);
            objPad.PadSetMicroField("��סַ",ls_XIAN_PLACE);  
            objPad.PadSetMicroField("����ʱ��",ls_DEATH_DATE_TIME);
            objPad.PadSetMicroField("����ԭ��", ls_DEADREASON);

            //��Ժ���ֵ�����
            if (lb_is_in_hospital)
            {
                if (bIsTemplet)//2010-10-30 �жϲ����ļ��Ƿ��½������½�������
                {
                    if (EmrSysPubVar.getCurPatientVisitID() > 0)
                        objPad.PadSetMicroField("����", EmrSysPubFunction.getBedLabelByWard(ll_BED_NO, EmrSysPubVar.getCurPatientWardCode()));
                    objPad.PadSetMicroField("����", ls_DEPT_NAME);
                    objPad.PadSetMicroField("�Ʊ�", ls_DEPT_NAME_ALIAS);
                    objPad.PadSetMicroField("����", ls_WARD_NAME);
                    objPad.PadSetMicroField("����", ls_WARD_CODE);
                    objPad.PadSetMicroField("�ٴ����", ls_DIAGNOSIS);
                    objPad.PadSetMicroField("��Ժ���", ls_DIAGNOSIS);
                    objPad.PadSetMicroField("�������", ldt_ADM_WARD_DATE_TIME.ToString("yyyy-MM-dd"));
                    objPad.PadSetMicroField("���ʱ��", ldt_ADM_WARD_DATE_TIME.ToString("yyyy-MM-dd HH:mm"));
                } 
            }
            else
            {
                if (bIsTemplet)   //��Ժ�Ĵ���Ϊ�� �жϲ����ļ��Ƿ��½������½�������
                {
                    if (EmrSysPubVar.getCurPatientVisitID() > 0 && !string.IsNullOrEmpty(ls_BED_LABEL))
                        objPad.PadSetMicroField("����", ls_BED_LABEL);
                    else
                        objPad.PadSetMicroField("����", " ");
                    //��ȡ��������
                    strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_DEPT_DISCHARGE_FROM + "'";
                    objReturn = DALUse.GetSingle(strSQL);//��������
                    if (objReturn != null)
                        ls_DEPT_NAME = objReturn.ToString();
                    //��ȡ�Ʊ�
                    strSQL = "select DEPT_ALIAS from dept_dict where DEPT_CODE='" + ls_DEPT_DISCHARGE_FROM + "'";
                    objReturn = DALUse.GetSingle(strSQL);//��������
                    if (objReturn != null)
                        ls_DEPT_NAME_ALIAS = objReturn.ToString();
                    objPad.PadSetMicroField("����", ls_DEPT_NAME);
                    objPad.PadSetMicroField("�Ʊ�", ls_DEPT_NAME_ALIAS);
                    //objPad.PadSetMicroField("����", ls_DEPT_NAME);
                }
            }


            //�����ģ��������
            if (bIsTemplet)
            {
                objPad.PadSetMicroField("֪ͨʱ��", EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd HH:mm"));
                //2007.8.23 ǿ����Ժ��¼�ļ�¼ʱ���������Ժʱ���24Сʱ��
                if (lb_is_in_hospital)
                {
                    DateTime dtWrite = EmrSysPubFunction.getServerNow();
                    TimeSpan dtSpan = EmrSysPubFunction.getServerNow() - ldt_ADM_WARD_DATE_TIME;
                    if (dtSpan.TotalHours >= 24)
                        dtWrite = ldt_ADM_WARD_DATE_TIME.AddHours(23);

                    objPad.PadSetMicroField("��¼����", dtWrite.ToString("yyyy-MM-dd"));
                    objPad.PadSetMicroField("��¼ʱ��", dtWrite.ToString("yyyy-MM-dd HH:mm"));
                }
                else
                {
                    DateTime dtWrite = EmrSysPubFunction.getServerNow();
                    TimeSpan dtSpan = EmrSysPubFunction.getServerNow() - ldt_ADM_WARD_DATE_TIME;
                    if (dtSpan.TotalHours >= 24)
                        dtWrite = ldt_ADM_WARD_DATE_TIME.AddHours(23);

                    objPad.PadSetMicroField("��¼����", dtWrite.ToString("yyyy-MM-dd"));
                    objPad.PadSetMicroField("��¼ʱ��", dtWrite.ToString("yyyy-MM-dd HH:mm"));

                }
                objPad.PadSetMicroField("ǩ��", EmrSysPubVar.getOperator());
            }


            //2008-11-10 ���ģ��סԺ�գ���Ժ���� ������
            //DateTime draaaa = EmrSysPubVar.getCurVisitAdmissionDateTime();
            //DateTime dtDischarge = EmrSysPubVar.getCurVisitDischargeDateTime();//0001-1-1 0:00:00
            string patInHospDays = "";
            if (dtDischarge != DateTime.MinValue)
            {
                //����ʵ��סԺ��
                patInHospDays = EmrSysPubFunction.GetBetweenDays(ld_ADMISSION_DATE_TIME, dtDischarge).ToString();
            }
            else
            {
                patInHospDays = EmrSysPubFunction.GetBetweenDays(ld_ADMISSION_DATE_TIME, EmrSysPubFunction.getServerNow()).ToString();
            }
            objPad.PadSetMicroField("סԺ����", patInHospDays);
            objPad.PadSetMicroField("��Ժ����", dtDischarge.ToString("yyyy-MM-dd"));
            objPad.PadSetMicroField("��Ժ������", dtDischarge.ToString("yyyy��MM��dd��"));
            objPad.PadSetMicroField("��Ժʱ��", dtDischarge.ToString("yyyy-MM-dd HH:mm"));


            objPad.PadUpdateMicroField(true);
        }


        // �Էﶫ 2014-2-27 �����㷨����ҳһ��
        public static string GetAge(DateTime dtCurrent, DateTime dtBirth)
        {
            //����
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
                //strReturn = nYears.ToString() + "��";
                strReturn = nyears.ToString() + "��";
            }
            else
            {
                if (nYears > 0)
                {
                    strReturn = nYears.ToString() + "��" + nMonth.ToString() + "��";

                }
                else if (nMonth > 0)
                    strReturn = nMonth.ToString() + " " + nDay.ToString() + "/30" + "��";
                else if (nDay > 0)
                    strReturn = nDay.ToString() + "/30��";
                else
                    strReturn = "1/30��";
            }

            return strReturn;
        }
        /// <summary>
        /// 
        /// 
        /// ������뵥��
        /// </summary>
        /// <param name="objPad"></param>
        /// <param name="bIsTemplet"></param>
        public static void updatePadMicroField1(JHEMR.EmrSysUserCtl.UCEMRPad30 objPad, bool bIsTemplet)
        {
            ////���ƽ���վ����滻
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

            //1.���˻�����Ϣ����
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


                    if (ls_INP_NO == null) ls_INP_NO = "";                //סԺ��
                    if (ls_BIRTH_PLACE == null) ls_BIRTH_PLACE = "";      //�����ش���

                    ls_BIRTH_PLACE = ls_BIRTH_PLACE.Trim();
                    ls_BIRTH_PLACE_NAME = ls_BIRTH_PLACE;

                    /* 
                    strSQL = "select dict_name from emr_dict_detail where class_code='AREA' and dict_code='" + ls_BIRTH_PLACE + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_BIRTH_PLACE_NAME = objReturn.ToString();
                    */

                    if (ls_BIRTH_PLACE_NAME == null) ls_BIRTH_PLACE_NAME = "����";     //������
                    if (ls_phone_number_home == null) ls_phone_number_home = "����";      //��ϵ�绰
                    if (ls_NATION == null) ls_NATION = "";                //���� 
                }
            }

            ls_age = "";

            //2.סԺ��Ϣ

            string ls_MARITAL_STATUS = "", ls_OCCUPATION = "", ls_OCCUPATION_NAME = "", ls_MAILING_ADDRESS = "", ls_CHARGE_TYPE = "", ls_SERVICE_AGENCY = "", ls_PAT_ADM_CONDITION = "", ls_PAT_ADM_CONDITION_NAME = "", ls_ADMISSION_CAUSE = "";
            string ls_IDENTITY = "", ls_DEPT_DISCHARGE_FROM = "", ls_DEPT_ADMISSION_TO = "", ls_BED_LABEL = "", ls_DISCHARGE_DATE_TIME = "";  //2013-12-4 �����
            DateTime ld_ADMISSION_DATE_TIME = DateTime.Today;
            DateTime ldt_ADM_WARD_DATE_TIME = DateTime.Today;
            DateTime dtDischarge = DateTime.MinValue;
            strSQL = "SELECT MARITAL_STATUS,OCCUPATION,ADMISSION_DATE_TIME,DISCHARGE_DATE_TIME,MAILING_ADDRESS,CHARGE_TYPE,SERVICE_AGENCY,PAT_ADM_CONDITION,ADMISSION_CAUSE,IDENTITY,DEPT_DISCHARGE_FROM,DEPT_ADMISSION_TO,BED_LABEL,WARD_DATE_TIME��DISCHARGE_DATE_TIME";
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
                        ls_DISCHARGE_DATE_TIME =  drCurrent["DISCHARGE_DATE_TIME"].ToString(); //����� 2013-12-4
                    if (drCurrent["MARITAL_STATUS"] != DBNull.Value)
                        ls_MARITAL_STATUS = drCurrent["MARITAL_STATUS"].ToString();
                    if (drCurrent["OCCUPATION"] != DBNull.Value)
                        ls_OCCUPATION = drCurrent["OCCUPATION"].ToString();
                    if (drCurrent["ADMISSION_DATE_TIME"] != DBNull.Value)
                    {
                        ld_ADMISSION_DATE_TIME = Convert.ToDateTime(drCurrent["ADMISSION_DATE_TIME"].ToString());
                        ldt_ADM_WARD_DATE_TIME = ld_ADMISSION_DATE_TIME;
                    }

                    if (drCurrent["DISCHARGE_DATE_TIME"] != DBNull.Value) // �Էﶫ 2014-2-27
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

                    //ֵ����
                    if (ls_DISCHARGE_DATE_TIME == null) ls_DISCHARGE_DATE_TIME = "����";    //�����   2013-12-4 
                    if (ls_MARITAL_STATUS == null) ls_MARITAL_STATUS = "����";      //����״��
                    if (ls_OCCUPATION == null) ls_OCCUPATION = "����";              //ְҵ����
                    
                    strSQL = "select dict_name from emr_dict_detail where class_code='OCCUPATION' and dict_code='" + ls_OCCUPATION + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_OCCUPATION_NAME = objReturn.ToString();
                    else
                        ls_OCCUPATION_NAME = ls_OCCUPATION;

                    if ((ls_OCCUPATION_NAME == null) || ls_OCCUPATION_NAME == "") ls_OCCUPATION_NAME = "����";      //ְҵ
                    if (ls_MAILING_ADDRESS == null) ls_MAILING_ADDRESS = "����";    //��ַ
                    if (ls_CHARGE_TYPE == null) ls_CHARGE_TYPE = "����";            //�ѱ�
                    if (ls_SERVICE_AGENCY == null) ls_SERVICE_AGENCY = "����";      //������λ
                    if (ls_ADMISSION_CAUSE == null) ls_ADMISSION_CAUSE = "����";    //סԺĿ��
                    if (ls_IDENTITY == null) ls_IDENTITY = "����";   				  //���
                    if (ls_PAT_ADM_CONDITION == null) ls_PAT_ADM_CONDITION = " "; //��Ժ�������
                    strSQL = "select dict_name from emr_dict_detail where class_code='RYBQ' and dict_code='" + ls_PAT_ADM_CONDITION + "'";
                    objReturn = DALUse.GetSingle(strSQL);
                    if (objReturn != null)
                        ls_PAT_ADM_CONDITION_NAME = objReturn.ToString();
                    if (ls_PAT_ADM_CONDITION_NAME == null) ls_PAT_ADM_CONDITION_NAME = "";    //��Ժ���
                }
            }


            //3.��Ժ��Ϣ
            bool lb_is_in_hospital = false;   //�ж��Ƿ�����Ժ��¼
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

                    if (ls_DIAGNOSIS == null) ls_DIAGNOSIS = " ";    //��Ժ���
                    if (ll_BED_NO < 0) ll_BED_NO = 0;           //����

                    if (ls_DEPT_CODE == null)
                    {
                        //ѡ����Ժ����
                        ls_DEPT_CODE = ls_DEPT_DISCHARGE_FROM;    //���Ҵ���
                        lb_is_in_hospital = false;
                        if (ls_DEPT_CODE == null)
                            ls_DEPT_CODE = " ";    //���Ҵ���
                    }

                }
            }

            if (EmrSysPubVar.getCurPatientVisitID() <= 0)
                ls_DEPT_CODE = ls_DEPT_ADMISSION_TO;

            //��ȡ��������
            strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_DEPT_CODE + "'";
            objReturn = DALUse.GetSingle(strSQL);//��������
            if (objReturn != null)
                ls_DEPT_NAME = objReturn.ToString();
            //������ȡ���ұ�����Ϊ�Ʊ�
            strSQL = "select DEPT_ALIAS from dept_dict where DEPT_CODE='" + ls_DEPT_CODE + "'";
            objReturn = DALUse.GetSingle(strSQL);//���ұ���
            if (objReturn != null)
                ls_DEPT_NAME_ALIAS = objReturn.ToString();


            //��ȡ��������
            strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_WARD_CODE + "'";
            //����ҽԺ�޸�,����ֱ����ȡ�����ı���,������д
            objReturn = DALUse.GetSingle(strSQL);//��������
            if (objReturn != null)
                ls_WARD_NAME = objReturn.ToString();

            //4.�����Ϣ             

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


            if (is_diagnose == null) is_diagnose = "��δȷ��";

            //////////////////////////////////////////////////////////////////////////////////////
            objPad.PadSetMicroField("��Ҫ���", is_diagnose);


          
                objPad.PadSetMicroField("����", EmrSysPubVar.getCurPatientName());
                objPad.PadSetMicroField("��λ", ls_SERVICE_AGENCY);
                objPad.PadSetMicroField("������λ", ls_SERVICE_AGENCY);
                objPad.PadSetMicroField("סַ", ls_MAILING_ADDRESS);
                objPad.PadEditReplaceInternal("[סַ]", ls_MAILING_ADDRESS, 1);
                objPad.PadSetMicroField("�绰", ls_phone_number_home);

            objPad.PadSetMicroField("�Ա�", EmrSysPubVar.getCurPatientSex());
            objPad.PadSetMicroField("����", ls_age);
            objPad.PadSetMicroField("סԺ��", ls_INP_NO);
            objPad.PadSetMicroField("ID��", EmrSysPubVar.getCurPatientID());
            objPad.PadSetMicroField("����״��", ls_MARITAL_STATUS);
            objPad.PadSetMicroField("����", ls_NATION);
            objPad.PadSetMicroField("ְҵ", ls_OCCUPATION_NAME);
            objPad.PadSetMicroField("ְ��", ls_OCCUPATION_NAME);
            objPad.PadSetMicroField("������", ls_BIRTH_PLACE_NAME);
            objPad.PadSetMicroField("��Ժ����", ld_ADMISSION_DATE_TIME.ToString("yyyy-MM-dd"));
            objPad.PadSetMicroField("��Ժ������", ld_ADMISSION_DATE_TIME.ToString("yyyy��MM��dd��"));
            objPad.PadSetMicroField("��Ժʱ��", ld_ADMISSION_DATE_TIME.ToString("yyyy-MM-dd HH:mm"));
            objPad.PadSetMicroField("סԺĿ��", ls_ADMISSION_CAUSE);
            objPad.PadSetMicroField("��Ժ���", ls_PAT_ADM_CONDITION_NAME);
            //objPad.PadSetMicroField("��λ", ls_SERVICE_AGENCY);
            objPad.PadSetMicroField("���", ls_IDENTITY);
            //objPad.PadSetMicroField("������λ", ls_SERVICE_AGENCY);
            // objPad.PadSetMicroField("סַ", ls_MAILING_ADDRESS);
            // objPad.PadEditReplaceInternal("[סַ]", ls_MAILING_ADDRESS, 1);
            //objPad.PadSetMicroField("�绰", ls_phone_number_home);
            objPad.PadSetMicroField("��������", ldt_DATE_OF_BIRTH.ToString("yyyy��MM��dd��"));


            //��Ժ���ֵ�����
            if (lb_is_in_hospital)
            {
                if (EmrSysPubVar.getCurPatientVisitID() > 0)
                    objPad.PadSetMicroField("����", EmrSysPubFunction.getBedLabelByWard(ll_BED_NO, EmrSysPubVar.getCurPatientWardCode()));
                objPad.PadSetMicroField("����", ls_DEPT_NAME);
                objPad.PadSetMicroField("�Ʊ�", ls_DEPT_NAME_ALIAS);
                objPad.PadSetMicroField("����", ls_WARD_NAME);
                objPad.PadSetMicroField("����", ls_WARD_CODE);
                objPad.PadSetMicroField("�ٴ����", ls_DIAGNOSIS);
                objPad.PadSetMicroField("��Ժ���", ls_DIAGNOSIS);
                objPad.PadSetMicroField("�������", ldt_ADM_WARD_DATE_TIME.ToString("yyyy-MM-dd"));
                objPad.PadSetMicroField("���ʱ��", ldt_ADM_WARD_DATE_TIME.ToString("yyyy-MM-dd HH:mm"));
            }
            else
            {
                if (bIsTemplet)   //��Ժ�Ĵ���Ϊ��
                {
                    if (EmrSysPubVar.getCurPatientVisitID() > 0 && !string.IsNullOrEmpty(ls_BED_LABEL))
                        objPad.PadSetMicroField("����", ls_BED_LABEL);
                    else
                        objPad.PadSetMicroField("����", " ");
                    //��ȡ��������
                    strSQL = "select DEPT_NAME from dept_dict where DEPT_CODE='" + ls_DEPT_DISCHARGE_FROM + "'";
                    objReturn = DALUse.GetSingle(strSQL);//��������
                    if (objReturn != null)
                        ls_DEPT_NAME = objReturn.ToString();
                    //��ȡ�Ʊ�
                    strSQL = "select DEPT_ALIAS from dept_dict where DEPT_CODE='" + ls_DEPT_DISCHARGE_FROM + "'";
                    objReturn = DALUse.GetSingle(strSQL);//��������
                    if (objReturn != null)
                        ls_DEPT_NAME_ALIAS = objReturn.ToString();
                    objPad.PadSetMicroField("����", ls_DEPT_NAME);
                    objPad.PadSetMicroField("�Ʊ�", ls_DEPT_NAME_ALIAS);
                    //objPad.PadSetMicroField("����", ls_DEPT_NAME);
                }
            }


            //�����ģ��������
            if (bIsTemplet)
            {
                objPad.PadSetMicroField("֪ͨʱ��", EmrSysPubFunction.getServerNow().ToString("yyyy-MM-dd HH:mm"));
                //2007.8.23 ǿ����Ժ��¼�ļ�¼ʱ���������Ժʱ���24Сʱ��
                if (lb_is_in_hospital)
                {
                    DateTime dtWrite = EmrSysPubFunction.getServerNow();
                    TimeSpan dtSpan = EmrSysPubFunction.getServerNow() - ldt_ADM_WARD_DATE_TIME;
                    if (dtSpan.TotalHours >= 24)
                        dtWrite = ldt_ADM_WARD_DATE_TIME.AddHours(23);

                    objPad.PadSetMicroField("��¼����", dtWrite.ToString("yyyy-MM-dd"));
                    objPad.PadSetMicroField("��¼ʱ��", dtWrite.ToString("yyyy-MM-dd HH:mm"));
                }
                else
                {
                    DateTime dtWrite = EmrSysPubFunction.getServerNow();
                    TimeSpan dtSpan = EmrSysPubFunction.getServerNow() - ldt_ADM_WARD_DATE_TIME;
                    if (dtSpan.TotalHours >= 24)
                        dtWrite = ldt_ADM_WARD_DATE_TIME.AddHours(23);

                    objPad.PadSetMicroField("��¼����", dtWrite.ToString("yyyy-MM-dd"));
                    objPad.PadSetMicroField("��¼ʱ��", dtWrite.ToString("yyyy-MM-dd HH:mm"));

                }
                objPad.PadSetMicroField("ǩ��", EmrSysPubVar.getOperator());
            }


            //2008-11-10 ���ģ��סԺ�գ���Ժ���� ������
            //DateTime draaaa = EmrSysPubVar.getCurVisitAdmissionDateTime();
            //DateTime dtDischarge = EmrSysPubVar.getCurVisitDischargeDateTime();//0001-1-1 0:00:00
            string patInHospDays = "";
            if (dtDischarge != DateTime.MinValue)
            {
                //����ʵ��סԺ��
                patInHospDays = EmrSysPubFunction.GetBetweenDays(ld_ADMISSION_DATE_TIME, dtDischarge).ToString();
            }
            else
            {
                patInHospDays = EmrSysPubFunction.GetBetweenDays(ld_ADMISSION_DATE_TIME, EmrSysPubFunction.getServerNow()).ToString();
            }
            objPad.PadSetMicroField("סԺ����", patInHospDays);
            objPad.PadSetMicroField("��Ժ����", dtDischarge.ToString("yyyy-MM-dd"));
            objPad.PadSetMicroField("��Ժ������", dtDischarge.ToString("yyyy��MM��dd��"));
            objPad.PadSetMicroField("��Ժʱ��", dtDischarge.ToString("yyyy-MM-dd HH:mm"));


            objPad.PadUpdateMicroField(true);
        }
        /// <summary>
        ///��������: replaceVitalSignsRecExist
        ///    ����: �滻�Ѿ�����������������
        ///    ����: ������  2007��1��26��
        ///����޸�:     
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
            if (strVitalSigns == "����ѹ")
            {
                strList[3] = "Ѫѹhigh";
            }
            else if(strVitalSigns=="����ѹ")
            {
                strList[3] = "ѪѹLow";
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
                            if(strVitalSigns=="����")
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
                //�滻סԺ��
                objPad.PadEditReplaceInternal("[סԺ��]", EmrSysPubVar.getCurPatientVisitID().ToString(), 1);

                //�滻�������
                string strSQL = "select * from diagnosis where diagnosis_type=1 and patient_id='" + EmrSysPubVar.getCurPatientID() + "' and visit_id=" + EmrSysPubVar.getCurPatientVisitID().ToString();
                DataTable dtFirstDiag = DALUse.Query(strSQL).Tables[0];
                string strFirstDiag = " ";
                if (dtFirstDiag.Rows.Count > 0)
                    strFirstDiag = dtFirstDiag.Rows[0]["diagnosis_desc"].ToString();
                objPad.PadEditReplaceInternal("[�������]", strFirstDiag, 1);
                //�滻�������
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
                        strContent += nIndex.ToString() + "." + drCurrent["�������"].ToString();
                        nIndex++;
                    }

                    switch (strDiagnoseClass)
                    {
                        case "2":
                            {
                                if (strContent.Length > 0)
                                    objPad.PadEditReplaceInternal("[�������]", strContent, 1);
                                else
                                    objPad.PadEditReplaceInternal("[�������]", " ", 1);
                            }
                            break;
                        case "3":
                            {
                                if (strContent.Length > 0)
                                    objPad.PadEditReplaceInternal("[������]", strContent, 1);
                                else
                                    objPad.PadEditReplaceInternal("[������]", " ", 1);
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
                        objPad.PadEditReplaceInternal("[��ʩ����]", (strTmp == "" ? " " : strTmp), 1);

                        strTmp = "";
                        if (drOperation["surgeon"] != DBNull.Value)
                            strTmp = drOperation["surgeon"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[����ҽ��]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["first_assistant"] != DBNull.Value)
                            strTmp = drOperation["first_assistant"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[һ��]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["second_assistant"] != DBNull.Value)
                            strTmp = drOperation["second_assistant"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[����]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["third_assistant"] != DBNull.Value)
                            strTmp = drOperation["third_assistant"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[����]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["first_operation_nurse"] != DBNull.Value)
                            strTmp = drOperation["first_operation_nurse"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[������ʿ]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["anesthesia_method"] != DBNull.Value)
                            strTmp = drOperation["anesthesia_method"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[������]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["anesthesia_doctor"] != DBNull.Value)
                            strTmp = drOperation["anesthesia_doctor"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[������]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["START_DATE_TIME"] != DBNull.Value)
                            strTmp = drOperation["START_DATE_TIME"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[��������]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["diag_before_operation"] != DBNull.Value)
                            strTmp = drOperation["diag_before_operation"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[��ǰ���]", (strTmp == "" ? " " : strTmp), 1);
                        strTmp = "";
                        if (drOperation["diag_after_operation"] != DBNull.Value)
                            strTmp = drOperation["diag_after_operation"].ToString();
                        else
                            strTmp = " ";
                        objPad.PadEditReplaceInternal("[�������]", (strTmp == "" ? " " : strTmp), 1);

                    }
                    else
                    {
                        objPad.PadEditReplaceInternal("[��ʩ����]", " ", 1);
                        objPad.PadEditReplaceInternal("[����ҽ��]", " ", 1);
                        objPad.PadEditReplaceInternal("[һ��]", " ", 1);
                        objPad.PadEditReplaceInternal("[����]", " ", 1);
                        objPad.PadEditReplaceInternal("[����]", " ", 1);
                        objPad.PadEditReplaceInternal("[������ʿ]", " ", 1);
                        objPad.PadEditReplaceInternal("[������]", " ", 1);
                        objPad.PadEditReplaceInternal("[������]", " ", 1);
                        objPad.PadEditReplaceInternal("[��������]", " ", 1);
                        objPad.PadEditReplaceInternal("[��ǰ���]", " ", 1);
                        objPad.PadEditReplaceInternal("[�������]", " ", 1);
                    }
                }
                else
                {
                    objPad.PadEditReplaceInternal("[��ʩ����]", " ", 1);
                    objPad.PadEditReplaceInternal("[����ҽ��]", " ", 1);
                    objPad.PadEditReplaceInternal("[һ��]", " ", 1);
                    objPad.PadEditReplaceInternal("[����]", " ", 1);
                    objPad.PadEditReplaceInternal("[����]", " ", 1);
                    objPad.PadEditReplaceInternal("[������ʿ]", " ", 1);
                    objPad.PadEditReplaceInternal("[������]", " ", 1);
                    objPad.PadEditReplaceInternal("[������]", " ", 1);
                    objPad.PadEditReplaceInternal("[��������]", " ", 1);
                    objPad.PadEditReplaceInternal("[��ǰ���]", " ", 1);
                    objPad.PadEditReplaceInternal("[�������]", " ", 1);
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }

        #endregion �滻�����������Ѿ����ڵ�����

        #region ��дסԺ־�����(��׼��)
        /// <summary>
        ///��������: writePadDiagnoseGEY
        ///    ����: ��дסԺ־�����(�㶫ʡ�ڶ�����ҽԺ)
        ///    ����: ����ΰ  2007��10��22��
        ///����޸�: ����ΰ  2008��02��28��
        /// </summary>
        /// <param name="objPad"></param>
        /// <returns></returns>
        public static bool writePadDiagnose(JHEMR.EmrSysUserCtl.UCEMRPad30 objPad)
        {
            //���ǩ����ΪCAǩ��   ����  20140312
            //1���ж��Ƿ�ΪCA�û� flag1
            //2������ǩ������CAǩ��
            bool flag1 = false;
            flag1 = IsCAUser();
            string strSQL = "select a.three_day_diagnosis_name from pat_visit a where a.patient_id='" + EmrSysPubVar.getCurPatientID() + "' and a.visit_id='" + EmrSysPubVar.getCurPatientVisitID().ToString() + "'";
            object obj = DALUse.GetSingle(strSQL);
            if (obj != null)
                objPad.PadEditReplaceInternal("[ȷ�����]", obj.ToString(), 1);
            #region ��� (�����ϣ��������)
            if (objPad.PadFindField("���", 1, 2, true))
            {
                //��ȡ��ǰ���ı��
                int nbaselineindex = -1; 	//���к�
                int ncellindex = -1; 		//��Ԫ���
                int nlineindex = -1; 		//�к�
                int nfieldelemindex = -1; //Ԫ�����
                int ncharpos = -1;		   //�ַ�λ��
                short ndiagnoselevel = -1; //�������Ԫ�صļ���,���ڹ̶�Ԫ��,���������<0��,��ֻ��Ϊ�ڵ����,���������

                objPad.PadGetCurCursorPos(ref nbaselineindex, ref ncellindex, ref nlineindex, ref nfieldelemindex, ref ncharpos, true);

                //Ҫ��֤һ��ֵ�Ƿ���Ч
                if (nbaselineindex < 0)
                    return false;

                //������ǰ�ǲ����ڱ����
                if (ncellindex < 0)
                    return false;

                //��ɾ��������Ѿ��еļ�¼,Ȼ����¼�¼д�������
                //�õ���ǰ�е��к�
                int ntablerows = 0;
                int ntablecols = 0;
                ntablerows = objPad.PadGetObjectCount(nbaselineindex, ncellindex, nlineindex, 2);
                ntablecols = objPad.PadGetObjectCount(nbaselineindex, ncellindex, nlineindex, 3);
                //���ñ��ɱ༭
                objPad.PadTableSelect();
                objPad.PadEditLineEditMode();

                for (int i = 0; i < ntablerows - 1; i++)
                {
                    objPad.PadSetSel(nbaselineindex, ntablecols, 0, 0, 0, nbaselineindex, ntablecols, 0, 0, 0);
                    objPad.PadTableDeleteRow();
                }
                ntablerows = 1;

                //�������һ��
                objPad.PadSetSel(nbaselineindex, 0, 0, 0, 0, nbaselineindex, 0, 0, 0, 0);
                objPad.PadTableInsertRowBottom();
                objPad.PadSetSel(nbaselineindex, 0, 0, 0, 0, nbaselineindex, 0, 0, 0, 0);
                objPad.PadTableDeleteRow();
                //��λ����һ��
                objPad.PadSetSel(nbaselineindex, 0, 0, 0, 0, nbaselineindex, 0, 0, 0, 0);

                //��ǩ���

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

                //�����ʾ����	
                int li_temp_row = 0;

                /////////------------------������-----------------////////////////
                int nrow = 0;
                int ntotalrow = 0;
                int nmainno = 0; //��������
                int nsubno = 0;//����Ϻ�
                string ndiagtext;  		//�����ʾ������
                int nsigncount = 1;       //ǩ������

                //��������ϸ
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
                        DataRow[] dr = objTableDiagnosis.Select("�ϼ�ҽʦ is null");
                        if (dr.Length > 0)
                            bModifier = false;
                        else
                            bModifier = true;

                        dr = objTableDiagnosis.Select("����ҽʦ is null");
                        if (dr.Length > 0)
                            bSupper = false;
                        else
                            bSupper = true;
                        int x = 1;
                        foreach (DataRow drDiagnosis in objTableDiagnosis.Rows)
                        {
                            //������,������ֵ
                            if (ntotalrow == ntablerows)
                            {
                                objPad.PadTableInsertRowBottom();
                                ntablerows++;
                            }
                            ntotalrow++;
                            //�������
                            if (nrow == 1)
                            {
                                objPad.PadSetSel(nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0, nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0);
                                //qzz20110408 ȥ���������
                                //objPad.PadInsertField(drDiagnosis["�������"].ToString(), drDiagnosis["�������"].ToString() +" (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                                objPad.PadInsertField(drDiagnosis["�������"].ToString(), drDiagnosis["�������"].ToString(), 2, 2, 1);//������ʱ��spf
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
                            //ֻ��һ������ϻ�����ϲ�д���
                            foreach (DataRow drCur in objTableDiagnosis.Rows)
                            {
                                if (Convert.ToInt32(drCur["���"].ToString()) > 1)
                                {
                                    nmainno = Convert.ToInt32(drCur["���"].ToString());
                                }
                                if (drCur["���"].ToString() == drDiagnosis["���"].ToString())
                                {
                                    if (Convert.ToInt32(drCur["�Ӻ�"].ToString()) > 0)
                                    {
                                        nsubno = Convert.ToInt32(drCur["�Ӻ�"].ToString());
                                    }
                                }
                            }
                            if (nmainno > 1)
                                ndiagtext = drDiagnosis["���"].ToString() + ".";
                            int intLevel = 0;
                            string strSpace = "    ";
                            GetLevel(objTableDiagnosis, drDiagnosis["ID"].ToString(), ref intLevel);
                            for (int i = 1; i < intLevel; i++)
                            {
                                strSpace += "    ";
                            }

                            if (nsubno > 1 && drDiagnosis["�Ӻ�"].ToString() != "0" && intLevel <= 2)
                            {

                                //ndiagtext = strSpace + x.ToString() + "." + drDiagnosis["�������"].ToString() +" (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                                //x++;
                                ndiagtext = strSpace  + drDiagnosis["�������"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                                x++;
                            }
                            else if (nsubno == 1 && drDiagnosis["�Ӻ�"].ToString() != "0" || intLevel > 2)
                                ndiagtext = strSpace + drDiagnosis["�������"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                            else
                            {
                                ndiagtext = strSpace + ndiagtext + drDiagnosis["�������"].ToString() +" (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                            }
                            objPad.PadInsertField(drDiagnosis["�������"].ToString() + nrow.ToString(), ndiagtext, ndiagnoselevel, 2, 1);
                            nrow++;
                            //////////////////////////////////////////////////////////////////////////////////////////////
                            if (nrow == objTableDiagnosis.Rows.Count+1)
                            {
                                //ls_temp = drDiagnosis["ҽʦ"].ToString();
                                //if (ls_temp.Length > 0)
                                //    ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);
                                ls_temp = drDiagnosis["ҽʦ"].ToString();
                                if (ls_temp.Length > 0)
                                    ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);

                                if (drDiagnosis["�ϼ�ҽʦ"] != DBNull.Value)
                                {
                                    if (drDiagnosis["�ϼ�ҽʦ"].ToString().Trim().Length > 0)
                                        ls_temp = EmrSysPubFunction.getUserName(drDiagnosis["�ϼ�ҽʦ"].ToString(),false) + "/" + ls_temp;
                                }

                                if (drDiagnosis["����ҽʦ"] != DBNull.Value)
                                {
                                    if (drDiagnosis["����ҽʦ"].ToString().Trim().Length > 0)
                                    {
                                        ls_temp = EmrSysPubFunction.getUserName(drDiagnosis["����ҽʦ"].ToString(),false) + "/" + ls_temp;
                                    }
                                }
                                else
                                {
                                    if (drDiagnosis["ʵϰҽʦ"] != DBNull.Value)
                                    {
                                        if (drDiagnosis["ʵϰҽʦ"].ToString().Trim().Length > 0)
                                            ls_temp += "/" + drDiagnosis["ʵϰҽʦ"].ToString();
                                    }
                                }

                                if (ls_temp.Length > 0)
                                {
                                    //������,������ֵ
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
                                    objPad.PadSetSel(nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0, nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0);//2013-12-16  ���  ������ǩ����λ��
                                    
                                       
                                    //CA�û�ͼƬǩ��   ����  20140312
                                        if (flag1)
                                        {
                                            insertSignPic(objPad, drDiagnosis["ҽʦ"].ToString(), EmrSysPubFunction.getUserName(drDiagnosis["ҽʦ"].ToString(), false));
                                        }
                                        else
                                        {
                                            objPad.PadInsertField("���ǩ��" + nsigncount.ToString(), ls_temp, ndiagnoselevel, 2, 1);
                                        }
                                    objPad.PadLineAlignRight();
                                    //������,������ֵ
                                    //nrow++;
                                    //li_temp_row++;
                                    //if (li_temp_row >= ntablerows)
                                    //{
                                    //    objPad.PadTableInsertRowBottom();
                                    //    ntablerows++;
                                    //}
                                    //objPad.PadSetSel(nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0, nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0);
                                    //objPad.PadInsertField("���ǩ��ʱ��" + nsigncount.ToString(), Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") , ndiagnoselevel, 2, 1);
                                    objPad.PadLineAlignRight();
                                    nsigncount++;
                                    li_temp_row++;
                                }
                            }
                        }// end of Diagnosis foreach
                    }//table>0
                }//end foreach of �������









                //            //ҽ��ǩ��20081120spf
                //            if (nrow == objTableDiagnosis.Rows.Count + 1)
                //            {
                //                ls_temp = drDiagnosis["ҽʦ"].ToString();
                //                if (ls_temp.Length > 0)
                //                    ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);



                //                //20100901ǩ�� ��ʵϰҽ��
                //                if (drDiagnosis["ʵϰҽʦ"].ToString().Trim().Length > 0)
                //                {
                //                    ls_temp += "/" + drDiagnosis["ʵϰҽʦ"].ToString();
                //                }

                //                //qzz20110322ȡ�����ǩ��
                //                if (ls_temp.Length > 0)
                //                {
                //                    //������,������ֵ
                //                    if (ntotalrow == ntablerows)
                //                    {
                //                        objPad.PadTableInsertRowBottom();
                //                        ntablerows++;
                //                    }
                //                    //ntotalrow++;
                //                    //objPad.PadSetSel(nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0, nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0);
                //                    //objPad.PadInsertField("���ǩ��ʱ��" + nsigncount.ToString(), Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy��MM��dd��"), ndiagnoselevel, 2, 1);
                //                    //objPad.PadLineAlignRight();

                //                    //nsigncount++;

                //                    if (ntotalrow == ntablerows)
                //                    {
                //                        objPad.PadTableInsertRowBottom();
                //                        ntablerows++;
                //                    }
                //                    ntotalrow++;
                //                    objPad.PadSetSel(nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0, nbaselineindex, (ntablerows - 1) * ntablecols, 0, 0, 0);
                //                    objPad.PadInsertField("���ǩ��" + nsigncount.ToString(), ls_temp, ndiagnoselevel, 2, 1);
                //                    objPad.PadLineAlignRight();
                //                    nsigncount++;
                //                    li_temp_row++;
                //                }
                //            }


                //        }//end foreach
                //    }
                //}


                /////////------------------�������-----------------////////////////

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
                            //������,������ֵ
                            if (li_temp_row >= ntablerows)
                            {
                                objPad.PadTableInsertRowBottom();
                                ntablerows++;
                            }

                            //�������
                            if (nrow == 1)
                            {

                                objPad.PadSetSel(nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0, nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0);
                                //qzz20110408 ȥ���������
                                //objPad.PadInsertField(drDiagnosis["�������"].ToString(), drDiagnosis["�������"].ToString() + "��(" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")", 2, 2, 1);//�����������spf
                                objPad.PadInsertField(drDiagnosis["�������"].ToString(), drDiagnosis["�������"].ToString(), 2, 2, 1);//�����������spf
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
                            //ֻ��һ������ϻ�����ϲ�д���
                            foreach (DataRow drCur in objTableDiagnosis.Rows)
                            {
                                if (Convert.ToInt32(drCur["���"].ToString()) > 1)
                                {
                                    nmainno = Convert.ToInt32(drCur["���"].ToString());
                                }
                                if (drCur["���"].ToString() == drDiagnosis["���"].ToString())
                                {
                                    if (Convert.ToInt32(drCur["�Ӻ�"].ToString()) > 0)
                                    {
                                        nsubno = Convert.ToInt32(drCur["�Ӻ�"].ToString());
                                    }
                                }
                            }
                            if (nmainno > 1)
                                ndiagtext = drDiagnosis["���"].ToString() + ".";
                            int intLevel = 0;
                            string strSpace = "    ";
                            GetLevel(objTableDiagnosis, drDiagnosis["ID"].ToString(), ref intLevel);
                            for (int i = 1; i < intLevel; i++)
                            {
                                strSpace += "    ";
                            }

                            if (nsubno > 1 && drDiagnosis["�Ӻ�"].ToString() != "0" && intLevel <= 2)
                            {
                                //ndiagtext = strSpace + y.ToString() + "." + drDiagnosis["�������"].ToString()+ " (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                                ndiagtext = strSpace  + drDiagnosis["�������"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                                y++;
                            }
                            else if (nsubno == 1 && drDiagnosis["�Ӻ�"].ToString() != "0" || intLevel > 2)
                                ndiagtext = strSpace + drDiagnosis["�������"].ToString();
                            else
                            {
                                ndiagtext = strSpace + ndiagtext + drDiagnosis["�������"].ToString() +"(" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                            }
                            objPad.PadInsertField(drDiagnosis["�������"].ToString() + nrow.ToString(), ndiagtext, ndiagnoselevel, 2, 1);
                            nrow++;
                            li_temp_row++;
                            //if (nrow == objTableDiagnosis.Rows.Count + 1)
                            //{
                            //    ls_temp = drDiagnosis["ҽʦ"].ToString();
                            //    if (ls_temp.Length > 0)
                            //        ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);

                            //    //20100901ǩ�� ��ʵϰҽ��
                            //    if (drDiagnosis["ʵϰҽʦ"].ToString().Trim().Length > 0)
                            //    {
                            //        ls_temp += "/" + drDiagnosis["ʵϰҽʦ"].ToString();
                            //    }





                                 if (nrow == objTableDiagnosis.Rows.Count+1)
                            {
                                //ls_temp = drDiagnosis["ҽʦ"].ToString();
                                //if (ls_temp.Length > 0)
                                //    ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);
                                ls_temp = drDiagnosis["ҽʦ"].ToString();
                                if (ls_temp.Length > 0)
                                    ls_temp = EmrSysPubFunction.getUserName(ls_temp, false);

                                if (drDiagnosis["�ϼ�ҽʦ"] != DBNull.Value)
                                {
                                    if (drDiagnosis["�ϼ�ҽʦ"].ToString().Trim().Length > 0)
                                        ls_temp = EmrSysPubFunction.getUserName(drDiagnosis["�ϼ�ҽʦ"].ToString(),false) + "/" + ls_temp;
                                }

                                if (drDiagnosis["����ҽʦ"] != DBNull.Value)
                                {
                                    if (drDiagnosis["����ҽʦ"].ToString().Trim().Length > 0)
                                    {
                                        ls_temp = EmrSysPubFunction.getUserName(drDiagnosis["����ҽʦ"].ToString(),false) + "/" + ls_temp;
                                    }
                                }
                                else
                                {
                                    if (drDiagnosis["ʵϰҽʦ"] != DBNull.Value)
                                    {
                                        if (drDiagnosis["ʵϰҽʦ"].ToString().Trim().Length > 0)
                                            ls_temp += "/" + drDiagnosis["ʵϰҽʦ"].ToString();
                                    }
                                }







                                if (ls_temp.Length > 0)
                                {
                                    //������,������ֵ
                                    //qzz20110322ȡ�����ǩ��
                                    if (li_temp_row >= ntablerows)
                                    {
                                        objPad.PadTableInsertRowBottom();
                                        ntablerows++;
                                    }
                                    //objPad.PadSetSel(nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0, nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0);
                                    //objPad.PadInsertField("���ǩ��ʱ��" + nsigncount.ToString(), Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy��MM��dd��"), ndiagnoselevel, 2, 1);
                                    //objPad.PadLineAlignRight();
                                    //������,������ֵ
                                    //nrow++;
                                    //li_temp_row++;
                                    if (li_temp_row >= ntablerows)
                                    {
                                        objPad.PadTableInsertRowBottom();
                                        ntablerows++;
                                    }
                                    objPad.PadSetSel(nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0, nbaselineindex, li_temp_row * ntablecols + 1, 0, 0, 0);
                                  
                                    //CA�û�ͼƬǩ��   ����  20140312
                                    if (flag1)
                                    {
                                        insertSignPic(objPad, drDiagnosis["ҽʦ"].ToString(), EmrSysPubFunction.getUserName(drDiagnosis["ҽʦ"].ToString(), false));
                                    }
                                    else
                                    {
                                        objPad.PadInsertField("���ǩ��" + nsigncount.ToString(), ls_temp, ndiagnoselevel, 2, 1);
                                    }
                                    objPad.PadLineAlignRight();
                                    nsigncount++;
                                    li_temp_row++;
                                }
                            }
                        }// end of Diagnosis foreach
                    }//table>0
                }//end foreach of �������

                objPad.PadSetSel(nbaselineindex, 0, 0, 0, 0, nbaselineindex, 0, 0, 0, 0);

                //Ҫ���ñ��ֻ��
                //���ñ��ɱ༭
                //Ҫ��ձ༭����������������ǲ������û������ġ�
                objPad.PadCleanUndoBuffer();
                objPad.PadTableSelect();
                objPad.PadEditLineReadOnly();
                objPad.PadSetSel(nbaselineindex, 0, 0, 0, 0, nbaselineindex, 0, 0, 0, 0);
            }//���

            #endregion

            #region ��Ժ���

            if (objPad.PadFindField("��Ժ���", -1, 2, true))
            {
                /////////------------------��Ժ���-----------------////////////////
                //��ȡ��ǰ���ı��
                int nbaselineindex = -1; 	//���к�
                int ncellindex = -1; 		//��Ԫ���
                int nlineindex = -1; 		//�к�
                int nfieldelemindex = -1; //Ԫ�����
                int ncharpos = -1;		   //�ַ�λ��

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
                            //ֻ��һ������ϻ�����ϲ�д���
                            int nmainno = 0; //��������
                            int nsubno = 0;//����Ϻ�
                            string ndiagtext = "";
                            foreach (DataRow drCur in objTableDiagnosis.Rows)
                            {
                                if (Convert.ToInt32(drCur["���"].ToString()) > 1)
                                {
                                    nmainno = Convert.ToInt32(drCur["���"].ToString());
                                }
                                if (drCur["���"].ToString() == drDiagnosis["���"].ToString())
                                {
                                    if (Convert.ToInt32(drCur["�Ӻ�"].ToString()) > 0)
                                    {
                                        nsubno = Convert.ToInt32(drCur["�Ӻ�"].ToString());
                                    }
                                }
                            }
                            if (nmainno > 1)
                                ndiagtext = drDiagnosis["���"].ToString() + ".";
                            int intLevel = 0;
                            string strSpace = "    ";
                            GetLevel(objTableDiagnosis, drDiagnosis["ID"].ToString(), ref intLevel);
                            for (int ii = 1; ii < intLevel; ii++)
                            {
                                strSpace += "    ";
                            }

                            //if (nsubno > 1 && drDiagnosis["�Ӻ�"].ToString() != "0")  �������ϲ�Ҫ��� ����ΰ 2008-5-30
                            if (nsubno > 1 && drDiagnosis["�Ӻ�"].ToString() != "0" && intLevel <= 2)

                                //ndiagtext = "��������" + Convert.ToInt32(drDiagnosis["�Ӻ�"].ToString()) + "." + " " + drDiagnosis["�������"].ToString();
                                ndiagtext = strSpace + drDiagnosis["�������"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                            //else if (nsubno == 1 && drDiagnosis["�Ӻ�"].ToString() != "0")    �������ϲ�Ҫ��� ����ΰ 2008-5-30
                            else if (nsubno == 1 && drDiagnosis["�Ӻ�"].ToString() != "0" || intLevel > 2)
                                //ndiagtext = "��������     " + drDiagnosis["�������"].ToString();
                                ndiagtext = strSpace + drDiagnosis["�������"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                            else
                            {
                                //ndiagtext = "����" + ndiagtext + drDiagnosis["�������"].ToString() + "(" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                                ndiagtext = strSpace + ndiagtext + drDiagnosis["�������"].ToString() + "(" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                            }
                            objPad.PadInsertField("��Ժ���" + i.ToString(), ndiagtext + " ", -1, 2, 1);
                            i++;
                        }
                    }
                }
            }//end if of ��Ժ���
            #endregion

            #region ��Ժ���

            if (objPad.PadFindField("��Ժ���", -1, 1, true))
            {
                /////////------------------��Ժ���-----------------////////////////
                //��ȡ��ǰ���ı��
                int nbaselineindex = -1; 	//���к�
                int ncellindex = -1; 		//��Ԫ���
                int nlineindex = -1; 		//�к�
                int nfieldelemindex = -1; //Ԫ�����
                int ncharpos = -1;		   //�ַ�λ��

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
                            //ֻ��һ������ϻ�����ϲ�д���
                            int nmainno = 0; //��������
                            int nsubno = 0;//����Ϻ�
                            string ndiagtext = "";
                            foreach (DataRow drCur in objTableDiagnosis.Rows)
                            {
                                if (Convert.ToInt32(drCur["���"].ToString()) > 1)
                                {
                                    nmainno = Convert.ToInt32(drCur["���"].ToString());
                                }
                                if (drCur["���"].ToString() == drDiagnosis["���"].ToString())
                                {
                                    if (Convert.ToInt32(drCur["�Ӻ�"].ToString()) > 0)
                                    {
                                        nsubno = Convert.ToInt32(drCur["�Ӻ�"].ToString());
                                    }
                                }
                            }
                            if (nmainno > 1)
                                ndiagtext = drDiagnosis["���"].ToString() + ".";
                            //���������
                            //���������
                            int intLevel = 0;
                            string strSpace = "    ";
                            GetLevel(objTableDiagnosis, drDiagnosis["ID"].ToString(), ref intLevel);
                            for (int ii = 1; ii < intLevel; ii++)
                            {
                                strSpace += "    ";
                            }

                            //if (nsubno > 1 && drDiagnosis["�Ӻ�"].ToString() != "0")  �������ϲ�Ҫ��� ����ΰ 2008-5-30
                            if (nsubno > 1 && drDiagnosis["�Ӻ�"].ToString() != "0" && intLevel <= 2)
                                //ndiagtext = "��������" + Convert.ToInt32(drDiagnosis["�Ӻ�"].ToString()) + "." + " " + drDiagnosis["�������"].ToString();
                                ndiagtext = strSpace + drDiagnosis["�������"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                            //else if (nsubno == 1 && drDiagnosis["�Ӻ�"].ToString() != "0")    �������ϲ�Ҫ��� ����ΰ 2008-5-30
                            else if (nsubno == 1 && drDiagnosis["�Ӻ�"].ToString() != "0" || intLevel > 2)
                                //ndiagtext = "��������     " + drDiagnosis["�������"].ToString();
                                ndiagtext = strSpace + drDiagnosis["�������"].ToString() + " (" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                            else
                            {
                                //ndiagtext = "����" + ndiagtext + drDiagnosis["�������"].ToString() + "(" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                                ndiagtext = strSpace + ndiagtext + drDiagnosis["�������"].ToString() + "(" + Convert.ToDateTime(drDiagnosis["�������"].ToString()).ToString("yyyy-MM-dd") + ")";
                            }
                            objPad.PadInsertField("��Ժ���" + i.ToString(), ndiagtext + " ", -1, 2, 1);
                            i++;
                        }
                    }
                }
            }//end if ��Ժ���
            #endregion

            return true;
        }

        #endregion
        #region �ж��Ƿ�CA�û�������CA��֤   ����   20140312
        public static bool IsCAUser()
        {
            if (EMRCA.CAAdapter.GetCatype() != EMRCA.CAType.NOCA)
            {
                if (EMRCA.CAAdapter.ReadKey())
                {
                    //��֤CA
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
        #region ��ͼƬǩ��  ����  20140312
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

        //�õ���ϲ��
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
