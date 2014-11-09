using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace JHEMR.EMREdit
{
    public interface EMREditHisAdaper
    {
        /// <summary>
        ///函数名称: getLabTestMaster
        ///    功能: 读取检验的主索引
        ///    创建: 陈联忠  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <param name="bCurVisit"></param>
        /// <returns></returns>
        DataSet getLabTestMaster(bool bCurVisit);

        /// <summary>
        ///函数名称: getLabResult
        ///    功能: 读取检验结果
        ///    创建: 陈联忠  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <param name="strTestNo"></param>
        /// <returns></returns>
        string getLabResult(string strTestNo);

        /// <summary>
        ///函数名称: getOrders
        ///    功能: 读取医嘱
        ///    创建: 陈联忠  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        DataSet getBasketOrders();
        string getOrderClassName(string strOrderClassCode);

        DataSet getExamMaster(bool bCurVisit);
        string getExamResult(string strExamNo);

        DataSet getPatDiagnose();
        DataSet getVitalSignsRec();

        DataSet getExamClassDict();
        DataSet getExamSubClassDict(string strExamClassName);
        DataSet getExamRptPattern(string strExamClassName, string strExamSubClassName);
        DataSet getExamItems(string strExamNo);
        DataSet getExamAppoint(bool bCurVisit);


        DataSet getLabDeptDict();
        DataSet getLabSheetMaster(string strDeptCode);
        DataSet getLabSheetItems(string strSheetID);
        DataSet getLabSpecimanDict(string strDeptCode);
        DataSet getLabResultQuery(string strTestNo);
        DataSet getLabItemResultQuery(string strPatientID,int intVisitID,string strReportItemCode);

        DataSet getDoctorOrders();

        /// <summary>
        ///函数名称: getOrders
        ///    功能: 读取医嘱
        ///    创建: 李世伟  2007年1月24日
        ///最后修改:     
        /// </summary>
        /// <returns></returns>
        DataSet getOrders();
        DataSet getOrders(string strPatientID, int intVisitID);
        DataSet getGroupOrderMaster(string strDeptCode);
        DataSet getGroupOrderItems(string strGroupOrderID);
        DataTable getAdministrationDict();
        DataTable getDosageUnitsDict();
        DataTable getPerformFreqDict(string strFreqDesc);
        string getOrderStatusDict(string strOrderStatusCode);
        DataTable getOrderClassDict();
        DataTable getOrderRepearIndicator();
        DataTable getDrugDict(string strDrugCode);


    }
}
