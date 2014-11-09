using System.Windows.Forms;
using System;
using System.Drawing;
namespace JHEMR.MRFirstPagesBJ
{
    partial class frmCMMRFirstPagePrint
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolButtonPage = new System.Windows.Forms.ToolStripButton();
            this.toolButtonPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.toolButtonPrintPreview1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonPage,
            this.toolButtonPrintPreview,
            this.toolButtonPrintPreview1,
            this.toolStripLabel1,
            this.toolButtonPrint,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(851, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolButtonPage
            // 
            this.toolButtonPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonPage.Name = "toolButtonPage";
            this.toolButtonPage.Size = new System.Drawing.Size(69, 22);
            this.toolButtonPage.Text = "首页第二页";
            this.toolButtonPage.Click += new System.EventHandler(this.toolButtonPage_Click);
            // 
            // toolButtonPrintPreview
            // 
            this.toolButtonPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonPrintPreview.Name = "toolButtonPrintPreview";
            this.toolButtonPrintPreview.Size = new System.Drawing.Size(57, 22);
            this.toolButtonPrintPreview.Text = "打印预览";
            this.toolButtonPrintPreview.Click += new System.EventHandler(this.toolButtonPrintPreview_Click);
            // 
            // toolButtonPrintPreview1
            // 
            this.toolButtonPrintPreview1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonPrintPreview1.Name = "toolButtonPrintPreview1";
            this.toolButtonPrintPreview1.Size = new System.Drawing.Size(33, 22);
            this.toolButtonPrintPreview1.Text = "打印";
            this.toolButtonPrintPreview1.Click += new System.EventHandler(this.toolButtonPrintPreview1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(125, 22);
            this.toolStripLabel1.Text = "请及时打印首页反面！";
            this.toolStripLabel1.Visible = false;
            // 
            // toolButtonPrint
            // 
            this.toolButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonPrint.Name = "toolButtonPrint";
            this.toolButtonPrint.Size = new System.Drawing.Size(57, 22);
            this.toolButtonPrint.Text = "连续打印";
            this.toolButtonPrint.Visible = false;
            this.toolButtonPrint.Click += new System.EventHandler(this.toolButtonPrint_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton1.Text = "打印奇数页";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton2.Text = "打印偶数页";
            this.toolStripButton2.Visible = false;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmCMMRFirstPagePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 410);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCMMRFirstPagePrint";
            this.Text = "frmCMMRFirstPagePrint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCMMRFirstPagePrint_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolButtonPage;
        private ToolStripButton toolButtonPrintPreview;
        private ToolStripButton toolButtonPrintPreview1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolButtonPrint;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
    }
}