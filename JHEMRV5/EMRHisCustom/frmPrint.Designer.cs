using System;
using System.Windows.Forms;
using System.Drawing;
using JHEMR.EmrSysUserCtl;
using System.ComponentModel;
namespace JHEMR.EMRHisCustom
{
    partial class frmPrint
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
            //ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPrint));
            this.toolStrip1 = new ToolStrip();
            this.toolStripButton1 = new ToolStripButton();
            this.toolStripButton2 = new ToolStripButton();
            this.ucemrPad301 = new UCEMRPad30();
            this.toolStrip1.SuspendLayout();
            base.SuspendLayout();
            this.toolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton1,
				this.toolStripButton2
			});
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(587, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            //this.toolStripButton1.Image = (Image)componentResourceManager.GetObject("toolStripButton1.Image");
            this.toolStripButton1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new Size(73, 22);
            this.toolStripButton1.Text = "打印预览";
            //this.toolStripButton2.Image = (Image)componentResourceManager.GetObject("toolStripButton2.Image");
            this.toolStripButton2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new Size(49, 22);
            this.toolStripButton2.Text = "打印";
            this.ucemrPad301.BackColor = SystemColors.Desktop;
            this.ucemrPad301.Dock = DockStyle.Fill;
            this.ucemrPad301.Location = new Point(0, 25);
            this.ucemrPad301.Name = "ucemrPad301";
            this.ucemrPad301.Size = new Size(587, 381);
            this.ucemrPad301.TabIndex = 2;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            //base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(587, 406);
            base.Controls.Add(this.ucemrPad301);
            base.Controls.Add(this.toolStrip1);
            base.Name = "frmPrint";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "打印";
            base.Load += new EventHandler(this.frmPrint_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private UCEMRPad30 ucemrPad301;
    }
}