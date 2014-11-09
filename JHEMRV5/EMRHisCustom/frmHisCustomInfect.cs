using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;

namespace JHEMR.EMRHisCustom
{
    public partial class frmHisCustomInfect : DevExpress.XtraEditors.XtraForm
    {
        private string m_strPatientID = "";
        private int m_nVisitID = 1;
        private int m_nNum = 1;
        private int m_nMaxNum = 1;
        private DataTable m_dtInfection = new DataTable();
        private DataTable m_dtPartClass = new DataTable();
        private DataTable m_dtPartParent = new DataTable();
        private DataTable m_dtPart = new DataTable();
        public int m_QueryFlag = 0;
        private int m_Flag = 0;
        public void FillPatInfo(string strPatientID, int nVisitID, int nNum)
        {
            this.m_strPatientID = strPatientID;
            this.m_nVisitID = nVisitID;
            this.m_nNum = nNum;
        }
        public frmHisCustomInfect()
        {
            this.InitializeComponent();
        }
        private void frmHisCustomInfect_Load(object sender, EventArgs e)
        {
            if (EmrSysPubVar.getStationName() == "DOCTWS")
            {
                if (this.m_QueryFlag == 0)
                {
                    if (EmrSysPubVar.getCurPatientID().Length <= 0)
                    {
                        MessageBox.Show("没有选中病人，将退出！");
                        base.Close();
                        return;
                    }
                    this.m_strPatientID = EmrSysPubVar.getCurPatientID();
                    this.m_nVisitID = EmrSysPubVar.getCurPatientVisitID();
                    this.tbAdd.Enabled = true;
                    this.btnDisAdd.Enabled = true;
                }
            }
            else
            {
                this.spbtnConfirm.Visible = true;
                this.tbDelete.Enabled = true;
                this.spbtnQuery.Enabled = false;
            }
            this.FillPatInfo();
            this.FillInfectionPart();
            this.m_nMaxNum = this.GetMaxNum();
            if (this.m_nNum > 1)
            {
                this.tbBack.Enabled = true;
            }
            if (this.m_nNum < this.m_nMaxNum)
            {
                this.tbNext.Enabled = true;
            }
            this.txtClin_Diag.Focus();
        }
        private void FillInfectionPart()
        {
            string sQLString = "SELECT LABEL,HANDLE,INFO,PARENTHANDLE,ID,INDEXS FROM EMR_DEPT_REPOSITORY  WHERE ID ='11' AND   PARENTHANDLE =  0";
            this.m_dtPartClass = DALUse.Query(sQLString).Tables[0];
            if (this.m_dtPartClass.Rows.Count > 0)
            {
                foreach (DataRow dataRow in this.m_dtPartClass.Rows)
                {
                    this.cmbInfection_Part_Class.Items.Add(dataRow["LABEL"].ToString());
                }
            }
        }
        private bool FillPatInfo()
        {
            string sQLString = string.Concat(new string[]
			{
				"select a.*, b.name,b.sex,b.INP_NO,b.date_of_birth,c.admission_date_time from pat_visit_infection a,pat_master_index b,pat_visit c  where a.patient_id=b.patient_id and a.patient_id=c.patient_id and a.visit_id=c.visit_id and a.patient_id='",
				this.m_strPatientID,
				"' and a.visit_id=",
				this.m_nVisitID.ToString(),
				" and num=",
				this.m_nNum.ToString()
			});
            this.m_dtInfection = DALUse.Query(sQLString).Tables[0];
            if (this.m_dtInfection.Rows.Count > 0)
            {
                this.lbInpNO.Text = "住院号：" + this.m_dtInfection.Rows[0]["INP_NO"].ToString();
                this.lbInpNO.Tag = this.m_dtInfection.Rows[0]["INP_NO"].ToString();
                this.lbPatientID.Text = "ID：" + this.m_strPatientID;
                this.lblName.Text = "姓名：" + this.m_dtInfection.Rows[0]["name"].ToString();
                this.lblName.Tag = this.m_dtInfection.Rows[0]["name"].ToString();
                this.lblDept.Text = "科室：" + EmrSysPubFunction.getDeptName(this.m_dtInfection.Rows[0]["dept_code"].ToString(), false);
                this.lblDept.Tag = this.m_dtInfection.Rows[0]["dept_code"].ToString();
                this.lblBed_No.Text = "床号：" + this.m_dtInfection.Rows[0]["bed_no"].ToString();
                this.lblBed_No.Tag = this.m_dtInfection.Rows[0]["bed_no"].ToString();
                this.lblCard_No.Text = "编号：" + this.m_dtInfection.Rows[0]["card_no"].ToString();
                this.lblCard_No.Tag = this.m_dtInfection.Rows[0]["card_no"].ToString();
                this.lblSex.Text = "性别：" + this.m_dtInfection.Rows[0]["sex"].ToString();
                this.lblSex.Tag = this.m_dtInfection.Rows[0]["sex"].ToString();
                this.lblAge.Text = "年龄：" + EmrSysPubFunction.GetAge(Convert.ToDateTime(this.m_dtInfection.Rows[0]["admission_date_time"].ToString()), Convert.ToDateTime(this.m_dtInfection.Rows[0]["date_of_birth"].ToString()));
                this.lblAge.Tag = EmrSysPubFunction.GetAge(Convert.ToDateTime(this.m_dtInfection.Rows[0]["admission_date_time"].ToString()), Convert.ToDateTime(this.m_dtInfection.Rows[0]["date_of_birth"].ToString()));
                this.txtClin_Diag.Text = this.m_dtInfection.Rows[0]["CLINIC_DIAG"].ToString();
                this.lblReport_Doct.Text = "上报人：" + this.m_dtInfection.Rows[0]["report_doct"].ToString();
                this.lblReport_Doct.Tag = this.m_dtInfection.Rows[0]["report_doct"].ToString();
                this.dtpInfection_Date_Time.Text = this.m_dtInfection.Rows[0]["infection_date_time"].ToString();
                this.dtpReport_Date_Time.Text = this.m_dtInfection.Rows[0]["report_date_time"].ToString();
                this.cmbInfection_Part_Class.Text = this.m_dtInfection.Rows[0]["infection_part_class"].ToString();
                this.cmbInfection_Part_Parent.Text = this.m_dtInfection.Rows[0]["infection_part_parent"].ToString();
                this.cmbInfection_Part.Text = this.m_dtInfection.Rows[0]["infection_part"].ToString();
                if (this.m_dtInfection.Rows[0]["infection_symp_lab"] != DBNull.Value)
                {
                    this.txtInfection_Symp_Lab.Text = this.m_dtInfection.Rows[0]["infection_symp_lab"].ToString();
                }
                if (this.m_dtInfection.Rows[0]["BYXSJ_FLAG"] != DBNull.Value)
                {
                    this.cmbBYXSJ_FLAG.Text = this.m_dtInfection.Rows[0]["BYXSJ_FLAG"].ToString();
                }
                if (this.m_dtInfection.Rows[0]["CONFIRM_FLAG"].ToString() == "0")
                {
                    this.tbDelete.Enabled = true;
                }
                else
                {
                    if (EmrSysPubVar.getStationName() == "DOCTWS")
                    {
                        MessageBox.Show("该病人的疫卡上报已经审核,不能进行修改和删除");
                        this.tbSave.Enabled = false;
                        this.spbtnSave.Enabled = false;
                        this.tbDelete.Enabled = false;
                    }
                    else
                    {
                        this.tbDelete.Enabled = true;
                    }
                }
            }
            else
            {
                if (EmrSysPubVar.getStationName() == "DOCTWS")
                {
                    if (this.m_Flag == 0)
                    {
                        this.lbInpNO.Text = "住院号：" + EmrSysPubVar.getCurPatientInpNo();
                        this.lbInpNO.Tag = EmrSysPubVar.getCurPatientInpNo();
                        this.lbPatientID.Text = "ID：" + this.m_strPatientID;
                        this.lblName.Text = "姓名：" + EmrSysPubVar.getCurPatientName();
                        this.lblName.Tag = EmrSysPubVar.getCurPatientName();
                        if (EmrSysPubVar.getCurVisitDischargeDateTime() != DateTime.MinValue)
                        {
                            this.lblDept.Text = "科室：" + EmrSysPubFunction.getDeptName(EmrSysPubVar.getCurVisitDeptDischargeFrom(), false);
                            this.lblDept.Tag = EmrSysPubVar.getCurVisitDeptDischargeFrom();
                            this.lblBed_No.Text = "床号：" + this.GetBedNo(this.m_strPatientID, this.m_nVisitID);
                            this.lblBed_No.Tag = this.GetBedNo(this.m_strPatientID, this.m_nVisitID);
                        }
                        else
                        {
                            this.lblDept.Text = "科室：" + EmrSysPubFunction.getDeptName(EmrSysPubVar.getCurPatientDeptCode(), false);
                            this.lblDept.Tag = EmrSysPubVar.getCurPatientDeptCode();
                            this.lblBed_No.Text = "床号：" + EmrSysPubVar.getCurPatientBedNo().ToString();
                            this.lblBed_No.Tag = EmrSysPubVar.getCurPatientBedNo().ToString();
                        }
                        this.lblCard_No.Text = "编号：" + this.GetCardNo(this.lblDept.Tag.ToString()).ToString();
                        this.lblCard_No.Tag = this.GetCardNo(this.lblDept.Tag.ToString()).ToString();
                        this.lblSex.Text = "性别：" + EmrSysPubVar.getCurPatientSex();
                        this.lblSex.Tag = EmrSysPubVar.getCurPatientSex();
                        this.lblAge.Text = "年龄：" + EmrSysPubFunction.GetAge(EmrSysPubVar.getCurVisitAdmissionDateTime(), EmrSysPubVar.getCurPatientBirthDate());
                        this.lblAge.Tag = EmrSysPubFunction.GetAge(EmrSysPubVar.getCurVisitAdmissionDateTime(), EmrSysPubVar.getCurPatientBirthDate());
                        this.txtClin_Diag.Text = EmrSysPubVar.getCurPatientClinicDiag();
                    }
                    else
                    {
                        sQLString = string.Concat(new object[]
						{
							"select a.inp_no,a.name,a.sex,a.DATE_OF_BIRTH,b.DEPT_DISCHARGE_FROM,b.ADMISSION_DATE_TIME from pat_master_index a,pat_visit b where a.patient_id=b.patient_id   and  b.patient_id='",
							this.m_strPatientID,
							"' and b.visit_id=",
							this.m_nVisitID,
							""
						});
                        DataTable dataTable = new DataTable();
                        dataTable = DALUse.Query(sQLString).Tables[0];
                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow dataRow = dataTable.Rows[0];
                            this.lbInpNO.Text = "住院号：" + dataRow["inp_no"].ToString();
                            this.lbInpNO.Tag = dataRow["inp_no"].ToString();
                            this.lbPatientID.Text = "ID：" + this.m_strPatientID;
                            this.lblName.Text = "姓名：" + dataRow["name"].ToString();
                            this.lblName.Tag = dataRow["name"].ToString();
                            this.lblDept.Text = "科室：" + EmrSysPubFunction.getDeptName(dataRow["DEPT_DISCHARGE_FROM"].ToString(), false);
                            this.lblDept.Tag = dataRow["DEPT_DISCHARGE_FROM"].ToString();
                            this.lblBed_No.Text = "床号：" + this.GetBedNo(this.m_strPatientID, this.m_nVisitID);
                            this.lblBed_No.Tag = this.GetBedNo(this.m_strPatientID, this.m_nVisitID);
                            this.lblCard_No.Text = "编号：" + this.GetCardNo(this.lblDept.Tag.ToString()).ToString();
                            this.lblCard_No.Tag = this.GetCardNo(this.lblDept.Tag.ToString()).ToString();
                            this.lblSex.Text = "性别：" + dataRow["sex"].ToString();
                            this.lblSex.Tag = dataRow["sex"].ToString();
                            this.lblAge.Text = "年龄：" + EmrSysPubFunction.GetAge(Convert.ToDateTime(dataRow["ADMISSION_DATE_TIME"].ToString()), Convert.ToDateTime(dataRow["DATE_OF_BIRTH"].ToString()));
                            this.lblAge.Tag = EmrSysPubFunction.GetAge(Convert.ToDateTime(dataRow["ADMISSION_DATE_TIME"].ToString()), Convert.ToDateTime(dataRow["DATE_OF_BIRTH"].ToString()));
                        }
                    }
                    this.lblReport_Doct.Text = "上报人：" + EmrSysPubFunction.getUserName(EmrSysPubVar.getDbUser(), false);
                    this.lblReport_Doct.Tag = EmrSysPubFunction.getUserName(EmrSysPubVar.getDbUser(), false);
                    this.dtpInfection_Date_Time.Text = EmrSysPubFunction.getServerNow().ToString();
                    this.dtpReport_Date_Time.Text = EmrSysPubFunction.getServerNow().ToString();
                }
            }
            return true;
        }
        private int GetCardNo(string strDeptCode)
        {
            string sQLString = "select MAX(CARD_NO) as CARD_NO from pat_visit_infection where dept_code='" + strDeptCode + "'";
            object single = DALUse.GetSingle(sQLString);
            int num;
            if (single != null)
            {
                num = Convert.ToInt32(single.ToString());
            }
            else
            {
                num = 0;
            }
            return num + 1;
        }
        private string GetBedNo(string strPatientId, int nVisitID)
        {
            string sQLString = "select bed_label from pat_visit where patient_id='" + strPatientId + "' and visit_id=" + nVisitID.ToString();
            string result = " ";
            object single = DALUse.GetSingle(sQLString);
            if (single != null)
            {
                result = single.ToString();
            }
            return result;
        }
        private void spbtnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void txtClin_Diag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                foreach (Control control in base.Controls)
                {
                    if (control.Name == "input")
                    {
                        return;
                    }
                }
                UCInput instance = UCInput.GetInstance();
                instance.setOwner(base.Controls, (TextBox)sender);
                instance.loadData("DIAGNOSIS", "DIAGNOSIS", "");
                instance.Name = "input";
                base.Controls.Add(instance);
                base.Controls.SetChildIndex(instance, 0);
                if (((TextBox)sender).Location.X + instance.Width < base.Width)
                {
                    instance.Location = new Point(((TextBox)sender).Location.X - 3, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 12);
                }
                else
                {
                    instance.Location = new Point(base.Width - instance.Width, ((TextBox)sender).Location.Y + ((TextBox)sender).Height + 3);
                }
                instance.filter();
            }
        }
        private void txtClin_Diag_Enter(object sender, EventArgs e)
        {
            this.tsLab.Text = "如果为空，请按F9调用ICD拼音诊断库添加诊断！";
        }
        private void txtClin_Diag_Leave(object sender, EventArgs e)
        {
            this.tsLab.Text = "Ready";
        }
        private void spbtnSave_Click(object sender, EventArgs e)
        {
            if (this.cmbInfection_Part_Class.Text.Length < 0)
            {
                MessageBox.Show("感染部位分类不能为空！");
            }
            else
            {
                if (this.cmbInfection_Part_Parent.Text.Length < 0)
                {
                    MessageBox.Show("感染部位子分类不能为空！");
                }
                else
                {
                    if (this.cmbInfection_Part.Text.Length < 1)
                    {
                        MessageBox.Show("感染部位不能为空！");
                    }
                    else
                    {
                        if (MessageBox.Show("确定要上报该病人或者修改该病人感染上报信息", "注意：", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            string sQLString;
                            if (this.m_dtInfection.Rows.Count > 0)
                            {
                                sQLString = string.Concat(new object[]
								{
									"update pat_visit_infection set CLINIC_DIAG='",
									this.txtClin_Diag.Text,
									"',infection_part='",
									this.cmbInfection_Part.Text,
									"',infection_date_time=to_date('",
									this.dtpInfection_Date_Time.Text,
									"','YYYY-MM-DD HH24:MI:SS'),infection_part_class='",
									this.cmbInfection_Part_Class.Text,
									"',infection_part_parent='",
									this.cmbInfection_Part_Parent.Text,
									"',infection_symp_lab='",
									this.txtInfection_Symp_Lab.Text,
									"',BYXSJ_FLAG='",
									this.cmbBYXSJ_FLAG,
									"' where patient_id='",
									this.m_strPatientID,
									"' and visit_id=",
									this.m_nVisitID.ToString(),
									" and num=",
									this.m_nNum.ToString()
								});
                            }
                            else
                            {
                                sQLString = string.Concat(new string[]
								{
									"insert into pat_visit_infection (PATIENT_ID,VISIT_ID,Num,DEPT_CODE,CARD_NO,BED_NO,CLINIC_DIAG,INFECTION_PART,INFECTION_DATE_TIME,INFECTION_SYMP_LAB,REPORT_DOCT,REPORT_DATE_TIME,INFECTION_PART_CLASS,INFECTION_PART_PARENT,BYXSJ_FLAG) values('",
									this.m_strPatientID,
									"',",
									this.m_nVisitID.ToString(),
									",",
									this.m_nNum.ToString(),
									",'",
									this.lblDept.Tag.ToString(),
									"',",
									this.lblCard_No.Tag.ToString(),
									",'",
									this.lblBed_No.Tag.ToString(),
									"','",
									this.txtClin_Diag.Text.Trim(),
									"','",
									this.cmbInfection_Part.Text,
									"',TO_DATE('",
									this.dtpInfection_Date_Time.Text,
									"','YYYY-MM-DD HH24:MI:SS'),'",
									this.txtInfection_Symp_Lab.Text.Trim(),
									"','",
									this.lblReport_Doct.Tag.ToString(),
									"',TO_DATE('",
									this.dtpReport_Date_Time.Text,
									"','YYYY-MM-DD HH24:MI:SS'),'",
									this.cmbInfection_Part_Class.Text,
									"','",
									this.cmbInfection_Part_Parent.Text,
									"','",
									this.cmbBYXSJ_FLAG.Text,
									"')"
								});
                            }
                            if (DALUse.ExecuteSql(sQLString) > 0)
                            {
                                MessageBox.Show("保存成功！");
                                this.FillPatInfo();
                            }
                        }
                    }
                }
            }
        }
        private void spbtnPrint_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            for (int i = 0; i <= 1; i++)
            {
                dataTable.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
            }
            DataRow dataRow = dataTable.NewRow();
            dataRow[0] = "科室";
            dataRow[1] = ((EmrSysPubFunction.getDeptName(this.lblDept.Tag.ToString(), false).Length > 0) ? EmrSysPubFunction.getDeptName(this.lblDept.Tag.ToString(), false) : " ");
            dataTable.Rows.Add(dataRow);
            DataRow dataRow2 = dataTable.NewRow();
            dataRow2[0] = "编号";
            dataRow2[1] = ((this.lblCard_No.Tag.ToString().Length < 1) ? " " : this.lblCard_No.Tag.ToString());
            dataTable.Rows.Add(dataRow2);
            DataRow dataRow3 = dataTable.NewRow();
            dataRow3[0] = "姓名";
            dataRow3[1] = ((this.lblName.Tag.ToString().Length > 0) ? this.lblName.Tag.ToString() : " ");
            dataTable.Rows.Add(dataRow3);
            DataRow dataRow4 = dataTable.NewRow();
            dataRow4[0] = "床号";
            dataRow4[1] = ((this.lblBed_No.Tag.ToString().Length > 0) ? this.lblBed_No.Tag.ToString() : " ");
            dataTable.Rows.Add(dataRow4);
            DataRow dataRow5 = dataTable.NewRow();
            dataRow5[0] = "年龄";
            dataRow5[1] = ((this.lblAge.Tag.ToString().Length > 0) ? this.lblAge.Tag.ToString() : " ");
            dataTable.Rows.Add(dataRow5);
            DataRow dataRow6 = dataTable.NewRow();
            dataRow6[0] = "原发诊断";
            dataRow6[1] = ((this.txtClin_Diag.Text.Length < 1) ? " " : this.txtClin_Diag.Text);
            dataTable.Rows.Add(dataRow6);
            DataRow dataRow7 = dataTable.NewRow();
            dataRow7[0] = "感染部位";
            dataRow7[1] = ((this.cmbInfection_Part.Text.Length > 0) ? this.cmbInfection_Part.Text : " ");
            dataTable.Rows.Add(dataRow7);
            DataRow dataRow8 = dataTable.NewRow();
            dataRow8[0] = "感染时间";
            dataRow8[1] = ((this.dtpInfection_Date_Time.Text.Length > 0) ? this.dtpInfection_Date_Time.Text : " ");
            dataTable.Rows.Add(dataRow8);
            DataRow dataRow9 = dataTable.NewRow();
            dataRow9[0] = "感染迹象";
            dataRow9[1] = ((this.txtInfection_Symp_Lab.Text.Length > 0) ? this.txtInfection_Symp_Lab.Text : " ");
            dataTable.Rows.Add(dataRow9);
            DataRow dataRow10 = dataTable.NewRow();
            dataRow10[0] = "上报人";
            dataRow10[1] = ((this.lblReport_Doct.Tag.ToString().Length > 0) ? this.lblReport_Doct.Tag.ToString() : " ");
            dataTable.Rows.Add(dataRow10);
            DataRow dataRow11 = dataTable.NewRow();
            dataRow11[0] = "上报时间";
            dataRow11[1] = Convert.ToDateTime(this.dtpReport_Date_Time.Text).ToString("yyyy年MM月dd日");
            dataTable.Rows.Add(dataRow11);
            DataRow dataRow12 = dataTable.NewRow();
            dataRow12[0] = "性别";
            dataRow12[1] = ((this.lblSex.Tag.ToString().Length > 0) ? this.lblSex.Tag.ToString() : " ");
            dataTable.Rows.Add(dataRow12);
            DataRow dataRow13 = dataTable.NewRow();
            dataRow13[0] = "住院号";
            dataRow13[1] = ((this.lbInpNO.Tag.ToString().Length > 0) ? this.lbInpNO.Tag.ToString() : " ");
            dataTable.Rows.Add(dataRow13);
            frmPrint frmPrint = new frmPrint();
            frmPrint.PrintLabExam("医院感染病例上报卡", dataTable, null);
        }
        private void spbtnQuery_Click(object sender, EventArgs e)
        {
            frmHisCustomInfectQuery frmHisCustomInfectQuery = new frmHisCustomInfectQuery();
            frmHisCustomInfectQuery.ShowDialog();
        }
        private void tbClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void tbSave_Click(object sender, EventArgs e)
        {
            this.spbtnSave_Click(sender, e);
        }
        private void tbQuery_Click(object sender, EventArgs e)
        {
            this.spbtnQuery_Click(sender, e);
        }
        private void tbPrint_Click(object sender, EventArgs e)
        {
            this.spbtnPrint_Click(sender, e);
        }
        private void tbAdd_Click(object sender, EventArgs e)
        {
            if (this.m_dtInfection.Rows.Count >= 1)
            {
                this.m_nMaxNum = this.GetMaxNum();
                this.m_nNum = this.m_nMaxNum + 1;
                this.txtClin_Diag.Text = "";
                this.cmbInfection_Part.Text = "";
                this.txtInfection_Symp_Lab.Text = "";
                this.FillPatInfo();
                this.tbBack.Enabled = true;
            }
        }
        private void tbBack_Click(object sender, EventArgs e)
        {
            if (this.m_nNum - 1 > 0)
            {
                this.m_nNum--;
                this.FillPatInfo();
                this.tbNext.Enabled = true;
            }
            if (this.m_nNum == 1)
            {
                this.tbBack.Enabled = false;
            }
        }
        private void tbNext_Click(object sender, EventArgs e)
        {
            this.m_nMaxNum = this.GetMaxNum();
            if (this.m_nNum + 1 <= this.m_nMaxNum)
            {
                this.m_nNum++;
                this.FillPatInfo();
                this.tbBack.Enabled = true;
            }
            if (this.m_nNum == this.m_nMaxNum)
            {
                this.tbNext.Enabled = false;
            }
        }
        private int GetMaxNum()
        {
            string sQLString = "select max(num) from pat_visit_infection where patient_id='" + this.m_strPatientID + "' and visit_id=" + this.m_nVisitID.ToString();
            object single = DALUse.GetSingle(sQLString);
            int result;
            if (single != null)
            {
                result = Convert.ToInt32(single.ToString());
            }
            else
            {
                result = 0;
            }
            return result;
        }
        private void cmbInfection_Part_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbInfection_Part_Parent.Items.Clear();
            this.cmbInfection_Part_Parent.Text = "";
            if (this.m_dtPartClass.Rows.Count > 0)
            {
                DataRow dataRow = this.m_dtPartClass.Rows[this.cmbInfection_Part_Class.SelectedIndex];
                string sQLString = "SELECT LABEL,HANDLE,INFO,PARENTHANDLE,ID,INDEXS FROM EMR_DEPT_REPOSITORY  WHERE ID ='11' AND   PARENTHANDLE =  " + dataRow["HANDLE"].ToString() + " and handle !=0 ";
                this.m_dtPartParent = DALUse.Query(sQLString).Tables[0];
                if (this.m_dtPartParent.Rows.Count > 0)
                {
                    foreach (DataRow dataRow2 in this.m_dtPartParent.Rows)
                    {
                        this.cmbInfection_Part_Parent.Items.Add(dataRow2["LABEL"].ToString());
                    }
                }
                else
                {
                    DataRow dataRow3 = this.m_dtPartParent.NewRow();
                    dataRow3["LABEL"] = this.cmbInfection_Part_Class.Text;
                    dataRow3["HANDLE"] = "999";
                    dataRow3["INFO"] = "";
                    dataRow3["ID"] = "11";
                    dataRow3["INDEXS"] = "999";
                    this.m_dtPartParent.Rows.Add(dataRow3);
                    this.cmbInfection_Part_Parent.Items.Add(this.cmbInfection_Part_Class.Text);
                    this.cmbInfection_Part_Parent.SelectedIndex = 0;
                }
            }
        }
        private void cmbInfection_Part_Parent_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbInfection_Part.Items.Clear();
            this.cmbInfection_Part.Text = "";
            if (this.m_dtPartParent.Rows.Count > 0)
            {
                DataRow dataRow = this.m_dtPartParent.Rows[this.cmbInfection_Part_Parent.SelectedIndex];
                string sQLString = "SELECT LABEL,HANDLE,INFO,PARENTHANDLE,ID,INDEXS FROM EMR_DEPT_REPOSITORY  WHERE ID ='11' AND   PARENTHANDLE =  " + dataRow["HANDLE"].ToString() + " and handle !=0 ";
                this.m_dtPart = DALUse.Query(sQLString).Tables[0];
                if (this.m_dtPart.Rows.Count > 0)
                {
                    foreach (DataRow dataRow2 in this.m_dtPart.Rows)
                    {
                        this.cmbInfection_Part.Items.Add(dataRow2["LABEL"].ToString());
                    }
                }
                else
                {
                    DataRow dataRow3 = this.m_dtPart.NewRow();
                    dataRow3["LABEL"] = this.cmbInfection_Part_Parent.Text;
                    dataRow3["HANDLE"] = "999";
                    dataRow3["INFO"] = "";
                    dataRow3["ID"] = "11";
                    dataRow3["INDEXS"] = "999";
                    this.m_dtPart.Rows.Add(dataRow3);
                    this.cmbInfection_Part.Items.Add(this.cmbInfection_Part_Parent.Text);
                    this.cmbInfection_Part.SelectedIndex = 0;
                }
            }
        }
        private void frmHisCustomInfect_Shown(object sender, EventArgs e)
        {
            this.txtClin_Diag.Focus();
        }
        private void tbDelete_Click(object sender, EventArgs e)
        {
            if (this.m_dtInfection.Rows.Count > 0)
            {
                string sQLString = string.Concat(new string[]
				{
					"delete from pat_visit_infection where patient_id='",
					this.m_strPatientID,
					"' and visit_id=",
					this.m_nVisitID.ToString(),
					" and num=",
					this.m_nNum.ToString()
				});
                if (DALUse.ExecuteSql(sQLString) > 0)
                {
                    MessageBox.Show("删除成功!");
                    this.FillPatInfo();
                }
            }
            else
            {
                MessageBox.Show("还没有保存,不能进行删除!");
            }
        }
        private void tbHistory_Click(object sender, EventArgs e)
        {
            frmHisCustomHistory frmHisCustomHistory = new frmHisCustomHistory();
            frmHisCustomHistory.m_strPatient_ID = this.m_strPatientID;
            frmHisCustomHistory.m_Flag = 1;
            if (frmHisCustomHistory.ShowDialog() == DialogResult.OK)
            {
                this.FillPatInfo(frmHisCustomHistory.m_strPatient_ID, Convert.ToInt32(frmHisCustomHistory.m_strVisit_ID), Convert.ToInt32(frmHisCustomHistory.m_strNum));
                this.FillPatInfo();
            }
        }
        private void spbtnConfirm_Click(object sender, EventArgs e)
        {
            if (this.cmbInfection_Part_Class.Text.Length < 0)
            {
                MessageBox.Show("感染部位分类不能为空！");
            }
            else
            {
                if (this.cmbInfection_Part_Parent.Text.Length < 0)
                {
                    MessageBox.Show("感染部位子分类不能为空！");
                }
                else
                {
                    if (this.cmbInfection_Part.Text.Length < 1)
                    {
                        MessageBox.Show("感染部位不能为空！");
                    }
                    else
                    {
                        if (MessageBox.Show("确定要审核病人上报信息，审核之后医生站不能进行删除和修改", "注意：", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            string sQLString = "";
                            if (this.m_dtInfection.Rows.Count > 0)
                            {
                                sQLString = string.Concat(new string[]
								{
									"update pat_visit_infection set CLINIC_DIAG='",
									this.txtClin_Diag.Text,
									"',infection_part='",
									this.cmbInfection_Part.Text,
									"',infection_date_time=to_date('",
									this.dtpInfection_Date_Time.Text,
									"','YYYY-MM-DD HH24:MI:SS'),infection_part_class='",
									this.cmbInfection_Part_Class.Text,
									"',infection_part_parent='",
									this.cmbInfection_Part_Parent.Text,
									"',infection_symp_lab='",
									this.txtInfection_Symp_Lab.Text,
									"',CONFIRM_FLAG=1,CONFIRM_TIME=sysdate,CONFIRM_USER_ID='",
									EmrSysPubVar.getUserID(),
									"'  where patient_id='",
									this.m_strPatientID,
									"' and visit_id=",
									this.m_nVisitID.ToString(),
									" and num=",
									this.m_nNum.ToString()
								});
                            }
                            if (DALUse.ExecuteSql(sQLString) > 0)
                            {
                                MessageBox.Show("保存成功！");
                                this.FillPatInfo();
                            }
                        }
                    }
                }
            }
        }
        private void btnDisAdd_Click(object sender, EventArgs e)
        {
            frmInfectSel frmInfectSel = new frmInfectSel();
            if (frmInfectSel.ShowDialog() == DialogResult.OK)
            {
                this.m_strPatientID = frmInfectSel.strPatientID;
                this.m_nVisitID = frmInfectSel.nVisitID;
                this.m_Flag = 1;
                this.m_nMaxNum = this.GetMaxNum();
                this.m_nNum = this.m_nMaxNum + 1;
                this.txtClin_Diag.Text = "";
                this.cmbInfection_Part.Text = "";
                this.txtInfection_Symp_Lab.Text = "";
                this.FillPatInfo();
                this.tbBack.Enabled = true;
            }
        }
    }
}