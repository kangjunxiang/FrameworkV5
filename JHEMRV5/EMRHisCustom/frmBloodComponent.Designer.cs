using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using System.ComponentModel;
using System;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
namespace JHEMR.EMRHisCustom
{
    partial class frmBloodComponent
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
            this.splitContainer1 = new SplitContainer();
            this.splitContainer2 = new SplitContainer();
            this.grp1 = new GroupBox();
            this.gcApply = new GridControl();
            this.gvApply = new GridView();
            this.APPLY_NUM1 = new GridColumn();
            this.PAT_NAME = new GridColumn();
            this.PAT_SEX = new GridColumn();
            this.FEE_TYPE = new GridColumn();
            this.BLOOD_INUSE = new GridColumn();
            this.PAT_BLOOD_GROUP = new GridColumn();
            this.RH = new GridColumn();
            this.BLOOD_TABOO = new GridColumn();
            this.APPLY_DATE = new GridColumn();
            this.HEMATIN = new GridColumn();
            this.PLATELET = new GridColumn();
            this.LEUCOCYTE = new GridColumn();
            this.BLOOD_DIAGNOSE = new GridColumn();
            this.DOCTOR = new GridColumn();
            this.groupBox2 = new GroupBox();
            this.gcBLOODCAPACITY = new GridControl();
            this.gvBLOODCAPACITY = new GridView();
            this.MATCH_SUB_NUM = new GridColumn();
            this.FAST_SLOW = new GridColumn();
            this.repositoryItemLookUpEdit2 = new RepositoryItemLookUpEdit();
            this.TRANS_DATE = new GridColumn();
            this.repositoryItemDateEdit1 = new RepositoryItemDateEdit();
            this.BLOOD_TYPE = new GridColumn();
            this.repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
            this.TRANS_CAPACITY = new GridColumn();
            this.UNIT = new GridColumn();
            this.APPLY_NUM = new GridColumn();
            this.repositoryItemRadioGroup1 = new RepositoryItemRadioGroup();
            this.repositoryItemComboBox1 = new RepositoryItemComboBox();
            this.btnClose = new Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grp1.SuspendLayout();
            ((ISupportInitialize)this.gcApply).BeginInit();
            ((ISupportInitialize)this.gvApply).BeginInit();
            this.groupBox2.SuspendLayout();
            ((ISupportInitialize)this.gcBLOODCAPACITY).BeginInit();
            ((ISupportInitialize)this.gvBLOODCAPACITY).BeginInit();
            ((ISupportInitialize)this.repositoryItemLookUpEdit2).BeginInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1).BeginInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1.VistaTimeProperties).BeginInit();
            ((ISupportInitialize)this.repositoryItemLookUpEdit1).BeginInit();
            ((ISupportInitialize)this.repositoryItemRadioGroup1).BeginInit();
            ((ISupportInitialize)this.repositoryItemComboBox1).BeginInit();
            base.SuspendLayout();
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = Orientation.Horizontal;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Size = new Size(914, 471);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer2.Dock = DockStyle.Fill;
            this.splitContainer2.Location = new Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Panel1.Controls.Add(this.grp1);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new Size(914, 414);
            this.splitContainer2.SplitterDistance = 554;
            this.splitContainer2.TabIndex = 0;
            this.grp1.Controls.Add(this.gcApply);
            this.grp1.Dock = DockStyle.Fill;
            this.grp1.Location = new Point(0, 0);
            this.grp1.Name = "grp1";
            this.grp1.Size = new Size(554, 414);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            this.grp1.Text = "用血申请单";
            this.gcApply.Dock = DockStyle.Fill;
            this.gcApply.EmbeddedNavigator.Name = "";
            this.gcApply.Location = new Point(3, 17);
            this.gcApply.MainView = this.gvApply;
            this.gcApply.Name = "gcApply";
            this.gcApply.Size = new Size(548, 394);
            this.gcApply.TabIndex = 0;
            this.gcApply.ViewCollection.AddRange(new BaseView[]
			{
				this.gvApply
			});
            this.gvApply.Columns.AddRange(new GridColumn[]
			{
				this.APPLY_NUM1,
				this.PAT_NAME,
				this.PAT_SEX,
				this.FEE_TYPE,
				this.BLOOD_INUSE,
				this.PAT_BLOOD_GROUP,
				this.RH,
				this.BLOOD_TABOO,
				this.APPLY_DATE,
				this.HEMATIN,
				this.PLATELET,
				this.LEUCOCYTE,
				this.BLOOD_DIAGNOSE,
				this.DOCTOR
			});
            this.gvApply.GridControl = this.gcApply;
            this.gvApply.Name = "gvApply";
            this.gvApply.OptionsView.ColumnAutoWidth = false;
            this.gvApply.OptionsView.ShowGroupPanel = false;
            this.gvApply.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gvApply_FocusedRowChanged);
            this.gvApply.GotFocus += new EventHandler(this.gvApply_GotFocus);
            this.gvApply.DoubleClick += new EventHandler(this.gvApply_DoubleClick);
            this.APPLY_NUM1.Caption = "申请号";
            this.APPLY_NUM1.FieldName = "APPLY_NUM";
            this.APPLY_NUM1.Name = "APPLY_NUM1";
            this.APPLY_NUM1.OptionsColumn.AllowEdit = false;
            this.APPLY_NUM1.OptionsColumn.AllowMove = false;
            this.APPLY_NUM1.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.APPLY_NUM1.OptionsColumn.ReadOnly = true;
            this.APPLY_NUM1.Visible = true;
            this.APPLY_NUM1.VisibleIndex = 0;
            this.APPLY_NUM1.Width = 66;
            this.PAT_NAME.Caption = "姓名";
            this.PAT_NAME.FieldName = "PAT_NAME";
            this.PAT_NAME.Name = "PAT_NAME";
            this.PAT_NAME.OptionsColumn.AllowEdit = false;
            this.PAT_NAME.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.PAT_NAME.OptionsColumn.ReadOnly = true;
            this.PAT_NAME.Visible = true;
            this.PAT_NAME.VisibleIndex = 1;
            this.PAT_NAME.Width = 64;
            this.PAT_SEX.Caption = "性别";
            this.PAT_SEX.FieldName = "PAT_SEX";
            this.PAT_SEX.Name = "PAT_SEX";
            this.PAT_SEX.OptionsColumn.AllowEdit = false;
            this.PAT_SEX.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.PAT_SEX.OptionsColumn.ReadOnly = true;
            this.PAT_SEX.Visible = true;
            this.PAT_SEX.VisibleIndex = 2;
            this.PAT_SEX.Width = 44;
            this.FEE_TYPE.Caption = "费别";
            this.FEE_TYPE.FieldName = "FEE_TYPE";
            this.FEE_TYPE.Name = "FEE_TYPE";
            this.FEE_TYPE.OptionsColumn.AllowEdit = false;
            this.FEE_TYPE.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.FEE_TYPE.OptionsColumn.ReadOnly = true;
            this.FEE_TYPE.Visible = true;
            this.FEE_TYPE.VisibleIndex = 3;
            this.FEE_TYPE.Width = 47;
            this.BLOOD_INUSE.Caption = "血源";
            this.BLOOD_INUSE.FieldName = "BLOOD_INUSE";
            this.BLOOD_INUSE.Name = "BLOOD_INUSE";
            this.BLOOD_INUSE.OptionsColumn.AllowEdit = false;
            this.BLOOD_INUSE.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.BLOOD_INUSE.OptionsColumn.ReadOnly = true;
            this.BLOOD_INUSE.Visible = true;
            this.BLOOD_INUSE.VisibleIndex = 4;
            this.BLOOD_INUSE.Width = 45;
            this.PAT_BLOOD_GROUP.Caption = "血型";
            this.PAT_BLOOD_GROUP.FieldName = "PAT_BLOOD_GROUP";
            this.PAT_BLOOD_GROUP.Name = "PAT_BLOOD_GROUP";
            this.PAT_BLOOD_GROUP.OptionsColumn.AllowEdit = false;
            this.PAT_BLOOD_GROUP.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.PAT_BLOOD_GROUP.OptionsColumn.ReadOnly = true;
            this.PAT_BLOOD_GROUP.Visible = true;
            this.PAT_BLOOD_GROUP.VisibleIndex = 5;
            this.PAT_BLOOD_GROUP.Width = 49;
            this.RH.Caption = "RH";
            this.RH.FieldName = "RH";
            this.RH.Name = "RH";
            this.RH.OptionsColumn.AllowEdit = false;
            this.RH.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.RH.OptionsColumn.ReadOnly = true;
            this.RH.Visible = true;
            this.RH.VisibleIndex = 6;
            this.RH.Width = 42;
            this.BLOOD_TABOO.Caption = "禁忌";
            this.BLOOD_TABOO.FieldName = "BLOOD_TABOO";
            this.BLOOD_TABOO.Name = "BLOOD_TABOO";
            this.BLOOD_TABOO.OptionsColumn.AllowEdit = false;
            this.BLOOD_TABOO.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.BLOOD_TABOO.OptionsColumn.ReadOnly = true;
            this.BLOOD_TABOO.Visible = true;
            this.BLOOD_TABOO.VisibleIndex = 7;
            this.APPLY_DATE.Caption = "申请时间";
            this.APPLY_DATE.FieldName = "APPLY_DATE";
            this.APPLY_DATE.Name = "APPLY_DATE";
            this.APPLY_DATE.OptionsColumn.AllowEdit = false;
            this.APPLY_DATE.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.APPLY_DATE.OptionsColumn.ReadOnly = true;
            this.APPLY_DATE.Visible = true;
            this.APPLY_DATE.VisibleIndex = 8;
            this.HEMATIN.Caption = "血红蛋白";
            this.HEMATIN.FieldName = "HEMATIN";
            this.HEMATIN.Name = "HEMATIN";
            this.HEMATIN.OptionsColumn.AllowEdit = false;
            this.HEMATIN.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.HEMATIN.OptionsColumn.ReadOnly = true;
            this.HEMATIN.Visible = true;
            this.HEMATIN.VisibleIndex = 9;
            this.PLATELET.Caption = "血小板";
            this.PLATELET.FieldName = "PLATELET";
            this.PLATELET.Name = "PLATELET";
            this.PLATELET.OptionsColumn.AllowEdit = false;
            this.PLATELET.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.PLATELET.OptionsColumn.ReadOnly = true;
            this.PLATELET.Visible = true;
            this.PLATELET.VisibleIndex = 10;
            this.LEUCOCYTE.Caption = "白细胞";
            this.LEUCOCYTE.FieldName = "LEUCOCYTE";
            this.LEUCOCYTE.Name = "LEUCOCYTE";
            this.LEUCOCYTE.OptionsColumn.AllowEdit = false;
            this.LEUCOCYTE.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.LEUCOCYTE.OptionsColumn.ReadOnly = true;
            this.LEUCOCYTE.Visible = true;
            this.LEUCOCYTE.VisibleIndex = 11;
            this.BLOOD_DIAGNOSE.Caption = "临床诊断";
            this.BLOOD_DIAGNOSE.FieldName = "BLOOD_DIAGNOSE";
            this.BLOOD_DIAGNOSE.Name = "BLOOD_DIAGNOSE";
            this.BLOOD_DIAGNOSE.OptionsColumn.AllowEdit = false;
            this.BLOOD_DIAGNOSE.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.BLOOD_DIAGNOSE.OptionsColumn.ReadOnly = true;
            this.BLOOD_DIAGNOSE.Visible = true;
            this.BLOOD_DIAGNOSE.VisibleIndex = 12;
            this.DOCTOR.Caption = "申请医生";
            this.DOCTOR.FieldName = "DOCTOR";
            this.DOCTOR.Name = "DOCTOR";
            this.DOCTOR.OptionsColumn.AllowEdit = false;
            this.DOCTOR.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.DOCTOR.OptionsColumn.ReadOnly = true;
            this.DOCTOR.Visible = true;
            this.DOCTOR.VisibleIndex = 13;
            this.groupBox2.Controls.Add(this.gcBLOODCAPACITY);
            this.groupBox2.Dock = DockStyle.Fill;
            this.groupBox2.Location = new Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(356, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "申请血液信息";
            this.gcBLOODCAPACITY.Dock = DockStyle.Fill;
            this.gcBLOODCAPACITY.EmbeddedNavigator.Name = "";
            this.gcBLOODCAPACITY.Location = new Point(3, 17);
            this.gcBLOODCAPACITY.MainView = this.gvBLOODCAPACITY;
            this.gcBLOODCAPACITY.Name = "gcBLOODCAPACITY";
            this.gcBLOODCAPACITY.RepositoryItems.AddRange(new RepositoryItem[]
			{
				this.repositoryItemRadioGroup1,
				this.repositoryItemComboBox1,
				this.repositoryItemDateEdit1,
				this.repositoryItemLookUpEdit1,
				this.repositoryItemLookUpEdit2
			});
            this.gcBLOODCAPACITY.Size = new Size(350, 394);
            this.gcBLOODCAPACITY.TabIndex = 1;
            this.gcBLOODCAPACITY.ViewCollection.AddRange(new BaseView[]
			{
				this.gvBLOODCAPACITY
			});
            this.gvBLOODCAPACITY.Columns.AddRange(new GridColumn[]
			{
				this.MATCH_SUB_NUM,
				this.FAST_SLOW,
				this.TRANS_DATE,
				this.BLOOD_TYPE,
				this.TRANS_CAPACITY,
				this.UNIT,
				this.APPLY_NUM
			});
            this.gvBLOODCAPACITY.GridControl = this.gcBLOODCAPACITY;
            this.gvBLOODCAPACITY.Name = "gvBLOODCAPACITY";
            this.gvBLOODCAPACITY.OptionsView.ColumnAutoWidth = false;
            this.gvBLOODCAPACITY.OptionsView.ShowDetailButtons = false;
            this.gvBLOODCAPACITY.OptionsView.ShowGroupPanel = false;
            this.gvBLOODCAPACITY.OptionsView.ShowIndicator = false;
            this.MATCH_SUB_NUM.Caption = "序号";
            this.MATCH_SUB_NUM.FieldName = "NUM";
            this.MATCH_SUB_NUM.Name = "MATCH_SUB_NUM";
            this.MATCH_SUB_NUM.OptionsColumn.AllowEdit = false;
            this.MATCH_SUB_NUM.OptionsColumn.ReadOnly = true;
            this.MATCH_SUB_NUM.Width = 52;
            this.FAST_SLOW.Caption = "用血方式";
            this.FAST_SLOW.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.FAST_SLOW.FieldName = "FAST_SLOW";
            this.FAST_SLOW.Name = "FAST_SLOW";
            this.FAST_SLOW.OptionsColumn.AllowEdit = false;
            this.FAST_SLOW.OptionsColumn.ReadOnly = true;
            this.FAST_SLOW.Visible = true;
            this.FAST_SLOW.VisibleIndex = 0;
            this.FAST_SLOW.Width = 65;
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
            this.repositoryItemLookUpEdit2.DisplayMember = "name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ShowDropDown = ShowDropDown.Never;
            this.repositoryItemLookUpEdit2.ValueMember = "code";
            this.TRANS_DATE.Caption = "申请用血时间";
            this.TRANS_DATE.ColumnEdit = this.repositoryItemDateEdit1;
            this.TRANS_DATE.FieldName = "TRANS_DATE";
            this.TRANS_DATE.Name = "TRANS_DATE";
            this.TRANS_DATE.OptionsColumn.AllowEdit = false;
            this.TRANS_DATE.OptionsColumn.ReadOnly = true;
            this.TRANS_DATE.Visible = true;
            this.TRANS_DATE.VisibleIndex = 1;
            this.TRANS_DATE.Width = 107;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "g";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "g";
            this.repositoryItemDateEdit1.EditFormat.FormatType = FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "g";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton()
			});
            this.BLOOD_TYPE.Caption = "血液要求";
            this.BLOOD_TYPE.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.BLOOD_TYPE.FieldName = "BLOOD_TYPE";
            this.BLOOD_TYPE.Name = "BLOOD_TYPE";
            this.BLOOD_TYPE.OptionsColumn.AllowEdit = false;
            this.BLOOD_TYPE.OptionsColumn.ReadOnly = true;
            this.BLOOD_TYPE.Visible = true;
            this.BLOOD_TYPE.VisibleIndex = 2;
            this.BLOOD_TYPE.Width = 73;
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
            this.repositoryItemLookUpEdit1.DisplayMember = "BLOOD_TYPE_NAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ShowDropDown = ShowDropDown.Never;
            this.repositoryItemLookUpEdit1.ValueMember = "BLOOD_TYPE";
            this.TRANS_CAPACITY.Caption = "血量";
            this.TRANS_CAPACITY.FieldName = "TRANS_CAPACITY";
            this.TRANS_CAPACITY.Name = "TRANS_CAPACITY";
            this.TRANS_CAPACITY.OptionsColumn.AllowEdit = false;
            this.TRANS_CAPACITY.OptionsColumn.ReadOnly = true;
            this.TRANS_CAPACITY.Visible = true;
            this.TRANS_CAPACITY.VisibleIndex = 3;
            this.TRANS_CAPACITY.Width = 50;
            this.UNIT.Caption = "单位";
            this.UNIT.FieldName = "UNIT";
            this.UNIT.Name = "UNIT";
            this.UNIT.OptionsColumn.AllowEdit = false;
            this.UNIT.OptionsColumn.ReadOnly = true;
            this.UNIT.Width = 42;
            this.APPLY_NUM.Caption = "申请单号";
            this.APPLY_NUM.FieldName = "APPLY_NUM";
            this.APPLY_NUM.Name = "APPLY_NUM";
            this.APPLY_NUM.OptionsColumn.AllowEdit = false;
            this.APPLY_NUM.OptionsColumn.ReadOnly = true;
            this.repositoryItemRadioGroup1.Items.AddRange(new RadioGroupItem[]
			{
				new RadioGroupItem(null, "紧急"),
				new RadioGroupItem(null, "计划"),
				new RadioGroupItem(null, "备血")
			});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
            this.repositoryItemComboBox1.Items.AddRange(new object[]
			{
				"急诊",
				"计划",
				"备血"
			});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.btnClose.Location = new Point(792, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            //base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(914, 471);
            base.Controls.Add(this.splitContainer1);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmBloodComponent";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "输血申请单查看";
            base.Load += new EventHandler(this.frmBloodComponent_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.grp1.ResumeLayout(false);
            ((ISupportInitialize)this.gcApply).EndInit();
            ((ISupportInitialize)this.gvApply).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((ISupportInitialize)this.gcBLOODCAPACITY).EndInit();
            ((ISupportInitialize)this.gvBLOODCAPACITY).EndInit();
            ((ISupportInitialize)this.repositoryItemLookUpEdit2).EndInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1.VistaTimeProperties).EndInit();
            ((ISupportInitialize)this.repositoryItemDateEdit1).EndInit();
            ((ISupportInitialize)this.repositoryItemLookUpEdit1).EndInit();
            ((ISupportInitialize)this.repositoryItemRadioGroup1).EndInit();
            ((ISupportInitialize)this.repositoryItemComboBox1).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox grp1;
        private Button btnClose;
        private GroupBox groupBox2;
        private GridControl gcApply;
        private GridView gvApply;
        private GridControl gcBLOODCAPACITY;
        private GridView gvBLOODCAPACITY;
        private GridColumn MATCH_SUB_NUM;
        private GridColumn FAST_SLOW;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private GridColumn TRANS_DATE;
        private RepositoryItemDateEdit repositoryItemDateEdit1;
        private GridColumn BLOOD_TYPE;
        private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private GridColumn TRANS_CAPACITY;
        private GridColumn UNIT;
        private GridColumn APPLY_NUM;
        private RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private RepositoryItemComboBox repositoryItemComboBox1;
        private GridColumn APPLY_NUM1;
        private GridColumn PAT_NAME;
        private GridColumn PAT_SEX;
        private GridColumn FEE_TYPE;
        private GridColumn BLOOD_INUSE;
        private GridColumn BLOOD_DIAGNOSE;
        private GridColumn BLOOD_TABOO;
        private GridColumn APPLY_DATE;
        private GridColumn HEMATIN;
        private GridColumn PLATELET;
        private GridColumn LEUCOCYTE;
        private GridColumn PAT_BLOOD_GROUP;
        private GridColumn RH;
        private GridColumn DOCTOR;
    }
}