using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysAdaper;

namespace JHEMR.MRFirstPagesBJ
{
    public partial class frmReturnVisitPrint : Form
    {
        private UCReturnVisitPrintPad ucReturnVisitPrintPad1;
        public string m_strPatientID;
        public string m_strPatientName;
        public string m_nVisitID;
        public bool isSpecialist;
        public frmReturnVisitPrint()
        {
            InitializeComponent();
            this.ucReturnVisitPrintPad1 = new UCReturnVisitPrintPad();
            this.ucReturnVisitPrintPad1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.ucReturnVisitPrintPad1.BackColor = SystemColors.Desktop;
            this.ucReturnVisitPrintPad1.Location = new Point(0, 28);
            this.ucReturnVisitPrintPad1.Name = "ucReturnVisitPrintPad1";
            this.ucReturnVisitPrintPad1.Size = new Size(672, 337);
            this.ucReturnVisitPrintPad1.TabIndex = 1;
            base.Controls.Add(this.ucReturnVisitPrintPad1);
        }
        private void toolStripButtonPreview_Click(object sender, EventArgs e)
        {
            this.ucReturnVisitPrintPad1.PadPrintPreview();
        }
        public void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            this.ucReturnVisitPrintPad1.PadPrint(0);
        }
        private void frmReturnVisitPrint_Load(object sender, EventArgs e)
        {
            object[] array = new object[3];
            array[0] = 1;
            if (this.isSpecialist)
            {
                array[1] = "专科预约条";
            }
            else
            {
                array[1] = "预约条";
            }
            array[2] = "首页";
            if (!EMRArchiveAdaperUse.retrieveEmrFile(array))
            {
                MessageBox.Show("模板文件未挂接!");
                base.Close();
            }
            this.ucReturnVisitPrintPad1.m_strPatientID = this.m_strPatientID;
            this.ucReturnVisitPrintPad1.m_nVisitID = this.m_nVisitID;
            this.ucReturnVisitPrintPad1.m_strPatientName = this.m_strPatientName;
            this.ucReturnVisitPrintPad1.open_templet_file();
            base.DialogResult = DialogResult.Yes;
        }
    }
}