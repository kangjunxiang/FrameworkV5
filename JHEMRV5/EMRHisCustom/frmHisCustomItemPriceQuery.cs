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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmHisCustomItemPriceQuery : DevExpress.XtraEditors.XtraForm
    {
        private string m_strDBConnet = "HISConnect";
        private DataTable m_dtItemClass = new DataTable();
        private DataTable m_dtInsuranceType = new DataTable();
        private DataTable m_dtYBList = new DataTable();
        private DataTable m_dtjdmf = new DataTable();
        private DataTable m_dtjb = new DataTable();
        public frmHisCustomItemPriceQuery()
        {
            InitializeComponent();
        }
        private void frmHisCustomItemPriceQuery_Load(object sender, EventArgs e)
        {
            this.FillInitTable();
        }
        private void FillInitTable()
        {
            string sQLString = string.Empty;
            sQLString = "SELECT insurance_type_name from insurance_type_dict where insurance_type_name like '%医保'";
            this.m_dtInsuranceType = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (this.m_dtInsuranceType.Rows.Count > 0)
            {
                foreach (DataRow dataRow in this.m_dtInsuranceType.Rows)
                {
                    this.cmbYblb.Items.Add(dataRow["insurance_type_name"].ToString());
                }
                this.cmbYblb.Text = "市医保";
            }
            sQLString = "SELECT CLASS_CODE,CLASS_NAME FROM bill_item_class_dict ORDER BY SERIAL_NO ASC";
            this.m_dtItemClass = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
            if (this.m_dtItemClass.Rows.Count > 0)
            {
                foreach (DataRow dataRow2 in this.m_dtItemClass.Rows)
                {
                    this.cmbClass.Items.Add(dataRow2["CLASS_CODE"].ToString() + "  " + dataRow2["CLASS_NAME"].ToString());
                }
                this.cmbClass.SelectedIndex = 0;
            }
        }
        private void FillGridYB(int nFlag, string strYBLB, string strClass, string strCode)
        {
            switch (nFlag)
            {
                case 0:
                    {
                        string sQLString = string.Concat(new string[]
				{
					"SELECT  a.INSURANCE_TYPE,b.ITEM_NAME,a.ITEM_SPEC,a.PROPORTION_NUMERATOR,a.REIMBURSE_LIMIT,a.CLASSIFY,a.ORIGIN,a.REMARK  FROM PAY_SPECIAL_EXCEPT_DICT a,PRICE_LIST b WHERE (b.ITEM_CLASS = a.ITEM_CLASS) and (b.ITEM_CODE = a.ITEM_CODE) and (b.ITEM_SPEC = a.ITEM_SPEC)  and (b.STOP_DATE is null) and (a.INSURANCE_TYPE like '",
					strYBLB,
					"' ) and ( a.ITEM_CLASS = '",
					strClass,
					"' ) and ( a.ITEM_CODE like '",
					strCode,
					"' )"
				});
                        this.m_dtYBList = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                        this.gridControlYB.DataSource = this.m_dtYBList;
                        break;
                    }
                case 1:
                    {
                        string sQLString = string.Concat(new string[]
				{
					"SELECT  a.ITEM_NAME, b.ITEM_SPEC,a.UNITS,a.PRICE,b.PROPORTION_NUMERATOR, b.REIMBURSE_LIMIT  FROM PRICE_LIST a,PAY_SPECIAL_EXCEPT_DICT b  WHERE (a.ITEM_CLASS = b.ITEM_CLASS) and (a.ITEM_CODE = b.ITEM_CODE) and (a.ITEM_SPEC = b.ITEM_SPEC)  and ((b.INSURANCE_TYPE = '免费医疗') And (a.STOP_DATE is null) And (b.ITEM_CLASS = '",
					strClass,
					"') And ( b.ITEM_CODE like '",
					strCode,
					"' ) )"
				});
                        this.m_dtjdmf = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                        this.gcjdmf.DataSource = this.m_dtjdmf;
                        break;
                    }
                case 2:
                    {
                        string sQLString = string.Concat(new string[]
				{
					"SELECT  a.ITEM_NAME,a.ITEM_SPEC,a.UNITS,a.PRICE  FROM PRICE_LIST a WHERE (a.ITEM_CLASS ='",
					strClass,
					"' ) And ( a.ITEM_CODE like '",
					strCode,
					"' ) and ( a.STOP_DATE is null )"
				});
                        this.m_dtjb = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                        this.gcjb.DataSource = this.m_dtjb;
                        break;
                    }
            }
        }
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void sbtnQuery_Click(object sender, EventArgs e)
        {
            string empty = string.Empty;
            string strYBLB = string.Empty;
            string strClass = string.Empty;
            string strCode = string.Empty;
            if (this.rdgItem.SelectedIndex == 0)
            {
                if (this.cmbYblb.Text.Length < 0)
                {
                    this.cmbYblb.Text = "市医保";
                }
                strYBLB = this.cmbYblb.Text.Trim() + "%";
                if (this.cmbClass.Text.Length < 0)
                {
                    this.cmbClass.SelectedIndex = 0;
                }
                strClass = this.cmbClass.Text.Substring(0, 1);
                if (this.txtItem.Text.Trim().Length < 1)
                {
                    strCode = "%%";
                }
                else
                {
                    strCode = this.txtItem.Tag.ToString();
                }
                this.FillGridYB(0, strYBLB, strClass, strCode);
            }
            else
            {
                strYBLB = this.cmbYblb.Text.Trim() + "%";
                if (this.cmbClass.Text.Length < 0)
                {
                    this.cmbClass.SelectedIndex = 0;
                }
                strClass = this.cmbClass.Text.Substring(0, 1);
                if (this.txtItem.Text.Trim().Length < 1)
                {
                    strCode = "%%";
                }
                else
                {
                    strCode = this.txtItem.Tag.ToString();
                }
                this.FillGridYB(this.rdgItem.SelectedIndex, "", strClass, strCode);
            }
        }
        private void rdgItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rdgItem.SelectedIndex == 0)
            {
                this.m_dtYBList.Clear();
                this.gridControlYB.Visible = true;
                this.gcjdmf.Visible = false;
                this.gcjb.Visible = false;
                this.cmbClass.SelectedIndex = 0;
                this.cmbYblb.Text = "市医保";
                this.cmbYblb.Enabled = true;
                this.txtItem.Text = "";
                this.txtItem.Focus();
            }
            else
            {
                if (this.rdgItem.SelectedIndex == 1)
                {
                    this.m_dtjdmf.Clear();
                    this.gridControlYB.Visible = false;
                    this.gcjdmf.Visible = true;
                    this.gcjb.Visible = false;
                    this.cmbClass.SelectedIndex = 0;
                    this.cmbYblb.Text = "市医保";
                    this.cmbYblb.Enabled = false;
                    this.txtItem.Text = "";
                    this.txtItem.Focus();
                }
                else
                {
                    this.m_dtjb.Clear();
                    this.gridControlYB.Visible = false;
                    this.gcjdmf.Visible = false;
                    this.gcjb.Visible = true;
                    this.cmbClass.SelectedIndex = 0;
                    this.cmbYblb.Text = "市医保";
                    this.cmbYblb.Enabled = false;
                    this.txtItem.Text = "";
                    this.txtItem.Focus();
                }
            }
        }
        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                this.txtItem.Text = "";
                foreach (Control control in base.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(base.Controls, (TextBox)sender);
                instance.loadData("DRUG", this.cmbClass.Text.Substring(0, 1), "");
                instance.Name = "input";
                base.Controls.Add(instance);
                base.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X + instance.Width / 2, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 12);
                }
                else
                {
                    instance.Location = new Point(base.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void sbtnClear_Click(object sender, EventArgs e)
        {
            this.rdgItem.SelectedIndex = 0;
        }
    }
}