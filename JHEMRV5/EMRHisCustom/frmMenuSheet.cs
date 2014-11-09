using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmMenuSheet : Form
    {
        private string m_strDBConnet = "HISConnect";
        private DataTable m_dtMenu = new DataTable();
        public int m_nindicator = 0;
        public frmMenuSheet()
        {
            InitializeComponent();
        }
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void sbtnConfirm_Click(object sender, EventArgs e)
        {
            if (this.gvMenu.SelectedRowsCount >= 1)
            {
                string text = this.gvMenu.GetDataRow(this.gvMenu.FocusedRowHandle)["MENU_NAME"].ToString();
                if (MessageBox.Show(string.Concat(new string[]
				{
					"您选择了对病人『",
					EmrSysPubVar.getCurPatientName(),
					"』下达检验套餐『",
					text,
					"』，是否继续？"
				}), "注意", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    string text2 = "";
                    string text3 = "";
                    int num = 1;
                    DataTable dataTable = new DataTable();
                    int nindicator = this.m_nindicator;
                    if (nindicator == 1)
                    {
                    }
                    DateTime serverNow = EmrSysPubFunction.getServerNow();
                    int curPatientVisitID = EmrSysPubVar.getCurPatientVisitID();
                    string curPatientClinicDiag = EmrSysPubVar.getCurPatientClinicDiag();
                    string curPatientDeptCode = EmrSysPubVar.getCurPatientDeptCode();
                    string curPatientNamePhonetic = EmrSysPubVar.getCurPatientNamePhonetic();
                    string curVisitChargeType = EmrSysPubVar.getCurVisitChargeType();
                    DateTime curPatientBirthDate = EmrSysPubVar.getCurPatientBirthDate();
                    int num2 = EmrSysPubFunction.getServerNow().Year - curPatientBirthDate.Year;
                    string sQLString = "SELECT  CREATE_DATE,MENU_NAME,SN,ITEM_NO,ITEM_CODE,ITEM_NAME,SPECIMAN,PERFORMED_BY  FROM LAB_MENU_SHEET  WHERE ( MENU_NAME = '" + text + "' ) ";
                    dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                    if (dataTable.Rows.Count < 0)
                    {
                        MessageBox.Show("没有找到对应套餐的内容", "错误");
                    }
                    else
                    {
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            if (i > 0)
                            {
                                if (dataTable.Rows[i]["item_no"].ToString() == dataTable.Rows[i - 1]["item_no"].ToString())
                                {
                                    num = 0;
                                }
                                else
                                {
                                    num = 1;
                                }
                            }
                            if (num == 1)
                            {
                                sQLString = "select test_no.nextval as ls_no from dual";
                                object single = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
                                if (single != null)
                                {
                                    text2 = single.ToString();
                                }
                                if (text2.Length < 4)
                                {
                                    switch (text2.Length)
                                    {
                                        case 1:
                                            text2 = "000" + text2;
                                            break;
                                        case 2:
                                            text2 = "00" + text2;
                                            break;
                                        case 3:
                                            text2 = "0" + text2;
                                            break;
                                    }
                                }
                                text3 = DateTime.Now.ToString("yyMMdd") + text2;
                            }
                            string text4 = dataTable.Rows[i]["SPECIMAN"].ToString();
                            string text5 = dataTable.Rows[i]["PERFORMED_BY"].ToString();
                            if (num == 1)
                            {
                                sQLString = string.Concat(new string[]
								{
									"insert into lab_test_master (test_no,priority_indicator,patient_id,visit_id,working_id,execute_date,name,name_phonetic,charge_type, sex, age,test_cause,relevant_clinic_diag,specimen,notes_for_spcm,spcm_received_date_time,spcm_sample_date_time,requested_date_time,ordering_dept,ordering_provider,performed_by,result_status,results_rpt_date_time,transcriptionist,verified_by,costs,charges,billing_indicator,print_indicator,subject,prt_flag)  values ('",
									text3,
									"',",
									nindicator.ToString(),
									",'",
									EmrSysPubVar.getCurPatientID(),
									"',",
									curPatientVisitID.ToString(),
									",'',null,'",
									EmrSysPubVar.getCurPatientName(),
									"','",
									curPatientNamePhonetic,
									"','",
									curVisitChargeType,
									"','",
									EmrSysPubVar.getCurPatientSex(),
									"','",
									num2.ToString(),
									"','','",
									curPatientClinicDiag,
									"','",
									text4,
									"','',null,null,TO_DATE('",
									serverNow.ToString(),
									"','YYYY-MM-DD HH24:MI:SS'),'",
									curPatientDeptCode,
									"','",
									EmrSysPubVar.getCurPatientDoctorInCharge(),
									"','",
									text5,
									"','1',null,'','','','','','','",
									text,
									"','0')"
								});
                                DALUseSpecial.ExecuteSql(sQLString, this.m_strDBConnet);
                            }
                            string text6 = dataTable.Rows[i]["item_name"].ToString();
                            string text7 = dataTable.Rows[i]["item_code"].ToString();
                            sQLString = string.Concat(new string[]
							{
								"insert into LAB_TEST_ITEMS (TEST_NO,ITEM_NO,ITEM_NAME,ITEM_CODE) values('",
								text3,
								"','",
								dataTable.Rows[i]["sn"].ToString(),
								"','",
								text6,
								"','",
								text7,
								"')"
							});
                            DALUseSpecial.ExecuteSql(sQLString, this.m_strDBConnet);
                        }
                        MessageBox.Show("数据提交成功,请通知护士站有新检验单下达", "提示");
                        base.DialogResult = DialogResult.OK;
                    }
                }
            }
        }
        private void frmMenuSheet_Load(object sender, EventArgs e)
        {
            string sQLString = "SELECT distinct MENU_NAME FROM LAB_MENU_SHEET";
            this.m_dtMenu = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            this.gcMenu.DataSource = this.m_dtMenu;
        }
        private void gvMenu_DoubleClick(object sender, EventArgs e)
        {
            this.sbtnConfirm_Click(sender, e);
        }
    }
}