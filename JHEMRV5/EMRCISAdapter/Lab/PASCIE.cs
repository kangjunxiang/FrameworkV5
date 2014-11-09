using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JHEMR.EMREdit
{
    public partial class PASCIE : UserControl, EmrSysCom.EmrEditUCInterface
    {
        public PASCIE()
        {
            InitializeComponent();
        }

        private void PASCIE_Load(object sender, EventArgs e)
        {
            try
            {
                string InpNo = EmrSysCom.EmrSysPubVar.getCurPatientInpNo();
                System.Diagnostics.Process.Start("IEXPLORE.EXE", "http://192.168.2.43:8080/webviewer/query.do?inPatientNo=" + InpNo + "");
                //this.Hide();
            }
            catch (Exception ex)
            {
                this.Hide();

            }
            { return; }

        }

        #region EmrEditUCInterface ≥…‘±

        bool JHEMR.EmrSysCom.EmrEditUCInterface.cmdCheckIsUnSave()
        {
            return false;
        }

        bool JHEMR.EmrSysCom.EmrEditUCInterface.getCloseFlag()
        {
            return true;
                //true;
        }
       
        void JHEMR.EmrSysCom.EmrEditUCInterface.setPatientInfo(string strPatientID, int nVisitID)
        {

        }

        #endregion


    }
}

