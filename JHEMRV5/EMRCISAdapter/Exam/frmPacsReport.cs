using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;
using System.Runtime.InteropServices;

namespace JHEMR.EMREdit
{
    public partial class frmPacsReport :UserControl,EmrEditUCInterface

    {
        string strInpNo = "";
        public frmPacsReport()
        {
            InitializeComponent();
        }
 
        [DllImport("PACSReport.dll")]
        static extern string UnLoadPACSReport();
        [DllImport("PACSReport.dll")]
        static extern string LoadPACSReport(int handle);
        [DllImport("PACSReport.dll")]
        static extern string ShowPACSReport(string HisCode1, string HisCode2);

        private void frmPacsReport_Load(object sender, EventArgs e)
        {
            string strSQL = "select inp_no from pat_master_index where patient_id='" + EmrSysPubVar.getCurPatientID() + "'";
            object objInpNo = DALUse.GetSingle(strSQL);
            if (objInpNo != null)
            {
                strInpNo = objInpNo.ToString();
            }
            LoadPACSReport(Handle.ToInt32());
            ShowPACSReport(strInpNo, "");
    
            
        }

        #region EmrEditUCInterface ≥…‘±

        public bool cmdCheckIsUnSave()
        {
            return false;
        }

        public bool getCloseFlag()
        {
            return true;
        }

        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            
        }

        #endregion
    }
}