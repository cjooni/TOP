using DevExpress.Spreadsheet;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.Excel;
using TOP.lib;
using DevExpress.XtraWaitForm;

namespace TOP.Screen
{
    public partial class frmLoadPipeTool : TOP.Parent.PForm
    {
        string FileName;
        public frmLoadPipeTool()
        {
            InitializeComponent();
        }

        //Pipe Tool 데이터를 Load 한다.
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                XtraOpenFileDialog Opendlg = new XtraOpenFileDialog();

                Opendlg.Filter = "EXCEL 파일 (*.xlsx)|*.xlsx|모든파일(*.*)|*.*";


                if (Opendlg.ShowDialog() == DialogResult.OK)
                {
                    
                    splashScreenManager1.ShowWaitForm();
                    //ProgressPanel panel = CUtil.GetProgress("Data Loading", "EXCEL 파일을 읽는 중 입니다.");
                    //panel.Parent = this;
                    //this.Controls.Add(panel);
                    //panel.Show();
                    //panel.BringToFront();

                    string filename = Opendlg.FileName;

                    using (FileStream stream = new FileStream(filename, FileMode.Open))
                    {


                        //progressPanel1.Parent = this;
                        //this.Controls.Add(progressPanel1);

                        //progressPanel1.Show();
                        //progressPanel1.BringToFront();

                        ///EXCEL DATA를 Load 한다.
                        spread1.LoadDocument(stream, DocumentFormat.Xlsx);
                        FileName = filename;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }

        }


        private DataTable GetDataTable(Worksheet item, string range)
        {
            ExcelDataSource Eds = new ExcelDataSource();
            Eds.Name = item.Name;
            Eds.FileName = @FileName;
            ExcelWorksheetSettings worksheetsetting = new ExcelWorksheetSettings(Eds.Name, range);
            Eds.SourceOptions = new ExcelSourceOptions(worksheetsetting);

            Eds.SourceOptions.SkipEmptyRows = false;
            Eds.SourceOptions.UseFirstRowAsHeader = true;
            Eds.Fill();

            DataTable dt = ExcelDataSourceExtension.ToDataTable(Eds);
            dt.TableName = item.Name;

            return dt;
        }




        /// <summary>
        /// 막서 데이터로 변환한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            splashScreenManager1.SplashFormStartPosition = DevExpress.XtraSplashScreen.SplashFormStartPosition.Default;
            splashScreenManager1.ShowWaitForm();
            try
            {

            
                IWorkbook workbook = spread1.Document;


                CPipeDataMngr PipeMngr = new CPipeDataMngr();
            
                ///PipeTool을 처리하기 위한 필드값을 찾는다.
                ///
                int n = workbook.Worksheets.Count;
                foreach (Worksheet item in workbook.Worksheets)
                {
                    //sheet에 (H) 가 있으면 skip
                    if (item.Name.Contains("H") == true)
                    {
                        continue;
                    }
                    CPipeData Data = new CPipeData();
                    Data.SheetName = item.Name;
                    Data.Data1Position = "B3:AN3";
                    Data.Data1RowIndex = 2;

                    Data.Data3Position = "AQ3:AR3";
                    Data.Data3RowIndex = 2;
              

                    //Data2의 시작 위치를 찾아볼까
                    SearchOptions options = new SearchOptions();
                    options.SearchBy = SearchBy.Columns;
                    options.SearchIn = SearchIn.Values;
                    options.MatchEntireCellContents = true;

                    //item.Search("측점", options);
                    //worksheet의 유효 데이터 Row를 구한다.
                    int nRow = item.GetUsedRange().RowCount;


                    string strPos2;
                    string strPos1;
                    string strPos3;

                   // Data.Data3 = GetDataTable(item, Data.Data3Position);

                    IEnumerable<Cell> searchResult = item.Search("측점", options);
                    foreach (Cell cell in searchResult)
                    {
                        if (cell.ColumnIndex != 1)
                        {
                            continue;
                        }

                        strPos1 = string.Format("{0}{1}:{2}{3}", "B", 3, "AN", cell.RowIndex - 1);
                        strPos2 = string.Format("{0}{1}:{2}{3}", "B", cell.RowIndex + 1, "H", nRow -1);
                        // = string.Format("{0}{1}:{2}{3}", "AQ", 3, "AR", nRow - 1);
                        Data.Data2Position = strPos2;
                        Data.Data2RowIndex = cell.RowIndex;

                        Data.Data1 = GetDataTable(item, strPos1);
                        Data.Data2 = GetDataTable(item, strPos2);
                       // Data.Data3 = GetDataTable(item, strPos3);
                        Data.ManholeDt = GetManholeData1(Data.Data1);
                    }

                    //포장측점이 있는지 찾는다.
                    IEnumerable<Cell> searchResult2 = item.Search("포장측점", options);
                    foreach (Cell cell in searchResult2)
                    {
                
             
                        strPos3 = string.Format("{0}{1}:{2}{3}", "AQ", 3, "AR", nRow - 1);                
                        Data.Data3 = GetDataTable(item, strPos3);
                
                    }

                    MakeFLO(Data);
                    PipeMngr.Add(Data);

                }


                DataTable MaxerDt = PipeMngr.GetMaxerInputData();

                gridView1.PopulateColumns(MaxerDt);
                gridControl1.DataSource = MaxerDt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }

        }

