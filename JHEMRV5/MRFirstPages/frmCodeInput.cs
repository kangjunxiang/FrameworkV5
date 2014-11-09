using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;
using System.Runtime.InteropServices;

namespace JHEMR.MRFirstPages
{
    public partial class frmCodeInput : Form
    {
        private const int IME_CMODE_FULLSHAPE = 8;
        private const int IME_CHOTKEY_SHAPE_TOGGLE = 17;
        private const int IME_THotKey_IME_NonIME_Toggle = 112;
        private codeStruc pcodeStruc = new codeStruc();
        private string m_strSQL = "";
        private string m_strSubClass = "";
        private string m_strFilter = "";
        private DataTable objDataTableDict = null;
        private bool m_bDisableIME = false;
        private bool m_bImmOpenStatus = false;


        [DllImport("imm32.dll")]
        public static extern IntPtr ImmGetContext(IntPtr hwnd);
        [DllImport("imm32.dll")]
        public static extern bool ImmGetOpenStatus(IntPtr himc);
        [DllImport("imm32.dll")]
        public static extern bool ImmSetOpenStatus(IntPtr himc, bool b);
        [DllImport("imm32.dll")]
        public static extern bool ImmGetConversionStatus(IntPtr himc, ref int lpdw, ref int lpdw2);
        [DllImport("imm32.dll")]
        public static extern int ImmSimulateHotKey(IntPtr hwnd, int lngHotkey);
        public frmCodeInput()
        {
            this.InitializeComponent();
            IntPtr himc = frmCodeInput.ImmGetContext(base.Handle);
            this.m_bImmOpenStatus = frmCodeInput.ImmGetOpenStatus(himc);
        }
        public void setDictName(string strDictName, string strSubClass)
        {
            this.m_strSQL = strDictName;
        }
        public void setDictTable(DataTable dt)
        {
            this.objDataTableDict = dt;
        }
        public void disableIME(bool bDisable)
        {
            this.m_bDisableIME = bDisable;
        }

        public codeStruc getCodeStruc()
        {
            return this.pcodeStruc;
        }
        private void frmCodeInput_Load(object sender, EventArgs e)
        {
            if (this.m_strSQL.Length > 0)
            {
                this.objDataTableDict = DALUse.Query(this.m_strSQL).Tables[0];
                if (this.objDataTableDict != null)
                {
                    this.dgvDict.DataSource = this.objDataTableDict.DefaultView;
                }
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (this.objDataTableDict != null)
            {
                if (this.rbÆ´Òô.Checked)
                {
                    this.objDataTableDict.DefaultView.RowFilter = this.m_strFilter + "ÊäÈëÂë like '" + this.txtPhone.Text.Replace("'", "''").ToUpper() + "%'";
                }
                if (this.rbÃû³Æ.Checked)
                {
                    this.objDataTableDict.DefaultView.RowFilter = this.m_strFilter + "Ãû³Æ like '%" + this.txtPhone.Text.Replace("'", "''") + "%'";
                }
                if (this.rb±àÂë.Checked)
                {
                    this.objDataTableDict.DefaultView.RowFilter = this.m_strFilter + "±àÂë like '%" + this.txtPhone.Text.Replace("'", "''") + "%'";
                }
            }
        }
        private void dgvDict_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvDict.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = this.dgvDict.SelectedRows[0];
                this.pcodeStruc.codename = dataGridViewRow.Cells["Ãû³Æ"].Value.ToString();
                this.pcodeStruc.codeitem = dataGridViewRow.Cells["±àÂë"].Value.ToString();
                this.pcodeStruc.codephone = dataGridViewRow.Cells["ÊäÈëÂë"].Value.ToString();
                base.DialogResult = DialogResult.OK;
                base.Close();
            }
        }
        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.dgvDict.SelectedRows.Count > 0)
                {
                    this.dgvDict.Focus();
                    DataGridViewRow dataGridViewRow = this.dgvDict.SelectedRows[0];
                    this.pcodeStruc.codename = dataGridViewRow.Cells["Ãû³Æ"].Value.ToString();
                    this.pcodeStruc.codeitem = dataGridViewRow.Cells["±àÂë"].Value.ToString();
                    this.pcodeStruc.codephone = dataGridViewRow.Cells["ÊäÈëÂë"].Value.ToString();
                    base.DialogResult = DialogResult.OK;
                    base.Close();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    base.Close();
                }
            }
        }
        private void rbÆ´Òô_CheckedChanged(object sender, EventArgs e)
        {
            this.objDataTableDict.DefaultView.RowFilter = "";
            if (this.m_strSubClass.Length > 0)
            {
                this.objDataTableDict.DefaultView.RowFilter = "CLASS_CODE='" + this.m_strSubClass + "'";
            }
            this.txtPhone.Text = "";
            this.txtPhone.Focus();
        }
        private void rbÃû³Æ_CheckedChanged(object sender, EventArgs e)
        {
            this.objDataTableDict.DefaultView.RowFilter = "";
            if (this.m_strSubClass.Length > 0)
            {
                this.objDataTableDict.DefaultView.RowFilter = "CLASS_CODE='" + this.m_strSubClass + "'";
            }
            this.txtPhone.Text = "";
            this.txtPhone.Focus();
        }
        private void rb±àÂë_CheckedChanged(object sender, EventArgs e)
        {
            this.objDataTableDict.DefaultView.RowFilter = "";
            if (this.m_strSubClass.Length > 0)
            {
                this.objDataTableDict.DefaultView.RowFilter = "CLASS_CODE='" + this.m_strSubClass + "'";
            }
            this.txtPhone.Text = "";
            this.txtPhone.Focus();
        }
        private void frmCodeInput_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void frmCodeInput_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void frmCodeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtPhone.Focused)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        this.dgvDict.Focus();
                        SendKeys.Send("{UP}");
                        break;
                    case Keys.Down:
                        this.dgvDict.Focus();
                        SendKeys.Send("{DOWN}");
                        break;
                }
            }
            if (this.dgvDict.Focused)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        this.txtPhone.Focus();
                        SendKeys.Send("{LEFT}");
                        break;
                    case Keys.Right:
                        this.txtPhone.Focus();
                        SendKeys.Send("{RIGHT}");
                        break;
                }
            }
        }
        private void dgvDict_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtPhone_KeyDown(sender, e);
        }
    }
}