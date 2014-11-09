namespace JHEMR.EMREdit
{
    partial class frmExamApply
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboExamClass = new System.Windows.Forms.ComboBox();
            this.cboExamSubClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxItemForSel = new System.Windows.Forms.ListBox();
            this.lbxItemSelected = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dtApply = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别：";
            // 
            // cboExamClass
            // 
            this.cboExamClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExamClass.FormattingEnabled = true;
            this.cboExamClass.Location = new System.Drawing.Point(64, 18);
            this.cboExamClass.Name = "cboExamClass";
            this.cboExamClass.Size = new System.Drawing.Size(91, 20);
            this.cboExamClass.TabIndex = 1;
            this.cboExamClass.SelectedIndexChanged += new System.EventHandler(this.cboExamClass_SelectedIndexChanged);
            // 
            // cboExamSubClass
            // 
            this.cboExamSubClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExamSubClass.FormattingEnabled = true;
            this.cboExamSubClass.Location = new System.Drawing.Point(161, 18);
            this.cboExamSubClass.Name = "cboExamSubClass";
            this.cboExamSubClass.Size = new System.Drawing.Size(125, 20);
            this.cboExamSubClass.TabIndex = 2;
            this.cboExamSubClass.SelectedIndexChanged += new System.EventHandler(this.cboExamSubClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "发送科室：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "可选：";
            // 
            // lbxItemForSel
            // 
            this.lbxItemForSel.FormattingEnabled = true;
            this.lbxItemForSel.ItemHeight = 12;
            this.lbxItemForSel.Location = new System.Drawing.Point(64, 71);
            this.lbxItemForSel.Name = "lbxItemForSel";
            this.lbxItemForSel.Size = new System.Drawing.Size(219, 160);
            this.lbxItemForSel.TabIndex = 6;
            this.lbxItemForSel.Click += new System.EventHandler(this.lbxItemForSel_Click);
            // 
            // lbxItemSelected
            // 
            this.lbxItemSelected.FormattingEnabled = true;
            this.lbxItemSelected.ItemHeight = 12;
            this.lbxItemSelected.Location = new System.Drawing.Point(328, 71);
            this.lbxItemSelected.Name = "lbxItemSelected";
            this.lbxItemSelected.Size = new System.Drawing.Size(219, 160);
            this.lbxItemSelected.TabIndex = 9;
            this.lbxItemSelected.Click += new System.EventHandler(this.lbxItemSelected_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "已选项目：";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(379, 257);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(472, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDept
            // 
            this.txtDept.BackColor = System.Drawing.SystemColors.Control;
            this.txtDept.Location = new System.Drawing.Point(356, 16);
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Size = new System.Drawing.Size(153, 21);
            this.txtDept.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtApply
            // 
            this.dtApply.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtApply.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtApply.Location = new System.Drawing.Point(64, 257);
            this.dtApply.Name = "dtApply";
            this.dtApply.Size = new System.Drawing.Size(190, 21);
            this.dtApply.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "申请时间：";
            // 
            // frmExamApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 326);
            this.Controls.Add(this.dtApply);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxItemSelected);
            this.Controls.Add(this.lbxItemForSel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboExamSubClass);
            this.Controls.Add(this.cboExamClass);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExamApply";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检查电子申请单";
            this.Load += new System.EventHandler(this.frmExamApply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboExamClass;
        private System.Windows.Forms.ComboBox cboExamSubClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxItemForSel;
        private System.Windows.Forms.ListBox lbxItemSelected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtApply;
        private System.Windows.Forms.Label label9;
    }
}