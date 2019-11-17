using DevExpress.DataAccess.Sql.DataApi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{

    
   
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
    }
}
