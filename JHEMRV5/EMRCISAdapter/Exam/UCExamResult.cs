using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using JHEMR.EmrSysUserCtl;
using JHEMR.EmrSysCom;
using System.Diagnostics;

namespace JHEMR.EMREdit
{
    public partial class UCExamResult : UserControl
    {

        public UCExamResult()
        {
            InitializeComponent();
        }

        private void UCExamResult_Load(object sender, EventArgs e)
        {
            //开始创建文件 
            //Process p = new Process();
            //p.StartInfo.FileName = "D:\\HHPACS\\MedClinicalWS.exe";
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.RedirectStandardError = true;
            //p.StartInfo.CreateNoWindow = true;
            //string strCmd = " /S3 /F0 /E"+EmrSysCom.EmrSysPubVar.getCurPatientID();//695151
            //try
            //{
            //    Process.Start("D:\\HHPACS\\MedClinicalWS.exe", strCmd);
            //    //p.Start();
            //    //p.StandardInput.WriteLine(strCmd);
            //}
            //catch (Exception ex)
            //{
            //    ex.ToString();
            //}
            //this.Dispose();
            webBrowser1.Navigate("http://baidu.com");
            //// invoke the outlook style
            //menuSkinOutlook_Click(sender, e);

            //// setup our example list of business objects
            //// in this case a list of contacts
            //OrderList = new ArrayList();

            ////填充数据
            //DataSet objDataSet = new DataSet();
            //objDataSet = EMREditHisAdaperUse.getExamMaster(true);

            //if (objDataSet.Tables.Count > 0)
            //{
            //    DataTable objTable;
            //    objTable = objDataSet.Tables[0];
            //    foreach (DataRow drCurrent in objTable.Rows)
            //    {
            //        if (drCurrent["EXAM_CLASS"].ToString() != "心电图")
            //        {
            //            ExamInfo ObjOrder = new ExamInfo();

            //            ObjOrder.ExamClass = drCurrent["EXAM_CLASS"].ToString();
            //            ObjOrder.ExamSubClass = drCurrent["EXAM_SUB_CLASS"].ToString();
            //            ObjOrder.ReportDateTime = Convert.ToDateTime(drCurrent["EXAM_DATE_TIME"].ToString());
            //            TimeSpan ts = ObjOrder.ReportDateTime.Date - EmrSysPubVar.getCurVisitAdmissionDateTime().Date;
            //            ObjOrder.AdmissionDateTime = ObjOrder.ReportDateTime.ToString("yyyy年MM月dd日") + " 入院第" + ts.Days.ToString() + "天 " + EmrSysPubFunction.WeekDayOfCN(ObjOrder.ReportDateTime);
            //            string strTmp;
            //            strTmp = drCurrent["REPORT_DATE_TIME"].ToString();
            //            if (strTmp.Length > 0)
            //                ObjOrder.ReportDateTime = Convert.ToDateTime(strTmp);

            //            ObjOrder.ExamNo = drCurrent["EXAM_NO"].ToString();

            //            OrderList.Add(ObjOrder);
            //        }
            //    }
            //}

            //// invoke inital filling, in this case unbound data
            //menuUnboundContactList_Click(sender, e);
        }
    }
}
