using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JHEMR.EmrSysCom;

namespace JHEMR.EMRHisCustom
{
    public partial class frmHisCustomLab : DevExpress.XtraEditors.XtraForm
    {
        private UCLab ucLab1;
        public frmHisCustomLab()
        {
            InitializeComponent();
            ucLab1 = new UCLab();
            this.ucLab1.Dock = DockStyle.Fill;
            this.ucLab1.Location = new Point(0, 0);
            this.ucLab1.Name = "ucLab1";
            this.ucLab1.Size = new Size(866, 611);
            this.ucLab1.TabIndex = 0;
            this.Controls.Add(ucLab1);
        }
        private void frmHisCustomLab_Load(object sender, EventArgs e)
        {
            this.ucLab1.toolStrip1.Visible = false;
            this.ucLab1.groupBox1.Location = new Point(3, 9);
            this.ucLab1.groupBox2.Location = new Point(3, 75);
            this.ucLab1.panel1.Location = new Point(3, 134);
            this.ucLab1.panel1.Size = new Size(872, 481);
            this.ucLab1.setPatientInfo(EmrSysPubVar.getCurPatientID(), EmrSysPubVar.getCurPatientVisitID());
        }
    }
}