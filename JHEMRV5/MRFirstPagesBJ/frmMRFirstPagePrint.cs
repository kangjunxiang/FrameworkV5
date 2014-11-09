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
    public partial class frmMRFirstPagePrint : Form
    {
        public string m_strPatientID;
        public int m_nVisitID;
        private UCFirstPagePrintPad ucFirstPagePrintPad1;
        public frmMRFirstPagePrint()
        {
            InitializeComponent();
            this.ucFirstPagePrintPad1 = new UCFirstPagePrintPad();
            this.ucFirstPagePrintPad1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.ucFirstPagePrintPad1.BackColor = SystemColors.Desktop;
            this.ucFirstPagePrintPad1.Location = new Point(2, 28);
            this.ucFirstPagePrintPad1.Name = "ucFirstPagePrintPad1";
            this.ucFirstPagePrintPad1.Size = new Size(1032, 370);
            this.ucFirstPagePrintPad1.TabIndex = 0;
            base.Controls.Add(this.ucFirstPagePrintPad1);
        }
        private void frmMRFirstPagePrint_Load(object sender, EventArgs e)
        {
            if (!EMRArchiveAdaperUse.retrieveEmrFile(new object[]
			{
				1,
				"������ҳ2",
				"��ҳ"
			}))
            {
                MessageBox.Show("ģ���ļ�δ�ҽ�!");
                base.Close();
            }
            this.ucFirstPagePrintPad1.m_strPatientID = this.m_strPatientID;
            this.ucFirstPagePrintPad1.m_nVisitID = this.m_nVisitID;
            this.ucFirstPagePrintPad1.open_templet_file();
        }
        private void toolButtonPrintPreview_Click(object sender, EventArgs e)
        {
            this.ucFirstPagePrintPad1.PadPrintPreview();
        }
        private void toolButtonPrint_Click(object sender, EventArgs e)
        {
            this.ucFirstPagePrintPad1.PadSetPrintPageType(0);
            this.ucFirstPagePrintPad1.PadPrint(0);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.ucFirstPagePrintPad1.PadSetPrintPageType(1);
            this.ucFirstPagePrintPad1.PadPrint(0);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.ucFirstPagePrintPad1.PadSetPrintPageType(2);
            this.ucFirstPagePrintPad1.PadPrint(0);
        }
        private void toolButtonPrintPreview1_Click(object sender, EventArgs e)
        {
            this.ucFirstPagePrintPad1.PadPrint(0);
            if (this.toolButtonPage.Text == "��ҳ�ڶ�ҳ")
            {
                MessageBox.Show("�뼰ʱ��ת������ӡֽ��");
                this.toolStripLabel1.Visible = true;
            }
            else
            {
                this.toolStripLabel1.Visible = false;
            }
        }
        private void toolButtonPage_Click(object sender, EventArgs e)
        {
            if (this.toolButtonPage.Text == "��ҳ�ڶ�ҳ")
            {
                if (!EMRArchiveAdaperUse.retrieveEmrFile(new object[]
				{
					1,
					"������ҳ3",
					"��ҳ"
				}))
                {
                    MessageBox.Show("ģ���ļ�δ�ҽ�!");
                    base.Close();
                }
                this.ucFirstPagePrintPad1.m_strPatientID = this.m_strPatientID;
                this.ucFirstPagePrintPad1.m_nVisitID = this.m_nVisitID;
                this.ucFirstPagePrintPad1.open_templet_file();
                this.toolButtonPage.Text = "��ҳ��һҳ";
            }
            else
            {
                if (!EMRArchiveAdaperUse.retrieveEmrFile(new object[]
				{
					1,
					"������ҳ2",
					"��ҳ"
				}))
                {
                    MessageBox.Show("ģ���ļ�δ�ҽ�!");
                    base.Close();
                }
                this.ucFirstPagePrintPad1.m_strPatientID = this.m_strPatientID;
                this.ucFirstPagePrintPad1.m_nVisitID = this.m_nVisitID;
                this.ucFirstPagePrintPad1.open_templet_file();
                this.toolButtonPage.Text = "��ҳ�ڶ�ҳ";
            }
        }
    }
}