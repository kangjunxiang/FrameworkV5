using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using JHEMR.EmrSysDAL;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysAdaper;

namespace JHEMR.EMREdit
{
    public sealed class EMREditHisAdaperJiahe : EMREditHisAdaper
    {
        public EMREditHisAdaperJiahe()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        

        #region 临床数据提取窗口内容


        /// <summary>
        ///函数名称: getOrders
        ///    功能: 读取护士执行的医嘱
        ///    创建: 陈联忠  2007年2月1日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getOrders(string strPatientID, int intVisitID)
        {
            DataSet objDataSet = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetOrderDataSetByPatentID(strPatientID, intVisitID);
            //foreach (DataRow objDataRow in objDataSet.Tables[0].Rows)
            //{
            //    string strREPEATINDICATOR = objDataRow["order_status"].ToString();
            //    switch (strREPEATINDICATOR)
            //    {
            //        case "0":
            //            objDataRow["order_status"] = "临时";
            //            break;
            //        case "1":
            //            objDataRow["order_status"] = "长期";
            //            break;
            //    }
            //}
            return objDataSet;
        }

        /// <summary>
        ///函数名称: getLabTestMaster
        ///    功能: 读取检验的主索引
        ///    创建: 李世伟  2007年7月27日
        ///最后修改:     
        /// </summary>
        /// <param name="bCurVisit"></param>
        /// <returns></returns>

        public DataSet getLabTestMaster(string strPatientID, int intVisitID, bool bCurVisit)
        {
            DataSet objDataSet = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetLabDataSetByPatientID(strPatientID, intVisitID);
            return objDataSet;
        }

        /// <summary>
        ///函数名称: getLabTestMaster
        ///    功能: 读取检验的主索引
        ///    创建: 陈联忠  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <param name="bCurVisit"></param>
        /// <returns></returns>

        public DataSet getLabTestMaster(bool bCurVisit)
        {
            string strSQL;
            strSQL = "SELECT SUBJECT,RESULTS_RPT_DATE_TIME,SPECIMEN,TEST_NO,";//SPCM_RECEIVED_DATE_TIME,";
            strSQL += " RESULT_STATUS,REQUESTED_DATE_TIME,ORDERING_PROVIDER"; //,NOTES_FOR_SPCM
            strSQL += "   FROM LAB_TEST_MASTER ";
            strSQL += " WHERE PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "' ";
            if (bCurVisit)
                strSQL += "  AND  VISIT_ID =  " + EmrSysPubVar.getCurPatientVisitID().ToString();
            return DALUse.Query(strSQL);
        }
        /// <summary>
        ///函数名称: getLabResult
        ///    功能: 读取检验结果
        ///    创建: 陈联忠  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <param name="strTestNo"></param>
        /// <returns></returns>
        public string getLabResult(string strTestNo)
        {
            string strReturn = "";
            string strSQL;
            strSQL = "SELECT TEST_NO,ITEM_NO,TEST_NO,PRINT_ORDER,REPORT_ITEM_NAME,REPORT_ITEM_CODE,";
            strSQL += " RESULT,UNITS,RESULT_DATE_TIME,ABNORMAL_INDICATOR";
            strSQL += "   FROM LAB_RESULT ";
            strSQL += " WHERE TEST_NO ='" + strTestNo + "' ";
            strSQL += " ORDER BY PRINT_ORDER";

            DataSet objDataSet = new DataSet();
            objDataSet = DALUse.Query(strSQL);
            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                string ls_creport_item_name, ls_cresult, ls_cabnormal_indicator, ls_cunits;//,ls_compute_1;

                foreach (DataRow drCurrent in objTable.Rows)
                {
                    ls_creport_item_name = drCurrent["REPORT_ITEM_NAME"].ToString();
                    ls_cresult = drCurrent["RESULT"].ToString();
                    ls_cabnormal_indicator = drCurrent["ABNORMAL_INDICATOR"].ToString();
                    ls_cunits = drCurrent["UNITS"].ToString();
                    //ls_compute_1=drCurrent["clower_limit"].ToString()+ "~~~~~~"+ drCurrent["cupper_limit"].ToString();
                    strReturn += ls_creport_item_name + "(" + ls_cresult + "," + ls_cunits + "," + ls_cabnormal_indicator + ");";
                }
            }
            return strReturn;

        }

