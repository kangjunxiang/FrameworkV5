namespace JHEMR.EMREdit
{
    partial class UCExamApplyList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvExamMaster = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExam = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.EXAM_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_SUB_CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPORT_DATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_DATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERFORMED_BY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQ_PHYSICIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQ_DATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQ_DEPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESULT_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamMaster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExamMaster
            // 
            this.dgvExamMaster.AllowUserToAddRows = false;
            this.dgvExamMaster.AllowUserToDeleteRows = false;
            this.dgvExamMaster.AllowUserToResizeRows = false;
            this.dgvExamMaster.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvExamMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EXAM_NO,
            this.EXAM_CLASS,
            this.EXAM_SUB_CLASS,
            this.REPORT_DATE_TIME,
            this.EXAM_DATE_TIME,
            this.PERFORMED_BY,
            this.REQ_PHYSICIAN,
            this.REQ_DATE_TIME,
            this.REQ_DEPT,
            this.RESULT_STATUS});
            this.dgvExamMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvExamMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvExamMaster.Name = "dgvExamMaster";
            this.dgvExamMaster.RowHeadersVisible = false;
            this.dgvExamMaster.RowTemplate.Height = 23;
            this.dgvExamMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamMaster.Size = new System.Drawing.Size(498, 262);
            this.dgvExamMaster.TabIndex = 1;
            this.dgvExamMaster.Click += new System.EventHandler(this.dgvExamMaster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExam);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检查明细及文本报告：";
            // 
            // txtExam
            // 
            this.txtExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExam.Location = new System.Drawing.Point(3, 17);
            this.txtExam.Name = "txtExam";
            this.txtExam.ReadOnly = true;
            this.txtExam.Size = new System.Drawing.Size(492, 168);
            this.txtExam.TabIndex = 0;
            this.txtExam.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 262);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(498, 6);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // EXAM_NO
            // 
            this.EXAM_NO.DataPropertyName = "EXAM_NO";
            this.EXAM_NO.HeaderText = "检查号";
            this.EXAM_NO.Name = "EXAM_NO";
            this.EXAM_NO.ReadOnly = true;
            this.EXAM_NO.Width = 80;
            // 
            // EXAM_CLASS
            // 
            this.EXAM_CLASS.DataPropertyName = "EXAM_CLASS";
            this.EXAM_CLASS.HeaderText = "类别";
            this.EXAM_CLASS.Name = "EXAM_CLASS";
            this.EXAM_CLASS.ReadOnly = true;
            this.EXAM_CLASS.Width = 70;
            // 
            // EXAM_SUB_CLASS
            // 
            this.EXAM_SUB_CLASS.DataPropertyName = "EXAM_SUB_CLASS";
            this.EXAM_SUB_CLASS.HeaderText = "子类";
            this.EXAM_SUB_CLASS.Name = "EXAM_SUB_CLASS";
            this.EXAM_SUB_CLASS.ReadOnly = true;
            this.EXAM_SUB_CLASS.Width = 70;
            // 
            // REPORT_DATE_TIME
            // 
            this.REPORT_DATE_TIME.DataPropertyName = "REPORT_DATE_TIME";
            this.REPORT_DATE_TIME.HeaderText = "报告日期";
            this.REPORT_DATE_TIME.Name = "REPORT_DATE_TIME";
            this.REPORT_DATE_TIME.ReadOnly = true;
            this.REPORT_DATE_TIME.Visible = false;
            this.REPORT_DATE_TIME.Width = 120;
            // 
            // EXAM_DATE_TIME
            // 
            this.EXAM_DATE_TIME.DataPropertyName = "EXAM_DATE_TIME";
            this.EXAM_DATE_TIME.HeaderText = "检查日期";
            this.EXAM_DATE_TIME.Name = "EXAM_DATE_TIME";
            this.EXAM_DATE_TIME.ReadOnly = true;
            this.EXAM_DATE_TIME.Width = 120;
            // 
            // PERFORMED_BY
            // 
            this.PERFORMED_BY.DataPropertyName = "PERFORMED_BY";
            this.PERFORMED_BY.HeaderText = "执行医师";
            this.PERFORMED_BY.Name = "PERFORMED_BY";
            this.PERFORMED_BY.ReadOnly = true;
            // 
            // REQ_PHYSICIAN
            // 
            this.REQ_PHYSICIAN.DataPropertyName = "REQ_PHYSICIAN";
            this.REQ_PHYSICIAN.HeaderText = "申请人";
            this.REQ_PHYSICIAN.Name = "REQ_PHYSICIAN";
            this.REQ_PHYSICIAN.ReadOnly = true;
            this.REQ_PHYSICIAN.Width = 70;
            // 
            // REQ_DATE_TIME
            // 
            this.REQ_DATE_TIME.DataPropertyName = "REQ_DATE_TIME";
            this.REQ_DATE_TIME.HeaderText = "申请日期";
            this.REQ_DATE_TIME.Name = "REQ_DATE_TIME";
            this.REQ_DATE_TIME.ReadOnly = true;
            this.REQ_DATE_TIME.Width = 120;
            // 
            // REQ_DEPT
            // 
            this.REQ_DEPT.DataPropertyName = "REQ_DEPT";
            this.REQ_DEPT.HeaderText = "申请部门";
            this.REQ_DEPT.Name = "REQ_DEPT";
            this.REQ_DEPT.ReadOnly = true;
            this.REQ_DEPT.Width = 80;
            // 
            // RESULT_STATUS
            // 
            this.RESULT_STATUS.DataPropertyName = "RESULT_STATUS";
            this.RESULT_STATUS.HeaderText = "状态";
            this.RESULT_STATUS.Name = "RESULT_STATUS";
            this.RESULT_STATUS.ReadOnly = true;
            this.RESULT_STATUS.Width = 60;
            // 
            // UCExamApplyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvExamMaster);
            this.Name = "UCExamApplyList";
            this.Size = new System.Drawing.Size(498, 456);
            this.Load += new System.EventHandler(this.UCExamApplyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamMaster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamMaster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtExam;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_SUB_CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORT_DATE_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_DATE_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERFORMED_BY;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQ_PHYSICIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQ_DATE_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQ_DEPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESULT_STATUS;
    }
}
