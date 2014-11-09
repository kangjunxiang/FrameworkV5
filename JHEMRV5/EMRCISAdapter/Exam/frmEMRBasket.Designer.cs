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
            this.EXAM_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_SUB_CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPORT_DATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPORTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXAM_DATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERFORMED_BY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQ_PHYSICIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQ_DATE_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQ_DEPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESULT_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATIENT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VISIT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExam = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamMaster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExamMaster
            // 
            this.dgvExamMaster.AllowUserToAddRows = false;
            this.dgvExamMaster.AllowUserToDeleteRows = false;
            this.dgvExamMaster.AllowUserToResizeRows = false;
            this.dgvExamMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExamMaster.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvExamMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EXAM_NO,
            this.EXAM_CLASS,
            this.EXAM_SUB_CLASS,
            this.REPORT_DATE_TIME,
            this.REPORTER,
            this.EXAM_DATE_TIME,
            this.PERFORMED_BY,
            this.REQ_PHYSICIAN,
            this.REQ_DATE_TIME,
            this.REQ_DEPT,
            this.RESULT_STATUS,
            this.PATIENT_ID,
            this.VISIT_ID});
            this.dgvExamMaster.Location = new System.Drawing.Point(4, 3);
            this.dgvExamMaster.Name = "dgvExamMaster";
            this.dgvExamMaster.RowHeadersVisible = false;
            this.dgvExamMaster.RowTemplate.Height = 23;
            this.dgvExamMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamMaster.Size = new System.Drawing.Size(489, 220);
            this.dgvExamMaster.TabIndex = 3;
            this.dgvExamMaster.SelectionChanged += new System.EventHandler(this.dgvExamMaster_SelectionChanged);
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
            this.EXAM_SUB_CLASS.Width = 90;
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
            // REPORTER
            // 
            this.REPORTER.DataPropertyName = "REPORTER";
            this.REPORTER.HeaderText = "报告人";
            this.REPORTER.Name = "REPORTER";
            this.REPORTER.ReadOnly = true;
            this.REPORTER.Visible = false;
            this.REPORTER.Width = 70;
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
            this.PERFORMED_BY.HeaderText = "执行科室";
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
            // PATIENT_ID
            // 
            this.PATIENT_ID.DataPropertyName = "PATIENT_ID";
            this.PATIENT_ID.HeaderText = "ID号";
            this.PATIENT_ID.Name = "PATIENT_ID";
            this.PATIENT_ID.Visible = false;
            // 
            // VISIT_ID
            // 
            this.VISIT_ID.DataPropertyName = "VISIT_ID";
            this.VISIT_ID.HeaderText = "住院次";
            this.VISIT_ID.Name = "VISIT_ID";
            this.VISIT_ID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExam);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 224);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检查明细及文本报告：";
            // 
            // txtExam
            // 
            this.txtExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExam.Location = new System.Drawing.Point(3, 17);
            this.txtExam.Name = "txtExam";
            this.txtExam.ReadOnly = true;
            this.txtExam.Size = new System.Drawing.Size(492, 204);
            this.txtExam.TabIndex = 0;
            this.txtExam.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvExamMaster);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(498, 456);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 5;
            // 
            // UCExamApplyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCExamApplyList";
            this.Size = new System.Drawing.Size(498, 456);
            this.Load += new System.EventHandler(this.UCExamApplyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamMaster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamMaster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_SUB_CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORT_DATE_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXAM_DATE_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERFORMED_BY;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQ_PHYSICIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQ_DATE_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQ_DEPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESULT_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATIENT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VISIT_ID;
        private System.Windows.Forms.SplitContainer splitContainer1;

    }
}
