using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;
using System.Diagnostics;
namespace JHEMR.EMRCISAdapter
{
    public partial class UCPACSOLD : UserControl, EmrEditUCInterface
    {
        public UCPACSOLD()
        {
            InitializeComponent();
        }
        #region ɱ������
        public void KillProcess(string processName)
        {
            //��ý��̶�������������   
            System.Diagnostics.Process myproc = new System.Diagnostics.Process();
            //�õ����д򿪵Ľ���    
            try
            {
                //�����Ҫɱ���Ľ�����   
                foreach (Process thisproc in Process.GetProcessesByName(processName))
                {
                    //����ɱ������   
                    thisproc.Kill();
                }
            }
            catch (Exception Exc)
            {
                throw new Exception("", Exc);
            }
        }
        #endregion

        #region EmrEditUCInterface Members

        public bool cmdCheckIsUnSave()
        {
            return false;
            //throw new Exception("The method or operation is not implemented.");
        }

        public bool getCloseFlag()
        {
            return true;
            //throw new Exception("The method or operation is not implemented.");
        }
        /// <summary>
        /// 2009.08.27 ��ΰ// ������������
        /// </summary>
        /// <param name="strPatientID"></param>
        /// <param name="nVisitID"></param>
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            string strSQL = "select a.inp_no,b.ADMISSION_DATE_TIME from pat_master_index a,pat_visit b where a.patient_id=b.patient_id and b.patient_id='" + strPatientID + "' and b.visit_id=" + nVisitID + "";
            DataSet objReturn = DALUse.Query(strSQL);
            string strInpNo = "";
            string strKsrq = "";
           // string strJsrq = "";
            DateTime dtKsrq;
            if (objReturn .Tables[0].Rows.Count>0)
            {
                strInpNo = objReturn.Tables[0].Rows[0]["inp_no"].ToString().Trim();
                if (objReturn.Tables[0].Rows[0]["ADMISSION_DATE_TIME"] != DBNull.Value)
                {
                  dtKsrq = Convert.ToDateTime(objReturn.Tables[0].Rows[0]["ADMISSION_DATE_TIME"].ToString().Trim().Substring(0,10));
                  int yearr = dtKsrq.Year;
                  int monthh = dtKsrq.Month;
                  int dayy = dtKsrq.Day;
                  strKsrq = String.Format("{0:0000}{1:00}{2:00}", yearr, monthh, dayy);
                }
                //DateTime TODAY = EmrSysPubFunction.getServerNow().Date;
                //int year=TODAY.Year;
                //int month=TODAY.Month;
                //int day=TODAY.Day;
                //strJsrq = year.ToString().Trim() + month.ToString().Trim() + day.ToString().Trim();
            }
            if (strInpNo.Length > 0)
            {
                KillProcess("PacsBrowser");
                try
                {
                   // Process.Start("D:\\Program Files\\�κ͵��Ӳ������ƽ̨\\Dongyin\\PacsBrowser.exe", strInpNo + " " + strKsrq);
                    Process.Start("D:\\Dongyin\\PacsBrowser.exe", strInpNo + " " + strKsrq);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            //throw new Exception("The method or operation is not implemented.");
        }

        #endregion
        private void UCPACSOLD_Load(object sender, EventArgs e)
        {

        }
    }
}
