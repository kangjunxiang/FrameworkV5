using System.Windows.Forms;
using System.Drawing;
namespace JHEMR.EMRHisCustom
{
    partial class frmClinicMemo
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
            this.richTextBox1 = new RichTextBox();
            base.SuspendLayout();
            this.richTextBox1.BackColor = SystemColors.Window;
            this.richTextBox1.Dock = DockStyle.Fill;
            this.richTextBox1.Location = new Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new Size(551, 453);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            //base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(551, 453);
            base.Controls.Add(this.richTextBox1);
            //base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmClinicMemo";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "临床意义查看";
            base.ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTextBox1;
    }
}