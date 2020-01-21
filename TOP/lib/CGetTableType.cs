using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public static class CGetTableType
    {
        /// <summary>
        /// 맨홀 높이를 관리하는 데이터 테이블을 만든다.
        /// </summary>
        /// <returns></returns>
        public static DataTable GetMhHeight()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("LINENAME", typeof(string));
            dt.Columns.Add("MhHeight", typeof(string));

            return dt;
        }
    }
}
