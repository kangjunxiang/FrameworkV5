using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmPatientPreOut : DevExpress.XtraEditors.XtraForm
    {
        private string m_strDBConnet = "HISConnect";
        private DataTable m_dtUserDept = new DataTable();
        private DataTable m_dtUserWard = new DataTable();
        private BaseEdit m_gridViewActiveEditor = null;
        private DataTable m_dtOut = new DataTable();
        public frmPatientPreOut()
        {
            InitializeComponent();
        }
        private void frmPatientPreOut_Load(object sender, EventArgs e)
        {
            this.FillUserDept();
            this.FillDvOut();
        }
        private void FillDvOut()
        {
            if (this.cmbDept.Text.Length > 0)
            {
                string sQLString = "SELECT b.DISCHARGE_DATE_EXPCTED,a.NAME,a.SEX,c.DIAGNOSIS,c.ADMISSION_DATE_TIME, b.CREATE_DATE_TIME,b.PATIENT_ID,d.BED_LABEL,d.BED_NO,c.WARD_CODE FROM PAT_MASTER_INDEX a,PRE_DISCHGED_PATS b,PATS_IN_HOSPITAL c,BED_REC d   WHERE ( a.PATIENT_ID = b.PATIENT_ID ) and ( b.PATIENT_ID = c.PATIENT_ID ) and  ( c.WARD_CODE = d.WARD_CODE ) and ( c.BED_NO = d.BED_NO ) and ( ( c.WARD_CODE = '" + this.cmbDept.Tag.ToString() + "' ) )";
                this.m_dtOut = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                this.gcOUT.DataSource = this.m_dtOut;
            }
        }
        private void FillUserDept()
        {
            this.m_dtUserWard.Columns.Add("WARD_CODE");
            this.m_dtUserWard.Columns.Add("WARD_NAME");
            DataSet dataSet = new DataSet();
            string text = "SELECT USER_DEPT,DEPT_NAME,DEFAULT_DEPT_FLAG FROM USER_DEPT a, DEPT_DICT b  ";
            text = text + " WHERE a.USER_DEPT=b.DEPT_CODE AND  a.USER_ID='" + EmrSysPubVar.getUserID() + "' ORDER BY DEPT_NAME";
            dataSet = DALUse.Query(text);
            if (dataSet.Tables.Count > 0)
            {
                this.m_dtUserDept = dataSet.Tables[0];
                foreach (DataRow dataRow in this.m_dtUserDept.Rows)
                {
                    DataTable tableByDept = this.GetTableByDept(dataRow["USER_DEPT"].ToString());
                    if (tableByDept.Rows.Count > 0)
                    {
                        DataRow dataRow2 = this.m_dtUserWard.NewRow();
                        dataRow2["WARD_CODE"] = tableByDept.Rows[0]["ward_code"].ToString();
                        dataRow2["WARD_NAME"] = tableByDept.Rows[0]["dept_name"].ToString();
                        this.cmbDept.Items.Add(tableByDept.Rows[0]["dept_name"].ToString());
                        this.m_dtUserWard.Rows.Add(dataRow2);
                    }
                }
                DataTable tableByDept2 = this.GetTableByDept(EmrSysPubVar.getDeptCode());
                if (tableByDept2.Rows.Count > 0)
                {
                    this.cmbDept.Text = tableByDept2.Rows[0]["dept_name"].ToString();
                    this.cmbDept.Tag = tableByDept2.Rows[0]["ward_code"].ToString();
                }
            }
        }
        private DataTable GetTableByDept(string strDeptCode)
        {
            string sQLString = "select a.ward_code,b.dept_name from dept_vs_ward a,dept_dict b where b.dept_code=a.ward_code and a.dept_code='" + strDeptCode + "'";
            return DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
        }
        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_dtUserWard != null)
            {
                if (this.m_dtUserWard.IsInitialized)
                {
                    if (this.m_dtUserWard.Rows.Count > this.cmbDept.SelectedIndex)
                    {
                        DataRow dataRow = this.m_dtUserWard.Rows[this.cmbDept.SelectedIndex];
                        this.cmbDept.Tag = dataRow["WARD_CODE"].ToString();
                        this.FillDvOut();
                    }
                }
            }
        }
        private void gvOUT_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void gvOUT_HiddenEditor(object sender, EventArgs e)
        {
            if (this.m_gridViewActiveEditor != null)
            {
                this.m_gridViewActiveEditor.KeyDown -= new KeyEventHandler(this.gvOUT_KeyDown);
                this.m_gridViewActiveEditor = null;
            }
        }
        private void gvOUT_ShownEditor(object sender, EventArgs e)
        {
            if (this.gvOUT.ActiveEditor != null && this.m_gridViewActiveEditor == null)
            {
                this.m_gridViewActiveEditor = this.gvOUT.ActiveEditor;
                this.m_gridViewActiveEditor.KeyDown += new KeyEventHandler(this.gvOUT_KeyDown);
            }
        }
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            this.sbtnSave_Click(sender, e);
            base.Close();
        }
        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            DataRow dataRow = this.m_dtOut.NewRow();
            dataRow["BED_LABEL"] = "";
            dataRow["DISCHARGE_DATE_EXPCTED"] = EmrSysPubFunction.getServerNow().AddDays(1.0).ToShortDateString() + " 09:30";
            dataRow["NAME"] = "";
            dataRow["SEX"] = "";
            dataRow["PATIENT_ID"] = "";
            dataRow["DIAGNOSIS"] = "";
            dataRow["ADMISSION_DATE_TIME"] = DBNull.Value;
            this.m_dtOut.Rows.Add(dataRow);
            this.gvOUT.ClearSelection();
            this.gvOUT.MakeRowVisible(this.m_dtOut.Rows.Count - 1, false);
            this.gvOUT.SelectRow(this.m_dtOut.Rows.Count - 1);
            this.gvOUT.FocusedRowHandle = this.m_dtOut.Rows.Count - 1;
            this.gvOUT.FocusedColumn = this.gvOUT.Columns["BED_LABEL"];
            this.gvOUT.Focus();
        }
        private void sbtnDel_Click(object sender, EventArgs e)
        {
            if (this.m_dtOut.Rows.Count != 0)
            {
                int focusedRowHandle = this.gvOUT.FocusedRowHandle;
                if (focusedRowHandle >= 0)
                {
                    this.m_dtOut.Rows.RemoveAt(focusedRowHandle);
                }
            }
        }
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in this.m_dtOut.Rows)
            {
                if (dataRow["BED_LABEL"].ToString().Length < 1)
                {
                    MessageBox.Show("请输入正确的床号。 ");
                    return;
                }
                string sQLString = string.Concat(new string[]
				{
					"Select bed_no FROM bed_rec WHERE ward_Code='",
					this.cmbDept.Tag.ToString(),
					"' and bed_label='",
					dataRow["BED_LABEL"].ToString(),
					"'"
				});
                DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                string str = string.Empty;
                if (dataTable.Rows.Count > 0)
                {
                    str = dataTable.Rows[0]["bed_no"].ToString();
                }
                else
                {
                    str = dataRow["BED_LABEL"].ToString();
                }
                sQLString = "SELECT  patient_id,Admission_Date_Time,diagnosis  FROM pats_in_hospital WHERE Ward_code='" + this.cmbDept.Tag.ToString() + "' AND bed_no=" + str;
                dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (dataTable.Rows.Count < 1)
                {
                    MessageBox.Show("请输入正确的床号。");
                    return;
                }
            }
            foreach (DataRow dataRow in this.m_dtOut.Rows)
            {
                string sQLString = string.Empty;
                sQLString = "select * from PRE_DISCHGED_PATS where patient_id='" + dataRow["PATIENT_ID"].ToString() + "'";
                DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    sQLString = string.Concat(new string[]
					{
						"update pre_dischged_pats set discharge_date_expcted=TO_DATE('",
						dataRow["discharge_date_expcted"].ToString(),
						"','YYYY-MM-DD HH24:MI:SS') where patient_id='",
						dataRow["patient_id"].ToString(),
						"'"
					});
                }
                else
                {
                    sQLString = string.Concat(new string[]
					{
						"INSERT INTO pre_dischged_pats(patient_id,discharge_date_expcted,create_date_time) VALUES ('",
						dataRow["PATIENT_ID"].ToString(),
						"',TO_DATE('",
						dataRow["discharge_date_expcted"].ToString(),
						"','YYYY-MM-DD HH24:MI:SS'),sysdate)"
					});
                }
                DALUseSpecial.ExecuteSql(sQLString, this.m_strDBConnet);
            }
        }
        private void gvOUT_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                try
                {
                    DataRow dataRow = this.gvOUT.GetDataRow(e.RowHandle);
                    if (!this.gvOUT.IsRowSelected(e.RowHandle))
                    {
                        string fieldName = e.Column.FieldName;
                        if (fieldName != null)
                        {
                            if (!(fieldName == "NAME"))
                            {
                                if (!(fieldName == "SEX"))
                                {
                                    if (!(fieldName == "PATIENT_ID"))
                                    {
                                        if (!(fieldName == "DIAGNOSIS"))
                                        {
                                            if (fieldName == "ADMISSION_DATE_TIME")
                                            {
                                                e.Appearance.BackColor = Color.Gray;
                                            }
                                        }
                                        else
                                        {
                                            e.Appearance.BackColor = Color.Gray;
                                        }
                                    }
                                    else
                                    {
                                        e.Appearance.BackColor = Color.Gray;
                                    }
                                }
                                else
                                {
                                    e.Appearance.BackColor = Color.Gray;
                                }
                            }
                            else
                            {
                                e.Appearance.BackColor = Color.Gray;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
            }
        }
        private void gvOUT_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            int focusedRowHandle = this.gvOUT.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                DataRow dataRow = this.gvOUT.GetDataRow(focusedRowHandle);
                string text = e.Column.FieldName.ToUpper();
                if (text != null)
                {
                    if (text == "BED_LABEL")
                    {
                        string str = string.Empty;
                        string text2 = string.Empty;
                        string value = string.Empty;
                        string value2 = string.Empty;
                        if (dataRow["BED_LABEL"].ToString().Length < 1)
                        {
                            MessageBox.Show("床号不能为空！");
                        }
                        else
                        {
                            string sQLString = string.Concat(new string[]
							{
								"Select bed_no FROM bed_rec WHERE ward_Code='",
								this.cmbDept.Tag.ToString(),
								"' and bed_label='",
								dataRow["BED_LABEL"].ToString(),
								"'"
							});
                            DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                            if (dataTable.Rows.Count > 0)
                            {
                                str = dataTable.Rows[0]["bed_no"].ToString();
                            }
                            else
                            {
                                str = dataRow["BED_LABEL"].ToString();
                            }
                            sQLString = "SELECT  patient_id,Admission_Date_Time,diagnosis  FROM pats_in_hospital WHERE Ward_code='" + this.cmbDept.Tag.ToString() + "' AND bed_no=" + str;
                            dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                            if (dataTable.Rows.Count < 1)
                            {
                                MessageBox.Show("该床无病人。");
                            }
                            else
                            {
                                text2 = dataTable.Rows[0]["patient_id"].ToString();
                                value = dataTable.Rows[0]["diagnosis"].ToString();
                                value2 = dataTable.Rows[0]["Admission_Date_Time"].ToString();
                                for (int i = 0; i < this.m_dtOut.Rows.Count; i++)
                                {
                                    if (i != focusedRowHandle)
                                    {
                                        if (text2 == this.m_dtOut.Rows[i]["PATIENT_ID"].ToString())
                                        {
                                            MessageBox.Show("该床病人已经录入。");
                                            this.m_dtOut.Rows.RemoveAt(focusedRowHandle);
                                            return;
                                        }
                                    }
                                }
                                sQLString = "SELECT name,sex FROM pat_master_index where  patient_id='" + text2 + "'";
                                dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                                dataRow["NAME"] = dataTable.Rows[0]["name"].ToString();
                                dataRow["SEX"] = dataTable.Rows[0]["sex"].ToString();
                                dataRow["DIAGNOSIS"] = value;
                                dataRow["ADMISSION_DATE_TIME"] = value2;
                                dataRow["PATIENT_ID"] = text2;
                            }
                        }
                    }
                }
            }
        }
    }
}