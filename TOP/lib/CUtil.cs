using DevExpress.DataAccess.Excel;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraWaitForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public static class ExcelDataSourceExtension
    {
        public static DataTable ToDataTable( ExcelDataSource excelDataSource)
        {
            IList list = ((IListSource)excelDataSource).GetList();
            DevExpress.DataAccess.Native.Excel.DataView dataView = (DevExpress.DataAccess.Native.Excel.DataView)list;
            List<PropertyDescriptor> props = dataView.Columns.ToList<PropertyDescriptor>();

            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (DevExpress.DataAccess.Native.Excel.ViewRow item in list)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }


    public static class CUtil
    {
        
        public static DataTable GetTable(ITable result)
        {
            try
            {
                DataTable dt = new DataTable(result.Name);

                foreach (IColumn column in result.Columns)
                    dt.Columns.Add(column.Name, column.Type);
                foreach (IRow row in result)
                    dt.Rows.Add(row.ToArray());

                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }
          

        }


        public static List<DataColumn> GetColumns(DataTable dt)
        {
            List<DataColumn> columns = new List<DataColumn>();

            foreach (DataColumn item in dt.Columns)
            {
                columns.Add(item);    
            }

            return columns;
        }

        public static ProgressPanel GetProgress(string caption, string desc)
        {
            ProgressPanel progressPanel1 = new ProgressPanel();
            progressPanel1.Caption = "Loading";
            progressPanel1.Description = "Please wait...";
            progressPanel1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            
            progressPanel1.Top = 100;
            progressPanel1.Left = 100;

            return progressPanel1;

            //아래 항목은 호출하는 쪽에서 해줘야 함 
            //progressPanel1.Parent = this;
            //this.Controls.Add(progressPanel1);

            //progressPanel1.Show();
            //progressPanel1.BringToFront();
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        }
    }
}
