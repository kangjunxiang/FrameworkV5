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
    public partial class frmMrDescribe : Form
    {
        public string m_strclin_symp = "";
        public string m_strphys_sign = "";
        public string m_strr_labtest = "";
        public string m_strr_diag = "";
        public string m_strExam_Purpose = "";
        public frmMrDescribe()
        {
            InitializeComponent();
        }
        private void frmInputD_Load(object sender, EventArgs e)
        {
        }
        private void sbtnContinue_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            this.m_strclin_symp = this.txtClinic.Text;
            this.m_strphys_sign = this.txtVital.Text;
            this.m_strr_labtest = this.txtExam.Text;
            this.m_strr_diag = this.txtLab.Text;
            this.m_strExam_Purpose = this.txtExamPurpose.Text;
            base.Close();
        }
    }
}