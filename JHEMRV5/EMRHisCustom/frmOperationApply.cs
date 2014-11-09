using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using JHEMR.EMREdit;
using JHEMR.EmrSysAdaper;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmOperationApply : Form
    {
        private string m_strDBConnet = "HISConnect";
        private DataTable dtUserDept = new DataTable();
        private DataTable dtPats = new DataTable();
        private DataTable dtOperationName = new DataTable();
        private DataTable dtRoom = new DataTable();
        private DataTable dtRoomNo = new DataTable();
        private DataTable dtOperationScheduleName = new DataTable();
        private int m_nschedule_id = 1;
        private int m_nVisitID = 1;
        private BaseEdit m_gridViewActiveEditor = null;
        private DataTable m_dtPyInputDict = new DataTable();
        private string m_strDeptStayed = "";
        private DataTable m_dtGroup = new DataTable();
        private string strAllOperRoom = string.Empty;
        private bool blOperRoom = false;
        private string strAllDeptDict = string.Empty;
        private bool blDeptDict = true;
        public frmOperationApply()
        {
            InitializeComponent();
        }
        private void frmOperationApply_Load(object sender, EventArgs e)
        {
            this.gridViewPYInput.Focus();
            SendKeys.Send("{DOWN}");
            string sQLString = string.Empty;
            sQLString = "select * FROM APPLICATION_CONFIG where application='SURGEON' and item_name='OPER_ROOM'";
            DataSet dataSet = new DataSet();
            dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                if (dataSet.Tables[0].Rows[0]["value"] != DBNull.Value)
                {
                    this.strAllOperRoom = dataSet.Tables[0].Rows[0]["value"].ToString();
                }
            }
            sQLString = "select * FROM APPLICATION_CONFIG where application='SURGEON' and item_name='OPERATING_DEPT'";
            DataSet dataSet2 = new DataSet();
            dataSet2 = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
            if (dataSet2.Tables.Count > 0 && dataSet2.Tables[0].Rows.Count > 0)
            {
                if (dataSet2.Tables[0].Rows[0]["value"] != DBNull.Value)
                {
                    this.strAllDeptDict = dataSet2.Tables[0].Rows[0]["value"].ToString();
                }
            }
            this.FillUserDept();
            this.FillPatList();
            this.FillRoom();
            this.FillAnaesthesiaMethod();
            this.FillPyInputDict();
            this.FillANTIBIOTIC();
            this.cmbisolation_indicator.SelectedIndex = 0;
        }
        private DataTable SetScheduleDate(string strOperNameNo)
        {
            DataTable dataTable = new DataTable();
            string sQLString = "select a.limit_time,a.absolute_prohibited_day,a.absolute_prohibited_day_num,a.conditioned_prohibited_day,a.conditioned_prohibited_day_num,a.conditioned_relative_day,a.conditioned_relative_day_num,a.especial_day,a.especial_day_num from set_schedule_date a where a.operating_room='" + strOperNameNo + "' ";
            return DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
        }
        private void FillANTIBIOTIC()
        {
            string sQLString = "select * from emr_dict_detail where class_code='ANTIBIOTIC' order by order_no";
            DataTable dataTable = DALUse.Query(sQLString).Tables[0];
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    this.cmbANTIBIOTIC.Items.Add(dataRow["dict_name"].ToString());
                }
            }
        }
        private void FillPyInputDict()
        {
            string sQLString = "select INPUT_CODE,OPERATION_NAME as ITEM_NAME,OPERATION_SCALE from operation_dict";
            this.m_dtPyInputDict = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            this.gridPYInput.DataSource = this.m_dtPyInputDict;
        }
        private void FillAnaesthesiaMethod()
        {
            string sQLString = "SELECT ANAESTHESIA_CODE,ANAESTHESIA_NAME,SERIAL_NO FROM ANAESTHESIA_DICT ";
            DataSet dataSet = new DataSet();
            dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    this.cmbanesthesia_method.Items.Add(dataRow["ANAESTHESIA_NAME"].ToString());
                }
            }
        }
        private void FillRoom()
        {
            string sQLString = "  SELECT DISTINCT a.DEPT_NAME, a.DEPT_CODE FROM DEPT_DICT a,OPERATING_ROOM b WHERE a.DEPT_CODE = b.DEPT_CODE ";
            this.dtRoom = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (this.dtRoom.Rows.Count > 0)
            {
                foreach (DataRow dataRow in this.dtRoom.Rows)
                {
                    this.cmboperating_room.Items.Add(dataRow["dept_name"].ToString());
                }
            }
        }
        private void FillUserDept()
        {
            DataSet dataSet = new DataSet();
            string text = "SELECT USER_DEPT,DEPT_NAME,DEFAULT_DEPT_FLAG FROM USER_DEPT a, DEPT_DICT b  ";
            text = text + " WHERE a.USER_DEPT=b.DEPT_CODE AND  a.USER_ID='" + EmrSysPubVar.getUserID() + "' ORDER BY DEPT_NAME";
            dataSet = DALUse.Query(text);
            if (dataSet.Tables.Count > 0)
            {
                this.dtUserDept = dataSet.Tables[0];
                foreach (DataRow dataRow in this.dtUserDept.Rows)
                {
                    this.cmbDept.Items.Add(dataRow["DEPT_NAME"].ToString());
                }
                this.txtDeptName.Text = EmrSysPubVar.getDeptName();
                this.txtDeptName.Tag = EmrSysPubVar.getDeptCode();
            }
        }
        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dtUserDept != null)
            {
                if (this.dtUserDept.IsInitialized)
                {
                    if (this.dtUserDept.Rows.Count > this.cmbDept.SelectedIndex)
                    {
                        DataRow dataRow = this.dtUserDept.Rows[this.cmbDept.SelectedIndex];
                        this.cmbDept.Tag = dataRow["USER_DEPT"].ToString();
                    }
                }
                this.FillPatList();
            }
        }
        private void FillPatList()
        {
            if (this.txtDeptName.Text.Length > 0)
            {
                string sQLString = "  SELECT b.PATIENT_ID,b.VISIT_ID,b.BED_NO,b.DIAGNOSIS,a.NAME,a.SEX,a.DATE_OF_BIRTH,a.CHARGE_TYPE,b.TOTAL_COSTS,a.INP_NO,b.DEPT_CODE   FROM PAT_MASTER_INDEX a,PATS_IN_HOSPITAL b    WHERE ( a.PATIENT_ID = b.PATIENT_ID ) and  ( ( b.DEPT_CODE = '" + this.txtDeptName.Tag.ToString() + "'  ) ) order by b.bed_no   ";
                this.dtPats = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                this.gcPat.DataSource = this.dtPats;
                int num = 0;
                foreach (DataRow dataRow in this.dtPats.Rows)
                {
                    if (dataRow["PATIENT_ID"] != DBNull.Value && dataRow["VISIT_ID"] != DBNull.Value)
                    {
                        if (dataRow["PATIENT_ID"].ToString().Equals(EmrSysPubVar.getCurPatientID()) && dataRow["VISIT_ID"].ToString().Equals(EmrSysPubVar.getCurPatientVisitID().ToString()))
                        {
                            break;
                        }
                        num++;
                    }
                }
                if (num >= this.dtPats.Rows.Count)
                {
                    num = 0;
                }
                this.gvPat.FocusedRowHandle = num;
                this.gvPat.TopRowIndex = num;
            }
            else
            {
                this.gcPat.DataSource = null;
            }
        }
        private void gvPat_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (this.gvPat.SelectedRowsCount < 1)
            {
                this.txtBED_NO.Text = "";
                this.txtPatID.Text = "";
                this.txtINP_NO.Text = "";
                this.txtName.Text = "";
                this.txtSex.Text = "";
                this.txtAge.Text = "";
                this.txtdiag_before_operation.Text = "";
                this.txtpatient_condition.Text = "";
                this.txtsequence.Text = "";
                this.txtoperating_room.Text = "";
                this.cmboperating_room_no.Text = "";
                this.cmbisolation_indicator.Text = "";
                this.cmboperation_scale.Text = "";
                this.txtsurgeon.Text = "";
                this.txtfirst_assistant.Text = "";
                this.txtsecond_assistant.Text = "";
                this.txtthird_assistant.Text = "";
                this.txtfourth_assistant.Text = "";
                this.txtblood_tran_doctor.Text = "";
                this.cmbanesthesia_method.Text = "";
                this.txtnotes_on_operation.Text = "";
                this.txtOPERATING_DEPT.Text = "";
                this.txtOPERATING_DEPT.Tag = "";
                this.sbtnSave.Enabled = false;
            }
            else
            {
                this.sbtnSave.Enabled = true;
                DataRow dataRow = this.dtPats.Rows[this.gvPat.GetSelectedRows()[0]];
                DateTime serverNow = EmrSysPubFunction.getServerNow();
                if (serverNow.DayOfWeek.ToString() != "Saturday")
                {
                    this.dtpscheduled_date_time.Text = serverNow.AddDays(1.0).ToShortDateString() + " 08:00";
                }
                else
                {
                    this.dtpscheduled_date_time.Text = serverNow.AddDays(2.0).ToShortDateString() + " 08:00";
                }
                this.txtBED_NO.Text = dataRow["BED_NO"].ToString();
                this.txtPatID.Text = dataRow["PATIENT_ID"].ToString();
                this.m_nVisitID = Convert.ToInt32(dataRow["VISIT_ID"].ToString());
                this.m_strDeptStayed = dataRow["DEPT_CODE"].ToString();
                this.txtINP_NO.Text = dataRow["INP_NO"].ToString();
                this.txtName.Text = dataRow["NAME"].ToString();
                this.txtSex.Text = dataRow["SEX"].ToString();
                this.txtAge.Text = EmrSysPubFunction.GetAge(EmrSysPubFunction.getServerNow(), Convert.ToDateTime(dataRow["DATE_OF_BIRTH"].ToString()));
                string text = "select * from pat_diagnosis ";
                string text2 = text;
                text = string.Concat(new string[]
				{
					text2,
					" where patient_id = '",
					dataRow["patient_id"].ToString(),
					"' and visit_id = ",
					dataRow["visit_id"].ToString(),
					" and diagnosis_type = '2' and diagnosis_no = 1  "
				});
                DataTable dataTable = DALUse.Query(text).Tables[0];
                text = " select * from adt_log t where t.action = 'D' ";
                text2 = text;
                text = string.Concat(new string[]
				{
					text2,
					" and t.patient_id = '",
					dataRow["patient_id"].ToString(),
					"' and t.visit_id =",
					dataRow["visit_id"].ToString(),
					"  and t.dept_code = ",
					this.m_strDeptStayed,
					""
				});
                DataTable dataTable2 = DALUseSpecial.Query(text, this.m_strDBConnet).Tables[0];
                bool flag = false;
                if (dataTable2 != null)
                {
                    if (dataTable2.Rows.Count > 0)
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    text = "select distinct a.*  from mr_file_index a, mr_templet_index b";
                    text += " where a.mr_code = b.mr_code  and b.monitor_code = 'C10'";
                    text2 = text;
                    text = string.Concat(new string[]
					{
						text2,
						" and a.dept_code = '",
						dataRow["DEPT_CODE"].ToString(),
						"' and a.patient_id = '",
						dataRow["patient_id"].ToString(),
						"'  and a.visit_id =",
						dataRow["visit_id"].ToString(),
						""
					});
                    text += "  order by a.file_no desc";
                    DataTable dataTable3 = DALUse.Query(text).Tables[0];
                    if (dataTable3 != null)
                    {
                        if (dataTable3.Rows.Count > 0)
                        {
                            UCEMREditMrPad uCEMREditMrPad = new UCEMREditMrPad();
                            s_pat_info curPatientInfo = EmrSysPubVar.getCurPatientInfo();
                            string patient_id = curPatientInfo.patient_id;
                            int visit_id = curPatientInfo.visit_id;
                            curPatientInfo.patient_id = dataRow["PATIENT_ID"].ToString();
                            curPatientInfo.visit_id = this.m_nVisitID;
                            EmrSysPubVar.setCurPatientInfo(curPatientInfo);
                            if (EMRArchiveAdaperUse.retrieveEmrFile(new object[]
							{
								0,
								dataTable3.Rows[0]["FILE_NAME"].ToString(),
								""
							}))
                            {
                                uCEMREditMrPad.PadCleanPadDocumentMircoFieldElemValue();
                                if (uCEMREditMrPad.PadOpenFile(EmrSysPubVar.getTempFileFullName()))
                                {
                                    uCEMREditMrPad.PadSetDocumentMode(3);
                                    if (uCEMREditMrPad.PadFindField("病程记录" + dataTable3.Rows[0]["FILE_NO"].ToString(), -1, 1, true))
                                    {
                                        if (uCEMREditMrPad.PadFindField("初步诊断第一诊断", -1, 1, false))
                                        {
                                            this.txtdiag_before_operation.Text = uCEMREditMrPad.PadGetFieldText(-1, -1, -1, -1, false);
                                            if (this.txtdiag_before_operation.Text.Length < 0)
                                            {
                                                this.txtdiag_before_operation.Text = dataRow["DIAGNOSIS"].ToString();
                                            }
                                        }
                                    }
                                }
                            }
                            curPatientInfo.patient_id = patient_id;
                            curPatientInfo.visit_id = visit_id;
                            EmrSysPubVar.setCurPatientInfo(curPatientInfo);
                        }
                        else
                        {
                            if (dataRow["DIAGNOSIS"] != DBNull.Value)
                            {
                                this.txtdiag_before_operation.Text = dataRow["DIAGNOSIS"].ToString();
                            }
                        }
                    }
                    else
                    {
                        if (dataRow["DIAGNOSIS"] != DBNull.Value)
                        {
                            this.txtdiag_before_operation.Text = dataRow["DIAGNOSIS"].ToString();
                        }
                    }
                }
                else
                {
                    if (dataTable != null)
                    {
                        if (dataTable.Rows.Count > 0)
                        {
                            if (dataTable.Rows[0]["DIAGNOSIS_DESC"] != DBNull.Value)
                            {
                                this.txtdiag_before_operation.Text = dataTable.Rows[0]["DIAGNOSIS_DESC"].ToString();
                            }
                            else
                            {
                                if (dataRow["DIAGNOSIS"] != DBNull.Value)
                                {
                                    this.txtdiag_before_operation.Text = dataRow["DIAGNOSIS"].ToString();
                                }
                            }
                        }
                        else
                        {
                            if (dataRow["DIAGNOSIS"] != DBNull.Value)
                            {
                                this.txtdiag_before_operation.Text = dataRow["DIAGNOSIS"].ToString();
                            }
                        }
                    }
                    else
                    {
                        if (dataRow["DIAGNOSIS"] != DBNull.Value)
                        {
                            this.txtdiag_before_operation.Text = dataRow["DIAGNOSIS"].ToString();
                        }
                    }
                }
                this.txtpatient_condition.Text = "";
                this.txtsequence.Text = "";
                this.txtoperating_room.Text = "";
                this.cmboperating_room_no.Text = "";
                this.cmbisolation_indicator.Text = "";
                this.cmboperation_scale.Text = "";
                this.txtsurgeon.Text = "";
                this.txtfirst_assistant.Text = "";
                this.txtsecond_assistant.Text = "";
                this.txtthird_assistant.Text = "";
                this.txtfourth_assistant.Text = "";
                this.txtblood_tran_doctor.Text = "";
                this.cmbanesthesia_method.Text = "";
                this.txtnotes_on_operation.Text = "";
                this.cmbanesthesia_method.Text = "";
                this.cmbANTIBIOTIC.Text = "";
                this.txtOPERATING_DEPT.Tag = this.txtDeptName.Tag;
                this.txtOPERATING_DEPT.Text = this.txtDeptName.Text;
                if (this.txtOPERATING_DEPT.Tag != null)
                {
                    if (this.txtOPERATING_DEPT.Tag.ToString().Length >= 4)
                    {
                        if (this.strAllDeptDict.IndexOf(this.txtOPERATING_DEPT.Tag.ToString().Substring(0, 4)) >= 0)
                        {
                            this.blDeptDict = false;
                        }
                    }
                }
                this.cmbGroup.Text = "";
                this.cmbanesthesia_method.Text = "";
                this.txtentered_by.Text = EmrSysPubFunction.getUserName(EmrSysPubVar.getDbUser(), false);
                this.dtpreq_date_time.Text = EmrSysPubFunction.getServerNow().ToString();
                text = string.Concat(new string[]
				{
					"select OPERATION_NO,OPERATION,OPERATION_SCALE from SCHEDULED_OPERATION_NAME where patient_id='",
					dataRow["patient_id"].ToString(),
					"' and visit_id=",
					dataRow["visit_id"].ToString(),
					" and 1=2 and schedule_id=",
					this.m_nschedule_id.ToString()
				});
                this.dtOperationScheduleName = DALUseSpecial.Query(text, this.m_strDBConnet).Tables[0];
                int count = this.dtOperationScheduleName.Rows.Count;
                if (count < 2)
                {
                    for (int i = 0; i < 2 - count; i++)
                    {
                        DataRow dataRow2 = this.dtOperationScheduleName.NewRow();
                        dataRow2["OPERATION_NO"] = i + 1;
                        dataRow2["OPERATION"] = "";
                        dataRow2["OPERATION_SCALE"] = "";
                        this.dtOperationScheduleName.Rows.Add(dataRow2);
                    }
                }
                this.gcOperaion.DataSource = this.dtOperationScheduleName;
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            DataRow dataRow = this.dtOperationScheduleName.NewRow();
            dataRow["OPERATION_NO"] = this.dtOperationScheduleName.Rows.Count + 1;
            dataRow["OPERATION"] = "";
            dataRow["OPERATION_SCALE"] = "";
            this.dtOperationScheduleName.Rows.Add(dataRow);
        }
        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            if (this.gvOperation.SelectedRowsCount > 0)
            {
                this.dtOperationScheduleName.Rows.RemoveAt(this.gvOperation.FocusedRowHandle);
            }
        }
        private void cmboperating_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dtRoom != null)
            {
                if (this.dtRoom.IsInitialized)
                {
                    if (this.dtRoom.Rows.Count > this.cmboperating_room.SelectedIndex)
                    {
                        DataRow dataRow = this.dtRoom.Rows[this.cmboperating_room.SelectedIndex];
                        this.cmboperating_room.Tag = dataRow["dept_code"].ToString();
                        DataTable dataTable = this.SetScheduleDate(dataRow["dept_code"].ToString());
                        if (dataTable.Rows.Count > 0)
                        {
                            MessageBox.Show(string.Concat(new string[]
							{
								"当前手术室：",
								this.cmboperating_room.Text,
								"  当前手术室的预约限定时间=",
								dataTable.Rows[0]["limit_time"].ToString(),
								"\n\r非有效预约时间：周",
								dataTable.Rows[0]["absolute_prohibited_day"].ToString(),
								""
							}), "提示：");
                        }
                    }
                }
            }
            this.txtoperating_room.Tag = this.cmboperating_room.Tag;
            this.txtoperating_room.Text = this.cmboperating_room.Text;
        }
        private void FillRoomNo()
        {
            this.cmboperating_room_no.Items.Clear();
            if (this.cmboperating_room.Text.Length > 0)
            {
                string sQLString = "  SELECT DISTINCT a.DEPT_NAME,a.DEPT_CODE,b.ROOM_NO,b.STATUS  FROM DEPT_DICT a,OPERATING_ROOM b WHERE ( a.DEPT_CODE = b.DEPT_CODE ) and ( ( a.DEPT_CODE = '" + this.txtoperating_room.Tag.ToString() + "' ) AND ( b.STATUS = '0' ) ) ";
                this.dtRoomNo = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (this.dtRoomNo.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in this.dtRoomNo.Rows)
                    {
                        this.cmboperating_room_no.Items.Add(dataRow["ROOM_NO"].ToString());
                    }
                }
            }
        }
        private void SetScheduleID(string strPatientID, int nVisitID)
        {
            this.m_nschedule_id = 1;
            string sQLString = string.Empty;
            sQLString = "select count(*) as count from operation_schedule where patient_id='" + strPatientID + "' and visit_id=" + nVisitID.ToString();
            DataSet dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
            if (Convert.ToInt32(dataSet.Tables[0].Rows[0]["count"].ToString()) > 0)
            {
                sQLString = "select max(schedule_id) as schedule_id from operation_schedule where patient_id='" + strPatientID + "' and visit_id=" + nVisitID.ToString();
                dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    this.m_nschedule_id = Convert.ToInt32(dataSet.Tables[0].Rows[0]["schedule_id"].ToString()) + 1;
                }
            }
        }
        private void txtsurgeon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.panel5.Controls)
                {
                    if (control.Name == "input")
                    {
                        e.KeyChar = '\0';
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel5.Controls, (TextBox)sender);
                instance.loadData("USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                instance.Name = "input";
                this.panel5.Controls.Add(instance);
                this.panel5.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel5.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel5.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                e.KeyChar = '\0';
                instance.filter();
            }
        }
        private void txtsurgeon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.panel5.Controls)
                {
                    if (control.Name == "input")
                    {
                        e.KeyChar = '\0';
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel5.Controls, (TextBox)sender);
                if (this.blOperRoom && this.blDeptDict)
                {
                    instance.loadData("OPER_USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                }
                else
                {
                    instance.loadData("USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                }
                instance.Name = "input";
                this.panel5.Controls.Add(instance);
                this.panel5.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel5.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel5.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                e.KeyChar = '\0';
                instance.filter();
            }
        }
        private void gvOperation_ShownEditor(object sender, EventArgs e)
        {
            if (this.gvOperation.ActiveEditor != null && this.m_gridViewActiveEditor == null)
            {
                this.m_gridViewActiveEditor = this.gvOperation.ActiveEditor;
                this.m_gridViewActiveEditor.KeyDown += new KeyEventHandler(this.gvOperation_KeyDown);
                this.m_gridViewActiveEditor.DoubleClick += new EventHandler(this.gvOperation_DoubleClick);
            }
        }
        private void gvOperation_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gvOperation.RowCount >= 1)
            {
                if (e.KeyCode == Keys.F9)
                {
                    this.panelPYInput.Visible = true;
                    this.panelPYInput.BringToFront();
                    this.txtInPut.Text = "";
                    this.txtInPut.Focus();
                }
            }
        }
        private void gvOperation_DoubleClick(object sender, EventArgs e)
        {
            if (this.gvOperation.RowCount >= 1)
            {
                this.panelPYInput.Visible = true;
                this.panelPYInput.BringToFront();
                this.txtInPut.Text = "";
                this.txtInPut.Focus();
            }
        }
        private void gvOperation_HiddenEditor(object sender, EventArgs e)
        {
            if (this.m_gridViewActiveEditor != null)
            {
                this.m_gridViewActiveEditor.KeyDown -= new KeyEventHandler(this.gvOperation_KeyDown);
                this.m_gridViewActiveEditor.DoubleClick -= new EventHandler(this.gvOperation_DoubleClick);
                this.m_gridViewActiveEditor = null;
            }
        }
        private void setCellValueByPYInput(string strValue, string strOperationScale)
        {
            if (this.dtOperationScheduleName.Rows.Count >= 1)
            {
                this.dtOperationScheduleName.Rows[this.gvOperation.FocusedRowHandle]["operation"] = strValue;
                this.dtOperationScheduleName.Rows[this.gvOperation.FocusedRowHandle]["operation_scale"] = strOperationScale;
            }
        }
        private void txtInPut_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
            if (keyCode <= Keys.Escape)
            {
                if (keyCode != Keys.Return)
                {
                    if (keyCode == Keys.Escape)
                    {
                        this.panelPYInput.Visible = false;
                        this.gvOperation.Focus();
                    }
                }
                else
                {
                    if (this.gridViewPYInput.FocusedRowHandle >= 0)
                    {
                        DataRow dataRow = this.gridViewPYInput.GetDataRow(this.gridViewPYInput.FocusedRowHandle);
                        this.setCellValueByPYInput(dataRow["ITEM_NAME"].ToString(), dataRow["operation_scale"].ToString());
                        this.panelPYInput.Visible = false;
                        this.gvOperation.Focus();
                    }
                }
            }
            else
            {
                switch (keyCode)
                {
                    case Keys.Prior:
                        this.gridViewPYInput.Focus();
                        SendKeys.Send("{PGUP}");
                        break;
                    case Keys.Next:
                        this.gridViewPYInput.Focus();
                        SendKeys.Send("{PGDN}");
                        break;
                    default:
                        switch (keyCode)
                        {
                            case Keys.Up:
                                this.gridViewPYInput.Focus();
                                SendKeys.Send("{UP}");
                                break;
                            case Keys.Down:
                                this.gridViewPYInput.Focus();
                                SendKeys.Send("{DOWN}");
                                break;
                        }
                        break;
                }
            }
        }
        private void txtInPut_TextChanged(object sender, EventArgs e)
        {
            if (this.m_dtPyInputDict != null)
            {
                if (this.m_dtPyInputDict.Rows.Count > 0)
                {
                    this.m_dtPyInputDict.DefaultView.RowFilter = "INPUT_CODE like '%" + this.txtInPut.Text.Replace("'", "''").ToUpper() + "%'";
                    if (this.gridViewPYInput.RowCount > 0)
                    {
                        DataRow dataRow = this.gridViewPYInput.GetDataRow(0);
                        this.lblPyItemName.Text = dataRow["ITEM_NAME"].ToString();
                        this.gridViewPYInput.MakeRowVisible(0, false);
                        this.gridViewPYInput.FocusedRowHandle = 0;
                    }
                    else
                    {
                        this.lblPyItemName.Text = "";
                    }
                }
            }
        }
        private void gridViewPYInput_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                DataRow dataRow = this.gridViewPYInput.GetDataRow(e.FocusedRowHandle);
                this.lblPyItemName.Text = dataRow["ITEM_NAME"].ToString();
            }
        }
        private void gridPYInput_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
            if (keyCode != Keys.Return)
            {
                if (keyCode != Keys.Escape)
                {
                    switch (keyCode)
                    {
                        case Keys.Left:
                            this.txtInPut.Focus();
                            SendKeys.Send("{LEFT}");
                            break;
                        case Keys.Right:
                            this.txtInPut.Focus();
                            SendKeys.Send("{RIGHT}");
                            break;
                    }
                }
                else
                {
                    this.panelPYInput.Visible = false;
                    this.gvOperation.Focus();
                }
            }
            else
            {
                if (this.gridViewPYInput.FocusedRowHandle >= 0)
                {
                    DataRow dataRow = this.gridViewPYInput.GetDataRow(this.gridViewPYInput.FocusedRowHandle);
                    this.setCellValueByPYInput(dataRow["ITEM_NAME"].ToString(), dataRow["operation_scale"].ToString());
                    this.panelPYInput.Visible = false;
                    this.gvOperation.Focus();
                }
            }
        }
        private void txtdiag_before_operation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                this.txtdiag_before_operation.Text = "";
                foreach (Control control in this.panel5.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel5.Controls, (TextBox)sender);
                instance.loadData("DIAGNOSIS", "DIAGNOSIS", "");
                instance.Name = "input";
                this.panel5.Controls.Add(instance);
                this.panel5.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel5.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel5.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtdiag_before_operation_Enter(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "按F9调用拼音诊断字典操作";
        }
        private void txtdiag_before_operation_Leave(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "Ready";
        }
        private void txtsurgeon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.panel5.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel5.Controls, (TextBox)sender);
                instance.loadData("USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                instance.Name = "input";
                this.panel5.Controls.Add(instance);
                this.panel5.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel5.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel5.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtsurgeon1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.panel5.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel5.Controls, (TextBox)sender);
                if (this.blOperRoom && this.blDeptDict)
                {
                    instance.loadData("OPER_USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                }
                else
                {
                    instance.loadData("USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                }
                instance.Name = "input";
                this.panel5.Controls.Add(instance);
                this.panel5.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel5.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel5.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void gcOperaion_Enter(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "按F9或者双击该格调用手术名称字典选择操作，选中的项目回车写回";
        }
        private void gcOperaion_Leave(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "Ready";
        }
        private void txtsurgeon_Enter(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "按空格或者F9调用用户字典操作";
        }
        private void txtsurgeon_Leave(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "Ready";
        }
        private void gridViewPYInput_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridViewPYInput.FocusedRowHandle >= 0)
            {
                DataRow dataRow = this.gridViewPYInput.GetDataRow(this.gridViewPYInput.FocusedRowHandle);
                this.setCellValueByPYInput(dataRow["ITEM_NAME"].ToString(), dataRow["OPERATION_SCALE"].ToString());
                this.panelPYInput.Visible = false;
                this.gvOperation.Focus();
            }
        }
        public bool OperDoct(string strDoctName, string strDoctCode)
        {
            string sQLString = string.Concat(new string[]
			{
				"select * from operation_doctor_dict where doctor_id='",
				strDoctCode,
				"' and doctor_name='",
				strDoctName,
				"'"
			});
            DataSet dataSet = new DataSet();
            dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
            return dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0;
        }
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            string sQLString = string.Concat(new string[]
			{
				"select count(*) as count from operation_schedule where patient_id='",
				this.txtPatID.Text,
				"' and visit_id=",
				this.m_nVisitID.ToString(),
				" and scheduled_date_time=to_date('",
				this.dtpscheduled_date_time.Text,
				"','YYYY-MM-DD HH24:MI')"
			});
            DataSet dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
            if (Convert.ToInt32(dataSet.Tables[0].Rows[0]["count"].ToString()) > 0)
            {
                MessageBox.Show("该病人的手术已申请!");
            }
            else
            {
                if (this.txtoperating_room.Text.Length < 1)
                {
                    MessageBox.Show("手术室不能为空！", "提示：");
                }
                else
                {
                    if (this.OperLimit())
                    {
                        this.SetScheduleID(this.txtPatID.Text, this.m_nVisitID);
                        int num = 0;
                        if (this.gvOperation.RowCount > 0)
                        {
                            for (int i = 0; i < this.gvOperation.RowCount; i++)
                            {
                                if (this.gvOperation.GetDataRow(i)["OPERATION"].ToString().Trim() != "")
                                {
                                    num++;
                                }
                            }
                        }
                        if (num < 1)
                        {
                            MessageBox.Show("手术名称不能为空，请填写手术名称！", "提示：");
                        }
                        else
                        {
                            if (this.cmbGroup.Text.Length < 1)
                            {
                                MessageBox.Show("主诊组不能为空！", "提示：");
                            }
                            else
                            {
                                if (this.txtsurgeon.Text.Length < 1)
                                {
                                    MessageBox.Show("手术医师不能为空！", "提示：");
                                }
                                else
                                {
                                    if (this.blOperRoom && this.blDeptDict)
                                    {
                                        if (this.txtsurgeon.Tag == null)
                                        {
                                            MessageBox.Show("手术医师没有指纹代码，请先维护指纹代码！", "提示：");
                                            return;
                                        }
                                        if (!this.OperDoct(this.txtsurgeon.Text, this.txtsurgeon.Tag.ToString()))
                                        {
                                            MessageBox.Show("手术医师没有指纹代码，请先维护指纹代码！", "提示：");
                                            return;
                                        }
                                        if (this.txtsurgeon.Tag.ToString().Length < 1)
                                        {
                                            MessageBox.Show("手术医师没有指纹代码，请先维护指纹代码！", "提示：");
                                            return;
                                        }
                                    }
                                    if (this.txtfirst_assistant.Text.Length < 1)
                                    {
                                        MessageBox.Show("一助不能为空！", "提示：");
                                    }
                                    else
                                    {
                                        if (this.blOperRoom && this.blDeptDict)
                                        {
                                            if (this.txtfirst_assistant.Tag == null)
                                            {
                                                MessageBox.Show("一助没有指纹代码，请先维护指纹代码！", "提示：");
                                                return;
                                            }
                                            if (!this.OperDoct(this.txtsurgeon.Text, this.txtsurgeon.Tag.ToString()))
                                            {
                                                MessageBox.Show("手术医师没有指纹代码，请先维护指纹代码！", "提示：");
                                                return;
                                            }
                                            if (this.txtfirst_assistant.Tag.ToString().Length < 1)
                                            {
                                                MessageBox.Show("一助没有指纹代码，请先维护指纹代码！", "提示：");
                                                return;
                                            }
                                        }
                                        if (this.cmbanesthesia_method.Text.Length < 1)
                                        {
                                            MessageBox.Show("麻醉方法不能为空！", "提示：");
                                        }
                                        else
                                        {
                                            bool flag = false;
                                            bool flag2 = false;
                                            bool flag3 = false;
                                            bool flag4 = false;
                                            for (int i = 0; i < this.gvOperation.RowCount; i++)
                                            {
                                                if (this.gvOperation.GetDataRow(i)["OPERATION"].ToString().Trim() != "")
                                                {
                                                    if (this.gvOperation.GetDataRow(i)["OPERATION"].ToString().IndexOf("左") >= 0)
                                                    {
                                                        flag2 = true;
                                                    }
                                                    if (this.gvOperation.GetDataRow(i)["OPERATION"].ToString().IndexOf("右") >= 0)
                                                    {
                                                        flag = true;
                                                    }
                                                }
                                            }
                                            if (this.txtdiag_before_operation.Text.IndexOf("左") >= 0)
                                            {
                                                flag4 = true;
                                            }
                                            if (this.txtdiag_before_operation.Text.IndexOf("右") >= 0)
                                            {
                                                flag3 = true;
                                            }
                                            if (flag && flag2)
                                            {
                                                if (!flag3 && !flag4)
                                                {
                                                    MessageBox.Show("手术名称和术前诊断，存在左或右不统一,不能保存！", "提示：");
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                if (flag4 && flag3)
                                                {
                                                    if (!flag2 && !flag)
                                                    {
                                                        MessageBox.Show("手术名称和术前诊断，存在左或右不统一,不能保存！", "提示：");
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    if (!flag2.Equals(flag4) || !flag.Equals(flag3))
                                                    {
                                                        MessageBox.Show("手术名称和术前诊断，存在左或右不统一,不能保存！", "提示：");
                                                        return;
                                                    }
                                                }
                                            }
                                            string[] array = new string[num + 1];
                                            if (this.blOperRoom && this.blDeptDict)
                                            {
                                                array[0] = string.Concat(new string[]
												{
													"insert into OPERATION_SCHEDULE(PATIENT_ID,VISIT_ID,SCHEDULE_ID,DEPT_STAYED,BED_NO,SCHEDULED_DATE_TIME,OPERATING_ROOM,OPERATING_ROOM_NO,SEQUENCE,DIAG_BEFORE_OPERATION,PATIENT_CONDITION,OPERATION_SCALE,isolation_indicator, operating_dept,surgeon,first_assistant,second_assistant,third_assistant,fourth_assistant,anesthesia_method,entered_by,notes_on_operation,ack_indicator,req_date_time,blood_tran_doctor,antibiotic,dosage,group_code,doctor_no,SURGEON_NO,FS_NO) values ('",
													this.txtPatID.Text,
													"',",
													this.m_nVisitID.ToString(),
													",",
													this.m_nschedule_id.ToString(),
													",'",
													this.m_strDeptStayed,
													"','",
													this.txtBED_NO.Text,
													"',to_date('",
													this.dtpscheduled_date_time.Text,
													"','YYYY-MM-DD HH24:MI'),'",
													this.txtoperating_room.Tag.ToString(),
													"','",
													this.cmboperating_room_no.Text,
													"','",
													this.txtsequence.Text,
													"','",
													this.txtdiag_before_operation.Text,
													"','",
													this.txtpatient_condition.Text,
													"','",
													this.cmboperation_scale.Text,
													"','",
													this.cmbisolation_indicator.Text.Equals("") ? "" : Convert.ToString(this.cmbisolation_indicator.SelectedIndex + 1),
													"','",
													this.txtOPERATING_DEPT.Tag.ToString(),
													"','",
													this.txtsurgeon.Text,
													"','",
													this.txtfirst_assistant.Text,
													"','",
													this.txtsecond_assistant.Text,
													"','",
													this.txtthird_assistant.Text,
													"','",
													this.txtfourth_assistant.Text,
													"','",
													this.cmbanesthesia_method.Text,
													"','",
													this.txtentered_by.Text,
													"','",
													this.txtnotes_on_operation.Text.Replace("'", "''"),
													"',0,to_date('",
													this.dtpreq_date_time.Text,
													"','YYYY-MM-DD HH24:MI:SS'),'",
													this.txtblood_tran_doctor.Text,
													"','",
													this.cmbANTIBIOTIC.Text,
													"','",
													this.txtDOSAGE.Text.Replace("'", "''"),
													"','",
													(this.cmbGroup.Tag == null) ? "" : this.cmbGroup.Tag.ToString(),
													"','",
													EmrSysPubVar.getUserID(),
													"','",
													this.txtsurgeon.Tag.ToString(),
													"','",
													this.txtfirst_assistant.Tag.ToString(),
													"')"
												});
                                            }
                                            else
                                            {
                                                array[0] = string.Concat(new string[]
												{
													"insert into OPERATION_SCHEDULE(PATIENT_ID,VISIT_ID,SCHEDULE_ID,DEPT_STAYED,BED_NO,SCHEDULED_DATE_TIME,OPERATING_ROOM,OPERATING_ROOM_NO,SEQUENCE,DIAG_BEFORE_OPERATION,PATIENT_CONDITION,OPERATION_SCALE,isolation_indicator, operating_dept,surgeon,first_assistant,second_assistant,third_assistant,fourth_assistant,anesthesia_method,entered_by,notes_on_operation,ack_indicator,req_date_time,blood_tran_doctor,antibiotic,dosage,group_code,doctor_no) values ('",
													this.txtPatID.Text,
													"',",
													this.m_nVisitID.ToString(),
													",",
													this.m_nschedule_id.ToString(),
													",'",
													this.m_strDeptStayed,
													"','",
													this.txtBED_NO.Text,
													"',to_date('",
													this.dtpscheduled_date_time.Text,
													"','YYYY-MM-DD HH24:MI'),'",
													this.txtoperating_room.Tag.ToString(),
													"','",
													this.cmboperating_room_no.Text,
													"','",
													this.txtsequence.Text,
													"','",
													this.txtdiag_before_operation.Text,
													"','",
													this.txtpatient_condition.Text,
													"','",
													this.cmboperation_scale.Text,
													"','",
													this.cmbisolation_indicator.Text.Equals("") ? "" : Convert.ToString(this.cmbisolation_indicator.SelectedIndex + 1),
													"','",
													this.txtOPERATING_DEPT.Tag.ToString(),
													"','",
													this.txtsurgeon.Text,
													"','",
													this.txtfirst_assistant.Text,
													"','",
													this.txtsecond_assistant.Text,
													"','",
													this.txtthird_assistant.Text,
													"','",
													this.txtfourth_assistant.Text,
													"','",
													this.cmbanesthesia_method.Text,
													"','",
													this.txtentered_by.Text,
													"','",
													this.txtnotes_on_operation.Text.Replace("'", "''"),
													"',0,to_date('",
													this.dtpreq_date_time.Text,
													"','YYYY-MM-DD HH24:MI:SS'),'",
													this.txtblood_tran_doctor.Text,
													"','",
													this.cmbANTIBIOTIC.Text,
													"','",
													this.txtDOSAGE.Text.Replace("'", "''"),
													"','",
													(this.cmbGroup.Tag == null) ? "" : this.cmbGroup.Tag.ToString(),
													"','",
													EmrSysPubVar.getUserID(),
													"')"
												});
                                            }
                                            for (int i = 0; i < this.gvOperation.RowCount; i++)
                                            {
                                                if (this.gvOperation.GetDataRow(i)["OPERATION"].ToString().Trim() != "")
                                                {
                                                    array[i + 1] = string.Concat(new string[]
													{
														"insert into SCHEDULED_OPERATION_NAME(patient_id,visit_id,SCHEDULE_ID,operation_no,operation,operation_scale) values('",
														this.txtPatID.Text,
														"',",
														this.m_nVisitID.ToString(),
														",",
														this.m_nschedule_id.ToString(),
														",",
														Convert.ToString(i + 1),
														",'",
														this.gvOperation.GetDataRow(i)["OPERATION"].ToString(),
														"','",
														this.gvOperation.GetDataRow(i)["OPERATION_SCALE"].ToString(),
														"')"
													});
                                                }
                                            }
                                            if (DALUseSpecial.ExecuteSqlTran(array, this.m_strDBConnet))
                                            {
                                                MessageBox.Show("手术申请单添加成功！");
                                            }
                                            else
                                            {
                                                MessageBox.Show("手术申请单添加失败！");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void txtsequence_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtOPERATING_DEPT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                this.txtOPERATING_DEPT.Text = "";
                foreach (Control control in this.panel5.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel5.Controls, (TextBox)sender);
                instance.loadData("DEPT", "DEPT", "");
                instance.Name = "input";
                this.panel5.Controls.Add(instance);
                this.panel5.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel5.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel5.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtOPERATING_DEPT_Enter(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "按空格或者F9调用科室字典操作";
        }
        private void txtOPERATING_DEPT_Leave(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "Ready";
        }
        private void txtoperating_room_TextChanged(object sender, EventArgs e)
        {
            if (this.txtoperating_room.Tag != null)
            {
                this.txtsurgeon.Text = "";
                this.txtfirst_assistant.Text = "";
                if (this.strAllOperRoom.IndexOf(this.txtoperating_room.Tag.ToString()) >= 0)
                {
                    this.blOperRoom = true;
                }
                else
                {
                    this.blOperRoom = false;
                }
                this.FillRoomNo();
            }
        }
        private void txtOPERATING_DEPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                this.txtOPERATING_DEPT.Text = "";
                foreach (Control control in this.panel5.Controls)
                {
                    if (control.Name == "input")
                    {
                        e.KeyChar = '\0';
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel5.Controls, (TextBox)sender);
                instance.loadData("DEPT", "DEPT", "");
                instance.Name = "input";
                this.panel5.Controls.Add(instance);
                this.panel5.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel5.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X + 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel5.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                e.KeyChar = '\0';
                instance.filter();
            }
        }
        private void txtOPERATING_DEPT_TextChanged(object sender, EventArgs e)
        {
            this.cmbGroup.Items.Clear();
            if (this.txtOPERATING_DEPT.Tag != null)
            {
                if (this.txtOPERATING_DEPT.Tag.ToString().Length >= 4)
                {
                    string sQLString = "select * from staff_group_dict where group_class='主诊组' and valid=1 and group_code like '" + this.txtOPERATING_DEPT.Tag.ToString().Substring(0, 4) + "%'";
                    this.m_dtGroup = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                    if (this.m_dtGroup.Rows.Count > 0)
                    {
                        foreach (DataRow dataRow in this.m_dtGroup.Rows)
                        {
                            this.cmbGroup.Items.Add(dataRow["group_name"].ToString());
                        }
                    }
                    if (this.strAllDeptDict.IndexOf(this.txtOPERATING_DEPT.Tag.ToString().Substring(0, 4)) >= 0)
                    {
                        this.blDeptDict = false;
                    }
                    else
                    {
                        this.blDeptDict = true;
                    }
                }
            }
            this.txtsurgeon.Text = "";
            this.txtfirst_assistant.Text = "";
            this.txtsecond_assistant.Text = "";
            this.txtthird_assistant.Text = "";
            this.txtfourth_assistant.Text = "";
        }
        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbGroup.Tag = this.m_dtGroup.Rows[this.cmbGroup.SelectedIndex]["group_code"].ToString();
        }
        private void dtpscheduled_date_time_ValueChanged(object sender, EventArgs e)
        {
        }
        private void dtpscheduled_date_time_Leave(object sender, EventArgs e)
        {
        }
        public bool OperLimit()
        {
            string text = string.Empty;
            string text2 = string.Empty;
            string text3 = string.Empty;
            string text4 = string.Empty;
            string text5 = string.Empty;
            string text6 = string.Empty;
            string text7 = string.Empty;
            string text8 = string.Empty;
            string text9 = string.Empty;
            DateTime t = DateTime.MinValue;
            DateTime serverNow = EmrSysPubFunction.getServerNow();
            DataTable dataTable = null;
            if (this.txtoperating_room.Tag != null)
            {
                dataTable = this.SetScheduleDate(this.txtoperating_room.Tag.ToString());
            }
            int num = this.dtpscheduled_date_time.Value.DayOfWeek.GetHashCode();
            if (num == 7)
            {
                num = 1;
            }
            else
            {
                num++;
            }
            int num2 = serverNow.DayOfWeek.GetHashCode();
            if (num2 == 7)
            {
                num2 = 1;
            }
            else
            {
                num2++;
            }
            bool result;
            if (this.dtpscheduled_date_time.Value.Date < serverNow.AddDays(1.0).Date)
            {
                MessageBox.Show("预约日期必须大于当前日期！", "提示：");
                result = false;
            }
            else
            {
                if (dataTable.Rows.Count > 0)
                {
                    DataRow dataRow = dataTable.Rows[0];
                    if (dataRow["limit_time"] != DBNull.Value)
                    {
                        text = dataRow["limit_time"].ToString();
                    }
                    if (dataRow["absolute_prohibited_day"] != DBNull.Value)
                    {
                        text2 = dataRow["absolute_prohibited_day"].ToString();
                    }
                    if (dataRow["absolute_prohibited_day_num"] != DBNull.Value)
                    {
                        text3 = dataRow["absolute_prohibited_day_num"].ToString();
                    }
                    if (dataRow["especial_day"] != DBNull.Value)
                    {
                        text4 = dataRow["especial_day"].ToString();
                    }
                    if (dataRow["especial_day_num"] != DBNull.Value)
                    {
                        text5 = dataRow["especial_day_num"].ToString();
                    }
                    if (dataRow["conditioned_prohibited_day"] != DBNull.Value)
                    {
                        text6 = dataRow["conditioned_prohibited_day"].ToString();
                    }
                    if (dataRow["conditioned_prohibited_day_num"] != DBNull.Value)
                    {
                        text7 = dataRow["conditioned_prohibited_day_num"].ToString();
                    }
                    if (dataRow["conditioned_relative_day"] != DBNull.Value)
                    {
                        text8 = dataRow["conditioned_relative_day"].ToString();
                    }
                    if (dataRow["conditioned_relative_day_num"] != DBNull.Value)
                    {
                        text9 = dataRow["conditioned_relative_day_num"].ToString();
                    }
                    if (text.Length > 0)
                    {
                        t = Convert.ToDateTime(serverNow.ToShortDateString() + " " + text);
                    }
                    if (text2.Length > 0 && text3.Length > 0)
                    {
                        if (text3.IndexOf(num.ToString()) >= 0)
                        {
                            MessageBox.Show("禁止预约周" + text2 + "的手术！", "提示：");
                            result = false;
                            return result;
                        }
                    }
                    if (this.dtpscheduled_date_time.Value.Date == serverNow.AddDays(1.0).Date)
                    {
                        if (serverNow > t && text.Length > 0)
                        {
                            MessageBox.Show("" + text + "以后不能预约隔日手术！", "提示：");
                            result = false;
                            return result;
                        }
                    }
                    else
                    {
                        if (this.dtpscheduled_date_time.Value.Date > serverNow.AddDays(1.0).Date)
                        {
                            if (text5.IndexOf(num2.ToString()) >= 0 && text7.IndexOf(num.ToString()) >= 0)
                            {
                                if (serverNow > t && text.Length > 0)
                                {
                                    MessageBox.Show(string.Concat(new string[]
									{
										"周",
										text4,
										text,
										"以后不能预约下周",
										text6,
										"的手术！"
									}), "提示：");
                                    result = false;
                                    return result;
                                }
                            }
                        }
                    }
                    if (text9.IndexOf(num2.ToString()) >= 0 && text7.IndexOf(num.ToString()) >= 0)
                    {
                        if ((this.dtpscheduled_date_time.Value - serverNow).Days < 7)
                        {
                            MessageBox.Show(string.Concat(new string[]
							{
								"周",
								text8,
								"不能预约下周",
								text6,
								"的手术！"
							}), "跨周预约提示：");
                            result = false;
                            return result;
                        }
                    }
                    result = true;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }
        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            codeStruc codeStruc = new codeStruc();
            codeStruc = EmrSysPubFunction.openCodeInput("select a.dept_code,a.dept_name,a.input_code from dept_dict a where  a.clinic_attr=0 and a.outp_or_inp=1 ");
            if (codeStruc.codename.Length > 0)
            {
                this.txtDeptName.Text = codeStruc.codename;
                this.txtDeptName.Tag = codeStruc.codeitem;
                this.txtOPERATING_DEPT.Tag = codeStruc.codeitem;
                this.txtOPERATING_DEPT.Text = codeStruc.codename;
                this.FillPatList();
            }
        }
        private void txtfirst_assistant_Leave(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "Ready";
        }
        private void txtsurgeon_Leave_1(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "Ready";
        }
    }
}