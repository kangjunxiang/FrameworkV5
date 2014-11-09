using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JHEMR.EMREdit
{
    public partial class UCExamApplyList : UserControl
    {
        private string m_CurPatientID;
        private int m_CurVisitID;

        public UCExamApplyList()
        {
            InitializeComponent();
        }

        public void setPatient(string strPatientID, int intVisitID)
        {
            m_CurPatientID = strPatientID;
            m_CurVisitID = intVisitID;
            DataLoad();
        }

        private void DataLoad()
        {
            DataSet objDataSet = new DataSet();
            objDataSet = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetExamMaster(m_CurPatientID, m_CurVisitID);
            if (objDataSet == null)
                return;
            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                dgvExamMaster.DataSource = objTable.DefaultView;
            }
            foreach (DataGridViewRow row in dgvExamMaster.Rows)
            {
                if (row.Cells["RESULT_STATUS"] != null)
                {
                    if (row.Cells["RESULT_STATUS"].Value.ToString() == "报告")
                    {
                        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                        cellStyle.BackColor = Color.Wheat;
                        row.DefaultCellStyle = cellStyle;
                    }
                }
            }
            dgvExamMaster_Click(dgvExamMaster, new EventArgs());
        }

        private void UCExamApplyList_Load(object sender, EventArgs e)
        {
           
        }

        private void dgvExamMaster_Click(object sender, EventArgs e)
        {
            if (dgvExamMaster.SelectedRows.Count > 0)
            {
                DataGridViewRow objCurRow = dgvExamMaster.SelectedRows[0];
                string strContent = "";
                string strReportDate;
                string strExamSubClass;	//检查项目
                string strExamClass;	//检查项目
                string strExamNo;
                string strExamReport;
                //if (objCurRow.Cells["RESULT_STATUS"].Value.ToString() != "报告")
                //{
                //    txtExam.Rtf = "";
                //    return;
                //}
                strExamNo = objCurRow.Cells["EXAM_NO"].Value.ToString().Trim();
                DataSet dtExamReport;
                dtExamReport=EmrSysWebservices.EmrSysWebservicesUse.myEmrGetExamReport(strExamNo);
                if (dtExamReport.Tables[0].Rows.Count != 1)
                {
                    txtExam.Text = "";
                    return;
                }
                if (dtExamReport.Tables[0].Rows[0]["exam_report"] != DBNull.Value)
                {
                    strExamReport = dtExamReport.Tables[0].Rows[0]["exam_report"].ToString();
                    txtExam.Text = strExamReport;
                }
                else
                    txtExam.Text = "";
                //strReportDate = objCurRow.Cells["REPORT_DATE_TIME"].Value.ToString();
                //strExamSubClass = objCurRow.Cells["EXAM_SUB_CLASS"].Value.ToString();
                //strExamClass = objCurRow.Cells["EXAM_CLASS"].Value.ToString();
                //if (strReportDate.Length > 0)
                //    strContent += strExamClass + "(" + strExamSubClass + ")" + "(" + Convert.ToDateTime(strReportDate).ToString("yyyy-MM-dd") + ")检查结果：";
                //else
                //    strContent += strExamClass + "(" + strExamSubClass + ")检查结果：";

                //strContent += EMREditHisAdaperUse.getExamResult(objCurRow.Cells["EXAM_NO1"].Value.ToString());
                //txtExam.Text = strContent;

                //DataSet objDataSetItems = new DataSet();
                //objDataSetItems = EMREditHisAdaperUse.getExamItems(objCurRow.Cells["EXAM_NO1"].Value.ToString());

                //if (objDataSetItems.Tables.Count > 0)
                //{
                //    DataTable objTable;
                //    objTable = objDataSetItems.Tables[0];
                //    dgvExamItems.DataSource = objTable.DefaultView;
                //}


            }

        }
    }
}
