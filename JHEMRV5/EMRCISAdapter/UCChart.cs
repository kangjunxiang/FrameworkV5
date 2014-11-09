using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JHEMR.EMREdit
{
    public partial class UCChart : UserControl
    {
        public UCChart()
        {
            InitializeComponent();
        }

        private void UCChart_Load(object sender, EventArgs e)
        {
            this.axMSChart1.Column = 1;
            this.axMSChart1.Data = "10";
            this.axMSChart1.Column = 2;
            this.axMSChart1.Data = "20";

        }
        public void SetChartDataSet(DataSet objDataSet,string strTitle)
        {
            try
            {
                if (objDataSet.Tables.Count > 0)
                {
                    DataTable objTable;
                    objTable = objDataSet.Tables[0];
                    if (objTable.Rows.Count > 0)
                    {
                        axMSChart1.RowCount = (short)objTable.Rows.Count;
                        axMSChart1.ColumnCount = 1;
                        axMSChart1.TitleText = strTitle;
                        short i=1;

                        for (i = 1; i <= objTable.Rows.Count; i++)
                        {
                            DataRow drCurrent = objTable.Rows[i - 1];
                            axMSChart1.DataGrid.set_RowLabel(i, 1, Convert.ToDateTime(drCurrent["RESULT_DATE_TIME"].ToString()).ToString("MM-dd"));
                            axMSChart1.DataGrid.SetData(i, 1, Convert.ToDouble(drCurrent["RESULT"].ToString()), 0);
                        }
                    }

                }
            }
            catch (System.Exception E)
            {
                string err=E.ToString();
            }
           

        }
    }
}
