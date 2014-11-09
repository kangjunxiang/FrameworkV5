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
    public partial class frmCMMRFirstPagePrint : Form
    {
        private UCCMFirstPagePrintPad uccmFirstPagePrintPad1;
        public string m_strPatientID;
        public int m_nVisitID;
        public frmCMMRFirstPagePrint()
        {
            InitializeComponent();
            this.uccmFirstPagePrintPad1 = new UCCMFirstPagePrintPad();
            this.uccmFirstPagePrintPad1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.uccmFirstPagePrintPad1.BackColor = SystemColors.Desktop;
            this.uccmFirstPagePrintPad1.Location = new Point(0, 28);
            this.uccmFirstPagePrintPad1.Name = "uccmFirstPagePrintPad1";
            this.uccmFirstPagePrintPad1.Size = new Size(1032, 370);
            this.uccmFirstPagePrintPad1.TabIndex = 3;
            base.Controls.Add(this.uccmFirstPagePrintPad1);
        }
        private void frmCMMRFirstPagePrint_Load(object sender, EventArgs e)
        {
            if (!EMRArchiveAdaperUse.retrieveEmrFile(new object[]
			{
				1,
				"病案首页6",
				"首页"
			}))
            {
                MessageBox.Show("模板文件未挂接!");
                base.Close();
            }
            this.uccmFirstPagePrintPad1.m_strPatientID = this.m_strPatientID;
            this.uccmFirstPagePrintPad1.m_nVisitID = this.m_nVisitID;
            this.uccmFirstPagePrintPad1.open_templet_file();
        }
        private void toolButtonPrintPreview_Click(object sender, EventArgs e)
        {
            this.uccmFirstPagePrintPad1.PadPrintPreview();
        }
        private void toolButtonPrint_Click(object sender, EventArgs e)
        {
            this.uccmFirstPagePrintPad1.PadSetPrintPageType(0);
            this.uccmFirstPagePrintPad1.PadPrint(0);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.uccmFirstPagePrintPad1.PadSetPrintPageType(1);
            this.uccmFirstPagePrintPad1.PadPrint(0);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.uccmFirstPagePrintPad1.PadSetPrintPageType(2);
            this.uccmFirstPagePrintPad1.PadPrint(0);
        }
        private void toolButtonPrintPreview1_Click(object sender, EventArgs e)
        {
            this.uccmFirstPagePrintPad1.PadPrint(0);
            if (this.toolButtonPage.Text == "首页第二页")
            {
                MessageBox.Show("请及时翻转病案打印纸！");
                this.toolStripLabel1.Visible = true;
            }
            else
            {
                this.toolStripLabel1.Visible = false;
            }
        }
        private void toolButtonPage_Click(object sender, EventArgs e)
        {
            if (this.toolButtonPage.Text == "首页第二页")
            {
                if (!EMRArchiveAdaperUse.retrieveEmrFile(new object[]
				{
					1,
					"病案首页7",
					"首页"
				}))
                {
                    MessageBox.Show("模板文件未挂接!");
                    base.Close();
                }
                this.uccmFirstPagePrintPad1.m_strPatientID = this.m_strPatientID;
                this.uccmFirstPagePrintPad1.m_nVisitID = this.m_nVisitID;
                this.uccmFirstPagePrintPad1.open_templet_file();
                this.toolButtonPage.Text = "首页第一页";
            }
            else
            {
                if (!EMRArchiveAdaperUse.retrieveEmrFile(new object[]
				{
					1,
					"病案首页6",
					"首页"
				}))
                {
                    MessageBox.Show("模板文件未挂接!");
                    base.Close();
                }
                this.uccmFirstPagePrintPad1.m_strPatientID = this.m_strPatientID;
                this.uccmFirstPagePrintPad1.m_nVisitID = this.m_nVisitID;
                this.uccmFirstPagePrintPad1.open_templet_file();
                this.toolButtonPage.Text = "首页第二页";
            }
        }
    }
}