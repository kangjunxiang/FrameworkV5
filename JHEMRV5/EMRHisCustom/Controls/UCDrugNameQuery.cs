using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class UCDrugNameQuery : UserControl, EmrEditUCInterface
    {
        private string m_strDBConnet = "HISConnect";
        private DataTable m_dtDrug = new DataTable();
        private DataTable m_dtPYDrug = new DataTable();
        private DataTable m_dtNewDrugInfo = new DataTable();
        private DataTable dt_DrugMHSearch = new DataTable();
        private DataSet m_dsStorage = new DataSet();
        public string strPham_std_code = "";
        private bool blPhamNameType = true;
        public UCDrugNameQuery()
        {
            InitializeComponent();
        }

        private void UCDrugNameQuery_Load(object sender, EventArgs e)
        {
            this.FillgcCode();
            this.m_dsStorage = this.getStorage();
            this.cbBoxFiled1.SelectedIndex = 6;
            this.cbBoxFiled2.SelectedIndex = 6;
            this.comboBoxLogic.SelectedIndex = 0;
            this.txtDrug.Focus();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtDrug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                if (!this.panelDrug.Visible)
                {
                    this.panelDrug.Visible = true;
                    this.txtPYM.Text = "";
                    this.txtPYM.Focus();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (!this.panelDrug.Visible)
                    {
                        this.panelDrug.Visible = true;
                        this.txtPYM.Text = "";
                        this.txtPYM.Focus();
                    }
                }
            }
        }
        private void txtPYM_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
            if (keyCode <= Keys.Escape)
            {
                if (keyCode != Keys.Return)
                {
                    if (keyCode == Keys.Escape)
                    {
                        this.panelDrug.Visible = false;
                        this.txtDrug.Focus();
                    }
                }
                else
                {
                    if (this.gvCode.FocusedRowHandle >= 0)
                    {
                        DataRow dataRow = this.gvCode.GetDataRow(this.gvCode.FocusedRowHandle);
                        this.settxtDrug(dataRow["DRUG_NAME"].ToString(), dataRow["DRUG_CODE"].ToString());
                        this.panelDrug.Visible = false;
                        this.txtDrug.Focus();
                    }
                }
            }
            else
            {
                switch (keyCode)
                {
                    case Keys.Prior:
                        this.gvCode.Focus();
                        SendKeys.Send("{PGUP}");
                        break;
                    case Keys.Next:
                        this.gvCode.Focus();
                        SendKeys.Send("{PGDN}");
                        break;
                    default:
                        switch (keyCode)
                        {
                            case Keys.Up:
                                this.gvCode.Focus();
                                SendKeys.Send("{UP}");
                                break;
                            case Keys.Down:
                                this.gvCode.Focus();
                                SendKeys.Send("{DOWN}");
                                break;
                        }
                        break;
                }
            }
        }
        private void settxtDrug(string strName, string strCode)
        {
            this.txtDrug.Tag = strCode;
            this.txtDrug.Text = strName;
        }
        private void txtPYM_TextChanged(object sender, EventArgs e)
        {
            if (this.m_dtPYDrug != null)
            {
                if (this.m_dtPYDrug.Rows.Count > 0)
                {
                    this.m_dtPYDrug.DefaultView.RowFilter = "INPUT_CODE like '%" + this.txtPYM.Text.Replace("'", "''").ToUpper() + "%'";
                    if (this.gvCode.RowCount > 0)
                    {
                        DataRow dataRow = this.gvCode.GetDataRow(0);
                        this.lblName.Text = dataRow["DRUG_NAME"].ToString();
                        this.gvCode.MakeRowVisible(0, false);
                        this.gvCode.FocusedRowHandle = 0;
                    }
                    else
                    {
                        this.lblName.Text = "";
                    }
                }
            }
        }
        private void txtDrug_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDrug.Tag != null)
            {
                this.FillDrugGrid(this.txtDrug.Tag.ToString());
            }
        }
        private void txtDrug_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.panelDrug.Visible = true;
                this.panelDrug.BringToFront();
                this.txtPYM.Text = "";
                this.txtPYM.Focus();
            }
        }
        private void txtDrug_Leave(object sender, EventArgs e)
        {
        }
        private void txtDrug_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.labelControl1.Visible = true;
        }
        private void FillDrugGrid(string strDrugCode)
        {
            this.richTextBox2.Text = "";
            string text = "";
            string sQLString = "  select a.PHAM_STD_CODE,a.pham_code as drug_code,a.pham_name as drug_name,a.pham_spec as item_spec,a.pham_unit as units,a.RETAIL_PRICE as price  ,b.indication,b.form,b.adverse_reaction,b.attention,b.contraindication  ,b.DRUG_NAME,b.DRUG_E_NAME,b.ACTION,b.DOSAGE from pham_basic_info a,drug_info b where a.pham_code='" + strDrugCode + "' and substr(a.pham_code,0,7)=b.drug_code(+) ";
            this.m_dtDrug = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            this.gcDrug.DataSource = this.m_dtDrug;
            if (this.m_dtDrug.Rows.Count > 0)
            {
                DataRow dataRow = this.m_dtDrug.Rows[0];
                this.strPham_std_code = dataRow["PHAM_STD_CODE"].ToString();
                this.richTextBox2.Text = this.getDrugInfo(this.strPham_std_code, dataRow, ref text);
                this.richTextBox3.Text = text;
                this.setpanelControlDrugInfo(this.strPham_std_code);
                DataTable dataTable = new DataTable();
                dataTable = this.getStorageQuantity(this.strPham_std_code);
                if (dataTable != null)
                {
                    this.gcStorage.DataSource = dataTable;
                }
            }
        }
        private void gvCode_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                DataRow dataRow = this.gvCode.GetDataRow(e.FocusedRowHandle);
                this.lblName.Text = dataRow["DRUG_NAME"].ToString();
            }
        }
        private void gcCode_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
            if (keyCode != Keys.Return)
            {
                if (keyCode != Keys.Escape)
                {
                    switch (keyCode)
                    {
                        case Keys.Left:
                            this.txtPYM.Focus();
                            SendKeys.Send("{LEFT}");
                            break;
                        case Keys.Right:
                            this.txtPYM.Focus();
                            SendKeys.Send("{RIGHT}");
                            break;
                    }
                }
                else
                {
                    this.panelDrug.Visible = false;
                    this.txtDrug.Focus();
                }
            }
            else
            {
                if (this.gvCode.FocusedRowHandle >= 0)
                {
                    DataRow dataRow = this.gvCode.GetDataRow(this.gvCode.FocusedRowHandle);
                    this.settxtDrug(dataRow["DRUG_NAME"].ToString(), dataRow["DRUG_CODE"].ToString());
                    this.panelDrug.Visible = false;
                    this.txtDrug.Focus();
                }
            }
        }
        private void gvCode_DoubleClick(object sender, EventArgs e)
        {
            if (this.gvCode.FocusedRowHandle >= 0)
            {
                DataRow dataRow = this.gvCode.GetDataRow(this.gvCode.FocusedRowHandle);
                this.settxtDrug(dataRow["DRUG_NAME"].ToString(), dataRow["DRUG_CODE"].ToString());
                this.panelDrug.Visible = false;
                this.txtDrug.Focus();
            }
        }
        private void gvDrug_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = this.gvDrug.GetDataRow(e.FocusedRowHandle);
            if (dataRow == null)
            {
                this.richTextBox2.Text = "";
            }
            else
            {
                this.strPham_std_code = dataRow["PHAM_STD_CODE"].ToString();
                string text = "";
                this.richTextBox2.Text = this.getDrugInfo(this.strPham_std_code, dataRow, ref text);
                this.richTextBox3.Text = text;
                this.setpanelControlDrugInfo(this.strPham_std_code);
                DataTable dataTable = new DataTable();
                dataTable = this.getStorageQuantity(this.strPham_std_code);
                if (dataTable != null)
                {
                    this.gcStorage.DataSource = dataTable;
                }
            }
        }
        private void spbtnQuery_Click(object sender, EventArgs e)
        {
            DateTime value = this.dtpStart.Value;
            DateTime value2 = this.dtpEnd.Value;
            try
            {
                string sQLString = string.Concat(new object[]
				{
					"select t.pham_name as DRUG_NAME,t.pham_spec AS DRUG_SPEC,t.trade_price As DRUG_TRADE_PRICE,t.retail_price as DRUG_RETAIL_PRICE,t.pham_form as DRUG_FORM,t.pham_unit as DRUG_UNIT,t.enter_date as DRUG_ENTER_DATE,t.pham_std_code as DRUG_STD_CODE from pham_basic_info t where t.enter_date >= to_date('",
					value.Date,
					"','YYYY-MM-DD HH24:MI:SS') and t.enter_date <= to_date('",
					value2.Date,
					"','YYYY-MM-DD HH24:MI:SS')"
				});
                this.m_dtNewDrugInfo = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (this.m_dtNewDrugInfo.Rows.Count < 1)
                {
                    MessageBox.Show("此时间段无新进药品！");
                }
                this.gcNewDrug.DataSource = this.m_dtNewDrugInfo.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "新药品查询错误");
            }
        }
        private void spbtnClose_Click(object sender, EventArgs e)
        {
            this.m_dtNewDrugInfo.Clear();
        }
        private void gvNewDrug_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = this.gvNewDrug.GetDataRow(e.FocusedRowHandle);
            try
            {
                this.strPham_std_code = dataRow["DRUG_STD_CODE"].ToString();
                string text = "";
                DataTable phamBasicDrugInfo = this.getPhamBasicDrugInfo(this.strPham_std_code);
                if (phamBasicDrugInfo != null)
                {
                    if (phamBasicDrugInfo.Rows.Count > 0)
                    {
                        DataRow dr = phamBasicDrugInfo.Rows[0];
                        this.richTextBox2.Text = this.getDrugInfo(this.strPham_std_code, dr, ref text);
                        this.richTextBox3.Text = text;
                    }
                }
                this.setpanelControlDrugInfo(this.strPham_std_code);
                DataTable dataTable = new DataTable();
                dataTable = this.getStorageQuantity(this.strPham_std_code);
                if (dataTable != null)
                {
                    this.gcStorage.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void rgPhamNameType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rgPhamNameType.SelectedIndex.Equals(0))
            {
                this.blPhamNameType = true;
                this.FillgcCode();
            }
            else
            {
                this.blPhamNameType = false;
                this.FillgcCode();
            }
        }
        private void FillgcCode()
        {
            string sQLString = string.Empty;
            if (this.blPhamNameType)
            {
                sQLString = "select '' as input_code,trade_name as drug_name,pham_code as drug_code from pham_basic_info where  trade_name is not null";
            }
            else
            {
                sQLString = "select '' as input_code,pham_name as drug_name,pham_code as drug_code from pham_basic_info where  trade_name is not null";
            }
            this.m_dtPYDrug = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            foreach (DataRow dataRow in this.m_dtPYDrug.Rows)
            {
                try
                {
                    string value = EmrSysPubFunction.IndexCode(dataRow["drug_name"].ToString());
                    if (!string.IsNullOrEmpty(value))
                    {
                        dataRow["input_code"] = value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.gcCode.DataSource = this.m_dtPYDrug;
        }
        private void gvMHData_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = this.gvMHData.GetDataRow(e.FocusedRowHandle);
            if (dataRow == null)
            {
                this.richTextBox2.Text = "";
            }
            else
            {
                this.strPham_std_code = dataRow["DRUG_CODE"].ToString();
                string str = "";
                string str2 = "";
                string str3 = "";
                string str4 = "";
                string str5 = "";
                string str6 = "";
                string str7 = "";
                string sQLString = "select * from pham_yzh1 where DRUG_CODE='" + this.strPham_std_code + "'";
                DataTable dataTable = new DataTable();
                dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    this.strPham_std_code = ((dataTable.Rows[0]["PHAM_STD_CODE"] == DBNull.Value) ? "" : dataTable.Rows[0]["PHAM_STD_CODE"].ToString());
                    str = ((dataTable.Rows[0]["TRADE_NAME"] == DBNull.Value) ? "" : dataTable.Rows[0]["TRADE_NAME"].ToString());
                    str2 = ((dataTable.Rows[0]["DETAIL_USAGE_1"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_1"].ToString());
                    str3 = ((dataTable.Rows[0]["DETAIL_USAGE_2"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_2"].ToString());
                    str4 = ((dataTable.Rows[0]["DETAIL_USAGE_5"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_5"].ToString());
                    str5 = ((dataTable.Rows[0]["DETAIL_USAGE_6"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_6"].ToString());
                    str6 = ((dataTable.Rows[0]["DETAIL_USAGE_8"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_8"].ToString());
                    str7 = ((dataTable.Rows[0]["DETAIL_USAGE_9"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_9"].ToString());
                }
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("【商品名称】\n\t" + str + "\n\r");
                stringBuilder.Append("【药品标准名】\n\t" + dataRow["DRUG_NAME"].ToString() + "\n\r");
                stringBuilder.Append("【药品英文名】\n\t" + dataRow["DRUG_E_NAME"].ToString() + "\n\r");
                stringBuilder.Append("【理化特性】\n\t" + str2 + "\n\r");
                stringBuilder.Append("【药品成分】\n\t" + str3 + "\n\r");
                stringBuilder.Append("【储藏方式】\n\t" + str4 + "\n\r");
                stringBuilder.Append("【包装规格】\n\t" + str5 + "\n\r");
                stringBuilder.Append("【药品效期】\n\t" + str6 + "\n\r");
                stringBuilder.Append("【其他信息】\n\t" + str7 + "\n\r");
                stringBuilder.Append("【作用机理】\n\t" + dataRow["ACTION"].ToString() + "\n\r");
                stringBuilder.Append("【适应症】\n\t" + dataRow["indication"].ToString() + "\n\r");
                stringBuilder.Append("【用法用量】\n\t" + dataRow["DOSAGE"].ToString() + "\n\r");
                stringBuilder.Append("【药物相互作用】\n\t" + dataRow["form"].ToString() + "\n\r");
                stringBuilder.Append("【不良反应】\n\t" + dataRow["adverse_reaction"].ToString() + "\n\r");
                stringBuilder.Append("【注意事项】\n\t" + dataRow["attention"].ToString() + "\n\r");
                stringBuilder.Append("【禁忌症】\n\t" + dataRow["contraindication"].ToString() + "\n\r");
                string text = "【禁忌症】 " + dataRow["contraindication"].ToString();
                this.richTextBox2.Text = stringBuilder.ToString();
                this.richTextBox3.Text = text;
                this.setpanelControlDrugInfo(this.strPham_std_code);
                DataTable dataTable2 = new DataTable();
                dataTable2 = this.getStorageQuantity(this.strPham_std_code);
                if (dataTable2 != null)
                {
                    this.gcStorage.DataSource = dataTable2;
                }
            }
        }
        private void btnClearMHData_Click(object sender, EventArgs e)
        {
            this.dt_DrugMHSearch.Clear();
        }
        private void btnMHSearch_Click(object sender, EventArgs e)
        {
            string text = "select drug_code,drug_name,drug_e_name,action,indication,dosage,form,pharmacokinetics,adverse_reaction,attention,contraindication,DRUG_NAME,DRUG_E_NAME,ACTION,DOSAGE,'' as TRADE_NAME,'' as DETAIL_USAGE_1,'' as DETAIL_USAGE_2,'' as DETAIL_USAGE_5,'' as DETAIL_USAGE_6,'' as DETAIL_USAGE_8,'' as DETAIL_USAGE_9 from drug_info";
            try
            {
                if (this.txtBoxCondition1.Text.Length > 0 || this.txtBoxCondition2.Text.Length > 0)
                {
                    if (this.txtBoxCondition1.Text.Length > 0)
                    {
                        text = text + " where " + this.getConditionString(this.cbBoxFiled1.SelectedItem.ToString().Trim(), this.txtBoxCondition1.Text.Trim());
                        if (this.txtBoxCondition2.Text.Length > 0)
                        {
                            if (this.comboBoxLogic.SelectedIndex == 0)
                            {
                                text += " and ";
                            }
                            else
                            {
                                if (this.comboBoxLogic.SelectedIndex != 1)
                                {
                                    this.comboBoxLogic.Focus();
                                    throw new Exception("请选择条件");
                                }
                                text += " or ";
                            }
                            text += this.getConditionString(this.cbBoxFiled2.SelectedItem.ToString().Trim(), this.txtBoxCondition2.Text.Trim());
                        }
                    }
                    else
                    {
                        if (this.txtBoxCondition2.Text.Length > 0)
                        {
                            text = text + " where " + this.getConditionString(this.cbBoxFiled2.SelectedItem.ToString().Trim(), this.txtBoxCondition2.Text.Trim());
                        }
                    }
                }
                this.dt_DrugMHSearch = DALUseSpecial.Query(text, this.m_strDBConnet).Tables[0];
                if (this.dt_DrugMHSearch.Rows.Count < 1)
                {
                    MessageBox.Show("此条件无匹配的内容，请重新输入条件！");
                }
                this.gcMHData.DataSource = this.dt_DrugMHSearch.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "药品模糊查询出错提示");
            }
        }
        private string getConditionString(string filedname, string searchText)
        {
            string result = "";
            switch (filedname)
            {
                case "英文名":
                    result = "drug_e_name like '%" + searchText + "%' ";
                    break;
                case "适应症":
                    result = "indication like '%" + searchText + "%' ";
                    break;
                case "药物相互作用":
                    result = "form like '%" + searchText + "%' ";
                    break;
                case "不良反应":
                    result = "adverse_reaction like '%" + searchText + "%' ";
                    break;
                case "注意事项":
                    result = "attention like '%" + searchText + "%' ";
                    break;
                case "禁忌症":
                    result = "contraindication like '%" + searchText + "%' ";
                    break;
                case "药物名称":
                    result = "drug_name like '%" + searchText + "%' ";
                    break;
            }
            return result;
        }
        private void FillDrugSort()
        {
            this.trvDrug.Nodes.Clear();
            DataTable dataTable = new DataTable();
            string sQLString = string.Empty;
            sQLString = "SELECT  PHAM_NAME,PHAM_CODE  FROM INSIDE_CODE_DICT  WHERE length(rtrim(PHAM_CODE)) = 1";
            dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            foreach (DataRow dataRow in dataTable.Rows)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = dataRow["PHAM_NAME"].ToString();
                treeNode.Name = dataRow["PHAM_CODE"].ToString();
                treeNode.Tag = "1";
                this.trvDrug.Nodes.Add(treeNode);
            }
        }
        private void FillDrugSort2(TreeNode tn1)
        {
            if (tn1.GetNodeCount(true) == 0)
            {
                tn1.Nodes.Clear();
                DataTable dataTable = new DataTable();
                string sQLString = "SELECT  PHAM_NAME,PHAM_CODE  FROM INSIDE_CODE_DICT  WHERE length(rtrim(PHAM_CODE)) = 3 and substr(PHAM_CODE,1,1 ) ='" + tn1.Name + "'";
                dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Text = dataRow["PHAM_NAME"].ToString();
                    treeNode.Name = dataRow["PHAM_CODE"].ToString();
                    treeNode.Tag = "2";
                    tn1.Nodes.Add(treeNode);
                }
            }
        }
        private void FillDrugSort3(TreeNode tn2)
        {
            if (tn2.GetNodeCount(true) == 0)
            {
                tn2.Nodes.Clear();
                string sQLString = "SELECT  PHAM_NAME,PHAM_CODE  FROM INSIDE_CODE_DICT  WHERE length(rtrim(PHAM_CODE)) = 4 and substr(PHAM_CODE,1,3 ) ='" + tn2.Name + "'";
                DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Text = dataRow["PHAM_NAME"].ToString();
                    treeNode.Name = dataRow["PHAM_CODE"].ToString();
                    treeNode.Tag = "3";
                    tn2.Nodes.Add(treeNode);
                }
            }
        }
        private void FillDrugSort4(TreeNode tn3)
        {
            if (tn3.GetNodeCount(true) == 0)
            {
                tn3.Nodes.Clear();
                string sQLString = "SELECT  PHAM_NAME,PHAM_CODE  FROM INSIDE_CODE_DICT  WHERE length(rtrim(PHAM_CODE)) = 5 and substr(PHAM_CODE,1,4 ) ='" + tn3.Name + "'";
                DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Text = dataRow["PHAM_NAME"].ToString();
                    treeNode.Name = dataRow["PHAM_CODE"].ToString();
                    treeNode.Tag = "4";
                    tn3.Nodes.Add(treeNode);
                }
            }
        }
        private void FillDrugSort5(TreeNode tn4)
        {
            if (tn4.GetNodeCount(true) == 0)
            {
                tn4.Nodes.Clear();
                string sQLString = "SELECT  PHAM_NAME,PHAM_STD_CODE  FROM PHAM_BASIC_INFO  WHERE  substr(PHAM_STD_CODE,1,5 ) ='" + tn4.Name + "'";
                DataTable dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Text = dataRow["PHAM_NAME"].ToString();
                    treeNode.Name = dataRow["PHAM_STD_CODE"].ToString();
                    treeNode.Tag = "5";
                    tn4.Nodes.Add(treeNode);
                }
            }
        }
        private void tabDrug_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabDrug.SelectedIndex == 3)
            {
                this.FillDrugSort();
            }
        }
        private void trvDrug_DoubleClick(object sender, EventArgs e)
        {
            if (this.trvDrug.SelectedNode != null)
            {
                if (this.trvDrug.SelectedNode.Tag == "5")
                {
                    this.strPham_std_code = this.trvDrug.SelectedNode.Name;
                    DataTable phamBasicDrugInfo = this.getPhamBasicDrugInfo(this.strPham_std_code);
                    string text = "";
                    if (phamBasicDrugInfo.Rows.Count > 0)
                    {
                        DataRow dr = phamBasicDrugInfo.Rows[0];
                        this.richTextBox2.Text = this.getDrugInfo(this.strPham_std_code, dr, ref text);
                        this.richTextBox3.Text = text;
                        this.setpanelControlDrugInfo(this.strPham_std_code);
                        DataTable dataTable = new DataTable();
                        dataTable = this.getStorageQuantity(this.strPham_std_code);
                        if (dataTable != null)
                        {
                            this.gcStorage.DataSource = dataTable;
                        }
                    }
                    else
                    {
                        this.richTextBox2.Text = "";
                    }
                }
            }
        }
        private void trvDrug_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string text = e.Node.Tag.ToString();
            if (text != null)
            {
                if (!(text == "1"))
                {
                    if (!(text == "2"))
                    {
                        if (!(text == "3"))
                        {
                            if (text == "4")
                            {
                                this.FillDrugSort5(e.Node);
                            }
                        }
                        else
                        {
                            this.FillDrugSort4(e.Node);
                        }
                    }
                    else
                    {
                        this.FillDrugSort3(e.Node);
                    }
                }
                else
                {
                    this.FillDrugSort2(e.Node);
                }
            }
        }
        private DataSet getPhamBasicInfo(string phamStdCode)
        {
            DataSet dataSet = new DataSet();
            string text = "SELECT  pham_name,pham_spec,pham_unit,pham_form,retail_price,toxicology_property ,special_sign,manage_level,use_or_not";
            text = text + " from pham_basic_info WHERE PHAM_STD_CODE = '" + phamStdCode + "'";
            dataSet = DALUseSpecial.Query(text, this.m_strDBConnet);
            DataSet result;
            if (dataSet != null)
            {
                result = dataSet;
            }
            else
            {
                result = null;
            }
            return result;
        }
        private void setpanelControlDrugInfo(string phamStdCode)
        {
            DataTable dataTable = this.getPhamBasicInfo(phamStdCode).Tables[0];
            if (dataTable.Rows.Count > 0)
            {
                this.textBox1.Text = ((dataTable.Rows[0]["PHAM_FORM"] == DBNull.Value) ? "" : dataTable.Rows[0]["PHAM_FORM"].ToString());
                this.textBox2.Text = ((dataTable.Rows[0]["RETAIL_PRICE"] == DBNull.Value) ? "" : dataTable.Rows[0]["RETAIL_PRICE"].ToString());
                this.textBox3.Text = ((dataTable.Rows[0]["TOXICOLOGY_PROPERTY"] == DBNull.Value) ? "" : dataTable.Rows[0]["TOXICOLOGY_PROPERTY"].ToString());
                this.textBox4.Text = ((dataTable.Rows[0]["SPECIAL_SIGN"] == DBNull.Value) ? "" : dataTable.Rows[0]["SPECIAL_SIGN"].ToString());
                this.textBox5.Text = ((dataTable.Rows[0]["PHAM_UNIT"] == DBNull.Value) ? "" : dataTable.Rows[0]["PHAM_UNIT"].ToString());
                this.textBox6.Text = ((dataTable.Rows[0]["MANAGE_LEVEL"] == DBNull.Value) ? "" : dataTable.Rows[0]["MANAGE_LEVEL"].ToString());
                string text = this.textBox6.Text;
                if (text != null)
                {
                    if (!(text == "A"))
                    {
                        if (!(text == "B"))
                        {
                            if (text == "C")
                            {
                                this.textBox6.Text = "特殊使用";
                            }
                        }
                        else
                        {
                            this.textBox6.Text = "限制使用";
                        }
                    }
                    else
                    {
                        this.textBox6.Text = "非限制使用";
                    }
                }
                this.label1.Text = ((dataTable.Rows[0]["USE_OR_NOT"] == DBNull.Value) ? "" : dataTable.Rows[0]["USE_OR_NOT"].ToString());
                text = this.label1.Text;
                if (text != null)
                {
                    if (!(text == "1"))
                    {
                        if (text == "0")
                        {
                            this.label1.Text = "停用";
                            this.label1.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        this.label1.Text = "在用";
                        this.label1.ForeColor = Color.Black;
                    }
                }
            }
        }
        private DataSet getStorage()
        {
            DataSet dataSet = new DataSet();
            string text = "SELECT  PHAM_STORAGE_DEPT.DEPT_CODE , DEPT_DICT.DEPT_NAME,PHAM_STORAGE_DEPT.STORAGE_TYPE     ";
            text += "  FROM DEPT_DICT ,PHAM_STORAGE_DEPT WHERE ( DEPT_DICT.DEPT_CODE = PHAM_STORAGE_DEPT.DEPT_CODE )  ";
            dataSet = DALUseSpecial.Query(text, this.m_strDBConnet);
            DataSet result;
            if (dataSet != null)
            {
                result = dataSet;
            }
            else
            {
                result = null;
            }
            return result;
        }
        private DataTable getStorageQuantity(string strphamStdCode)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("DEPT_NAME", typeof(string));
            dataTable.Columns.Add("QUANTITY", typeof(string));
            if (this.m_dsStorage != null)
            {
                if (this.m_dsStorage.Tables.Count > 0)
                {
                    if (this.m_dsStorage.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dataRow in this.m_dsStorage.Tables[0].Rows)
                        {
                            DataRow dataRow2 = dataTable.NewRow();
                            int outpOrInpDispensaryStock = this.getOutpOrInpDispensaryStock(strphamStdCode, dataRow["DEPT_CODE"].ToString(), dataRow["STORAGE_TYPE"].ToString());
                            if (outpOrInpDispensaryStock > 0)
                            {
                                dataRow2["DEPT_NAME"] = dataRow["DEPT_NAME"].ToString();
                                dataRow2["QUANTITY"] = outpOrInpDispensaryStock.ToString();
                                dataTable.Rows.Add(dataRow2);
                            }
                        }
                    }
                }
            }
            return dataTable;
        }
        private int getOutpOrInpDispensaryStock(string phamStdCode, string strDeptCode, string strStorageType)
        {
            int result = 0;
            if (strStorageType != null)
            {
                if (!(strStorageType == "门诊药局"))
                {
                    if (strStorageType == "临床药局")
                    {
                        string text = " SELECT sum(a.QUANTITY)  FROM INP_DISPENSARY_STOCK a, PHAM_BASIC_INFO b WHERE (a.PHAM_STD_CODE = b.PHAM_STD_CODE)";
                        string text2 = text;
                        text = string.Concat(new string[]
						{
							text2,
							" and ((a.DISPENSARY = '",
							strDeptCode,
							"') AND   (a.PHAM_STD_CODE = '",
							phamStdCode,
							"')) GROUP BY a.PHAM_STD_CODE"
						});
                        object single = DALUseSpecial.GetSingle(text, this.m_strDBConnet);
                        if (single != null)
                        {
                            result = Convert.ToInt32(single.ToString());
                        }
                    }
                }
                else
                {
                    string text = "SELECT sum(b.QUANTITY) as QUANTITY FROM PHAM_BASIC_INFO a, OUTP_DISPENSARY_STOCK b ";
                    text = text + "  WHERE (a.PHAM_STD_CODE = b.PHAM_STD_CODE)   and ((b.DISPENSARY ='" + strDeptCode + "') AND";
                    text = text + "  (b.PHAM_STD_CODE = '" + phamStdCode + "')) GROUP BY b.PHAM_STD_CODE";
                    object single = DALUseSpecial.GetSingle(text, this.m_strDBConnet);
                    if (single != null)
                    {
                        result = Convert.ToInt32(single.ToString());
                    }
                }
            }
            return result;
        }
        private string getDrugInfo(string strPhamStdCode, DataRow dr, ref string contraindication)
        {
            string str = "";
            string str2 = "";
            string str3 = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string str7 = "";
            string sQLString = "select * from pham_yzh1 where pham_std_code='" + strPhamStdCode + "'";
            DataTable dataTable = new DataTable();
            dataTable = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (dataTable.Rows.Count > 0)
            {
                str = ((dataTable.Rows[0]["TRADE_NAME"] == DBNull.Value) ? "" : dataTable.Rows[0]["TRADE_NAME"].ToString());
                str2 = ((dataTable.Rows[0]["DETAIL_USAGE_1"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_1"].ToString());
                str3 = ((dataTable.Rows[0]["DETAIL_USAGE_2"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_2"].ToString());
                str4 = ((dataTable.Rows[0]["DETAIL_USAGE_5"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_5"].ToString());
                str5 = ((dataTable.Rows[0]["DETAIL_USAGE_6"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_6"].ToString());
                str6 = ((dataTable.Rows[0]["DETAIL_USAGE_8"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_8"].ToString());
                str7 = ((dataTable.Rows[0]["DETAIL_USAGE_9"] == DBNull.Value) ? "" : dataTable.Rows[0]["DETAIL_USAGE_9"].ToString());
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("【商品名称】\n\t" + str + "\n\r");
            stringBuilder.Append("【药品标准名】\n\t" + dr["DRUG_NAME"].ToString() + "\n\r");
            stringBuilder.Append("【药品英文名】\n\t" + dr["DRUG_E_NAME"].ToString() + "\n\r");
            stringBuilder.Append("【理化特性】\n\t" + str2 + "\n\r");
            stringBuilder.Append("【药品成分】\n\t" + str3 + "\n\r");
            stringBuilder.Append("【储藏方式】\n\t" + str4 + "\n\r");
            stringBuilder.Append("【包装规格】\n\t" + str5 + "\n\r");
            stringBuilder.Append("【药品效期】\n\t" + str6 + "\n\r");
            stringBuilder.Append("【其他信息】\n\t" + str7 + "\n\r");
            stringBuilder.Append("【作用机理】\n\t" + dr["ACTION"].ToString() + "\n\r");
            stringBuilder.Append("【适应症】\n\t" + dr["indication"].ToString() + "\n\r");
            stringBuilder.Append("【用法用量】\n\t" + dr["DOSAGE"].ToString() + "\n\r");
            stringBuilder.Append("【药物相互作用】\n\t" + dr["form"].ToString() + "\n\r");
            stringBuilder.Append("【不良反应】\n\t" + dr["adverse_reaction"].ToString() + "\n\r");
            stringBuilder.Append("【注意事项】\n\t" + dr["attention"].ToString() + "\n\r");
            stringBuilder.Append("【禁忌症】\n\t" + dr["contraindication"].ToString() + "\n\r");
            contraindication = "【禁忌症】 " + dr["contraindication"].ToString();
            return stringBuilder.ToString();
        }
        private DataTable getPhamBasicDrugInfo(string strPhamStdCode)
        {
            string sQLString = "  select a.PHAM_STD_CODE,a.pham_code as drug_code,a.pham_name as drug_name,a.pham_spec as item_spec,a.pham_unit as units,a.RETAIL_PRICE as price  ,b.indication,b.form,b.adverse_reaction,b.attention,b.contraindication  ,b.DRUG_NAME,b.DRUG_E_NAME,b.ACTION,b.DOSAGE from pham_basic_info a,drug_info b where a.PHAM_STD_CODE='" + strPhamStdCode + "' and substr(a.pham_code,0,7)=b.drug_code(+) ";
            return DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                foreach (Control control in this.panelControlDrugInfo.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(this.panelControlDrugInfo.Controls, (TextBox)sender);
                instance.loadData("DIAGNOSIS", "DIAGNOSIS", "");
                instance.Name = "input";
                this.panelControlDrugInfo.Controls.Add(instance);
                this.panelControlDrugInfo.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < this.panelControlDrugInfo.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                else
                {
                    instance.Location = new Point(this.panelControlDrugInfo.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }

        #region EmrEditUCInterface 成员

        public bool cmdCheckIsUnSave()
        {
            return false;
        }

        public bool getCloseFlag()
        {
            return false;
        }

        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            
        }

        #endregion
    }
}
