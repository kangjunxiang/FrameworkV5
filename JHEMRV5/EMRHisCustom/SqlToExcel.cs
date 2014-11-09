using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace JHEMR.EMRHisCustom
{
    public class SqlToExcel
    {
        private string ExcelName = "";
        public SqlToExcel(string tableName)
        {
            this.ExcelName = tableName;
        }
        public void ExportToExcel(string fileName, DataTable DTable)
        {
            try
            {
                int count = DTable.Columns.Count;
                string[] array = new string[count];
                for (int i = 0; i <= DTable.Columns.Count - 1; i++)
                {
                    array[i] = DTable.Columns[i].Caption.Trim();
                }
                string text = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";User ID=Admin;Password=;";
                text += "Extended Properties=Excel 8.0;";
                string text2 = "create   table   " + this.ExcelName + "(";
                for (int i = 0; i <= DTable.Columns.Count - 1; i++)
                {
                    text2 = text2 + array[i] + "   varchar,";
                }
                text2 = text2.Remove(text2.Length - 1, 1);
                text2 += ")";
                OleDbConnection oleDbConnection = new OleDbConnection();
                oleDbConnection.ConnectionString = text;
                OleDbCommand oleDbCommand = new OleDbCommand();
                oleDbCommand.Connection = oleDbConnection;
                oleDbCommand.CommandText = text2;
                oleDbConnection.Open();
                oleDbCommand.ExecuteNonQuery();
                string text3 = "insert   into   " + this.ExcelName + "     values(";
                for (int i = 0; i <= DTable.Rows.Count - 1; i++)
                {
                    try
                    {
                        for (int j = 0; j <= DTable.Columns.Count - 1; j++)
                        {
                            text3 = text3 + "'" + DTable.Rows[i][j].ToString() + "',";
                        }
                        text3 = text3.Remove(text3.Length - 1, 1) + ")";
                        oleDbCommand.CommandText = text3;
                        oleDbCommand.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("导出数据失败，请重新导出！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    text3 = "insert   into   " + this.ExcelName + "     values(";
                }
                oleDbConnection.Close();
            }
            catch
            {
                MessageBox.Show("导出数据失败，请检查是否安装有Excel！或没有获得数据！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
