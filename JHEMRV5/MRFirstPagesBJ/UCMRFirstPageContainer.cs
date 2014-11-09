using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JHEMR.MRFirstPagesBJ
{
    public partial class UCMRFirstPageContainer : UserControl
    {
        private string m_strPatientID;
        private int m_nVisitID;
        private UCMRFirstPage UCMRFirstPage1;
        public UCMRFirstPageContainer()
        {
            InitializeComponent();
            this.UCMRFirstPage1 = new UCMRFirstPage();
            this.UCMRFirstPage1.AutoSize = true;
            this.UCMRFirstPage1.BackColor = Color.White;
            this.UCMRFirstPage1.ForeColor = Color.Gray;
            this.UCMRFirstPage1.Location = new Point(19, 19);
            this.UCMRFirstPage1.Name = "UCMRFirstPage1";
            this.UCMRFirstPage1.Size = new Size(794, 1962);
            this.UCMRFirstPage1.TabIndex = 0;
            this.Controls.Add(this.UCMRFirstPage1);
        }
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            this.m_strPatientID = strPatientID;
            this.m_nVisitID = nVisitID;
            this.UCMRFirstPage1.setPatientInfo(strPatientID, nVisitID);
        }
        public void setReadOnly(bool bReadOnly)
        {
            this.UCMRFirstPage1.setReadOnly(bReadOnly);
        }
        public bool Save()
        {
            return this.UCMRFirstPage1.Save();
        }
        public bool UpdatePatInfo(string strFieldName, string strFieldValue)
        {
            return this.UCMRFirstPage1.UpdatePatInfo(strFieldName, strFieldValue);
        }
        public bool Print()
        {
            return this.UCMRFirstPage1.Print();
        }
        private void UCMRFirstPageContainer_Load(object sender, EventArgs e)
        {
        }
    }
}
