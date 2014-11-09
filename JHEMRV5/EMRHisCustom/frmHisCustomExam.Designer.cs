using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
namespace JHEMR.EMRHisCustom
{
    partial class frmHisCustomExam
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
            this.components = new Container();
            //ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmHisCustomExam));
            this.panel1 = new Panel();
            this.rgpClass = new RadioGroup();
            this.lblDoct = new Label();
            this.lblSex = new Label();
            this.lblID = new Label();
            this.lblName = new Label();
            this.lblWard = new Label();
            this.groupBox1 = new GroupBox();
            this.gcReqItems = new GridControl();
            this.gvReqItems = new GridView();
            this.NO = new GridColumn();
            this.ITEM_SUB_CLASS = new GridColumn();
            this.PART = new GridColumn();
            this.ITEM_NAME = new GridColumn();
            this.DEPT_NAME = new GridColumn();
            this.COST = new GridColumn();
            this.ITEM_CLASS = new GridColumn();
            this.PERFORMED_BY = new GridColumn();
            this.NOTICE = new GridColumn();
            this.lblDetail = new Label();
            this.sbtnAdd = new SimpleButton();
            this.txtMemo = new TextBox();
            this.txtItem = new TextBox();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.cmbSc = new System.Windows.Forms.ComboBox();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.sbtnDelete = new SimpleButton();
            this.sbtnSave = new SimpleButton();
            this.sbtnClose = new SimpleButton();
            this.chkPrint = new CheckEdit();
            this.panel3 = new Panel();
            this.tvExam = new TreeView();
            //this.imageList1 = new ImageList(this.components);
            this.statusStrip1 = new StatusStrip();
            this.toolSSLabel = new ToolStripStatusLabel();
            this.sbtnLook = new SimpleButton();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.rgpClass.Properties).BeginInit();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize)this.gcReqItems).BeginInit();
            ((ISupportInitialize)this.gvReqItems).BeginInit();
            ((ISupportInitialize)this.chkPrint.Properties).BeginInit();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            base.SuspendLayout();
            this.panel1.Controls.Add(this.rgpClass);
            this.panel1.Controls.Add(this.lblDoct);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblWard);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(765, 40);
            this.panel1.TabIndex = 0;
            this.rgpClass.Location = new Point(543, 9);
            this.rgpClass.Name = "rgpClass";
            this.rgpClass.Properties.Appearance.ForeColor = Color.FromArgb(0, 64, 0);
            this.rgpClass.Properties.Appearance.Options.UseForeColor = true;
            this.rgpClass.Properties.Items.AddRange(new RadioGroupItem[]
			{
				new RadioGroupItem(null, "套餐"),
				new RadioGroupItem(null, "单项")
			});
            this.rgpClass.Size = new Size(120, 24);
            this.rgpClass.TabIndex = 99;
            this.rgpClass.SelectedIndexChanged += new EventHandler(this.rgpClass_SelectedIndexChanged);
            this.lblDoct.AutoSize = true;
            this.lblDoct.ForeColor = Color.Blue;
            this.lblDoct.Location = new Point(430, 13);
            this.lblDoct.Name = "lblDoct";
            this.lblDoct.Size = new Size(67, 14);
            this.lblDoct.TabIndex = 99;
            this.lblDoct.Text = "主管医生：";
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = Color.Blue;
            this.lblSex.Location = new Point(358, 13);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new Size(43, 14);
            this.lblSex.TabIndex = 99;
            this.lblSex.Text = "性别：";
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = Color.Blue;
            this.lblID.Location = new Point(268, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new Size(31, 14);
            this.lblID.TabIndex = 99;
            this.lblID.Text = "ID：";
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = Color.Blue;
            this.lblName.Location = new Point(170, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(43, 14);
            this.lblName.TabIndex = 99;
            this.lblName.Text = "姓名：";
            this.lblWard.AutoSize = true;
            this.lblWard.ForeColor = Color.Blue;
            this.lblWard.Location = new Point(12, 13);
            this.lblWard.Name = "lblWard";
            this.lblWard.Size = new Size(38, 14);
            this.lblWard.TabIndex = 99;
            this.lblWard.Text = "label1";
            this.groupBox1.Controls.Add(this.gcReqItems);
            this.groupBox1.Controls.Add(this.lblDetail);
            this.groupBox1.Controls.Add(this.sbtnAdd);
            this.groupBox1.Controls.Add(this.txtMemo);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.cmbPart);
            this.groupBox1.Controls.Add(this.cmbSc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(535, 416);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "申请项目";
            this.gcReqItems.EmbeddedNavigator.Name = "";
            this.gcReqItems.Location = new Point(0, 190);
            this.gcReqItems.MainView = this.gvReqItems;
            this.gcReqItems.Name = "gcReqItems";
            this.gcReqItems.Size = new Size(535, 219);
            this.gcReqItems.TabIndex = 6;
            this.gcReqItems.ViewCollection.AddRange(new BaseView[]
			{
				this.gvReqItems
			});
            this.gvReqItems.Columns.AddRange(new GridColumn[]
			{
				this.NO,
				this.ITEM_SUB_CLASS,
				this.PART,
				this.ITEM_NAME,
				this.DEPT_NAME,
				this.COST,
				this.ITEM_CLASS,
				this.PERFORMED_BY,
				this.NOTICE
			});
            this.gvReqItems.GridControl = this.gcReqItems;
            this.gvReqItems.Name = "gvReqItems";
            this.gvReqItems.OptionsView.ColumnAutoWidth = false;
            this.gvReqItems.OptionsView.ShowGroupPanel = false;
            this.gvReqItems.OptionsView.ShowIndicator = false;
            this.NO.Caption = "序号";
            this.NO.FieldName = "NO";
            this.NO.Name = "NO";
            this.NO.OptionsColumn.AllowEdit = false;
            this.NO.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.NO.OptionsColumn.ReadOnly = true;
            this.NO.Visible = true;
            this.NO.VisibleIndex = 0;
            this.NO.Width = 44;
            this.ITEM_SUB_CLASS.Caption = "子分类";
            this.ITEM_SUB_CLASS.FieldName = "ITEM_SUB_CLASS";
            this.ITEM_SUB_CLASS.Name = "ITEM_SUB_CLASS";
            this.ITEM_SUB_CLASS.OptionsColumn.AllowEdit = false;
            this.ITEM_SUB_CLASS.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.ITEM_SUB_CLASS.OptionsColumn.ReadOnly = true;
            this.ITEM_SUB_CLASS.Visible = true;
            this.ITEM_SUB_CLASS.VisibleIndex = 1;
            this.ITEM_SUB_CLASS.Width = 62;
            this.PART.Caption = "部位";
            this.PART.FieldName = "PART";
            this.PART.Name = "PART";
            this.PART.OptionsColumn.AllowEdit = false;
            this.PART.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.PART.OptionsColumn.ReadOnly = true;
            this.PART.Visible = true;
            this.PART.VisibleIndex = 2;
            this.PART.Width = 102;
            this.ITEM_NAME.Caption = "项目名称";
            this.ITEM_NAME.FieldName = "ITEM_NAME";
            this.ITEM_NAME.Name = "ITEM_NAME";
            this.ITEM_NAME.OptionsColumn.AllowEdit = false;
            this.ITEM_NAME.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.ITEM_NAME.OptionsColumn.ReadOnly = true;
            this.ITEM_NAME.Visible = true;
            this.ITEM_NAME.VisibleIndex = 3;
            this.ITEM_NAME.Width = 159;
            this.DEPT_NAME.Caption = "执行科室";
            this.DEPT_NAME.FieldName = "DEPT_NAME";
            this.DEPT_NAME.Name = "DEPT_NAME";
            this.DEPT_NAME.OptionsColumn.AllowEdit = false;
            this.DEPT_NAME.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.DEPT_NAME.OptionsColumn.ReadOnly = true;
            this.DEPT_NAME.Visible = true;
            this.DEPT_NAME.VisibleIndex = 4;
            this.DEPT_NAME.Width = 142;
            this.COST.Caption = "COST";
            this.COST.FieldName = "COST";
            this.COST.Name = "COST";
            this.COST.OptionsColumn.AllowEdit = false;
            this.COST.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.COST.OptionsColumn.ReadOnly = true;
            this.ITEM_CLASS.Caption = "分类";
            this.ITEM_CLASS.FieldName = "ITEM_CLASS";
            this.ITEM_CLASS.Name = "ITEM_CLASS";
            this.ITEM_CLASS.OptionsColumn.AllowEdit = false;
            this.ITEM_CLASS.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.ITEM_CLASS.OptionsColumn.ReadOnly = true;
            this.PERFORMED_BY.Caption = "Performedby";
            this.PERFORMED_BY.FieldName = "PERFORMED_BY";
            this.PERFORMED_BY.Name = "PERFORMED_BY";
            this.PERFORMED_BY.OptionsColumn.AllowEdit = false;
            this.PERFORMED_BY.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.PERFORMED_BY.OptionsColumn.ReadOnly = true;
            this.NOTICE.Caption = "Memo";
            this.NOTICE.FieldName = "NOTICE";
            this.NOTICE.Name = "NOTICE";
            this.NOTICE.OptionsColumn.AllowEdit = false;
            this.NOTICE.OptionsColumn.AllowSort = DefaultBoolean.False;
            this.NOTICE.OptionsColumn.ReadOnly = true;
            this.lblDetail.AutoSize = true;
            this.lblDetail.ForeColor = Color.Red;
            this.lblDetail.Location = new Point(20, 151);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new Size(55, 14);
            this.lblDetail.TabIndex = 5;
            this.lblDetail.Text = "项目详情";
            this.sbtnAdd.Location = new Point(378, 54);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new Size(112, 23);
            this.sbtnAdd.TabIndex = 4;
            this.sbtnAdd.Text = "添加到列表(&A)";
            this.sbtnAdd.Click += new EventHandler(this.sbtnAdd_Click);
            this.txtMemo.Location = new Point(107, 86);
            this.txtMemo.MaxLength = 40;
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new Size(383, 42);
            this.txtMemo.TabIndex = 3;
            this.txtItem.Location = new Point(107, 57);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new Size(265, 21);
            this.txtItem.TabIndex = 2;
            this.txtItem.KeyDown += new KeyEventHandler(this.txtItem_KeyDown);
            this.txtItem.Leave += new EventHandler(this.txtItem_Leave);
            this.txtItem.MouseClick += new MouseEventHandler(this.txtItem_MouseClick);
            this.txtItem.Enter += new EventHandler(this.txtItem_Enter);
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new Point(316, 25);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new Size(137, 20);
            this.cmbPart.TabIndex = 1;
            this.cmbSc.FormattingEnabled = true;
            this.cmbSc.Location = new Point(107, 25);
            this.cmbSc.Name = "cmbSc";
            this.cmbSc.Size = new Size(103, 20);
            this.cmbSc.TabIndex = 0;
            this.cmbSc.SelectedIndexChanged += new EventHandler(this.cmbSc_SelectedIndexChanged);
            this.label5.AutoSize = true;
            this.label5.ForeColor = Color.Blue;
            this.label5.Location = new Point(20, 86);
            this.label5.Name = "label5";
            this.label5.Size = new Size(79, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "输入检查备注";
            this.label4.AutoSize = true;
            this.label4.ForeColor = Color.Blue;
            this.label4.Location = new Point(16, 100);
            this.label4.Name = "label4";
            this.label4.Size = new Size(65, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "(无则不填)";
            this.label3.AutoSize = true;
            this.label3.ForeColor = Color.Blue;
            this.label3.Location = new Point(31, 57);
            this.label3.Name = "label3";
            this.label3.Size = new Size(68, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "F9选择项目";
            this.label2.AutoSize = true;
            this.label2.ForeColor = Color.Blue;
            this.label2.Location = new Point(232, 25);
            this.label2.Name = "label2";
            this.label2.Size = new Size(79, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "选择项目部位";
            this.label1.AutoSize = true;
            this.label1.ForeColor = Color.Blue;
            this.label1.Location = new Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择项目子分类";
            this.sbtnDelete.Location = new Point(2, 468);
            this.sbtnDelete.Name = "sbtnDelete";
            this.sbtnDelete.Size = new Size(98, 23);
            this.sbtnDelete.TabIndex = 4;
            this.sbtnDelete.Text = "删除条目(&D)";
            this.sbtnDelete.Click += new EventHandler(this.sbtnDelete_Click);
            this.sbtnSave.Location = new Point(219, 468);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new Size(110, 23);
            this.sbtnSave.TabIndex = 4;
            this.sbtnSave.Text = "保存提交(&C)";
            this.sbtnSave.Click += new EventHandler(this.sbtnSave_Click);
            this.sbtnClose.Location = new Point(446, 468);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new Size(91, 23);
            this.sbtnClose.TabIndex = 4;
            this.sbtnClose.Text = "关闭窗口(&X)";
            this.sbtnClose.Click += new EventHandler(this.sbtnClose_Click);
            this.chkPrint.Location = new Point(99, 470);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Properties.Caption = "提交时打印申请单";
            this.chkPrint.Size = new Size(119, 19);
            this.chkPrint.TabIndex = 5;
            this.panel3.Controls.Add(this.tvExam);
            this.panel3.Location = new Point(541, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(219, 444);
            this.panel3.TabIndex = 6;
            this.tvExam.ImageIndex = 0;
            //this.tvExam.ImageList = this.imageList1;
            this.tvExam.Location = new Point(3, 3);
            this.tvExam.Name = "tvExam";
            this.tvExam.SelectedImageIndex = 0;
            this.tvExam.Size = new Size(216, 438);
            this.tvExam.TabIndex = 99;
            this.tvExam.AfterSelect += new TreeViewEventHandler(this.tvExam_AfterSelect);
            //this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            //this.imageList1.TransparentColor = Color.Transparent;
            //this.imageList1.Images.SetKeyName(0, "Cancel.ico");
            this.statusStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.toolSSLabel
			});
            this.statusStrip1.Location = new Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(765, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.toolSSLabel.ForeColor = Color.Red;
            this.toolSSLabel.Name = "toolSSLabel";
            this.toolSSLabel.Size = new Size(35, 17);
            this.toolSSLabel.Text = "Ready";
            this.sbtnLook.Location = new Point(339, 468);
            this.sbtnLook.Name = "sbtnLook";
            this.sbtnLook.Size = new Size(100, 23);
            this.sbtnLook.TabIndex = 4;
            this.sbtnLook.Text = "查看检查单状态";
            this.sbtnLook.Click += new EventHandler(this.sbtnLook_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            //base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(765, 526);
            base.Controls.Add(this.statusStrip1);
            base.Controls.Add(this.panel3);
            base.Controls.Add(this.chkPrint);
            base.Controls.Add(this.sbtnLook);
            base.Controls.Add(this.sbtnClose);
            base.Controls.Add(this.sbtnSave);
            base.Controls.Add(this.sbtnDelete);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.panel1);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmHisCustomExam";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "检查申请单";
            base.Load += new EventHandler(this.frmHisCustomExam_Load);
            base.Shown += new EventHandler(this.frmHisCustomExam_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.rgpClass.Properties).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((ISupportInitialize)this.gcReqItems).EndInit();
            ((ISupportInitialize)this.gvReqItems).EndInit();
            ((ISupportInitialize)this.chkPrint.Properties).EndInit();
            this.panel3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label lblWard;
        private Label lblDoct;
        private Label lblSex;
        private Label lblID;
        private Label lblName;
        private RadioGroup rgpClass;
        private GroupBox groupBox1;
        private SimpleButton sbtnDelete;
        private SimpleButton sbtnSave;
        private SimpleButton sbtnClose;
        private CheckEdit chkPrint;
        private Panel panel3;
        private TreeView tvExam;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtItem;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.ComboBox cmbSc;
        private Label label5;
        private SimpleButton sbtnAdd;
        private TextBox txtMemo;
        //private ImageList imageList1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolSSLabel;
        private SimpleButton sbtnLook;
        private Label lblDetail;
        private GridControl gcReqItems;
        private GridView gvReqItems;
        private GridColumn NO;
        private GridColumn ITEM_SUB_CLASS;
        private GridColumn PART;
        private GridColumn ITEM_NAME;
        private GridColumn DEPT_NAME;
        private GridColumn COST;
        private GridColumn ITEM_CLASS;
        private GridColumn PERFORMED_BY;
        private GridColumn NOTICE;
    }
}