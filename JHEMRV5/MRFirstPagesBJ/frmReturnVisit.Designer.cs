using System.Windows.Forms;
using System.ComponentModel;
using System;
using System.Drawing;
namespace JHEMR.MRFirstPagesBJ
{
    partial class frmReturnVisit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDOCTOR = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.rdbCOMMON = new System.Windows.Forms.RadioButton();
            this.rdbSPECIALIST = new System.Windows.Forms.RadioButton();
            this.txtPATIENT_NAME = new System.Windows.Forms.TextBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.txtDIAGNOSE = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtYEAR = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDEPT = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtDAY = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtMONTH = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.comNOON = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(138, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "出院病人门诊复诊预约条";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "患者姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(223, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "出院诊断:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(50, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "预约时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(147, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "年";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(194, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "月";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(238, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "日";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(298, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 14);
            this.label8.TabIndex = 7;
            this.label8.Tag = "";
            this.label8.Text = "午";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(403, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "科";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtDOCTOR);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.rdbCOMMON);
            this.panel1.Controls.Add(this.rdbSPECIALIST);
            this.panel1.Location = new System.Drawing.Point(51, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 73);
            this.panel1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(89, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 570;
            this.label10.Text = "医生";
            // 
            // txtDOCTOR
            // 
            this.txtDOCTOR.BackColor = System.Drawing.Color.White;
            this.txtDOCTOR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDOCTOR.ForeColor = System.Drawing.Color.Gray;
            this.txtDOCTOR.Location = new System.Drawing.Point(123, 11);
            this.txtDOCTOR.Name = "txtDOCTOR";
            this.txtDOCTOR.ReadOnly = true;
            this.txtDOCTOR.Size = new System.Drawing.Size(85, 14);
            this.txtDOCTOR.TabIndex = 571;
            this.txtDOCTOR.DoubleClick += new System.EventHandler(this.txtDOCTOR_DoubleClick);
            this.txtDOCTOR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDOCTOR_KeyDown);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Location = new System.Drawing.Point(121, 27);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(90, 1);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 572;
            this.pictureBox7.TabStop = false;
            // 
            // rdbCOMMON
            // 
            this.rdbCOMMON.AutoSize = true;
            this.rdbCOMMON.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbCOMMON.Location = new System.Drawing.Point(3, 41);
            this.rdbCOMMON.Name = "rdbCOMMON";
            this.rdbCOMMON.Size = new System.Drawing.Size(109, 18);
            this.rdbCOMMON.TabIndex = 11;
            this.rdbCOMMON.TabStop = true;
            this.rdbCOMMON.Text = "专科普通门诊";
            this.rdbCOMMON.UseVisualStyleBackColor = true;
            // 
            // rdbSPECIALIST
            // 
            this.rdbSPECIALIST.AutoSize = true;
            this.rdbSPECIALIST.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbSPECIALIST.Location = new System.Drawing.Point(3, 10);
            this.rdbSPECIALIST.Name = "rdbSPECIALIST";
            this.rdbSPECIALIST.Size = new System.Drawing.Size(88, 18);
            this.rdbSPECIALIST.TabIndex = 10;
            this.rdbSPECIALIST.TabStop = true;
            this.rdbSPECIALIST.Text = "专家门诊,";
            this.rdbSPECIALIST.UseVisualStyleBackColor = true;
            this.rdbSPECIALIST.CheckedChanged += new System.EventHandler(this.rdbSPECIALIST_CheckedChanged);
            // 
            // txtPATIENT_NAME
            // 
            this.txtPATIENT_NAME.BackColor = System.Drawing.Color.White;
            this.txtPATIENT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPATIENT_NAME.Enabled = false;
            this.txtPATIENT_NAME.ForeColor = System.Drawing.Color.Gray;
            this.txtPATIENT_NAME.Location = new System.Drawing.Point(118, 90);
            this.txtPATIENT_NAME.Name = "txtPATIENT_NAME";
            this.txtPATIENT_NAME.ReadOnly = true;
            this.txtPATIENT_NAME.Size = new System.Drawing.Size(100, 14);
            this.txtPATIENT_NAME.TabIndex = 555;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.White;
            this.pictureBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox30.Enabled = false;
            this.pictureBox30.Location = new System.Drawing.Point(116, 106);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(105, 1);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 556;
            this.pictureBox30.TabStop = false;
            // 
            // txtDIAGNOSE
            // 
            this.txtDIAGNOSE.BackColor = System.Drawing.Color.White;
            this.txtDIAGNOSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDIAGNOSE.Enabled = false;
            this.txtDIAGNOSE.ForeColor = System.Drawing.Color.Gray;
            this.txtDIAGNOSE.Location = new System.Drawing.Point(289, 90);
            this.txtDIAGNOSE.Name = "txtDIAGNOSE";
            this.txtDIAGNOSE.ReadOnly = true;
            this.txtDIAGNOSE.Size = new System.Drawing.Size(125, 14);
            this.txtDIAGNOSE.TabIndex = 557;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(287, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 1);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 558;
            this.pictureBox1.TabStop = false;
            // 
            // txtYEAR
            // 
            this.txtYEAR.BackColor = System.Drawing.Color.White;
            this.txtYEAR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYEAR.ForeColor = System.Drawing.Color.Gray;
            this.txtYEAR.Location = new System.Drawing.Point(120, 133);
            this.txtYEAR.Name = "txtYEAR";
            this.txtYEAR.ReadOnly = true;
            this.txtYEAR.Size = new System.Drawing.Size(25, 14);
            this.txtYEAR.TabIndex = 559;
            this.txtYEAR.DoubleClick += new System.EventHandler(this.txtYEAR_DoubleClick);
            this.txtYEAR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYEAR_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(118, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 560;
            this.pictureBox2.TabStop = false;
            // 
            // txtDEPT
            // 
            this.txtDEPT.BackColor = System.Drawing.Color.White;
            this.txtDEPT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDEPT.ForeColor = System.Drawing.Color.Gray;
            this.txtDEPT.Location = new System.Drawing.Point(318, 133);
            this.txtDEPT.Name = "txtDEPT";
            this.txtDEPT.ReadOnly = true;
            this.txtDEPT.Size = new System.Drawing.Size(85, 14);
            this.txtDEPT.TabIndex = 563;
            this.txtDEPT.DoubleClick += new System.EventHandler(this.txtDEPT_DoubleClick);
            this.txtDEPT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDEPT_KeyDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(316, 149);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 1);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 564;
            this.pictureBox4.TabStop = false;
            // 
            // txtDAY
            // 
            this.txtDAY.BackColor = System.Drawing.Color.White;
            this.txtDAY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDAY.ForeColor = System.Drawing.Color.Gray;
            this.txtDAY.Location = new System.Drawing.Point(214, 133);
            this.txtDAY.Name = "txtDAY";
            this.txtDAY.ReadOnly = true;
            this.txtDAY.Size = new System.Drawing.Size(25, 14);
            this.txtDAY.TabIndex = 565;
            this.txtDAY.DoubleClick += new System.EventHandler(this.txtDAY_DoubleClick);
            this.txtDAY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDAY_KeyDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(212, 149);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 1);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 566;
            this.pictureBox5.TabStop = false;
            // 
            // txtMONTH
            // 
            this.txtMONTH.BackColor = System.Drawing.Color.White;
            this.txtMONTH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMONTH.ForeColor = System.Drawing.Color.Gray;
            this.txtMONTH.Location = new System.Drawing.Point(167, 133);
            this.txtMONTH.Name = "txtMONTH";
            this.txtMONTH.ReadOnly = true;
            this.txtMONTH.Size = new System.Drawing.Size(25, 14);
            this.txtMONTH.TabIndex = 567;
            this.txtMONTH.DoubleClick += new System.EventHandler(this.txtMONTH_DoubleClick);
            this.txtMONTH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMONTH_KeyDown);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Location = new System.Drawing.Point(165, 149);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 1);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 568;
            this.pictureBox6.TabStop = false;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(347, 236);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(66, 23);
            this.btn_print.TabIndex = 569;
            this.btn_print.Text = "确  定";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // comNOON
            // 
            this.comNOON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comNOON.FormattingEnabled = true;
            this.comNOON.Items.AddRange(new object[] {
            "上",
            "下"});
            this.comNOON.Location = new System.Drawing.Point(256, 132);
            this.comNOON.Name = "comNOON";
            this.comNOON.Size = new System.Drawing.Size(41, 20);
            this.comNOON.TabIndex = 570;
            // 
            // frmReturnVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(472, 287);
            this.Controls.Add(this.comNOON);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txtMONTH);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtDAY);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtDEPT);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtYEAR);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtDIAGNOSE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPATIENT_NAME);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReturnVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "门诊复诊预约条";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReturnVisit_FormClosing);
            this.Load += new System.EventHandler(this.frmReturnVisit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private RadioButton rdbCOMMON;
        private RadioButton rdbSPECIALIST;
        private TextBox txtPATIENT_NAME;
        private PictureBox pictureBox30;
        private TextBox txtDIAGNOSE;
        private PictureBox pictureBox1;
        private TextBox txtYEAR;
        private PictureBox pictureBox2;
        private TextBox txtDEPT;
        private PictureBox pictureBox4;
        private TextBox txtDAY;
        private PictureBox pictureBox5;
        private TextBox txtMONTH;
        private PictureBox pictureBox6;
        private Button btn_print;
        private Label label10;
        private TextBox txtDOCTOR;
        private PictureBox pictureBox7;
        private ComboBox comNOON;
    }
}