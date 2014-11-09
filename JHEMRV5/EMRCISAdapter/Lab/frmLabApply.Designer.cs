namespace JHEMR.EMREdit
{
    partial class frmLabApply
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSpeciman = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtApply = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOperate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.txtNotesForSpcm = new System.Windows.Forms.TextBox();
            this.lvItems = new System.Windows.Forms.ListView();
            this.cbxPriorityIndicator = new System.Windows.Forms.CheckBox();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.order_class = new System.Windows.Forms.ColumnHeader();
            this.start_date_time = new System.Windows.Forms.ColumnHeader();
            this.order_text = new System.Windows.Forms.ColumnHeader();
            this.doctor = new System.Windows.Forms.ColumnHeader();
            this.order_class_code = new System.Windows.Forms.ColumnHeader();
            this.item_name = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.LAB_ITEM_CODE = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(457, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(364, 330);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "检验科室：";
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(84, 18);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(190, 20);
            this.cboDept.TabIndex = 18;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "标    本：";
            // 
            // cboSpeciman
            // 
            this.cboSpeciman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpeciman.FormattingEnabled = true;
            this.cboSpeciman.Location = new System.Drawing.Point(84, 76);
            this.cboSpeciman.Name = "cboSpeciman";
            this.cboSpeciman.Size = new System.Drawing.Size(190, 20);
            this.cboSpeciman.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "标本说明：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "申请时间：";
            // 
            // dtApply
            // 
            this.dtApply.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtApply.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtApply.Location = new System.Drawing.Point(84, 137);
            this.dtApply.Name = "dtApply";
            this.dtApply.Size = new System.Drawing.Size(190, 21);
            this.dtApply.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lvOrders);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtOperate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(23, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 145);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "对应的检验医嘱";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "医嘱项目：";
            // 
            // txtOperate
            // 
            this.txtOperate.Location = new System.Drawing.Point(93, 22);
            this.txtOperate.Name = "txtOperate";
            this.txtOperate.Size = new System.Drawing.Size(323, 21);
            this.txtOperate.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "操作名称：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "检 验 单：";
            // 
            // cboSheet
            // 
            this.cboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(84, 47);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(190, 20);
            this.cboSheet.TabIndex = 30;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // txtNotesForSpcm
            // 
            this.txtNotesForSpcm.Location = new System.Drawing.Point(84, 105);
            this.txtNotesForSpcm.Name = "txtNotesForSpcm";
            this.txtNotesForSpcm.Size = new System.Drawing.Size(190, 21);
            this.txtNotesForSpcm.TabIndex = 31;
            // 
            // lvItems
            // 
            this.lvItems.CheckBoxes = true;
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_name,
            this.LAB_ITEM_CODE});
            this.lvItems.Location = new System.Drawing.Point(280, 18);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(258, 140);
            this.lvItems.TabIndex = 32;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // cbxPriorityIndicator
            // 
            this.cbxPriorityIndicator.AutoSize = true;
            this.cbxPriorityIndicator.ForeColor = System.Drawing.Color.Red;
            this.cbxPriorityIndicator.Location = new System.Drawing.Point(24, 330);
            this.cbxPriorityIndicator.Name = "cbxPriorityIndicator";
            this.cbxPriorityIndicator.Size = new System.Drawing.Size(54, 16);
            this.cbxPriorityIndicator.TabIndex = 33;
            this.cbxPriorityIndicator.Text = " 急诊";
            this.cbxPriorityIndicator.UseVisualStyleBackColor = true;
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order_class,
            this.start_date_time,
            this.order_text,
            this.doctor,
            this.order_class_code});
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.Location = new System.Drawing.Point(95, 54);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(406, 81);
            this.lvOrders.TabIndex = 3;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            // 
            // order_class
            // 
            this.order_class.Text = "类别";
            // 
            // start_date_time
            // 
            this.start_date_time.Text = "下医嘱时间";
            this.start_date_time.Width = 120;
            // 
            // order_text
            // 
            this.order_text.Text = "医嘱内容";
            this.order_text.Width = 160;
            // 
            // doctor
            // 
            this.doctor.Text = "医生";
            // 
            // order_class_code
            // 
            this.order_class_code.Width = 0;
            // 
            // item_name
            // 
            this.item_name.Text = "项目名称";
            this.item_name.Width = 250;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(423, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增操作";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // LAB_ITEM_CODE
            // 
            this.LAB_ITEM_CODE.Width = 0;
            // 
            // frmLabApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 374);
            this.Controls.Add(this.cbxPriorityIndicator);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.txtNotesForSpcm);
            this.Controls.Add(this.cboSheet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtApply);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboSpeciman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLabApply";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检验电子申请单";
            this.Load += new System.EventHandler(this.frmLabApply_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSpeciman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtApply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOperate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.TextBox txtNotesForSpcm;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.CheckBox cbxPriorityIndicator;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader order_class;
        private System.Windows.Forms.ColumnHeader start_date_time;
        private System.Windows.Forms.ColumnHeader order_text;
        private System.Windows.Forms.ColumnHeader doctor;
        private System.Windows.Forms.ColumnHeader order_class_code;
        private System.Windows.Forms.ColumnHeader item_name;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader LAB_ITEM_CODE;
    }
}