using System;
using System.Drawing;
using System.Windows.Forms;
namespace JHEMR.MRFirstPagesBJ
{
    partial class frmMRFirstPagePrint
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            //ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMRFirstPagePrint));
            
            this.toolStrip1 = new ToolStrip();
            this.toolButtonPage = new ToolStripButton();
            this.toolButtonPrintPreview = new ToolStripButton();
            this.toolButtonPrintPreview1 = new ToolStripButton();
            this.toolStripLabel1 = new ToolStripLabel();
            this.toolButtonPrint = new ToolStripButton();
            this.toolStripButton1 = new ToolStripButton();
            this.toolStripButton2 = new ToolStripButton();
            this.toolStrip1.SuspendLayout();
            base.SuspendLayout();
            
            this.toolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.toolButtonPage,
				this.toolButtonPrintPreview,
				this.toolButtonPrintPreview1,
				this.toolStripLabel1,
				this.toolButtonPrint,
				this.toolStripButton1,
				this.toolStripButton2
			});
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(852, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            //this.toolButtonPage.Image = (Image)componentResourceManager.GetObject("toolButtonPage.Image");
            this.toolButtonPage.ImageTransparentColor = Color.Magenta;
            this.toolButtonPage.Name = "toolButtonPage";
            this.toolButtonPage.Size = new Size(92, 22);
            this.toolButtonPage.Text = "首页第二页";
            this.toolButtonPage.Click += new EventHandler(this.toolButtonPage_Click);
            //this.toolButtonPrintPreview.Image = (Image)componentResourceManager.GetObject("toolButtonPrintPreview.Image");
            this.toolButtonPrintPreview.ImageTransparentColor = Color.Magenta;
            this.toolButtonPrintPreview.Name = "toolButtonPrintPreview";
            this.toolButtonPrintPreview.Size = new Size(79, 22);
            this.toolButtonPrintPreview.Text = "打印预览";
            this.toolButtonPrintPreview.Click += new EventHandler(this.toolButtonPrintPreview_Click);
            //this.toolButtonPrintPreview1.Image = (Image)componentResourceManager.GetObject("toolButtonPrintPreview1.Image");
            this.toolButtonPrintPreview1.ImageTransparentColor = Color.Magenta;
            this.toolButtonPrintPreview1.Name = "toolButtonPrintPreview1";
            this.toolButtonPrintPreview1.Size = new Size(53, 22);
            this.toolButtonPrintPreview1.Text = "打印";
            this.toolButtonPrintPreview1.Click += new EventHandler(this.toolButtonPrintPreview1_Click);
            this.toolStripLabel1.ForeColor = Color.Red;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new Size(137, 22);
            this.toolStripLabel1.Text = "请及时打印首页反面！";
            this.toolStripLabel1.Visible = false;
            //this.toolButtonPrint.Image = (Image)componentResourceManager.GetObject("toolButtonPrint.Image");
            this.toolButtonPrint.ImageTransparentColor = Color.Magenta;
            this.toolButtonPrint.Name = "toolButtonPrint";
            this.toolButtonPrint.Size = new Size(79, 22);
            this.toolButtonPrint.Text = "连续打印";
            this.toolButtonPrint.Visible = false;
            this.toolButtonPrint.Click += new EventHandler(this.toolButtonPrint_Click);
            //this.toolStripButton1.Image = (Image)componentResourceManager.GetObject("toolStripButton1.Image");
            this.toolStripButton1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new Size(92, 22);
            this.toolStripButton1.Text = "打印奇数页";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new EventHandler(this.toolStripButton1_Click);
            //this.toolStripButton2.Image = (Image)componentResourceManager.GetObject("toolStripButton2.Image");
            this.toolStripButton2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new Size(92, 22);
            this.toolStripButton2.Text = "打印偶数页";
            this.toolStripButton2.Visible = false;
            this.toolStripButton2.Click += new EventHandler(this.toolStripButton2_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            //base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(852, 400);
            base.Controls.Add(this.toolStrip1);
            
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmMRFirstPagePrint";
            base.ShowInTaskbar = false;
            this.Text = "病案首页打印";
            base.WindowState = FormWindowState.Maximized;
            base.Load += new EventHandler(this.frmMRFirstPagePrint_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        
        private ToolStrip toolStrip1;
        private ToolStripButton toolButtonPrint;
        private ToolStripButton toolButtonPrintPreview;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolButtonPrintPreview1;
        private ToolStripButton toolButtonPage;
        private ToolStripLabel toolStripLabel1;
    }
}