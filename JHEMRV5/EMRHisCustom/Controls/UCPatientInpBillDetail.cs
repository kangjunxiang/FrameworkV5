using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class UCPatientInpBillDetail : UserControl, EmrEditUCInterface
    {
        private string m_strPatientID;
        private int m_nVisitID;
        private string m_strPat_dept;
        private string m_strDBConnet = "HISConnect";
        public UCPatientInpBillDetail()
        {
            InitializeComponent();
        }
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            this.m_strPatientID = strPatientID;
            this.m_nVisitID = nVisitID;
            DataSet dataSet = new DataSet();
            if (EmrSysPubVar.getCurPatientChargeType() == "军队医改")
            {
                this.btnPrint.Enabled = true;
            }
            string text = "select CLASS_CODE as ORDER_CLASS,CLASS_NAME as ORDER_CLASS_NAME from bill_item_class_dict ";
            dataSet = DALUseSpecial.Query(text, this.m_strDBConnet);
            if (dataSet.Tables.Count > 0)
            {
                this.repositoryItemLookUpOrderClass.DataSource = dataSet.Tables[0];
                this.repositoryItemLookUpEdit1.DataSource = dataSet.Tables[0];
            }
            text = string.Concat(new object[]
			{
				"SELECT ITEM_CLASS, ITEM_NAME, ITEM_CODE,ITEM_SPEC, UNITS, SUM(AMOUNT) AS AMOUNT, SUM(COSTS) AS COSTS,SUM(CHARGES) as CHARGES FROM INP_BILL_DETAIL  WHERE (1=1)  and patient_id='",
				this.m_strPatientID,
				"' and visit_id=",
				this.m_nVisitID,
				"  GROUP BY ITEM_CLASS, ITEM_NAME, ITEM_CODE, ITEM_SPEC,UNITS"
			});
            dataSet = DALUseSpecial.Query(text, this.m_strDBConnet);
            if (dataSet.Tables.Count > 0)
            {
                this.gridInpBillDetail.DataSource = dataSet.Tables[0].DefaultView;
            }
            decimal num = 0m;
            text = string.Concat(new object[]
			{
				"select ITEM_CLASS,sum(CHARGES) as SUM_CHARGES,sum(COSTS) as SUM_COSTS,0.0 as FEE_PERCENT from INP_BILL_DETAIL where patient_id='",
				this.m_strPatientID,
				"' and visit_id=",
				this.m_nVisitID,
				" group by ITEM_CLASS order by ITEM_CLASS"
			});
            dataSet = DALUseSpecial.Query(text, this.m_strDBConnet);
            if (dataSet.Tables.Count > 0)
            {
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    if (dataRow["SUM_CHARGES"] != DBNull.Value)
                    {
                        if (dataRow["SUM_CHARGES"].ToString().Length > 0)
                        {
                            num += Convert.ToDecimal(dataRow["SUM_CHARGES"].ToString());
                        }
                    }
                }
                decimal num2 = 0m;
                if (num > 0m)
                {
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        DataRow dataRow2 = dataSet.Tables[0].Rows[i];
                        if (i == dataSet.Tables[0].Rows.Count - 1)
                        {
                            dataRow2["FEE_PERCENT"] = (100m - num2).ToString("#0.#");
                        }
                        else
                        {
                            if (dataRow2["SUM_CHARGES"] != DBNull.Value)
                            {
                                if (dataRow2["SUM_CHARGES"].ToString().Length > 0)
                                {
                                    decimal d = Convert.ToDecimal((Convert.ToDecimal(dataRow2["SUM_CHARGES"].ToString()) * 100m / num).ToString("#0.#"));
                                    num2 += d;
                                    dataRow2["FEE_PERCENT"] = d.ToString("#0.#");
                                }
                            }
                        }
                    }
                }
                this.gridOrderClassBill.DataSource = dataSet.Tables[0].DefaultView;
            }
            text = "SELECT Prepayments,total_charges  From pats_in_hospital ";
            object obj = text;
            text = string.Concat(new object[]
			{
				obj,
				"\twhere patient_id='",
				this.m_strPatientID,
				"' and visit_id=",
				this.m_nVisitID
			});
            DataSet dataSet2 = new DataSet();
            dataSet2 = DALUseSpecial.Query(text, this.m_strDBConnet);
            if (dataSet2.Tables.Count > 0)
            {
                if (dataSet2.Tables[0].Rows.Count == 1)
                {
                    DataRow dataRow2 = dataSet2.Tables[0].Rows[0];
                    if (dataRow2["Prepayments"] != DBNull.Value)
                    {
                        this.txtPrepayments.Text = dataRow2["Prepayments"].ToString();
                        decimal d2 = Convert.ToDecimal(this.txtPrepayments.Text) - num;
                        this.labelControl2.Text = d2.ToString("#0.00");
                        if (d2 <= 0m)
                        {
                            this.labelControl2.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }
        private void UCPatientInpBillDetail_Load(object sender, EventArgs e)
        {
        }
        public bool cmdCheckIsUnSave()
        {
            return false;
        }
        public bool getCloseFlag()
        {
            return false;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int num = 0;
            string sQLString = "select count(*) from inp_settle_master where patient_id='" + this.m_strPatientID + "' and visit_id=" + this.m_nVisitID.ToString();
            object single = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
            if (single != null)
            {
                num = Convert.ToInt32(single.ToString());
            }
            if (num == 0)
            {
                MessageBox.Show("该病人还没有结算，不能打印！");
            }
            else
            {
                num = 0;
                sQLString = string.Concat(new string[]
				{
					"select count(*) from pat_visit where patient_id='",
					this.m_strPatientID,
					"' and visit_id=",
					this.m_nVisitID.ToString(),
					" and discharge_date_time is not null"
				});
                object single2 = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
                if (single2 != null)
                {
                    num = Convert.ToInt32(single2.ToString());
                }
                if (num < 1)
                {
                    MessageBox.Show("病人还没有出院，不能打印！");
                }
                else
                {
                    string text = "";
                    sQLString = "select sum(costs) from inp_settle_master where patient_id='" + this.m_strPatientID + "' and visit_id=" + this.m_nVisitID.ToString();
                    object single3 = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
                    if (single3 != null)
                    {
                        text = single3.ToString();
                    }
                    text = ((text == "") ? " " : text);
                    frmPrint frmPrint = new frmPrint();
                    DataTable dataTable = new DataTable();
                    for (int i = 0; i <= 1; i++)
                    {
                        dataTable.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                    }
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = "医院名称";
                    dataRow[1] = EmrSysPubVar.getHospitalName();
                    dataTable.Rows.Add(dataRow);
                    DataRow dataRow2 = dataTable.NewRow();
                    dataRow2[0] = "住院天数";
                    dataRow2[1] = EmrSysPubFunction.GetBetweenDays(EmrSysPubVar.getCurVisitAdmissionDateTime(), EmrSysPubVar.getCurVisitDischargeDateTime()).ToString();
                    dataTable.Rows.Add(dataRow2);
                    DataRow dataRow3 = dataTable.NewRow();
                    dataRow3[0] = "入院日期";
                    dataRow3[1] = EmrSysPubVar.getCurVisitAdmissionDateTime().ToString("yyyy年MM月dd日");
                    dataTable.Rows.Add(dataRow3);
                    DataRow dataRow4 = dataTable.NewRow();
                    dataRow4[0] = "出院日期";
                    dataRow4[1] = EmrSysPubVar.getCurVisitDischargeDateTime().ToString("yyyy年MM月dd日");
                    dataTable.Rows.Add(dataRow4);
                    DataRow dataRow5 = dataTable.NewRow();
                    dataRow5[0] = "住院费用";
                    dataRow5[1] = text;
                    dataTable.Rows.Add(dataRow5);
                    DataRow dataRow6 = dataTable.NewRow();
                    dataRow6[0] = "西药费";
                    dataRow6[1] = this.GetDetailFee("西药费");
                    dataTable.Rows.Add(dataRow6);
                    DataRow dataRow7 = dataTable.NewRow();
                    dataRow7[0] = "中药费";
                    dataRow7[1] = this.GetDetailFee("中药费");
                    dataTable.Rows.Add(dataRow7);
                    DataRow dataRow8 = dataTable.NewRow();
                    dataRow8[0] = "检验费";
                    dataRow8[1] = this.GetDetailFee("检验费");
                    dataTable.Rows.Add(dataRow8);
                    DataRow dataRow9 = dataTable.NewRow();
                    dataRow9[0] = "检查费";
                    dataRow9[1] = this.GetDetailFee("检查费");
                    dataTable.Rows.Add(dataRow9);
                    DataRow dataRow10 = dataTable.NewRow();
                    dataRow10[0] = "材料费";
                    dataRow10[1] = this.GetDetailFee("材料费");
                    dataTable.Rows.Add(dataRow10);
                    DataRow dataRow11 = dataTable.NewRow();
                    dataRow11[0] = "治疗费";
                    dataRow11[1] = this.GetDetailFee("治疗费");
                    dataTable.Rows.Add(dataRow11);
                    DataRow dataRow12 = dataTable.NewRow();
                    dataRow12[0] = "输血费";
                    dataRow12[1] = this.GetDetailFee("输血费");
                    dataTable.Rows.Add(dataRow12);
                    DataRow dataRow13 = dataTable.NewRow();
                    dataRow13[0] = "手术费";
                    dataRow13[1] = this.GetDetailFee("手术费");
                    dataTable.Rows.Add(dataRow13);
                    DataRow dataRow14 = dataTable.NewRow();
                    dataRow14[0] = "麻醉费";
                    dataRow14[1] = this.GetDetailFee("麻醉费");
                    dataTable.Rows.Add(dataRow14);
                    DataRow dataRow15 = dataTable.NewRow();
                    dataRow15[0] = "其他";
                    dataRow15[1] = this.GetDetailFee("其他");
                    dataTable.Rows.Add(dataRow15);
                    frmPrint.PrintLabExam("实报实销", dataTable, null);
                }
            }
        }
        private string GetDetailFee(string strDetailItem)
        {
            string sQLString = string.Concat(new string[]
			{
				"select sum(b.COSTS) from inp_settle_master a ,inp_settle_detail b where a.rcpt_no=b.rcpt_no and a.patient_id='",
				this.m_strPatientID,
				"' and a.visit_id=",
				this.m_nVisitID.ToString(),
				" and b.FEE_CLASS_NAME='",
				strDetailItem,
				"'"
			});
            string text = "";
            object single = DALUseSpecial.GetSingle(sQLString, this.m_strDBConnet);
            if (single != null)
            {
                text = single.ToString();
            }
            return (text == "") ? " " : text;
        }
    }
}
