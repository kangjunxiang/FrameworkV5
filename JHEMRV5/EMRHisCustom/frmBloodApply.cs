using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace JHEMR.EMRHisCustom
{
    public partial class frmBloodApply : DevExpress.XtraEditors.XtraForm
    {
        public string strApplyNum = "";
        private UCBloodApply ucBlood = new UCBloodApply();
        public frmBloodApply()
        {
            InitializeComponent();
        }
        private void frmBloodApply_Load(object sender, EventArgs e)
        {
            this.ucBlood.Update();
            this.ucBlood.txtAPPLY_NUM.Text = this.strApplyNum;
            base.Controls.Add(this.ucBlood);
            this.ucBlood.Dock = DockStyle.Fill;
        }
	
    }
}