        /// <summary>
        ///函数名称: getBasketOrders
        ///    功能: 读取数据篮医嘱
        ///    创建: 陈联忠  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getBasketOrders()
        {
            string strSQL;
            strSQL = "SELECT REPEAT_INDICATOR as 长期,ORDER_CLASS as 类别,START_DATE_TIME as 开始时间,ORDER_TEXT as 医嘱内容,DOSAGE as 剂量,DOSAGE_UNITS as 单位";
            strSQL += "   FROM ORDERS ";
            strSQL += " WHERE PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "' ";
            strSQL += "  AND  VISIT_ID =  " + EmrSysPubVar.getCurPatientVisitID().ToString();
            strSQL += "  ORDER BY  START_DATE_TIME";
            return DALUse.Query(strSQL);
        }

        /// <summary>
        ///函数名称: getOrderClassName
        ///    功能: 读取医嘱
        ///    创建: 陈联忠  2007年1月28日
        ///最后修改:     
        /// </summary>
        /// <param name="strOrderClassCode"></param>
        /// <returns></returns>
        public string getOrderClassName(string strOrderClassCode)
        {
            string strReturn = "其它";
            string strSQL;
            strSQL = "SELECT ORDER_CLASS_CODE,ORDER_CLASS_NAME,INPUT_CODE ";
            strSQL += "   FROM ORDER_CLASS_DICT ";
            strSQL += " WHERE ORDER_CLASS_CODE ='" + strOrderClassCode + "' ";
            strSQL += "  ORDER BY  ORDER_CLASS_CODE";
            DataSet objDataSet = DALUse.Query(strSQL);
            if (objDataSet != null)
            {
                if (objDataSet.Tables.Count > 0)
                {
                    DataTable objTable;
                    objTable = objDataSet.Tables[0];
                    if (objTable.Rows.Count>0)
                    {
                        DataRow drCurrent = objTable.Rows[0];
                        strReturn = drCurrent["ORDER_CLASS_NAME"].ToString();
                    }
                }
            }

            return strReturn;
        }

        /// <summary>
        ///函数名称: getExamtMaster
        ///    功能: 检查主索引
        ///    创建: 陈联忠  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <param name="bCurVisit"></param>
        /// <returns></returns>
        public DataSet getExamMaster(bool bCurVisit)
        {
            string strSQL;
            strSQL = "SELECT EXAM_CLASS ,EXAM_SUB_CLASS,REPORT_DATE_TIME,EXAM_NO,EXAM_DATE_TIME,REQ_PHYSICIAN,REQ_DATE_TIME,REQ_DEPT,REPORTER,RESULT_STATUS,";
            strSQL += " PATIENT_ID,VISIT_ID";
            strSQL += "   FROM EXAM_APPOINTS ";
            strSQL += " WHERE EXAM_DATE_TIME is not null and PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "' ";
            if (bCurVisit)
                strSQL += "  AND  VISIT_ID =  " + EmrSysPubVar.getCurPatientVisitID().ToString();
            strSQL += "   ORDER BY  EXAM_DATE_TIME";
            return DALUse.Query(strSQL);
        }

