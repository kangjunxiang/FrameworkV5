using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using JHEMR.EmrSysUserCtl;
using JHEMR.EmrSysCom;
using EmrSysWebservices;
using System.Web.Services;

namespace JHEMR.EMREdit
{
    public partial class UCEMROrders : UserControl
    {
        #region private members
        // example of a bound object list
        private ArrayList OrderList;

        // specifies the current data view (bound/unbound, dataset)
        private string View;

        // remember the column index that was last sorted on
        private int prevColIndex = -1;

        // remember the direction the rows were last sorted on (ascending/descending)
        private ListSortDirection prevSortDirection = ListSortDirection.Ascending;
        #endregion private members
        private string m_CurPatientID;
        private int m_CurVisitID;
        private　DataSet objDataSet = new DataSet();
       
    
        public UCEMROrders()
        {
            InitializeComponent();
        }

        public void setPatient(string strPatientID, int intVisitID)
        {
            m_CurPatientID = strPatientID;
            m_CurVisitID = intVisitID;
            DataLoad();
        }

        private void DataLoad()
        {
            //填充数据
            DataSet objDataSet = new DataSet();
            objDataSet = EmrSysWebservicesUse.myEmrGetOrderDataSetByPatentID(m_CurPatientID, m_CurVisitID); ;
            if (objDataSet == null)
                return;
            if (objDataSet.Tables.Count > 0)
            {
                DataTable objTable;
                objTable = objDataSet.Tables[0];
                gcOrder.DataSource = objTable;
            }
        }

        private void UCEMROrders_Load(object sender, EventArgs e)
        {
            // invoke the outlook style
            //menuSkinOutlook_Click(sender, e);



        }

        #region menu handlers

        private void menuSkinOutlook_Click(object sender, EventArgs e)
        {
            this.outlookGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle2.BackColor = Color.FromArgb(247, 247, 247);// System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23,75,115);// System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.outlookGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.outlookGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;

            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.outlookGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;

            this.outlookGrid1.GridColor = System.Drawing.SystemColors.Control;
            this.outlookGrid1.RowTemplate.Height = 19;
            this.outlookGrid1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.outlookGrid1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.outlookGrid1.RowHeadersVisible = false;
            this.outlookGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.outlookGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.outlookGrid1.AllowUserToAddRows = false;
           // this.outlookGrid1.AutoResizeColumns();
            this.outlookGrid1.AllowUserToDeleteRows = false;
            this.outlookGrid1.AllowUserToResizeRows = false;
            this.outlookGrid1.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.outlookGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.outlookGrid1.ClearGroups(); // reset

        }

        private void menuUnboundContactList_Click(object sender, EventArgs e)
        {
            // this is an example of adding unbound data into the grid
            // while the grouping mechanism keeps functioning

            // first clear any previous bindings
            outlookGrid1.BindData(null, null);

            // setup the column headers
            outlookGrid1.Columns.Add("column1", "住院日");
            outlookGrid1.Columns.Add("column2", "长期");
            outlookGrid1.Columns.Add("column3", "类别");
            outlookGrid1.Columns.Add("column4", "开始时间");
            outlookGrid1.Columns.Add("column5", "医嘱内容");
            outlookGrid1.Columns.Add("column6", "剂量");
            outlookGrid1.Columns.Add("column7", "单位");

            // example of unbound items
            foreach (OrderInfo obj in OrderList)
            {
                // notice that the outlookgrid only works with OutlookGridRow objects
                OutlookGridRow row = new OutlookGridRow();
                row.CreateCells(outlookGrid1,obj.AdmissionDateTime, obj.RepeatIndicator , obj.OrderClass, obj.StartDateTime, obj.OrderText, obj.Dosage,obj.DosageUnits);
                outlookGrid1.Rows.Add(row);
            }

            //set our view for sorting
            View = "UnboundContactInfo";

        }


