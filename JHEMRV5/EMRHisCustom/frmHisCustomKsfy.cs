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
    public partial class frmHisCustomKsfy : DevExpress.XtraEditors.XtraForm
    {
        private string m_strWardCode = "";
        private string m_strWardName = "";
        private string m_strDBConnet = "HISConnect";
        public frmHisCustomKsfy()
        {
            InitializeComponent();
        }
        private void frmHisCustomKsfy_Load(object sender, EventArgs e)
        {
            this.GetWardInfo();
            if (this.m_strWardName.Length > 0)
            {
                this.FillgdKsfy();
            }
        }
        private void GetWardInfo()
        {
            string sQLString = "select a.ward_code,b.dept_name from dept_vs_ward a,dept_dict b where a.ward_code=b.dept_code and a.dept_code='" + EmrSysPubVar.getDeptCode() + "'";
            try
            {
                DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    this.m_strWardCode = dataTable.Rows[0]["WARD_CODE"].ToString();
                    this.m_strWardName = dataTable.Rows[0]["DEPT_NAME"].ToString();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void FillgdKsfy()
        {
            frmLoadProgress frmLoadProgress = new frmLoadProgress();
            frmLoadProgress.Show();
            frmLoadProgress.setTipText("正在查询科室费用数据，请稍后...");
            frmLoadProgress.setRange(0, 5);
            frmLoadProgress.Refresh();
            string sQLString = "SELECT  a.PATIENT_ID,a.VISIT_ID,a.BED_NO,a.WARD_CODE,a.PREPAYMENTS AS YJJ,b.inp_no,b.name,b.sex,'' as JJFY,'' as SJFY,'' as  YPFY,'' as YPBL,'' as FLAG FROM PATS_IN_HOSPITAL a,PAT_MASTER_INDEX b WHERE a.patient_id=b.patient_id and (WARD_CODE = '" + this.m_strWardCode + "')";
            DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            frmLoadProgress.setPos(1);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    sQLString = "select sum(costs) as jjfy1,sum(charges) as sjfy1 from inp_bill_detail where patient_id='" + dataRow["patient_id"].ToString() + "' and visit_id=" + dataRow["visit_id"].ToString();
                    DataTable dataTable2 = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                    frmLoadProgress.setPos(2);
                    if (dataTable2.Rows.Count > 0)
                    {
                        if (dataTable2.Rows[0]["jjfy1"].ToString().Length < 1)
                        {
                            dataRow["JJFY"] = "0";
                        }
                        else
                        {
                            dataRow["JJFY"] = dataTable2.Rows[0]["jjfy1"].ToString();
                        }
                        if (dataTable2.Rows[0]["sjfy1"].ToString().Length < 1)
                        {
                            dataRow["SJFY"] = "0";
                        }
                        else
                        {
                            dataRow["SJFY"] = dataTable2.Rows[0]["sjfy1"].ToString();
                        }
                    }
                    else
                    {
                        dataRow["JJFY"] = "0";
                        dataRow["SJFY"] = "0";
                    }
                    frmLoadProgress.setPos(3);
                    sQLString = string.Concat(new string[]
					{
						"select sum(costs) as ypfy from inp_bill_detail where patient_id='",
						dataRow["patient_id"].ToString(),
						"' and visit_id=",
						dataRow["visit_id"].ToString(),
						" and item_class='A'"
					});
                    DataTable dataTable3 = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                    frmLoadProgress.setPos(4);
                    if (dataTable3.Rows.Count > 0)
                    {
                        if (dataTable3.Rows[0]["ypfy"].ToString().Length < 1)
                        {
                            dataRow["YPFY"] = "0";
                        }
                        else
                        {
                            dataRow["YPFY"] = dataTable3.Rows[0]["ypfy"].ToString();
                        }
                    }
                    else
                    {
                        dataRow["YPFY"] = "0";
                    }
                    if (dataRow["YJJ"] == DBNull.Value)
                    {
                        dataRow["YJJ"] = "0";
                    }
                    if (dataRow["JJFY"] != DBNull.Value)
                    {
                        if (dataRow["JJFY"].ToString() != "0")
                        {
                            double num = Convert.ToDouble(dataRow["YPFY"].ToString()) / Convert.ToDouble(dataRow["JJFY"].ToString()) * 100.0;
                            dataRow["YPBL"] = string.Format("{0:F2}", num);
                        }
                        else
                        {
                            dataRow["YPBL"] = "";
                        }
                    }
                    else
                    {
                        dataRow["YPBL"] = "";
                    }
                }
                this.gcKsfy.DataSource = dataTable;
            }
            frmLoadProgress.Close();
        }
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            if (this.m_strWardName.Length > 0)
            {
                this.FillgdKsfy();
            }
        }
        private void sbtnClear_Click(object sender, EventArgs e)
        {
            this.gcKsfy.DataSource = null;
        }
        private void gvKsfy_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                try
                {
                    DataRow dataRow = this.gvKsfy.GetDataRow(e.RowHandle);
                    if (dataRow["YJJ"] != DBNull.Value)
                    {
                        if (dataRow["SJFY"] != DBNull.Value)
                        {
                            if (Convert.ToDouble(dataRow["YJJ"].ToString()) < Convert.ToDouble(dataRow["SJFY"].ToString()))
                            {
                                e.Appearance.BackColor = Color.LightCoral;
                                dataRow["FLAG"] = "√";
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
        private void sbtnPrint_Click(object sender, EventArgs e)
        {
            this.gcKsfy.Print();
        }
    }
}