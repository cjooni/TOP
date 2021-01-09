using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using System;
using System.Collections.Generic;
using System.Data;

namespace TOP.lib
{
    public class APipeData
    {
        /// <summary>
        /// PipeData
        /// </summary>

        private DataTable data1;//누가거리	지반고	관저고	관경	맨홀	TEXT1	TEXT2	구간	구배	INV	SIZE	라인명	지하수위	맨홀INVERT

        /// <summary>
        /// 지장물 TABLE
        /// </summary>
        private DataTable data2;//측점	INV	SIZE	TEXT	BoxT1	BoxT2	BoxT3

        private DataTable manholeDt;

        private string data1Position;
        private string data2Position;
        private string data3Position;
        private int data1RowIndex;
        private int data2RowIndex;
        private int data3RowIndex;
        private string sheetName; //LINE NAME
        private string pipe_type; // 관종

        public APipeData()
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
        public string Pipe_type { get => pipe_type; set => pipe_type = value; }
    }

    /// <summary>
    /// PipeTool 출력 데이터를 관리하는 매니져
    /// </summary>
    public class APipeDataMngr
    {
        private List<APipeData> data;
        public SpreadsheetControl MainSheet;
        public DataSet MainDataSet;

        public APipeDataMngr()
        {
            Data = new List<APipeData>();
            //MainSheet = new SpreadsheetControl();
            MainDataSet = new DataSet();
        }

        private DataTable 맨홀구간정보1;

        public List<APipeData> Data { get => data; set => data = value; }

        public DataTable 맨홀구간정보 { get => 맨홀구간정보1; set => 맨홀구간정보1 = value; }

        public void Add(APipeData data)
        {
            Data.Add(data);
        }

        public void LoadXmlData()
        {
        }

        public void LoadPipeData()
        {
            string filename = "";

            //splashScreenManager1.SplashFormStartPosition = DevExpress.XtraSplashScreen.SplashFormStartPosition.Default;

            string sheetname = "";

            ///엑셀을 불러와 봅시다.
            try
            {
                filename = CUtil.LoadExcel(MainSheet);
                //splashScreenManager1.ShowWaitForm();
                IWorkbook workbook = MainSheet.Document;

                //불러온 EXCEL을 Data화 해봅니다.
                foreach (Worksheet item in workbook.Worksheets)
                {
                    int nRow = item.GetUsedRange().RowCount;
                    sheetname = item.Name;

                    IEnumerable<Cell> searchResult = ExcelDataSourceExtension.FindCell(item, "측점");

                    string strPos2;
                    string strPos1;
                    string strPos3;

                    foreach (Cell cell in searchResult)
                    {
                        if (cell.ColumnIndex != 1)
                        {
                            continue;
                        }

                        //PIPE Data를 구성합니다.

                        APipeData Data = new APipeData();
                        Data.SheetName = item.Name;
                        Data.Pipe_type = item.GetCellValue(8, 1).ToString(); //관종 설정
                        Data.Data1Position = "B3:AN3";
                        Data.Data1RowIndex = 2;

                        strPos1 = string.Format("{0}{1}:{2}{3}", "B", 3, "AN", cell.RowIndex - 1);

                        if (nRow == cell.RowIndex + 1)
                        {
                            strPos2 = string.Format("{0}{1}:{2}{3}", "B", cell.RowIndex + 1, "H", nRow);
                        }
                        else
                        {
                            strPos2 = string.Format("{0}{1}:{2}{3}", "B", cell.RowIndex + 1, "H", nRow - 1);
                        }

                        Data.Data2Position = strPos2;
                        Data.Data2RowIndex = cell.RowIndex;

                        Data.Data1 = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos1);
                        Data.Data2 = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos2);

                        ///데이터 1이 확장되기 전에 Data0에 copy 한다.
                        SetExtend(Data.Data1);
                        // Data.Data3 = GetDataTable(item, strPos3);
                        //Data.ManholeDt = GetManholeData1(Data.Data1);

                        Add(Data);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(sheetname + "::" + ex.Message);
            }
            finally
            {
                // splashScreenManager1.CloseWaitForm();
            }
        }

        /// <summary>
        /// 포장 측점과, 포장명을 기존 파이툴 생성 데이터에 추가해요
        /// </summary>
        /// <param name="orig"></param>
        /// <param name="ext"></param>
        private void SetExtend(DataTable orig)
        {
            DataTable dt_tmp = new DataTable();
            dt_tmp.Columns.Add("맨홀규격", typeof(string));
            dt_tmp.Columns.Add("굴착공법", typeof(string));
            dt_tmp.Columns.Add("굴착장비", typeof(string));
            dt_tmp.Columns.Add("포장종류", typeof(string));

            foreach (DataColumn item in dt_tmp.Columns)
            {
                orig.Columns.Add(item.ColumnName, typeof(string));
            }

            int nCnt = orig.Rows.Count;

            foreach (DataRow item in orig.Rows)
            {
                CData포장 data포장 = CDataMngr.Get포장정보(item["구간"].ToString());

                item["굴착공법"] = data포장.굴착공법;
                item["포장종류"] = data포장.포장종류;
            }
        }
    }
}