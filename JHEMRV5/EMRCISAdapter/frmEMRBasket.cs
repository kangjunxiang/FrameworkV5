using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EmrSysWebservices;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysAdaper;
using JHEMR.EmrSysUserCtl;
using JHEMR.EmrSysDAL;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
namespace JHEMR.EMREdit
{
    public partial class frmEMRBasket : Form
    {
        public UCEMRPad30 m_objPad;
        public void setParentPad(UCEMRPad30 objPad)
        {
            m_objPad = objPad;
        }
        public frmEMRBasket()
        {
            InitializeComponent();
        }

        private void frmEMRBasket1_Load(object sender, EventArgs e)
        {

            //获取检验申请
            DataSet objDataSetLabTestMaster = new DataSet();
            objDataSetLabTestMaster = EmrSysWebservicesUse.myEmrGetLabDataSetByPatientID(EmrSysPubVar.getCurPatientID(), EmrSysPubVar.getCurPatientVisitID());
            if (objDataSetLabTestMaster != null)
            {
                if (objDataSetLabTestMaster.Tables.Count > 0)
                {
                    DataTable objTable;
                    objTable = objDataSetLabTestMaster.Tables[0];
                    this.gcLab.DataSource = objTable.DefaultView;
                }
            }
            //获取医嘱
            DataSet objDataSetOrders = new DataSet();
            objDataSetOrders = EmrSysWebservicesUse.myEmrGetOrderDataSetByPatentID(EmrSysPubVar.getCurPatientID(), EmrSysPubVar.getCurPatientVisitID());
            if (objDataSetOrders != null)
            {
                if (objDataSetOrders.Tables.Count > 0)
                {
                    DataTable objTable;
                    objTable = objDataSetOrders.Tables[0];
                    this.gcOrder.DataSource = objTable.DefaultView;
                }
            }
            //获取检查
            //DataSet objDataSetExam = new DataSet();                         
           // objDataSetExam = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetExamMaster(EmrSysPubVar.getCurPatientID(), EmrSysPubVar.getCurPatientVisitID());
            //if (objDataSetExam.Tables.Count > 0)
               // gcExam.DataSource = objDataSetExam.Tables[0];
            DataSet objDataSetExam = new DataSet();
            objDataSetExam = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetExamMaster(EmrSysPubVar.getCurPatientID(), EmrSysPubVar.getCurPatientVisitID());
            if (objDataSetExam != null)
            {
                if (objDataSetExam.Tables.Count > 0)
                {
                    DataTable objTable;
                    objTable = objDataSetExam.Tables[0];
                    this.gcExam.DataSource = objTable.DefaultView;
                }

 }
}
        private void gvLab_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.gvLab.SelectedRowsCount > 0)
            {
                try
                {
                    string applyno = this.gvLab.GetRowCellValue(e.FocusedRowHandle, "ApplyNo").ToString().Trim();
                    DataSet objDataSet = EmrSysWebservicesUse.myEmrGetLabReportDataSet(applyno);
                    if (objDataSet != null)
                    {
                        if (objDataSet.Tables.Count > 0)
                        {
                            DataTable objTable;
                            objTable = objDataSet.Tables[0];
                            this.gcReport.DataSource = objTable.DefaultView;
                        }
                    }
                }
                catch (System.Exception E)
                {
                    EmrSysPubFunction.DoWithSystemException(E);
                }
            }
        }
        //写回
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            int i = this.xtraTabControl1.SelectedTabPageIndex;
            switch (i)
            {
                case 0:
                    if (this.gvReport.SelectedRowsCount > 0)
                    {
                        this.txtLab.Text = "";
                        try
                        {
                            int[] a = this.gvReport.GetSelectedRows();
                            for (int j = 0; j < a.Length; j++)
                            {
                                string itemname = this.gvReport.GetRowCellValue(a[j], "ItemName").ToString().Trim();
                                string name = this.gvReport.GetRowCellValue(a[j], "ResultValue").ToString().Trim();
                                string unit = this.gvReport.GetRowCellValue(a[j], "Unit").ToString().Trim();
                                this.txtLab.Text += itemname + name + unit;
                            }
                        }
                        catch (System.Exception E)
                        {
                            EmrSysPubFunction.DoWithSystemException(E);
                        }
                    }

                    if (txtLab.Text.Length > 0)
                    {
                        Clipboard.SetDataObject(txtLab.Text, false);//
                        m_objPad.PadSetPasteMode(2); //设置为粘贴文本格式		
                        m_objPad.PadEditPaste();
                        m_objPad.PadSetPasteMode(1); //设置为粘贴病历格式	
                    }
                    break;
                case 1:
                    {
                        string strContent = "";
                        string ls_dosage, ls_dosage_units, ls_dosagetext;
                        if (this.gvOrder.SelectedRowsCount > 0)
                        {
                            int[] a = this.gvOrder.GetSelectedRows();
                            for (int k = 0; k < a.Length; k++)
                            {
                                if (strContent.Length > 0) strContent += "，";
                                ls_dosage = this.gvOrder.GetRowCellValue(a[k], "DOSAGE").ToString().Trim();
                                ls_dosage_units = this.gvOrder.GetRowCellValue(a[k], "DOSAGE_UNITS").ToString().Trim();
                                ls_dosagetext = this.gvOrder.GetRowCellValue(a[k], "ORDER_TEXT").ToString().Trim();
                                ls_dosage = ls_dosage + ls_dosage_units;
                                strContent += ls_dosagetext;
                                if (ls_dosage.Length > 0)
                                    strContent += "(" + ls_dosage + ")";

                            }

                        }
                        if (strContent.Length > 0)
                        {
                            Clipboard.SetDataObject(strContent, false);//
                            m_objPad.PadSetPasteMode(2); //设置为粘贴文本格式		
                            m_objPad.PadEditPaste();
                            m_objPad.PadSetPasteMode(1); //设置为粘贴病历格式	
                        }

                    }
                    break;
                case 2:
                    {
                        if (txtReport.SelectedText.Length > 0)
                        {
                            Clipboard.SetDataObject(txtReport.SelectedText.Replace("\r", "").Replace("\n", ""), false);//
                            m_objPad.PadSetPasteMode(2); //设置为粘贴文本格式		
                            m_objPad.PadEditPaste();
                            m_objPad.PadSetPasteMode(1); //设置为粘贴病历格式	
                        }

                    }
                    break;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //先保存到临时文件
            if (!emrpadMrBrief.PadFileSaveAs(EmrSysPubVar.getTempFileFullName(), 0, 0))
            {
                MessageBox.Show("保存文件出错。");
                return;
            }

            //先传送文件
            object[] strArgs;
            strArgs = new object[3];
            strArgs[0] = 0;
            strArgs[1] = "blzy";
            strArgs[2] = EmrSysPubVar.getCurPatientID();
            if (!EMRArchiveAdaperUse.storageEmrFile(strArgs))
            {
                MessageBox.Show("将病历摘要保存回服务器出错!");
                return;
            }
            else
            {
                //MessageBox.Show("病历摘要保存成功!");
            }
            if (!emrpadMrBrief.PadFileSaveAs(EmrSysPubVar.getTempFileFullName(), 5, 0))
            {
                MessageBox.Show("保存文件出错。");
                return;
            }

            //先传送文件
            object[] strArgstxt;
            strArgstxt = new object[3];
            strArgstxt[0] = 0;
            strArgstxt[1] = "blzy.txt";
            strArgstxt[2] = EmrSysPubVar.getCurPatientID();
            if (!EMRArchiveAdaperUse.storageEmrFile(strArgstxt))
            {
                MessageBox.Show("将病历摘要txt文件保存回服务器出错!");
                return;
            }
            else
            {
                MessageBox.Show("病历摘要保存成功!");
            }
        }

        private void gvExam_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvExam.FocusedRowHandle < 0)
                return;
           DataRow dr = gvExam.GetDataRow(gvExam.FocusedRowHandle);
            string strExamNo = "";
            string strReportText = "";
            if (dr["EXAM_NO"] != DBNull.Value)
                strExamNo = dr["EXAM_NO"].ToString();

            DataSet dtExamReport;
            dtExamReport = EmrSysWebservices.EmrSysWebservicesUse.myEmrGetExamReport(strExamNo);
            if (dtExamReport.Tables.Count > 0 && dtExamReport.Tables[0].Rows.Count > 0)
            {
                DataRow drReport = dtExamReport.Tables[0].Rows[0];
                strReportText = drReport["REPORT_TXT"].ToString();
            }
            txtReport.Text = strReportText;

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void gvReport_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        
        {
            DataRow dr = this.gvReport.GetDataRow(e.RowHandle);
            //H＝偏高、L＝偏低、P＝阳性、Q＝弱阳性、E＝错误、HH＝偏高并超出危急值范围、LL＝偏低并超出危急值范围
            if (dr["CharRefer"].ToString().Trim().Equals("H"))
            {
                e.Appearance.BackColor = Color.Red;
            }
            if (dr["CharRefer"].ToString().Trim().Equals("L"))
            {
                e.Appearance.BackColor = Color.Red;
            }
            if (dr["CharRefer"].ToString().Trim().Equals("P"))
            {
                e.Appearance.BackColor = Color.Red;
            }
            if (dr["CharRefer"].ToString().Trim().Equals("Q"))
            {
                e.Appearance.BackColor = Color.Red;
            }
            if (dr["CharRefer"].ToString().Trim().Equals("E"))
            {
                e.Appearance.BackColor = Color.Red;
            }
            if (dr["CharRefer"].ToString().Trim().Equals("HH"))
            {
                e.Appearance.BackColor = Color.Red;
            }
            if (dr["CharRefer"].ToString().Trim().Equals("LL"))
            {
                e.Appearance.BackColor = Color.Red;
            }
        }
        
        private void gcReport_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLab_TextChanged(object sender, EventArgs e)
        {

        }

        }
    }
