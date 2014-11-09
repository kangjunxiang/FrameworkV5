using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysCom;
using JHEMR.EmrSysDAL;
using JHEMR.EmrEntities;

namespace JHEMR.EMREdit
{
    public partial class UCOrderMain : UserControl
    {
        private DataSet objDataSetOrders = new DataSet();
        private DataSet objDataSetDoctorOrders = new DataSet();

        public UCOrderMain()
        {
            InitializeComponent();
        }

        private void UCOrderMain_Load(object sender, EventArgs e)
        {
            objDataSetOrders = EMREditHisAdaperUse.getOrders();
            dgvOrders.RegisterExistHeaderColumn();
            if (objDataSetOrders.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSetOrders.Tables[0];
                dgvOrders.DataSource = objTable.DefaultView;
                
            }

            objDataSetDoctorOrders = EMREditHisAdaperUse.getDoctorOrders();
            //dgvDoctorOrder.AutoGenerateColumns = false;
            dgvDoctorOrder.RegisterExistHeaderColumn();
            if (objDataSetDoctorOrders.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSetDoctorOrders.Tables[0];
                dgvDoctorOrder.DataSource = objTable.DefaultView;

                //长期
                dgvDoctorOrder.Columns.Remove("repeat_indicator_d");
                DataGridViewComboBoxColumn dgvCBCRepeatIndicator = new DataGridViewComboBoxColumn();
                dgvCBCRepeatIndicator.DisplayIndex = 1;
                dgvCBCRepeatIndicator.HeaderText = "长期";
                dgvCBCRepeatIndicator.Name = "repeat_indicator_d";
                dgvCBCRepeatIndicator.Width = 50;
                dgvCBCRepeatIndicator.DataPropertyName = "REPEAT_INDICATOR";
                dgvCBCRepeatIndicator.DataSource = EMREditHisAdaperUse.getOrderRepearIndicator();
                dgvCBCRepeatIndicator.DisplayMember = "REPEAT_INDICATOR_NAME";
                dgvCBCRepeatIndicator.ValueMember = "REPEAT_INDICATOR";
                dgvDoctorOrder.Columns.Add(dgvCBCRepeatIndicator);

                //类别
                dgvDoctorOrder.Columns.Remove("ORDER_CLASS_D");
                DataGridViewComboBoxColumn dgvCBCOrderClass = new DataGridViewComboBoxColumn();
                dgvCBCOrderClass.DisplayIndex = 2;
                dgvCBCOrderClass.HeaderText = "类别";
                dgvCBCOrderClass.Name = "ORDER_CLASS_D";
                dgvCBCOrderClass.Width = 50;
                dgvCBCOrderClass.DataPropertyName = "ORDER_CLASS";
                dgvCBCOrderClass.DataSource = EMREditHisAdaperUse.getOrderClassDict();
                dgvCBCOrderClass.DisplayMember = "ORDER_CLASS_NAME";
                dgvCBCOrderClass.ValueMember = "ORDER_CLASS_CODE";
                dgvDoctorOrder.Columns.Add(dgvCBCOrderClass);


                //剂量单位
                dgvDoctorOrder.Columns.Remove("dosage_units_d");
                DataGridViewComboBoxColumn dgvCBCDosageUnits = new DataGridViewComboBoxColumn();
                dgvCBCDosageUnits.DisplayIndex = 7;
                dgvCBCDosageUnits.HeaderText = "单位";
                dgvCBCDosageUnits.Name = "dosage_units_d";
                dgvCBCDosageUnits.Width = 50;
                dgvCBCDosageUnits.DataPropertyName = "DOSAGE_UNITS";
                dgvCBCDosageUnits.DataSource = EMREditHisAdaperUse.getDosageUnitsDict();
                dgvCBCDosageUnits.DisplayMember = "DOSAGE_UNITS";
                dgvCBCDosageUnits.ValueMember = "DOSAGE_UNITS";
                dgvDoctorOrder.Columns.Add(dgvCBCDosageUnits);

                //给药途径
                dgvDoctorOrder.Columns.Remove("administration_d");
                DataGridViewComboBoxColumn dgvCBCAdministration = new DataGridViewComboBoxColumn();
                dgvCBCAdministration.DisplayIndex = 8;
                dgvCBCAdministration.HeaderText = "途径";
                dgvCBCAdministration.Name = "administration_d";
                dgvCBCAdministration.Width = 85;
                dgvCBCAdministration.DataPropertyName = "ADMINISTRATION";
                dgvCBCAdministration.DataSource =EMREditHisAdaperUse.getAdministrationDict();
                dgvCBCAdministration.DisplayMember = "ADMINISTRATION_NAME";
                dgvCBCAdministration.ValueMember = "ADMINISTRATION_NAME";
                dgvDoctorOrder.Columns.Add(dgvCBCAdministration);

                //频次
                dgvDoctorOrder.Columns.Remove("frequency_d");
                DataGridViewComboBoxColumn dgvCBCFrequency = new DataGridViewComboBoxColumn();
                dgvCBCFrequency.DisplayIndex = 9;
                dgvCBCFrequency.HeaderText = "频次";
                dgvCBCFrequency.Name = "frequency_d";
                dgvCBCFrequency.Width = 85;
                dgvCBCFrequency.DataPropertyName = "FREQUENCY";
                dgvCBCFrequency.DataSource = EMREditHisAdaperUse.getPerformFreqDict("");
                dgvCBCFrequency.DisplayMember = "FREQ_DESC";
                dgvCBCFrequency.ValueMember = "FREQ_DESC";
                dgvDoctorOrder.Columns.Add(dgvCBCFrequency);

            }

            //诊断
            DataSet objDataSetPatDiagnose = new DataSet();
            objDataSetPatDiagnose = EMREditHisAdaperUse.getPatDiagnose();
            dgvPatDiagnose.RegisterExistHeaderColumn();

            if (objDataSetPatDiagnose.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSetPatDiagnose.Tables[0];
                dgvPatDiagnose.DataSource = objTable.DefaultView;
            }

            //套餐医嘱
            dgvGroupOrderItems.RegisterExistHeaderColumn();
            DataSet objDataSetGroupOrderMaster = new DataSet();
            objDataSetGroupOrderMaster = EMREditHisAdaperUse.getGroupOrderMaster(EmrSysPubVar.getCurPatientDeptCode());
            dgvGroupOrderMaster.RegisterExistHeaderColumn();

            if (objDataSetGroupOrderMaster.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSetGroupOrderMaster.Tables[0];
                dgvGroupOrderMaster.DataSource = objTable.DefaultView;
            }

        }

