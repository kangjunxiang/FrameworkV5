using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JHEMR.EMRHisCustom
{
    public partial class frmClinicMemo : Form
    {
        public frmClinicMemo()
        {
            InitializeComponent();
        }
        public void SetClinicMemoText(string clinicText)
        {
            this.richTextBox1.Text = clinicText;
        }
		
    }
}