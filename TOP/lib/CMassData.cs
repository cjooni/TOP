using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public class CMassData
    {
        private string sheetName;
        private DataTable data;

        public string SheetName { get => sheetName; set => sheetName = value; }
        public DataTable Data { get => data; set => data = value; }
    }


    public class CMassDataMngr
    {
        private List<CMassData> data;
        public CMassDataMngr()
        {
            Data = new List<CMassData>();
        }


        public List<CMassData> Data { get => data; set => data = value; }


        public void Add(CMassData data)
        {
            Data.Add(data);
        }
    }
}