        private void dgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;
            DataGridViewRow theRow = dgvOrders.Rows[rowIndex];

            //把不可编辑的行和列的背景显示为灰色
            string strAbnormalIndicator = theRow.Cells["order_status"].Value.ToString();
            switch (strAbnormalIndicator)
            {
                case "0":
                    theRow.DefaultCellStyle.ForeColor = Color.FromArgb(128, 0, 128);
                    break;
                case "1":
                    theRow.DefaultCellStyle.ForeColor = Color.FromArgb(0,0,0);
                    break;
                case "4":
                    theRow.DefaultCellStyle.ForeColor = Color.Red;
                    break;
                default:
                    theRow.DefaultCellStyle.ForeColor = Color.Blue;
                    break;

            }
        }

        /// <summary>
        //函数名称: insertNewRow
        //    功能: 添加一条新记录
        //    创建: 陈联忠  2007年1月23日
        //最后修改:     
        /// </summary>
        /// <param name="bInsert"></param>
        private void insertNewRow(bool bInsert)
        {
            if (objDataSetDoctorOrders.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSetDoctorOrders.Tables[0];
                DataRow objDataRow = objTable.NewRow();
                objDataRow["patient_id"] = EmrSysPubVar.getCurPatientID();
                objDataRow["visit_id"] = EmrSysPubVar.getCurPatientVisitID();
                objDataRow["start_date_time"] = EmrSysPubFunction.getServerNow() ;

                int nRow=objTable.Rows.Count;
                if (  nRow==0)  //set  order_no=1
                    objDataRow["order_no"] =1;
                else  //set order_no the value of the row's before which is inserted
                {
                    DataRow objDataRowPrev = objTable.Rows[nRow-1];
                    objDataRow["order_no"] = Convert.ToInt32(objDataRowPrev["order_no"].ToString())+1;
                    objDataRow["order_class"] = objDataRowPrev["order_class"].ToString();
                    objDataRow["repeat_indicator"] = Convert.ToInt32(objDataRowPrev["repeat_indicator"].ToString());
                }
                objDataRow["doctor"] = EmrSysPubVar.getOperator();
                objDataRow["order_sub_no"] = 1;
                objDataRow["ordering_dept"] = EmrSysPubVar.getDeptCode() ;
                objDataRow["ORDER_PRINT_INDICATOR"] = 0;
                objDataRow["ORDER_STATUS"] = '0';
                objDataRow["START_STOP_INDICATOR"] = 0;
                objTable.Rows.Add(objDataRow);
            }

        }

        private void dgvDoctorOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;
            DataGridViewRow theRow = dgvDoctorOrder.Rows[rowIndex];

