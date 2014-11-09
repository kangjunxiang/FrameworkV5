using System.Drawing;
using System.Windows.Forms;
using System;
namespace JHEMR.MRFirstPagesBJ
{
    partial class frmReturnVisitPrint
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
            //ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmReturnVisitPrint));
            this.toolStrip1 = new ToolStrip();
            this.toolStripButtonPreview = new ToolStripButton();
            this.toolStripButtonPrint = new ToolStripButton();
            
            this.toolStrip1.SuspendLayout();
            base.SuspendLayout();
            this.toolStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButtonPreview,
				this.toolStripButtonPrint
			});
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(537, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            //this.toolStripButtonPreview.Image = (Image)componentResourceManager.GetObject("toolStripButtonPreview.Image");
            this.toolStripButtonPreview.ImageTransparentColor = Color.Magenta;
            this.toolStripButtonPreview.Name = "toolStripButtonPreview";
            this.toolStripButtonPreview.Size = new Size(92, 22);
            this.toolStripButtonPreview.Text = "打印预览";
            this.toolStripButtonPreview.Click += new EventHandler(this.toolStripButtonPreview_Click);
            //this.toolStripButtonPrint.Image = (Image)componentResourceManager.GetObject("toolStripButtonPrint.Image");
            this.toolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new Size(60, 22);
            this.toolStripButtonPrint.Text = "打印";
            this.toolStripButtonPrint.Click += new EventHandler(this.toolStripButtonPrint_Click);
            
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            //base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(537, 328);
            
            base.Controls.Add(this.toolStrip1);
            base.Name = "frmReturnVisitPrint";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "门诊复诊预约条打印";
            base.WindowState = FormWindowState.Maximized;
            base.Load += new EventHandler(this.frmReturnVisitPrint_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        
        private ToolStripButton toolStripButtonPreview;
        public ToolStripButton toolStripButtonPrint;
    }
}