        /// <summary>
        ///函数名称: getExamResult
        ///    功能: 提取报告内容
        ///    创建: 陈联忠  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <param name="strExamNo"></param>
        /// <returns></returns>
        public string getExamResult(string strExamNo)
        {
            string strReturn = "";
            string strSQL;
            strSQL = "SELECT exam_para,description,impression,recommendation,is_abnormal,use_image";
            strSQL += "   FROM exam_report ";
            strSQL += " WHERE exam_no ='" + strExamNo + "' ";


            DataSet objDataSet = new DataSet();
            objDataSet = DALUse.Query(strSQL);
            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                if (objTable.Rows.Count > 0)
                {
                    DataRow drCurrent = objTable.Rows[0];
                    strReturn += "\r\n" + "[检查参数]" + "\r\n" + drCurrent["exam_para"].ToString() + "\r\n";
                    strReturn += "[检查所见]" + "\r\n" + drCurrent["description"].ToString() + "\r\n";
                    strReturn += "[印象]" + "\r\n" + drCurrent["impression"].ToString() + "\r\n";
                    strReturn += "[建议]" + "\r\n" + drCurrent["recommendation"].ToString() + "\r\n";
                    if (drCurrent["is_abnormal"].ToString() == "1")
                        strReturn += "[异常]";
                }
            }
            return strReturn;

        }


        /// <summary>
        ///函数名称: getPatDiagnose
        ///    功能: 提取病人的诊断
        ///    创建: 陈联忠  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getPatDiagnose()
        {
            string strSQL;
            strSQL = "SELECT  DIAGNOSIS_TYPE_NAME as 诊断类型,DIAGNOSIS_NO as 序号,DIAGNOSIS_SUB_NO as 子号,";
            strSQL += " DIAGNOSIS_DESC as 诊断名称 ,DIAGNOSIS_DATE as 诊断日期,DIAGNOSIS_CODE as 诊断编码,DIAGNOSTICIAN_ID as 医师,";
            strSQL += " HOUSEMAN as 实习医师,MODIFIER_ID as 上级医师,LAST_MODIFY_DATE as 上级审签日期,";
            strSQL += " SUPER_ID as 主任医师, SUPER_SIGN_DATE as 主任审签日期";
            strSQL += " FROM PAT_DIAGNOSIS ";
            strSQL += " WHERE ( PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "') ";
            strSQL += "   AND  ( VISIT_ID =" + EmrSysPubVar.getCurPatientVisitID().ToString() + ") ";
            return DALUse.Query(strSQL);
        }

        /// <summary>
        ///函数名称: getVitalSignsRec
        ///    功能: 提取病人的生命体征
        ///    创建: 陈联忠  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getVitalSignsRec()
        {
            string strSQL;
            strSQL = "SELECT  RECORDING_DATE as 日期,TIME_POINT as 时间点,VITAL_SIGNS as 名称,VITAL_SIGNS_VALUES_C as 值,UNITS as 单位";
            strSQL += " FROM VITAL_SIGNS_REC ";
            strSQL += " WHERE ( PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "') ";
            strSQL += "   AND  ( VISIT_ID =" + EmrSysPubVar.getCurPatientVisitID().ToString() + ") ";
            strSQL += "   ORDER BY TIME_POINT DESC ";
            return DALUse.Query(strSQL);
        }
        #endregion 临床数据提取窗口内容


        #region 检查电子申请单

        /// <summary>
        ///函数名称: getExamClassDict
        ///    功能: 提取检查分类字典
        ///    创建: 陈联忠  2007年1月29日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getExamClassDict()
        {
            string strSQL;
            strSQL = "SELECT  EXAM_CLASS_CODE,EXAM_CLASS_NAME";
            strSQL += " FROM EXAM_CLASS_DICT ";
            strSQL += "   ORDER BY EXAM_CLASS_NAME ";
            return DALUse.Query(strSQL);
        }

        /// <summary>
        ///函数名称: getExamSubClassDict
        ///    功能: 提取检查分类字典
        ///    创建: 陈联忠  2007年1月29日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getExamSubClassDict(string strExamClassName)
        {
            string strSQL;
            strSQL = "SELECT  EXAM_SUBCLASS_NAME";
            strSQL += " FROM EXAM_SUBCLASS_DICT ";
            strSQL += " WHERE  EXAM_CLASS_NAME='" + strExamClassName + "'";
            strSQL += "   ORDER BY EXAM_SUBCLASS_NAME ";
            return DALUse.Query(strSQL);
        }

        /// <summary>
        ///函数名称: getExamRptPattern
        ///    功能: 提取检查可选的详细项目
        ///    创建: 陈联忠  2007年1月29日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getExamRptPattern(string strExamClassName, string strExamSubClassName)
        {
            string strSQL;
            strSQL = "SELECT  DESCRIPTION,DESCRIPTION_CODE";
            strSQL += " FROM EXAM_RPT_PATTERN ";
            strSQL += " WHERE  EXAM_CLASS='" + strExamClassName + "' and EXAM_SUB_CLASS='" + strExamSubClassName + "' and DESC_ITEM = '检查项目'";
            strSQL += "   ORDER BY DESCRIPTION ";
            return DALUse.Query(strSQL);
        }


        /// <summary>
        ///函数名称: getExamItems
        ///    功能: 提取检查详细项目
        ///    创建: 陈联忠  2007年1月29日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getExamItems(string strExamNo)
        {
            string strSQL;
            strSQL = "SELECT  EXAM_ITEM";
            strSQL += " FROM EXAM_ITEMS ";
            strSQL += " WHERE  EXAM_NO='" + strExamNo + "'";
            strSQL += "   ORDER BY EXAM_ITEM ";
            return DALUse.Query(strSQL);
        }
        /// <summary>
        ///函数名称: getExamAppoint
        ///    功能: 检查预约主索引
        ///    创建: 陈联忠  2007年1月30日
        ///最后修改:     
        /// </summary>
        /// <param name="bCurVisit"></param>
        /// <returns></returns>
        public DataSet getExamAppoint(bool bCurVisit)
        {
            string strSQL;
            strSQL = "SELECT EXAM_NO,EXAM_CLASS ,EXAM_SUB_CLASS,REQ_PHYSICIAN,PERFORMED_BY,REQ_DATE_TIME,REQ_DEPT";
            strSQL += "   FROM EXAM_APPOINTS ";
            strSQL += " WHERE PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "' ";
            if (bCurVisit)
                strSQL += "  AND  VISIT_ID =  " + EmrSysPubVar.getCurPatientVisitID().ToString();
            strSQL += "   ORDER BY  REQ_DATE_TIME";
            return DALUse.Query(strSQL);
        }

        #endregion 检查电子申请单


        #region 检验电子申请单

        /// <summary>
        ///函数名称: getLabDeptDict
        ///    功能: 提取检验科室字典
        ///    创建: 陈联忠  2007年1月30日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getLabDeptDict()
        {
            string strSQL;
            strSQL = "SELECT  DISTINCT a.PERFORMED_BY,b.DEPT_NAME";
            strSQL += " FROM LAB_SHEET_MASTER a,DEPT_DICT b ";
            strSQL += " WHERE a.PERFORMED_BY=b.DEPT_CODE";
            strSQL += "   ORDER BY DEPT_NAME ";
            return DALUse.Query(strSQL);
        }

        /// <summary>
        ///函数名称: getLabSheetMaster
        ///    功能: 提取检验科室定制检验单名称字典
        ///    创建: 陈联忠  2007年1月30日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getLabSheetMaster(string strDeptCode)
        {
            string strSQL;
            strSQL = "SELECT  LAB_SHEET_ID,SHEET_TITLE ";
            strSQL += " FROM LAB_SHEET_MASTER ";
            strSQL += " WHERE PERFORMED_BY='" + strDeptCode + "'";
            strSQL += "   ORDER BY SHEET_TITLE ";
            return DALUse.Query(strSQL);
        }

        /// <summary>
        ///函数名称: getLabSheetItems
        ///    功能: 提取检验科室定制检验单名称条目字典
        ///    创建: 陈联忠  2007年1月30日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getLabSheetItems(string strSheetID)
        {
            string strSQL;
            strSQL = "SELECT  LAB_ITEM_NO,LAB_ITEM_CODE,LAB_ITEM_NAME ";
            strSQL += " FROM LAB_SHEET_ITEMS ";
            strSQL += " WHERE LAB_SHEET_ID='" + strSheetID + "'";
            strSQL += "   ORDER BY LAB_ITEM_NO ";
            return DALUse.Query(strSQL);
        }


        /// <summary>
        ///函数名称: getLabSpecimanDict
        ///    功能: 提取指定检验科室的检验项目字典
        ///    创建: 陈联忠  2007年1月30日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getLabSpecimanDict(string strDeptCode)
        {
            string strSQL;
            strSQL = "SELECT  SPECIMAN_NAME,DEPT_CODE";
            strSQL += " FROM SPECIMAN_DICT ";
            strSQL += " WHERE DEPT_CODE='"+strDeptCode+"'";
            strSQL += "   ORDER BY SPECIMAN_NAME ";
            return DALUse.Query(strSQL);
        }


        /// <summary>
        ///函数名称: getLabSpecimanDict
        ///    功能: 提取指定检验科室的检验项目字典
        ///    创建: 李世伟  2007年7月27日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getLabResultQuery(string strTestNo)
        {
            return EmrSysWebservices.EmrSysWebservicesUse.myEmrGetLabReportDataSet(strTestNo);
        }

        public DataSet getLabItemResultQuery(string strPatientID,int intVisitID, string strReportItemCode)
        {
            return EmrSysWebservices.EmrSysWebservicesUse.myEmrGetLabItemResultQuery(strPatientID, intVisitID, strReportItemCode);
        }

        #endregion 检验电子申请单

        #region 电子处方

        /// <summary>
        ///函数名称: getOrders
        ///    功能: 读取护士执行的医嘱
        ///    创建: 陈联忠  2007年2月1日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getOrders()
        {

            string strSQL;
            strSQL = "SELECT '' as REPEAT_INDICATOR_DISPLAY,REPEAT_INDICATOR,'' as ORDER_CLASS_DISPLAY,ORDER_CLASS,START_DATE_TIME,ORDER_TEXT,DOSAGE,DOSAGE_UNITS,ADMINISTRATION,DURATION,DURATION_UNITS,FREQUENCY,";
            strSQL += " STOP_DATE_TIME,FREQ_COUNTER,FREQ_INTERVAL,FREQ_INTERVAL_UNIT,DOCTOR,NURSE,STOP_DOCTOR,";
            strSQL += " ORDER_CODE,ORDER_STATUS,ENTER_DATE_TIME,FREQ_DETAIL,ORDER_NO,ORDER_SUB_NO,PERFORM_SCHEDULE,";
            strSQL += " BILLING_ATTR,LAST_ACCTING_DATE_TIME,PATIENT_ID,VISIT_ID ";
            strSQL += "   FROM ORDERS ";
            strSQL += " WHERE PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "' ";
            strSQL += "  AND  VISIT_ID =  " + EmrSysPubVar.getCurPatientVisitID().ToString();
            strSQL += "  ORDER BY  ORDER_NO,ORDER_SUB_NO";
            DataSet objDataSet = DALUse.Query(strSQL);
            if (objDataSet != null)
            {
                if (objDataSet.Tables.Count > 0)
                {
                    DataTable objTable;
                    objTable = objDataSet.Tables[0];
                    for (int i = 0; i < objTable.Rows.Count; i++)
                    {
                        DataRow drCurrent = objTable.Rows[i];
                        objTable.Rows[i]["REPEAT_INDICATOR_DISPLAY"] = (Convert.ToInt32(drCurrent["REPEAT_INDICATOR"].ToString()) == 1 ? "长" : "临");
                        objTable.Rows[i]["ORDER_CLASS_DISPLAY"] = getOrderClassName(drCurrent["ORDER_CLASS"].ToString());

                    }
                }
            }
            return objDataSet;
        }

        /// <summary>
        ///函数名称: getDoctorOrders
        ///    功能: 读取医生的医嘱本
        ///    创建: 陈联忠  2007年2月1日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getDoctorOrders()
        {
            string strSQL;
            strSQL = "SELECT REPEAT_INDICATOR,ORDER_CLASS,ORDER_TEXT,DOSAGE,DOSAGE_UNITS,ADMINISTRATION,FREQUENCY,FREQ_COUNTER,";
            strSQL += " FREQ_INTERVAL_UNIT,FREQ_INTERVAL,DURATION,DURATION_UNITS,FREQ_DETAIL,DOCTOR,NURSE,START_STOP_INDICATOR,";
            strSQL += " ORDER_CODE,ORDER_STATUS,ENTER_DATE_TIME,ORDER_NO,ORDER_SUB_NO,ORDERING_DEPT,ORDER_PRINT_INDICATOR,";
            strSQL += "  RELATED_ORDER_NO,RELATED_ORDER_SUB_NO,BILLING_ATTR,PROCESSING_DATE_TIME,START_DATE_TIME,DRUG_BILLING_ATTR,PATIENT_ID,VISIT_ID ";
            strSQL += "   FROM DOCTOR_ORDERS ";
            strSQL += " WHERE PATIENT_ID ='" + EmrSysPubVar.getCurPatientID() + "' ";
            strSQL += "  AND  VISIT_ID =  " + EmrSysPubVar.getCurPatientVisitID().ToString();
            strSQL += "  ORDER BY  ORDER_NO,ORDER_SUB_NO";
            return DALUse.Query(strSQL);
        }

        /// <summary>
        ///函数名称: getGroupOrderMaster
        ///    功能: 读取套餐医嘱主索引
        ///    创建: 陈联忠  2007年2月2日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getGroupOrderMaster(string strDeptCode)
        {
            string strSQL;
            strSQL = "SELECT TITLE,GROUP_ORDER_ID,DEPT_CODE";
            strSQL += "   FROM GROUP_ORDER_MASTER ";
            if (strDeptCode.Length>0)
                strSQL += " WHERE DEPT_CODE ='" + strDeptCode + "' ";
            strSQL += "  ORDER BY  TITLE";
            return DALUse.Query(strSQL);
        }

        /// <summary>
        ///函数名称: getGroupOrderItems
        ///    功能: 读取套餐医嘱详细项目
        ///    创建: 陈联忠  2007年2月2日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataSet getGroupOrderItems(string strGroupOrderID)
        {
            string strSQL;
            strSQL = "SELECT '' as REPEAT_INDICATOR_DISPLAY,'' as ORDER_CLASS_DISPLAY,GROUP_ORDER_ID,ITEM_NO,ITEM_SUB_NO,REPEAT_INDICATOR,ORDER_CLASS,ORDER_TEXT,";
            strSQL += "  ORDER_CODE,DOSAGE,DOSAGE_UNITS,ADMINISTRATION,FREQUENCY,FREQ_COUNTER,FREQ_INTERVAL,";
            strSQL += "  FREQ_INTERVAL_UNIT";
            strSQL += "   FROM GROUP_ORDER_ITEMS ";
            strSQL += " WHERE GROUP_ORDER_ID ='" + strGroupOrderID + "' ";
            strSQL += "  ORDER BY  ITEM_NO,ITEM_SUB_NO";
            DataSet objDataSet = DALUse.Query(strSQL);
            if (objDataSet != null)
            {
                if (objDataSet.Tables.Count > 0)
                {
                    DataTable objTable;
                    objTable = objDataSet.Tables[0];
                    for (int i = 0; i < objTable.Rows.Count; i++)
                    {
                        DataRow drCurrent = objTable.Rows[i];
                        objTable.Rows[i]["REPEAT_INDICATOR_DISPLAY"] = (Convert.ToInt32(drCurrent["REPEAT_INDICATOR"].ToString()) == 1 ? "长" : "临");
                        objTable.Rows[i]["ORDER_CLASS_DISPLAY"] = getOrderClassName(drCurrent["ORDER_CLASS"].ToString());

                    }
                }
            }
            return objDataSet;
        }

        /// <summary>
        ///函数名称: getAdministrationDict
        ///    功能: 读取医嘱给药途径字典
        ///    创建: 陈联忠  2007年2月3日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataTable getAdministrationDict()
        {
            DataTable objTable = new DataTable();
            DataSet objDataSet = new DataSet();
            string strSQL;
            strSQL = "SELECT ADMINISTRATION_NAME,ADMINISTRATION_CODE,INPUT_CODE";
            strSQL += "   FROM ADMINISTRATION_DICT ";
            strSQL += "  ORDER BY  ADMINISTRATION_NAME";

            objDataSet = DALUse.Query(strSQL);
            if (objDataSet.Tables.Count > 0)
                objTable = objDataSet.Tables[0];
            return objTable;
        }

        /// <summary>
        ///函数名称: getDosageUnitsDict
        ///    功能: 读取医嘱剂量单位字典
        ///    创建: 陈联忠  2007年2月3日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataTable getDosageUnitsDict()
        {
            DataTable objTable = new DataTable();
            DataSet objDataSet = new DataSet();

            string strSQL;
            strSQL = "SELECT DOSAGE_UNITS,BASE_UNITS,CONVERSION_RATIO,INPUT_CODE";
            strSQL += "   FROM DOSAGE_UNITS_DICT ";
            strSQL += "  ORDER BY  DOSAGE_UNITS";
            objDataSet = DALUse.Query(strSQL);

            if (objDataSet.Tables.Count > 0)
                objTable = objDataSet.Tables[0];
            return objTable;
        }

        /// <summary>
        ///函数名称: getPerformFreqDict
        ///    功能: 读取医嘱给药频次字典
        ///    创建: 陈联忠  2007年2月3日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataTable getPerformFreqDict(string strFreqDesc)
        {
            DataTable objTable = new DataTable();

            DataSet objDataSet = new DataSet();

            string strSQL;
            strSQL = "SELECT FREQ_DESC,FREQ_COUNTER,FREQ_INTERVAL,FREQ_INTERVAL_UNITS";
            strSQL += "   FROM PERFORM_FREQ_DICT ";
            if (strFreqDesc.Length>0)
                strSQL += "  WHERE  FREQ_DESC='" + strFreqDesc+"' ";

            strSQL += "  ORDER BY  FREQ_DESC";

            objDataSet = DALUse.Query(strSQL);

            if (objDataSet.Tables.Count > 0)
                objTable = objDataSet.Tables[0];
            return objTable;
        }

        /// <summary>
        ///函数名称: getDrugDict
        ///    功能: 读取医嘱药品字典
        ///    创建: 陈联忠  2007年2月4日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataTable getDrugDict(string strDrugCode)
        {
            DataTable objTable = new DataTable();
            DataSet objDataSet = new DataSet();

            string strSQL;
            strSQL = "SELECT DRUG_CODE,DRUG_NAME,DRUG_SPEC,UNITS,DRUG_FORM,TOXI_PROPERTY,DOSE_PER_UNIT,DOSE_UNITS,DRUG_INDICATOR,INPUT_CODE";
            strSQL += "   FROM DRUG_DICT ";
            if (strDrugCode.Length > 0)
                strSQL += "  WHERE  DRUG_CODE='" + strDrugCode + "' ";
            strSQL += "  ORDER BY  DRUG_CODE";

            objDataSet = DALUse.Query(strSQL);

            if (objDataSet.Tables.Count > 0)
                objTable = objDataSet.Tables[0];
            return objTable;
        }

        /// <summary>
        ///函数名称: getOrderStatusDict
        ///    功能: 读取医嘱状态字典
        ///    创建: 陈联忠  2007年2月3日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public string getOrderStatusDict(string strOrderStatusCode)
        {
            string strReturn = "";
            string strSQL;
            strSQL = "SELECT ORDER_STATUS_CODE,ORDER_STATUS_NAME,INPUT_CODE ";
            strSQL += "   FROM ORDER_STATUS_DICT ";
            strSQL += " WHERE ORDER_STATUS_CODE ='" + strOrderStatusCode + "' ";
            DataSet objDataSet = DALUse.Query(strSQL);
            if (objDataSet != null)
            {
                if (objDataSet.Tables.Count > 0)
                {
                    DataTable objTable;
                    objTable = objDataSet.Tables[0];
                    if (objTable.Rows.Count > 0)
                    {
                        DataRow drCurrent = objTable.Rows[0];
                        strReturn = drCurrent["ORDER_STATUS_NAME"].ToString();
                    }
                }
            }

            return strReturn;
        }


        /// <summary>
        ///函数名称: getOrderClassDict
        ///    功能: 读取医嘱类别字典
        ///    创建: 陈联忠  2007年2月3日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        public DataTable getOrderClassDict()
        {
            DataTable objTable = new DataTable();
            DataSet objDataSet = new DataSet();

            string strSQL;
            strSQL = "SELECT ORDER_CLASS_CODE,ORDER_CLASS_NAME,INPUT_CODE ";
            strSQL += "   FROM ORDER_CLASS_DICT ";
            strSQL += "  ORDER BY  ORDER_CLASS_CODE";
            objDataSet = DALUse.Query(strSQL);

            if (objDataSet.Tables.Count > 0)
                objTable = objDataSet.Tables[0];
            return objTable;
        }

        public DataTable getOrderRepearIndicator()
        {
            DataTable objTable=new DataTable();

            DataSet objDataSet = new DataSet();
            string strSQL;
            strSQL = "SELECT REPEAT_INDICATOR,REPEAT_INDICATOR_NAME ";
            strSQL += "   FROM REPEAT_INDICATOR_DICT ";
            strSQL += "  ORDER BY  REPEAT_INDICATOR";

            objDataSet = DALUse.Query(strSQL);

            if (objDataSet.Tables.Count > 0)
                objTable = objDataSet.Tables[0];

            /*
            DataTable table = new DataTable("TableOne");

            DataColumn column = table.Columns.Add();
            column.ColumnName = "REPEAT_INDICATOR";
            column.DataType = Type.GetType("System.String"); 

            column = table.Columns.Add();
            column.ColumnName = "REPEAT_INDICATOR_NAME";
            column.DataType = Type.GetType("System.String");

            table.Rows.Add(new object[] {"0","临"});
            table.Rows.Add(new object[] {"1","长"});
            */
            return objTable;
        }


        #endregion 电子处方

    }

}
