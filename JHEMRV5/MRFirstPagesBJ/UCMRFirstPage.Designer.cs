using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using JHEMR.EmrSysUserCtl;
using System.ComponentModel;
using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
namespace JHEMR.MRFirstPagesBJ
{
    partial class UCMRFirstPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtHospitalName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.txtVisit_id = new System.Windows.Forms.TextBox();
            this.txtInp_no = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtDate_of_birth = new System.Windows.Forms.MaskedTextBox();
            this.txtMARITAL_STATUS = new System.Windows.Forms.TextBox();
            this.txtOCCUPATION = new System.Windows.Forms.TextBox();
            this.txtBIRTH_PLACE = new System.Windows.Forms.TextBox();
            this.txtNATION = new System.Windows.Forms.TextBox();
            this.txtCITIZENSHIP = new System.Windows.Forms.TextBox();
            this.txtID_NO = new System.Windows.Forms.TextBox();
            this.txtSERVICE_AGENCY = new System.Windows.Forms.TextBox();
            this.txtPHONE_NUMBER_BUSINESS = new System.Windows.Forms.TextBox();
            this.txtZIP_CODE = new System.Windows.Forms.TextBox();
            this.txtRegistered_p_r_address = new System.Windows.Forms.TextBox();
            this.txtRegistered_p_r_address_zip = new System.Windows.Forms.TextBox();
            this.txtNEXT_OF_KIN = new System.Windows.Forms.TextBox();
            this.txtNEXT_OF_KIN_ADDR = new System.Windows.Forms.TextBox();
            this.txtNEXT_OF_KIN_PHONE = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.txtRELATIONSHIP = new System.Windows.Forms.TextBox();
            this.txtADMISSION_DATE_TIME = new System.Windows.Forms.TextBox();
            this.txtDEPT_ADMISSION_TO = new System.Windows.Forms.TextBox();
            this.txtdept_transfer = new System.Windows.Forms.TextBox();
            this.txtDISCHARGE_DATE_TIME = new System.Windows.Forms.TextBox();
            this.txtDEPT_DISCHARGE_FROM = new System.Windows.Forms.TextBox();
            this.txtward_discharge_from = new System.Windows.Forms.TextBox();
            this.txtInhospitaldays = new System.Windows.Forms.TextBox();
            this.txtALERGY_DRUGS = new System.Windows.Forms.TextBox();
            this.txtDIRECTOR = new System.Windows.Forms.TextBox();
            this.txtCHIEF_DOCTOR = new System.Windows.Forms.TextBox();
            this.txtATTENDING_DOCTOR = new System.Windows.Forms.TextBox();
            this.txtDOCTOR_IN_CHARGE = new System.Windows.Forms.TextBox();
            this.txtCATALOGER = new System.Windows.Forms.TextBox();
            this.txtDOCTOR_OF_CONTROL_QUALITY = new System.Windows.Forms.TextBox();
            this.txtNURSE_OF_CONTROL_QUALITY = new System.Windows.Forms.TextBox();
            this.txtDATE_OF_CONTROL_QUALITY = new System.Windows.Forms.TextBox();
            this.txtMedical_pay_way = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtBLOOD_TYPE = new System.Windows.Forms.TextBox();
            this.txtBLOOD_TYPE_RH = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnOperDel = new System.Windows.Forms.Button();
            this.btnOperInsert = new System.Windows.Forms.Button();
            this.lbItemSel = new System.Windows.Forms.ListBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnCustomOper = new System.Windows.Forms.Button();
            this.btnAddCustomDiag = new System.Windows.Forms.Button();
            this.btnAddCustomOper = new System.Windows.Forms.Button();
            this.label90 = new System.Windows.Forms.Label();
            this.txtdischarge_disposition = new System.Windows.Forms.TextBox();
            this.btnMrDiagnose = new System.Windows.Forms.Button();
            this.label184 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label186 = new System.Windows.Forms.Label();
            this.label187 = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.comMR_QUALITY = new System.Windows.Forms.ComboBox();
            this.txtMR_QUALITY = new System.Windows.Forms.TextBox();
            this.comAUTOPSY_INDICATOR = new System.Windows.Forms.ComboBox();
            this.txtAUTOPSY_INDICATOR = new System.Windows.Forms.TextBox();
            this.comBLOOD_TYPE = new System.Windows.Forms.ComboBox();
            this.comBLOOD_TYPE_RH = new System.Windows.Forms.ComboBox();
            this.comSex = new System.Windows.Forms.ComboBox();
            this.comMARITAL_STATUS = new System.Windows.Forms.ComboBox();
            this.comMedical_pay_way = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvDiagnose = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.diagnosis_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis_desc_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treat_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_treat_indicator = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.diagnosis_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADMISSION_CONDITIONS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.treat_result = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFee5 = new System.Windows.Forms.TextBox();
            this.txtHy = new System.Windows.Forms.TextBox();
            this.txtJs = new System.Windows.Forms.TextBox();
            this.txtJc = new System.Windows.Forms.TextBox();
            this.txtZcny = new System.Windows.Forms.TextBox();
            this.txtFee3 = new System.Windows.Forms.TextBox();
            this.txtFee2 = new System.Windows.Forms.TextBox();
            this.txtFee11 = new System.Windows.Forms.TextBox();
            this.txtFee10 = new System.Windows.Forms.TextBox();
            this.txtFee9 = new System.Windows.Forms.TextBox();
            this.txtSy = new System.Windows.Forms.TextBox();
            this.txtFee8 = new System.Windows.Forms.TextBox();
            this.txtFee7 = new System.Windows.Forms.TextBox();
            this.txtPc = new System.Windows.Forms.TextBox();
            this.txtYe = new System.Windows.Forms.TextBox();
            this.txtMz = new System.Windows.Forms.TextBox();
            this.txtFee1 = new System.Windows.Forms.TextBox();
            this.txtTOTAL_PAYMENTS = new System.Windows.Forms.TextBox();
            this.label167 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvOperation = new JHEMR.EmrSysUserCtl.CCEMRDataGridView();
            this.operation_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operating_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operating_grade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.operation_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operator1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STERILE_HEAL = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.first_assistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.second_assistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wound_grade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.heal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.anaesthesia_method = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.anesthesia_doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.检查标志 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISMAIN = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ILLNESS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.INFFECT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OPERACCORD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtward_admission_to = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.label112 = new System.Windows.Forms.Label();
            this.txtADVANCED_STUDIES_DOCTOR = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.txtLIABILITY_NURSE_ID = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPRACTICE_DOCTOR = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.txtBABYAGE = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.label102 = new System.Windows.Forms.Label();
            this.txtBABY_WEIGHT = new System.Windows.Forms.TextBox();
            this.txtBABY_R_WEIGHT = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.txtJIGUAN = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.txtCurrent_Address = new System.Windows.Forms.TextBox();
            this.label105 = new System.Windows.Forms.Label();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.txtCurrent_Address_PHOTO = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.txtCurrent_Address_Zip_Code = new System.Windows.Forms.TextBox();
            this.label107 = new System.Windows.Forms.Label();
            this.comRUYUAN_PASS = new System.Windows.Forms.ComboBox();
            this.txtRUYUAN_PASS = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.textdiagnosis_desc28 = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.txtdiagnosis_code28 = new System.Windows.Forms.TextBox();
            this.label121 = new System.Windows.Forms.Label();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.txtBLH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comYWGM = new System.Windows.Forms.ComboBox();
            this.txtYWGM = new System.Windows.Forms.TextBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comDISCHARGE_PASS = new System.Windows.Forms.ComboBox();
            this.txtDISCHARGE_PASS = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtZYMC = new System.Windows.Forms.TextBox();
            this.txtZYJG = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comZRYJH = new System.Windows.Forms.ComboBox();
            this.txtZRYJH = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.txtZYMD = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cmdBLOOD_TYPE = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtCOST_TOTAL = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtCOST_ZH_YBYL = new System.Windows.Forms.TextBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtCOST_OWNPAY = new System.Windows.Forms.TextBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtCOST_ZD_SYS = new System.Windows.Forms.TextBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtCOST_ZH_HL = new System.Windows.Forms.TextBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtCOST_ZH_OTHER = new System.Windows.Forms.TextBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtCOST_ZD_BL = new System.Windows.Forms.TextBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtCOST_ZD_YXX = new System.Windows.Forms.TextBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtCOST_ZH_YBZL = new System.Windows.Forms.TextBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.label50 = new System.Windows.Forms.Label();
            this.txtCOST_ZD_LCXM = new System.Windows.Forms.TextBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtCOST_ZL_FSSZLXM = new System.Windows.Forms.TextBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtCOST_ZL_LCWLZL = new System.Windows.Forms.TextBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtCOST_ZL_SSZL = new System.Windows.Forms.TextBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.label58 = new System.Windows.Forms.Label();
            this.txtCOST_ZL_MZ = new System.Windows.Forms.TextBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txtCOST_ZL_SS = new System.Windows.Forms.TextBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.label60 = new System.Windows.Forms.Label();
            this.txtCOST_KF_KF = new System.Windows.Forms.TextBox();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.label64 = new System.Windows.Forms.Label();
            this.txtCOST_ZY_ZYZL = new System.Windows.Forms.TextBox();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.label65 = new System.Windows.Forms.Label();
            this.txtCOST_XY_XY = new System.Windows.Forms.TextBox();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.label67 = new System.Windows.Forms.Label();
            this.txtCOST_ZY_ZCHY = new System.Windows.Forms.TextBox();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.txtCOST_XY_KJYW = new System.Windows.Forms.TextBox();
            this.txtCOST_ZY_ZCAOY = new System.Windows.Forms.TextBox();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.label87 = new System.Windows.Forms.Label();
            this.txtCOST_XY_XF = new System.Windows.Forms.TextBox();
            this.pictureBox71 = new System.Windows.Forms.PictureBox();
            this.label89 = new System.Windows.Forms.Label();
            this.txtCOST_XY_BDB = new System.Windows.Forms.TextBox();
            this.pictureBox72 = new System.Windows.Forms.PictureBox();
            this.label91 = new System.Windows.Forms.Label();
            this.txtCOST_XY_QDB = new System.Windows.Forms.TextBox();
            this.pictureBox73 = new System.Windows.Forms.PictureBox();
            this.label93 = new System.Windows.Forms.Label();
            this.txtCOST_XY_NXYZ = new System.Windows.Forms.TextBox();
            this.pictureBox74 = new System.Windows.Forms.PictureBox();
            this.label94 = new System.Windows.Forms.Label();
            this.txtCOST_XY_XBYZ = new System.Windows.Forms.TextBox();
            this.pictureBox75 = new System.Windows.Forms.PictureBox();
            this.label95 = new System.Windows.Forms.Label();
            this.txtCOST_HC_JC = new System.Windows.Forms.TextBox();
            this.pictureBox76 = new System.Windows.Forms.PictureBox();
            this.label100 = new System.Windows.Forms.Label();
            this.txtCOST_HC_ZL = new System.Windows.Forms.TextBox();
            this.pictureBox77 = new System.Windows.Forms.PictureBox();
            this.label109 = new System.Windows.Forms.Label();
            this.txtCOST_HC_SS = new System.Windows.Forms.TextBox();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            this.label116 = new System.Windows.Forms.Label();
            this.txtCOST_OTHER = new System.Windows.Forms.TextBox();
            this.pictureBox79 = new System.Windows.Forms.PictureBox();
            this.label118 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.pictureBox85 = new System.Windows.Forms.PictureBox();
            this.pictureBox82 = new System.Windows.Forms.PictureBox();
            this.pictureBox84 = new System.Windows.Forms.PictureBox();
            this.pictureBox81 = new System.Windows.Forms.PictureBox();
            this.pictureBox83 = new System.Windows.Forms.PictureBox();
            this.pictureBox80 = new System.Windows.Forms.PictureBox();
            this.txtLNSS_A_HOSPITAL_MIN = new System.Windows.Forms.TextBox();
            this.txtLNSS_P_HOSPITAL_MIN = new System.Windows.Forms.TextBox();
            this.txtLNSS_A_HOSPITAL_HOURS = new System.Windows.Forms.TextBox();
            this.txtLNSS_P_HOSPITAL_HOURS = new System.Windows.Forms.TextBox();
            this.txtLNSS_A_HOSPITAL_DAYS = new System.Windows.Forms.TextBox();
            this.txtLNSS_P_HOSPITAL_DAYS = new System.Windows.Forms.TextBox();
            this.label127 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.txtAge2 = new System.Windows.Forms.TextBox();
            this.pictureBox86 = new System.Windows.Forms.PictureBox();
            this.label130 = new System.Windows.Forms.Label();
            this.pictureBox87 = new System.Windows.Forms.PictureBox();
            this.pictureBox88 = new System.Windows.Forms.PictureBox();
            this.pictureBox89 = new System.Windows.Forms.PictureBox();
            this.label131 = new System.Windows.Forms.Label();
            this.txtATTEMD_DOCTOR = new System.Windows.Forms.TextBox();
            this.label132 = new System.Windows.Forms.Label();
            this.txtCurrent_Address_Detail = new System.Windows.Forms.TextBox();
            this.txtRegistered_p_r_address_detail = new System.Windows.Forms.TextBox();
            this.pictureBox90 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox91 = new System.Windows.Forms.PictureBox();
            this.gridControlGraveWard = new DevExpress.XtraGrid.GridControl();
            this.gridViewGraveWard = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label133 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.pictureBox92 = new System.Windows.Forms.PictureBox();
            this.txtRESPIRATOR_USE_TIME = new System.Windows.Forms.TextBox();
            this.pictureBox93 = new System.Windows.Forms.PictureBox();
            this.pictureBox94 = new System.Windows.Forms.PictureBox();
            this.txtADL_DISCHARGE = new System.Windows.Forms.TextBox();
            this.txtADL_ADMISSION = new System.Windows.Forms.TextBox();
            this.label141 = new System.Windows.Forms.Label();
            this.pictureBox95 = new System.Windows.Forms.PictureBox();
            this.pictureBox96 = new System.Windows.Forms.PictureBox();
            this.pictureBox97 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.txtTUMOR_STAGE_T = new System.Windows.Forms.TextBox();
            this.comTUMOR_STAGE_T = new System.Windows.Forms.ComboBox();
            this.txtTUMOR_STAGE_N = new System.Windows.Forms.TextBox();
            this.comTUMOR_STAGE_N = new System.Windows.Forms.ComboBox();
            this.txtTUMOR_STAGE_M = new System.Windows.Forms.TextBox();
            this.comTUMOR_STAGE_M = new System.Windows.Forms.ComboBox();
            this.txtFOLLOW_DATETIME = new System.Windows.Forms.TextBox();
            this.label145 = new System.Windows.Forms.Label();
            this.txtFOLLOW_INTERVAL_UNITS = new System.Windows.Forms.TextBox();
            this.txtFOLLOW_INDICATOR = new System.Windows.Forms.TextBox();
            this.comFOLLOW_INTERVAL_UNITS = new System.Windows.Forms.ComboBox();
            this.comFOLLOW_INDICATOR = new System.Windows.Forms.ComboBox();
            this.txtFOLLOW_INTERVAL = new System.Windows.Forms.TextBox();
            this.pictureBox98 = new System.Windows.Forms.PictureBox();
            this.label147 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.txtFOLLOW_WAY = new System.Windows.Forms.TextBox();
            this.comFOLLOW_WAY = new System.Windows.Forms.ComboBox();
            this.label146 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.comNOON = new System.Windows.Forms.ComboBox();
            this.pictureBox99 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label151 = new System.Windows.Forms.Label();
            this.txtDISCHARGE_CONDITIONS = new System.Windows.Forms.TextBox();
            this.comDISCHARGE_CONDITIONS = new System.Windows.Forms.ComboBox();
            this.label152 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGraveWard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGraveWard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHospitalName
            // 
            this.txtHospitalName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHospitalName.ForeColor = System.Drawing.Color.Teal;
            this.txtHospitalName.Location = new System.Drawing.Point(258, 48);
            this.txtHospitalName.Name = "txtHospitalName";
            this.txtHospitalName.Size = new System.Drawing.Size(269, 24);
            this.txtHospitalName.TabIndex = 479;
            this.txtHospitalName.Text = "某某医院";
            this.txtHospitalName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(280, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 478;
            this.label1.Text = "住 院 病 案 首 页";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(44, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 481;
            this.label2.Text = "医疗付费方式：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(634, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 483;
            this.label9.Text = "病案号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(401, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 484;
            this.label8.Text = "次住院";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(363, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 482;
            this.label6.Text = "第";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(613, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 514;
            this.label11.Text = "邮编：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(49, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 513;
            this.label7.Text = "户口地址：";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Enabled = false;
            this.label81.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label81.ForeColor = System.Drawing.Color.Gray;
            this.label81.Location = new System.Drawing.Point(598, 409);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(59, 13);
            this.label81.TabIndex = 512;
            this.label81.Text = "实际住院";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Enabled = false;
            this.label79.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label79.ForeColor = System.Drawing.Color.Gray;
            this.label79.Location = new System.Drawing.Point(489, 409);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(41, 12);
            this.label79.TabIndex = 511;
            this.label79.Text = "病房：";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Enabled = false;
            this.label77.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label77.ForeColor = System.Drawing.Color.Gray;
            this.label77.Location = new System.Drawing.Point(305, 409);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(65, 12);
            this.label77.TabIndex = 510;
            this.label77.Text = "出院科别：";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Enabled = false;
            this.label68.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label68.ForeColor = System.Drawing.Color.Gray;
            this.label68.Location = new System.Drawing.Point(85, 409);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(65, 12);
            this.label68.TabIndex = 509;
            this.label68.Text = "出院日期：";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Enabled = false;
            this.label66.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label66.ForeColor = System.Drawing.Color.Gray;
            this.label66.Location = new System.Drawing.Point(598, 378);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(72, 13);
            this.label66.TabIndex = 508;
            this.label66.Text = "转科科别：";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Enabled = false;
            this.label53.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label53.ForeColor = System.Drawing.Color.Gray;
            this.label53.Location = new System.Drawing.Point(85, 378);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(65, 12);
            this.label53.TabIndex = 505;
            this.label53.Text = "入院日期：";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Enabled = false;
            this.label43.ForeColor = System.Drawing.Color.Gray;
            this.label43.Location = new System.Drawing.Point(613, 302);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(41, 12);
            this.label43.TabIndex = 501;
            this.label43.Text = "邮编：";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Enabled = false;
            this.label39.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.ForeColor = System.Drawing.Color.Gray;
            this.label39.Location = new System.Drawing.Point(47, 303);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(101, 12);
            this.label39.TabIndex = 499;
            this.label39.Text = "工作单位及地址：";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Enabled = false;
            this.label37.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.ForeColor = System.Drawing.Color.Gray;
            this.label37.Location = new System.Drawing.Point(51, 228);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 12);
            this.label37.TabIndex = 498;
            this.label37.Text = "身份证号：";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Enabled = false;
            this.label35.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.ForeColor = System.Drawing.Color.Gray;
            this.label35.Location = new System.Drawing.Point(546, 152);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(41, 12);
            this.label35.TabIndex = 497;
            this.label35.Text = "国籍：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Enabled = false;
            this.label28.ForeColor = System.Drawing.Color.Gray;
            this.label28.Location = new System.Drawing.Point(547, 228);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(209, 12);
            this.label28.TabIndex = 493;
            this.label28.Text = "1.未婚 2.已婚 3.丧偶 4.离婚 5.其他";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(237, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "１.男 ２.女";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Enabled = false;
            this.label29.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.ForeColor = System.Drawing.Color.Gray;
            this.label29.Location = new System.Drawing.Point(323, 228);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 494;
            this.label29.Text = "职业：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Enabled = false;
            this.label26.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.ForeColor = System.Drawing.Color.Gray;
            this.label26.Location = new System.Drawing.Point(454, 228);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 492;
            this.label26.Text = "婚姻：";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.ForeColor = System.Drawing.Color.Gray;
            this.label24.Location = new System.Drawing.Point(432, 152);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 491;
            this.label24.Text = "年龄：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(305, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 490;
            this.label17.Text = "出生：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(68, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 487;
            this.label12.Text = "姓名：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(161, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 488;
            this.label14.Text = "性别：";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Enabled = false;
            this.label33.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.ForeColor = System.Drawing.Color.Gray;
            this.label33.Location = new System.Drawing.Point(530, 205);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 12);
            this.label33.TabIndex = 496;
            this.label33.Text = "民族：";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Enabled = false;
            this.label45.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label45.ForeColor = System.Drawing.Color.Gray;
            this.label45.Location = new System.Drawing.Point(47, 329);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(77, 12);
            this.label45.TabIndex = 502;
            this.label45.Text = "联系人姓名：";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Enabled = false;
            this.label51.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label51.ForeColor = System.Drawing.Color.Gray;
            this.label51.Location = new System.Drawing.Point(612, 329);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(46, 13);
            this.label51.TabIndex = 504;
            this.label51.Text = "电话：";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Enabled = false;
            this.label62.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label62.ForeColor = System.Drawing.Color.Gray;
            this.label62.Location = new System.Drawing.Point(305, 378);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(65, 12);
            this.label62.TabIndex = 506;
            this.label62.Text = "入院科别：";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Enabled = false;
            this.label31.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.ForeColor = System.Drawing.Color.Gray;
            this.label31.Location = new System.Drawing.Point(51, 204);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 495;
            this.label31.Text = "出生地：";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Enabled = false;
            this.label41.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.ForeColor = System.Drawing.Color.Gray;
            this.label41.Location = new System.Drawing.Point(451, 302);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 12);
            this.label41.TabIndex = 500;
            this.label41.Text = "电话：";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Enabled = false;
            this.label49.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label49.ForeColor = System.Drawing.Color.Gray;
            this.label49.Location = new System.Drawing.Point(303, 329);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 12);
            this.label49.TabIndex = 503;
            this.label49.Text = "地址：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.ForeColor = System.Drawing.Color.Teal;
            this.label23.Location = new System.Drawing.Point(554, 1182);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 544;
            this.label23.Text = "日期：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(259, 1182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 542;
            this.label13.Text = "质控医师";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(130, 1182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 541;
            this.label10.Text = "1.甲 2.乙 3.丙";
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label168.ForeColor = System.Drawing.Color.Teal;
            this.label168.Location = new System.Drawing.Point(35, 1182);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(59, 13);
            this.label168.TabIndex = 540;
            this.label168.Text = "病案质量";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label166.ForeColor = System.Drawing.Color.Teal;
            this.label166.Location = new System.Drawing.Point(3, 63);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(59, 13);
            this.label166.TabIndex = 538;
            this.label166.Text = "实习医师";
            this.label166.Visible = false;
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label164.ForeColor = System.Drawing.Color.Teal;
            this.label164.Location = new System.Drawing.Point(1, 43);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(98, 13);
            this.label164.TabIndex = 537;
            this.label164.Text = "研究生实习医师";
            this.label164.Visible = false;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label162.ForeColor = System.Drawing.Color.Teal;
            this.label162.Location = new System.Drawing.Point(4, 24);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(59, 13);
            this.label162.TabIndex = 536;
            this.label162.Text = "进修医师";
            this.label162.Visible = false;
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label160.ForeColor = System.Drawing.Color.Teal;
            this.label160.Location = new System.Drawing.Point(609, 890);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(59, 13);
            this.label160.TabIndex = 535;
            this.label160.Text = "住院医师";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label158.ForeColor = System.Drawing.Color.Teal;
            this.label158.Location = new System.Drawing.Point(437, 890);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(59, 13);
            this.label158.TabIndex = 534;
            this.label158.Text = "主治医师";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label156.ForeColor = System.Drawing.Color.Teal;
            this.label156.Location = new System.Drawing.Point(211, 890);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(99, 13);
            this.label156.TabIndex = 533;
            this.label156.Text = "主(副主)任医师";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label154.ForeColor = System.Drawing.Color.Teal;
            this.label154.Location = new System.Drawing.Point(43, 890);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(46, 13);
            this.label154.TabIndex = 532;
            this.label154.Text = "科主任";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label126.ForeColor = System.Drawing.Color.Teal;
            this.label126.Location = new System.Drawing.Point(245, 776);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(72, 13);
            this.label126.TabIndex = 517;
            this.label126.Text = "药物过敏：";
            // 
            // label57
            // 
            this.label57.ForeColor = System.Drawing.Color.Teal;
            this.label57.Location = new System.Drawing.Point(103, 1929);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(544, 23);
            this.label57.TabIndex = 598;
            this.label57.Text = "       5.商业医疗保险  6.全公费  7.全自费  8.其他社会保险  9.其他";
            this.label57.Click += new System.EventHandler(this.label57_Click);
            // 
            // label56
            // 
            this.label56.ForeColor = System.Drawing.Color.Teal;
            this.label56.Location = new System.Drawing.Point(48, 1908);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(666, 19);
            this.label56.TabIndex = 597;
            this.label56.Text = "说明：（一）医疗付费方式  1.城镇职工基本医疗保险  2.城镇居民基本医疗保险 3.新型农村合作医疗 4.贫困救助  ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Teal;
            this.label20.Location = new System.Drawing.Point(381, 861);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 573;
            this.label20.Text = "RH";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.Teal;
            this.label46.Location = new System.Drawing.Point(453, 861);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(155, 12);
            this.label46.TabIndex = 560;
            this.label46.Text = "1. 阴 2. 阳 3.不详 4.未查";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.ForeColor = System.Drawing.Color.Teal;
            this.label61.Location = new System.Drawing.Point(131, 861);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(221, 12);
            this.label61.TabIndex = 590;
            this.label61.Text = " 1. A 2. B 3. O 4. AB 5. 不详 6.未查";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.ForeColor = System.Drawing.Color.Teal;
            this.label63.Location = new System.Drawing.Point(48, 861);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(41, 12);
            this.label63.TabIndex = 593;
            this.label63.Text = "血型：";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.ForeColor = System.Drawing.Color.Teal;
            this.label69.Location = new System.Drawing.Point(650, 776);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(71, 12);
            this.label69.TabIndex = 591;
            this.label69.Text = "1. 是 2. 否";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.ForeColor = System.Drawing.Color.Teal;
            this.label70.Location = new System.Drawing.Point(504, 776);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(89, 12);
            this.label70.TabIndex = 592;
            this.label70.Text = "死亡患者尸检：";
            // 
            // txtVisit_id
            // 
            this.txtVisit_id.BackColor = System.Drawing.Color.White;
            this.txtVisit_id.Location = new System.Drawing.Point(380, 119);
            this.txtVisit_id.Name = "txtVisit_id";
            this.txtVisit_id.Size = new System.Drawing.Size(20, 21);
            this.txtVisit_id.TabIndex = 607;
            this.txtVisit_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInp_no
            // 
            this.txtInp_no.BackColor = System.Drawing.Color.White;
            this.txtInp_no.Location = new System.Drawing.Point(681, 120);
            this.txtInp_no.Name = "txtInp_no";
            this.txtInp_no.ReadOnly = true;
            this.txtInp_no.Size = new System.Drawing.Size(84, 21);
            this.txtInp_no.TabIndex = 608;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Enabled = false;
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(104, 151);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(56, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.White;
            this.txtSex.Enabled = false;
            this.txtSex.ForeColor = System.Drawing.Color.Gray;
            this.txtSex.Location = new System.Drawing.Point(201, 151);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(16, 21);
            this.txtSex.TabIndex = 2;
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSex.DoubleClick += new System.EventHandler(this.txtSex_DoubleClick);
            this.txtSex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSex_KeyDown);
            // 
            // txtDate_of_birth
            // 
            this.txtDate_of_birth.BackColor = System.Drawing.Color.White;
            this.txtDate_of_birth.ForeColor = System.Drawing.Color.Gray;
            this.txtDate_of_birth.Location = new System.Drawing.Point(341, 151);
            this.txtDate_of_birth.Name = "txtDate_of_birth";
            this.txtDate_of_birth.Size = new System.Drawing.Size(93, 21);
            this.txtDate_of_birth.TabIndex = 3;
            this.txtDate_of_birth.ValidatingType = typeof(System.DateTime);
            this.txtDate_of_birth.DoubleClick += new System.EventHandler(this.txtDate_of_birth_DoubleClick);
            this.txtDate_of_birth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_of_birth_KeyDown);
            // 
            // txtMARITAL_STATUS
            // 
            this.txtMARITAL_STATUS.BackColor = System.Drawing.Color.White;
            this.txtMARITAL_STATUS.ForeColor = System.Drawing.Color.Gray;
            this.txtMARITAL_STATUS.Location = new System.Drawing.Point(496, 227);
            this.txtMARITAL_STATUS.Name = "txtMARITAL_STATUS";
            this.txtMARITAL_STATUS.Size = new System.Drawing.Size(17, 21);
            this.txtMARITAL_STATUS.TabIndex = 5;
            this.txtMARITAL_STATUS.Tag = "－";
            this.txtMARITAL_STATUS.Text = "－";
            this.txtMARITAL_STATUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMARITAL_STATUS.WordWrap = false;
            // 
            // txtOCCUPATION
            // 
            this.txtOCCUPATION.BackColor = System.Drawing.Color.White;
            this.txtOCCUPATION.ForeColor = System.Drawing.Color.Gray;
            this.txtOCCUPATION.Location = new System.Drawing.Point(364, 227);
            this.txtOCCUPATION.Name = "txtOCCUPATION";
            this.txtOCCUPATION.Size = new System.Drawing.Size(64, 21);
            this.txtOCCUPATION.TabIndex = 6;
            // 
            // txtBIRTH_PLACE
            // 
            this.txtBIRTH_PLACE.BackColor = System.Drawing.Color.White;
            this.txtBIRTH_PLACE.ForeColor = System.Drawing.Color.Gray;
            this.txtBIRTH_PLACE.Location = new System.Drawing.Point(104, 203);
            this.txtBIRTH_PLACE.Name = "txtBIRTH_PLACE";
            this.txtBIRTH_PLACE.Size = new System.Drawing.Size(204, 21);
            this.txtBIRTH_PLACE.TabIndex = 7;
            // 
            // txtNATION
            // 
            this.txtNATION.BackColor = System.Drawing.Color.White;
            this.txtNATION.ForeColor = System.Drawing.Color.Gray;
            this.txtNATION.Location = new System.Drawing.Point(569, 204);
            this.txtNATION.Name = "txtNATION";
            this.txtNATION.Size = new System.Drawing.Size(65, 21);
            this.txtNATION.TabIndex = 8;
            // 
            // txtCITIZENSHIP
            // 
            this.txtCITIZENSHIP.BackColor = System.Drawing.Color.White;
            this.txtCITIZENSHIP.ForeColor = System.Drawing.Color.Gray;
            this.txtCITIZENSHIP.Location = new System.Drawing.Point(586, 151);
            this.txtCITIZENSHIP.Name = "txtCITIZENSHIP";
            this.txtCITIZENSHIP.Size = new System.Drawing.Size(58, 21);
            this.txtCITIZENSHIP.TabIndex = 9;
            // 
            // txtID_NO
            // 
            this.txtID_NO.BackColor = System.Drawing.Color.White;
            this.txtID_NO.ForeColor = System.Drawing.Color.Gray;
            this.txtID_NO.Location = new System.Drawing.Point(115, 227);
            this.txtID_NO.Name = "txtID_NO";
            this.txtID_NO.Size = new System.Drawing.Size(193, 21);
            this.txtID_NO.TabIndex = 10;
            // 
            // txtSERVICE_AGENCY
            // 
            this.txtSERVICE_AGENCY.BackColor = System.Drawing.Color.White;
            this.txtSERVICE_AGENCY.ForeColor = System.Drawing.Color.Gray;
            this.txtSERVICE_AGENCY.Location = new System.Drawing.Point(143, 301);
            this.txtSERVICE_AGENCY.Name = "txtSERVICE_AGENCY";
            this.txtSERVICE_AGENCY.Size = new System.Drawing.Size(305, 21);
            this.txtSERVICE_AGENCY.TabIndex = 11;
            // 
            // txtPHONE_NUMBER_BUSINESS
            // 
            this.txtPHONE_NUMBER_BUSINESS.BackColor = System.Drawing.Color.White;
            this.txtPHONE_NUMBER_BUSINESS.ForeColor = System.Drawing.Color.Gray;
            this.txtPHONE_NUMBER_BUSINESS.Location = new System.Drawing.Point(487, 301);
            this.txtPHONE_NUMBER_BUSINESS.Name = "txtPHONE_NUMBER_BUSINESS";
            this.txtPHONE_NUMBER_BUSINESS.Size = new System.Drawing.Size(117, 21);
            this.txtPHONE_NUMBER_BUSINESS.TabIndex = 12;
            this.txtPHONE_NUMBER_BUSINESS.TextChanged += new System.EventHandler(this.txtPHONE_NUMBER_BUSINESS_TextChanged);
            // 
            // txtZIP_CODE
            // 
            this.txtZIP_CODE.BackColor = System.Drawing.Color.White;
            this.txtZIP_CODE.ForeColor = System.Drawing.Color.Gray;
            this.txtZIP_CODE.Location = new System.Drawing.Point(657, 300);
            this.txtZIP_CODE.Name = "txtZIP_CODE";
            this.txtZIP_CODE.Size = new System.Drawing.Size(91, 21);
            this.txtZIP_CODE.TabIndex = 13;
            // 
            // txtRegistered_p_r_address
            // 
            this.txtRegistered_p_r_address.BackColor = System.Drawing.Color.White;
            this.txtRegistered_p_r_address.ForeColor = System.Drawing.Color.Gray;
            this.txtRegistered_p_r_address.Location = new System.Drawing.Point(114, 274);
            this.txtRegistered_p_r_address.Name = "txtRegistered_p_r_address";
            this.txtRegistered_p_r_address.Size = new System.Drawing.Size(152, 21);
            this.txtRegistered_p_r_address.TabIndex = 14;
            // 
            // txtRegistered_p_r_address_zip
            // 
            this.txtRegistered_p_r_address_zip.BackColor = System.Drawing.Color.White;
            this.txtRegistered_p_r_address_zip.ForeColor = System.Drawing.Color.Gray;
            this.txtRegistered_p_r_address_zip.Location = new System.Drawing.Point(656, 274);
            this.txtRegistered_p_r_address_zip.Name = "txtRegistered_p_r_address_zip";
            this.txtRegistered_p_r_address_zip.Size = new System.Drawing.Size(91, 21);
            this.txtRegistered_p_r_address_zip.TabIndex = 15;
            // 
            // txtNEXT_OF_KIN
            // 
            this.txtNEXT_OF_KIN.BackColor = System.Drawing.Color.White;
            this.txtNEXT_OF_KIN.ForeColor = System.Drawing.Color.Gray;
            this.txtNEXT_OF_KIN.Location = new System.Drawing.Point(119, 330);
            this.txtNEXT_OF_KIN.Name = "txtNEXT_OF_KIN";
            this.txtNEXT_OF_KIN.Size = new System.Drawing.Size(73, 21);
            this.txtNEXT_OF_KIN.TabIndex = 16;
            // 
            // txtNEXT_OF_KIN_ADDR
            // 
            this.txtNEXT_OF_KIN_ADDR.BackColor = System.Drawing.Color.White;
            this.txtNEXT_OF_KIN_ADDR.ForeColor = System.Drawing.Color.Gray;
            this.txtNEXT_OF_KIN_ADDR.Location = new System.Drawing.Point(344, 329);
            this.txtNEXT_OF_KIN_ADDR.Name = "txtNEXT_OF_KIN_ADDR";
            this.txtNEXT_OF_KIN_ADDR.Size = new System.Drawing.Size(267, 21);
            this.txtNEXT_OF_KIN_ADDR.TabIndex = 18;
            // 
            // txtNEXT_OF_KIN_PHONE
            // 
            this.txtNEXT_OF_KIN_PHONE.BackColor = System.Drawing.Color.White;
            this.txtNEXT_OF_KIN_PHONE.ForeColor = System.Drawing.Color.Gray;
            this.txtNEXT_OF_KIN_PHONE.Location = new System.Drawing.Point(657, 329);
            this.txtNEXT_OF_KIN_PHONE.Name = "txtNEXT_OF_KIN_PHONE";
            this.txtNEXT_OF_KIN_PHONE.Size = new System.Drawing.Size(91, 21);
            this.txtNEXT_OF_KIN_PHONE.TabIndex = 19;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Enabled = false;
            this.label78.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label78.ForeColor = System.Drawing.Color.Gray;
            this.label78.Location = new System.Drawing.Point(194, 328);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(41, 12);
            this.label78.TabIndex = 626;
            this.label78.Text = "关系：";
            // 
            // txtRELATIONSHIP
            // 
            this.txtRELATIONSHIP.BackColor = System.Drawing.Color.White;
            this.txtRELATIONSHIP.ForeColor = System.Drawing.Color.Gray;
            this.txtRELATIONSHIP.Location = new System.Drawing.Point(229, 330);
            this.txtRELATIONSHIP.Name = "txtRELATIONSHIP";
            this.txtRELATIONSHIP.Size = new System.Drawing.Size(71, 21);
            this.txtRELATIONSHIP.TabIndex = 17;
            // 
            // txtADMISSION_DATE_TIME
            // 
            this.txtADMISSION_DATE_TIME.BackColor = System.Drawing.Color.White;
            this.txtADMISSION_DATE_TIME.Enabled = false;
            this.txtADMISSION_DATE_TIME.ForeColor = System.Drawing.Color.Gray;
            this.txtADMISSION_DATE_TIME.Location = new System.Drawing.Point(149, 377);
            this.txtADMISSION_DATE_TIME.Name = "txtADMISSION_DATE_TIME";
            this.txtADMISSION_DATE_TIME.ReadOnly = true;
            this.txtADMISSION_DATE_TIME.Size = new System.Drawing.Size(142, 21);
            this.txtADMISSION_DATE_TIME.TabIndex = 20;
            // 
            // txtDEPT_ADMISSION_TO
            // 
            this.txtDEPT_ADMISSION_TO.BackColor = System.Drawing.Color.White;
            this.txtDEPT_ADMISSION_TO.Enabled = false;
            this.txtDEPT_ADMISSION_TO.ForeColor = System.Drawing.Color.Gray;
            this.txtDEPT_ADMISSION_TO.Location = new System.Drawing.Point(366, 377);
            this.txtDEPT_ADMISSION_TO.Name = "txtDEPT_ADMISSION_TO";
            this.txtDEPT_ADMISSION_TO.ReadOnly = true;
            this.txtDEPT_ADMISSION_TO.Size = new System.Drawing.Size(121, 21);
            this.txtDEPT_ADMISSION_TO.TabIndex = 21;
            this.txtDEPT_ADMISSION_TO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDEPT_ADMISSION_TO_KeyDown);
            // 
            // txtdept_transfer
            // 
            this.txtdept_transfer.BackColor = System.Drawing.Color.White;
            this.txtdept_transfer.Enabled = false;
            this.txtdept_transfer.ForeColor = System.Drawing.Color.Gray;
            this.txtdept_transfer.Location = new System.Drawing.Point(659, 377);
            this.txtdept_transfer.Name = "txtdept_transfer";
            this.txtdept_transfer.ReadOnly = true;
            this.txtdept_transfer.Size = new System.Drawing.Size(103, 21);
            this.txtdept_transfer.TabIndex = 23;
            this.txtdept_transfer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdept_transfer_KeyDown);
            // 
            // txtDISCHARGE_DATE_TIME
            // 
            this.txtDISCHARGE_DATE_TIME.BackColor = System.Drawing.Color.White;
            this.txtDISCHARGE_DATE_TIME.ForeColor = System.Drawing.Color.Gray;
            this.txtDISCHARGE_DATE_TIME.Location = new System.Drawing.Point(145, 408);
            this.txtDISCHARGE_DATE_TIME.Name = "txtDISCHARGE_DATE_TIME";
            this.txtDISCHARGE_DATE_TIME.Size = new System.Drawing.Size(145, 21);
            this.txtDISCHARGE_DATE_TIME.TabIndex = 24;
            this.txtDISCHARGE_DATE_TIME.DragOver += new System.Windows.Forms.DragEventHandler(this.txtDISCHARGE_DATE_TIME_DragOver);
            this.txtDISCHARGE_DATE_TIME.DoubleClick += new System.EventHandler(this.txtDISCHARGE_DATE_TIME_DoubleClick1);
            this.txtDISCHARGE_DATE_TIME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDISCHARGE_DATE_TIME_KeyDown1);
            // 
            // txtDEPT_DISCHARGE_FROM
            // 
            this.txtDEPT_DISCHARGE_FROM.BackColor = System.Drawing.Color.White;
            this.txtDEPT_DISCHARGE_FROM.Enabled = false;
            this.txtDEPT_DISCHARGE_FROM.ForeColor = System.Drawing.Color.Gray;
            this.txtDEPT_DISCHARGE_FROM.Location = new System.Drawing.Point(366, 408);
            this.txtDEPT_DISCHARGE_FROM.Name = "txtDEPT_DISCHARGE_FROM";
            this.txtDEPT_DISCHARGE_FROM.ReadOnly = true;
            this.txtDEPT_DISCHARGE_FROM.Size = new System.Drawing.Size(121, 21);
            this.txtDEPT_DISCHARGE_FROM.TabIndex = 25;
            this.txtDEPT_DISCHARGE_FROM.DoubleClick += new System.EventHandler(this.txtDEPT_DISCHARGE_FROM_DoubleClick);
            this.txtDEPT_DISCHARGE_FROM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDEPT_DISCHARGE_FROM_KeyDown);
            // 
            // txtward_discharge_from
            // 
            this.txtward_discharge_from.BackColor = System.Drawing.Color.White;
            this.txtward_discharge_from.Enabled = false;
            this.txtward_discharge_from.ForeColor = System.Drawing.Color.Gray;
            this.txtward_discharge_from.Location = new System.Drawing.Point(526, 408);
            this.txtward_discharge_from.Name = "txtward_discharge_from";
            this.txtward_discharge_from.Size = new System.Drawing.Size(56, 21);
            this.txtward_discharge_from.TabIndex = 26;
            // 
            // txtInhospitaldays
            // 
            this.txtInhospitaldays.BackColor = System.Drawing.Color.White;
            this.txtInhospitaldays.Enabled = false;
            this.txtInhospitaldays.ForeColor = System.Drawing.Color.Gray;
            this.txtInhospitaldays.Location = new System.Drawing.Point(671, 408);
            this.txtInhospitaldays.Name = "txtInhospitaldays";
            this.txtInhospitaldays.ReadOnly = true;
            this.txtInhospitaldays.Size = new System.Drawing.Size(55, 21);
            this.txtInhospitaldays.TabIndex = 27;
            this.txtInhospitaldays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInhospitaldays.TextChanged += new System.EventHandler(this.txtInhospitaldays_TextChanged);
            // 
            // txtALERGY_DRUGS
            // 
            this.txtALERGY_DRUGS.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtALERGY_DRUGS.Location = new System.Drawing.Point(319, 775);
            this.txtALERGY_DRUGS.Name = "txtALERGY_DRUGS";
            this.txtALERGY_DRUGS.Size = new System.Drawing.Size(177, 21);
            this.txtALERGY_DRUGS.TabIndex = 35;
            this.txtALERGY_DRUGS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtALERGY_DRUGS_KeyDown);
            // 
            // txtDIRECTOR
            // 
            this.txtDIRECTOR.Location = new System.Drawing.Point(99, 889);
            this.txtDIRECTOR.Name = "txtDIRECTOR";
            this.txtDIRECTOR.ShortcutsEnabled = false;
            this.txtDIRECTOR.Size = new System.Drawing.Size(80, 21);
            this.txtDIRECTOR.TabIndex = 1010;
            this.txtDIRECTOR.DoubleClick += new System.EventHandler(this.txtDIRECTOR_DoubleClick);
            this.txtDIRECTOR.Leave += new System.EventHandler(this.txtDIRECTOR_Leave);
            this.txtDIRECTOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDIRECTOR_KeyPress);
            // 
            // txtCHIEF_DOCTOR
            // 
            this.txtCHIEF_DOCTOR.Location = new System.Drawing.Point(318, 889);
            this.txtCHIEF_DOCTOR.Name = "txtCHIEF_DOCTOR";
            this.txtCHIEF_DOCTOR.Size = new System.Drawing.Size(80, 21);
            this.txtCHIEF_DOCTOR.TabIndex = 1011;
            this.txtCHIEF_DOCTOR.DoubleClick += new System.EventHandler(this.txtCHIEF_DOCTOR_DoubleClick);
            this.txtCHIEF_DOCTOR.Leave += new System.EventHandler(this.txtCHIEF_DOCTOR_Leave);
            this.txtCHIEF_DOCTOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDIRECTOR_KeyPress);
            // 
            // txtATTENDING_DOCTOR
            // 
            this.txtATTENDING_DOCTOR.Location = new System.Drawing.Point(511, 889);
            this.txtATTENDING_DOCTOR.Name = "txtATTENDING_DOCTOR";
            this.txtATTENDING_DOCTOR.Size = new System.Drawing.Size(80, 21);
            this.txtATTENDING_DOCTOR.TabIndex = 1012;
            this.txtATTENDING_DOCTOR.DoubleClick += new System.EventHandler(this.txtATTENDING_DOCTOR_DoubleClick);
            this.txtATTENDING_DOCTOR.Leave += new System.EventHandler(this.txtATTENDING_DOCTOR_Leave);
            this.txtATTENDING_DOCTOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDIRECTOR_KeyPress);
            // 
            // txtDOCTOR_IN_CHARGE
            // 
            this.txtDOCTOR_IN_CHARGE.Location = new System.Drawing.Point(677, 889);
            this.txtDOCTOR_IN_CHARGE.Name = "txtDOCTOR_IN_CHARGE";
            this.txtDOCTOR_IN_CHARGE.Size = new System.Drawing.Size(80, 21);
            this.txtDOCTOR_IN_CHARGE.TabIndex = 1013;
            this.txtDOCTOR_IN_CHARGE.DoubleClick += new System.EventHandler(this.txtDOCTOR_IN_CHARGE_DoubleClick);
            this.txtDOCTOR_IN_CHARGE.Leave += new System.EventHandler(this.txtDOCTOR_IN_CHARGE_Leave);
            this.txtDOCTOR_IN_CHARGE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDIRECTOR_KeyPress);
            // 
            // txtCATALOGER
            // 
            this.txtCATALOGER.BackColor = System.Drawing.Color.White;
            this.txtCATALOGER.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.txtCATALOGER.ForeColor = System.Drawing.Color.Red;
            this.txtCATALOGER.Location = new System.Drawing.Point(676, 927);
            this.txtCATALOGER.Name = "txtCATALOGER";
            this.txtCATALOGER.ReadOnly = true;
            this.txtCATALOGER.Size = new System.Drawing.Size(80, 23);
            this.txtCATALOGER.TabIndex = 51;
            this.txtCATALOGER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCATALOGER_KeyDown);
            // 
            // txtDOCTOR_OF_CONTROL_QUALITY
            // 
            this.txtDOCTOR_OF_CONTROL_QUALITY.BackColor = System.Drawing.Color.White;
            this.txtDOCTOR_OF_CONTROL_QUALITY.Location = new System.Drawing.Point(318, 1181);
            this.txtDOCTOR_OF_CONTROL_QUALITY.Name = "txtDOCTOR_OF_CONTROL_QUALITY";
            this.txtDOCTOR_OF_CONTROL_QUALITY.ReadOnly = true;
            this.txtDOCTOR_OF_CONTROL_QUALITY.Size = new System.Drawing.Size(84, 21);
            this.txtDOCTOR_OF_CONTROL_QUALITY.TabIndex = 1018;
            this.txtDOCTOR_OF_CONTROL_QUALITY.DoubleClick += new System.EventHandler(this.txtDOCTOR_OF_CONTROL_QUALITY_DoubleClick);
            this.txtDOCTOR_OF_CONTROL_QUALITY.Leave += new System.EventHandler(this.txtDOCTOR_OF_CONTROL_QUALITY_Leave);
            this.txtDOCTOR_OF_CONTROL_QUALITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDOCTOR_OF_CONTROL_QUALITY_KeyPress);
            this.txtDOCTOR_OF_CONTROL_QUALITY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDOCTOR_OF_CONTROL_QUALITY_KeyDown);
            // 
            // txtNURSE_OF_CONTROL_QUALITY
            // 
            this.txtNURSE_OF_CONTROL_QUALITY.BackColor = System.Drawing.Color.White;
            this.txtNURSE_OF_CONTROL_QUALITY.Location = new System.Drawing.Point(461, 1181);
            this.txtNURSE_OF_CONTROL_QUALITY.Name = "txtNURSE_OF_CONTROL_QUALITY";
            this.txtNURSE_OF_CONTROL_QUALITY.ReadOnly = true;
            this.txtNURSE_OF_CONTROL_QUALITY.Size = new System.Drawing.Size(93, 21);
            this.txtNURSE_OF_CONTROL_QUALITY.TabIndex = 1019;
            this.txtNURSE_OF_CONTROL_QUALITY.DoubleClick += new System.EventHandler(this.txtNURSE_OF_CONTROL_QUALITY_DoubleClick);
            this.txtNURSE_OF_CONTROL_QUALITY.Leave += new System.EventHandler(this.txtNURSE_OF_CONTROL_QUALITY_Leave);
            this.txtNURSE_OF_CONTROL_QUALITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNURSE_OF_CONTROL_QUALITY_KeyPress);
            this.txtNURSE_OF_CONTROL_QUALITY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNURSE_OF_CONTROL_QUALITY_KeyDown);
            // 
            // txtDATE_OF_CONTROL_QUALITY
            // 
            this.txtDATE_OF_CONTROL_QUALITY.BackColor = System.Drawing.Color.White;
            this.txtDATE_OF_CONTROL_QUALITY.Location = new System.Drawing.Point(592, 1181);
            this.txtDATE_OF_CONTROL_QUALITY.Name = "txtDATE_OF_CONTROL_QUALITY";
            this.txtDATE_OF_CONTROL_QUALITY.ReadOnly = true;
            this.txtDATE_OF_CONTROL_QUALITY.Size = new System.Drawing.Size(121, 21);
            this.txtDATE_OF_CONTROL_QUALITY.TabIndex = 1020;
            this.txtDATE_OF_CONTROL_QUALITY.DoubleClick += new System.EventHandler(this.txtDATE_OF_CONTROL_QUALITY_DoubleClick);
            this.txtDATE_OF_CONTROL_QUALITY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDATE_OF_CONTROL_QUALITY_KeyDown);
            // 
            // txtMedical_pay_way
            // 
            this.txtMedical_pay_way.BackColor = System.Drawing.Color.White;
            this.txtMedical_pay_way.Location = new System.Drawing.Point(134, 119);
            this.txtMedical_pay_way.Name = "txtMedical_pay_way";
            this.txtMedical_pay_way.ReadOnly = true;
            this.txtMedical_pay_way.Size = new System.Drawing.Size(69, 21);
            this.txtMedical_pay_way.TabIndex = 0;
            this.txtMedical_pay_way.Tag = "－";
            this.txtMedical_pay_way.Text = "－";
            this.txtMedical_pay_way.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMedical_pay_way.Enter += new System.EventHandler(this.txtMedical_pay_way_Enter);
            this.txtMedical_pay_way.DoubleClick += new System.EventHandler(this.txtMedical_pay_way_DoubleClick);
            this.txtMedical_pay_way.Leave += new System.EventHandler(this.txtMedical_pay_way_Leave);
            this.txtMedical_pay_way.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMedical_pay_way_KeyDown);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.Enabled = false;
            this.txtAge.ForeColor = System.Drawing.Color.Gray;
            this.txtAge.Location = new System.Drawing.Point(469, 151);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(61, 21);
            this.txtAge.TabIndex = 4;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Enabled = false;
            this.label84.ForeColor = System.Drawing.Color.Gray;
            this.label84.Location = new System.Drawing.Point(746, 409);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(17, 12);
            this.label84.TabIndex = 679;
            this.label84.Text = "天";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(601, 775);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(34, 21);
            this.textBox9.TabIndex = 655;
            // 
            // txtBLOOD_TYPE
            // 
            this.txtBLOOD_TYPE.BackColor = System.Drawing.Color.White;
            this.txtBLOOD_TYPE.Location = new System.Drawing.Point(92, 859);
            this.txtBLOOD_TYPE.Name = "txtBLOOD_TYPE";
            this.txtBLOOD_TYPE.ReadOnly = true;
            this.txtBLOOD_TYPE.Size = new System.Drawing.Size(18, 21);
            this.txtBLOOD_TYPE.TabIndex = 3007;
            this.txtBLOOD_TYPE.Tag = "－";
            this.txtBLOOD_TYPE.Text = "－";
            this.txtBLOOD_TYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBLOOD_TYPE.DoubleClick += new System.EventHandler(this.txtBLOOD_TYPE_DoubleClick);
            this.txtBLOOD_TYPE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBLOOD_TYPE_KeyDown);
            // 
            // txtBLOOD_TYPE_RH
            // 
            this.txtBLOOD_TYPE_RH.BackColor = System.Drawing.Color.White;
            this.txtBLOOD_TYPE_RH.Location = new System.Drawing.Point(399, 859);
            this.txtBLOOD_TYPE_RH.Name = "txtBLOOD_TYPE_RH";
            this.txtBLOOD_TYPE_RH.ReadOnly = true;
            this.txtBLOOD_TYPE_RH.Size = new System.Drawing.Size(17, 21);
            this.txtBLOOD_TYPE_RH.TabIndex = 3008;
            this.txtBLOOD_TYPE_RH.Tag = "－";
            this.txtBLOOD_TYPE_RH.Text = "－";
            this.txtBLOOD_TYPE_RH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBLOOD_TYPE_RH.DoubleClick += new System.EventHandler(this.txtBLOOD_TYPE_RH_DoubleClick);
            this.txtBLOOD_TYPE_RH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBLOOD_TYPE_RH_KeyDown);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.Color.Teal;
            this.btnInsert.Location = new System.Drawing.Point(637, 450);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(59, 23);
            this.btnInsert.TabIndex = 31;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Teal;
            this.btnDel.Location = new System.Drawing.Point(702, 450);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(59, 23);
            this.btnDel.TabIndex = 33;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnOperDel
            // 
            this.btnOperDel.ForeColor = System.Drawing.Color.Teal;
            this.btnOperDel.Location = new System.Drawing.Point(704, 954);
            this.btnOperDel.Name = "btnOperDel";
            this.btnOperDel.Size = new System.Drawing.Size(59, 23);
            this.btnOperDel.TabIndex = 58;
            this.btnOperDel.Text = "删除";
            this.btnOperDel.UseVisualStyleBackColor = true;
            this.btnOperDel.Click += new System.EventHandler(this.btnOperDel_Click);
            // 
            // btnOperInsert
            // 
            this.btnOperInsert.ForeColor = System.Drawing.Color.Teal;
            this.btnOperInsert.Location = new System.Drawing.Point(641, 954);
            this.btnOperInsert.Name = "btnOperInsert";
            this.btnOperInsert.Size = new System.Drawing.Size(59, 23);
            this.btnOperInsert.TabIndex = 56;
            this.btnOperInsert.Text = "插入";
            this.btnOperInsert.UseVisualStyleBackColor = true;
            this.btnOperInsert.Click += new System.EventHandler(this.btnOperInsert_Click);
            // 
            // lbItemSel
            // 
            this.lbItemSel.FormattingEnabled = true;
            this.lbItemSel.ItemHeight = 12;
            this.lbItemSel.Location = new System.Drawing.Point(606, 10);
            this.lbItemSel.Name = "lbItemSel";
            this.lbItemSel.Size = new System.Drawing.Size(120, 88);
            this.lbItemSel.TabIndex = 702;
            this.lbItemSel.Visible = false;
            this.lbItemSel.Leave += new System.EventHandler(this.lbItemSel_Leave);
            this.lbItemSel.DoubleClick += new System.EventHandler(this.lbItemSel_DoubleClick);
            this.lbItemSel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbItemSel_KeyDown);
            // 
            // btnCustom
            // 
            this.btnCustom.ForeColor = System.Drawing.Color.Teal;
            this.btnCustom.Location = new System.Drawing.Point(558, 450);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(75, 23);
            this.btnCustom.TabIndex = 706;
            this.btnCustom.Text = "常用诊断";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnCustomOper
            // 
            this.btnCustomOper.ForeColor = System.Drawing.Color.Teal;
            this.btnCustomOper.Location = new System.Drawing.Point(560, 954);
            this.btnCustomOper.Name = "btnCustomOper";
            this.btnCustomOper.Size = new System.Drawing.Size(75, 23);
            this.btnCustomOper.TabIndex = 707;
            this.btnCustomOper.Text = "常用手术";
            this.btnCustomOper.UseVisualStyleBackColor = true;
            this.btnCustomOper.Click += new System.EventHandler(this.btnCustomOper_Click);
            // 
            // btnAddCustomDiag
            // 
            this.btnAddCustomDiag.ForeColor = System.Drawing.Color.Teal;
            this.btnAddCustomDiag.Location = new System.Drawing.Point(308, 450);
            this.btnAddCustomDiag.Name = "btnAddCustomDiag";
            this.btnAddCustomDiag.Size = new System.Drawing.Size(157, 23);
            this.btnAddCustomDiag.TabIndex = 708;
            this.btnAddCustomDiag.Text = "当前诊断添加为常用诊断";
            this.btnAddCustomDiag.UseVisualStyleBackColor = true;
            this.btnAddCustomDiag.Click += new System.EventHandler(this.btnAddCustomDiag_Click);
            // 
            // btnAddCustomOper
            // 
            this.btnAddCustomOper.ForeColor = System.Drawing.Color.Teal;
            this.btnAddCustomOper.Location = new System.Drawing.Point(411, 954);
            this.btnAddCustomOper.Name = "btnAddCustomOper";
            this.btnAddCustomOper.Size = new System.Drawing.Size(146, 23);
            this.btnAddCustomOper.TabIndex = 709;
            this.btnAddCustomOper.Text = "当前手术添加为常用手术";
            this.btnAddCustomOper.UseVisualStyleBackColor = true;
            this.btnAddCustomOper.Click += new System.EventHandler(this.btnAddCustomOper_Click);
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label90.ForeColor = System.Drawing.Color.Teal;
            this.label90.Location = new System.Drawing.Point(404, 1182);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(59, 13);
            this.label90.TabIndex = 538;
            this.label90.Text = "质控护士";
            // 
            // txtdischarge_disposition
            // 
            this.txtdischarge_disposition.BackColor = System.Drawing.Color.White;
            this.txtdischarge_disposition.Location = new System.Drawing.Point(718, 34);
            this.txtdischarge_disposition.Name = "txtdischarge_disposition";
            this.txtdischarge_disposition.ReadOnly = true;
            this.txtdischarge_disposition.Size = new System.Drawing.Size(53, 21);
            this.txtdischarge_disposition.TabIndex = 30;
            this.txtdischarge_disposition.Tag = "－";
            this.txtdischarge_disposition.Text = "－";
            this.txtdischarge_disposition.Visible = false;
            this.txtdischarge_disposition.DoubleClick += new System.EventHandler(this.txtdischarge_disposition_DoubleClick);
            // 
            // btnMrDiagnose
            // 
            this.btnMrDiagnose.ForeColor = System.Drawing.Color.Teal;
            this.btnMrDiagnose.Location = new System.Drawing.Point(478, 450);
            this.btnMrDiagnose.Name = "btnMrDiagnose";
            this.btnMrDiagnose.Size = new System.Drawing.Size(75, 23);
            this.btnMrDiagnose.TabIndex = 718;
            this.btnMrDiagnose.Text = "病历诊断";
            this.btnMrDiagnose.UseVisualStyleBackColor = true;
            this.btnMrDiagnose.Click += new System.EventHandler(this.btnMrDiagnose_Click);
            // 
            // label184
            // 
            this.label184.Location = new System.Drawing.Point(315, 886);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(86, 20);
            this.label184.TabIndex = 719;
            // 
            // label185
            // 
            this.label185.Location = new System.Drawing.Point(96, 886);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(86, 20);
            this.label185.TabIndex = 719;
            // 
            // pictureBox46
            // 
            this.pictureBox46.BackColor = System.Drawing.Color.White;
            this.pictureBox46.Location = new System.Drawing.Point(36, 882);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(730, 1);
            this.pictureBox46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox46.TabIndex = 713;
            this.pictureBox46.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(36, 1902);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(730, 1);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 604;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(37, 1201);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(730, 1);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 602;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Location = new System.Drawing.Point(142, 424);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(161, 1);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 558;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Enabled = false;
            this.pictureBox8.Location = new System.Drawing.Point(142, 393);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(161, 1);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 557;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.BackColor = System.Drawing.Color.White;
            this.pictureBox38.Location = new System.Drawing.Point(365, 424);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(127, 1);
            this.pictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox38.TabIndex = 558;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.BackColor = System.Drawing.Color.White;
            this.pictureBox39.Location = new System.Drawing.Point(523, 427);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(65, 1);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox39.TabIndex = 558;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.BackColor = System.Drawing.Color.White;
            this.pictureBox40.Location = new System.Drawing.Point(657, 427);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(85, 1);
            this.pictureBox40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox40.TabIndex = 558;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.Color.White;
            this.pictureBox35.Enabled = false;
            this.pictureBox35.Location = new System.Drawing.Point(363, 393);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(127, 1);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox35.TabIndex = 557;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackColor = System.Drawing.Color.White;
            this.pictureBox37.Enabled = false;
            this.pictureBox37.Location = new System.Drawing.Point(657, 395);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(103, 1);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox37.TabIndex = 557;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Location = new System.Drawing.Point(117, 346);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(76, 1);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 556;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.White;
            this.pictureBox32.Enabled = false;
            this.pictureBox32.Location = new System.Drawing.Point(227, 346);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(76, 1);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox32.TabIndex = 556;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.Color.White;
            this.pictureBox33.Enabled = false;
            this.pictureBox33.Location = new System.Drawing.Point(342, 346);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(274, 1);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox33.TabIndex = 556;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Location = new System.Drawing.Point(107, 290);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(506, 1);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 555;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(362, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 1);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 553;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.White;
            this.pictureBox29.Enabled = false;
            this.pictureBox29.Location = new System.Drawing.Point(487, 317);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(117, 1);
            this.pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox29.TabIndex = 554;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.White;
            this.pictureBox30.Enabled = false;
            this.pictureBox30.Location = new System.Drawing.Point(655, 317);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(100, 1);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 554;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.White;
            this.pictureBox31.Enabled = false;
            this.pictureBox31.Location = new System.Drawing.Point(655, 289);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(100, 1);
            this.pictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox31.TabIndex = 554;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.White;
            this.pictureBox34.Enabled = false;
            this.pictureBox34.Location = new System.Drawing.Point(655, 346);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(100, 1);
            this.pictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox34.TabIndex = 554;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(142, 317);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(304, 1);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 554;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.White;
            this.pictureBox18.Enabled = false;
            this.pictureBox18.Location = new System.Drawing.Point(102, 219);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(206, 1);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 553;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.White;
            this.pictureBox19.Enabled = false;
            this.pictureBox19.Location = new System.Drawing.Point(569, 220);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(69, 1);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 553;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.White;
            this.pictureBox20.Enabled = false;
            this.pictureBox20.Location = new System.Drawing.Point(584, 167);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(65, 1);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 553;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.White;
            this.pictureBox28.Enabled = false;
            this.pictureBox28.Location = new System.Drawing.Point(113, 242);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(196, 1);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 553;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(103, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 1);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 552;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.White;
            this.pictureBox16.Enabled = false;
            this.pictureBox16.Location = new System.Drawing.Point(467, 167);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(66, 1);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 552;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.BackColor = System.Drawing.Color.White;
            this.pictureBox44.Enabled = false;
            this.pictureBox44.Location = new System.Drawing.Point(406, 167);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(10, 1);
            this.pictureBox44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox44.TabIndex = 552;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.BackColor = System.Drawing.Color.White;
            this.pictureBox43.Enabled = false;
            this.pictureBox43.Location = new System.Drawing.Point(378, 167);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(17, 1);
            this.pictureBox43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox43.TabIndex = 552;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.White;
            this.pictureBox17.Enabled = false;
            this.pictureBox17.Location = new System.Drawing.Point(340, 167);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(25, 1);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 552;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(36, 137);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(730, 2);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 486;
            this.pictureBox5.TabStop = false;
            // 
            // label186
            // 
            this.label186.Location = new System.Drawing.Point(508, 886);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(86, 20);
            this.label186.TabIndex = 719;
            // 
            // label187
            // 
            this.label187.Location = new System.Drawing.Point(674, 886);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(86, 20);
            this.label187.TabIndex = 719;
            // 
            // label188
            // 
            this.label188.Location = new System.Drawing.Point(62, 59);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(22, 20);
            this.label188.TabIndex = 719;
            this.label188.Visible = false;
            // 
            // label189
            // 
            this.label189.Location = new System.Drawing.Point(109, 39);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(10, 20);
            this.label189.TabIndex = 719;
            this.label189.Visible = false;
            // 
            // label190
            // 
            this.label190.Location = new System.Drawing.Point(62, 20);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(21, 20);
            this.label190.TabIndex = 719;
            this.label190.Visible = false;
            // 
            // comMR_QUALITY
            // 
            this.comMR_QUALITY.FormattingEnabled = true;
            this.comMR_QUALITY.Location = new System.Drawing.Point(91, 1176);
            this.comMR_QUALITY.Name = "comMR_QUALITY";
            this.comMR_QUALITY.Size = new System.Drawing.Size(38, 20);
            this.comMR_QUALITY.TabIndex = 720;
            this.comMR_QUALITY.SelectedIndexChanged += new System.EventHandler(this.comMR_QUALITY_SelectedIndexChanged);
            this.comMR_QUALITY.DropDown += new System.EventHandler(this.comMR_QUALITY_DropDown);
            // 
            // txtMR_QUALITY
            // 
            this.txtMR_QUALITY.BackColor = System.Drawing.Color.White;
            this.txtMR_QUALITY.Location = new System.Drawing.Point(93, 1178);
            this.txtMR_QUALITY.Name = "txtMR_QUALITY";
            this.txtMR_QUALITY.ReadOnly = true;
            this.txtMR_QUALITY.Size = new System.Drawing.Size(19, 21);
            this.txtMR_QUALITY.TabIndex = 1017;
            this.txtMR_QUALITY.Tag = "-";
            this.txtMR_QUALITY.Text = "-";
            this.txtMR_QUALITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMR_QUALITY.DoubleClick += new System.EventHandler(this.txtMR_QUALITY_DoubleClick);
            this.txtMR_QUALITY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMR_QUALITY_KeyDown);
            // 
            // comAUTOPSY_INDICATOR
            // 
            this.comAUTOPSY_INDICATOR.FormattingEnabled = true;
            this.comAUTOPSY_INDICATOR.Location = new System.Drawing.Point(602, 772);
            this.comAUTOPSY_INDICATOR.Name = "comAUTOPSY_INDICATOR";
            this.comAUTOPSY_INDICATOR.Size = new System.Drawing.Size(38, 20);
            this.comAUTOPSY_INDICATOR.TabIndex = 720;
            this.comAUTOPSY_INDICATOR.Tag = "-";
            this.comAUTOPSY_INDICATOR.Text = "-";
            this.comAUTOPSY_INDICATOR.SelectedIndexChanged += new System.EventHandler(this.comAUTOPSY_INDICATOR_SelectedIndexChanged);
            this.comAUTOPSY_INDICATOR.DropDownClosed += new System.EventHandler(this.comAUTOPSY_INDICATOR_DropDownClosed);
            this.comAUTOPSY_INDICATOR.DropDown += new System.EventHandler(this.comAUTOPSY_INDICATOR_DropDown);
            // 
            // txtAUTOPSY_INDICATOR
            // 
            this.txtAUTOPSY_INDICATOR.BackColor = System.Drawing.Color.White;
            this.txtAUTOPSY_INDICATOR.Location = new System.Drawing.Point(603, 775);
            this.txtAUTOPSY_INDICATOR.Name = "txtAUTOPSY_INDICATOR";
            this.txtAUTOPSY_INDICATOR.ReadOnly = true;
            this.txtAUTOPSY_INDICATOR.Size = new System.Drawing.Size(18, 21);
            this.txtAUTOPSY_INDICATOR.TabIndex = 3001;
            this.txtAUTOPSY_INDICATOR.Tag = "－";
            this.txtAUTOPSY_INDICATOR.Text = "－";
            this.txtAUTOPSY_INDICATOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAUTOPSY_INDICATOR.DoubleClick += new System.EventHandler(this.txtAUTOPSY_INDICATOR_DoubleClick);
            this.txtAUTOPSY_INDICATOR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAUTOPSY_INDICATOR_KeyDown);
            // 
            // comBLOOD_TYPE
            // 
            this.comBLOOD_TYPE.Location = new System.Drawing.Point(-39, 0);
            this.comBLOOD_TYPE.Name = "comBLOOD_TYPE";
            this.comBLOOD_TYPE.Size = new System.Drawing.Size(121, 20);
            this.comBLOOD_TYPE.TabIndex = 3219;
            // 
            // comBLOOD_TYPE_RH
            // 
            this.comBLOOD_TYPE_RH.FormattingEnabled = true;
            this.comBLOOD_TYPE_RH.Location = new System.Drawing.Point(397, 856);
            this.comBLOOD_TYPE_RH.Name = "comBLOOD_TYPE_RH";
            this.comBLOOD_TYPE_RH.Size = new System.Drawing.Size(38, 20);
            this.comBLOOD_TYPE_RH.TabIndex = 720;
            this.comBLOOD_TYPE_RH.Tag = "-";
            this.comBLOOD_TYPE_RH.Text = "-";
            this.comBLOOD_TYPE_RH.SelectedIndexChanged += new System.EventHandler(this.comBLOOD_TYPE_RH_SelectedIndexChanged);
            this.comBLOOD_TYPE_RH.DropDownClosed += new System.EventHandler(this.comBLOOD_TYPE_RH_DropDownClosed);
            this.comBLOOD_TYPE_RH.DropDown += new System.EventHandler(this.comBLOOD_TYPE_RH_DropDown);
            // 
            // comSex
            // 
            this.comSex.Enabled = false;
            this.comSex.FormattingEnabled = true;
            this.comSex.Location = new System.Drawing.Point(198, 148);
            this.comSex.Name = "comSex";
            this.comSex.Size = new System.Drawing.Size(38, 20);
            this.comSex.TabIndex = 720;
            this.comSex.Visible = false;
            this.comSex.SelectedIndexChanged += new System.EventHandler(this.comSex_SelectedIndexChanged);
            this.comSex.DropDownClosed += new System.EventHandler(this.comSex_DropDownClosed);
            this.comSex.DropDown += new System.EventHandler(this.comSex_DropDown);
            // 
            // comMARITAL_STATUS
            // 
            this.comMARITAL_STATUS.Location = new System.Drawing.Point(493, 224);
            this.comMARITAL_STATUS.Name = "comMARITAL_STATUS";
            this.comMARITAL_STATUS.Size = new System.Drawing.Size(38, 20);
            this.comMARITAL_STATUS.TabIndex = 720;
            this.comMARITAL_STATUS.SelectedIndexChanged += new System.EventHandler(this.comMARITAL_STATUS_SelectedIndexChanged);
            this.comMARITAL_STATUS.DropDownClosed += new System.EventHandler(this.comMARITAL_STATUS_DropDownClosed);
            this.comMARITAL_STATUS.DropDown += new System.EventHandler(this.comMARITAL_STATUS_DropDown);
            // 
            // comMedical_pay_way
            // 
            this.comMedical_pay_way.FormattingEnabled = true;
            this.comMedical_pay_way.Location = new System.Drawing.Point(132, 116);
            this.comMedical_pay_way.Name = "comMedical_pay_way";
            this.comMedical_pay_way.Size = new System.Drawing.Size(90, 20);
            this.comMedical_pay_way.TabIndex = 720;
            this.comMedical_pay_way.SelectedIndexChanged += new System.EventHandler(this.comMedical_pay_way_SelectedIndexChanged);
            this.comMedical_pay_way.DropDownClosed += new System.EventHandler(this.comMedical_pay_way_DropDownClosed);
            this.comMedical_pay_way.DropDown += new System.EventHandler(this.comMedical_pay_way_DropDown);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.Teal;
            this.btnUpdate.Location = new System.Drawing.Point(45, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(23, 42);
            this.btnUpdate.TabIndex = 3015;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvDiagnose
            // 
            this.dgvDiagnose.AllowUserToAddRows = false;
            this.dgvDiagnose.AllowUserToDeleteRows = false;
            this.dgvDiagnose.AllowUserToResizeColumns = false;
            this.dgvDiagnose.AllowUserToResizeRows = false;
            this.dgvDiagnose.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiagnose.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDiagnose.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiagnose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiagnose.ColumnHeadersHeight = 29;
            this.dgvDiagnose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiagnose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diagnosis_type_name,
            this.diagnosis_desc,
            this.diagnosis_desc_part,
            this.code1,
            this.code2,
            this.treat_days,
            this.oper_treat_indicator,
            this.diagnosis_date,
            this.ADMISSION_CONDITIONS,
            this.treat_result});
            this.dgvDiagnose.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDiagnose.Location = new System.Drawing.Point(40, 477);
            this.dgvDiagnose.MultiSelect = false;
            this.dgvDiagnose.Name = "dgvDiagnose";
            this.dgvDiagnose.RowHeadersVisible = false;
            this.dgvDiagnose.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDiagnose.RowTemplate.Height = 23;
            this.dgvDiagnose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnose.Size = new System.Drawing.Size(725, 258);
            this.dgvDiagnose.TabIndex = 34;
            this.dgvDiagnose.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDiagnose_CellBeginEdit);
            this.dgvDiagnose.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnose_CellDoubleClick);
            this.dgvDiagnose.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDiagnose_CellFormatting);
            this.dgvDiagnose.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnose_CellEndEdit);
            // 
            // diagnosis_type_name
            // 
            this.diagnosis_type_name.DataPropertyName = "diagnosis_type_name";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.diagnosis_type_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.diagnosis_type_name.HeaderText = "诊断类别";
            this.diagnosis_type_name.Name = "diagnosis_type_name";
            this.diagnosis_type_name.ReadOnly = true;
            this.diagnosis_type_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // diagnosis_desc
            // 
            this.diagnosis_desc.DataPropertyName = "diagnosis_desc";
            this.diagnosis_desc.HeaderText = "诊断描述";
            this.diagnosis_desc.Name = "diagnosis_desc";
            this.diagnosis_desc.ReadOnly = true;
            this.diagnosis_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.diagnosis_desc.Width = 280;
            // 
            // diagnosis_desc_part
            // 
            this.diagnosis_desc_part.DataPropertyName = "diagnosis_desc_part";
            this.diagnosis_desc_part.HeaderText = "部位描述";
            this.diagnosis_desc_part.Name = "diagnosis_desc_part";
            this.diagnosis_desc_part.Visible = false;
            this.diagnosis_desc_part.Width = 150;
            // 
            // code1
            // 
            this.code1.DataPropertyName = "code1";
            this.code1.HeaderText = "疾病编码";
            this.code1.Name = "code1";
            this.code1.ReadOnly = true;
            this.code1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.code1.Width = 70;
            // 
            // code2
            // 
            this.code2.DataPropertyName = "code2";
            this.code2.HeaderText = "疾病M编码";
            this.code2.Name = "code2";
            this.code2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.code2.Visible = false;
            this.code2.Width = 70;
            // 
            // treat_days
            // 
            this.treat_days.DataPropertyName = "treat_days";
            this.treat_days.HeaderText = "天数";
            this.treat_days.Name = "treat_days";
            this.treat_days.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.treat_days.Visible = false;
            this.treat_days.Width = 45;
            // 
            // oper_treat_indicator
            // 
            this.oper_treat_indicator.DataPropertyName = "oper_treat_indicator";
            this.oper_treat_indicator.HeaderText = "手术";
            this.oper_treat_indicator.Name = "oper_treat_indicator";
            this.oper_treat_indicator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oper_treat_indicator.TrueValue = "1";
            this.oper_treat_indicator.Visible = false;
            this.oper_treat_indicator.Width = 45;
            // 
            // diagnosis_date
            // 
            this.diagnosis_date.DataPropertyName = "diagnosis_date";
            this.diagnosis_date.HeaderText = "诊断日期";
            this.diagnosis_date.Name = "diagnosis_date";
            this.diagnosis_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.diagnosis_date.Width = 90;
            // 
            // ADMISSION_CONDITIONS
            // 
            this.ADMISSION_CONDITIONS.DataPropertyName = "ADMISSION_CONDITIONS";
            this.ADMISSION_CONDITIONS.HeaderText = "入院病情";
            this.ADMISSION_CONDITIONS.Items.AddRange(new object[] {
            "有",
            "临床未确定",
            "情况不明",
            "无"});
            this.ADMISSION_CONDITIONS.Name = "ADMISSION_CONDITIONS";
            this.ADMISSION_CONDITIONS.Width = 90;
            // 
            // treat_result
            // 
            this.treat_result.DataPropertyName = "treat_result";
            this.treat_result.HeaderText = "治疗结果";
            this.treat_result.Items.AddRange(new object[] {
            "治愈",
            "好转",
            "未愈",
            "死亡",
            "其他",
            " "});
            this.treat_result.Name = "treat_result";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Teal;
            this.label16.Location = new System.Drawing.Point(8, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 495;
            this.label16.Text = "B超号：";
            this.label16.Visible = false;
            // 
            // txtbch
            // 
            this.txtbch.BackColor = System.Drawing.Color.White;
            this.txtbch.ForeColor = System.Drawing.Color.Black;
            this.txtbch.Location = new System.Drawing.Point(57, 10);
            this.txtbch.Name = "txtbch";
            this.txtbch.Size = new System.Drawing.Size(21, 21);
            this.txtbch.TabIndex = 7;
            this.txtbch.Text = "-";
            this.txtbch.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbch);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label162);
            this.panel1.Controls.Add(this.label190);
            this.panel1.Controls.Add(this.label164);
            this.panel1.Controls.Add(this.label189);
            this.panel1.Controls.Add(this.label166);
            this.panel1.Controls.Add(this.label188);
            this.panel1.Location = new System.Drawing.Point(43, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 10);
            this.panel1.TabIndex = 3017;
            this.panel1.Visible = false;
            // 
            // txtFee5
            // 
            this.txtFee5.BackColor = System.Drawing.Color.White;
            this.txtFee5.ForeColor = System.Drawing.Color.Gray;
            this.txtFee5.Location = new System.Drawing.Point(63, 1995);
            this.txtFee5.Name = "txtFee5";
            this.txtFee5.ReadOnly = true;
            this.txtFee5.Size = new System.Drawing.Size(58, 21);
            this.txtFee5.TabIndex = 3028;
            this.txtFee5.TabStop = false;
            this.txtFee5.Visible = false;
            // 
            // txtHy
            // 
            this.txtHy.BackColor = System.Drawing.Color.White;
            this.txtHy.ForeColor = System.Drawing.Color.Gray;
            this.txtHy.Location = new System.Drawing.Point(158, 1995);
            this.txtHy.Name = "txtHy";
            this.txtHy.ReadOnly = true;
            this.txtHy.Size = new System.Drawing.Size(58, 21);
            this.txtHy.TabIndex = 3023;
            this.txtHy.TabStop = false;
            this.txtHy.Visible = false;
            // 
            // txtJs
            // 
            this.txtJs.BackColor = System.Drawing.Color.White;
            this.txtJs.ForeColor = System.Drawing.Color.Gray;
            this.txtJs.Location = new System.Drawing.Point(645, 1995);
            this.txtJs.Name = "txtJs";
            this.txtJs.ReadOnly = true;
            this.txtJs.Size = new System.Drawing.Size(58, 21);
            this.txtJs.TabIndex = 3025;
            this.txtJs.TabStop = false;
            this.txtJs.Visible = false;
            // 
            // txtJc
            // 
            this.txtJc.BackColor = System.Drawing.Color.White;
            this.txtJc.ForeColor = System.Drawing.Color.Gray;
            this.txtJc.Location = new System.Drawing.Point(66, 2016);
            this.txtJc.Name = "txtJc";
            this.txtJc.ReadOnly = true;
            this.txtJc.Size = new System.Drawing.Size(58, 21);
            this.txtJc.TabIndex = 3024;
            this.txtJc.TabStop = false;
            this.txtJc.Visible = false;
            // 
            // txtZcny
            // 
            this.txtZcny.BackColor = System.Drawing.Color.White;
            this.txtZcny.ForeColor = System.Drawing.Color.Gray;
            this.txtZcny.Location = new System.Drawing.Point(540, 1978);
            this.txtZcny.Name = "txtZcny";
            this.txtZcny.ReadOnly = true;
            this.txtZcny.Size = new System.Drawing.Size(58, 21);
            this.txtZcny.TabIndex = 3021;
            this.txtZcny.TabStop = false;
            this.txtZcny.Visible = false;
            // 
            // txtFee3
            // 
            this.txtFee3.BackColor = System.Drawing.Color.White;
            this.txtFee3.ForeColor = System.Drawing.Color.Gray;
            this.txtFee3.Location = new System.Drawing.Point(645, 1978);
            this.txtFee3.Name = "txtFee3";
            this.txtFee3.ReadOnly = true;
            this.txtFee3.Size = new System.Drawing.Size(58, 21);
            this.txtFee3.TabIndex = 3022;
            this.txtFee3.TabStop = false;
            this.txtFee3.Visible = false;
            // 
            // txtFee2
            // 
            this.txtFee2.BackColor = System.Drawing.Color.White;
            this.txtFee2.ForeColor = System.Drawing.Color.Gray;
            this.txtFee2.Location = new System.Drawing.Point(438, 1978);
            this.txtFee2.Name = "txtFee2";
            this.txtFee2.ReadOnly = true;
            this.txtFee2.Size = new System.Drawing.Size(58, 21);
            this.txtFee2.TabIndex = 3020;
            this.txtFee2.TabStop = false;
            this.txtFee2.Visible = false;
            // 
            // txtFee11
            // 
            this.txtFee11.BackColor = System.Drawing.Color.White;
            this.txtFee11.ForeColor = System.Drawing.Color.Gray;
            this.txtFee11.Location = new System.Drawing.Point(445, 2016);
            this.txtFee11.Name = "txtFee11";
            this.txtFee11.ReadOnly = true;
            this.txtFee11.Size = new System.Drawing.Size(58, 21);
            this.txtFee11.TabIndex = 3037;
            this.txtFee11.TabStop = false;
            this.txtFee11.Visible = false;
            // 
            // txtFee10
            // 
            this.txtFee10.BackColor = System.Drawing.Color.White;
            this.txtFee10.ForeColor = System.Drawing.Color.Gray;
            this.txtFee10.Location = new System.Drawing.Point(540, 1995);
            this.txtFee10.Name = "txtFee10";
            this.txtFee10.ReadOnly = true;
            this.txtFee10.Size = new System.Drawing.Size(58, 21);
            this.txtFee10.TabIndex = 3036;
            this.txtFee10.TabStop = false;
            this.txtFee10.Visible = false;
            // 
            // txtFee9
            // 
            this.txtFee9.BackColor = System.Drawing.Color.White;
            this.txtFee9.ForeColor = System.Drawing.Color.Gray;
            this.txtFee9.Location = new System.Drawing.Point(347, 1978);
            this.txtFee9.Name = "txtFee9";
            this.txtFee9.ReadOnly = true;
            this.txtFee9.Size = new System.Drawing.Size(58, 21);
            this.txtFee9.TabIndex = 3035;
            this.txtFee9.TabStop = false;
            this.txtFee9.Visible = false;
            // 
            // txtSy
            // 
            this.txtSy.BackColor = System.Drawing.Color.White;
            this.txtSy.ForeColor = System.Drawing.Color.Gray;
            this.txtSy.Location = new System.Drawing.Point(253, 1995);
            this.txtSy.Name = "txtSy";
            this.txtSy.ReadOnly = true;
            this.txtSy.Size = new System.Drawing.Size(58, 21);
            this.txtSy.TabIndex = 3033;
            this.txtSy.TabStop = false;
            this.txtSy.Visible = false;
            this.txtSy.TextChanged += new System.EventHandler(this.txtSy_TextChanged);
            // 
            // txtFee8
            // 
            this.txtFee8.BackColor = System.Drawing.Color.White;
            this.txtFee8.ForeColor = System.Drawing.Color.Gray;
            this.txtFee8.Location = new System.Drawing.Point(346, 1995);
            this.txtFee8.Name = "txtFee8";
            this.txtFee8.ReadOnly = true;
            this.txtFee8.Size = new System.Drawing.Size(58, 21);
            this.txtFee8.TabIndex = 3034;
            this.txtFee8.TabStop = false;
            this.txtFee8.Visible = false;
            // 
            // txtFee7
            // 
            this.txtFee7.BackColor = System.Drawing.Color.White;
            this.txtFee7.ForeColor = System.Drawing.Color.Gray;
            this.txtFee7.Location = new System.Drawing.Point(438, 1995);
            this.txtFee7.Name = "txtFee7";
            this.txtFee7.ReadOnly = true;
            this.txtFee7.Size = new System.Drawing.Size(58, 21);
            this.txtFee7.TabIndex = 3032;
            this.txtFee7.TabStop = false;
            this.txtFee7.Visible = false;
            // 
            // txtPc
            // 
            this.txtPc.BackColor = System.Drawing.Color.White;
            this.txtPc.ForeColor = System.Drawing.Color.Gray;
            this.txtPc.Location = new System.Drawing.Point(346, 2016);
            this.txtPc.Name = "txtPc";
            this.txtPc.ReadOnly = true;
            this.txtPc.Size = new System.Drawing.Size(58, 21);
            this.txtPc.TabIndex = 3029;
            this.txtPc.TabStop = false;
            this.txtPc.Visible = false;
            // 
            // txtYe
            // 
            this.txtYe.BackColor = System.Drawing.Color.White;
            this.txtYe.ForeColor = System.Drawing.Color.Gray;
            this.txtYe.Location = new System.Drawing.Point(254, 2016);
            this.txtYe.Name = "txtYe";
            this.txtYe.ReadOnly = true;
            this.txtYe.Size = new System.Drawing.Size(58, 21);
            this.txtYe.TabIndex = 3030;
            this.txtYe.TabStop = false;
            this.txtYe.Visible = false;
            // 
            // txtMz
            // 
            this.txtMz.BackColor = System.Drawing.Color.White;
            this.txtMz.ForeColor = System.Drawing.Color.Gray;
            this.txtMz.Location = new System.Drawing.Point(159, 2016);
            this.txtMz.Name = "txtMz";
            this.txtMz.ReadOnly = true;
            this.txtMz.Size = new System.Drawing.Size(58, 21);
            this.txtMz.TabIndex = 3031;
            this.txtMz.TabStop = false;
            this.txtMz.Visible = false;
            // 
            // txtFee1
            // 
            this.txtFee1.BackColor = System.Drawing.Color.White;
            this.txtFee1.ForeColor = System.Drawing.Color.Gray;
            this.txtFee1.Location = new System.Drawing.Point(247, 1978);
            this.txtFee1.Name = "txtFee1";
            this.txtFee1.ReadOnly = true;
            this.txtFee1.Size = new System.Drawing.Size(58, 21);
            this.txtFee1.TabIndex = 3019;
            this.txtFee1.TabStop = false;
            this.txtFee1.Visible = false;
            // 
            // txtTOTAL_PAYMENTS
            // 
            this.txtTOTAL_PAYMENTS.BackColor = System.Drawing.Color.White;
            this.txtTOTAL_PAYMENTS.ForeColor = System.Drawing.Color.Gray;
            this.txtTOTAL_PAYMENTS.Location = new System.Drawing.Point(153, 1978);
            this.txtTOTAL_PAYMENTS.Name = "txtTOTAL_PAYMENTS";
            this.txtTOTAL_PAYMENTS.ReadOnly = true;
            this.txtTOTAL_PAYMENTS.Size = new System.Drawing.Size(58, 21);
            this.txtTOTAL_PAYMENTS.TabIndex = 3018;
            this.txtTOTAL_PAYMENTS.TabStop = false;
            this.txtTOTAL_PAYMENTS.Visible = false;
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label167.Location = new System.Drawing.Point(404, 1996);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(29, 12);
            this.label167.TabIndex = 3058;
            this.label167.Text = "诊疗";
            this.label167.Visible = false;
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label165.Location = new System.Drawing.Point(404, 2015);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(29, 12);
            this.label165.TabIndex = 3038;
            this.label165.Text = "其它";
            this.label165.Visible = false;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label71.Location = new System.Drawing.Point(218, 1996);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(29, 12);
            this.label71.TabIndex = 3041;
            this.label71.Text = "输氧";
            this.label71.Visible = false;
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label163.Location = new System.Drawing.Point(502, 1996);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(29, 12);
            this.label163.TabIndex = 3039;
            this.label163.Text = "手术";
            this.label163.Visible = false;
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label161.Location = new System.Drawing.Point(310, 1996);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(29, 12);
            this.label161.TabIndex = 3040;
            this.label161.Text = "输血";
            this.label161.Visible = false;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label72.Location = new System.Drawing.Point(125, 1996);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(29, 12);
            this.label72.TabIndex = 3046;
            this.label72.Text = "化验";
            this.label72.Visible = false;
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label136.Location = new System.Drawing.Point(602, 1996);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(29, 12);
            this.label136.TabIndex = 3047;
            this.label136.Text = "接生";
            this.label136.Visible = false;
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label137.Location = new System.Drawing.Point(35, 2015);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(29, 12);
            this.label137.TabIndex = 3045;
            this.label137.Text = "检查";
            this.label137.Visible = false;
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label159.Location = new System.Drawing.Point(307, 1979);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(41, 12);
            this.label159.TabIndex = 3042;
            this.label159.Text = "护理费";
            this.label159.Visible = false;
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label139.Location = new System.Drawing.Point(310, 2015);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(41, 12);
            this.label139.TabIndex = 3050;
            this.label139.Text = "陪床费";
            this.label139.Visible = false;
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label138.Location = new System.Drawing.Point(216, 2015);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(41, 12);
            this.label138.TabIndex = 3048;
            this.label138.Text = "婴儿费";
            this.label138.Visible = false;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label73.Location = new System.Drawing.Point(125, 2015);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(29, 12);
            this.label73.TabIndex = 3049;
            this.label73.Text = "麻醉";
            this.label73.Visible = false;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label74.Location = new System.Drawing.Point(497, 1979);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(41, 12);
            this.label74.TabIndex = 3054;
            this.label74.Text = "中成药";
            this.label74.Visible = false;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label75.Location = new System.Drawing.Point(598, 1979);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(41, 12);
            this.label75.TabIndex = 3055;
            this.label75.Text = "中草药";
            this.label75.Visible = false;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label76.Location = new System.Drawing.Point(404, 1979);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(29, 12);
            this.label76.TabIndex = 3056;
            this.label76.Text = "西药";
            this.label76.Visible = false;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label80.Location = new System.Drawing.Point(35, 1995);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(29, 12);
            this.label80.TabIndex = 3057;
            this.label80.Text = "放射";
            this.label80.Visible = false;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label82.Location = new System.Drawing.Point(218, 1979);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(29, 12);
            this.label82.TabIndex = 3052;
            this.label82.Text = "床费";
            this.label82.Visible = false;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label83.Location = new System.Drawing.Point(30, 1979);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(113, 12);
            this.label83.TabIndex = 3053;
            this.label83.Text = "住院费用总计(元)：";
            this.label83.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(36, 911);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(730, 1);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 713;
            this.pictureBox2.TabStop = false;
            // 
            // dgvOperation
            // 
            this.dgvOperation.AllowUserToAddRows = false;
            this.dgvOperation.AllowUserToDeleteRows = false;
            this.dgvOperation.AllowUserToResizeColumns = false;
            this.dgvOperation.AllowUserToResizeRows = false;
            this.dgvOperation.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperation.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOperation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operation_code,
            this.operating_date,
            this.operating_grade,
            this.operation_desc,
            this.operator1,
            this.STERILE_HEAL,
            this.first_assistant,
            this.second_assistant,
            this.wound_grade,
            this.heal,
            this.anaesthesia_method,
            this.anesthesia_doctor,
            this.检查标志,
            this.ISMAIN,
            this.ILLNESS,
            this.INFFECT,
            this.OPERACCORD});
            this.dgvOperation.Location = new System.Drawing.Point(38, 983);
            this.dgvOperation.MultiSelect = false;
            this.dgvOperation.Name = "dgvOperation";
            this.dgvOperation.RowHeadersVisible = false;
            this.dgvOperation.RowTemplate.Height = 23;
            this.dgvOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperation.Size = new System.Drawing.Size(729, 187);
            this.dgvOperation.TabIndex = 3061;
            this.dgvOperation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOperation_KeyDown);
            this.dgvOperation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperation_CellDoubleClick);
            this.dgvOperation.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvOperation_DataError);
            // 
            // operation_code
            // 
            this.operation_code.DataPropertyName = "operation_code";
            this.operation_code.HeaderText = "手术、操作编码";
            this.operation_code.Name = "operation_code";
            this.operation_code.ReadOnly = true;
            this.operation_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.operation_code.Width = 80;
            // 
            // operating_date
            // 
            this.operating_date.DataPropertyName = "operating_date";
            this.operating_date.HeaderText = "手术、操作日期";
            this.operating_date.Name = "operating_date";
            this.operating_date.ReadOnly = true;
            this.operating_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.operating_date.Width = 80;
            // 
            // operating_grade
            // 
            this.operating_grade.DataPropertyName = "OPERATING_GRADE";
            this.operating_grade.HeaderText = "手术级别";
            this.operating_grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.operating_grade.Name = "operating_grade";
            this.operating_grade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.operating_grade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.operating_grade.Width = 40;
            // 
            // operation_desc
            // 
            this.operation_desc.DataPropertyName = "operation_desc";
            this.operation_desc.HeaderText = "手术、操作名称";
            this.operation_desc.Name = "operation_desc";
            this.operation_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.operation_desc.Width = 195;
            // 
            // operator1
            // 
            this.operator1.DataPropertyName = "operator";
            this.operator1.HeaderText = "术者";
            this.operator1.Name = "operator1";
            this.operator1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.operator1.Width = 80;
            // 
            // STERILE_HEAL
            // 
            this.STERILE_HEAL.DataPropertyName = "STERILE_HEAL";
            this.STERILE_HEAL.HeaderText = "无菌手术（1级切口）愈合情况";
            this.STERILE_HEAL.Items.AddRange(new object[] {
            "甲级",
            "乙级",
            "丙级"});
            this.STERILE_HEAL.Name = "STERILE_HEAL";
            // 
            // first_assistant
            // 
            this.first_assistant.DataPropertyName = "first_assistant";
            this.first_assistant.HeaderText = "Ⅰ助";
            this.first_assistant.Name = "first_assistant";
            this.first_assistant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.first_assistant.Width = 60;
            // 
            // second_assistant
            // 
            this.second_assistant.DataPropertyName = "second_assistant";
            this.second_assistant.HeaderText = "Ⅱ助";
            this.second_assistant.Name = "second_assistant";
            this.second_assistant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.second_assistant.Width = 60;
            // 
            // wound_grade
            // 
            this.wound_grade.DataPropertyName = "wound_grade";
            this.wound_grade.HeaderText = "切口等级";
            this.wound_grade.Items.AddRange(new object[] {
            "0",
            "Ⅰ",
            "Ⅱ",
            "Ⅲ"});
            this.wound_grade.Name = "wound_grade";
            this.wound_grade.Width = 40;
            // 
            // heal
            // 
            this.heal.DataPropertyName = "heal";
            this.heal.HeaderText = "愈合情况";
            this.heal.Items.AddRange(new object[] {
            "甲",
            "乙",
            "丙",
            "其他"});
            this.heal.Name = "heal";
            this.heal.Width = 60;
            // 
            // anaesthesia_method
            // 
            this.anaesthesia_method.DataPropertyName = "anaesthesia_method";
            this.anaesthesia_method.HeaderText = "麻醉方式";
            this.anaesthesia_method.Items.AddRange(new object[] {
            "局麻",
            "全麻",
            "表面麻醉",
            "硬膜外麻",
            "颈丛麻",
            "臂丛麻",
            "骶麻",
            "基础麻",
            "静脉麻",
            "腰麻",
            "针麻",
            "腰硬联合",
            "无麻醉"});
            this.anaesthesia_method.Name = "anaesthesia_method";
            this.anaesthesia_method.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.anaesthesia_method.Width = 70;
            // 
            // anesthesia_doctor
            // 
            this.anesthesia_doctor.DataPropertyName = "anesthesia_doctor";
            this.anesthesia_doctor.HeaderText = "麻醉医师";
            this.anesthesia_doctor.Name = "anesthesia_doctor";
            this.anesthesia_doctor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.anesthesia_doctor.Width = 80;
            // 
            // 检查标志
            // 
            this.检查标志.DataPropertyName = "jcbz";
            this.检查标志.HeaderText = "检查标志";
            this.检查标志.Name = "检查标志";
            this.检查标志.Visible = false;
            // 
            // ISMAIN
            // 
            this.ISMAIN.DataPropertyName = "ISMAIN";
            this.ISMAIN.HeaderText = "是否主要手术";
            this.ISMAIN.Items.AddRange(new object[] {
            "次",
            "主"});
            this.ISMAIN.Name = "ISMAIN";
            // 
            // ILLNESS
            // 
            this.ILLNESS.DataPropertyName = "ILLNESS";
            this.ILLNESS.HeaderText = "手术并发症";
            this.ILLNESS.Items.AddRange(new object[] {
            "有",
            "无"});
            this.ILLNESS.Name = "ILLNESS";
            // 
            // INFFECT
            // 
            this.INFFECT.DataPropertyName = "INFFECT";
            this.INFFECT.HeaderText = "手术是否感染";
            this.INFFECT.Items.AddRange(new object[] {
            "有",
            "无"});
            this.INFFECT.Name = "INFFECT";
            // 
            // OPERACCORD
            // 
            this.OPERACCORD.DataPropertyName = "OPERACCORD";
            this.OPERACCORD.HeaderText = "手术符合情况";
            this.OPERACCORD.Items.AddRange(new object[] {
            "符合",
            "不符合",
            "不肯定"});
            this.OPERACCORD.Name = "OPERACCORD";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(45, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 61);
            this.button1.TabIndex = 3066;
            this.button1.Text = "清除出院日期科室";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(604, 1925);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(36, 21);
            this.txt.TabIndex = 3059;
            this.txt.Visible = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackColor = System.Drawing.Color.White;
            this.pictureBox36.Enabled = false;
            this.pictureBox36.Location = new System.Drawing.Point(523, 393);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(65, 1);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox36.TabIndex = 557;
            this.pictureBox36.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(490, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3068;
            this.label3.Text = "病房：";
            // 
            // txtward_admission_to
            // 
            this.txtward_admission_to.BackColor = System.Drawing.Color.White;
            this.txtward_admission_to.Enabled = false;
            this.txtward_admission_to.ForeColor = System.Drawing.Color.Gray;
            this.txtward_admission_to.Location = new System.Drawing.Point(527, 377);
            this.txtward_admission_to.Name = "txtward_admission_to";
            this.txtward_admission_to.Size = new System.Drawing.Size(56, 21);
            this.txtward_admission_to.TabIndex = 3069;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("宋体", 9.75F);
            this.label88.ForeColor = System.Drawing.Color.Teal;
            this.label88.Location = new System.Drawing.Point(331, 927);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(59, 13);
            this.label88.TabIndex = 3127;
            this.label88.Text = "进修医师";
            // 
            // pictureBox47
            // 
            this.pictureBox47.Location = new System.Drawing.Point(37, 948);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(730, 1);
            this.pictureBox47.TabIndex = 3128;
            this.pictureBox47.TabStop = false;
            // 
            // label112
            // 
            this.label112.Location = new System.Drawing.Point(389, 924);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(86, 20);
            this.label112.TabIndex = 3130;
            // 
            // txtADVANCED_STUDIES_DOCTOR
            // 
            this.txtADVANCED_STUDIES_DOCTOR.Location = new System.Drawing.Point(392, 927);
            this.txtADVANCED_STUDIES_DOCTOR.Name = "txtADVANCED_STUDIES_DOCTOR";
            this.txtADVANCED_STUDIES_DOCTOR.ShortcutsEnabled = false;
            this.txtADVANCED_STUDIES_DOCTOR.Size = new System.Drawing.Size(80, 21);
            this.txtADVANCED_STUDIES_DOCTOR.TabIndex = 3131;
            this.txtADVANCED_STUDIES_DOCTOR.DoubleClick += new System.EventHandler(this.txtADVANCED_STUDIES_DOCTOR_DoubleClick);
            this.txtADVANCED_STUDIES_DOCTOR.Leave += new System.EventHandler(this.txtADVANCED_STUDIES_DOCTOR_Leave);
            this.txtADVANCED_STUDIES_DOCTOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtADVANCED_STUDIES_DOCTOR_KeyPress);
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("宋体", 9.75F);
            this.label113.ForeColor = System.Drawing.Color.Teal;
            this.label113.Location = new System.Drawing.Point(183, 928);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(59, 13);
            this.label113.TabIndex = 3132;
            this.label113.Text = "责任护士";
            // 
            // label114
            // 
            this.label114.Location = new System.Drawing.Point(245, 924);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(86, 20);
            this.label114.TabIndex = 3133;
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("宋体", 9.75F);
            this.label115.ForeColor = System.Drawing.Color.Teal;
            this.label115.Location = new System.Drawing.Point(476, 928);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(59, 13);
            this.label115.TabIndex = 3135;
            this.label115.Text = "实习医师";
            // 
            // txtLIABILITY_NURSE_ID
            // 
            this.txtLIABILITY_NURSE_ID.Location = new System.Drawing.Point(248, 927);
            this.txtLIABILITY_NURSE_ID.Name = "txtLIABILITY_NURSE_ID";
            this.txtLIABILITY_NURSE_ID.ShortcutsEnabled = false;
            this.txtLIABILITY_NURSE_ID.Size = new System.Drawing.Size(80, 21);
            this.txtLIABILITY_NURSE_ID.TabIndex = 3137;
            this.txtLIABILITY_NURSE_ID.DoubleClick += new System.EventHandler(this.txtLIABILITY_NURSE_ID_DoubleClick);
            this.txtLIABILITY_NURSE_ID.Leave += new System.EventHandler(this.txtLIABILITY_NURSE_ID_Leave);
            this.txtLIABILITY_NURSE_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLIABILITY_NURSE_ID_KeyPress);
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Font = new System.Drawing.Font("宋体", 9.75F);
            this.label117.ForeColor = System.Drawing.Color.Teal;
            this.label117.Location = new System.Drawing.Point(624, 927);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(46, 13);
            this.label117.TabIndex = 3138;
            this.label117.Text = "编码员";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(535, 924);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 3139;
            // 
            // txtPRACTICE_DOCTOR
            // 
            this.txtPRACTICE_DOCTOR.Location = new System.Drawing.Point(538, 927);
            this.txtPRACTICE_DOCTOR.Name = "txtPRACTICE_DOCTOR";
            this.txtPRACTICE_DOCTOR.Size = new System.Drawing.Size(80, 21);
            this.txtPRACTICE_DOCTOR.TabIndex = 3140;
            this.txtPRACTICE_DOCTOR.DoubleClick += new System.EventHandler(this.txtPRACTICE_DOCTOR_DoubleClick);
            this.txtPRACTICE_DOCTOR.Leave += new System.EventHandler(this.txtPRACTICE_DOCTOR_Leave);
            this.txtPRACTICE_DOCTOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPRACTICE_DOCTOR_KeyPress);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.ForeColor = System.Drawing.Color.Teal;
            this.label92.Location = new System.Drawing.Point(74, 178);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(107, 12);
            this.label92.TabIndex = 3149;
            this.label92.Text = "(年龄不足1周岁的)";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.ForeColor = System.Drawing.Color.Gray;
            this.label96.Location = new System.Drawing.Point(141, 22);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(41, 12);
            this.label96.TabIndex = 3150;
            this.label96.Text = "年龄：";
            this.label96.Visible = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Location = new System.Drawing.Point(185, 33);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(50, 1);
            this.pictureBox24.TabIndex = 3151;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Visible = false;
            // 
            // txtBABYAGE
            // 
            this.txtBABYAGE.ForeColor = System.Drawing.Color.Gray;
            this.txtBABYAGE.Location = new System.Drawing.Point(185, 19);
            this.txtBABYAGE.Name = "txtBABYAGE";
            this.txtBABYAGE.Size = new System.Drawing.Size(50, 21);
            this.txtBABYAGE.TabIndex = 3152;
            this.txtBABYAGE.Visible = false;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.ForeColor = System.Drawing.Color.Gray;
            this.label97.Location = new System.Drawing.Point(238, 20);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(17, 12);
            this.label97.TabIndex = 3153;
            this.label97.Text = "月";
            this.label97.Visible = false;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.ForeColor = System.Drawing.Color.Teal;
            this.label98.Location = new System.Drawing.Point(293, 178);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(101, 12);
            this.label98.TabIndex = 3154;
            this.label98.Text = "新生儿出生体重：";
            // 
            // pictureBox27
            // 
            this.pictureBox27.Enabled = false;
            this.pictureBox27.Location = new System.Drawing.Point(394, 191);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(50, 1);
            this.pictureBox27.TabIndex = 3155;
            this.pictureBox27.TabStop = false;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.ForeColor = System.Drawing.Color.Teal;
            this.label99.Location = new System.Drawing.Point(450, 178);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(17, 12);
            this.label99.TabIndex = 3156;
            this.label99.Text = "克";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.ForeColor = System.Drawing.Color.Teal;
            this.label101.Location = new System.Drawing.Point(485, 178);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(101, 12);
            this.label101.TabIndex = 3157;
            this.label101.Text = "新生儿入院体重：";
            // 
            // pictureBox42
            // 
            this.pictureBox42.Enabled = false;
            this.pictureBox42.Location = new System.Drawing.Point(578, 191);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(50, 1);
            this.pictureBox42.TabIndex = 3158;
            this.pictureBox42.TabStop = false;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.ForeColor = System.Drawing.Color.Teal;
            this.label102.Location = new System.Drawing.Point(634, 178);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(17, 12);
            this.label102.TabIndex = 3159;
            this.label102.Text = "克";
            // 
            // txtBABY_WEIGHT
            // 
            this.txtBABY_WEIGHT.BackColor = System.Drawing.Color.White;
            this.txtBABY_WEIGHT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBABY_WEIGHT.Location = new System.Drawing.Point(395, 177);
            this.txtBABY_WEIGHT.Name = "txtBABY_WEIGHT";
            this.txtBABY_WEIGHT.Size = new System.Drawing.Size(50, 21);
            this.txtBABY_WEIGHT.TabIndex = 3160;
            // 
            // txtBABY_R_WEIGHT
            // 
            this.txtBABY_R_WEIGHT.BackColor = System.Drawing.Color.White;
            this.txtBABY_R_WEIGHT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBABY_R_WEIGHT.Location = new System.Drawing.Point(579, 177);
            this.txtBABY_R_WEIGHT.Name = "txtBABY_R_WEIGHT";
            this.txtBABY_R_WEIGHT.Size = new System.Drawing.Size(50, 21);
            this.txtBABY_R_WEIGHT.TabIndex = 3161;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Enabled = false;
            this.label103.ForeColor = System.Drawing.Color.Gray;
            this.label103.Location = new System.Drawing.Point(322, 204);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(41, 12);
            this.label103.TabIndex = 3162;
            this.label103.Text = "籍贯：";
            // 
            // pictureBox45
            // 
            this.pictureBox45.Enabled = false;
            this.pictureBox45.Location = new System.Drawing.Point(358, 220);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(160, 1);
            this.pictureBox45.TabIndex = 3163;
            this.pictureBox45.TabStop = false;
            // 
            // txtJIGUAN
            // 
            this.txtJIGUAN.BackColor = System.Drawing.Color.White;
            this.txtJIGUAN.ForeColor = System.Drawing.Color.Gray;
            this.txtJIGUAN.Location = new System.Drawing.Point(359, 204);
            this.txtJIGUAN.Name = "txtJIGUAN";
            this.txtJIGUAN.Size = new System.Drawing.Size(160, 21);
            this.txtJIGUAN.TabIndex = 3164;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Enabled = false;
            this.label104.ForeColor = System.Drawing.Color.Gray;
            this.label104.Location = new System.Drawing.Point(49, 251);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(53, 12);
            this.label104.TabIndex = 3165;
            this.label104.Text = "现住址：";
            // 
            // pictureBox48
            // 
            this.pictureBox48.Enabled = false;
            this.pictureBox48.Location = new System.Drawing.Point(98, 265);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(349, 1);
            this.pictureBox48.TabIndex = 3166;
            this.pictureBox48.TabStop = false;
            // 
            // txtCurrent_Address
            // 
            this.txtCurrent_Address.BackColor = System.Drawing.Color.White;
            this.txtCurrent_Address.ForeColor = System.Drawing.Color.Gray;
            this.txtCurrent_Address.Location = new System.Drawing.Point(100, 249);
            this.txtCurrent_Address.Name = "txtCurrent_Address";
            this.txtCurrent_Address.Size = new System.Drawing.Size(135, 21);
            this.txtCurrent_Address.TabIndex = 3167;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Enabled = false;
            this.label105.ForeColor = System.Drawing.Color.Gray;
            this.label105.Location = new System.Drawing.Point(451, 251);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(41, 12);
            this.label105.TabIndex = 3168;
            this.label105.Text = "电话：";
            // 
            // pictureBox49
            // 
            this.pictureBox49.Enabled = false;
            this.pictureBox49.Location = new System.Drawing.Point(487, 265);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(117, 1);
            this.pictureBox49.TabIndex = 3169;
            this.pictureBox49.TabStop = false;
            // 
            // txtCurrent_Address_PHOTO
            // 
            this.txtCurrent_Address_PHOTO.BackColor = System.Drawing.Color.White;
            this.txtCurrent_Address_PHOTO.ForeColor = System.Drawing.Color.Gray;
            this.txtCurrent_Address_PHOTO.Location = new System.Drawing.Point(487, 249);
            this.txtCurrent_Address_PHOTO.Name = "txtCurrent_Address_PHOTO";
            this.txtCurrent_Address_PHOTO.Size = new System.Drawing.Size(117, 21);
            this.txtCurrent_Address_PHOTO.TabIndex = 3170;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Enabled = false;
            this.label106.ForeColor = System.Drawing.Color.Gray;
            this.label106.Location = new System.Drawing.Point(613, 252);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(41, 12);
            this.label106.TabIndex = 3171;
            this.label106.Text = "邮编：";
            // 
            // pictureBox50
            // 
            this.pictureBox50.Enabled = false;
            this.pictureBox50.Location = new System.Drawing.Point(655, 265);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(100, 1);
            this.pictureBox50.TabIndex = 3172;
            this.pictureBox50.TabStop = false;
            this.pictureBox50.Click += new System.EventHandler(this.pictureBox50_Click);
            // 
            // txtCurrent_Address_Zip_Code
            // 
            this.txtCurrent_Address_Zip_Code.BackColor = System.Drawing.Color.White;
            this.txtCurrent_Address_Zip_Code.ForeColor = System.Drawing.Color.Gray;
            this.txtCurrent_Address_Zip_Code.Location = new System.Drawing.Point(657, 248);
            this.txtCurrent_Address_Zip_Code.Name = "txtCurrent_Address_Zip_Code";
            this.txtCurrent_Address_Zip_Code.Size = new System.Drawing.Size(91, 21);
            this.txtCurrent_Address_Zip_Code.TabIndex = 3173;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Enabled = false;
            this.label107.ForeColor = System.Drawing.Color.Gray;
            this.label107.Location = new System.Drawing.Point(48, 355);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(65, 12);
            this.label107.TabIndex = 3174;
            this.label107.Text = "入院途径：";
            // 
            // comRUYUAN_PASS
            // 
            this.comRUYUAN_PASS.FormattingEnabled = true;
            this.comRUYUAN_PASS.Location = new System.Drawing.Point(111, 352);
            this.comRUYUAN_PASS.Name = "comRUYUAN_PASS";
            this.comRUYUAN_PASS.Size = new System.Drawing.Size(36, 20);
            this.comRUYUAN_PASS.TabIndex = 3175;
            this.comRUYUAN_PASS.SelectedIndexChanged += new System.EventHandler(this.comRUYUAN_PASS_SelectedIndexChanged);
            this.comRUYUAN_PASS.DropDownClosed += new System.EventHandler(this.comRUYUAN_PASS_DropDownClosed);
            this.comRUYUAN_PASS.DropDown += new System.EventHandler(this.comRUYUAN_PASS_DropDown);
            // 
            // txtRUYUAN_PASS
            // 
            this.txtRUYUAN_PASS.ForeColor = System.Drawing.Color.Gray;
            this.txtRUYUAN_PASS.Location = new System.Drawing.Point(113, 355);
            this.txtRUYUAN_PASS.Name = "txtRUYUAN_PASS";
            this.txtRUYUAN_PASS.Size = new System.Drawing.Size(16, 21);
            this.txtRUYUAN_PASS.TabIndex = 3176;
            this.txtRUYUAN_PASS.Tag = "－";
            this.txtRUYUAN_PASS.Text = "－";
            this.txtRUYUAN_PASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRUYUAN_PASS.DoubleClick += new System.EventHandler(this.txtRUYUAN_PASS_DoubleClick);
            this.txtRUYUAN_PASS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRUYUAN_PASS_KeyDown);
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Enabled = false;
            this.label108.ForeColor = System.Drawing.Color.Gray;
            this.label108.Location = new System.Drawing.Point(161, 356);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(257, 12);
            this.label108.TabIndex = 3177;
            this.label108.Text = "1.急诊  2.门诊  3.其他医疗机构转入  9.其他";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(236, 743);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(65, 12);
            this.label110.TabIndex = 3188;
            this.label110.Text = "病理诊断：";
            this.label110.Visible = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.Location = new System.Drawing.Point(296, 758);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(280, 1);
            this.pictureBox51.TabIndex = 3189;
            this.pictureBox51.TabStop = false;
            this.pictureBox51.Visible = false;
            // 
            // textdiagnosis_desc28
            // 
            this.textdiagnosis_desc28.Location = new System.Drawing.Point(295, 742);
            this.textdiagnosis_desc28.Name = "textdiagnosis_desc28";
            this.textdiagnosis_desc28.Size = new System.Drawing.Size(280, 21);
            this.textdiagnosis_desc28.TabIndex = 3190;
            this.textdiagnosis_desc28.Visible = false;
            this.textdiagnosis_desc28.TextChanged += new System.EventHandler(this.textdiagnosis_desc28_TextChanged);
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(586, 743);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(65, 12);
            this.label111.TabIndex = 3191;
            this.label111.Text = "疾病编码：";
            this.label111.Visible = false;
            // 
            // pictureBox52
            // 
            this.pictureBox52.Location = new System.Drawing.Point(648, 758);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(100, 1);
            this.pictureBox52.TabIndex = 3192;
            this.pictureBox52.TabStop = false;
            this.pictureBox52.Visible = false;
            // 
            // txtdiagnosis_code28
            // 
            this.txtdiagnosis_code28.ForeColor = System.Drawing.Color.Teal;
            this.txtdiagnosis_code28.Location = new System.Drawing.Point(650, 742);
            this.txtdiagnosis_code28.Name = "txtdiagnosis_code28";
            this.txtdiagnosis_code28.Size = new System.Drawing.Size(100, 21);
            this.txtdiagnosis_code28.TabIndex = 3193;
            this.txtdiagnosis_code28.Visible = false;
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(51, 743);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(53, 12);
            this.label121.TabIndex = 3194;
            this.label121.Text = "病理号：";
            // 
            // pictureBox53
            // 
            this.pictureBox53.Location = new System.Drawing.Point(96, 758);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(100, 1);
            this.pictureBox53.TabIndex = 3195;
            this.pictureBox53.TabStop = false;
            // 
            // txtBLH
            // 
            this.txtBLH.Location = new System.Drawing.Point(98, 742);
            this.txtBLH.Name = "txtBLH";
            this.txtBLH.Size = new System.Drawing.Size(100, 21);
            this.txtBLH.TabIndex = 3196;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(49, 776);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3197;
            this.label4.Text = "药物过敏：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-41, -26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3198;
            // 
            // comYWGM
            // 
            this.comYWGM.FormattingEnabled = true;
            this.comYWGM.Location = new System.Drawing.Point(116, 772);
            this.comYWGM.Name = "comYWGM";
            this.comYWGM.Size = new System.Drawing.Size(38, 20);
            this.comYWGM.TabIndex = 3199;
            this.comYWGM.Tag = "-";
            this.comYWGM.Text = "-";
            this.comYWGM.SelectedIndexChanged += new System.EventHandler(this.comYWGM_SelectedIndexChanged);
            this.comYWGM.DropDownClosed += new System.EventHandler(this.comYWGM_DropDownClosed);
            this.comYWGM.DropDown += new System.EventHandler(this.comYWGM_DropDown);
            // 
            // txtYWGM
            // 
            this.txtYWGM.Location = new System.Drawing.Point(119, 775);
            this.txtYWGM.Name = "txtYWGM";
            this.txtYWGM.Size = new System.Drawing.Size(18, 21);
            this.txtYWGM.TabIndex = 3200;
            this.txtYWGM.Tag = "－";
            this.txtYWGM.Text = "－";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(-15, -16);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(100, 50);
            this.pictureBox13.TabIndex = 3201;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox54
            // 
            this.pictureBox54.Location = new System.Drawing.Point(319, 790);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(177, 1);
            this.pictureBox54.TabIndex = 3202;
            this.pictureBox54.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 1216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 3203;
            this.label18.Text = "离院方式：";
            // 
            // comDISCHARGE_PASS
            // 
            this.comDISCHARGE_PASS.FormattingEnabled = true;
            this.comDISCHARGE_PASS.Location = new System.Drawing.Point(106, 1212);
            this.comDISCHARGE_PASS.Name = "comDISCHARGE_PASS";
            this.comDISCHARGE_PASS.Size = new System.Drawing.Size(38, 20);
            this.comDISCHARGE_PASS.TabIndex = 3204;
            this.comDISCHARGE_PASS.SelectedIndexChanged += new System.EventHandler(this.comDISCHARGE_PASS_SelectedIndexChanged);
            this.comDISCHARGE_PASS.DropDownClosed += new System.EventHandler(this.comDISCHARGE_PASS_DropDownClosed);
            this.comDISCHARGE_PASS.DropDown += new System.EventHandler(this.comDISCHARGE_PASS_DropDown);
            // 
            // txtDISCHARGE_PASS
            // 
            this.txtDISCHARGE_PASS.Location = new System.Drawing.Point(109, 1215);
            this.txtDISCHARGE_PASS.Name = "txtDISCHARGE_PASS";
            this.txtDISCHARGE_PASS.Size = new System.Drawing.Size(18, 21);
            this.txtDISCHARGE_PASS.TabIndex = 3205;
            this.txtDISCHARGE_PASS.Tag = "－";
            this.txtDISCHARGE_PASS.Text = "－";
            this.txtDISCHARGE_PASS.TextChanged += new System.EventHandler(this.txtDISCHARGE_PASS_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(162, 1217);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(263, 12);
            this.label19.TabIndex = 3206;
            this.label19.Text = "1.医嘱离院   2.医嘱转院，转入医疗机构名称：";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(422, 1229);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(200, 1);
            this.pictureBox15.TabIndex = 3207;
            this.pictureBox15.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(41, 1244);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(335, 12);
            this.label21.TabIndex = 3208;
            this.label21.Text = "3.医嘱转社区卫生服务机构/乡镇卫生院，转入医疗机构名称：";
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(367, 1259);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(200, 1);
            this.pictureBox22.TabIndex = 3209;
            this.pictureBox22.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(575, 1243);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(173, 12);
            this.label22.TabIndex = 3210;
            this.label22.Text = "4.非医嘱离院  5.死亡  9.其他";
            // 
            // txtZYMC
            // 
            this.txtZYMC.Location = new System.Drawing.Point(424, 1213);
            this.txtZYMC.Name = "txtZYMC";
            this.txtZYMC.Size = new System.Drawing.Size(200, 21);
            this.txtZYMC.TabIndex = 3211;
            // 
            // txtZYJG
            // 
            this.txtZYJG.Location = new System.Drawing.Point(369, 1243);
            this.txtZYJG.Name = "txtZYJG";
            this.txtZYJG.Size = new System.Drawing.Size(200, 21);
            this.txtZYJG.TabIndex = 3212;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(42, 1270);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(173, 12);
            this.label25.TabIndex = 3213;
            this.label25.Text = "是否有出院31天内再住院计划：";
            // 
            // comZRYJH
            // 
            this.comZRYJH.FormattingEnabled = true;
            this.comZRYJH.Location = new System.Drawing.Point(210, 1267);
            this.comZRYJH.Name = "comZRYJH";
            this.comZRYJH.Size = new System.Drawing.Size(38, 20);
            this.comZRYJH.TabIndex = 3214;
            this.comZRYJH.Tag = "0";
            this.comZRYJH.Text = "-";
            this.comZRYJH.SelectedIndexChanged += new System.EventHandler(this.comZRYJH_SelectedIndexChanged);
            this.comZRYJH.DropDownClosed += new System.EventHandler(this.comZRYJH_DropDownClosed);
            this.comZRYJH.DropDown += new System.EventHandler(this.comZRYJH_DropDown);
            // 
            // txtZRYJH
            // 
            this.txtZRYJH.Location = new System.Drawing.Point(213, 1270);
            this.txtZRYJH.Name = "txtZRYJH";
            this.txtZRYJH.Size = new System.Drawing.Size(18, 21);
            this.txtZRYJH.TabIndex = 3215;
            this.txtZRYJH.Tag = "－";
            this.txtZRYJH.Text = "－";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(273, 1271);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(137, 12);
            this.label27.TabIndex = 3216;
            this.label27.Text = "1.无  2.有，    目的：";
            // 
            // pictureBox25
            // 
            this.pictureBox25.Location = new System.Drawing.Point(404, 1287);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(200, 1);
            this.pictureBox25.TabIndex = 3217;
            this.pictureBox25.TabStop = false;
            // 
            // txtZYMD
            // 
            this.txtZYMD.Location = new System.Drawing.Point(406, 1271);
            this.txtZYMD.Name = "txtZYMD";
            this.txtZYMD.Size = new System.Drawing.Size(200, 21);
            this.txtZYMD.TabIndex = 3218;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(161, 776);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 12);
            this.label30.TabIndex = 3197;
            this.label30.Text = "1.无   2.有，";
            // 
            // cmdBLOOD_TYPE
            // 
            this.cmdBLOOD_TYPE.FormattingEnabled = true;
            this.cmdBLOOD_TYPE.Location = new System.Drawing.Point(90, 856);
            this.cmdBLOOD_TYPE.Name = "cmdBLOOD_TYPE";
            this.cmdBLOOD_TYPE.Size = new System.Drawing.Size(38, 20);
            this.cmdBLOOD_TYPE.TabIndex = 3220;
            this.cmdBLOOD_TYPE.SelectedIndexChanged += new System.EventHandler(this.cmdBLOOD_TYPE_SelectedIndexChanged);
            this.cmdBLOOD_TYPE.DropDownClosed += new System.EventHandler(this.cmdBLOOD_TYPE_DropDownClosed);
            this.cmdBLOOD_TYPE.DropDown += new System.EventHandler(this.cmdBLOOD_TYPE_DropDown);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label32.Location = new System.Drawing.Point(35, 1533);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(137, 12);
            this.label32.TabIndex = 3221;
            this.label32.Text = "住院费用（元）：总费用";
            // 
            // txtCOST_TOTAL
            // 
            this.txtCOST_TOTAL.BackColor = System.Drawing.Color.White;
            this.txtCOST_TOTAL.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_TOTAL.Location = new System.Drawing.Point(173, 1532);
            this.txtCOST_TOTAL.Name = "txtCOST_TOTAL";
            this.txtCOST_TOTAL.ReadOnly = true;
            this.txtCOST_TOTAL.Size = new System.Drawing.Size(120, 21);
            this.txtCOST_TOTAL.TabIndex = 3018;
            this.txtCOST_TOTAL.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(172, 1548);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(120, 1);
            this.pictureBox10.TabIndex = 3222;
            this.pictureBox10.TabStop = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label34.Location = new System.Drawing.Point(315, 1533);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 12);
            this.label34.TabIndex = 3052;
            this.label34.Text = "自付金额";
            // 
            // txtCOST_ZH_YBYL
            // 
            this.txtCOST_ZH_YBYL.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZH_YBYL.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZH_YBYL.Location = new System.Drawing.Point(273, 1555);
            this.txtCOST_ZH_YBYL.Name = "txtCOST_ZH_YBYL";
            this.txtCOST_ZH_YBYL.ReadOnly = true;
            this.txtCOST_ZH_YBYL.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_ZH_YBYL.TabIndex = 3018;
            this.txtCOST_ZH_YBYL.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(272, 1572);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(67, 1);
            this.pictureBox14.TabIndex = 3222;
            this.pictureBox14.TabStop = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label36.Location = new System.Drawing.Point(42, 1556);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(227, 12);
            this.label36.TabIndex = 3052;
            this.label36.Text = "1.综合医疗服务类：（1）一般医疗服务费";
            // 
            // txtCOST_OWNPAY
            // 
            this.txtCOST_OWNPAY.BackColor = System.Drawing.Color.White;
            this.txtCOST_OWNPAY.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_OWNPAY.Location = new System.Drawing.Point(373, 1532);
            this.txtCOST_OWNPAY.Name = "txtCOST_OWNPAY";
            this.txtCOST_OWNPAY.ReadOnly = true;
            this.txtCOST_OWNPAY.Size = new System.Drawing.Size(120, 21);
            this.txtCOST_OWNPAY.TabIndex = 3018;
            this.txtCOST_OWNPAY.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Location = new System.Drawing.Point(372, 1548);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(120, 1);
            this.pictureBox23.TabIndex = 3222;
            this.pictureBox23.TabStop = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label38.Location = new System.Drawing.Point(316, 1608);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(107, 12);
            this.label38.TabIndex = 3052;
            this.label38.Text = "（6）实验室诊断费";
            // 
            // txtCOST_ZD_SYS
            // 
            this.txtCOST_ZD_SYS.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZD_SYS.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZD_SYS.Location = new System.Drawing.Point(424, 1607);
            this.txtCOST_ZD_SYS.Name = "txtCOST_ZD_SYS";
            this.txtCOST_ZD_SYS.ReadOnly = true;
            this.txtCOST_ZD_SYS.Size = new System.Drawing.Size(75, 21);
            this.txtCOST_ZD_SYS.TabIndex = 3018;
            this.txtCOST_ZD_SYS.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Location = new System.Drawing.Point(423, 1624);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(75, 1);
            this.pictureBox26.TabIndex = 3222;
            this.pictureBox26.TabStop = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label40.Location = new System.Drawing.Point(579, 1556);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(71, 12);
            this.label40.TabIndex = 3052;
            this.label40.Text = "（3）护理费";
            // 
            // txtCOST_ZH_HL
            // 
            this.txtCOST_ZH_HL.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZH_HL.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZH_HL.Location = new System.Drawing.Point(652, 1555);
            this.txtCOST_ZH_HL.Name = "txtCOST_ZH_HL";
            this.txtCOST_ZH_HL.ReadOnly = true;
            this.txtCOST_ZH_HL.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_ZH_HL.TabIndex = 3018;
            this.txtCOST_ZH_HL.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.Location = new System.Drawing.Point(651, 1572);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(67, 1);
            this.pictureBox41.TabIndex = 3222;
            this.pictureBox41.TabStop = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label42.Location = new System.Drawing.Point(100, 1581);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(83, 12);
            this.label42.TabIndex = 3052;
            this.label42.Text = "（4）其他费用";
            // 
            // txtCOST_ZH_OTHER
            // 
            this.txtCOST_ZH_OTHER.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZH_OTHER.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZH_OTHER.Location = new System.Drawing.Point(194, 1580);
            this.txtCOST_ZH_OTHER.Name = "txtCOST_ZH_OTHER";
            this.txtCOST_ZH_OTHER.ReadOnly = true;
            this.txtCOST_ZH_OTHER.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_ZH_OTHER.TabIndex = 3018;
            this.txtCOST_ZH_OTHER.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.Location = new System.Drawing.Point(193, 1597);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(67, 1);
            this.pictureBox55.TabIndex = 3222;
            this.pictureBox55.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label44.Location = new System.Drawing.Point(39, 1608);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(155, 12);
            this.label44.TabIndex = 3052;
            this.label44.Text = "2.诊断类：（5）病理诊断费";
            // 
            // txtCOST_ZD_BL
            // 
            this.txtCOST_ZD_BL.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZD_BL.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZD_BL.Location = new System.Drawing.Point(199, 1607);
            this.txtCOST_ZD_BL.Name = "txtCOST_ZD_BL";
            this.txtCOST_ZD_BL.ReadOnly = true;
            this.txtCOST_ZD_BL.Size = new System.Drawing.Size(84, 21);
            this.txtCOST_ZD_BL.TabIndex = 3018;
            this.txtCOST_ZD_BL.TabStop = false;
            // 
            // pictureBox56
            // 
            this.pictureBox56.Location = new System.Drawing.Point(199, 1624);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(84, 1);
            this.pictureBox56.TabIndex = 3222;
            this.pictureBox56.TabStop = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label47.Location = new System.Drawing.Point(546, 1608);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(107, 12);
            this.label47.TabIndex = 3052;
            this.label47.Text = "（7）影像学诊断费";
            // 
            // txtCOST_ZD_YXX
            // 
            this.txtCOST_ZD_YXX.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZD_YXX.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZD_YXX.Location = new System.Drawing.Point(655, 1607);
            this.txtCOST_ZD_YXX.Name = "txtCOST_ZD_YXX";
            this.txtCOST_ZD_YXX.ReadOnly = true;
            this.txtCOST_ZD_YXX.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_ZD_YXX.TabIndex = 3018;
            this.txtCOST_ZD_YXX.TabStop = false;
            // 
            // pictureBox57
            // 
            this.pictureBox57.Location = new System.Drawing.Point(654, 1624);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(67, 1);
            this.pictureBox57.TabIndex = 3222;
            this.pictureBox57.TabStop = false;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label48.Location = new System.Drawing.Point(357, 1556);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(119, 12);
            this.label48.TabIndex = 3052;
            this.label48.Text = "（2）一般治疗操作费";
            // 
            // txtCOST_ZH_YBZL
            // 
            this.txtCOST_ZH_YBZL.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZH_YBZL.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZH_YBZL.Location = new System.Drawing.Point(479, 1555);
            this.txtCOST_ZH_YBZL.Name = "txtCOST_ZH_YBZL";
            this.txtCOST_ZH_YBZL.ReadOnly = true;
            this.txtCOST_ZH_YBZL.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_ZH_YBZL.TabIndex = 3018;
            this.txtCOST_ZH_YBZL.TabStop = false;
            // 
            // pictureBox58
            // 
            this.pictureBox58.Location = new System.Drawing.Point(478, 1572);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(67, 1);
            this.pictureBox58.TabIndex = 3222;
            this.pictureBox58.TabStop = false;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label50.Location = new System.Drawing.Point(98, 1633);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(119, 12);
            this.label50.TabIndex = 3052;
            this.label50.Text = "（8）临床诊断项目费";
            // 
            // txtCOST_ZD_LCXM
            // 
            this.txtCOST_ZD_LCXM.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZD_LCXM.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZD_LCXM.Location = new System.Drawing.Point(219, 1632);
            this.txtCOST_ZD_LCXM.Name = "txtCOST_ZD_LCXM";
            this.txtCOST_ZD_LCXM.ReadOnly = true;
            this.txtCOST_ZD_LCXM.Size = new System.Drawing.Size(74, 21);
            this.txtCOST_ZD_LCXM.TabIndex = 3018;
            this.txtCOST_ZD_LCXM.TabStop = false;
            // 
            // pictureBox59
            // 
            this.pictureBox59.Location = new System.Drawing.Point(218, 1648);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(74, 1);
            this.pictureBox59.TabIndex = 3222;
            this.pictureBox59.TabStop = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label52.Location = new System.Drawing.Point(39, 1658);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(191, 12);
            this.label52.TabIndex = 3052;
            this.label52.Text = "3.治疗类：（9）非手术治疗项目费";
            // 
            // txtCOST_ZL_FSSZLXM
            // 
            this.txtCOST_ZL_FSSZLXM.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZL_FSSZLXM.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZL_FSSZLXM.Location = new System.Drawing.Point(234, 1657);
            this.txtCOST_ZL_FSSZLXM.Name = "txtCOST_ZL_FSSZLXM";
            this.txtCOST_ZL_FSSZLXM.ReadOnly = true;
            this.txtCOST_ZL_FSSZLXM.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_ZL_FSSZLXM.TabIndex = 3018;
            this.txtCOST_ZL_FSSZLXM.TabStop = false;
            // 
            // pictureBox60
            // 
            this.pictureBox60.Location = new System.Drawing.Point(233, 1675);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(67, 1);
            this.pictureBox60.TabIndex = 3222;
            this.pictureBox60.TabStop = false;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label54.Location = new System.Drawing.Point(343, 1658);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(89, 12);
            this.label54.TabIndex = 3052;
            this.label54.Text = "临床物理治疗费";
            // 
            // txtCOST_ZL_LCWLZL
            // 
            this.txtCOST_ZL_LCWLZL.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZL_LCWLZL.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZL_LCWLZL.Location = new System.Drawing.Point(438, 1657);
            this.txtCOST_ZL_LCWLZL.Name = "txtCOST_ZL_LCWLZL";
            this.txtCOST_ZL_LCWLZL.ReadOnly = true;
            this.txtCOST_ZL_LCWLZL.Size = new System.Drawing.Size(75, 21);
            this.txtCOST_ZL_LCWLZL.TabIndex = 3018;
            this.txtCOST_ZL_LCWLZL.TabStop = false;
            // 
            // pictureBox61
            // 
            this.pictureBox61.Location = new System.Drawing.Point(437, 1675);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(75, 1);
            this.pictureBox61.TabIndex = 3222;
            this.pictureBox61.TabStop = false;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label55.Location = new System.Drawing.Point(98, 1683);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(101, 12);
            this.label55.TabIndex = 3052;
            this.label55.Text = "（10）手术治疗费";
            // 
            // txtCOST_ZL_SSZL
            // 
            this.txtCOST_ZL_SSZL.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZL_SSZL.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZL_SSZL.Location = new System.Drawing.Point(202, 1682);
            this.txtCOST_ZL_SSZL.Name = "txtCOST_ZL_SSZL";
            this.txtCOST_ZL_SSZL.ReadOnly = true;
            this.txtCOST_ZL_SSZL.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_ZL_SSZL.TabIndex = 3018;
            this.txtCOST_ZL_SSZL.TabStop = false;
            // 
            // pictureBox62
            // 
            this.pictureBox62.Location = new System.Drawing.Point(201, 1698);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(67, 1);
            this.pictureBox62.TabIndex = 3222;
            this.pictureBox62.TabStop = false;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label58.Location = new System.Drawing.Point(390, 1683);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(41, 12);
            this.label58.TabIndex = 3052;
            this.label58.Text = "麻醉费";
            // 
            // txtCOST_ZL_MZ
            // 
            this.txtCOST_ZL_MZ.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZL_MZ.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZL_MZ.Location = new System.Drawing.Point(438, 1682);
            this.txtCOST_ZL_MZ.Name = "txtCOST_ZL_MZ";
            this.txtCOST_ZL_MZ.ReadOnly = true;
            this.txtCOST_ZL_MZ.Size = new System.Drawing.Size(75, 21);
            this.txtCOST_ZL_MZ.TabIndex = 3018;
            this.txtCOST_ZL_MZ.TabStop = false;
            // 
            // pictureBox63
            // 
            this.pictureBox63.Location = new System.Drawing.Point(438, 1698);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(75, 1);
            this.pictureBox63.TabIndex = 3222;
            this.pictureBox63.TabStop = false;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label59.Location = new System.Drawing.Point(612, 1683);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(41, 12);
            this.label59.TabIndex = 3052;
            this.label59.Text = "手术费";
            // 
            // txtCOST_ZL_SS
            // 
            this.txtCOST_ZL_SS.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZL_SS.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZL_SS.Location = new System.Drawing.Point(657, 1682);
            this.txtCOST_ZL_SS.Name = "txtCOST_ZL_SS";
            this.txtCOST_ZL_SS.ReadOnly = true;
            this.txtCOST_ZL_SS.Size = new System.Drawing.Size(70, 21);
            this.txtCOST_ZL_SS.TabIndex = 3018;
            this.txtCOST_ZL_SS.TabStop = false;
            // 
            // pictureBox64
            // 
            this.pictureBox64.Location = new System.Drawing.Point(656, 1698);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(70, 1);
            this.pictureBox64.TabIndex = 3222;
            this.pictureBox64.TabStop = false;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label60.Location = new System.Drawing.Point(38, 1708);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(137, 12);
            this.label60.TabIndex = 3052;
            this.label60.Text = "4.康复类：（11）康复费";
            // 
            // txtCOST_KF_KF
            // 
            this.txtCOST_KF_KF.BackColor = System.Drawing.Color.White;
            this.txtCOST_KF_KF.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_KF_KF.Location = new System.Drawing.Point(182, 1707);
            this.txtCOST_KF_KF.Name = "txtCOST_KF_KF";
            this.txtCOST_KF_KF.ReadOnly = true;
            this.txtCOST_KF_KF.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_KF_KF.TabIndex = 3018;
            this.txtCOST_KF_KF.TabStop = false;
            // 
            // pictureBox65
            // 
            this.pictureBox65.Location = new System.Drawing.Point(181, 1724);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(67, 1);
            this.pictureBox65.TabIndex = 3222;
            this.pictureBox65.TabStop = false;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label64.Location = new System.Drawing.Point(269, 1708);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(161, 12);
            this.label64.TabIndex = 3052;
            this.label64.Text = "5.中医类：（12）中医治疗费";
            // 
            // txtCOST_ZY_ZYZL
            // 
            this.txtCOST_ZY_ZYZL.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZY_ZYZL.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZY_ZYZL.Location = new System.Drawing.Point(437, 1718);
            this.txtCOST_ZY_ZYZL.Name = "txtCOST_ZY_ZYZL";
            this.txtCOST_ZY_ZYZL.ReadOnly = true;
            this.txtCOST_ZY_ZYZL.Size = new System.Drawing.Size(76, 21);
            this.txtCOST_ZY_ZYZL.TabIndex = 3018;
            this.txtCOST_ZY_ZYZL.TabStop = false;
            // 
            // pictureBox66
            // 
            this.pictureBox66.Location = new System.Drawing.Point(436, 1724);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(76, 1);
            this.pictureBox66.TabIndex = 3222;
            this.pictureBox66.TabStop = false;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label65.Location = new System.Drawing.Point(38, 1733);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(137, 12);
            this.label65.TabIndex = 3052;
            this.label65.Text = "6.西药类：（13）西药费";
            // 
            // txtCOST_XY_XY
            // 
            this.txtCOST_XY_XY.BackColor = System.Drawing.Color.White;
            this.txtCOST_XY_XY.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_XY_XY.Location = new System.Drawing.Point(180, 1732);
            this.txtCOST_XY_XY.Name = "txtCOST_XY_XY";
            this.txtCOST_XY_XY.ReadOnly = true;
            this.txtCOST_XY_XY.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_XY_XY.TabIndex = 3018;
            this.txtCOST_XY_XY.TabStop = false;
            // 
            // pictureBox67
            // 
            this.pictureBox67.Location = new System.Drawing.Point(179, 1749);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(67, 1);
            this.pictureBox67.TabIndex = 3222;
            this.pictureBox67.TabStop = false;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label67.Location = new System.Drawing.Point(38, 1758);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(149, 12);
            this.label67.TabIndex = 3052;
            this.label67.Text = "7.中药类：（14）中成药费";
            // 
            // txtCOST_ZY_ZCHY
            // 
            this.txtCOST_ZY_ZCHY.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZY_ZCHY.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZY_ZCHY.Location = new System.Drawing.Point(191, 1757);
            this.txtCOST_ZY_ZCHY.Name = "txtCOST_ZY_ZCHY";
            this.txtCOST_ZY_ZCHY.ReadOnly = true;
            this.txtCOST_ZY_ZCHY.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_ZY_ZCHY.TabIndex = 3018;
            this.txtCOST_ZY_ZCHY.TabStop = false;
            // 
            // pictureBox68
            // 
            this.pictureBox68.Location = new System.Drawing.Point(190, 1775);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(67, 1);
            this.pictureBox68.TabIndex = 3222;
            this.pictureBox68.TabStop = false;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label85.Location = new System.Drawing.Point(351, 1733);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(77, 12);
            this.label85.TabIndex = 3052;
            this.label85.Text = "抗菌药物费用";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label86.Location = new System.Drawing.Point(340, 1758);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(89, 12);
            this.label86.TabIndex = 3052;
            this.label86.Text = "（15）中草药费";
            // 
            // txtCOST_XY_KJYW
            // 
            this.txtCOST_XY_KJYW.BackColor = System.Drawing.Color.White;
            this.txtCOST_XY_KJYW.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_XY_KJYW.Location = new System.Drawing.Point(433, 1732);
            this.txtCOST_XY_KJYW.Name = "txtCOST_XY_KJYW";
            this.txtCOST_XY_KJYW.ReadOnly = true;
            this.txtCOST_XY_KJYW.Size = new System.Drawing.Size(79, 21);
            this.txtCOST_XY_KJYW.TabIndex = 3018;
            this.txtCOST_XY_KJYW.TabStop = false;
            // 
            // txtCOST_ZY_ZCAOY
            // 
            this.txtCOST_ZY_ZCAOY.BackColor = System.Drawing.Color.White;
            this.txtCOST_ZY_ZCAOY.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_ZY_ZCAOY.Location = new System.Drawing.Point(433, 1757);
            this.txtCOST_ZY_ZCAOY.Name = "txtCOST_ZY_ZCAOY";
            this.txtCOST_ZY_ZCAOY.ReadOnly = true;
            this.txtCOST_ZY_ZCAOY.Size = new System.Drawing.Size(79, 21);
            this.txtCOST_ZY_ZCAOY.TabIndex = 3018;
            this.txtCOST_ZY_ZCAOY.TabStop = false;
            // 
            // pictureBox69
            // 
            this.pictureBox69.Location = new System.Drawing.Point(432, 1749);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(79, 1);
            this.pictureBox69.TabIndex = 3222;
            this.pictureBox69.TabStop = false;
            // 
            // pictureBox70
            // 
            this.pictureBox70.Location = new System.Drawing.Point(432, 1775);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(79, 1);
            this.pictureBox70.TabIndex = 3222;
            this.pictureBox70.TabStop = false;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label87.Location = new System.Drawing.Point(39, 1783);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(185, 12);
            this.label87.TabIndex = 3052;
            this.label87.Text = "8.血液和血液制品类：（16）血费";
            // 
            // txtCOST_XY_XF
            // 
            this.txtCOST_XY_XF.BackColor = System.Drawing.Color.White;
            this.txtCOST_XY_XF.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_XY_XF.Location = new System.Drawing.Point(223, 1782);
            this.txtCOST_XY_XF.Name = "txtCOST_XY_XF";
            this.txtCOST_XY_XF.ReadOnly = true;
            this.txtCOST_XY_XF.Size = new System.Drawing.Size(67, 21);
            this.txtCOST_XY_XF.TabIndex = 3018;
            this.txtCOST_XY_XF.TabStop = false;
            // 
            // pictureBox71
            // 
            this.pictureBox71.Location = new System.Drawing.Point(222, 1800);
            this.pictureBox71.Name = "pictureBox71";
            this.pictureBox71.Size = new System.Drawing.Size(67, 1);
            this.pictureBox71.TabIndex = 3222;
            this.pictureBox71.TabStop = false;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label89.Location = new System.Drawing.Point(304, 1783);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(125, 12);
            this.label89.TabIndex = 3052;
            this.label89.Text = "（17）白蛋白类制品费";
            // 
            // txtCOST_XY_BDB
            // 
            this.txtCOST_XY_BDB.BackColor = System.Drawing.Color.White;
            this.txtCOST_XY_BDB.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_XY_BDB.Location = new System.Drawing.Point(435, 1782);
            this.txtCOST_XY_BDB.Name = "txtCOST_XY_BDB";
            this.txtCOST_XY_BDB.ReadOnly = true;
            this.txtCOST_XY_BDB.Size = new System.Drawing.Size(79, 21);
            this.txtCOST_XY_BDB.TabIndex = 3018;
            this.txtCOST_XY_BDB.TabStop = false;
            // 
            // pictureBox72
            // 
            this.pictureBox72.Location = new System.Drawing.Point(434, 1800);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(79, 1);
            this.pictureBox72.TabIndex = 3222;
            this.pictureBox72.TabStop = false;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label91.Location = new System.Drawing.Point(528, 1783);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(125, 12);
            this.label91.TabIndex = 3052;
            this.label91.Text = "（18）球蛋白类制品费";
            // 
            // txtCOST_XY_QDB
            // 
            this.txtCOST_XY_QDB.BackColor = System.Drawing.Color.White;
            this.txtCOST_XY_QDB.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_XY_QDB.Location = new System.Drawing.Point(656, 1782);
            this.txtCOST_XY_QDB.Name = "txtCOST_XY_QDB";
            this.txtCOST_XY_QDB.ReadOnly = true;
            this.txtCOST_XY_QDB.Size = new System.Drawing.Size(71, 21);
            this.txtCOST_XY_QDB.TabIndex = 3018;
            this.txtCOST_XY_QDB.TabStop = false;
            // 
            // pictureBox73
            // 
            this.pictureBox73.Location = new System.Drawing.Point(655, 1800);
            this.pictureBox73.Name = "pictureBox73";
            this.pictureBox73.Size = new System.Drawing.Size(71, 1);
            this.pictureBox73.TabIndex = 3222;
            this.pictureBox73.TabStop = false;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label93.Location = new System.Drawing.Point(98, 1808);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(137, 12);
            this.label93.TabIndex = 3052;
            this.label93.Text = "（19）凝血因子类制品费";
            // 
            // txtCOST_XY_NXYZ
            // 
            this.txtCOST_XY_NXYZ.BackColor = System.Drawing.Color.White;
            this.txtCOST_XY_NXYZ.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_XY_NXYZ.Location = new System.Drawing.Point(236, 1807);
            this.txtCOST_XY_NXYZ.Name = "txtCOST_XY_NXYZ";
            this.txtCOST_XY_NXYZ.ReadOnly = true;
            this.txtCOST_XY_NXYZ.Size = new System.Drawing.Size(79, 21);
            this.txtCOST_XY_NXYZ.TabIndex = 3018;
            this.txtCOST_XY_NXYZ.TabStop = false;
            // 
            // pictureBox74
            // 
            this.pictureBox74.Location = new System.Drawing.Point(235, 1824);
            this.pictureBox74.Name = "pictureBox74";
            this.pictureBox74.Size = new System.Drawing.Size(79, 1);
            this.pictureBox74.TabIndex = 3222;
            this.pictureBox74.TabStop = false;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label94.Location = new System.Drawing.Point(335, 1808);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(137, 12);
            this.label94.TabIndex = 3052;
            this.label94.Text = "（20）细胞因子类制品费";
            // 
            // txtCOST_XY_XBYZ
            // 
            this.txtCOST_XY_XBYZ.BackColor = System.Drawing.Color.White;
            this.txtCOST_XY_XBYZ.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_XY_XBYZ.Location = new System.Drawing.Point(473, 1807);
            this.txtCOST_XY_XBYZ.Name = "txtCOST_XY_XBYZ";
            this.txtCOST_XY_XBYZ.ReadOnly = true;
            this.txtCOST_XY_XBYZ.Size = new System.Drawing.Size(79, 21);
            this.txtCOST_XY_XBYZ.TabIndex = 3018;
            this.txtCOST_XY_XBYZ.TabStop = false;
            // 
            // pictureBox75
            // 
            this.pictureBox75.Location = new System.Drawing.Point(472, 1824);
            this.pictureBox75.Name = "pictureBox75";
            this.pictureBox75.Size = new System.Drawing.Size(79, 1);
            this.pictureBox75.TabIndex = 3222;
            this.pictureBox75.TabStop = false;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label95.Location = new System.Drawing.Point(38, 1833);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(233, 12);
            this.label95.TabIndex = 3052;
            this.label95.Text = "9.耗材类：（21）检查用一次性医用材料费";
            // 
            // txtCOST_HC_JC
            // 
            this.txtCOST_HC_JC.BackColor = System.Drawing.Color.White;
            this.txtCOST_HC_JC.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_HC_JC.Location = new System.Drawing.Point(273, 1832);
            this.txtCOST_HC_JC.Name = "txtCOST_HC_JC";
            this.txtCOST_HC_JC.ReadOnly = true;
            this.txtCOST_HC_JC.Size = new System.Drawing.Size(79, 21);
            this.txtCOST_HC_JC.TabIndex = 3018;
            this.txtCOST_HC_JC.TabStop = false;
            // 
            // pictureBox76
            // 
            this.pictureBox76.Location = new System.Drawing.Point(272, 1849);
            this.pictureBox76.Name = "pictureBox76";
            this.pictureBox76.Size = new System.Drawing.Size(79, 1);
            this.pictureBox76.TabIndex = 3222;
            this.pictureBox76.TabStop = false;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label100.Location = new System.Drawing.Point(466, 1833);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(173, 12);
            this.label100.TabIndex = 3052;
            this.label100.Text = "（22）治疗用一次性医用材料费";
            // 
            // txtCOST_HC_ZL
            // 
            this.txtCOST_HC_ZL.BackColor = System.Drawing.Color.White;
            this.txtCOST_HC_ZL.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_HC_ZL.Location = new System.Drawing.Point(645, 1832);
            this.txtCOST_HC_ZL.Name = "txtCOST_HC_ZL";
            this.txtCOST_HC_ZL.ReadOnly = true;
            this.txtCOST_HC_ZL.Size = new System.Drawing.Size(83, 21);
            this.txtCOST_HC_ZL.TabIndex = 3018;
            this.txtCOST_HC_ZL.TabStop = false;
            // 
            // pictureBox77
            // 
            this.pictureBox77.Location = new System.Drawing.Point(644, 1849);
            this.pictureBox77.Name = "pictureBox77";
            this.pictureBox77.Size = new System.Drawing.Size(83, 1);
            this.pictureBox77.TabIndex = 3222;
            this.pictureBox77.TabStop = false;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label109.Location = new System.Drawing.Point(97, 1858);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(173, 12);
            this.label109.TabIndex = 3052;
            this.label109.Text = "（23）手术用一次性医用材料费";
            // 
            // txtCOST_HC_SS
            // 
            this.txtCOST_HC_SS.BackColor = System.Drawing.Color.White;
            this.txtCOST_HC_SS.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_HC_SS.Location = new System.Drawing.Point(276, 1857);
            this.txtCOST_HC_SS.Name = "txtCOST_HC_SS";
            this.txtCOST_HC_SS.ReadOnly = true;
            this.txtCOST_HC_SS.Size = new System.Drawing.Size(79, 21);
            this.txtCOST_HC_SS.TabIndex = 3018;
            this.txtCOST_HC_SS.TabStop = false;
            // 
            // pictureBox78
            // 
            this.pictureBox78.Location = new System.Drawing.Point(275, 1874);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(79, 1);
            this.pictureBox78.TabIndex = 3222;
            this.pictureBox78.TabStop = false;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label116.Location = new System.Drawing.Point(40, 1883);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(143, 12);
            this.label116.TabIndex = 3052;
            this.label116.Text = "10.其他类：（24）其他费";
            // 
            // txtCOST_OTHER
            // 
            this.txtCOST_OTHER.BackColor = System.Drawing.Color.White;
            this.txtCOST_OTHER.ForeColor = System.Drawing.Color.Gray;
            this.txtCOST_OTHER.Location = new System.Drawing.Point(187, 1882);
            this.txtCOST_OTHER.Name = "txtCOST_OTHER";
            this.txtCOST_OTHER.ReadOnly = true;
            this.txtCOST_OTHER.Size = new System.Drawing.Size(79, 21);
            this.txtCOST_OTHER.TabIndex = 3018;
            this.txtCOST_OTHER.TabStop = false;
            // 
            // pictureBox79
            // 
            this.pictureBox79.Location = new System.Drawing.Point(186, 1898);
            this.pictureBox79.Name = "pictureBox79";
            this.pictureBox79.Size = new System.Drawing.Size(79, 1);
            this.pictureBox79.TabIndex = 3222;
            this.pictureBox79.TabStop = false;
            // 
            // label118
            // 
            this.label118.ForeColor = System.Drawing.Color.Teal;
            this.label118.Location = new System.Drawing.Point(82, 1952);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(544, 23);
            this.label118.TabIndex = 598;
            this.label118.Text = "（二）凡可由医院信息系统提供住院费用清单的，住院病案首页中可不填写“住院费用”";
            this.label118.Click += new System.EventHandler(this.label57_Click);
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(499, 1296);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(17, 12);
            this.label129.TabIndex = 3256;
            this.label129.Text = "天";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(260, 1296);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(17, 12);
            this.label128.TabIndex = 3257;
            this.label128.Text = "天";
            // 
            // pictureBox85
            // 
            this.pictureBox85.Location = new System.Drawing.Point(578, 1309);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(40, 1);
            this.pictureBox85.TabIndex = 3252;
            this.pictureBox85.TabStop = false;
            // 
            // pictureBox82
            // 
            this.pictureBox82.Location = new System.Drawing.Point(339, 1309);
            this.pictureBox82.Name = "pictureBox82";
            this.pictureBox82.Size = new System.Drawing.Size(40, 1);
            this.pictureBox82.TabIndex = 3251;
            this.pictureBox82.TabStop = false;
            // 
            // pictureBox84
            // 
            this.pictureBox84.Location = new System.Drawing.Point(513, 1309);
            this.pictureBox84.Name = "pictureBox84";
            this.pictureBox84.Size = new System.Drawing.Size(40, 1);
            this.pictureBox84.TabIndex = 3250;
            this.pictureBox84.TabStop = false;
            // 
            // pictureBox81
            // 
            this.pictureBox81.Location = new System.Drawing.Point(274, 1309);
            this.pictureBox81.Name = "pictureBox81";
            this.pictureBox81.Size = new System.Drawing.Size(40, 1);
            this.pictureBox81.TabIndex = 3255;
            this.pictureBox81.TabStop = false;
            // 
            // pictureBox83
            // 
            this.pictureBox83.Location = new System.Drawing.Point(456, 1309);
            this.pictureBox83.Name = "pictureBox83";
            this.pictureBox83.Size = new System.Drawing.Size(40, 1);
            this.pictureBox83.TabIndex = 3254;
            this.pictureBox83.TabStop = false;
            // 
            // pictureBox80
            // 
            this.pictureBox80.Location = new System.Drawing.Point(217, 1309);
            this.pictureBox80.Name = "pictureBox80";
            this.pictureBox80.Size = new System.Drawing.Size(40, 1);
            this.pictureBox80.TabIndex = 3253;
            this.pictureBox80.TabStop = false;
            // 
            // txtLNSS_A_HOSPITAL_MIN
            // 
            this.txtLNSS_A_HOSPITAL_MIN.BackColor = System.Drawing.SystemColors.Window;
            this.txtLNSS_A_HOSPITAL_MIN.ForeColor = System.Drawing.Color.Black;
            this.txtLNSS_A_HOSPITAL_MIN.Location = new System.Drawing.Point(580, 1294);
            this.txtLNSS_A_HOSPITAL_MIN.Name = "txtLNSS_A_HOSPITAL_MIN";
            this.txtLNSS_A_HOSPITAL_MIN.Size = new System.Drawing.Size(35, 21);
            this.txtLNSS_A_HOSPITAL_MIN.TabIndex = 3248;
            this.txtLNSS_A_HOSPITAL_MIN.TabStop = false;
            this.txtLNSS_A_HOSPITAL_MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLNSS_A_HOSPITAL_MIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLNSS_P_HOSPITAL_DAYS_KeyPress);
            // 
            // txtLNSS_P_HOSPITAL_MIN
            // 
            this.txtLNSS_P_HOSPITAL_MIN.BackColor = System.Drawing.SystemColors.Window;
            this.txtLNSS_P_HOSPITAL_MIN.ForeColor = System.Drawing.Color.Black;
            this.txtLNSS_P_HOSPITAL_MIN.Location = new System.Drawing.Point(341, 1294);
            this.txtLNSS_P_HOSPITAL_MIN.Name = "txtLNSS_P_HOSPITAL_MIN";
            this.txtLNSS_P_HOSPITAL_MIN.Size = new System.Drawing.Size(35, 21);
            this.txtLNSS_P_HOSPITAL_MIN.TabIndex = 3249;
            this.txtLNSS_P_HOSPITAL_MIN.TabStop = false;
            this.txtLNSS_P_HOSPITAL_MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLNSS_P_HOSPITAL_MIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLNSS_P_HOSPITAL_DAYS_KeyPress);
            // 
            // txtLNSS_A_HOSPITAL_HOURS
            // 
            this.txtLNSS_A_HOSPITAL_HOURS.BackColor = System.Drawing.SystemColors.Window;
            this.txtLNSS_A_HOSPITAL_HOURS.ForeColor = System.Drawing.Color.Black;
            this.txtLNSS_A_HOSPITAL_HOURS.Location = new System.Drawing.Point(515, 1294);
            this.txtLNSS_A_HOSPITAL_HOURS.Name = "txtLNSS_A_HOSPITAL_HOURS";
            this.txtLNSS_A_HOSPITAL_HOURS.Size = new System.Drawing.Size(35, 21);
            this.txtLNSS_A_HOSPITAL_HOURS.TabIndex = 3247;
            this.txtLNSS_A_HOSPITAL_HOURS.TabStop = false;
            this.txtLNSS_A_HOSPITAL_HOURS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLNSS_A_HOSPITAL_HOURS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLNSS_P_HOSPITAL_DAYS_KeyPress);
            // 
            // txtLNSS_P_HOSPITAL_HOURS
            // 
            this.txtLNSS_P_HOSPITAL_HOURS.BackColor = System.Drawing.SystemColors.Window;
            this.txtLNSS_P_HOSPITAL_HOURS.ForeColor = System.Drawing.Color.Black;
            this.txtLNSS_P_HOSPITAL_HOURS.Location = new System.Drawing.Point(276, 1294);
            this.txtLNSS_P_HOSPITAL_HOURS.Name = "txtLNSS_P_HOSPITAL_HOURS";
            this.txtLNSS_P_HOSPITAL_HOURS.Size = new System.Drawing.Size(35, 21);
            this.txtLNSS_P_HOSPITAL_HOURS.TabIndex = 3244;
            this.txtLNSS_P_HOSPITAL_HOURS.TabStop = false;
            this.txtLNSS_P_HOSPITAL_HOURS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLNSS_P_HOSPITAL_HOURS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLNSS_P_HOSPITAL_DAYS_KeyPress);
            // 
            // txtLNSS_A_HOSPITAL_DAYS
            // 
            this.txtLNSS_A_HOSPITAL_DAYS.BackColor = System.Drawing.SystemColors.Window;
            this.txtLNSS_A_HOSPITAL_DAYS.ForeColor = System.Drawing.Color.Black;
            this.txtLNSS_A_HOSPITAL_DAYS.Location = new System.Drawing.Point(458, 1294);
            this.txtLNSS_A_HOSPITAL_DAYS.Name = "txtLNSS_A_HOSPITAL_DAYS";
            this.txtLNSS_A_HOSPITAL_DAYS.Size = new System.Drawing.Size(35, 21);
            this.txtLNSS_A_HOSPITAL_DAYS.TabIndex = 3245;
            this.txtLNSS_A_HOSPITAL_DAYS.TabStop = false;
            this.txtLNSS_A_HOSPITAL_DAYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLNSS_A_HOSPITAL_DAYS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLNSS_P_HOSPITAL_DAYS_KeyPress);
            // 
            // txtLNSS_P_HOSPITAL_DAYS
            // 
            this.txtLNSS_P_HOSPITAL_DAYS.BackColor = System.Drawing.SystemColors.Window;
            this.txtLNSS_P_HOSPITAL_DAYS.ForeColor = System.Drawing.Color.Black;
            this.txtLNSS_P_HOSPITAL_DAYS.Location = new System.Drawing.Point(219, 1294);
            this.txtLNSS_P_HOSPITAL_DAYS.Name = "txtLNSS_P_HOSPITAL_DAYS";
            this.txtLNSS_P_HOSPITAL_DAYS.Size = new System.Drawing.Size(35, 21);
            this.txtLNSS_P_HOSPITAL_DAYS.TabIndex = 3246;
            this.txtLNSS_P_HOSPITAL_DAYS.TabStop = false;
            this.txtLNSS_P_HOSPITAL_DAYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLNSS_P_HOSPITAL_DAYS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLNSS_P_HOSPITAL_DAYS_KeyPress);
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.ForeColor = System.Drawing.Color.Teal;
            this.label127.Location = new System.Drawing.Point(618, 1296);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(29, 12);
            this.label127.TabIndex = 3242;
            this.label127.Text = "分钟";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.ForeColor = System.Drawing.Color.Teal;
            this.label125.Location = new System.Drawing.Point(554, 1298);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(29, 12);
            this.label125.TabIndex = 3238;
            this.label125.Text = "小时";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.ForeColor = System.Drawing.Color.Teal;
            this.label123.Location = new System.Drawing.Point(379, 1296);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(29, 12);
            this.label123.TabIndex = 3243;
            this.label123.Text = "分钟";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.ForeColor = System.Drawing.Color.Teal;
            this.label124.Location = new System.Drawing.Point(417, 1298);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(41, 12);
            this.label124.TabIndex = 3241;
            this.label124.Text = "入院后";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.ForeColor = System.Drawing.Color.Teal;
            this.label122.Location = new System.Drawing.Point(315, 1298);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(29, 12);
            this.label122.TabIndex = 3237;
            this.label122.Text = "小时";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.ForeColor = System.Drawing.Color.Teal;
            this.label119.Location = new System.Drawing.Point(177, 1298);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(41, 12);
            this.label119.TabIndex = 3240;
            this.label119.Text = "入院前";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.ForeColor = System.Drawing.Color.Teal;
            this.label120.Location = new System.Drawing.Point(41, 1298);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(137, 12);
            this.label120.TabIndex = 3239;
            this.label120.Text = "昏迷时间(颅脑损伤患者)";
            // 
            // txtAge2
            // 
            this.txtAge2.BackColor = System.Drawing.Color.White;
            this.txtAge2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAge2.Location = new System.Drawing.Point(185, 177);
            this.txtAge2.Name = "txtAge2";
            this.txtAge2.ReadOnly = true;
            this.txtAge2.Size = new System.Drawing.Size(61, 21);
            this.txtAge2.TabIndex = 0;
            // 
            // pictureBox86
            // 
            this.pictureBox86.BackColor = System.Drawing.Color.White;
            this.pictureBox86.Enabled = false;
            this.pictureBox86.Location = new System.Drawing.Point(183, 191);
            this.pictureBox86.Name = "pictureBox86";
            this.pictureBox86.Size = new System.Drawing.Size(66, 1);
            this.pictureBox86.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox86.TabIndex = 3259;
            this.pictureBox86.TabStop = false;
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.ForeColor = System.Drawing.Color.Teal;
            this.label130.Location = new System.Drawing.Point(256, 178);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(17, 12);
            this.label130.TabIndex = 3260;
            this.label130.Text = "月";
            // 
            // pictureBox87
            // 
            this.pictureBox87.Enabled = false;
            this.pictureBox87.Location = new System.Drawing.Point(109, 373);
            this.pictureBox87.Name = "pictureBox87";
            this.pictureBox87.Size = new System.Drawing.Size(41, 1);
            this.pictureBox87.TabIndex = 3261;
            this.pictureBox87.TabStop = false;
            // 
            // pictureBox88
            // 
            this.pictureBox88.Enabled = false;
            this.pictureBox88.Location = new System.Drawing.Point(196, 167);
            this.pictureBox88.Name = "pictureBox88";
            this.pictureBox88.Size = new System.Drawing.Size(41, 1);
            this.pictureBox88.TabIndex = 3262;
            this.pictureBox88.TabStop = false;
            // 
            // pictureBox89
            // 
            this.pictureBox89.Enabled = false;
            this.pictureBox89.Location = new System.Drawing.Point(491, 242);
            this.pictureBox89.Name = "pictureBox89";
            this.pictureBox89.Size = new System.Drawing.Size(41, 1);
            this.pictureBox89.TabIndex = 3263;
            this.pictureBox89.TabStop = false;
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label131.ForeColor = System.Drawing.Color.Teal;
            this.label131.Location = new System.Drawing.Point(42, 929);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(59, 13);
            this.label131.TabIndex = 3264;
            this.label131.Text = "主诊医师";
            // 
            // txtATTEMD_DOCTOR
            // 
            this.txtATTEMD_DOCTOR.Location = new System.Drawing.Point(99, 929);
            this.txtATTEMD_DOCTOR.Name = "txtATTEMD_DOCTOR";
            this.txtATTEMD_DOCTOR.ShortcutsEnabled = false;
            this.txtATTEMD_DOCTOR.Size = new System.Drawing.Size(80, 21);
            this.txtATTEMD_DOCTOR.TabIndex = 3122;
            this.txtATTEMD_DOCTOR.DoubleClick += new System.EventHandler(this.txtATTEMD_DOCTOR_DoubleClick);
            this.txtATTEMD_DOCTOR.Leave += new System.EventHandler(this.txtATTEMD_DOCTOR_Leave);
            this.txtATTEMD_DOCTOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtATTEMD_DOCTOR_KeyPress);
            this.txtATTEMD_DOCTOR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtATTEMD_DOCTOR_KeyDown);
            // 
            // label132
            // 
            this.label132.Enabled = false;
            this.label132.Location = new System.Drawing.Point(96, 925);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(86, 20);
            this.label132.TabIndex = 3265;
            // 
            // txtCurrent_Address_Detail
            // 
            this.txtCurrent_Address_Detail.BackColor = System.Drawing.Color.White;
            this.txtCurrent_Address_Detail.ForeColor = System.Drawing.Color.Gray;
            this.txtCurrent_Address_Detail.Location = new System.Drawing.Point(237, 249);
            this.txtCurrent_Address_Detail.Name = "txtCurrent_Address_Detail";
            this.txtCurrent_Address_Detail.Size = new System.Drawing.Size(213, 21);
            this.txtCurrent_Address_Detail.TabIndex = 3267;
            // 
            // txtRegistered_p_r_address_detail
            // 
            this.txtRegistered_p_r_address_detail.BackColor = System.Drawing.Color.White;
            this.txtRegistered_p_r_address_detail.ForeColor = System.Drawing.Color.Gray;
            this.txtRegistered_p_r_address_detail.Location = new System.Drawing.Point(271, 274);
            this.txtRegistered_p_r_address_detail.Name = "txtRegistered_p_r_address_detail";
            this.txtRegistered_p_r_address_detail.Size = new System.Drawing.Size(337, 21);
            this.txtRegistered_p_r_address_detail.TabIndex = 3268;
            // 
            // pictureBox90
            // 
            this.pictureBox90.BackColor = System.Drawing.Color.White;
            this.pictureBox90.Location = new System.Drawing.Point(36, 765);
            this.pictureBox90.Name = "pictureBox90";
            this.pictureBox90.Size = new System.Drawing.Size(730, 1);
            this.pictureBox90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox90.TabIndex = 3269;
            this.pictureBox90.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(37, 1316);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(730, 1);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 3270;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox91
            // 
            this.pictureBox91.Location = new System.Drawing.Point(36, 1524);
            this.pictureBox91.Name = "pictureBox91";
            this.pictureBox91.Size = new System.Drawing.Size(730, 1);
            this.pictureBox91.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox91.TabIndex = 3271;
            this.pictureBox91.TabStop = false;
            // 
            // gridControlGraveWard
            // 
            this.gridControlGraveWard.EmbeddedNavigator.Name = "";
            this.gridControlGraveWard.Location = new System.Drawing.Point(39, 1333);
            this.gridControlGraveWard.MainView = this.gridViewGraveWard;
            this.gridControlGraveWard.Name = "gridControlGraveWard";
            this.gridControlGraveWard.Size = new System.Drawing.Size(723, 117);
            this.gridControlGraveWard.TabIndex = 3272;
            this.gridControlGraveWard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGraveWard});
            // 
            // gridViewGraveWard
            // 
            this.gridViewGraveWard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewGraveWard.GridControl = this.gridControlGraveWard;
            this.gridViewGraveWard.Name = "gridViewGraveWard";
            this.gridViewGraveWard.OptionsBehavior.Editable = false;
            this.gridViewGraveWard.OptionsView.ColumnAutoWidth = false;
            this.gridViewGraveWard.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "重症监护室名称";
            this.gridColumn1.FieldName = "WARD_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 220;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "进重症监护室时间（_年_月_日_时_分）";
            this.gridColumn2.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "ENTER_TIME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 240;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "出重症监护室时间（_年_月_日_时_分）";
            this.gridColumn3.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "EXIT_TIME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 240;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.ForeColor = System.Drawing.Color.Teal;
            this.label133.Location = new System.Drawing.Point(45, 1457);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(101, 12);
            this.label133.TabIndex = 3273;
            this.label133.Text = "呼吸机使用时间：";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.ForeColor = System.Drawing.Color.Teal;
            this.label134.Location = new System.Drawing.Point(44, 1482);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(71, 12);
            this.label134.TabIndex = 3274;
            this.label134.Text = "肿瘤分期：T";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.ForeColor = System.Drawing.Color.Teal;
            this.label135.Location = new System.Drawing.Point(42, 1506);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(185, 12);
            this.label135.TabIndex = 3275;
            this.label135.Text = "日常生活能力评定量表得分：入院";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.ForeColor = System.Drawing.Color.Teal;
            this.label140.Location = new System.Drawing.Point(267, 1457);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(29, 12);
            this.label140.TabIndex = 3276;
            this.label140.Text = "小时";
            // 
            // pictureBox92
            // 
            this.pictureBox92.Location = new System.Drawing.Point(142, 1472);
            this.pictureBox92.Name = "pictureBox92";
            this.pictureBox92.Size = new System.Drawing.Size(120, 1);
            this.pictureBox92.TabIndex = 3278;
            this.pictureBox92.TabStop = false;
            // 
            // txtRESPIRATOR_USE_TIME
            // 
            this.txtRESPIRATOR_USE_TIME.BackColor = System.Drawing.Color.White;
            this.txtRESPIRATOR_USE_TIME.ForeColor = System.Drawing.Color.Black;
            this.txtRESPIRATOR_USE_TIME.Location = new System.Drawing.Point(144, 1455);
            this.txtRESPIRATOR_USE_TIME.Name = "txtRESPIRATOR_USE_TIME";
            this.txtRESPIRATOR_USE_TIME.Size = new System.Drawing.Size(120, 21);
            this.txtRESPIRATOR_USE_TIME.TabIndex = 3277;
            this.txtRESPIRATOR_USE_TIME.TabStop = false;
            this.txtRESPIRATOR_USE_TIME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLNSS_P_HOSPITAL_DAYS_KeyPress);
            // 
            // pictureBox93
            // 
            this.pictureBox93.Location = new System.Drawing.Point(411, 1520);
            this.pictureBox93.Name = "pictureBox93";
            this.pictureBox93.Size = new System.Drawing.Size(120, 1);
            this.pictureBox93.TabIndex = 3282;
            this.pictureBox93.TabStop = false;
            // 
            // pictureBox94
            // 
            this.pictureBox94.Location = new System.Drawing.Point(244, 1519);
            this.pictureBox94.Name = "pictureBox94";
            this.pictureBox94.Size = new System.Drawing.Size(120, 1);
            this.pictureBox94.TabIndex = 3283;
            this.pictureBox94.TabStop = false;
            // 
            // txtADL_DISCHARGE
            // 
            this.txtADL_DISCHARGE.BackColor = System.Drawing.Color.White;
            this.txtADL_DISCHARGE.ForeColor = System.Drawing.Color.Black;
            this.txtADL_DISCHARGE.Location = new System.Drawing.Point(412, 1505);
            this.txtADL_DISCHARGE.Name = "txtADL_DISCHARGE";
            this.txtADL_DISCHARGE.Size = new System.Drawing.Size(120, 21);
            this.txtADL_DISCHARGE.TabIndex = 3279;
            this.txtADL_DISCHARGE.TabStop = false;
            this.txtADL_DISCHARGE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtADL_ADMISSION_KeyPress);
            // 
            // txtADL_ADMISSION
            // 
            this.txtADL_ADMISSION.BackColor = System.Drawing.Color.White;
            this.txtADL_ADMISSION.ForeColor = System.Drawing.Color.Black;
            this.txtADL_ADMISSION.Location = new System.Drawing.Point(245, 1504);
            this.txtADL_ADMISSION.Name = "txtADL_ADMISSION";
            this.txtADL_ADMISSION.Size = new System.Drawing.Size(120, 21);
            this.txtADL_ADMISSION.TabIndex = 3280;
            this.txtADL_ADMISSION.TabStop = false;
            this.txtADL_ADMISSION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtADL_ADMISSION_KeyPress);
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.ForeColor = System.Drawing.Color.Teal;
            this.label141.Location = new System.Drawing.Point(378, 1506);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(29, 12);
            this.label141.TabIndex = 3281;
            this.label141.Text = "出院";
            // 
            // pictureBox95
            // 
            this.pictureBox95.Location = new System.Drawing.Point(116, 1497);
            this.pictureBox95.Name = "pictureBox95";
            this.pictureBox95.Size = new System.Drawing.Size(67, 1);
            this.pictureBox95.TabIndex = 3289;
            this.pictureBox95.TabStop = false;
            // 
            // pictureBox96
            // 
            this.pictureBox96.Location = new System.Drawing.Point(304, 1497);
            this.pictureBox96.Name = "pictureBox96";
            this.pictureBox96.Size = new System.Drawing.Size(70, 1);
            this.pictureBox96.TabIndex = 3290;
            this.pictureBox96.TabStop = false;
            // 
            // pictureBox97
            // 
            this.pictureBox97.Location = new System.Drawing.Point(207, 1497);
            this.pictureBox97.Name = "pictureBox97";
            this.pictureBox97.Size = new System.Drawing.Size(75, 1);
            this.pictureBox97.TabIndex = 3291;
            this.pictureBox97.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.ForeColor = System.Drawing.Color.Gray;
            this.textBox5.Location = new System.Drawing.Point(117, 1481);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 21);
            this.textBox5.TabIndex = 3284;
            this.textBox5.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.ForeColor = System.Drawing.Color.Gray;
            this.textBox6.Location = new System.Drawing.Point(305, 1481);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(70, 21);
            this.textBox6.TabIndex = 3285;
            this.textBox6.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.ForeColor = System.Drawing.Color.Gray;
            this.textBox7.Location = new System.Drawing.Point(207, 1481);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(75, 21);
            this.textBox7.TabIndex = 3286;
            this.textBox7.TabStop = false;
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.ForeColor = System.Drawing.Color.Teal;
            this.label142.Location = new System.Drawing.Point(288, 1482);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(11, 12);
            this.label142.TabIndex = 3288;
            this.label142.Text = "M";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.ForeColor = System.Drawing.Color.Teal;
            this.label143.Location = new System.Drawing.Point(190, 1482);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(11, 12);
            this.label143.TabIndex = 3287;
            this.label143.Text = "N";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.ForeColor = System.Drawing.Color.Teal;
            this.label144.Location = new System.Drawing.Point(397, 1482);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(173, 12);
            this.label144.TabIndex = 3292;
            this.label144.Text = "0期 Ⅰ期 Ⅱ期 Ⅲ期 Ⅳ期 不详";
            // 
            // txtTUMOR_STAGE_T
            // 
            this.txtTUMOR_STAGE_T.BackColor = System.Drawing.Color.White;
            this.txtTUMOR_STAGE_T.Location = new System.Drawing.Point(122, 1479);
            this.txtTUMOR_STAGE_T.Name = "txtTUMOR_STAGE_T";
            this.txtTUMOR_STAGE_T.ReadOnly = true;
            this.txtTUMOR_STAGE_T.Size = new System.Drawing.Size(42, 21);
            this.txtTUMOR_STAGE_T.TabIndex = 3294;
            this.txtTUMOR_STAGE_T.Tag = "－";
            this.txtTUMOR_STAGE_T.Text = "－";
            // 
            // comTUMOR_STAGE_T
            // 
            this.comTUMOR_STAGE_T.FormattingEnabled = true;
            this.comTUMOR_STAGE_T.Location = new System.Drawing.Point(119, 1476);
            this.comTUMOR_STAGE_T.Name = "comTUMOR_STAGE_T";
            this.comTUMOR_STAGE_T.Size = new System.Drawing.Size(62, 20);
            this.comTUMOR_STAGE_T.TabIndex = 3293;
            this.comTUMOR_STAGE_T.Tag = "0";
            this.comTUMOR_STAGE_T.Text = "-";
            this.comTUMOR_STAGE_T.SelectedIndexChanged += new System.EventHandler(this.comTUMOR_STAGE_T_SelectedIndexChanged);
            this.comTUMOR_STAGE_T.DropDownClosed += new System.EventHandler(this.comTUMOR_STAGE_T_DropDownClosed);
            this.comTUMOR_STAGE_T.DropDown += new System.EventHandler(this.comTUMOR_STAGE_T_DropDown);
            // 
            // txtTUMOR_STAGE_N
            // 
            this.txtTUMOR_STAGE_N.BackColor = System.Drawing.Color.White;
            this.txtTUMOR_STAGE_N.Location = new System.Drawing.Point(214, 1479);
            this.txtTUMOR_STAGE_N.Name = "txtTUMOR_STAGE_N";
            this.txtTUMOR_STAGE_N.ReadOnly = true;
            this.txtTUMOR_STAGE_N.Size = new System.Drawing.Size(42, 21);
            this.txtTUMOR_STAGE_N.TabIndex = 3296;
            this.txtTUMOR_STAGE_N.Tag = "－";
            this.txtTUMOR_STAGE_N.Text = "－";
            // 
            // comTUMOR_STAGE_N
            // 
            this.comTUMOR_STAGE_N.FormattingEnabled = true;
            this.comTUMOR_STAGE_N.Location = new System.Drawing.Point(211, 1476);
            this.comTUMOR_STAGE_N.Name = "comTUMOR_STAGE_N";
            this.comTUMOR_STAGE_N.Size = new System.Drawing.Size(62, 20);
            this.comTUMOR_STAGE_N.TabIndex = 3295;
            this.comTUMOR_STAGE_N.Tag = "0";
            this.comTUMOR_STAGE_N.Text = "-";
            this.comTUMOR_STAGE_N.SelectedIndexChanged += new System.EventHandler(this.comTUMOR_STAGE_N_SelectedIndexChanged);
            this.comTUMOR_STAGE_N.DropDownClosed += new System.EventHandler(this.comTUMOR_STAGE_N_DropDownClosed);
            this.comTUMOR_STAGE_N.DropDown += new System.EventHandler(this.comTUMOR_STAGE_N_DropDown);
            // 
            // txtTUMOR_STAGE_M
            // 
            this.txtTUMOR_STAGE_M.BackColor = System.Drawing.Color.White;
            this.txtTUMOR_STAGE_M.Location = new System.Drawing.Point(312, 1479);
            this.txtTUMOR_STAGE_M.Name = "txtTUMOR_STAGE_M";
            this.txtTUMOR_STAGE_M.ReadOnly = true;
            this.txtTUMOR_STAGE_M.Size = new System.Drawing.Size(42, 21);
            this.txtTUMOR_STAGE_M.TabIndex = 3298;
            this.txtTUMOR_STAGE_M.Tag = "－";
            this.txtTUMOR_STAGE_M.Text = "－";
            // 
            // comTUMOR_STAGE_M
            // 
            this.comTUMOR_STAGE_M.FormattingEnabled = true;
            this.comTUMOR_STAGE_M.Location = new System.Drawing.Point(309, 1476);
            this.comTUMOR_STAGE_M.Name = "comTUMOR_STAGE_M";
            this.comTUMOR_STAGE_M.Size = new System.Drawing.Size(62, 20);
            this.comTUMOR_STAGE_M.TabIndex = 3297;
            this.comTUMOR_STAGE_M.Tag = "0";
            this.comTUMOR_STAGE_M.Text = "-";
            this.comTUMOR_STAGE_M.SelectedIndexChanged += new System.EventHandler(this.comTUMOR_STAGE_M_SelectedIndexChanged);
            this.comTUMOR_STAGE_M.DropDownClosed += new System.EventHandler(this.comTUMOR_STAGE_M_DropDownClosed);
            this.comTUMOR_STAGE_M.DropDown += new System.EventHandler(this.comTUMOR_STAGE_M_DropDown);
            // 
            // txtFOLLOW_DATETIME
            // 
            this.txtFOLLOW_DATETIME.BackColor = System.Drawing.Color.White;
            this.txtFOLLOW_DATETIME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFOLLOW_DATETIME.Location = new System.Drawing.Point(124, 825);
            this.txtFOLLOW_DATETIME.Name = "txtFOLLOW_DATETIME";
            this.txtFOLLOW_DATETIME.ReadOnly = true;
            this.txtFOLLOW_DATETIME.Size = new System.Drawing.Size(100, 21);
            this.txtFOLLOW_DATETIME.TabIndex = 3315;
            this.txtFOLLOW_DATETIME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFOLLOW_DATETIME.DoubleClick += new System.EventHandler(this.txtFOLLOW_DATETIME_DoubleClick);
            this.txtFOLLOW_DATETIME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFOLLOW_DATETIME_KeyDown);
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.ForeColor = System.Drawing.Color.Teal;
            this.label145.Location = new System.Drawing.Point(51, 828);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(65, 12);
            this.label145.TabIndex = 3314;
            this.label145.Text = "随诊时间：";
            // 
            // txtFOLLOW_INTERVAL_UNITS
            // 
            this.txtFOLLOW_INTERVAL_UNITS.BackColor = System.Drawing.Color.White;
            this.txtFOLLOW_INTERVAL_UNITS.Location = new System.Drawing.Point(432, 826);
            this.txtFOLLOW_INTERVAL_UNITS.Name = "txtFOLLOW_INTERVAL_UNITS";
            this.txtFOLLOW_INTERVAL_UNITS.ReadOnly = true;
            this.txtFOLLOW_INTERVAL_UNITS.Size = new System.Drawing.Size(23, 21);
            this.txtFOLLOW_INTERVAL_UNITS.TabIndex = 3301;
            this.txtFOLLOW_INTERVAL_UNITS.Tag = "";
            this.txtFOLLOW_INTERVAL_UNITS.Text = "月";
            this.txtFOLLOW_INTERVAL_UNITS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFOLLOW_INTERVAL_UNITS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFOLLOW_INTERVAL_UNITS_KeyDown);
            // 
            // txtFOLLOW_INDICATOR
            // 
            this.txtFOLLOW_INDICATOR.BackColor = System.Drawing.Color.White;
            this.txtFOLLOW_INDICATOR.Location = new System.Drawing.Point(91, 803);
            this.txtFOLLOW_INDICATOR.Name = "txtFOLLOW_INDICATOR";
            this.txtFOLLOW_INDICATOR.ReadOnly = true;
            this.txtFOLLOW_INDICATOR.Size = new System.Drawing.Size(16, 21);
            this.txtFOLLOW_INDICATOR.TabIndex = 3299;
            this.txtFOLLOW_INDICATOR.Tag = "－";
            this.txtFOLLOW_INDICATOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFOLLOW_INDICATOR.DoubleClick += new System.EventHandler(this.txtFOLLOW_INDICATOR_DoubleClick);
            this.txtFOLLOW_INDICATOR.Leave += new System.EventHandler(this.txtFOLLOW_INDICATOR_Leave);
            this.txtFOLLOW_INDICATOR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFOLLOW_INDICATOR_KeyDown);
            // 
            // comFOLLOW_INTERVAL_UNITS
            // 
            this.comFOLLOW_INTERVAL_UNITS.FormattingEnabled = true;
            this.comFOLLOW_INTERVAL_UNITS.Location = new System.Drawing.Point(430, 823);
            this.comFOLLOW_INTERVAL_UNITS.Name = "comFOLLOW_INTERVAL_UNITS";
            this.comFOLLOW_INTERVAL_UNITS.Size = new System.Drawing.Size(43, 20);
            this.comFOLLOW_INTERVAL_UNITS.TabIndex = 3311;
            this.comFOLLOW_INTERVAL_UNITS.Tag = "-";
            this.comFOLLOW_INTERVAL_UNITS.Text = "-";
            this.comFOLLOW_INTERVAL_UNITS.SelectedIndexChanged += new System.EventHandler(this.comFOLLOW_INTERVAL_UNITS_SelectedIndexChanged);
            this.comFOLLOW_INTERVAL_UNITS.DropDownClosed += new System.EventHandler(this.comFOLLOW_INTERVAL_UNITS_DropDownClosed);
            this.comFOLLOW_INTERVAL_UNITS.DropDown += new System.EventHandler(this.comFOLLOW_INTERVAL_UNITS_DropDown);
            // 
            // comFOLLOW_INDICATOR
            // 
            this.comFOLLOW_INDICATOR.FormattingEnabled = true;
            this.comFOLLOW_INDICATOR.Location = new System.Drawing.Point(89, 800);
            this.comFOLLOW_INDICATOR.Name = "comFOLLOW_INDICATOR";
            this.comFOLLOW_INDICATOR.Size = new System.Drawing.Size(37, 20);
            this.comFOLLOW_INDICATOR.TabIndex = 3313;
            this.comFOLLOW_INDICATOR.Tag = "-";
            this.comFOLLOW_INDICATOR.Text = "-";
            this.comFOLLOW_INDICATOR.SelectedIndexChanged += new System.EventHandler(this.comFOLLOW_INDICATOR_SelectedIndexChanged);
            this.comFOLLOW_INDICATOR.DropDownClosed += new System.EventHandler(this.comFOLLOW_INDICATOR_DropDownClosed);
            this.comFOLLOW_INDICATOR.DropDown += new System.EventHandler(this.comFOLLOW_INDICATOR_DropDown);
            // 
            // txtFOLLOW_INTERVAL
            // 
            this.txtFOLLOW_INTERVAL.Location = new System.Drawing.Point(401, 827);
            this.txtFOLLOW_INTERVAL.MaxLength = 2;
            this.txtFOLLOW_INTERVAL.Name = "txtFOLLOW_INTERVAL";
            this.txtFOLLOW_INTERVAL.Size = new System.Drawing.Size(31, 21);
            this.txtFOLLOW_INTERVAL.TabIndex = 3300;
            this.txtFOLLOW_INTERVAL.Text = "0";
            this.txtFOLLOW_INTERVAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFOLLOW_INTERVAL_KeyPress);
            this.txtFOLLOW_INTERVAL.TextChanged += new System.EventHandler(this.txtFOLLOW_INTERVAL_TextChanged);
            this.txtFOLLOW_INTERVAL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFOLLOW_INTERVAL_KeyDown);
            // 
            // pictureBox98
            // 
            this.pictureBox98.Location = new System.Drawing.Point(37, 849);
            this.pictureBox98.Name = "pictureBox98";
            this.pictureBox98.Size = new System.Drawing.Size(730, 1);
            this.pictureBox98.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox98.TabIndex = 3308;
            this.pictureBox98.TabStop = false;
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.ForeColor = System.Drawing.Color.Teal;
            this.label147.Location = new System.Drawing.Point(338, 827);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(65, 12);
            this.label147.TabIndex = 3303;
            this.label147.Text = "随诊期限：";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.ForeColor = System.Drawing.Color.Teal;
            this.label149.Location = new System.Drawing.Point(146, 804);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(89, 12);
            this.label149.TabIndex = 3306;
            this.label149.Text = "1. 是    2. 否";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.ForeColor = System.Drawing.Color.Teal;
            this.label150.Location = new System.Drawing.Point(51, 804);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(41, 12);
            this.label150.TabIndex = 3307;
            this.label150.Text = "随诊：";
            // 
            // txtFOLLOW_WAY
            // 
            this.txtFOLLOW_WAY.BackColor = System.Drawing.Color.White;
            this.txtFOLLOW_WAY.Location = new System.Drawing.Point(339, 803);
            this.txtFOLLOW_WAY.Name = "txtFOLLOW_WAY";
            this.txtFOLLOW_WAY.ReadOnly = true;
            this.txtFOLLOW_WAY.Size = new System.Drawing.Size(48, 21);
            this.txtFOLLOW_WAY.TabIndex = 3316;
            this.txtFOLLOW_WAY.Tag = "－";
            this.txtFOLLOW_WAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFOLLOW_WAY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFOLLOW_WAY_KeyDown);
            // 
            // comFOLLOW_WAY
            // 
            this.comFOLLOW_WAY.FormattingEnabled = true;
            this.comFOLLOW_WAY.Items.AddRange(new object[] {
            "-",
            "门诊复诊",
            "电话、短信",
            "书信(Email)",
            "其他"});
            this.comFOLLOW_WAY.Location = new System.Drawing.Point(337, 801);
            this.comFOLLOW_WAY.Name = "comFOLLOW_WAY";
            this.comFOLLOW_WAY.Size = new System.Drawing.Size(68, 20);
            this.comFOLLOW_WAY.TabIndex = 3319;
            this.comFOLLOW_WAY.Tag = "-";
            this.comFOLLOW_WAY.Text = "-";
            this.comFOLLOW_WAY.SelectedIndexChanged += new System.EventHandler(this.comFOLLOW_WAY_SelectedIndexChanged);
            this.comFOLLOW_WAY.DropDownClosed += new System.EventHandler(this.comFOLLOW_WAY_DropDownClosed);
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.ForeColor = System.Drawing.Color.Teal;
            this.label146.Location = new System.Drawing.Point(411, 805);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(329, 12);
            this.label146.TabIndex = 3317;
            this.label146.Text = "1. 门诊复诊   2. 电话、短信   3. 书信(Email)   4. 其他";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.ForeColor = System.Drawing.Color.Teal;
            this.label148.Location = new System.Drawing.Point(269, 805);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(65, 12);
            this.label148.TabIndex = 3318;
            this.label148.Text = "随诊方式：";
            // 
            // comNOON
            // 
            this.comNOON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comNOON.FormattingEnabled = true;
            this.comNOON.Items.AddRange(new object[] {
            "上午",
            "下午"});
            this.comNOON.Location = new System.Drawing.Point(260, 823);
            this.comNOON.Name = "comNOON";
            this.comNOON.Size = new System.Drawing.Size(50, 20);
            this.comNOON.TabIndex = 3320;
            this.comNOON.Tag = "-";
            this.comNOON.SelectedIndexChanged += new System.EventHandler(this.comNOON_SelectedIndexChanged);
            // 
            // pictureBox99
            // 
            this.pictureBox99.Location = new System.Drawing.Point(112, 840);
            this.pictureBox99.Name = "pictureBox99";
            this.pictureBox99.Size = new System.Drawing.Size(130, 1);
            this.pictureBox99.TabIndex = 3321;
            this.pictureBox99.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 3322;
            this.button2.Text = "附页";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(47, 434);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(65, 12);
            this.label151.TabIndex = 3323;
            this.label151.Text = "出院情况：";
            // 
            // txtDISCHARGE_CONDITIONS
            // 
            this.txtDISCHARGE_CONDITIONS.Location = new System.Drawing.Point(117, 432);
            this.txtDISCHARGE_CONDITIONS.Name = "txtDISCHARGE_CONDITIONS";
            this.txtDISCHARGE_CONDITIONS.Size = new System.Drawing.Size(16, 21);
            this.txtDISCHARGE_CONDITIONS.TabIndex = 3324;
            this.txtDISCHARGE_CONDITIONS.Tag = "-";
            this.txtDISCHARGE_CONDITIONS.Text = "-";
            // 
            // comDISCHARGE_CONDITIONS
            // 
            this.comDISCHARGE_CONDITIONS.FormattingEnabled = true;
            this.comDISCHARGE_CONDITIONS.Location = new System.Drawing.Point(112, 429);
            this.comDISCHARGE_CONDITIONS.Name = "comDISCHARGE_CONDITIONS";
            this.comDISCHARGE_CONDITIONS.Size = new System.Drawing.Size(43, 20);
            this.comDISCHARGE_CONDITIONS.TabIndex = 3325;
            this.comDISCHARGE_CONDITIONS.SelectedIndexChanged += new System.EventHandler(this.comDISCHARGE_CONDITIONS_SelectedIndexChanged);
            this.comDISCHARGE_CONDITIONS.DropDownClosed += new System.EventHandler(this.comDISCHARGE_CONDITIONS_DropDownClosed);
            this.comDISCHARGE_CONDITIONS.DropDown += new System.EventHandler(this.comDISCHARGE_CONDITIONS_DropDown);
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(176, 435);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(287, 12);
            this.label152.TabIndex = 3326;
            this.label152.Text = "1、好转   2、未愈   3、治愈   4、死亡   5、其他";
            // 
            // UCMRFirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtATTEMD_DOCTOR);
            this.Controls.Add(this.label152);
            this.Controls.Add(this.txtDISCHARGE_CONDITIONS);
            this.Controls.Add(this.label151);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox99);
            this.Controls.Add(this.comNOON);
            this.Controls.Add(this.txtFOLLOW_WAY);
            this.Controls.Add(this.comFOLLOW_WAY);
            this.Controls.Add(this.label146);
            this.Controls.Add(this.label148);
            this.Controls.Add(this.txtFOLLOW_DATETIME);
            this.Controls.Add(this.label145);
            this.Controls.Add(this.txtFOLLOW_INTERVAL_UNITS);
            this.Controls.Add(this.txtFOLLOW_INDICATOR);
            this.Controls.Add(this.comFOLLOW_INTERVAL_UNITS);
            this.Controls.Add(this.comFOLLOW_INDICATOR);
            this.Controls.Add(this.txtFOLLOW_INTERVAL);
            this.Controls.Add(this.pictureBox98);
            this.Controls.Add(this.label147);
            this.Controls.Add(this.label149);
            this.Controls.Add(this.label150);
            this.Controls.Add(this.txtTUMOR_STAGE_M);
            this.Controls.Add(this.comTUMOR_STAGE_M);
            this.Controls.Add(this.txtTUMOR_STAGE_N);
            this.Controls.Add(this.comTUMOR_STAGE_N);
            this.Controls.Add(this.txtTUMOR_STAGE_T);
            this.Controls.Add(this.comTUMOR_STAGE_T);
            this.Controls.Add(this.label144);
            this.Controls.Add(this.pictureBox95);
            this.Controls.Add(this.pictureBox96);
            this.Controls.Add(this.pictureBox97);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label142);
            this.Controls.Add(this.label143);
            this.Controls.Add(this.pictureBox93);
            this.Controls.Add(this.pictureBox94);
            this.Controls.Add(this.txtADL_DISCHARGE);
            this.Controls.Add(this.txtADL_ADMISSION);
            this.Controls.Add(this.label141);
            this.Controls.Add(this.pictureBox92);
            this.Controls.Add(this.txtRESPIRATOR_USE_TIME);
            this.Controls.Add(this.label140);
            this.Controls.Add(this.label135);
            this.Controls.Add(this.label134);
            this.Controls.Add(this.label133);
            this.Controls.Add(this.gridControlGraveWard);
            this.Controls.Add(this.pictureBox91);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox90);
            this.Controls.Add(this.txtRegistered_p_r_address_detail);
            this.Controls.Add(this.txtCurrent_Address_Detail);
            this.Controls.Add(this.txtRUYUAN_PASS);
            this.Controls.Add(this.label132);
            this.Controls.Add(this.label131);
            this.Controls.Add(this.pictureBox89);
            this.Controls.Add(this.pictureBox88);
            this.Controls.Add(this.pictureBox87);
            this.Controls.Add(this.label130);
            this.Controls.Add(this.txtAge2);
            this.Controls.Add(this.pictureBox86);
            this.Controls.Add(this.label129);
            this.Controls.Add(this.label128);
            this.Controls.Add(this.pictureBox85);
            this.Controls.Add(this.pictureBox82);
            this.Controls.Add(this.pictureBox84);
            this.Controls.Add(this.pictureBox81);
            this.Controls.Add(this.pictureBox83);
            this.Controls.Add(this.pictureBox80);
            this.Controls.Add(this.txtLNSS_A_HOSPITAL_MIN);
            this.Controls.Add(this.txtLNSS_P_HOSPITAL_MIN);
            this.Controls.Add(this.txtLNSS_A_HOSPITAL_HOURS);
            this.Controls.Add(this.txtLNSS_P_HOSPITAL_HOURS);
            this.Controls.Add(this.txtLNSS_A_HOSPITAL_DAYS);
            this.Controls.Add(this.txtLNSS_P_HOSPITAL_DAYS);
            this.Controls.Add(this.label127);
            this.Controls.Add(this.label125);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.label124);
            this.Controls.Add(this.label122);
            this.Controls.Add(this.label119);
            this.Controls.Add(this.label120);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox55);
            this.Controls.Add(this.pictureBox58);
            this.Controls.Add(this.pictureBox41);
            this.Controls.Add(this.pictureBox60);
            this.Controls.Add(this.pictureBox59);
            this.Controls.Add(this.pictureBox66);
            this.Controls.Add(this.pictureBox79);
            this.Controls.Add(this.pictureBox78);
            this.Controls.Add(this.pictureBox77);
            this.Controls.Add(this.pictureBox75);
            this.Controls.Add(this.pictureBox76);
            this.Controls.Add(this.pictureBox74);
            this.Controls.Add(this.pictureBox73);
            this.Controls.Add(this.pictureBox72);
            this.Controls.Add(this.pictureBox70);
            this.Controls.Add(this.pictureBox71);
            this.Controls.Add(this.pictureBox68);
            this.Controls.Add(this.pictureBox69);
            this.Controls.Add(this.pictureBox67);
            this.Controls.Add(this.pictureBox65);
            this.Controls.Add(this.pictureBox62);
            this.Controls.Add(this.pictureBox57);
            this.Controls.Add(this.pictureBox64);
            this.Controls.Add(this.pictureBox63);
            this.Controls.Add(this.pictureBox61);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox56);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.txtZYMD);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtZRYJH);
            this.Controls.Add(this.comZRYJH);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtZYJG);
            this.Controls.Add(this.txtZYMC);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtDISCHARGE_PASS);
            this.Controls.Add(this.comDISCHARGE_PASS);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox54);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.txtYWGM);
            this.Controls.Add(this.comYWGM);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBLH);
            this.Controls.Add(this.pictureBox53);
            this.Controls.Add(this.label121);
            this.Controls.Add(this.txtdiagnosis_code28);
            this.Controls.Add(this.pictureBox52);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.textdiagnosis_desc28);
            this.Controls.Add(this.pictureBox51);
            this.Controls.Add(this.label110);
            this.Controls.Add(this.label108);
            this.Controls.Add(this.comRUYUAN_PASS);
            this.Controls.Add(this.label107);
            this.Controls.Add(this.txtCurrent_Address_Zip_Code);
            this.Controls.Add(this.pictureBox50);
            this.Controls.Add(this.label106);
            this.Controls.Add(this.txtCurrent_Address_PHOTO);
            this.Controls.Add(this.pictureBox49);
            this.Controls.Add(this.label105);
            this.Controls.Add(this.txtCurrent_Address);
            this.Controls.Add(this.pictureBox48);
            this.Controls.Add(this.label104);
            this.Controls.Add(this.txtJIGUAN);
            this.Controls.Add(this.pictureBox45);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.txtBABY_R_WEIGHT);
            this.Controls.Add(this.txtBABY_WEIGHT);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.pictureBox42);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.label98);
            this.Controls.Add(this.label97);
            this.Controls.Add(this.txtBABYAGE);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.label96);
            this.Controls.Add(this.label92);
            this.Controls.Add(this.txtPRACTICE_DOCTOR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label117);
            this.Controls.Add(this.txtLIABILITY_NURSE_ID);
            this.Controls.Add(this.label115);
            this.Controls.Add(this.label114);
            this.Controls.Add(this.label113);
            this.Controls.Add(this.txtADVANCED_STUDIES_DOCTOR);
            this.Controls.Add(this.label112);
            this.Controls.Add(this.pictureBox47);
            this.Controls.Add(this.label88);
            this.Controls.Add(this.txtward_admission_to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOperation);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtFee5);
            this.Controls.Add(this.txtHy);
            this.Controls.Add(this.txtJs);
            this.Controls.Add(this.txtJc);
            this.Controls.Add(this.txtZcny);
            this.Controls.Add(this.txtFee3);
            this.Controls.Add(this.txtFee2);
            this.Controls.Add(this.txtFee11);
            this.Controls.Add(this.txtFee10);
            this.Controls.Add(this.txtFee9);
            this.Controls.Add(this.txtSy);
            this.Controls.Add(this.txtFee8);
            this.Controls.Add(this.txtFee7);
            this.Controls.Add(this.txtPc);
            this.Controls.Add(this.txtYe);
            this.Controls.Add(this.txtMz);
            this.Controls.Add(this.txtFee1);
            this.Controls.Add(this.txtCOST_OWNPAY);
            this.Controls.Add(this.txtCOST_ZH_OTHER);
            this.Controls.Add(this.txtCOST_ZH_YBZL);
            this.Controls.Add(this.txtCOST_ZH_HL);
            this.Controls.Add(this.txtCOST_ZL_FSSZLXM);
            this.Controls.Add(this.txtCOST_ZD_LCXM);
            this.Controls.Add(this.txtCOST_ZY_ZYZL);
            this.Controls.Add(this.txtCOST_OTHER);
            this.Controls.Add(this.txtCOST_HC_SS);
            this.Controls.Add(this.txtCOST_HC_ZL);
            this.Controls.Add(this.txtCOST_XY_XBYZ);
            this.Controls.Add(this.txtCOST_HC_JC);
            this.Controls.Add(this.txtCOST_XY_NXYZ);
            this.Controls.Add(this.txtCOST_XY_QDB);
            this.Controls.Add(this.txtCOST_XY_BDB);
            this.Controls.Add(this.txtCOST_ZY_ZCAOY);
            this.Controls.Add(this.txtCOST_XY_XF);
            this.Controls.Add(this.txtCOST_ZY_ZCHY);
            this.Controls.Add(this.txtCOST_XY_KJYW);
            this.Controls.Add(this.txtCOST_XY_XY);
            this.Controls.Add(this.txtCOST_KF_KF);
            this.Controls.Add(this.txtCOST_ZL_SSZL);
            this.Controls.Add(this.txtCOST_ZD_YXX);
            this.Controls.Add(this.txtCOST_ZL_SS);
            this.Controls.Add(this.txtCOST_ZL_MZ);
            this.Controls.Add(this.txtCOST_ZL_LCWLZL);
            this.Controls.Add(this.txtCOST_ZD_SYS);
            this.Controls.Add(this.txtCOST_ZD_BL);
            this.Controls.Add(this.txtCOST_ZH_YBYL);
            this.Controls.Add(this.txtCOST_TOTAL);
            this.Controls.Add(this.txtTOTAL_PAYMENTS);
            this.Controls.Add(this.label167);
            this.Controls.Add(this.label165);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label163);
            this.Controls.Add(this.label161);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label136);
            this.Controls.Add(this.label137);
            this.Controls.Add(this.label159);
            this.Controls.Add(this.label139);
            this.Controls.Add(this.label138);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label116);
            this.Controls.Add(this.label109);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label94);
            this.Controls.Add(this.label95);
            this.Controls.Add(this.label93);
            this.Controls.Add(this.label91);
            this.Controls.Add(this.label89);
            this.Controls.Add(this.label86);
            this.Controls.Add(this.label87);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.label85);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label80);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvDiagnose);
            this.Controls.Add(this.txtMARITAL_STATUS);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtdischarge_disposition);
            this.Controls.Add(this.txtMedical_pay_way);
            this.Controls.Add(this.txtBLOOD_TYPE_RH);
            this.Controls.Add(this.txtBLOOD_TYPE);
            this.Controls.Add(this.txtAUTOPSY_INDICATOR);
            this.Controls.Add(this.txtMR_QUALITY);
            this.Controls.Add(this.comBLOOD_TYPE_RH);
            this.Controls.Add(this.comBLOOD_TYPE);
            this.Controls.Add(this.comAUTOPSY_INDICATOR);
            this.Controls.Add(this.comMR_QUALITY);
            this.Controls.Add(this.comMARITAL_STATUS);
            this.Controls.Add(this.comMedical_pay_way);
            this.Controls.Add(this.comSex);
            this.Controls.Add(this.lbItemSel);
            this.Controls.Add(this.txtDOCTOR_IN_CHARGE);
            this.Controls.Add(this.txtATTENDING_DOCTOR);
            this.Controls.Add(this.txtCHIEF_DOCTOR);
            this.Controls.Add(this.txtDIRECTOR);
            this.Controls.Add(this.label185);
            this.Controls.Add(this.label187);
            this.Controls.Add(this.label186);
            this.Controls.Add(this.label184);
            this.Controls.Add(this.btnMrDiagnose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox46);
            this.Controls.Add(this.btnAddCustomOper);
            this.Controls.Add(this.btnAddCustomDiag);
            this.Controls.Add(this.btnCustomOper);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnOperDel);
            this.Controls.Add(this.btnOperInsert);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label84);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtDATE_OF_CONTROL_QUALITY);
            this.Controls.Add(this.txtNURSE_OF_CONTROL_QUALITY);
            this.Controls.Add(this.txtDOCTOR_OF_CONTROL_QUALITY);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.txtCATALOGER);
            this.Controls.Add(this.txtInhospitaldays);
            this.Controls.Add(this.txtALERGY_DRUGS);
            this.Controls.Add(this.txtward_discharge_from);
            this.Controls.Add(this.txtDEPT_DISCHARGE_FROM);
            this.Controls.Add(this.txtDISCHARGE_DATE_TIME);
            this.Controls.Add(this.txtdept_transfer);
            this.Controls.Add(this.txtDEPT_ADMISSION_TO);
            this.Controls.Add(this.txtADMISSION_DATE_TIME);
            this.Controls.Add(this.txtRELATIONSHIP);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.txtNEXT_OF_KIN_PHONE);
            this.Controls.Add(this.txtNEXT_OF_KIN_ADDR);
            this.Controls.Add(this.txtNEXT_OF_KIN);
            this.Controls.Add(this.txtRegistered_p_r_address_zip);
            this.Controls.Add(this.txtRegistered_p_r_address);
            this.Controls.Add(this.txtZIP_CODE);
            this.Controls.Add(this.txtPHONE_NUMBER_BUSINESS);
            this.Controls.Add(this.txtSERVICE_AGENCY);
            this.Controls.Add(this.txtID_NO);
            this.Controls.Add(this.txtCITIZENSHIP);
            this.Controls.Add(this.txtNATION);
            this.Controls.Add(this.txtBIRTH_PLACE);
            this.Controls.Add(this.txtOCCUPATION);
            this.Controls.Add(this.txtDate_of_birth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInp_no);
            this.Controls.Add(this.txtVisit_id);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.label118);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox37);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox44);
            this.Controls.Add(this.pictureBox43);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label168);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.label160);
            this.Controls.Add(this.label158);
            this.Controls.Add(this.label156);
            this.Controls.Add(this.label154);
            this.Controls.Add(this.label126);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHospitalName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdBLOOD_TYPE);
            this.Controls.Add(this.comDISCHARGE_CONDITIONS);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "UCMRFirstPage";
            this.Size = new System.Drawing.Size(808, 2040);
            this.Load += new System.EventHandler(this.UCMRFirstPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGraveWard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGraveWard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label txtHospitalName;
        private Label label1;
        private PictureBox pictureBox5;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label11;
        private Label label7;
        private Label label81;
        private Label label79;
        private Label label77;
        private Label label68;
        private Label label66;
        private Label label53;
        private Label label43;
        private Label label39;
        private Label label37;
        private Label label35;
        private Label label28;
        private Label label15;
        private Label label29;
        private Label label26;
        private Label label24;
        private Label label17;
        private Label label12;
        private Label label14;
        private Label label33;
        private Label label45;
        private Label label51;
        private Label label62;
        private Label label31;
        private Label label41;
        private Label label49;
        private CCEMRDataGridView dgvDiagnose;
        private Label label23;
        private Label label13;
        private Label label10;
        private Label label168;
        private Label label166;
        private Label label164;
        private Label label162;
        private Label label160;
        private Label label158;
        private Label label156;
        private Label label154;
        private Label label126;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label label57;
        private Label label56;
        private Label label20;
        private Label label46;
        private Label label61;
        private Label label63;
        private Label label69;
        private Label label70;
        private PictureBox pictureBox12;
        private TextBox txtVisit_id;
        private TextBox txtInp_no;
        private TextBox txtName;
        private TextBox txtSex;
        private MaskedTextBox txtDate_of_birth;
        private TextBox txtMARITAL_STATUS;
        private TextBox txtOCCUPATION;
        private TextBox txtBIRTH_PLACE;
        private TextBox txtNATION;
        private TextBox txtCITIZENSHIP;
        private TextBox txtID_NO;
        private TextBox txtSERVICE_AGENCY;
        private TextBox txtPHONE_NUMBER_BUSINESS;
        private TextBox txtZIP_CODE;
        private TextBox txtRegistered_p_r_address;
        private TextBox txtRegistered_p_r_address_zip;
        private TextBox txtNEXT_OF_KIN;
        private TextBox txtNEXT_OF_KIN_ADDR;
        private TextBox txtNEXT_OF_KIN_PHONE;
        private Label label78;
        private TextBox txtRELATIONSHIP;
        private TextBox txtADMISSION_DATE_TIME;
        private TextBox txtDEPT_ADMISSION_TO;
        private TextBox txtdept_transfer;
        private TextBox txtDISCHARGE_DATE_TIME;
        private TextBox txtDEPT_DISCHARGE_FROM;
        private TextBox txtward_discharge_from;
        private TextBox txtInhospitaldays;
        private TextBox txtALERGY_DRUGS;
        private TextBox txtDIRECTOR;
        private TextBox txtCHIEF_DOCTOR;
        private TextBox txtATTENDING_DOCTOR;
        private TextBox txtDOCTOR_IN_CHARGE;
        private TextBox txtCATALOGER;
        private TextBox txtDOCTOR_OF_CONTROL_QUALITY;
        private TextBox txtNURSE_OF_CONTROL_QUALITY;
        private TextBox txtDATE_OF_CONTROL_QUALITY;
        private TextBox txtMedical_pay_way;
        private PictureBox pictureBox16;
        private TextBox txtAge;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox37;
        private PictureBox pictureBox38;
        private PictureBox pictureBox39;
        private PictureBox pictureBox40;
        private Label label84;
        private PictureBox pictureBox43;
        private PictureBox pictureBox44;
        private PictureBox pictureBox21;
        private TextBox textBox9;
        private TextBox txtBLOOD_TYPE;
        private TextBox txtBLOOD_TYPE_RH;
        private Button btnInsert;
        private Button btnDel;
        private Button btnOperDel;
        private Button btnOperInsert;
        private ListBox lbItemSel;
        private Button btnCustom;
        private Button btnCustomOper;
        private Button btnAddCustomDiag;
        private Button btnAddCustomOper;
        private PictureBox pictureBox46;
        private Label label90;
        private TextBox txtdischarge_disposition;
        private Button btnMrDiagnose;
        private Label label184;
        private Label label185;
        private Label label186;
        private Label label187;
        private Label label188;
        private Label label189;
        private Label label190;
        private ComboBox comMR_QUALITY;
        private TextBox txtMR_QUALITY;
        private ComboBox comAUTOPSY_INDICATOR;
        private TextBox txtAUTOPSY_INDICATOR;
        private ComboBox comBLOOD_TYPE;
        private ComboBox comBLOOD_TYPE_RH;
        private ComboBox comSex;
        private ComboBox comMARITAL_STATUS;
        private ComboBox comMedical_pay_way;
        private Button btnUpdate;
        private Label label16;
        private TextBox txtbch;
        private Panel panel1;
        private TextBox txtFee5;
        private TextBox txtHy;
        private TextBox txtJs;
        private TextBox txtJc;
        private TextBox txtZcny;
        private TextBox txtFee3;
        private TextBox txtFee2;
        private TextBox txtFee11;
        private TextBox txtFee10;
        private TextBox txtFee9;
        private TextBox txtSy;
        private TextBox txtFee8;
        private TextBox txtFee7;
        private TextBox txtPc;
        private TextBox txtYe;
        private TextBox txtMz;
        private TextBox txtFee1;
        private TextBox txtTOTAL_PAYMENTS;
        private Label label167;
        private Label label165;
        private Label label71;
        private Label label163;
        private Label label161;
        private Label label72;
        private Label label136;
        private Label label137;
        private Label label159;
        private Label label139;
        private Label label138;
        private Label label73;
        private Label label74;
        private Label label75;
        private Label label76;
        private Label label80;
        private Label label82;
        private Label label83;
        private PictureBox pictureBox2;
        private CCEMRDataGridView dgvOperation;
        private Button button1;
        private TextBox txt;
        private PictureBox pictureBox36;
        private Label label3;
        private TextBox txtward_admission_to;
        private Label label88;
        private PictureBox pictureBox47;
        private Label label112;
        private TextBox txtADVANCED_STUDIES_DOCTOR;
        private Label label113;
        private Label label114;
        private Label label115;
        private TextBox txtLIABILITY_NURSE_ID;
        private Label label117;
        private Label label5;
        private TextBox txtPRACTICE_DOCTOR;
        private Label label92;
        private Label label96;
        private PictureBox pictureBox24;
        private TextBox txtBABYAGE;
        private Label label97;
        private Label label98;
        private PictureBox pictureBox27;
        private Label label99;
        private Label label101;
        private PictureBox pictureBox42;
        private Label label102;
        private TextBox txtBABY_WEIGHT;
        private TextBox txtBABY_R_WEIGHT;
        private Label label103;
        private PictureBox pictureBox45;
        private TextBox txtJIGUAN;
        private Label label104;
        private PictureBox pictureBox48;
        private TextBox txtCurrent_Address;
        private Label label105;
        private PictureBox pictureBox49;
        private TextBox txtCurrent_Address_PHOTO;
        private Label label106;
        private PictureBox pictureBox50;
        private TextBox txtCurrent_Address_Zip_Code;
        private Label label107;
        private ComboBox comRUYUAN_PASS;
        private TextBox txtRUYUAN_PASS;
        private Label label108;
        private Label label110;
        private PictureBox pictureBox51;
        private TextBox textdiagnosis_desc28;
        private Label label111;
        private PictureBox pictureBox52;
        private TextBox txtdiagnosis_code28;
        private Label label121;
        private PictureBox pictureBox53;
        private TextBox txtBLH;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comYWGM;
        private TextBox txtYWGM;
        private PictureBox pictureBox13;
        private PictureBox pictureBox54;
        private Label label18;
        private ComboBox comDISCHARGE_PASS;
        private TextBox txtDISCHARGE_PASS;
        private Label label19;
        private PictureBox pictureBox15;
        private Label label21;
        private PictureBox pictureBox22;
        private Label label22;
        private TextBox txtZYMC;
        private TextBox txtZYJG;
        private Label label25;
        private ComboBox comZRYJH;
        private TextBox txtZRYJH;
        private Label label27;
        private PictureBox pictureBox25;
        private TextBox txtZYMD;
        private Label label30;
        private ComboBox cmdBLOOD_TYPE;
        private Label label32;
        private TextBox txtCOST_TOTAL;
        private PictureBox pictureBox10;
        private Label label34;
        private TextBox txtCOST_ZH_YBYL;
        private PictureBox pictureBox14;
        private Label label36;
        private TextBox txtCOST_OWNPAY;
        private PictureBox pictureBox23;
        private Label label38;
        private TextBox txtCOST_ZD_SYS;
        private PictureBox pictureBox26;
        private Label label40;
        private TextBox txtCOST_ZH_HL;
        private PictureBox pictureBox41;
        private Label label42;
        private TextBox txtCOST_ZH_OTHER;
        private PictureBox pictureBox55;
        private Label label44;
        private TextBox txtCOST_ZD_BL;
        private PictureBox pictureBox56;
        private Label label47;
        private TextBox txtCOST_ZD_YXX;
        private PictureBox pictureBox57;
        private Label label48;
        private TextBox txtCOST_ZH_YBZL;
        private PictureBox pictureBox58;
        private Label label50;
        private TextBox txtCOST_ZD_LCXM;
        private PictureBox pictureBox59;
        private Label label52;
        private TextBox txtCOST_ZL_FSSZLXM;
        private PictureBox pictureBox60;
        private Label label54;
        private TextBox txtCOST_ZL_LCWLZL;
        private PictureBox pictureBox61;
        private Label label55;
        private TextBox txtCOST_ZL_SSZL;
        private PictureBox pictureBox62;
        private Label label58;
        private TextBox txtCOST_ZL_MZ;
        private PictureBox pictureBox63;
        private Label label59;
        private TextBox txtCOST_ZL_SS;
        private PictureBox pictureBox64;
        private Label label60;
        private TextBox txtCOST_KF_KF;
        private PictureBox pictureBox65;
        private Label label64;
        private TextBox txtCOST_ZY_ZYZL;
        private PictureBox pictureBox66;
        private Label label65;
        private TextBox txtCOST_XY_XY;
        private PictureBox pictureBox67;
        private Label label67;
        private TextBox txtCOST_ZY_ZCHY;
        private PictureBox pictureBox68;
        private Label label85;
        private Label label86;
        private TextBox txtCOST_XY_KJYW;
        private TextBox txtCOST_ZY_ZCAOY;
        private PictureBox pictureBox69;
        private PictureBox pictureBox70;
        private Label label87;
        private TextBox txtCOST_XY_XF;
        private PictureBox pictureBox71;
        private Label label89;
        private TextBox txtCOST_XY_BDB;
        private PictureBox pictureBox72;
        private Label label91;
        private TextBox txtCOST_XY_QDB;
        private PictureBox pictureBox73;
        private Label label93;
        private TextBox txtCOST_XY_NXYZ;
        private PictureBox pictureBox74;
        private Label label94;
        private TextBox txtCOST_XY_XBYZ;
        private PictureBox pictureBox75;
        private Label label95;
        private TextBox txtCOST_HC_JC;
        private PictureBox pictureBox76;
        private Label label100;
        private TextBox txtCOST_HC_ZL;
        private PictureBox pictureBox77;
        private Label label109;
        private TextBox txtCOST_HC_SS;
        private PictureBox pictureBox78;
        private Label label116;
        private TextBox txtCOST_OTHER;
        private PictureBox pictureBox79;
        private Label label118;
        private Label label129;
        private Label label128;
        private PictureBox pictureBox85;
        private PictureBox pictureBox82;
        private PictureBox pictureBox84;
        private PictureBox pictureBox81;
        private PictureBox pictureBox83;
        private PictureBox pictureBox80;
        private TextBox txtLNSS_A_HOSPITAL_MIN;
        private TextBox txtLNSS_P_HOSPITAL_MIN;
        private TextBox txtLNSS_A_HOSPITAL_HOURS;
        private TextBox txtLNSS_P_HOSPITAL_HOURS;
        private TextBox txtLNSS_A_HOSPITAL_DAYS;
        private TextBox txtLNSS_P_HOSPITAL_DAYS;
        private Label label127;
        private Label label125;
        private Label label123;
        private Label label124;
        private Label label122;
        private Label label119;
        private Label label120;
        private TextBox txtAge2;
        private PictureBox pictureBox86;
        private Label label130;
        private PictureBox pictureBox87;
        private PictureBox pictureBox88;
        private PictureBox pictureBox89;
        private Label label131;
        private TextBox txtATTEMD_DOCTOR;
        private Label label132;
        private TextBox txtCurrent_Address_Detail;
        private TextBox txtRegistered_p_r_address_detail;
        private PictureBox pictureBox90;
        private PictureBox pictureBox11;
        private PictureBox pictureBox91;
        private GridControl gridControlGraveWard;
        private GridView gridViewGraveWard;
        private Label label133;
        private Label label134;
        private Label label135;
        private Label label140;
        private PictureBox pictureBox92;
        private TextBox txtRESPIRATOR_USE_TIME;
        private PictureBox pictureBox93;
        private PictureBox pictureBox94;
        private TextBox txtADL_DISCHARGE;
        private TextBox txtADL_ADMISSION;
        private Label label141;
        private PictureBox pictureBox95;
        private PictureBox pictureBox96;
        private PictureBox pictureBox97;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label142;
        private Label label143;
        private Label label144;
        private GridColumn gridColumn1;
        private GridColumn gridColumn2;
        private GridColumn gridColumn3;
        private TextBox txtTUMOR_STAGE_T;
        private ComboBox comTUMOR_STAGE_T;
        private TextBox txtTUMOR_STAGE_N;
        private ComboBox comTUMOR_STAGE_N;
        private TextBox txtTUMOR_STAGE_M;
        private ComboBox comTUMOR_STAGE_M;
        private TextBox txtFOLLOW_DATETIME;
        private Label label145;
        private TextBox txtFOLLOW_INTERVAL_UNITS;
        private TextBox txtFOLLOW_INDICATOR;
        private ComboBox comFOLLOW_INTERVAL_UNITS;
        private ComboBox comFOLLOW_INDICATOR;
        private TextBox txtFOLLOW_INTERVAL;
        private PictureBox pictureBox98;
        private Label label147;
        private Label label149;
        private Label label150;
        private TextBox txtFOLLOW_WAY;
        private ComboBox comFOLLOW_WAY;
        private Label label146;
        private Label label148;
        private ComboBox comNOON;
        private PictureBox pictureBox99;
        private Button button2;
        private Label label151;
        private TextBox txtDISCHARGE_CONDITIONS;
        private ComboBox comDISCHARGE_CONDITIONS;
        private Label label152;
        private DataGridViewTextBoxColumn diagnosis_type_name;
        private DataGridViewTextBoxColumn diagnosis_desc;
        private DataGridViewTextBoxColumn diagnosis_desc_part;
        private DataGridViewTextBoxColumn code1;
        private DataGridViewTextBoxColumn code2;
        private DataGridViewTextBoxColumn treat_days;
        private DataGridViewCheckBoxColumn oper_treat_indicator;
        private DataGridViewTextBoxColumn diagnosis_date;
        private DataGridViewComboBoxColumn ADMISSION_CONDITIONS;
        private DataGridViewComboBoxColumn treat_result;
        private DataGridViewTextBoxColumn operation_code;
        private DataGridViewTextBoxColumn operating_date;
        private DataGridViewComboBoxColumn operating_grade;
        private DataGridViewTextBoxColumn operation_desc;
        private DataGridViewTextBoxColumn operator1;
        private DataGridViewComboBoxColumn STERILE_HEAL;
        private DataGridViewTextBoxColumn first_assistant;
        private DataGridViewTextBoxColumn second_assistant;
        private DataGridViewComboBoxColumn wound_grade;
        private DataGridViewComboBoxColumn heal;
        private DataGridViewComboBoxColumn anaesthesia_method;
        private DataGridViewTextBoxColumn anesthesia_doctor;
        private DataGridViewTextBoxColumn 检查标志;
        private DataGridViewComboBoxColumn ISMAIN;
        private DataGridViewComboBoxColumn ILLNESS;
        private DataGridViewComboBoxColumn INFFECT;
        private DataGridViewComboBoxColumn OPERACCORD;
    }
}