            //把不可编辑的行和列的背景显示为灰色
            string strAbnormalIndicator = theRow.Cells["order_status"].Value.ToString();
            switch (strAbnormalIndicator)
            {
                case "0":
                    theRow.DefaultCellStyle.BackColor = Color.FromArgb(255,255,255);
                    break;
                default:
                    theRow.DefaultCellStyle.BackColor =Color.FromArgb(192,192,192);
                    break;

            }

        }

        private void dgvGroupOrderMaster_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroupOrderMaster.SelectedRows.Count > 0)
            {
                DataGridViewRow objCurRow = dgvGroupOrderMaster.SelectedRows[0];
                DataSet objDataSetItems = new DataSet();
                objDataSetItems = EMREditHisAdaperUse.getGroupOrderItems(objCurRow.Cells["GROUP_ORDER_ID"].Value.ToString());

                if (objDataSetItems.Tables.Count > 0)
                {
                    DataTable objTable;
                    objTable = objDataSetItems.Tables[0];
                    dgvGroupOrderItems.DataSource = objTable.DefaultView;
                }
            }

        }

        private void cbxPreviewGroupOrderItems_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPreviewGroupOrderItems.Checked)
            {
                lblCaption.Text = "模板明细项目：";
                dgvGroupOrderItems.Visible = true;
            }
            else
            {
                lblCaption.Text = "当前诊断：";
                dgvGroupOrderItems.Visible = false;
            }
        }

        /// <summary>
        ///函数名称: dgvGroupOrderMaster_DoubleClick
        ///    功能: 插入套餐医嘱
        ///    创建: 陈联忠  2007年2月2日
        ///最后修改:     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGroupOrderMaster_DoubleClick(object sender, EventArgs e)
        {
            if (dgvGroupOrderMaster.SelectedRows.Count <= 0)
                return;

            DataGridViewRow objCurRow = dgvGroupOrderMaster.SelectedRows[0];
            DataSet objDataSetItems = new DataSet();
            objDataSetItems = EMREditHisAdaperUse.getGroupOrderItems(objCurRow.Cells["GROUP_ORDER_ID"].Value.ToString());

            if (objDataSetItems.Tables.Count <= 0)
                return;

            if (objDataSetDoctorOrders.Tables.Count <= 0)
                return;

            if (MessageBox.Show("是否插入套餐医嘱【" + objCurRow.Cells["TITLE"].Value.ToString() + "】?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return; 

            DataTable objTableItems;
            objTableItems = objDataSetItems.Tables[0];

            DataTable objTable;
            objTable = objDataSetDoctorOrders.Tables[0];

            //提取医嘱序号
            int nOrderNo = 0;
            if (objTable.Rows.Count > 0)  //set  order_no=1
            {
                DataRow objDataRowPrev = objTable.Rows[objTable.Rows.Count - 1];
                nOrderNo = Convert.ToInt32(objDataRowPrev["order_no"].ToString()) + 0;
            }

            string strTemp;
            foreach (DataRow drCurrent in objTableItems.Rows)
            {
                DataRow objDataRow = objTable.NewRow();
                objDataRow["patient_id"] = EmrSysPubVar.getCurPatientID();
                objDataRow["visit_id"] = EmrSysPubVar.getCurPatientVisitID();
                objDataRow["start_date_time"] = EmrSysPubFunction.getServerNow();

                objDataRow["repeat_indicator"] = Convert.ToInt32(drCurrent["repeat_indicator"].ToString());
                objDataRow["ORDER_TEXT"] = drCurrent["ORDER_TEXT"].ToString();
                objDataRow["ORDER_CLASS"] = drCurrent["ORDER_CLASS"].ToString();
                strTemp = drCurrent["DOSAGE"].ToString();
                if (strTemp.Length>0)
                    objDataRow["DOSAGE"] = Convert.ToDouble(strTemp);
                objDataRow["DOSAGE_UNITS"] = drCurrent["DOSAGE_UNITS"].ToString();
                objDataRow["ADMINISTRATION"] = drCurrent["ADMINISTRATION"].ToString();
                objDataRow["FREQUENCY"] = drCurrent["FREQUENCY"].ToString();

                strTemp = drCurrent["FREQ_COUNTER"].ToString();
                if (strTemp.Length > 0)
                    objDataRow["FREQ_COUNTER"] = Convert.ToDouble(strTemp);

                strTemp = drCurrent["FREQ_INTERVAL"].ToString();
                if (strTemp.Length > 0)
                    objDataRow["FREQ_INTERVAL"] = Convert.ToDouble(strTemp);

                objDataRow["FREQ_INTERVAL_UNIT"] =drCurrent["FREQ_INTERVAL_UNIT"].ToString();
                objDataRow["ORDER_CODE"] =drCurrent["ORDER_CODE"].ToString();
                objDataRow["ORDER_NO"] =nOrderNo+Convert.ToInt32(drCurrent["ITEM_NO"].ToString());
                objDataRow["ORDER_SUB_NO"] = Convert.ToInt32(drCurrent["ITEM_SUB_NO"].ToString());

                objDataRow["doctor"] = EmrSysPubVar.getOperator();
                objDataRow["order_sub_no"] = 1;
                objDataRow["ordering_dept"] = EmrSysPubVar.getDeptCode();
                objDataRow["ORDER_PRINT_INDICATOR"] = 0;
                objDataRow["ORDER_STATUS"] = '0';
                objDataRow["START_STOP_INDICATOR"] = 0;
                objTable.Rows.Add(objDataRow);
            }

            dgvDoctorOrder.DataSource = objTable.DefaultView;


        }

        private void dgvDoctorOrder_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                e.Cancel = true;
                return;
            }
            e.Cancel=openCellCodeInput(e.RowIndex, e.ColumnIndex);           

        }

        private bool openCellCodeInput(int nRowIndex ,int nColumnIndex )
        {
            string strColumnName;
            DataGridViewColumn objColumn;
            DataGridViewRow objCurRow = dgvDoctorOrder.Rows[nRowIndex];

            DataTable objTable;
            objTable = objDataSetDoctorOrders.Tables[0];
            DataRow objDataRow = objTable.Rows[nRowIndex];

            if (Convert.ToInt32(objDataRow["order_status"].ToString()) > 0)
                return true;

            objColumn = dgvDoctorOrder.Columns[nColumnIndex];
            strColumnName = objColumn.DataPropertyName.ToUpper();
            bool bChage = false;
            switch (strColumnName)
            {
                case "ORDER_TEXT":
                    {
                        string strOrderClass;
                        strOrderClass = objCurRow.Cells["ORDER_CLASS_D"].Value.ToString();
                        //弹出拼音输入法
                        codeStruc pcodeStruc = new codeStruc();
                        pcodeStruc = EmrSysPubFunction.openCodeInput("clinic_item", strOrderClass);
                        if (pcodeStruc.codename.Length > 0)
                        {
                            objDataRow["ORDER_TEXT"] = pcodeStruc.codename;
                            if (pcodeStruc.codeitem != null)
                            {
                                if (pcodeStruc.codeitem.Length>10)
                                    objDataRow["ORDER_CODE"] = pcodeStruc.codeitem.Substring(0, 10);
                                else
                                    objDataRow["ORDER_CODE"] = pcodeStruc.codeitem;
                            }
                            bChage = true;
                            switch (strOrderClass)
                            {
                                case "A": //西药 
                                case "B": //中药 
                                    {
                                        if (pcodeStruc.codeitem != null)
                                        {
                                            DataTable objTableDrugDict;
                                            objTableDrugDict = EMREditHisAdaperUse.getDrugDict(pcodeStruc.codeitem);
                                            if (objTableDrugDict != null)
                                            {
                                                if (objTableDrugDict.Rows.Count > 0)
                                                {
                                                    DataRow objCurDataRow = objTableDrugDict.Rows[0];
                                                    objDataRow["dosage_units"] = objCurDataRow["DOSE_UNITS"];
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case "C": //化验 
                                    break;
                                case "D": //检查 
                                    break;
                                case "E": //处置 
                                    break;
                                case "F": //手术 
                                    break;
                                case "G": //麻醉 
                                    break;
                                case "H": //护理 
                                    break;
                                case "I": //膳食 
                                    break;
                                case "Z": //其它 
                                    break;
                            }

                        }


                        if (bChage)
                            dgvDoctorOrder.Refresh();

                        return bChage;
                    }
            }
            return bChage;

        }


        private void dgvDoctorOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string strColumnName;
            DataGridViewColumn objColumn;
            DataGridViewRow objCurRow = dgvDoctorOrder.Rows[e.RowIndex];

            DataGridViewCell objCell ;
            objCell = objCurRow.Cells["order_text_d"];

            DataTable objTable;
            objTable = objDataSetDoctorOrders.Tables[0];
            DataRow objDataRow = objTable.Rows[e.RowIndex];


            objColumn = dgvDoctorOrder.Columns[e.ColumnIndex];
            strColumnName = objColumn.DataPropertyName.ToUpper();


            switch (strColumnName)
            {
                case "ORDER_CLASS":
                    {
                        objDataRow["order_text"] = DBNull.Value;
                        objDataRow["administration"] = DBNull.Value;
                        objDataRow["frequency"] = DBNull.Value;
                        objDataRow["freq_interval_unit"] = DBNull.Value;
                        objDataRow["freq_interval"] = DBNull.Value;
                        objDataRow["freq_counter"] = DBNull.Value;
                        objDataRow["dosage"] = DBNull.Value;
                        objDataRow["dosage_units"] = DBNull.Value;
                        dgvDoctorOrder.Refresh();
                        objCell.Selected = true;
                        openCellCodeInput(objCell.RowIndex, objCell.ColumnIndex);
                    }
                    break;
                case "REPEAT_INDICATOR":
                    {
                        objDataRow["DURATION"] = DBNull.Value;
                        objDataRow["DURATION_UNITS"] = DBNull.Value;
                        dgvDoctorOrder.Refresh();
                    }
                    break;
                case "FREQUENCY":
                    {
                        DataTable objTablePerformFreqDict;
                        objTablePerformFreqDict = EMREditHisAdaperUse.getPerformFreqDict(objDataRow["FREQUENCY"].ToString());
                        if (objTablePerformFreqDict != null)
                        {
                            if (objTablePerformFreqDict.Rows.Count > 0)
                            {
                                DataRow objCurDataRow = objTablePerformFreqDict.Rows[0];
                                objDataRow["freq_interval_unit"] = objCurDataRow["FREQ_INTERVAL_UNITS"];
                                objDataRow["freq_interval"] = objCurDataRow["FREQ_INTERVAL"];
                                objDataRow["freq_counter"] = objCurDataRow["FREQ_COUNTER"];
                                dgvDoctorOrder.Refresh();
                            }
                        }
                    }
                    break;
                case "FREQ_COUNTER":
                case "FREQ_INTERVAL":
                case "FREQ_INTERVAL_UNIT":
                    setFrequency(strColumnName, objDataRow);
                    break;
            }


        }


        private void setFrequency(string strColumnName, DataRow objDataRow)
        {
            string strValue="";
            if (objDataRow["strColumnName"]==null)
                return;

            strValue=objDataRow["strColumnName"].ToString();

            switch (strColumnName)
            {
                case "FREQ_COUNTER":
                    {
                        if (objDataRow["freq_interval"]!=null && objDataRow["freq_interval_unit"]!=null)
                        {
                            strValue+="/"+objDataRow["freq_interval"].ToString()+objDataRow["freq_interval_unit"].ToString();
                            if (objDataRow["frequency"]!=null)
                            {
                                if (objDataRow["frequency"].ToString()!=strValue)
                                    objDataRow["frequency"] = strValue;
                            }
                            else
                                objDataRow["frequency"]=strValue;
                        }
                   }
                   break;

               case "FREQ_INTERVAL":
                   {
                       if (objDataRow["freq_counter"] != null && objDataRow["freq_interval_unit"] != null)
                       {
                           strValue = objDataRow["freq_counter"].ToString() + "/" + strValue + objDataRow["freq_interval_unit"].ToString();
                           if (objDataRow["frequency"] != null)
                           {
                               if (objDataRow["frequency"].ToString() != strValue)
                                   objDataRow["frequency"] = strValue;
                           }
                           else
                               objDataRow["frequency"] = strValue;
                       }
                   }
                   break;

               case "FREQ_INTERVAL_UNIT":
                   {
                       if (objDataRow["freq_counter"] != null && objDataRow["freq_interval"] != null)
                       {
                           strValue = objDataRow["freq_counter"].ToString() + "/" + objDataRow["freq_interval"].ToString() + strValue;
                           if (objDataRow["frequency"] != null)
                           {
                               if (objDataRow["frequency"].ToString() != strValue)
                                   objDataRow["frequency"] = strValue;
                           }
                           else
                               objDataRow["frequency"] = strValue;
                       }
                   }
                   break;

            }
        }

        private void panelOrderDetail_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertNewRow(false);
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            //一定是要在全部显示记录的情况下
            DataTable objTable;
            objTable = objDataSetDoctorOrders.Tables[0];
            if (objTable.Rows.Count == 0)
            {
                insertNewRow(false);
                return;
            }

            if (dgvDoctorOrder.SelectedRows.Count <= 0)
                return;

            DataGridViewRow objCurRow = dgvDoctorOrder.SelectedRows[0];
            DataRow objCurDataRow = objTable.Rows[objCurRow.Index];
            if (Convert.ToInt32(objCurDataRow["order_status"].ToString())>1)
            {
                MessageBox.Show("当前医嘱已经校对，请用‘新增’。");
                return;
            }
            
            int nOrderNo,nOrderSubNo;
            nOrderNo=Convert.ToInt32(objCurDataRow["order_no"].ToString());
            nOrderSubNo=Convert.ToInt32(objCurDataRow["order_sub_no"].ToString());

            DataRow objDataRow = objTable.NewRow();
            objDataRow["patient_id"] = EmrSysPubVar.getCurPatientID();
            objDataRow["visit_id"] = EmrSysPubVar.getCurPatientVisitID();
            objDataRow["start_date_time"] = EmrSysPubFunction.getServerNow() ;

            objDataRow["doctor"] = EmrSysPubVar.getOperator();
            objDataRow["order_sub_no"] = 1;
            objDataRow["ordering_dept"] = EmrSysPubVar.getDeptCode() ;
            objDataRow["ORDER_PRINT_INDICATOR"] = 0;
            objDataRow["ORDER_STATUS"] = '0';
            objDataRow["START_STOP_INDICATOR"] = 0;

            objDataRow["order_no"] =nOrderNo;

            objTable.Rows.InsertAt(objDataRow, objCurRow.Index);


            //modify the order_no whose row number is more than the current row's
            for (int i=objCurRow.Index+1;i<objTable.Rows.Count;i++)
            {
                DataRow objTmpDataRow = objTable.Rows[i];
                if (objTmpDataRow.RowState == DataRowState.Deleted)
                    continue;
                objTmpDataRow["order_no"] = Convert.ToInt32(objTmpDataRow["order_no"].ToString()) + 1;
            }

            /* 更新计价属性
            for i = 1 to dw_order_cost.RowCount()
            dw_order_cost.SetItem(i, "order_no", &
	                    dw_order_cost.GetItemNumber(i, "order_no") +1)
            next
            */
            dgvDoctorOrder.Refresh();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDoctorOrder.SelectedRows.Count <= 0)
                return;

            DataTable objTable;
            objTable = objDataSetDoctorOrders.Tables[0];
            DataGridViewRow objCurRow = dgvDoctorOrder.SelectedRows[0];
            DataRow objCurDataRow = objTable.Rows[objCurRow.Index];
            if (Convert.ToInt32(objCurDataRow["order_status"].ToString()) >0)
            {
                MessageBox.Show("不是新开的医嘱不能删除！");
                return;
            }
            int nIndex = objCurRow.Index+1;
            objCurDataRow.Delete();
//            objTable.Rows.Remove(objCurDataRow);
            
            for (int i = nIndex; i < objTable.Rows.Count; i++)
            {
                DataRow objTmpDataRow = objTable.Rows[i];
                if (objTmpDataRow.RowState == DataRowState.Deleted)
                    continue;
                objTmpDataRow["order_no"] = Convert.ToInt32(objTmpDataRow["order_no"].ToString()) - 1;
            }
            
            dgvDoctorOrder.Refresh();
        }

        private void btnChildorder_Click(object sender, EventArgs e)
        {
            if (dgvDoctorOrder.SelectedRows.Count <= 0)
                return;

            DataTable objTable;
            objTable = objDataSetDoctorOrders.Tables[0];
            DataGridViewRow objCurRow = dgvDoctorOrder.SelectedRows[0];
            if (objCurRow.Index<=0)
                return;
            DataRow objCurDataRow = objTable.Rows[objCurRow.Index];
            if (Convert.ToInt32(objCurDataRow["order_status"].ToString()) > 0)
            {
                MessageBox.Show("医嘱校对后不能进行此操作！");
                return;
            }
            int nOrderNo, nOrderSubNo;
            nOrderNo = Convert.ToInt32(objCurDataRow["order_no"].ToString());
            nOrderSubNo = Convert.ToInt32(objCurDataRow["order_sub_no"].ToString());
            if (nOrderSubNo == 1) //组合复合医嘱
            {
                DataRow objDataRowPrev = objTable.Rows[objCurRow.Index - 1];
                if (objCurDataRow["order_class"].ToString() != "A" || objDataRowPrev["order_class"].ToString() != "A")
                {
                    MessageBox.Show("不是药疗医嘱不能构成复合医嘱！");
                    return;
                }

                if (Convert.ToInt32(objDataRowPrev["order_status"]) > 0)
                {
                    MessageBox.Show("与提交后的医嘱不能构成复合医嘱！");
                    return;
                }

                object objCurAdministration = objCurDataRow["administration"];
                object objPrevAdministration = objDataRowPrev["administration"];
                if (objCurAdministration != null && objPrevAdministration != null)
                {
                    if (objCurAdministration.ToString() != objPrevAdministration.ToString())
                    {
                        MessageBox.Show("途径不同的医嘱不能构成复合医嘱！");
                        return;
                    }
                }
                objCurDataRow["order_class"] = objDataRowPrev["order_class"];
                objCurDataRow["frequency"] = objDataRowPrev["frequency"];
                objCurDataRow["administration"] = objDataRowPrev["administration"];


                objCurDataRow["order_no"] = objDataRowPrev["order_no"];
                int nPrevOrderSubNo = Convert.ToInt32(objDataRowPrev["order_sub_no"].ToString());
                int nPrevOrderNo = Convert.ToInt32(objDataRowPrev["order_no"].ToString());
                nPrevOrderSubNo++;
                objCurDataRow["ORDER_SUB_NO"] = nPrevOrderSubNo;

                objCurDataRow["freq_counter"] = objDataRowPrev["freq_counter"];
                objCurDataRow["freq_interval"] = objDataRowPrev["freq_interval"];
                objCurDataRow["freq_interval_unit"] = objDataRowPrev["freq_interval_unit"];
                objCurDataRow["enter_date_time"] = objDataRowPrev["enter_date_time"];

                //修改后续行的子号和序号	
                for (int i = objCurRow.Index + 1; i < objTable.Rows.Count; i++)
                {
                    DataRow objTmpDataRow = objTable.Rows[i];
                    if (objTmpDataRow.RowState == DataRowState.Deleted)
                        continue;
                    if (Convert.ToInt32(objTmpDataRow["ORDER_NO"].ToString()) == nOrderNo)
                    {
                        objTmpDataRow["order_no"] = nPrevOrderNo;
                        nPrevOrderSubNo++;
                        objCurDataRow["ORDER_SUB_NO"] = nPrevOrderSubNo;
                    }
                    else
                        objTmpDataRow["order_no"] = Convert.ToInt32(objTmpDataRow["order_no"].ToString()) - 1;

                }
            }
            else //拆分符合医嘱
            {
                objCurDataRow["order_no"] = nOrderNo+1;
                nOrderSubNo = 1;
                objCurDataRow["ORDER_SUB_NO"] = nOrderSubNo;
                nOrderSubNo++;
                //修改后续行的子号和序号	
                for (int i = objCurRow.Index + 1; i < objTable.Rows.Count; i++)
                {
                    DataRow objTmpDataRow = objTable.Rows[i];
                    if (objTmpDataRow.RowState == DataRowState.Deleted)
                        continue;
                    if (Convert.ToInt32(objTmpDataRow["ORDER_NO"].ToString()) == nOrderNo)
                    {
                        objTmpDataRow["order_no"] = nOrderNo+1;
                        objCurDataRow["ORDER_SUB_NO"] = nOrderSubNo;
                        nOrderSubNo++;
                    }
                    else
                        objTmpDataRow["order_no"] = Convert.ToInt32(objTmpDataRow["order_no"].ToString()) + 1;

                }

            }

            dgvDoctorOrder.Refresh();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //校验数据
            DataTable objTable;
            objTable = objDataSetDoctorOrders.Tables[0];
            for (int i = 0; i < objTable.Rows.Count; i++)
            {
                DataRow objTmpDataRow = objTable.Rows[i];
                if (objTmpDataRow.RowState == DataRowState.Deleted)
                    continue;

                if (objTmpDataRow["order_class"].ToString() == "A" || objTmpDataRow["order_class"].ToString() == "B")
                {
                    if (objTmpDataRow["dosage"]==null || objTmpDataRow["dosage_units"]==null)
                    {
                        if (MessageBox.Show("第"+i.ToString()+"行药品剂量/单位为空,继续吗?", "数据校验", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return; 
                    }
                    if (objTmpDataRow["administration"]==null)
                    {
                        MessageBox.Show("第"+i.ToString()+"行药品途径不能为空!");
                        return;
                    }

                    if (objTmpDataRow["frequency"] == null && Convert.ToInt32(objTmpDataRow["repeat_indicator"].ToString()) == 1)
                    {
                        MessageBox.Show("第"+i.ToString()+"行药疗长期医嘱的频率不能为空!");
                        return;
                    }
                }

                if (objTmpDataRow["order_class"]==null || objTmpDataRow["repeat_indicator"]==null || objTmpDataRow["start_date_time"]==null || objTmpDataRow["order_text"]==null)
                {
                    MessageBox.Show("第"+i.ToString()+"行‘长/临’‘类别’‘下达时间’‘内容’不能为空!");
                    return;
                }

                //判断下医嘱的时间

            }
            //EntityDoctorOrder pp = new EntityDoctorOrder();
            //if (DALUse.UpdateDataSet(objDataSetDoctorOrders, pp))
            //    MessageBox.Show("保存成功！");
            //else
            //    MessageBox.Show("保存失败！");

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            //提示先保存医嘱
            DataSet objDataSetDoctorOrdersChanges=objDataSetDoctorOrders.GetChanges();
            DataTable objTable;
            objTable = objDataSetDoctorOrders.Tables[0];

            if (objDataSetDoctorOrdersChanges!=null)
            {
                MessageBox.Show("请先保存医嘱。");
                return;
            }

            if (MessageBox.Show("是否提交新开的医嘱?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return; 

            //校验数据
            int ncountExam=0, ncountLab=0;
            for (int i = 0; i < objTable.Rows.Count; i++)
            {
                DataRow objTmpDataRow = objTable.Rows[i];
                if (objTmpDataRow.RowState == DataRowState.Deleted)
                    continue;

                if (objTmpDataRow["order_status"].ToString()=="0")
                {
                    objTmpDataRow["order_status"]="1";
                    if (objTmpDataRow["order_class"].ToString() == "D")  //检查
                        ncountExam++;
                    if (objTmpDataRow["order_class"].ToString() == "C")  //检验
                        ncountLab++;

                    objTmpDataRow["enter_date_time"]=EmrSysPubFunction.getServerNow() ;
                }
            }
            //保存到数据库
            if (!DALUse.UpdateDataSet(objDataSetDoctorOrders, ""))
            {
                MessageBox.Show("保存失败！");
                return;
            }

            //发送电子申请单
            if (ncountExam > 0 || ncountLab > 0)
            {
                if (MessageBox.Show("提交的医嘱中有" + ncountExam.ToString() + "个检查项目，" + ncountLab.ToString()+"个化验项目，是否发送电子申请单？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    ncountExam = ncountLab; 
            }

            //向护士站发送消息
            //添加质控信息
            dgvDoctorOrder.Refresh();
        }

        private void rbAllStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllStatus.Checked)
            {
                panelOrderGroup.Visible = false;
                panelDiagnose.Visible = false;
                dgvOrders.Visible = true;
                lblDoctorOrder.Visible = true;
                dgvDoctorOrder.Visible = true;
                dgvDoctorOrder.ReadOnly = true;
                dgvOrders.Height = panelOrderGroup.Bottom - dgvOrders.Top;
                btnAdd.Enabled = false;
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
                btnChildorder.Enabled = false;
                btnSave.Enabled = false;
                btnCommit.Enabled = false;
            }
        }

        private void rbCarried_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCarried.Checked)
            {
                panelOrderGroup.Visible = false;
                panelDiagnose.Visible = false;
                dgvOrders.Visible = true;
                lblDoctorOrder.Visible = false;
                dgvDoctorOrder.Visible = false;
                dgvDoctorOrder.ReadOnly = true;
                dgvOrders.Height = dgvDoctorOrder.Bottom - dgvOrders.Top;
                btnAdd.Enabled = false;
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
                btnChildorder.Enabled = false;
                btnSave.Enabled = false;
                btnCommit.Enabled = false;
            }
        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked)
            {
                panelOrderGroup.Visible = true;
                panelDiagnose.Visible = true;
                dgvOrders.Visible = false;
                lblDoctorOrder.Visible = true;
                dgvDoctorOrder.Visible = true;
                dgvDoctorOrder.ReadOnly = false;
                dgvOrders.Height = panelOrderGroup.Bottom - dgvOrders.Top;
                btnAdd.Enabled = rbAllOrders.Checked;
                btnInsert.Enabled = rbAllOrders.Checked;
                btnDelete.Enabled = rbAllOrders.Checked;
                btnChildorder.Enabled = rbAllOrders.Checked;
                btnSave.Enabled = rbAllOrders.Checked;
                btnCommit.Enabled = rbAllOrders.Checked;
            }
        }

        private void rbAllOrders_CheckedChanged(object sender, EventArgs e)
        {
            objDataSetOrders.Tables[0].DefaultView.RowFilter = "";
            objDataSetDoctorOrders.Tables[0].DefaultView.RowFilter = "";
            btnAdd.Enabled = rbNew.Checked;
            btnInsert.Enabled = rbNew.Checked;
            btnDelete.Enabled = rbNew.Checked;
            btnChildorder.Enabled = rbNew.Checked;
            btnSave.Enabled = rbNew.Checked;
            btnCommit.Enabled = rbNew.Checked;
            dgvDoctorOrder.ReadOnly = !btnAdd.Enabled;

        }

        private void rbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            objDataSetOrders.Tables[0].DefaultView.RowFilter = "repeat_indicator=1";
            objDataSetDoctorOrders.Tables[0].DefaultView.RowFilter = "repeat_indicator=1";

            btnAdd.Enabled = false;
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            btnChildorder.Enabled = false;
            btnSave.Enabled = false;
            btnCommit.Enabled = false;
            dgvDoctorOrder.ReadOnly = !btnAdd.Enabled;
        }

        private void rbTemp_CheckedChanged(object sender, EventArgs e)
        {
            objDataSetOrders.Tables[0].DefaultView.RowFilter = "repeat_indicator=0";
            objDataSetDoctorOrders.Tables[0].DefaultView.RowFilter = "repeat_indicator=0";
            btnAdd.Enabled = false;
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            btnChildorder.Enabled = false;
            btnSave.Enabled = false;
            btnCommit.Enabled = false;
            dgvDoctorOrder.ReadOnly = !btnAdd.Enabled;
        }


    }
}
