using System.Windows.Forms;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
namespace JHEMR.EMRHisCustom
{
    partial class frmMrDescribe
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
            this.txtClinic = new System.Windows.Forms.TextBox();
            this.txtVital = new System.Windows.Forms.TextBox();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.txtLab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sbtnContinue = new DevExpress.XtraEditors.SimpleButton();
            this.txtExamPurpose = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtClinic
            // 
            this.txtClinic.Location = new System.Drawing.Point(13, 13);
            this.txtClinic.MaxLength = 40;
            this.txtClinic.Multiline = true;
            this.txtClinic.Name = "txtClinic";
            this.txtClinic.Size = new System.Drawing.Size(421, 57);
            this.txtClinic.TabIndex = 0;
            this.txtClinic.Text = "临床症状：";
            // 
            // txtVital
            // 
            this.txtVital.Location = new System.Drawing.Point(12, 76);
            this.txtVital.MaxLength = 40;
            this.txtVital.Multiline = true;
            this.txtVital.Name = "txtVital";
            this.txtVital.Size = new System.Drawing.Size(422, 61);
            this.txtVital.TabIndex = 0;
            this.txtVital.Text = "体征：";
            // 
            // txtExam
            // 
            this.txtExam.Location = new System.Drawing.Point(12, 152);
            this.txtExam.MaxLength = 40;
            this.txtExam.Multiline = true;
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(422, 56);
            this.txtExam.TabIndex = 0;
            this.txtExam.Text = "相关检查结果：";
            // 
            // txtLab
            // 
            this.txtLab.Location = new System.Drawing.Point(12, 225);
            this.txtLab.MaxLength = 40;
            this.txtLab.Multiline = true;
            this.txtLab.Name = "txtLab";
            this.txtLab.Size = new System.Drawing.Size(422, 54);
            this.txtLab.TabIndex = 0;
            this.txtLab.Text = "相关化验结果：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "【提示】：请尽量输入上述内容，这可以给放射医生提供诊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "断依据，也可直接点击【继续】，打印出申请单后手写补充。";
            // 
            // sbtnContinue
            // 
            this.sbtnContinue.Location = new System.Drawing.Point(360, 368);
            this.sbtnContinue.Name = "sbtnContinue";
            this.sbtnContinue.Size = new System.Drawing.Size(74, 23);
            this.sbtnContinue.TabIndex = 2;
            this.sbtnContinue.Text = "继续";
            this.sbtnContinue.Click += new System.EventHandler(this.sbtnContinue_Click);
            // 
            // txtExamPurpose
            // 
            this.txtExamPurpose.Location = new System.Drawing.Point(12, 285);
            this.txtExamPurpose.MaxLength = 40;
            this.txtExamPurpose.Multiline = true;
            this.txtExamPurpose.Name = "txtExamPurpose";
            this.txtExamPurpose.Size = new System.Drawing.Size(422, 54);
            this.txtExamPurpose.TabIndex = 0;
            this.txtExamPurpose.Text = "检查目的：";
            // 
            // frmMrDescribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 417);
            this.Controls.Add(this.sbtnContinue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExamPurpose);
            this.Controls.Add(this.txtLab);
            this.Controls.Add(this.txtExam);
            this.Controls.Add(this.txtVital);
            this.Controls.Add(this.txtClinic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMrDescribe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAliasDrug";
            this.Load += new System.EventHandler(this.frmInputD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtClinic;
        private TextBox txtVital;
        private TextBox txtExam;
        private TextBox txtLab;
        private Label label1;
        private Label label2;
        private SimpleButton sbtnContinue;
        private TextBox txtExamPurpose;
    }
}