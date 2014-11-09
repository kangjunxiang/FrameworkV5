using System.Windows.Forms;
using System.Drawing;
namespace EMRHisCustom
{
    partial class UCExam
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new Label();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.Controls.Add(this.label1);
            base.Name = "UCExam";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private Label label1;
    }
}
