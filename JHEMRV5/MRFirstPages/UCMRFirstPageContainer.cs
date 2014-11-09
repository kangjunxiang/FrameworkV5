using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysDAL;
using JHEMR.MRFirstPagesBJ;

namespace JHEMR.MRFirstPages
{
    public partial class UCMRFirstPageContainer : UserControl
    {
        private string m_strPatientID;
        private int m_nVisitID;
        public bool m_bIsCMFirstPages = false;
        private UCMRFirstPage UCMRFirstPage1;
        private UCCMMRFirstPage UCMRFirstPage2;
        public UCMRFirstPageContainer()
        {
            InitializeComponent();
            this.UCMRFirstPage1 = new UCMRFirstPage();
            this.UCMRFirstPage2 = new UCCMMRFirstPage();
            base.SuspendLayout();
            this.UCMRFirstPage1.BackColor = Color.White;
            this.UCMRFirstPage1.ForeColor = Color.Gray;
            this.UCMRFirstPage1.Location = new Point(19, 19);
            this.UCMRFirstPage1.Name = "UCMRFirstPage1";
            this.UCMRFirstPage1.Size = new Size(794, 1426);
            this.UCMRFirstPage1.TabIndex = 0;
            this.UCMRFirstPage2.BackColor = Color.White;
            this.UCMRFirstPage2.ForeColor = Color.Gray;
            this.UCMRFirstPage2.Location = new Point(19, 19);
            this.UCMRFirstPage2.Name = "UCMRFirstPage2";
            this.UCMRFirstPage2.Size = new Size(794, 1426);
            this.UCMRFirstPage2.TabIndex = 1;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = SystemColors.Desktop;
            base.Controls.Add(this.UCMRFirstPage1);
            base.Controls.Add(this.UCMRFirstPage2);
            base.Name = "UCMRFirstPageContainer";
            base.Size = new Size(410, 315);
            base.Load += new EventHandler(this.UCMRFirstPageContainer_Load);
            base.ResumeLayout(false);
        }
        public void setPatientInfo(string strPatientID, int nVisitID)
        {
            this.m_strPatientID = strPatientID;
            this.m_nVisitID = nVisitID;
            string sQLString = "select settingvalue from goal_setting_table where settingid = '20120216HCJ01'";
            string text = "";
            int num = 0;
            text = DALUse.GetSingle(sQLString).ToString();
            if (text.Trim() == "")
            {
                this.UCMRFirstPage2.Visible = false;
                this.UCMRFirstPage1.setPatientInfo(strPatientID, nVisitID);
            }
            else
            {
                string text2 = "";
                try
                {
                    DataSet dataSet = new DataSet();
                    string sQLString2 = "SELECT DEPT_ADMISSION_TO FROM PAT_VISIT WHERE  PATIENT_ID='" + strPatientID + "' AND VISIT_ID=" + nVisitID.ToString();
                    dataSet = DALUse.Query(sQLString2);
                    if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                    {
                        text2 = dataSet.Tables[0].Rows[0][0].ToString().Trim();
                    }
                }
                catch (Exception var_6_F8)
                {
                }
                if (text.Contains("/"))
                {
                    string[] array = text.Split(new char[]
					{
						'/'
					});
                    string[] array2 = array;
                    for (int i = 0; i < array2.Length; i++)
                    {
                        string text3 = array2[i];
                        if (text3.Trim() == text2)
                        {
                            num++;
                        }
                    }
                }
                else
                {
                    if (text2 == text.Trim())
                    {
                        num++;
                    }
                }
                if (num > 0)
                {
                    this.m_bIsCMFirstPages = true;
                }
                if (this.m_bIsCMFirstPages)
                {
                    this.UCMRFirstPage1.Visible = false;
                    this.UCMRFirstPage2.setPatientInfo(strPatientID, nVisitID);
                }
                else
                {
                    this.UCMRFirstPage2.Visible = false;
                    this.UCMRFirstPage1.setPatientInfo(strPatientID, nVisitID);
                }
            }
        }
        public void setReadOnly(bool bReadOnly)
        {
            if (this.m_bIsCMFirstPages)
            {
                this.UCMRFirstPage2.setReadOnly(bReadOnly);
            }
            else
            {
                this.UCMRFirstPage1.setReadOnly(bReadOnly);
            }
        }
        public bool Save()
        {
            bool result;
            if (this.m_bIsCMFirstPages)
            {
                result = this.UCMRFirstPage2.Save();
            }
            else
            {
                result = this.UCMRFirstPage1.Save();
            }
            return result;
        }
        public bool UpdatePatInfo(string strFieldName, string strFieldValue)
        {
            bool result;
            if (this.m_bIsCMFirstPages)
            {
                result = this.UCMRFirstPage2.UpdatePatInfo(strFieldName, strFieldValue);
            }
            else
            {
                result = this.UCMRFirstPage1.UpdatePatInfo(strFieldName, strFieldValue);
            }
            return result;
        }
        public bool Print()
        {
            bool result;
            if (this.m_bIsCMFirstPages)
            {
                result = this.UCMRFirstPage2.Print();
            }
            else
            {
                result = this.UCMRFirstPage1.Print();
            }
            return result;
        }
        private void UCMRFirstPageContainer_Load(object sender, EventArgs e)
        {
        }
    }
}
