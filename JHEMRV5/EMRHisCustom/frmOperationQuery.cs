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
    public partial class frmOperationQuery : Form
    {
        private string m_strDBConnet = "HISConnect";
        private DataTable dtUserDept = new DataTable();
        private DataTable m_objTable = new DataTable();
        public frmOperationQuery()
        {
            InitializeComponent();
        }
        private void frmOperationQuery_Load(object sender, EventArgs e)
        {
            this.FillUserDept();
            DateTime serverNow = EmrSysPubFunction.getServerNow();
            this.dtpStart.Text = serverNow.AddDays(1.0).ToShortDateString() + " 00:00:00";
            this.dtpEnd.Text = serverNow.AddDays(2.0).ToShortDateString() + " 00:00:00";
            this.m_objTable = this.GetTableList(this.txtDeptName.Tag.ToString(), this.dtpStart.Text, this.dtpEnd.Text);
            this.gcOperation.DataSource = this.m_objTable;
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
        public DataTable GetTableList(string strDeptCode, string strStart, string strEnd)
        {
            DataTable dataTable = new DataTable();
            string text = string.Empty;
            text = " SELECT b.SCHEDULED_DATE_TIME,b.OPERATING_ROOM_NO,b.SEQUENCE,b.PATIENT_ID,a.INP_NO,a.NAME,Months_Between(Sysdate, a.DATE_OF_BIRTH),";
            text += " b.DEPT_STAYED,b.DIAG_BEFORE_OPERATION,0 as OPERATION_NO,'' as OPERATION,b.ISOLATION_INDICATOR,b.SURGEON,b.FIRST_ASSISTANT,b.SECOND_ASSISTANT,";
            text += " b.THIRD_ASSISTANT,b.FOURTH_ASSISTANT,b.ANESTHESIA_METHOD,b.ANESTHESIA_DOCTOR,b.ANESTHESIA_ASSISTANT,b.BLOOD_TRAN_DOCTOR,b.BED_NO,";
            text += " b.VISIT_ID,b.SCHEDULE_ID,d.dept_name as OPERATING_ROOM, a.SEX, b.NOTES_ON_OPERATION, b.ACK_INDICATOR,a.DATE_OF_BIRTH,c.group_name  ";
            text += " FROM PAT_MASTER_INDEX a, OPERATION_SCHEDULE b,DEPT_DICT d,staff_group_dict c  ";
            text += " WHERE (d.DEPT_CODE=b.OPERATING_ROOM) AND b.group_code=c.group_code and c.group_class='主诊组' and ";
            string text2 = text;
            text = string.Concat(new string[]
			{
				text2,
				" ( b.PATIENT_ID = a.PATIENT_ID ) and  ( ( b.DEPT_STAYED = '",
				strDeptCode,
				"' ) AND  ( b.SCHEDULED_DATE_TIME >= to_date('",
				strStart,
				"','YYYY-MM-DD HH24:MI:SS') ) AND "
			});
            text = text + "  ( b.SCHEDULED_DATE_TIME <= to_date('" + strEnd + "','YYYY-MM-DD HH24:MI:SS') ) ) ORDER BY b.SCHEDULED_DATE_TIME ASC,b.OPERATING_ROOM_NO ASC,b.SEQUENCE ASC  ";
            DataSet dataSet = new DataSet();
            dataSet = DALUseSpecial.Query(text, this.m_strDBConnet);
            if (dataSet.Tables.Count > 0)
            {
                dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        text = string.Concat(new string[]
						{
							"select * from SCHEDULED_OPERATION_NAME where patient_id='",
							dataRow["patient_id"].ToString(),
							"' and visit_id=",
							dataRow["visit_id"].ToString(),
							" and schedule_id=",
							dataRow["schedule_id"].ToString()
						});
                        DataSet dataSet2 = new DataSet();
                        dataSet2 = DALUseSpecial.Query(text, this.m_strDBConnet);
                        string text3 = string.Empty;
                        if (dataSet2.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow dataRow2 in dataSet2.Tables[0].Rows)
                            {
                                text2 = text3;
                                text3 = string.Concat(new string[]
								{
									text2,
									dataRow2["operation_no"].ToString(),
									".",
									dataRow2["operation"].ToString(),
									" "
								});
                            }
                        }
                        dataRow["operation"] = text3;
                    }
                }
            }
            return dataTable;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.m_objTable = this.GetTableList(this.txtDeptName.Tag.ToString(), this.dtpStart.Text, this.dtpEnd.Text);
            this.gcOperation.DataSource = this.m_objTable;
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
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.gridView1.SelectedRowsCount >= 1)
            {
                DataRow dataRow = this.gridView1.GetDataRow(this.gridView1.GetSelectedRows()[0]);
                if (dataRow["ack_indicator"].ToString() == "1")
                {
                    MessageBox.Show("手术室已确认，不能作废！", "提示：");
                }
                else
                {
                    DateTime dtScheduled = Convert.ToDateTime(dataRow["SCHEDULED_DATE_TIME"].ToString());
                    if (this.OperLimit(dataRow["OPERATING_ROOM"].ToString(), dtScheduled, false))
                    {
                        if (DALUseSpecial.ExecuteSqlTran(new string[]
						{
							string.Concat(new string[]
							{
								"delete from operation_schedule where patient_id = '",
								dataRow["PATIENT_ID"].ToString(),
								"' and visit_id =",
								dataRow["VISIT_ID"].ToString(),
								" and schedule_id = ",
								dataRow["schedule_id"].ToString(),
								""
							}),
							string.Concat(new string[]
							{
								"delete from  scheduled_operation_name where patient_id = '",
								dataRow["PATIENT_ID"].ToString(),
								"' and visit_id =",
								dataRow["VISIT_ID"].ToString(),
								" and schedule_id = ",
								dataRow["schedule_id"].ToString(),
								""
							})
						}, this.m_strDBConnet))
                        {
                            this.btnQuery_Click(sender, e);
                            MessageBox.Show("手术记录删除");
                        }
                    }
                }
            }
        }
        private void gridView1_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                try
                {
                    DataRow dataRow = this.gridView1.GetDataRow(e.RowHandle);
                    if (dataRow["ack_indicator"].ToString() == "0")
                    {
                        string fieldName = e.Column.FieldName;
                        if (fieldName != null)
                        {
                            if (fieldName == "OPERATION")
                            {
                                e.Appearance.ForeColor = Color.FromArgb(255, 0, 0);
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
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridView1.SelectedRowsCount < 1)
            {
                MessageBox.Show("没有选中的行，选中行后再双击该行进行手术确认！");
            }
            else
            {
                DataRow dataRow = this.gridView1.GetDataRow(this.gridView1.GetSelectedRows()[0]);
                if (dataRow["ack_indicator"].ToString() == "1")
                {
                    MessageBox.Show("该手术已经确认！");
                }
                else
                {
                    DateTime dtScheduled = Convert.ToDateTime(dataRow["SCHEDULED_DATE_TIME"].ToString());
                    if (this.OperLimit(dataRow["OPERATING_ROOM"].ToString(), dtScheduled, true))
                    {
                        frmOperationConfirm frmOperationConfirm = new frmOperationConfirm();
                        frmOperationConfirm.SetConfirmInfo(dataRow["NAME"].ToString(), dataRow["PATIENT_ID"].ToString(), dataRow["INP_NO"].ToString(), dataRow["VISIT_ID"].ToString(), dataRow["SCHEDULE_ID"].ToString());
                        if (frmOperationConfirm.ShowDialog() == DialogResult.OK)
                        {
                            this.btnQuery_Click(sender, e);
                        }
                    }
                }
            }
        }
        private DataTable SetScheduleDate(string strOperNameNo)
        {
            DataTable dataTable = new DataTable();
            string sQLString = "select a.limit_time,a.absolute_prohibited_day,a.absolute_prohibited_day_num,a.conditioned_prohibited_day,a.conditioned_prohibited_day_num,a.conditioned_relative_day,a.conditioned_relative_day_num,a.especial_day,a.especial_day_num from set_schedule_date a,dept_dict b where a.operating_room=b.dept_code and b.dept_name='" + strOperNameNo + "' ";
            return DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
        }
        public bool OperLimit(string strOperRoom, DateTime dtScheduled, bool blUpdate)
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
            if (strOperRoom.Length > 0)
            {
                dataTable = this.SetScheduleDate(strOperRoom);
            }
            int num = dtScheduled.DayOfWeek.GetHashCode();
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
            if (dtScheduled.Date < serverNow.AddDays(1.0).Date)
            {
                if (blUpdate)
                {
                    MessageBox.Show("不能修改预约日期少于等于当前日期的手术预约！", "提示：");
                }
                else
                {
                    MessageBox.Show("不能删除预约日期少于等于当前日期的手术预约！", "提示：");
                }
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
                    if (dtScheduled.Date == serverNow.AddDays(1.0).Date)
                    {
                        if (serverNow > t && text.Length > 0)
                        {
                            if (blUpdate)
                            {
                                MessageBox.Show("" + text + "以后不能修改隔日手术预约！", "提示：");
                            }
                            else
                            {
                                MessageBox.Show("" + text + "以后不能删除隔日手术预约！", "提示：");
                            }
                            result = false;
                            return result;
                        }
                    }
                    else
                    {
                        if (dtScheduled.Date > serverNow.AddDays(1.0).Date)
                        {
                            if (text5.IndexOf(num2.ToString()) >= 0 && text7.IndexOf(num.ToString()) >= 0)
                            {
                                if (serverNow > t && text.Length > 0)
                                {
                                    if (blUpdate)
                                    {
                                        MessageBox.Show(string.Concat(new string[]
										{
											"周",
											text4,
											text,
											"以后不能修改下周",
											text6,
											"的手术预约！"
										}), "提示：");
                                    }
                                    else
                                    {
                                        MessageBox.Show(string.Concat(new string[]
										{
											"周",
											text4,
											text,
											"以后不能删除下周",
											text6,
											"的手术预约！"
										}), "提示：");
                                    }
                                    result = false;
                                    return result;
                                }
                            }
                        }
                    }
                    if (text9.IndexOf(num2.ToString()) >= 0 && text7.IndexOf(num.ToString()) >= 0)
                    {
                        if ((dtScheduled - serverNow).Days < 7)
                        {
                            if (blUpdate)
                            {
                                MessageBox.Show(string.Concat(new string[]
								{
									"周",
									text8,
									"不能修改下周",
									text6,
									"的手术预约！"
								}), "跨周预约提示：");
                            }
                            else
                            {
                                MessageBox.Show(string.Concat(new string[]
								{
									"周",
									text8,
									"不能删除下周",
									text6,
									"的手术预约！"
								}), "跨周预约提示：");
                            }
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.m_objTable.Rows.Count >= 1)
            {
                DataTable dataTable = new DataTable();
                for (int i = 0; i <= 1; i++)
                {
                    dataTable.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                }
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = "科室名称";
                dataRow[1] = this.txtDeptName.Text;
                dataTable.Rows.Add(dataRow);
                DataRow dataRow2 = dataTable.NewRow();
                dataRow2[0] = "统计时间";
                dataRow2[1] = Convert.ToDateTime(this.dtpStart.Text).ToString("yyyy年MM月dd日 HH时mm分");
                dataTable.Rows.Add(dataRow2);
                DataRow dataRow3 = dataTable.NewRow();
                dataRow3[0] = "医师";
                dataRow3[1] = EmrSysPubVar.getOperator();
                dataTable.Rows.Add(dataRow3);
                DataTable dataTable2 = new DataTable();
                for (int i = 0; i <= 12; i++)
                {
                    dataTable2.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                }
                foreach (DataRow dataRow4 in this.m_objTable.Rows)
                {
                    DataRow dataRow5 = dataTable2.NewRow();
                    dataRow5[0] = dataRow4["OPERATING_ROOM_NO"].ToString();
                    dataRow5[1] = Convert.ToDateTime(dataRow4["SCHEDULED_DATE_TIME"].ToString()).ToString("HH:mm");
                    dataRow5[2] = dataRow4["NAME"].ToString();
                    dataRow5[3] = dataRow4["INP_NO"].ToString();
                    dataRow5[4] = dataRow4["BED_NO"].ToString();
                    dataRow5[5] = dataRow4["SEX"].ToString();
                    dataRow5[6] = EmrSysPubFunction.GetAge(Convert.ToDateTime(dataRow4["SCHEDULED_DATE_TIME"].ToString()), Convert.ToDateTime(dataRow4["DATE_OF_BIRTH"].ToString()));
                    dataRow5[7] = ((dataRow4["DIAG_BEFORE_OPERATION"] == DBNull.Value) ? " " : dataRow4["DIAG_BEFORE_OPERATION"].ToString());
                    dataRow5[8] = ((dataRow4["OPERATION"] == DBNull.Value) ? " " : dataRow4["OPERATION"].ToString());
                    string str = (dataRow4["SURGEON"] == DBNull.Value) ? "" : dataRow4["SURGEON"].ToString();
                    string text = (dataRow4["FIRST_ASSISTANT"] == DBNull.Value) ? "" : dataRow4["FIRST_ASSISTANT"].ToString();
                    string text2 = (dataRow4["SECOND_ASSISTANT"] == DBNull.Value) ? "" : dataRow4["SECOND_ASSISTANT"].ToString();
                    string text3 = (dataRow4["THIRD_ASSISTANT"] == DBNull.Value) ? "" : dataRow4["THIRD_ASSISTANT"].ToString();
                    if (text.Length > 0)
                    {
                        text = "、" + text;
                    }
                    if (text2.Length > 0)
                    {
                        text2 = "、" + text2;
                    }
                    if (text3.Length > 0)
                    {
                        text3 = "、" + text3;
                    }
                    dataRow5[9] = str + text + text2 + text3;
                    dataRow5[10] = ((dataRow4["ANESTHESIA_METHOD"] == DBNull.Value) ? "" : dataRow4["ANESTHESIA_METHOD"].ToString());
                    dataRow5[11] = dataRow4["NOTES_ON_OPERATION"].ToString();
                    dataRow5[12] = " ";
                    dataTable2.Rows.Add(dataRow5);
                }
                frmPrint frmPrint = new frmPrint();
                frmPrint.PrintOperation("手术通知", dataTable, dataTable2);
            }
        }
        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            codeStruc codeStruc = new codeStruc();
            codeStruc = EmrSysPubFunction.openCodeInput("select a.dept_code,a.dept_name,a.input_code from dept_dict a where  a.clinic_attr=0 and a.outp_or_inp=1 and a.internal_or_sergery in ('0','1')");
            if (codeStruc.codename.Length > 0)
            {
                this.txtDeptName.Text = codeStruc.codename;
                this.txtDeptName.Tag = codeStruc.codeitem;
            }
            else
            {
                this.txtDeptName.Text = "";
                this.txtDeptName.Tag = "";
            }
        }
    }
}