        private void outlookGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex >= 0)
            {
                ListSortDirection direction = ListSortDirection.Ascending;
                if (e.ColumnIndex == prevColIndex) // reverse sort order
                    direction = prevSortDirection == ListSortDirection.Descending ? ListSortDirection.Ascending : ListSortDirection.Descending;

                // remember the column that was clicked and in which direction is ordered
                prevColIndex = e.ColumnIndex;
                prevSortDirection = direction;

                // set the column to be grouped
                outlookGrid1.GroupTemplate.Column = outlookGrid1.Columns[e.ColumnIndex];

                //sort the grid (based on the selected view)
                switch (View)
                {
                    case "BoundContactInfo":
                        outlookGrid1.Sort(new ContactInfoComparer(e.ColumnIndex, direction));
                        break;
                    case "BoundCategory":
                        outlookGrid1.Sort(new DataRowComparer(e.ColumnIndex, direction));
                        break;
                    case "BoundInvoices":
                        outlookGrid1.Sort(new DataRowComparer(e.ColumnIndex, direction));
                        break;
                    case "BoundQuarterly":
                        // this is an example of overriding the default behaviour of the
                        // Group object. Instead of using the DefaultGroup behavious, we
                        // use the AlphabeticGroup, so items are grouped together based on
                        // their first character:
                        // all items starting with A or a will be put in the same group.
                        IOutlookGridGroup prevGroup = outlookGrid1.GroupTemplate;

                        if (e.ColumnIndex == 0) // execption when user pressed the customer name column
                        {
                            // simply override the GroupTemplate to use before sorting
                            outlookGrid1.GroupTemplate = new OutlookGridAlphabeticGroup();
                            outlookGrid1.GroupTemplate.Collapsed = prevGroup.Collapsed;
                        }

                        // set the column to be grouped
                        // this must always be done before sorting
                        outlookGrid1.GroupTemplate.Column = outlookGrid1.Columns[e.ColumnIndex];

                        // execute the sort, arrange and group function
                        outlookGrid1.Sort(new DataRowComparer(e.ColumnIndex, direction));

                        //after sorting, reset the GroupTemplate back to its default (if it was changed)
                        // this is needed just for this demo. We do not want the other
                        // columns to be grouped alphabetically.
                        outlookGrid1.GroupTemplate = prevGroup;
                        break;
                    default: //UnboundContactInfo
                        outlookGrid1.Sort(outlookGrid1.Columns[e.ColumnIndex], direction);
                        break;
                }
            }

        }
        #endregion menu handlers

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
          
        }

        private void filterOrderRecord1()
        {
            //if (objDataSet.Tables.Count > 0)
            //{
            //    DataTable objTable;
            //    objTable = objDataSet.Tables[0];
            //    if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            //        objTable.DefaultView.RowFilter = "";
            //    else
            //    {
            //        string strFilter = "";
            //        //看看是否需要过滤长期临时状态
            //        if (checkBox1.Checked)
            //            strFilter = "(REPEAT_INDICATOR='长期' and  ORDER_STATUS<5) ";

            //        if (checkBox2.Checked)
            //        {
            //            if (strFilter.Length > 0)
            //                strFilter += " OR ";
            //            strFilter += " (REPEAT_INDICATOR='长期'  and  ORDER_STATUS=5) ";
            //        }

            //        if (checkBox3.Checked)
            //        {
            //            if (strFilter.Length > 0)
            //                strFilter += " OR ";
            //            strFilter += "(REPEAT_INDICATOR='临时' and (ORDER_CLASS<>'放射类' and ORDER_CLASS<>'检查类' and ORDER_CLASS<>'化验类') ) ";
            //        }

            //        if (checkBox4.Checked)
            //        {
            //            if (strFilter.Length > 0)
            //                strFilter += " OR ";
            //            strFilter += "(REPEAT_INDICATOR='临时' and (ORDER_CLASS='放射类' or ORDER_CLASS='检查类' or ORDER_CLASS='化验类'))";
            //        }

            //        if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            //        {
            //            gcOrder.DataSource = null;
            //        }
            //        else
            //        {
            //            objTable.DefaultView.RowFilter = strFilter;
            //            objTable.DefaultView.Sort = "START_DATE_TIME";
            //            gcOrder.DataSource = objTable;
            //        }

            //    }


            //    //gcOrder.DataSource = objTable;

            //}
        }

        private void gcOrder_Click(object sender, EventArgs e)
        {

        }

        private void gcOrder_Load(object sender, EventArgs e)
        {
            setPatient(EmrSysPubVar.getCurPatientID(), EmrSysPubVar.getCurPatientVisitID());
        }
      
    }
    #region Comparers - used to sort CustomerInfo objects and DataRows of a DataTable

    /// <summary>
    /// reusable custom DataRow comparer implementation, can be used to sort DataTables
    /// </summary>
    public class DataRowComparer : IComparer
    {
        ListSortDirection direction;
        int columnIndex;

        public DataRowComparer(int columnIndex, ListSortDirection direction)
        {
            this.columnIndex = columnIndex;
            this.direction = direction;
        }

        #region IComparer Members

        public int Compare(object x, object y)
        {

            DataRow obj1 = (DataRow)x;
            DataRow obj2 = (DataRow)y;
            return string.Compare(obj1[columnIndex].ToString(), obj2[columnIndex].ToString()) * (direction == ListSortDirection.Ascending ? 1 : -1);
        }
        #endregion
    }

    // custom object comparer implementation
    public class ContactInfoComparer : IComparer
    {
        private int propertyIndex;
        ListSortDirection direction;

        public ContactInfoComparer(int propertyIndex, ListSortDirection direction)
        {
            this.propertyIndex = propertyIndex;
            this.direction = direction;
        }

        #region IComparer Members

        public int Compare(object x, object y)
        {
            OrderInfo obj1 = (OrderInfo)x;
            OrderInfo obj2 = (OrderInfo)y;

            switch (propertyIndex)
            {
                case 2:
                    return CompareStrings(obj1.OrderClass, obj2.OrderClass);
                case 3:
                    return CompareDates(obj1.StartDateTime, obj2.StartDateTime);
                case 4:
                    return CompareStrings(obj1.OrderText, obj2.OrderText);
                case 5:
                    return CompareStrings(obj1.Dosage, obj2.Dosage);
                case 6:
                    return CompareStrings(obj1.DosageUnits, obj2.DosageUnits);
                case 1:
                    return CompareStrings(obj1.RepeatIndicator, obj2.RepeatIndicator);
                default:
                    return CompareStrings(obj1.AdmissionDateTime, obj2.AdmissionDateTime);
                //                    return CompareNumbers((double)obj1.RepeatIndicator, (double)obj2.RepeatIndicator);
            }
        }
        #endregion

        private int CompareStrings(string val1, string val2)
        {
            return string.Compare(val1, val2) * (direction == ListSortDirection.Ascending ? 1 : -1);
        }

        private int CompareDates(DateTime val1, DateTime val2)
        {
            if (val1 > val2) return (direction == ListSortDirection.Ascending ? 1 : -1);
            if (val1 < val2) return (direction == ListSortDirection.Ascending ? -1 : 1);
            return 0;
        }

        private int CompareNumbers(double val1, double val2)
        {
            if (val1 > val2) return (direction == ListSortDirection.Ascending ? 1 : -1);
            if (val1 < val2) return (direction == ListSortDirection.Ascending ? -1 : 1);
            return 0;
        }
    }
    #endregion Comparers


    #region OrderInfo - example business object implementation
    public class OrderInfo
    {
        public OrderInfo()
        {
        }

        private string admissionDateTime;
        public string AdmissionDateTime
        {
            get { return admissionDateTime; }
            set { admissionDateTime = value; }
        }

        private string repeatIndicator;

        public string RepeatIndicator
        {
            get { return repeatIndicator; }
            set { repeatIndicator = value; }
        }
        private string orderClass;

        public string OrderClass
        {
            get { return orderClass; }
            set { orderClass = value; }
        }
        private DateTime startDateTime;

        public DateTime StartDateTime
        {
            get { return startDateTime; }
            set { startDateTime = value; }
        }
        private string orderText;

        public string OrderText
        {
            get { return orderText; }
            set { orderText = value; }
        }
        private string dosage;
        public string Dosage
        {
            get { return dosage; }
            set { dosage = value; }
        }

        private string dosageUnits;
        public string DosageUnits
        {
            get { return dosageUnits; }
            set { dosageUnits = value; }
        }


    }

    #endregion  

}
