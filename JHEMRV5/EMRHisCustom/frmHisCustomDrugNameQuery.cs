using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace JHEMR.EMRHisCustom
{
    public partial class frmHisCustomDrugNameQuery : DevExpress.XtraEditors.XtraForm
    {
        private UCDrugNameQuery ucDrugNameQuery1;
        public frmHisCustomDrugNameQuery()
        {
            InitializeComponent();
            this.ucDrugNameQuery1 = new UCDrugNameQuery();
            this.ucDrugNameQuery1.Dock = DockStyle.Fill;
            this.ucDrugNameQuery1.Location = new Point(0, 0);
            this.ucDrugNameQuery1.Name = "ucDrugNameQuery1";
            this.ucDrugNameQuery1.Size = new Size(852, 528);
            this.ucDrugNameQuery1.TabIndex = 4;
            this.Controls.Add(this.ucDrugNameQuery1);
        }
        private void frmHisCustomDrugNameQuery_Load(object sender, EventArgs e)
        {
        }
    }
}