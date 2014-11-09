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
    public partial class frmHisCustomExamQuery : DevExpress.XtraEditors.XtraForm
    {
        private DataTable m_dtApplyExam = new DataTable();
        private string m_strDBConnet = "HISConnect";
        private DataTable m_dtInfo = new DataTable();
        private DataTable m_dtExam = new DataTable();
        public frmHisCustomExamQuery()
        {
            InitializeComponent();
        }
        private void frmHisCustomExamQuery_Load(object sender, EventArgs e)
        {
            this.dtpStart.Text = EmrSysPubFunction.getServerNow().AddDays(-30.0).ToString();
            this.dtpEnd.Text = EmrSysPubFunction.getServerNow().AddDays(1.0).ToString();
            this.UpdateApllyExam();
            for (int i = 0; i <= 1; i++)
            {
                this.m_dtInfo.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                this.m_dtExam.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
            }
        }
        private void UpdateApllyExam()
        {
            string sQLString = string.Concat(new string[]
			{
				"SELECT a.PATIENT_ID,a.NAME,a.EXAM_NO,a.REQ_DATE_TIME,a.SCHEDULED_DATE,a.EXAM_SUB_CLASS,b.EXAM_ITEM_NO,b.COSTS, b.EXAM_ITEM,a.SEX,a.DATE_OF_BIRTH,a.CHARGE_TYPE,a.MAILING_ADDRESS,a.ZIP_CODE,a.PHONE_NUMBER,a.CLIN_DIAG,a.CLIN_SYMP, a.PHYS_SIGN,a.RELEVANT_LAB_TEST,a.RELEVANT_DIAG,a.REQ_PHYSICIAN,a.REQ_DEPT,a.EXAM_CLASS  FROM EXAM_APPOINTS a, EXAM_ITEMS b   WHERE ( a.EXAM_NO = b.EXAM_NO ) and ( ( a.REQ_DATE_TIME >= TO_DATE('",
				this.dtpStart.Text,
				"','YYYY-MM-DD HH24:MI:SS') ) AND   ( a.REQ_DATE_TIME <= TO_DATE('",
				this.dtpEnd.Text,
				"','YYYY-MM-DD HH24:MI:SS') ) AND  (a.REQ_PHYSICIAN = '",
				EmrSysPubFunction.getUserName(EmrSysPubVar.getDbUser(), false),
				"' ) )"
			});
            this.m_dtApplyExam = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            this.gcExamApply.DataSource = this.m_dtApplyExam;
        }
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void sbtnUpdate_Click(object sender, EventArgs e)
        {
            this.UpdateApllyExam();
        }
        private void sbtnCancel_Click(object sender, EventArgs e)
        {
            if (this.gvApplyExam.SelectedRowsCount >= 1)
            {
                DataRow dataRow = this.gvApplyExam.GetDataRow(this.gvApplyExam.FocusedRowHandle);
                if (dataRow["SCHEDULED_DATE"] != DBNull.Value)
                {
                    if (dataRow["SCHEDULED_DATE"].ToString().Length > 0)
                    {
                        MessageBox.Show("已经有预约时间，不能撤销", "提示：");
                        return;
                    }
                }
                if (DALUseSpecial.ExecuteSqlTran(new string[]
				{
					"delete from EXAM_ITEMS where EXAM_NO='" + dataRow["EXAM_NO"].ToString() + "'",
					"delete from EXAM_APPOINTS where EXAM_NO='" + dataRow["EXAM_NO"].ToString() + "'"
				}, this.m_strDBConnet))
                {
                    this.m_dtApplyExam.Rows.RemoveAt(this.gvApplyExam.FocusedRowHandle);
                    MessageBox.Show("撤销成功！");
                }
            }
        }
        private void gvApplyExam_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                try
                {
                    if (e.RowHandle > 0)
                    {
                        if (this.gvApplyExam.GetDataRow(e.RowHandle)["EXAM_CLASS"].ToString() == this.gvApplyExam.GetDataRow(e.RowHandle - 1)["EXAM_CLASS"].ToString() && this.gvApplyExam.GetDataRow(e.RowHandle)["PATIENT_ID"].ToString() == this.gvApplyExam.GetDataRow(e.RowHandle - 1)["PATIENT_ID"].ToString() && (e.Column.FieldName == "EXAM_CLASS" || e.Column.FieldName == "PATIENT_ID" || e.Column.FieldName == "NAME"))
                        {
                            e.DisplayText = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
            }
        }
        private void sbtnPrint_Click(object sender, EventArgs e)
        {
            if (this.gvApplyExam.RowCount >= 1)
            {
                if (this.gvApplyExam.SelectedRowsCount >= 1)
                {
                    frmPrint frmPrint = new frmPrint();
                    DataTable dataTable = new DataTable();
                    DataRow dataRow = this.gvApplyExam.GetDataRow(this.gvApplyExam.FocusedRowHandle);
                    string str = dataRow["EXAM_NO"].ToString();
                    string sQLString = "SELECT EXAM_NO,EXAM_ITEM_NO,EXAM_ITEM,EXAM_ITEM_CODE,COSTS FROM EXAM_ITEMS WHERE EXAM_NO='" + str + "'";
                    dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                    this.m_dtInfo.Rows.Clear();
                    DataRow dataRow2 = this.m_dtInfo.NewRow();
                    dataRow2[0] = "申请单号";
                    dataRow2[1] = "*" + str + "*";
                    this.m_dtInfo.Rows.Add(dataRow2);
                    DataRow dataRow3 = this.m_dtInfo.NewRow();
                    dataRow3[0] = "姓名";
                    dataRow3[1] = dataRow["NAME"].ToString();
                    this.m_dtInfo.Rows.Add(dataRow3);
                    DataRow dataRow4 = this.m_dtInfo.NewRow();
                    dataRow4[0] = "ID号";
                    dataRow4[1] = dataRow["PATIENT_ID"].ToString();
                    this.m_dtInfo.Rows.Add(dataRow4);
                    DataRow dataRow5 = this.m_dtInfo.NewRow();
                    dataRow5[0] = "性别";
                    dataRow5[1] = dataRow["SEX"].ToString();
                    this.m_dtInfo.Rows.Add(dataRow5);
                    DataRow dataRow6 = this.m_dtInfo.NewRow();
                    dataRow6[0] = "";
                    dataRow6[1] = "";
                    this.m_dtInfo.Rows.Add(dataRow6);
                    DataRow dataRow7 = this.m_dtInfo.NewRow();
                    dataRow7[0] = "出生日期";
                    dataRow7[1] = dataRow["DATE_OF_BIRTH"].ToString();
                    this.m_dtInfo.Rows.Add(dataRow7);
                    DataRow dataRow8 = this.m_dtInfo.NewRow();
                    dataRow8[0] = "年龄";
                    dataRow8[1] = Convert.ToString(EmrSysPubFunction.getServerNow().Year - Convert.ToDateTime(dataRow["DATE_OF_BIRTH"].ToString()).Year);
                    this.m_dtInfo.Rows.Add(dataRow8);
                    DataRow dataRow9 = this.m_dtInfo.NewRow();
                    dataRow9[0] = "费别";
                    dataRow9[1] = dataRow["CHARGE_TYPE"].ToString();
                    this.m_dtInfo.Rows.Add(dataRow9);
                    DataRow dataRow10 = this.m_dtInfo.NewRow();
                    dataRow10[0] = "工作单位";
                    if (dataRow["MAILING_ADDRESS"] != DBNull.Value)
                    {
                        dataRow10[1] = dataRow["MAILING_ADDRESS"].ToString();
                    }
                    else
                    {
                        dataRow10[1] = " ";
                    }
                    this.m_dtInfo.Rows.Add(dataRow10);
                    DataRow dataRow11 = this.m_dtInfo.NewRow();
                    dataRow11[0] = "电话";
                    if (dataRow["PHONE_NUMBER"] != DBNull.Value)
                    {
                        dataRow11[1] = dataRow["PHONE_NUMBER"].ToString();
                    }
                    else
                    {
                        dataRow11[1] = " ";
                    }
                    this.m_dtInfo.Rows.Add(dataRow11);
                    DataRow dataRow12 = this.m_dtInfo.NewRow();
                    dataRow12[0] = "入院诊断";
                    if (dataRow["CLIN_DIAG"] != DBNull.Value)
                    {
                        dataRow12[1] = dataRow["CLIN_DIAG"].ToString();
                    }
                    else
                    {
                        dataRow12[1] = " ";
                    }
                    this.m_dtInfo.Rows.Add(dataRow12);
                    DataRow dataRow13 = this.m_dtInfo.NewRow();
                    dataRow13[0] = "申请科室";
                    dataRow13[1] = EmrSysPubFunction.getDeptName(dataRow["REQ_DEPT"].ToString(), false);
                    this.m_dtInfo.Rows.Add(dataRow13);
                    DataRow dataRow14 = this.m_dtInfo.NewRow();
                    dataRow14[0] = "申请时间";
                    dataRow14[1] = dataRow["REQ_DATE_TIME"].ToString();
                    this.m_dtInfo.Rows.Add(dataRow14);
                    DataRow dataRow15 = this.m_dtInfo.NewRow();
                    dataRow15[0] = "开单医生";
                    dataRow15[1] = dataRow["REQ_PHYSICIAN"].ToString();
                    this.m_dtInfo.Rows.Add(dataRow15);
                    DataRow dataRow16 = this.m_dtInfo.NewRow();
                    dataRow16[0] = "症状";
                    if (dataRow["CLIN_SYMP"] != DBNull.Value)
                    {
                        dataRow16[1] = dataRow["CLIN_SYMP"].ToString();
                    }
                    else
                    {
                        dataRow16[1] = " ";
                    }
                    this.m_dtInfo.Rows.Add(dataRow16);
                    DataRow dataRow17 = this.m_dtInfo.NewRow();
                    dataRow17[0] = "体征";
                    if (dataRow["PHYS_SIGN"] != DBNull.Value)
                    {
                        dataRow17[1] = dataRow["PHYS_SIGN"].ToString();
                    }
                    else
                    {
                        dataRow17[1] = " ";
                    }
                    this.m_dtInfo.Rows.Add(dataRow17);
                    DataRow dataRow18 = this.m_dtInfo.NewRow();
                    dataRow18[0] = "化验";
                    if (dataRow["RELEVANT_LAB_TEST"] != DBNull.Value)
                    {
                        dataRow18[1] = dataRow["RELEVANT_LAB_TEST"].ToString();
                    }
                    else
                    {
                        dataRow18[1] = " ";
                    }
                    this.m_dtInfo.Rows.Add(dataRow18);
                    DataRow dataRow19 = this.m_dtInfo.NewRow();
                    dataRow19[0] = "检查";
                    if (dataRow["RELEVANT_DIAG"] != DBNull.Value)
                    {
                        dataRow19[1] = dataRow["RELEVANT_DIAG"].ToString();
                    }
                    else
                    {
                        dataRow19[1] = " ";
                    }
                    this.m_dtInfo.Rows.Add(dataRow19);
                    string value = " ";
                    if (dataRow["EXAM_CLASS"].ToString() == "ＣＴ")
                    {
                        value = "住院部主楼二层东侧放射科";
                    }
                    else
                    {
                        if (dataRow["EXAM_CLASS"].ToString() == "放射")
                        {
                            value = "门诊二楼中部放射科";
                        }
                        else
                        {
                            if (dataRow["EXAM_CLASS"].ToString() == "磁共振")
                            {
                                value = "核磁共振楼";
                            }
                            else
                            {
                                if (dataRow["EXAM_CLASS"].ToString() == "超声")
                                {
                                    value = "住院部主楼二层东侧放射科";
                                }
                                else
                                {
                                    if (dataRow["EXAM_CLASS"].ToString() == "DSA")
                                    {
                                        value = "住院部主楼二层西侧侧放射科";
                                    }
                                }
                            }
                        }
                    }
                    DataRow dataRow20 = this.m_dtInfo.NewRow();
                    dataRow20[0] = "检查地点";
                    dataRow20[1] = value;
                    this.m_dtInfo.Rows.Add(dataRow20);
                    DataRow dataRow21 = this.m_dtInfo.NewRow();
                    dataRow21[0] = "预约时间";
                    if (dataRow["SCHEDULED_DATE"] != DBNull.Value)
                    {
                        dataRow21[1] = dataRow["SCHEDULED_DATE"].ToString();
                    }
                    else
                    {
                        dataRow21[1] = " ";
                    }
                    this.m_dtInfo.Rows.Add(dataRow21);
                    DataRow dataRow22 = this.m_dtInfo.NewRow();
                    dataRow22[0] = "检查目的";
                    if (dataRow["EXAM_REASON"] != DBNull.Value)
                    {
                        dataRow22[1] = dataRow["EXAM_REASON"].ToString();
                    }
                    else
                    {
                        dataRow22[1] = " ";
                    }
                    this.m_dtInfo.Rows.Add(dataRow22);
                    this.m_dtExam.Rows.Clear();
                    for (int i = 1; i <= 8; i++)
                    {
                        DataRow dataRow23 = this.m_dtExam.NewRow();
                        dataRow23[0] = "[序号" + Convert.ToString(i) + "]";
                        dataRow23[1] = " ";
                        this.m_dtExam.Rows.Add(dataRow23);
                        DataRow dataRow24 = this.m_dtExam.NewRow();
                        dataRow24[0] = "[子分类" + Convert.ToString(i) + "]";
                        dataRow24[1] = " ";
                        this.m_dtExam.Rows.Add(dataRow24);
                        DataRow dataRow25 = this.m_dtExam.NewRow();
                        dataRow25[0] = "[部位" + Convert.ToString(i) + "]";
                        dataRow25[1] = " ";
                        this.m_dtExam.Rows.Add(dataRow25);
                        DataRow dataRow26 = this.m_dtExam.NewRow();
                        dataRow26[0] = "[项目" + Convert.ToString(i) + "]";
                        dataRow26[1] = " ";
                        this.m_dtExam.Rows.Add(dataRow26);
                    }
                    for (int j = 0; j < dataTable.Rows.Count; j++)
                    {
                        this.m_dtExam.Rows[j + j * 4][1] = Convert.ToString(j + 1);
                        this.m_dtExam.Rows[j + 1 + j * 4][1] = dataRow["EXAM_CLASS"].ToString();
                        this.m_dtExam.Rows[j + 2 + j * 4][1] = dataRow["EXAM_SUB_CLASS"].ToString();
                        this.m_dtExam.Rows[j + 3 + j * 4][1] = dataTable.Rows[j]["EXAM_ITEM"].ToString();
                    }
                    frmPrint.PrintLabExam("检查申请单", this.m_dtInfo, this.m_dtExam);
                }
            }
        }
    }
}