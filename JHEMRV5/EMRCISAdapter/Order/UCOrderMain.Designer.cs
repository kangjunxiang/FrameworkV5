using JHEMR.EmrSysUserCtl;
namespace JHEMR.EMREdit
{
    partial class UCOrderMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTemp = new System.Windows.Forms.RadioButton();
            this.rbRepeat = new System.Windows.Forms.RadioButton();
            this.rbAllOrders = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbCarried = new System.Windows.Forms.RadioButton();
            this.rbAllStatus = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChildorder = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDoctorOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDiagnose = new System.Windows.Forms.Panel();
            this.dgvGroupOrderItems = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.REPEAT_INDICATOR_DISPLAY_G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_CLASS_DISPLAY_G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_TEXT_G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOSAGE_G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOSAGE_UNITS_G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADMINISTRATION_G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FREQUENCY_G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCaption = new System.Windows.Forms.Label();
            this.dgvPatDiagnose = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.诊断类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.诊断名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.诊断日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.医师 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.诊断编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOrderGroup = new System.Windows.Forms.Panel();
            this.cbxPreviewGroupOrderItems = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvGroupOrderMaster = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDoctorOrder = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeat_indicator_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_CLASS_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date_time_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_text_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drug_billing_attr_d = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dosage_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosage_units_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administration_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FREQ_INTERVAL_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FREQ_INTERVAL_UNIT_D = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FREQ_COUNTER_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURATION_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURATION_UNITS_D = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.freq_detail_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurse_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrders = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.repeat_indicator_display = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_class_display = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosage_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perform_schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration_units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stop_date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freq_counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freq_interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freq_interval_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freq_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stop_doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billing_attr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelDiagnose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatDiagnose)).BeginInit();
            this.panelOrderGroup.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupOrderMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTemp);
            this.groupBox1.Controls.Add(this.rbRepeat);
            this.groupBox1.Controls.Add(this.rbAllOrders);
            this.groupBox1.Location = new System.Drawing.Point(20, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "长期 / 临时";
            // 
            // rbTemp
            // 
            this.rbTemp.AutoSize = true;
            this.rbTemp.Location = new System.Drawing.Point(154, 20);
            this.rbTemp.Name = "rbTemp";
            this.rbTemp.Size = new System.Drawing.Size(47, 16);
            this.rbTemp.TabIndex = 2;
            this.rbTemp.Text = "临时";
            this.rbTemp.UseVisualStyleBackColor = true;
            this.rbTemp.CheckedChanged += new System.EventHandler(this.rbTemp_CheckedChanged);
            // 
            // rbRepeat
            // 
            this.rbRepeat.AutoSize = true;
            this.rbRepeat.Location = new System.Drawing.Point(87, 20);
            this.rbRepeat.Name = "rbRepeat";
            this.rbRepeat.Size = new System.Drawing.Size(47, 16);
            this.rbRepeat.TabIndex = 1;
            this.rbRepeat.Text = "长期";
            this.rbRepeat.UseVisualStyleBackColor = true;
            this.rbRepeat.CheckedChanged += new System.EventHandler(this.rbRepeat_CheckedChanged);
            // 
            // rbAllOrders
            // 
            this.rbAllOrders.AutoSize = true;
            this.rbAllOrders.Checked = true;
            this.rbAllOrders.Location = new System.Drawing.Point(23, 20);
            this.rbAllOrders.Name = "rbAllOrders";
            this.rbAllOrders.Size = new System.Drawing.Size(47, 16);
            this.rbAllOrders.TabIndex = 0;
            this.rbAllOrders.TabStop = true;
            this.rbAllOrders.Text = "全部";
            this.rbAllOrders.UseVisualStyleBackColor = true;
            this.rbAllOrders.CheckedChanged += new System.EventHandler(this.rbAllOrders_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbNew);
            this.groupBox2.Controls.Add(this.rbCarried);
            this.groupBox2.Controls.Add(this.rbAllStatus);
            this.groupBox2.Location = new System.Drawing.Point(364, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 42);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示范围";
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Checked = true;
            this.rbNew.Location = new System.Drawing.Point(184, 20);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(59, 16);
            this.rbNew.TabIndex = 2;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "医嘱本";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // rbCarried
            // 
            this.rbCarried.AutoSize = true;
            this.rbCarried.Location = new System.Drawing.Point(109, 20);
            this.rbCarried.Name = "rbCarried";
            this.rbCarried.Size = new System.Drawing.Size(59, 16);
            this.rbCarried.TabIndex = 1;
            this.rbCarried.Text = "已执行";
            this.rbCarried.UseVisualStyleBackColor = true;
            this.rbCarried.CheckedChanged += new System.EventHandler(this.rbCarried_CheckedChanged);
            // 
            // rbAllStatus
            // 
            this.rbAllStatus.AutoSize = true;
            this.rbAllStatus.Location = new System.Drawing.Point(29, 20);
            this.rbAllStatus.Name = "rbAllStatus";
            this.rbAllStatus.Size = new System.Drawing.Size(59, 16);
            this.rbAllStatus.TabIndex = 0;
            this.rbAllStatus.Text = "都显示";
            this.rbAllStatus.UseVisualStyleBackColor = true;
            this.rbAllStatus.CheckedChanged += new System.EventHandler(this.rbAllStatus_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(20, 438);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "新增(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.Location = new System.Drawing.Point(101, 438);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "插入(&I)";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(183, 438);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChildorder
            // 
            this.btnChildorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChildorder.Location = new System.Drawing.Point(265, 438);
            this.btnChildorder.Name = "btnChildorder";
            this.btnChildorder.Size = new System.Drawing.Size(75, 23);
            this.btnChildorder.TabIndex = 8;
            this.btnChildorder.Text = "子医嘱(&H)";
            this.btnChildorder.UseVisualStyleBackColor = true;
            this.btnChildorder.Click += new System.EventHandler(this.btnChildorder_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCommit.Location = new System.Drawing.Point(427, 438);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 9;
            this.btnCommit.Text = "提交(&T)";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(346, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDoctorOrder
            // 
            this.lblDoctorOrder.AutoSize = true;
            this.lblDoctorOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDoctorOrder.Location = new System.Drawing.Point(6, 273);
            this.lblDoctorOrder.Name = "lblDoctorOrder";
            this.lblDoctorOrder.Size = new System.Drawing.Size(53, 12);
            this.lblDoctorOrder.TabIndex = 12;
            this.lblDoctorOrder.Text = "医嘱本：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "已执行的医嘱：";
            // 
            // panelDiagnose
            // 
            this.panelDiagnose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDiagnose.Controls.Add(this.dgvGroupOrderItems);
            this.panelDiagnose.Controls.Add(this.lblCaption);
            this.panelDiagnose.Controls.Add(this.dgvPatDiagnose);
            this.panelDiagnose.Location = new System.Drawing.Point(267, 58);
            this.panelDiagnose.Name = "panelDiagnose";
            this.panelDiagnose.Size = new System.Drawing.Size(359, 210);
            this.panelDiagnose.TabIndex = 14;
            // 
            // dgvGroupOrderItems
            // 
            this.dgvGroupOrderItems.AllowUserToAddRows = false;
            this.dgvGroupOrderItems.AllowUserToDeleteRows = false;
            this.dgvGroupOrderItems.AllowUserToResizeRows = false;
            this.dgvGroupOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroupOrderItems.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvGroupOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REPEAT_INDICATOR_DISPLAY_G,
            this.ORDER_CLASS_DISPLAY_G,
            this.ORDER_TEXT_G,
            this.DOSAGE_G,
            this.DOSAGE_UNITS_G,
            this.ADMINISTRATION_G,
            this.FREQUENCY_G});
            this.dgvGroupOrderItems.Location = new System.Drawing.Point(1, 29);
            this.dgvGroupOrderItems.Name = "dgvGroupOrderItems";
            this.dgvGroupOrderItems.ReadOnly = true;
            this.dgvGroupOrderItems.RowHeadersVisible = false;
            this.dgvGroupOrderItems.RowTemplate.Height = 23;
            this.dgvGroupOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupOrderItems.Size = new System.Drawing.Size(352, 178);
            this.dgvGroupOrderItems.TabIndex = 16;
            this.dgvGroupOrderItems.Visible = false;
            // 
            // REPEAT_INDICATOR_DISPLAY_G
            // 
            this.REPEAT_INDICATOR_DISPLAY_G.DataPropertyName = "REPEAT_INDICATOR_DISPLAY";
            this.REPEAT_INDICATOR_DISPLAY_G.HeaderText = "长期";
            this.REPEAT_INDICATOR_DISPLAY_G.Name = "REPEAT_INDICATOR_DISPLAY_G";
            this.REPEAT_INDICATOR_DISPLAY_G.ReadOnly = true;
            this.REPEAT_INDICATOR_DISPLAY_G.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.REPEAT_INDICATOR_DISPLAY_G.Width = 40;
            // 
            // ORDER_CLASS_DISPLAY_G
            // 
            this.ORDER_CLASS_DISPLAY_G.DataPropertyName = "ORDER_CLASS_DISPLAY";
            this.ORDER_CLASS_DISPLAY_G.HeaderText = "类别";
            this.ORDER_CLASS_DISPLAY_G.Name = "ORDER_CLASS_DISPLAY_G";
            this.ORDER_CLASS_DISPLAY_G.ReadOnly = true;
            this.ORDER_CLASS_DISPLAY_G.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ORDER_CLASS_DISPLAY_G.Width = 35;
            // 
            // ORDER_TEXT_G
            // 
            this.ORDER_TEXT_G.DataPropertyName = "ORDER_TEXT";
            this.ORDER_TEXT_G.HeaderText = "医嘱内容";
            this.ORDER_TEXT_G.Name = "ORDER_TEXT_G";
            this.ORDER_TEXT_G.ReadOnly = true;
            this.ORDER_TEXT_G.Width = 250;
            // 
            // DOSAGE_G
            // 
            this.DOSAGE_G.DataPropertyName = "DOSAGE";
            this.DOSAGE_G.HeaderText = "剂量";
            this.DOSAGE_G.Name = "DOSAGE_G";
            this.DOSAGE_G.ReadOnly = true;
            this.DOSAGE_G.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DOSAGE_G.Width = 55;
            // 
            // DOSAGE_UNITS_G
            // 
            this.DOSAGE_UNITS_G.DataPropertyName = "DOSAGE_UNITS";
            this.DOSAGE_UNITS_G.HeaderText = "单位";
            this.DOSAGE_UNITS_G.Name = "DOSAGE_UNITS_G";
            this.DOSAGE_UNITS_G.ReadOnly = true;
            this.DOSAGE_UNITS_G.Width = 60;
            // 
            // ADMINISTRATION_G
            // 
            this.ADMINISTRATION_G.DataPropertyName = "ADMINISTRATION";
            this.ADMINISTRATION_G.HeaderText = "途径";
            this.ADMINISTRATION_G.Name = "ADMINISTRATION_G";
            this.ADMINISTRATION_G.ReadOnly = true;
            this.ADMINISTRATION_G.Width = 60;
            // 
            // FREQUENCY_G
            // 
            this.FREQUENCY_G.DataPropertyName = "FREQUENCY";
            this.FREQUENCY_G.HeaderText = "频次";
            this.FREQUENCY_G.Name = "FREQUENCY_G";
            this.FREQUENCY_G.ReadOnly = true;
            this.FREQUENCY_G.Width = 60;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCaption.Location = new System.Drawing.Point(4, 11);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(65, 12);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "当前诊断：";
            // 
            // dgvPatDiagnose
            // 
            this.dgvPatDiagnose.AllowUserToAddRows = false;
            this.dgvPatDiagnose.AllowUserToDeleteRows = false;
            this.dgvPatDiagnose.AllowUserToResizeRows = false;
            this.dgvPatDiagnose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatDiagnose.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatDiagnose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatDiagnose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.诊断类型,
            this.诊断名称,
            this.诊断日期,
            this.医师,
            this.诊断编码});
            this.dgvPatDiagnose.Location = new System.Drawing.Point(4, 29);
            this.dgvPatDiagnose.Name = "dgvPatDiagnose";
            this.dgvPatDiagnose.ReadOnly = true;
            this.dgvPatDiagnose.RowHeadersVisible = false;
            this.dgvPatDiagnose.RowTemplate.Height = 23;
            this.dgvPatDiagnose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatDiagnose.Size = new System.Drawing.Size(349, 178);
            this.dgvPatDiagnose.TabIndex = 0;
            // 
            // 诊断类型
            // 
            this.诊断类型.DataPropertyName = "诊断类型";
            this.诊断类型.HeaderText = "诊断类型";
            this.诊断类型.Name = "诊断类型";
            this.诊断类型.ReadOnly = true;
            this.诊断类型.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.诊断类型.Width = 90;
            // 
            // 诊断名称
            // 
            this.诊断名称.DataPropertyName = "诊断名称";
            this.诊断名称.HeaderText = "诊断名称";
            this.诊断名称.Name = "诊断名称";
            this.诊断名称.ReadOnly = true;
            this.诊断名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.诊断名称.Width = 200;
            // 
            // 诊断日期
            // 
            this.诊断日期.DataPropertyName = "诊断日期";
            this.诊断日期.HeaderText = "诊断日期";
            this.诊断日期.Name = "诊断日期";
            this.诊断日期.ReadOnly = true;
            this.诊断日期.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.诊断日期.Width = 110;
            // 
            // 医师
            // 
            this.医师.DataPropertyName = "医师";
            this.医师.HeaderText = "医师";
            this.医师.Name = "医师";
            this.医师.ReadOnly = true;
            this.医师.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.医师.Width = 60;
            // 
            // 诊断编码
            // 
            this.诊断编码.DataPropertyName = "诊断编码";
            this.诊断编码.HeaderText = "诊断编码";
            this.诊断编码.Name = "诊断编码";
            this.诊断编码.ReadOnly = true;
            this.诊断编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.诊断编码.Width = 110;
            // 
            // panelOrderGroup
            // 
            this.panelOrderGroup.Controls.Add(this.cbxPreviewGroupOrderItems);
            this.panelOrderGroup.Controls.Add(this.tabControl1);
            this.panelOrderGroup.Controls.Add(this.label4);
            this.panelOrderGroup.Location = new System.Drawing.Point(5, 58);
            this.panelOrderGroup.Name = "panelOrderGroup";
            this.panelOrderGroup.Size = new System.Drawing.Size(262, 210);
            this.panelOrderGroup.TabIndex = 15;
            // 
            // cbxPreviewGroupOrderItems
            // 
            this.cbxPreviewGroupOrderItems.AutoSize = true;
            this.cbxPreviewGroupOrderItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxPreviewGroupOrderItems.Location = new System.Drawing.Point(79, 11);
            this.cbxPreviewGroupOrderItems.Name = "cbxPreviewGroupOrderItems";
            this.cbxPreviewGroupOrderItems.Size = new System.Drawing.Size(96, 16);
            this.cbxPreviewGroupOrderItems.TabIndex = 2;
            this.cbxPreviewGroupOrderItems.Text = "预览套餐明细";
            this.cbxPreviewGroupOrderItems.UseVisualStyleBackColor = true;
            this.cbxPreviewGroupOrderItems.CheckedChanged += new System.EventHandler(this.cbxPreviewGroupOrderItems_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(256, 178);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvGroupOrderMaster);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(248, 153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "套餐医嘱";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvGroupOrderMaster
            // 
            this.dgvGroupOrderMaster.AllowUserToAddRows = false;
            this.dgvGroupOrderMaster.AllowUserToDeleteRows = false;
            this.dgvGroupOrderMaster.AllowUserToResizeRows = false;
            this.dgvGroupOrderMaster.BackgroundColor = System.Drawing.Color.White;
            this.dgvGroupOrderMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupOrderMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TITLE});
            this.dgvGroupOrderMaster.Location = new System.Drawing.Point(4, 4);
            this.dgvGroupOrderMaster.Name = "dgvGroupOrderMaster";
            this.dgvGroupOrderMaster.ReadOnly = true;
            this.dgvGroupOrderMaster.RowHeadersVisible = false;
            this.dgvGroupOrderMaster.RowTemplate.Height = 23;
            this.dgvGroupOrderMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupOrderMaster.Size = new System.Drawing.Size(240, 150);
            this.dgvGroupOrderMaster.TabIndex = 0;
            this.dgvGroupOrderMaster.DoubleClick += new System.EventHandler(this.dgvGroupOrderMaster_DoubleClick);
            this.dgvGroupOrderMaster.SelectionChanged += new System.EventHandler(this.dgvGroupOrderMaster_SelectionChanged);
            // 
            // TITLE
            // 
            this.TITLE.DataPropertyName = "TITLE";
            this.TITLE.HeaderText = "套餐医嘱名称";
            this.TITLE.Name = "TITLE";
            this.TITLE.ReadOnly = true;
            this.TITLE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TITLE.Width = 220;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "处方模板：";
            // 
            // dgvDoctorOrder
            // 
            this.dgvDoctorOrder.AllowUserToAddRows = false;
            this.dgvDoctorOrder.AllowUserToDeleteRows = false;
            this.dgvDoctorOrder.AllowUserToResizeRows = false;
            this.dgvDoctorOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoctorOrder.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvDoctorOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.repeat_indicator_d,
            this.ORDER_CLASS_D,
            this.start_date_time_d,
            this.order_text_d,
            this.drug_billing_attr_d,
            this.dosage_d,
            this.dosage_units_d,
            this.administration_d,
            this.frequency_d,
            this.FREQ_INTERVAL_D,
            this.FREQ_INTERVAL_UNIT_D,
            this.FREQ_COUNTER_D,
            this.DURATION_D,
            this.DURATION_UNITS_D,
            this.freq_detail_d,
            this.doctor_d,
            this.nurse_d});
            this.dgvDoctorOrder.Location = new System.Drawing.Point(5, 288);
            this.dgvDoctorOrder.Name = "dgvDoctorOrder";
            this.dgvDoctorOrder.RowHeadersVisible = false;
            this.dgvDoctorOrder.RowTemplate.Height = 23;
            this.dgvDoctorOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctorOrder.Size = new System.Drawing.Size(619, 143);
            this.dgvDoctorOrder.TabIndex = 4;
            this.dgvDoctorOrder.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDoctorOrder_CellBeginEdit);
            this.dgvDoctorOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDoctorOrder_CellFormatting);
            this.dgvDoctorOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctorOrder_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "警";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 20;
            // 
            // repeat_indicator_d
            // 
            this.repeat_indicator_d.DataPropertyName = "REPEAT_INDICATOR";
            this.repeat_indicator_d.HeaderText = "长期";
            this.repeat_indicator_d.Name = "repeat_indicator_d";
            this.repeat_indicator_d.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.repeat_indicator_d.Width = 35;
            // 
            // ORDER_CLASS_D
            // 
            this.ORDER_CLASS_D.DataPropertyName = "ORDER_CLASS";
            this.ORDER_CLASS_D.HeaderText = "类别";
            this.ORDER_CLASS_D.Name = "ORDER_CLASS_D";
            this.ORDER_CLASS_D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ORDER_CLASS_D.Width = 60;
            // 
            // start_date_time_d
            // 
            this.start_date_time_d.DataPropertyName = "START_DATE_TIME";
            this.start_date_time_d.HeaderText = "下达时间";
            this.start_date_time_d.Name = "start_date_time_d";
            this.start_date_time_d.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.start_date_time_d.Width = 110;
            // 
            // order_text_d
            // 
            this.order_text_d.DataPropertyName = "ORDER_TEXT";
            this.order_text_d.HeaderText = "医嘱内容";
            this.order_text_d.Name = "order_text_d";
            this.order_text_d.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.order_text_d.Width = 260;
            // 
            // drug_billing_attr_d
            // 
            this.drug_billing_attr_d.DataPropertyName = "DRUG_BILLING_ATTR";
            this.drug_billing_attr_d.FalseValue = "0";
            this.drug_billing_attr_d.HeaderText = "自";
            this.drug_billing_attr_d.Name = "drug_billing_attr_d";
            this.drug_billing_attr_d.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.drug_billing_attr_d.TrueValue = "1";
            this.drug_billing_attr_d.Width = 20;
            // 
            // dosage_d
            // 
            this.dosage_d.DataPropertyName = "DOSAGE";
            this.dosage_d.HeaderText = "剂量";
            this.dosage_d.Name = "dosage_d";
            this.dosage_d.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dosage_d.Width = 35;
            // 
            // dosage_units_d
            // 
            this.dosage_units_d.DataPropertyName = "DOSAGE_UNITS";
            this.dosage_units_d.HeaderText = "单位";
            this.dosage_units_d.Name = "dosage_units_d";
            this.dosage_units_d.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dosage_units_d.Width = 35;
            // 
            // administration_d
            // 
            this.administration_d.DataPropertyName = "ADMINISTRATION";
            this.administration_d.HeaderText = "途径";
            this.administration_d.Name = "administration_d";
            this.administration_d.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.administration_d.Width = 70;
            // 
            // frequency_d
            // 
            this.frequency_d.DataPropertyName = "FREQUENCY";
            this.frequency_d.HeaderText = "频次";
            this.frequency_d.Name = "frequency_d";
            this.frequency_d.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.frequency_d.Width = 53;
            // 
            // FREQ_INTERVAL_D
            // 
            this.FREQ_INTERVAL_D.DataPropertyName = "FREQ_INTERVAL";
            this.FREQ_INTERVAL_D.HeaderText = "日";
            this.FREQ_INTERVAL_D.Name = "FREQ_INTERVAL_D";
            this.FREQ_INTERVAL_D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FREQ_INTERVAL_D.Width = 25;
            // 
            // FREQ_INTERVAL_UNIT_D
            // 
            this.FREQ_INTERVAL_UNIT_D.DataPropertyName = "FREQ_INTERVAL_UNIT";
            this.FREQ_INTERVAL_UNIT_D.HeaderText = "/";
            this.FREQ_INTERVAL_UNIT_D.Items.AddRange(new object[] {
            "分钟",
            "小时",
            "日",
            "周",
            "月",
            "晚",
            "早"});
            this.FREQ_INTERVAL_UNIT_D.Name = "FREQ_INTERVAL_UNIT_D";
            this.FREQ_INTERVAL_UNIT_D.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FREQ_INTERVAL_UNIT_D.Width = 50;
            // 
            // FREQ_COUNTER_D
            // 
            this.FREQ_COUNTER_D.DataPropertyName = "FREQ_COUNTER";
            this.FREQ_COUNTER_D.HeaderText = "次";
            this.FREQ_COUNTER_D.Name = "FREQ_COUNTER_D";
            this.FREQ_COUNTER_D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FREQ_COUNTER_D.Width = 25;
            // 
            // DURATION_D
            // 
            this.DURATION_D.DataPropertyName = "DURATION";
            this.DURATION_D.HeaderText = "持";
            this.DURATION_D.Name = "DURATION_D";
            this.DURATION_D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DURATION_D.Width = 25;
            // 
            // DURATION_UNITS_D
            // 
            this.DURATION_UNITS_D.DataPropertyName = "DURATION_UNITS";
            this.DURATION_UNITS_D.HeaderText = "续";
            this.DURATION_UNITS_D.Items.AddRange(new object[] {
            "分钟",
            "小时",
            "日",
            "周",
            "月"});
            this.DURATION_UNITS_D.Name = "DURATION_UNITS_D";
            this.DURATION_UNITS_D.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DURATION_UNITS_D.Width = 50;
            // 
            // freq_detail_d
            // 
            this.freq_detail_d.DataPropertyName = "FREQ_DETAIL";
            this.freq_detail_d.HeaderText = "医生说明";
            this.freq_detail_d.Name = "freq_detail_d";
            this.freq_detail_d.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.freq_detail_d.Width = 60;
            // 
            // doctor_d
            // 
            this.doctor_d.DataPropertyName = "DOCTOR";
            this.doctor_d.HeaderText = "医生";
            this.doctor_d.Name = "doctor_d";
            this.doctor_d.ReadOnly = true;
            this.doctor_d.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.doctor_d.Width = 60;
            // 
            // nurse_d
            // 
            this.nurse_d.DataPropertyName = "NURSE";
            this.nurse_d.HeaderText = "护士";
            this.nurse_d.Name = "nurse_d";
            this.nurse_d.ReadOnly = true;
            this.nurse_d.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nurse_d.Width = 60;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvOrders.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repeat_indicator_display,
            this.order_class_display,
            this.start_date_time,
            this.order_text,
            this.dosage,
            this.dosage_units,
            this.administration,
            this.frequency,
            this.perform_schedule,
            this.duration,
            this.duration_units,
            this.stop_date_time,
            this.freq_counter,
            this.freq_interval,
            this.freq_interval_unit,
            this.freq_detail,
            this.doctor,
            this.stop_doctor,
            this.nurse,
            this.billing_attr});
            this.dgvOrders.Location = new System.Drawing.Point(5, 75);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowTemplate.Height = 23;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(619, 193);
            this.dgvOrders.TabIndex = 3;
            this.dgvOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrders_CellFormatting);
            // 
            // repeat_indicator_display
            // 
            this.repeat_indicator_display.DataPropertyName = "repeat_indicator_display";
            this.repeat_indicator_display.HeaderText = "长期";
            this.repeat_indicator_display.Name = "repeat_indicator_display";
            this.repeat_indicator_display.ReadOnly = true;
            this.repeat_indicator_display.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.repeat_indicator_display.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.repeat_indicator_display.Width = 35;
            // 
            // order_class_display
            // 
            this.order_class_display.DataPropertyName = "order_class_display";
            this.order_class_display.HeaderText = "类别";
            this.order_class_display.Name = "order_class_display";
            this.order_class_display.ReadOnly = true;
            this.order_class_display.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.order_class_display.Width = 35;
            // 
            // start_date_time
            // 
            this.start_date_time.DataPropertyName = "start_date_time";
            this.start_date_time.HeaderText = "开始时间";
            this.start_date_time.Name = "start_date_time";
            this.start_date_time.ReadOnly = true;
            this.start_date_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.start_date_time.Width = 110;
            // 
            // order_text
            // 
            this.order_text.DataPropertyName = "order_text";
            this.order_text.HeaderText = "医嘱内容";
            this.order_text.Name = "order_text";
            this.order_text.ReadOnly = true;
            this.order_text.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.order_text.Width = 200;
            // 
            // dosage
            // 
            this.dosage.DataPropertyName = "dosage";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dosage.DefaultCellStyle = dataGridViewCellStyle2;
            this.dosage.HeaderText = "剂量";
            this.dosage.Name = "dosage";
            this.dosage.ReadOnly = true;
            this.dosage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dosage.Width = 35;
            // 
            // dosage_units
            // 
            this.dosage_units.DataPropertyName = "dosage_units";
            this.dosage_units.HeaderText = "单位";
            this.dosage_units.Name = "dosage_units";
            this.dosage_units.ReadOnly = true;
            this.dosage_units.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dosage_units.Width = 35;
            // 
            // administration
            // 
            this.administration.DataPropertyName = "administration";
            this.administration.HeaderText = "途径";
            this.administration.Name = "administration";
            this.administration.ReadOnly = true;
            this.administration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.administration.Width = 53;
            // 
            // frequency
            // 
            this.frequency.DataPropertyName = "frequency";
            this.frequency.HeaderText = "频次";
            this.frequency.Name = "frequency";
            this.frequency.ReadOnly = true;
            this.frequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.frequency.Width = 50;
            // 
            // perform_schedule
            // 
            this.perform_schedule.DataPropertyName = "perform_schedule";
            this.perform_schedule.HeaderText = "执行时间";
            this.perform_schedule.Name = "perform_schedule";
            this.perform_schedule.ReadOnly = true;
            this.perform_schedule.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.perform_schedule.Width = 80;
            // 
            // duration
            // 
            this.duration.DataPropertyName = "duration";
            this.duration.HeaderText = "持";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.duration.Visible = false;
            this.duration.Width = 20;
            // 
            // duration_units
            // 
            this.duration_units.DataPropertyName = "duration_units";
            this.duration_units.HeaderText = "续";
            this.duration_units.Name = "duration_units";
            this.duration_units.ReadOnly = true;
            this.duration_units.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.duration_units.Visible = false;
            this.duration_units.Width = 20;
            // 
            // stop_date_time
            // 
            this.stop_date_time.DataPropertyName = "stop_date_time";
            this.stop_date_time.HeaderText = "停止时间";
            this.stop_date_time.Name = "stop_date_time";
            this.stop_date_time.ReadOnly = true;
            this.stop_date_time.Width = 110;
            // 
            // freq_counter
            // 
            this.freq_counter.DataPropertyName = "freq_counter";
            this.freq_counter.HeaderText = "次";
            this.freq_counter.Name = "freq_counter";
            this.freq_counter.ReadOnly = true;
            this.freq_counter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.freq_counter.Width = 20;
            // 
            // freq_interval
            // 
            this.freq_interval.DataPropertyName = "freq_interval";
            this.freq_interval.HeaderText = "/";
            this.freq_interval.Name = "freq_interval";
            this.freq_interval.ReadOnly = true;
            this.freq_interval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.freq_interval.Width = 20;
            // 
            // freq_interval_unit
            // 
            this.freq_interval_unit.DataPropertyName = "freq_interval_unit";
            this.freq_interval_unit.HeaderText = "日";
            this.freq_interval_unit.Name = "freq_interval_unit";
            this.freq_interval_unit.ReadOnly = true;
            this.freq_interval_unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.freq_interval_unit.Width = 20;
            // 
            // freq_detail
            // 
            this.freq_detail.DataPropertyName = "freq_detail";
            this.freq_detail.HeaderText = "医生说明";
            this.freq_detail.Name = "freq_detail";
            this.freq_detail.ReadOnly = true;
            this.freq_detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.freq_detail.Width = 60;
            // 
            // doctor
            // 
            this.doctor.DataPropertyName = "doctor";
            this.doctor.HeaderText = "下达医生";
            this.doctor.Name = "doctor";
            this.doctor.ReadOnly = true;
            this.doctor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.doctor.Width = 60;
            // 
            // stop_doctor
            // 
            this.stop_doctor.DataPropertyName = "stop_doctor";
            this.stop_doctor.HeaderText = "停止医生";
            this.stop_doctor.Name = "stop_doctor";
            this.stop_doctor.ReadOnly = true;
            this.stop_doctor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.stop_doctor.Width = 60;
            // 
            // nurse
            // 
            this.nurse.DataPropertyName = "nurse";
            this.nurse.HeaderText = "护士";
            this.nurse.Name = "nurse";
            this.nurse.ReadOnly = true;
            this.nurse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nurse.Width = 60;
            // 
            // billing_attr
            // 
            this.billing_attr.DataPropertyName = "billing_attr";
            this.billing_attr.HeaderText = "计价";
            this.billing_attr.Name = "billing_attr";
            this.billing_attr.ReadOnly = true;
            this.billing_attr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.billing_attr.Width = 35;
            // 
            // UCOrderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOrderGroup);
            this.Controls.Add(this.panelDiagnose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDoctorOrder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnChildorder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDoctorOrder);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCOrderMain";
            this.Size = new System.Drawing.Size(629, 474);
            this.Load += new System.EventHandler(this.UCOrderMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelDiagnose.ResumeLayout(false);
            this.panelDiagnose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatDiagnose)).EndInit();
            this.panelOrderGroup.ResumeLayout(false);
            this.panelOrderGroup.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupOrderMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTemp;
        private System.Windows.Forms.RadioButton rbRepeat;
        private System.Windows.Forms.RadioButton rbAllOrders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbCarried;
        private System.Windows.Forms.RadioButton rbAllStatus;
        private CCEMRDataGridView dgvOrders;
        private CCEMRDataGridView dgvDoctorOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChildorder;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDoctorOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeat_indicator_display;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_class_display;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosage_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn administration;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn perform_schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration_units;
        private System.Windows.Forms.DataGridViewTextBoxColumn stop_date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn freq_counter;
        private System.Windows.Forms.DataGridViewTextBoxColumn freq_interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn freq_interval_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn freq_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn stop_doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurse;
        private System.Windows.Forms.DataGridViewTextBoxColumn billing_attr;
        private System.Windows.Forms.Panel panelDiagnose;
        private System.Windows.Forms.Label lblCaption;
        private CCEMRDataGridView dgvPatDiagnose;
        private System.Windows.Forms.DataGridViewTextBoxColumn 诊断类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 诊断名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 诊断日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 医师;
        private System.Windows.Forms.DataGridViewTextBoxColumn 诊断编码;
        private System.Windows.Forms.Panel panelOrderGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private CCEMRDataGridView dgvGroupOrderMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
        private CCEMRDataGridView dgvGroupOrderItems;
        private System.Windows.Forms.CheckBox cbxPreviewGroupOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPEAT_INDICATOR_DISPLAY_G;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_CLASS_DISPLAY_G;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_TEXT_G;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOSAGE_G;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOSAGE_UNITS_G;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADMINISTRATION_G;
        private System.Windows.Forms.DataGridViewTextBoxColumn FREQUENCY_G;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeat_indicator_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_CLASS_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date_time_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_text_d;
        private System.Windows.Forms.DataGridViewCheckBoxColumn drug_billing_attr_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosage_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosage_units_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn administration_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequency_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn FREQ_INTERVAL_D;
        private System.Windows.Forms.DataGridViewComboBoxColumn FREQ_INTERVAL_UNIT_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn FREQ_COUNTER_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURATION_D;
        private System.Windows.Forms.DataGridViewComboBoxColumn DURATION_UNITS_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn freq_detail_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurse_d;
    }
}
