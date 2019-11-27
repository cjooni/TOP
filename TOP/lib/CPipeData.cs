using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public class CPipeData
    {
        private DataTable data1;//누가거리	지반고	관저고	관경	맨홀	TEXT1	TEXT2	구간	구배	INV	SIZE	라인명	지하수위	맨홀INVERT
        private DataTable data2;//측점	INV	SIZE	TEXT	BoxT1	BoxT2	BoxT3

        private DataTable manholeDt;
        private DataTable floDt;

        private string data1Position;
        private string data2Position;
        private int data1RowIndex;
        private int data2RowIndex;
        private string sheetName;


        public CPipeData()
        {

        }


        public DataTable Data1 { get => data1; set => data1 = value; }
        public DataTable Data2 { get => data2; set => data2 = value; }
        public DataTable ManholeDt { get => manholeDt; set => manholeDt = value; }

        public string Data1Position { get => data1Position; set => data1Position = value; }
        public string Data2Position { get => data2Position; set => data2Position = value; }
        public int Data1RowIndex { get => data1RowIndex; set => data1RowIndex = value; }
        public int Data2RowIndex { get => data2RowIndex; set => data2RowIndex = value; }
        public string SheetName { get => sheetName; set => sheetName = value; }
        public DataTable FLODt { get => floDt; set => floDt = value; }
    }

    public class CPipeDataMngr
    {
        private List<CPipeData> data;
        public CPipeDataMngr()
        {
            Data = new List<CPipeData>();
        }


        public List<CPipeData> Data { get => data; set => data = value; }


        public void Add(CPipeData data)
        {
            Data.Add(data);
        }

        
        
    }

}
