using System.Collections.Generic;
using System.Data;

namespace TOP.lib
{
    /// <summary>
    /// 토적 Data를 Load하여 관리합니다.
    /// Sheet 별로 Data Table화 하여 관리합니다.
    /// </summary>
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