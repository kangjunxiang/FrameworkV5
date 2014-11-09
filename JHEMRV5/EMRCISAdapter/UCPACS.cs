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
    public partial class UCPACS : UserControl, EmrEditUCInterface
    {
        public UCPACS()
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
        /// 2009.08.26 λ˼�� �޸ĵ���PACS������ǰ���ر��Ѿ��򿪵�PACS
        /// </summary>
        /// <param name="strPatientID"></param>
        /// <param name="nVisitID"></param>
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            string strSQL = "select inp_no from pat_master_index where patient_id='"+strPatientID+"'";
            object objReturn = DALUse.GetSingle(strSQL);
            string strInpNo = "";
            if (objReturn != null)
                strInpNo = objReturn.ToString();
            string strkssj = "20000101";
            if (strInpNo.Length > 0)
            {
                KillProcess("PacsBrowser");
                try{

                    Process.Start("D:\\Dongyin\\PacsBrowser.exe", strInpNo + " " + strkssj);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            //throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
