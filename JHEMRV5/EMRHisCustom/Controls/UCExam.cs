using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;

namespace EMRHisCustom
{
    public partial class UCExam : UserControl, EmrEditUCInterface
    {
        public UCExam()
        {
            InitializeComponent();
        }
        public bool cmdCheckIsUnSave()
        {
            return false;
        }
        public bool getCloseFlag()
        {
            return false;
        }
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
        }
	
    }
}
