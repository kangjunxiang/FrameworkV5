using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace JHEMR.EMREdit
{
    public class EMREditHisAdaperUse
    {
    
        public EMREditHisAdaperUse()
        {

        }

        public static DataSet getLabTestMaster(string strPatientID, int intVisitID, bool bCurVisit)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getLabTestMaster(strPatientID,intVisitID, bCurVisit);
        }

        public static string getLabResult(string strTestNo)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getLabResult(strTestNo);
        }

        public static DataSet getBasketOrders()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getBasketOrders();
        }

        public static string getOrderClassName(string strOrderClassCode)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getOrderClassName(strOrderClassCode);
        }

        public static DataSet getExamMaster(bool bCurVisit)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getExamMaster(bCurVisit);
        }

        public static string getExamResult(string strExamNo)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getExamResult(strExamNo);

        }

        public static DataSet getPatDiagnose()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getPatDiagnose();

        }

        public static DataSet getVitalSignsRec()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getVitalSignsRec();
        }

        public static DataSet getExamClassDict()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getExamClassDict();

        }

        public static DataSet getExamSubClassDict(string strExamClassName)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getExamSubClassDict(strExamClassName);

        }

        public static DataSet getExamRptPattern(string strExamClassName, string strExamSubClassName)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getExamRptPattern(strExamClassName, strExamSubClassName);

        }

        public static DataSet getExamItems(string strExamNo)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getExamItems(strExamNo);

        }

        public static DataSet getExamAppoint(bool bCurVisit)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getExamAppoint(bCurVisit);

        }


        public static DataSet getLabDeptDict()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getLabDeptDict();

        }

        public static DataSet getLabSheetMaster(string strDeptCode)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getLabSheetMaster(strDeptCode);

        }

        public static DataSet getLabSheetItems(string strSheetID)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getLabSheetItems(strSheetID);

        }

        public static DataSet getLabSpecimanDict(string strDeptCode)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getLabSpecimanDict( strDeptCode);

        }

        public static DataSet getLabResultQuery(string strTestNo)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getLabResultQuery(strTestNo);
        }

        public static DataSet getLabItemResultQuery(string strPatientID,int intVisitID,string strReportItemCode)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getLabItemResultQuery(strPatientID, intVisitID,strReportItemCode);
        }

        public static DataSet getOrders()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getOrders();
        }


        public static DataSet getOrders(string strPatientID, int intVisitID)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getOrders(strPatientID,intVisitID);
        }

        public static DataSet getDoctorOrders()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getDoctorOrders();
        }


        public static DataSet getGroupOrderMaster(string strDeptCode)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getGroupOrderMaster(strDeptCode);
        }

        public static DataSet getGroupOrderItems(string strGroupOrderID)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getGroupOrderItems(strGroupOrderID);
        }

        public static DataTable getAdministrationDict()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getAdministrationDict();
        }

        public static DataTable getDosageUnitsDict()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getDosageUnitsDict();
        }


        public static DataTable getPerformFreqDict(string strFreqDesc)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getPerformFreqDict(strFreqDesc);
        }

        public static string getOrderStatusDict(string strOrderStatusCode)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getOrderStatusDict(strOrderStatusCode);
        }

        public static DataTable getOrderClassDict()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getOrderClassDict();
        }

        public static DataTable getOrderRepearIndicator()
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getOrderRepearIndicator();
        }

        public static DataTable getDrugDict(string strDrugCode)
        {
            EMREditHisAdaperJiahe objEMREditHisAdaperJiahe = new EMREditHisAdaperJiahe();
            return objEMREditHisAdaperJiahe.getDrugDict(strDrugCode);
        }

    }
}
