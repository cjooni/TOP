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
        private DataTable data3; //포장 측점, 포장구간

        private DataTable manholeDt;
        private DataTable floDt;

        private string data1Position;
        private string data2Position;
        private string data3Position;
        private int data1RowIndex;
        private int data2RowIndex;
        private int data3RowIndex;
        private string sheetName;


        public CPipeData()
        {

        }


        public DataTable Data1 { get => data1; set => data1 = value; }
        public DataTable Data2 { get => data2; set => data2 = value; }
        public DataTable Data3 { get => data3; set => data3 = value; }
        public DataTable ManholeDt { get => manholeDt; set => manholeDt = value; }

        public string Data1Position { get => data1Position; set => data1Position = value; }
        public string Data2Position { get => data2Position; set => data2Position = value; }
        public int Data1RowIndex { get => data1RowIndex; set => data1RowIndex = value; }
        public int Data2RowIndex { get => data2RowIndex; set => data2RowIndex = value; }
        public string SheetName { get => sheetName; set => sheetName = value; }
        public DataTable FLODt { get => floDt; set => floDt = value; }
        public string Data3Position { get => data3Position; set => data3Position = value; }
        public int Data3RowIndex { get => data3RowIndex; set => data3RowIndex = value; }
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

        public DataTable GetMaxerInputData()
        {
            if (Data[0].FLODt == null)
            {
                return null;
            }
            else if (Data[0].FLODt.Rows.Count <= 0)
            {
                return null;
            }
            else if (Data.Count == 0)
            {
                return null;
            }

            DataTable Dt = Data[0].FLODt.Clone();

            foreach (CPipeData item in Data)
            {
                foreach (DataRow Dr in item.FLODt.Rows)
                {
                    DataRow dr2 = Dt.NewRow();
                    dr2.ItemArray = Dr.ItemArray;
                    Dt.Rows.Add(dr2);
                }
            }

            return Dt;
        }
        
        
    }

}