        private DataTable GetManholeData1(DataTable data)
        {
            
            DataTable dt = data.Clone();
            dt.Columns.Add("F관경");
            dt.Columns.Add("T관경");

            DataColumn[] primarykey = new DataColumn[2];
            primarykey[0] = dt.Columns["누가거리"];
            primarykey[1] = dt.Columns["맨홀"];
         
            dt.PrimaryKey = primarykey;

            foreach (DataRow item in data.Rows)
            {
                if (item["맨홀"].ToString().Trim() == "")
                {
                    continue;
                }

                try
                {
                    DataRow dr = dt.NewRow();
                    dr.ItemArray = item.ItemArray;

                    //전단면과 후단면의 관경을 다를수도 있고 같을수도 있다
                    //일단 처음 넣을때는 관경을 동일하게 처리하고 
                    //중복이 발생했을 경우 후단면의 관경을 갱신 처리한다.
                    dr["F관경"] = item["관경"];
                    dr["T관경"] = item["관경"];
                    dt.Rows.Add(dr);
                }
                catch(ConstraintException ex)
                {
                    string filter;
                    filter = string.Format("누가거리='{0}' AND 맨홀='{1}'", item["누가거리"], item["맨홀"]);
                    DataRow[] drs = dt.Select(filter);
                    foreach (DataRow itemRow in drs)
                    {
                        itemRow["T관경"] = item["관경"]; //중복이 발생하면 후단면 관경을 T관경에 넣는다.
                    }
                    continue;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return null;
                }
                
              
                
            }

            return dt;
        }

        private void MakeFLO(CPipeData PipeData)
        {
            DataTable Dt = new DataTable();
            Dt.Columns.Add("FROM_LINE");
            Dt.Columns.Add("TO_LINE");
            Dt.Columns.Add("시작거리");
            Dt.Columns.Add("누가거리");
            Dt.Columns.Add("누가거리_차이"); 
            Dt.Columns.Add("DATA1"); //0.0000
            Dt.Columns.Add("DATA2"); //0.0000
            Dt.Columns.Add("F관저고"); //from의 관저고
            Dt.Columns.Add("T관저고"); //To의 관저고
            Dt.Columns.Add("DATA3"); //0.010
            Dt.Columns.Add("지반고"); //from의 지반고
            Dt.Columns.Add("하류지반고"); //To의 지반고
            Dt.Columns.Add("DATA4"); //0.010
            Dt.Columns.Add("관경"); //전, 후 단면이 있을경우 달라짐
            Dt.Columns.Add("지장물");
            DataTable data = PipeData.ManholeDt;


            for (int i = 0; i < data.Rows.Count; i++)
            {
               if (data.Rows.Count -1  == i)
                {
                    //제일 끝 라인은 처리안함
                    continue;
                }

                DataRow dr = Dt.NewRow();
                dr["FROM_LINE"] = data.Rows[i]["맨홀"];
                dr["TO_LINE"] = data.Rows[i + 1]["맨홀"];
                dr["시작거리"] = Convert.ToDouble(data.Rows[i]["누가거리"]);
                dr["누가거리"] = Convert.ToDouble(data.Rows[i + 1]["누가거리"]);
                dr["누가거리_차이"] = Convert.ToDouble(data.Rows[i + 1]["누가거리"]) - Convert.ToDouble( data.Rows[i]["누가거리"]);
                dr["DATA1"] = "0.0000";
                dr["DATA2"] = "0.65";
                dr["F관저고"] = data.Rows[i]["관저고"];
                dr["T관저고"] = data.Rows[i+1]["관저고"];
                dr["지반고"] = data.Rows[i]["지반고"];
                dr["하류지반고"] = data.Rows[i+1]["지반고"];
                if (data.Rows[i]["관경"] == data.Rows[i+1]["관경"])
                {
                    dr["관경"] = data.Rows[i]["관경"];
                }
                else 
                {
                    dr["관경"] = data.Rows[i]["T관경"];
                }
                
                dr["지장물"] = GetXData(PipeData, dr);
                dr["지장물"] = dr["지장물"] + GetGData(PipeData, dr);
                Dt.Rows.Add(dr);
            }

            PipeData.FLODt = Dt;
        }

        /// <summary>
        /// 지장물 정보를 찾는다.
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public string GetXData(CPipeData Data, DataRow Dr)
        {
            string xData = "";

            foreach (DataRow item in Data.Data2.Rows)
            {
                if(item["측점"].ToString().Trim() == "")
                {
                    continue;
                }
                string[] arr = item["측점"].ToString().Split('+');

                double spot = (Convert.ToDouble(arr[0])* 20) + Convert.ToDouble(arr[1]);

                double start = Convert.ToDouble(Dr["시작거리"]);
                double end = Convert.ToDouble(Dr["누가거리"]);

                if (start <= spot && end > spot)
                {
                    xData += string.Format("X={0},{1},{2} ", spot, item["INV"], Convert.ToDouble(item["SIZE"]) / 1000);
                }
            }

            return xData;
        }

        public string GetGData(CPipeData Data, DataRow Dr)
        {
            string gData = "";

            //포장정보가 없으면 skip
            if (Data.Data3 == null)
            {
                return "";
            }
            //포장 정보가 없으면 SKIP
            if (Data.Data3.Rows.Count <=0)
            {
                return "";
            }

            foreach (DataRow item in Data.Data3.Rows)
            {
                if (item["포장측점"].ToString().Trim() == "")
                {
                    continue;
                }
                string[] arr = item["포장측점"].ToString().Split('+');

                double spot = (Convert.ToDouble(arr[0]) * 20) + Convert.ToDouble(arr[1]);

                double start = Convert.ToDouble(Dr["시작거리"]);
                double end = Convert.ToDouble(Dr["누가거리"]);

                if (start <= spot && end > spot)
                {
                    gData += CMaxerSector.SetData(spot, Convert.ToDouble(Dr["하류지반고"]), item["포장구간"].ToString().ToUpper());
                }
            }
            return gData;
        }
    }
}
