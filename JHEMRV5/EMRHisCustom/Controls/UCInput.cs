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

namespace JHEMR.EMRHisCustom
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
        private string m_strDBConnet = "HISConnect";
        public UCInput()
        {
            InitializeComponent();
        }
        public void loadData(string strFlag, string strCondition1, string strCondition2)
        {
            string sQLString = string.Empty;
            if (strFlag == "DIAGNOSIS")
            {
                sQLString = "select input_code as PYM,diagnosis_name as NAME,diagnosis_code as ITEM_CODE from diagnosis_dict order by input_code";
                UCInput.dtData = DALUse.Query(sQLString).Tables[0];
            }
            else
            {
                if (strFlag == "OPER_USER")
                {
                    if (strCondition1.Length >= 4)
                    {
                        sQLString = "select distinct ''as pym,a.doctor_name as NAME,a.doctor_id as ITEM_CODE from operation_doctor_dict a where substr(a.dept_code,0,4)='" + strCondition1.Substring(0, 4) + "'";
                    }
                    else
                    {
                        sQLString = "select distinct ''as pym,a.doctor_name as NAME,a.doctor_id as ITEM_CODE from operation_doctor_dict a where substr(a.dept_code,0,4)='" + strCondition1 + "'";
                    }
                    UCInput.dtData = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                    foreach (DataRow dataRow in UCInput.dtData.Rows)
                    {
                        try
                        {
                            string value = EmrSysPubFunction.IndexCode(dataRow["NAME"].ToString());
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
                }
                else
                {
                    if (strFlag == "USER")
                    {
                        if (strCondition1.Length >= 4)
                        {
                            sQLString = "select distinct ''as pym,a.user_name as NAME,a.user_id as ITEM_CODE from users a,user_dept b where a.user_id=b.user_id and substr(b.user_dept,0,4)='" + strCondition1.Substring(0, 4) + "'";
                        }
                        else
                        {
                            sQLString = "select distinct ''as pym,a.user_name as NAME,a.user_id as ITEM_CODE from users a,user_dept b where a.user_id=b.user_id and b.user_dept='" + strCondition1 + "'";
                        }
                        UCInput.dtData = DALUse.Query(sQLString).Tables[0];
                        foreach (DataRow dataRow in UCInput.dtData.Rows)
                        {
                            try
                            {
                                string value = EmrSysPubFunction.IndexCode(dataRow["NAME"].ToString());
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
                    }
                    else
                    {
                        if (strFlag == "DEPT")
                        {
                            sQLString = "select a.input_code as PYM,a.dept_name as NAME,a.dept_code as ITEM_CODE from dept_dict a where a.clinic_attr=0 and a.outp_or_inp=1  order by a.input_code";
                            UCInput.dtData = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                        }
                        else
                        {
                            if (strFlag == "DRUG")
                            {
                                sQLString = "SELECT a.input_code as pym,a.ITEM_NAME as NAME,a.ITEM_CODE  FROM price_item_name_dict a  WHERE a.ITEM_CLASS = '" + strCondition1 + "'";
                                UCInput.dtData = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                            }
                            else
                            {
                                if (strFlag == "ITEMCLASS")
                                {
                                    sQLString = string.Concat(new string[]
									{
										"SELECT ITEM_CODE,ITEM_NAME as NAME,INPUT_CODE as PYM FROM APPL_ITEM_DICT  WHERE ( CLINIC_ITEM_CLASS = 'D' ) AND ( ITEM_SUB_CLASS = '",
										strCondition1,
										"' ) AND  ( PART = '",
										strCondition2,
										"' )"
									});
                                    UCInput.dtData = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                                }
                                else
                                {
                                    if (strFlag == "LISITEM")
                                    {
                                        sQLString = "SELECT b.input_code as PYM,a.LAB_ITEM_NAME as NAME,a.LAB_ITEM_CODE AS ITEM_CODE FROM LAB_SHEET_ITEMS a,LAB_SHEET_MASTER b  WHERE ( a.LAB_SHEET_ID = b.LAB_SHEET_ID )";
                                        UCInput.dtData = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                                    }
                                    else
                                    {
                                        if (strFlag == "DRUGALIAS")
                                        {
                                            sQLString = " SELECT INPUT_CODE as PYM,DRUG_NAME as NAME,DRUG_CODE as ITEM_CODE  FROM DRUG_ALIAS_NAME_DICT";
                                            UCInput.dtData = DALUseSpecial.Query(sQLString, this.m_strDBConnet).Tables[0];
                                        }
                                    }
                                }
                            }
                        }
                    }
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
                if (e.KeyChar == '\r' || e.KeyChar == ' ')
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
            this.filter();
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
                dataView.RowFilter = "PYM like '%" + this.text.Text + "%'";
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
                DataGridViewRow dataGridViewRow = this.dataGridView1.SelectedRows[0];
                this.text.Tag = dataGridViewRow.Cells["ITEM_CODE"].Value.ToString();
                this.text.Text = dataGridViewRow.Cells["NAME"].Value.ToString();
                this.text.SelectAll();
            }
        }
        private void UCInput_Load(object sender, EventArgs e)
        {
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
                }
            }
        }
    }
}
