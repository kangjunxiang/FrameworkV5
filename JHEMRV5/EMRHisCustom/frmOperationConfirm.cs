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
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmOperationConfirm : Form
    {
        private string m_strDBConnet = "HISConnect";
        private string m_strNAME;
        private string m_strPATIENT_ID;
        private string m_strINP_NO;
        private string m_strVISIT_ID;
        private string m_strSCHEDULE_ID;
        private DataTable objTable;
        private BaseEdit m_gridViewActiveEditor = null;
        private DataTable m_dtPyInputDict = new DataTable();
        private DataTable dtRoom = new DataTable();
        private DataTable m_dtName = new DataTable();
        private DataTable m_dtGroup = new DataTable();
        private string strAllOperRoom = string.Empty;
        private bool blOperRoom = false;
        private string strAllDeptDict = string.Empty;
        private bool blDeptDict = true;
        private int IOperRoom = 0;
        private int IOperDept = 0;
        public void SetConfirmInfo(string strNAME, string strPATIENT_ID, string strINP_NO, string strVISIT_ID, string strSCHEDULE_ID)
        {
            this.m_strNAME = strNAME;
            this.m_strPATIENT_ID = strPATIENT_ID;
            this.m_strINP_NO = strINP_NO;
            this.m_strVISIT_ID = strVISIT_ID;
            this.m_strSCHEDULE_ID = strSCHEDULE_ID;
        }
        public frmOperationConfirm()
        {
            this.InitializeComponent();
        }
        private void frmOperationConfirm_Load(object sender, EventArgs e)
        {
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
            this.txtName.Text = this.m_strNAME;
            this.txtINP_NO.Text = this.m_strINP_NO;
            this.txtPatID.Text = this.m_strPATIENT_ID;
            this.FillRoom();
            this.FillAnaesthesiaMethod();
            this.FillOperationInfo();
            this.FillPyInputDict();
        }
        private void FillPyInputDict()
        {
            string sQLString = "select INPUT_CODE,OPERATION_NAME as ITEM_NAME,operation_scale from operation_dict";
            this.m_dtPyInputDict = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            this.gridPYInput.DataSource = this.m_dtPyInputDict;
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
        private void FillOperationInfo()
        {
            string sQLString = string.Empty;
            sQLString = string.Concat(new string[]
			{
				"select * FROM OPERATION_SCHEDULE a  where ( a.PATIENT_ID = '",
				this.m_strPATIENT_ID,
				"' ) AND ( a.VISIT_ID = ",
				this.m_strVISIT_ID,
				" ) AND a.SCHEDULE_ID =",
				this.m_strSCHEDULE_ID
			});
            DataSet dataSet = new DataSet();
            dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                DataRow dataRow = dataSet.Tables[0].Rows[0];
                if (dataRow["diag_before_operation"] != DBNull.Value)
                {
                    this.txtdiag_before_operation.Text = dataRow["diag_before_operation"].ToString();
                }
                if (dataRow["patient_condition"] != DBNull.Value)
                {
                    this.txtpatient_condition.Text = dataRow["patient_condition"].ToString();
                }
                if (dataRow["scheduled_date_time"] != DBNull.Value)
                {
                    this.dtpscheduled_date_time.Text = dataRow["scheduled_date_time"].ToString();
                }
                if (dataRow["operating_room"] != DBNull.Value)
                {
                    this.cmboperating_room.Tag = dataRow["operating_room"].ToString();
                    this.cmboperating_room.Text = this.getDeptName(dataRow["operating_room"].ToString());
                    if (this.strAllOperRoom.IndexOf(dataRow["operating_room"].ToString()) >= 0)
                    {
                        this.blOperRoom = true;
                    }
                }
                if (dataRow["operating_room_no"] != DBNull.Value)
                {
                    this.cmboperating_room_no.Text = dataRow["operating_room_no"].ToString();
                }
                if (dataRow["sequence"] != DBNull.Value)
                {
                    this.txtsequence.Text = dataRow["sequence"].ToString();
                }
                if (dataRow["isolation_indicator"] != DBNull.Value)
                {
                    this.cmbisolation_indicator.SelectedIndex = Convert.ToInt32(dataRow["isolation_indicator"].ToString()) - 1;
                }
                if (dataRow["operation_scale"] != DBNull.Value)
                {
                    this.cmboperation_scale.Text = dataRow["operation_scale"].ToString();
                }
                if (dataRow["surgeon"] != DBNull.Value)
                {
                    this.txtsurgeon.Text = dataRow["surgeon"].ToString();
                }
                if (dataRow["SURGEON_NO"] != DBNull.Value)
                {
                    this.txtsurgeon.Tag = dataRow["SURGEON_NO"].ToString();
                }
                if (dataRow["first_assistant"] != DBNull.Value)
                {
                    this.txtfirst_assistant.Text = dataRow["first_assistant"].ToString();
                }
                if (dataRow["FS_NO"] != DBNull.Value)
                {
                    this.txtfirst_assistant.Tag = dataRow["FS_NO"].ToString();
                }
                if (dataRow["second_assistant"] != DBNull.Value)
                {
                    this.txtsecond_assistant.Text = dataRow["second_assistant"].ToString();
                }
                if (dataRow["third_assistant"] != DBNull.Value)
                {
                    this.txtthird_assistant.Text = dataRow["third_assistant"].ToString();
                }
                if (dataRow["fourth_assistant"] != DBNull.Value)
                {
                    this.txtfourth_assistant.Text = dataRow["fourth_assistant"].ToString();
                }
                if (dataRow["blood_tran_doctor"] != DBNull.Value)
                {
                    this.txtblood_tran_doctor.Text = dataRow["blood_tran_doctor"].ToString();
                }
                if (dataRow["anesthesia_method"] != DBNull.Value)
                {
                    this.cmbanesthesia_method.Text = dataRow["anesthesia_method"].ToString();
                }
                if (dataRow["req_date_time"] != DBNull.Value)
                {
                    this.txtpreq_date_time.Text = dataRow["req_date_time"].ToString();
                }
                if (dataRow["notes_on_operation"] != DBNull.Value)
                {
                    this.txtnotes_on_operation.Text = dataRow["notes_on_operation"].ToString();
                }
                if (dataRow["entered_by"] != DBNull.Value)
                {
                    this.txtentered_by.Text = dataRow["entered_by"].ToString();
                }
                if (dataRow["operating_dept"] != DBNull.Value)
                {
                    this.txtOPERATING_DEPT.Tag = dataRow["operating_dept"].ToString();
                    this.txtOPERATING_DEPT.Text = this.getDeptName(dataRow["operating_dept"].ToString());
                    this.cmbGroup.Items.Clear();
                    if (this.txtOPERATING_DEPT.Tag != null)
                    {
                        if (this.txtOPERATING_DEPT.Tag.ToString().Length >= 4)
                        {
                            if (this.strAllDeptDict.IndexOf(this.txtOPERATING_DEPT.Tag.ToString().Substring(0, 4)) >= 0)
                            {
                                this.blDeptDict = false;
                            }
                            sQLString = "select * from staff_group_dict where group_class='主诊组' and group_code like '" + this.txtOPERATING_DEPT.Tag.ToString().Substring(0, 4) + "%'";
                            this.m_dtGroup = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                            if (this.m_dtGroup.Rows.Count > 0)
                            {
                                foreach (DataRow dataRow2 in this.m_dtGroup.Rows)
                                {
                                    this.cmbGroup.Items.Add(dataRow2["group_name"].ToString());
                                }
                            }
                        }
                    }
                }
                if (dataRow["group_code"] != DBNull.Value)
                {
                    this.cmbGroup.Tag = dataRow["group_code"].ToString();
                    DataRow[] array = this.m_dtGroup.Select("group_code='" + dataRow["group_code"].ToString() + "'");
                    for (int i = 0; i < array.Length; i++)
                    {
                        DataRow dataRow3 = array[i];
                        this.cmbGroup.Text = dataRow3["group_name"].ToString();
                    }
                }
            }
            sQLString = string.Concat(new string[]
			{
				"select OPERATION,OPERATION_SCALE FROM SCHEDULED_OPERATION_NAME a where ( a.PATIENT_ID = '",
				this.m_strPATIENT_ID,
				"' ) AND ( a.VISIT_ID = ",
				this.m_strVISIT_ID,
				" ) AND a.SCHEDULE_ID =",
				this.m_strSCHEDULE_ID,
				" order by a.OPERATION_NO"
			});
            this.m_dtName = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            this.gcOperaion.DataSource = this.m_dtName;
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
        private string getDeptName(string strDeptCode)
        {
            string sQLString = string.Empty;
            sQLString = "select dept_name from dept_dict where dept_code='" + strDeptCode + "'";
            string result;
            try
            {
                DataSet dataSet = DALUseSpecial.Query(sQLString, this.m_strDBConnet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    result = dataSet.Tables[0].Rows[0]["dept_name"].ToString();
                    return result;
                }
            }
            catch (Exception ex)
            {
                string text = ex.ToString();
            }
            result = "";
            return result;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            DataRow dataRow = this.m_dtName.NewRow();
            dataRow["OPERATION"] = "";
            dataRow["OPERATION_SCALE"] = "";
            this.m_dtName.Rows.Add(dataRow);
        }
        private void txtsurgeon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.panel3.Controls)
                {
                    if (control.Name == "input")
                    {
                        e.KeyChar = '\0';
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel3.Controls, (TextBox)sender);
                instance.loadData("USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                instance.Name = "input";
                this.panel3.Controls.Add(instance);
                this.panel3.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel3.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X + 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel3.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
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
                foreach (Control control in this.panel3.Controls)
                {
                    if (control.Name == "input")
                    {
                        e.KeyChar = '\0';
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel3.Controls, (TextBox)sender);
                if (this.blOperRoom && this.blDeptDict)
                {
                    instance.loadData("OPER_USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                }
                else
                {
                    instance.loadData("USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                }
                instance.Name = "input";
                this.panel3.Controls.Add(instance);
                this.panel3.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel3.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X + 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel3.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                e.KeyChar = '\0';
                instance.filter();
            }
        }
        private void txtsurgeon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.panel3.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel3.Controls, (TextBox)sender);
                instance.loadData("USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                instance.Name = "input";
                this.panel3.Controls.Add(instance);
                this.panel3.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel3.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel3.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtsurgeon1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                ((TextBox)sender).Text = "";
                foreach (Control control in this.panel3.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel3.Controls, (TextBox)sender);
                if (this.blOperRoom && this.blDeptDict)
                {
                    instance.loadData("OPER_USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                }
                else
                {
                    instance.loadData("USER", this.txtOPERATING_DEPT.Tag.ToString(), "");
                }
                instance.Name = "input";
                this.panel3.Controls.Add(instance);
                this.panel3.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel3.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel3.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtdiag_before_operation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                this.txtdiag_before_operation.Text = "";
                foreach (Control control in base.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(base.Controls, (TextBox)sender);
                instance.loadData("DIAGNOSIS", "DIAGNOSIS", "");
                instance.Name = "input";
                base.Controls.Add(instance);
                base.Controls.SetChildIndex(instance, 0);
                instance.Location = new Point(((TextBox)sender).Location.X, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                instance.filter();
            }
        }
        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            if (this.gvOperation.SelectedRowsCount > 0)
            {
                this.m_dtName.Rows.RemoveAt(this.gvOperation.FocusedRowHandle);
            }
        }
        private void gvOperation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                this.panelPYInput.Visible = true;
                this.panelPYInput.BringToFront();
                this.txtInPut.Text = "";
                this.txtInPut.Focus();
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
        private void setCellValueByPYInput(string strValue, string strScale)
        {
            if (this.m_dtName.Rows.Count >= 0)
            {
                this.m_dtName.Rows[this.gvOperation.FocusedRowHandle]["operation"] = strValue;
                this.m_dtName.Rows[this.gvOperation.FocusedRowHandle]["OPERATION_SCALE"] = strScale;
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
                        this.setCellValueByPYInput(dataRow["ITEM_NAME"].ToString(), dataRow["OPERATION_SCALE"].ToString());
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
                    this.m_dtPyInputDict.DefaultView.RowFilter = "INPUT_CODE like '" + this.txtInPut.Text.Replace("'", "''").ToUpper() + "%'";
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
        private void txtdiag_before_operation_Enter(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "按F9调用拼音诊断字典操作";
        }
        private void txtdiag_before_operation_Leave(object sender, EventArgs e)
        {
            this.tlstatusBottom.Text = "Ready";
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
                this.setCellValueByPYInput(dataRow["ITEM_NAME"].ToString(), dataRow["operation_scale"].ToString());
                this.panelPYInput.Visible = false;
                this.gvOperation.Focus();
            }
        }
        private void txtdiag_before_operation_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            int num = 0;
            if (this.gvOperation.RowCount > 0)
            {
                for (int i = 0; i < this.gvOperation.RowCount; i++)
                {
                    if (this.gvOperation.GetDataRow(i)["OPERATION"] != DBNull.Value)
                    {
                        if (this.gvOperation.GetDataRow(i)["OPERATION"].ToString().Trim() != "")
                        {
                            num++;
                        }
                    }
                }
            }
            if (this.txtoperating_room.Text.Length < 1)
            {
                MessageBox.Show("手术室不能为空！", "提示：");
            }
            else
            {
                if (this.OperLimit())
                {
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
                                    string text = string.Empty;
                                    text = string.Concat(new string[]
									{
										"update OPERATION_SCHEDULE set SCHEDULED_DATE_TIME=to_date('",
										this.dtpscheduled_date_time.Text,
										"','YYYY-MM-DD HH24:MI'),OPERATING_ROOM='",
										this.txtoperating_room.Tag.ToString(),
										"',OPERATING_ROOM_NO='",
										this.cmboperating_room_no.Text,
										"',SEQUENCE='",
										this.txtsequence.Text,
										"',DIAG_BEFORE_OPERATION='",
										this.txtdiag_before_operation.Text,
										"',PATIENT_CONDITION='",
										this.txtpatient_condition.Text.Replace("'", "''"),
										"',OPERATION_SCALE='",
										this.cmboperation_scale.Text,
										"',operating_dept='",
										this.txtOPERATING_DEPT.Tag.ToString(),
										"',isolation_indicator='",
										this.cmbisolation_indicator.Text.Equals("") ? "" : Convert.ToString(this.cmbisolation_indicator.SelectedIndex + 1),
										"',surgeon='",
										this.txtsurgeon.Text,
										"',first_assistant='",
										this.txtfirst_assistant.Text,
										"',second_assistant='",
										this.txtsecond_assistant.Text,
										"',third_assistant='",
										this.txtthird_assistant.Text,
										"',fourth_assistant='",
										this.txtfourth_assistant.Text,
										"',anesthesia_method='",
										this.cmbanesthesia_method.Text,
										"',entered_by='",
										this.txtentered_by.Text,
										"',notes_on_operation='",
										this.txtnotes_on_operation.Text.Replace("'", "''"),
										"',blood_tran_doctor='",
										this.txtblood_tran_doctor.Text,
										"',group_code='",
										(this.cmbGroup.Tag == null) ? "" : this.cmbGroup.Tag.ToString(),
										"' "
									});
                                    string text2;
                                    if (this.blOperRoom && this.blDeptDict)
                                    {
                                        text2 = text;
                                        text = string.Concat(new string[]
										{
											text2,
											",SURGEON_NO='",
											this.txtsurgeon.Tag.ToString(),
											"',FS_NO='",
											this.txtfirst_assistant.Tag.ToString(),
											"' "
										});
                                    }
                                    text2 = text;
                                    text = string.Concat(new string[]
									{
										text2,
										" where patient_id='",
										this.m_strPATIENT_ID,
										"' and visit_id=",
										this.m_strVISIT_ID,
										" and schedule_id=",
										this.m_strSCHEDULE_ID
									});
                                    DALUseSpecial.ExecuteSql(text, this.m_strDBConnet);
                                    text = string.Concat(new string[]
									{
										"delete from SCHEDULED_OPERATION_NAME where patient_id='",
										this.m_strPATIENT_ID,
										"' and visit_id=",
										this.m_strVISIT_ID,
										" and schedule_id=",
										this.m_strSCHEDULE_ID
									});
                                    DALUseSpecial.ExecuteSql(text, this.m_strDBConnet);
                                    string[] array = new string[num];
                                    for (int i = 0; i < this.gvOperation.RowCount; i++)
                                    {
                                        if (this.gvOperation.GetDataRow(i)["OPERATION"].ToString().Trim() != "")
                                        {
                                            array[i] = string.Concat(new string[]
											{
												"insert into SCHEDULED_OPERATION_NAME(patient_id,visit_id,SCHEDULE_ID,operation_no,operation,operation_scale) values('",
												this.m_strPATIENT_ID,
												"',",
												this.m_strVISIT_ID,
												",",
												this.m_strSCHEDULE_ID,
												",",
												Convert.ToString(i + 1),
												",'",
												this.gvOperation.GetDataRow(i)["OPERATION"].ToString(),
												"','",
												this.gvOperation.GetDataRow(i)["operation_scale"].ToString(),
												"')"
											});
                                        }
                                    }
                                    DALUseSpecial.ExecuteSqlTran(array, this.m_strDBConnet);
                                    base.DialogResult = DialogResult.OK;
                                }
                            }
                        }
                    }
                }
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
                DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        this.cmboperating_room_no.Items.Add(dataRow["ROOM_NO"].ToString());
                    }
                }
            }
        }
        private void gridViewPYInput_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtOPERATING_DEPT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                this.txtOPERATING_DEPT.Text = "";
                foreach (Control control in this.panel3.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel3.Controls, (TextBox)sender);
                instance.loadData("DEPT", "DEPT", "");
                instance.Name = "input";
                this.panel3.Controls.Add(instance);
                this.panel3.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel3.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel3.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
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
                if (this.IOperRoom > 0)
                {
                    this.txtsurgeon.Text = "";
                    this.txtsurgeon.Tag = null;
                    this.txtfirst_assistant.Text = "";
                    this.txtfirst_assistant.Tag = null;
                }
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
            this.IOperRoom++;
        }
        private void txtOPERATING_DEPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                this.txtOPERATING_DEPT.Text = "";
                foreach (Control control in this.panel3.Controls)
                {
                    if (control.Name == "input")
                    {
                        e.KeyChar = '\0';
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panel3.Controls, (TextBox)sender);
                instance.loadData("DEPT", "DEPT", "");
                instance.Name = "input";
                this.panel3.Controls.Add(instance);
                this.panel3.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panel3.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X + 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panel3.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                e.KeyChar = '\0';
                instance.filter();
            }
        }
        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            base.Close();
        }
        private DataTable SetScheduleDate(string strOperNameNo)
        {
            DataTable dataTable = new DataTable();
            string sQLString = "select a.limit_time,a.absolute_prohibited_day,a.absolute_prohibited_day_num,a.conditioned_prohibited_day,a.conditioned_prohibited_day_num,a.conditioned_relative_day,a.conditioned_relative_day_num,a.especial_day,a.especial_day_num from set_schedule_date a,dept_dict b where a.operating_room=b.dept_code and b.dept_name='" + strOperNameNo + "' ";
            return DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
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
            DataTable dataTable = new DataTable();
            if (this.txtOPERATING_DEPT.Text.ToString().Trim().Length > 0)
            {
                dataTable = this.SetScheduleDate(this.txtOPERATING_DEPT.Text);
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
        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbGroup.Tag = this.m_dtGroup.Rows[this.cmbGroup.SelectedIndex]["group_code"].ToString();
        }
        private void txtOPERATING_DEPT_TextChanged(object sender, EventArgs e)
        {
            this.cmbGroup.Items.Clear();
            if (this.txtOPERATING_DEPT.Tag != null)
            {
                if (this.txtOPERATING_DEPT.Tag.ToString().Length >= 4)
                {
                    string sQLString = "select * from staff_group_dict where group_class='主诊组'  and valid=1 and group_code like '" + this.txtOPERATING_DEPT.Tag.ToString().Substring(0, 4) + "%'";
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
            if (this.IOperDept > 0)
            {
                this.txtsurgeon.Text = "";
                this.txtsurgeon.Tag = null;
                this.txtfirst_assistant.Text = "";
                this.txtfirst_assistant.Tag = null;
                this.txtsecond_assistant.Text = "";
                this.txtthird_assistant.Text = "";
                this.txtfourth_assistant.Text = "";
            }
            this.IOperDept++;
        }
        private void txtsurgeon_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtfirst_assistant_TextChanged(object sender, EventArgs e)
        {
        }
    }
}