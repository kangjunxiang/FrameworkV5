using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace JHEMR.EMREdit
{
    public interface EMREditHisAdaper
    {
        /// <summary>
        ///��������: getLabTestMaster
        ///    ����: ��ȡ�����������
        ///    ����: ������  2007��1��24��
        ///����޸�:     
        /// </summary>
        /// <param name="bCurVisit"></param>
        /// <returns></returns>
        DataSet getLabTestMaster(bool bCurVisit);

        /// <summary>
        ///��������: getLabResult
        ///    ����: ��ȡ������
        ///    ����: ������  2007��1��24��
        ///����޸�:     
        /// </summary>
        /// <param name="strTestNo"></param>
        /// <returns></returns>
        string getLabResult(string strTestNo);

        /// <summary>
        ///��������: getOrders
        ///    ����: ��ȡҽ��
        ///    ����: ������  2007��1��24��
        ///����޸�:     
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
        ///��������: getOrders
        ///    ����: ��ȡҽ��
        ///    ����: ����ΰ  2007��1��24��
        ///����޸�:     
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
