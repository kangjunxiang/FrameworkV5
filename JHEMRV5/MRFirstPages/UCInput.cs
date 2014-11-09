using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using JHEMR.EmrSysDAL;
using JHEMR.EmrSysCom;

namespace JHEMR.MRFirstPages
{
    public partial class UCInput : UserControl
    {
        private const int WM_CHAR = 258;
        private const int WM_DOWN = 256;
        private Control.ControlCollection _controls;
        private static DataTable dtData;
        private TextBox text;
        private static UCInput _instance;
        private KeyEventHandler handletext_KeyDown;
        private EventHandler handletext_TextChanged;
        private KeyPressEventHandler handletext_KeyPress;
        private EventHandler handletext_LostFocus;
        public UCInput()
        {
            InitializeComponent();
            this.dataGridView1.RegisterExistHeaderColumn();
        }
        public void loadData()
        {
            string sQLString = "select a.user_id,a.user_name,'' as pym ,b.DEPT_NAME from users a  left join dept_dict b  on a.user_dept = b.DEPT_CODE where  1=2";
            UCInput.dtData = DALUse.Query(sQLString).Tables[0];
            sQLString = "select a.user_id,a.user_name,'' as pym ,b.DEPT_NAME from users a  left join dept_dict b  on a.user_dept = b.DEPT_CODE where   b.clinic_attr = 0 and (b.outp_or_inp = 1or b.outp_or_inp = 2)and a.user_dept = '" + EmrSysPubVar.getDeptCode() + "'";
            DataTable dataTable = DALUse.Query(sQLString).Tables[0];
            foreach (DataRow dataRow in dataTable.Rows)
            {
                DataRow dataRow2 = UCInput.dtData.NewRow();
                dataRow2["user_id"] = dataRow["user_id"];
                dataRow2["user_name"] = dataRow["user_name"];
                dataRow2["pym"] = dataRow["pym"];
                dataRow2["DEPT_NAME"] = dataRow["DEPT_NAME"];
                UCInput.dtData.Rows.Add(dataRow2);
            }
            sQLString = "select a.user_id,a.user_name,'' as pym ,b.DEPT_NAME from users a  left join dept_dict b  on a.user_dept = b.DEPT_CODE where   b.clinic_attr = 0 and (b.outp_or_inp = 1or b.outp_or_inp = 2) and a.user_dept <> '" + EmrSysPubVar.getDeptCode() + "'";
            dataTable = DALUse.Query(sQLString).Tables[0];
            foreach (DataRow dataRow in dataTable.Rows)
            {
                DataRow dataRow2 = UCInput.dtData.NewRow();
                dataRow2["user_id"] = dataRow["user_id"];
                dataRow2["user_name"] = dataRow["user_name"];
                dataRow2["pym"] = dataRow["pym"];
                dataRow2["DEPT_NAME"] = dataRow["DEPT_NAME"];
                UCInput.dtData.Rows.Add(dataRow2);
            }
            foreach (DataRow dataRow in UCInput.dtData.Rows)
            {
                try
                {
                    string value = EmrSysPubFunction.IndexCode(dataRow["user_name"].ToString());
                    if (!string.IsNullOrEmpty(value))
                    {
                        dataRow["pym"] = value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.filter();
        }
        private void text_LostFocus(object sender, EventArgs e)
        {
            foreach (Control control in this._controls)
            {
                if (control.Name == "input")
                {
                    this.text.Focus();
                }
            }
        }
        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                UCInput.SendMessage(this.dataGridView1.Handle, 256, e.KeyValue, e.KeyValue);
            }
        }
        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                foreach (Control control in this._controls)
                {
                    if (control.Name == "input")
                    {
                        this._controls.Remove(control);
                    }
                }
            }
            else
            {
                if (e.KeyChar == '\r')
                {
                    this.GetName();
                    foreach (Control control in this._controls)
                    {
                        if (control.Name == "input")
                        {
                            this._controls.Remove(control);
                        }
                    }
                }
            }
        }
        private void text_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                foreach (Control control in this._controls)
                {
                    if (control.Name == "input")
                    {
                        this._controls.Remove(control);
                    }
                }
            }
            else
            {
                this.filter();
            }
        }
        public static UCInput GetInstance()
        {
            if (UCInput._instance == null)
            {
                UCInput._instance = new UCInput();
            }
            return UCInput._instance;
        }
        public void setOwner(Control.ControlCollection controls, TextBox input)
        {
            if (this.handletext_KeyDown != null)
            {
                this.text.KeyDown -= this.handletext_KeyDown;
            }
            if (this.handletext_TextChanged != null)
            {
                this.text.TextChanged -= this.handletext_TextChanged;
            }
            if (this.handletext_KeyPress != null)
            {
                this.text.KeyPress -= this.handletext_KeyPress;
            }
            if (this.handletext_LostFocus != null)
            {
                this.text.LostFocus -= this.handletext_LostFocus;
            }
            this._controls = controls;
            this.text = input;
            this.handletext_TextChanged = new EventHandler(this.text_TextChanged);
            this.text.TextChanged += this.handletext_TextChanged;
            this.handletext_KeyPress = new KeyPressEventHandler(this.text_KeyPress);
            this.text.KeyPress += this.handletext_KeyPress;
            this.handletext_KeyDown = new KeyEventHandler(this.text_KeyDown);
            this.text.KeyDown += this.handletext_KeyDown;
            this.handletext_LostFocus = new EventHandler(this.text_LostFocus);
            this.text.LostFocus += new EventHandler(this.handletext_LostFocus.Invoke);
        }
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public void filter()
        {
            base.ResumeLayout(false);
            DataView dataView = new DataView(UCInput.dtData);
            if (!string.IsNullOrEmpty(this.text.Text))
            {
                dataView.RowFilter = "PYM like '" + this.text.Text + "%'";
            }
            this.dataGridView1.DataSource = dataView;
            if (this.dataGridView1.RowCount > 0)
            {
                this.dataGridView1.Rows[0].Selected = true;
            }
            base.ResumeLayout(true);
        }
        public void GetName()
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                this.text.Tag = this.dataGridView1.SelectedRows[0].Cells["user_id"].Value.ToString();
                this.text.Text = this.dataGridView1.SelectedRows[0].Cells["user_name"].Value.ToString();
                this.text.SelectAll();
                SendKeys.Send("{tab}");
            }
        }
        private void UCInput_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.text.Focus();
            UCInput.SendMessage(this.text.Handle, 258, (int)e.KeyChar, (int)e.KeyChar);
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.GetName();
            foreach (Control control in this._controls)
            {
                if (control.Name == "input")
                {
                    this._controls.Remove(control);
                }
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.GetName();
            foreach (Control control in this._controls)
            {
                if (control.Name == "input")
                {
                    this._controls.Remove(control);
                    break;
                }
            }
        }
    }
}
