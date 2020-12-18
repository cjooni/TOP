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
using System.Linq;

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


        /// <summary>
        /// Excel Sheet의 데이터를 DataTable로 변환한다.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="range"></param>
        /// <returns></returns>
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
            String sheetName = "";
            try
            {

            
                IWorkbook workbook = spread1.Document;


                CPipeDataMngr PipeMngr = new CPipeDataMngr();
            
                ///PipeTool을 처리하기 위한 필드값을 찾는다.
                ///
                int n = workbook.Worksheets.Count;
                foreach (Worksheet item in workbook.Worksheets)
                {
                    sheetName = item.Name;
                    //sheet에 (H) 가 있으면 skip
                    if (item.Name.Contains("H") == true)
                    {
                        continue;
                    }

                    if (item.Name.Contains("Sheet1") == true)
                    {
                        continue;
                    }


                    ///파이프 툴의 출력 Field를 관리하는 Range를 지정
                    ///
                    CPipeData Data = new CPipeData();
                    Data.SheetName = item.Name;
                    Data.Data1Position = "B3:AN3";
                    Data.Data1RowIndex = 2;

                    Data.Data3Position = "AQ3:AR3";
                    Data.Data3RowIndex = 2;
              

                    //Data2 Search 하기 위한 옵션 설정 
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
                    //Sheet의 Data 중 "측점"의 위치를 찾아 Data 범위값을 설정한다.
                    foreach (Cell cell in searchResult)
                    {
                        if (cell.ColumnIndex != 1)
                        {
                            continue;
                        }
                      
                        ///기본 Pipe 정보는 B3:AN [측점이 관측된 RowIndex -1]
                        strPos1 = string.Format("{0}{1}:{2}{3}", "B", 3, "AN", cell.RowIndex - 1);

                        //전체 Row와 측점이 관측된 위치가 같다면 측점 이후 데이터가 없어용 
                        if (nRow == cell.RowIndex + 1)
                        {                            
                            strPos2 = string.Format("{0}{1}:{2}{3}", "B", cell.RowIndex + 1, "H", nRow);
                        }
                        else
                        {
                            strPos2 = string.Format("{0}{1}:{2}{3}", "B", cell.RowIndex + 1, "H", nRow - 1);
                        }
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

                    //막서 데이터로 변환을 해봅시다.
                    //Data 는 Sheet의 통합정보
                    MakeFLO(Data);
                    PipeMngr.Add(Data);
                }

                DataTable MaxerDt = PipeMngr.GetMaxerInputData();

                adGridView1.PopulateColumns(MaxerDt);
                gridControl1.DataSource = MaxerDt;

               
                ///TreeData를 만들어보자 
               // MakeTreeData(MaxerDt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(sheetName);
                
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }

            

        }

        /// <summary>
        /// 생성된 Maxer 데이터로 Tree를 만들어보자 
        /// </summary>
        /// <returns></returns>
        private DataTable MakeTreeData(DataTable maxer_dt)
        {
            try
            {

                DataTable tree_dt = new DataTable();
                tree_dt.Columns.Add("PARENT", typeof(string));
                tree_dt.Columns.Add("KEY", typeof(string));
                tree_dt.Columns.Add("FROM_LINE", typeof(string));
                tree_dt.Columns.Add("TO_LINE", typeof(string));


                

                //from line 쪽을 구한다. 
                var qryFromLine = (from d in maxer_dt.AsEnumerable()
                           select new
                           {
                               FROM_LINE = d.Field<string>("FROM_LINE")
                           }).Distinct();

                DataTable from_dt = CUtil.LinqQueryToDataTable(qryFromLine);

                
                //to line 쪽을 구한다.
                var qryToLine = (from d in maxer_dt.AsEnumerable()
                            select new
                            {
                                TO_LINE = d.Field<string>("TO_LINE")
                            }).Distinct();

                DataTable to_dt = CUtil.LinqQueryToDataTable(qryToLine);

                //from_dt 쪽에 있고 To_dt쪽에도 있다면 root 누드에 기입할 필요가 없다.
                foreach (DataRow item in to_dt.Rows)
                {

                    string expression = string.Format("FROM_LINE = '{0}'", item["TO_LINE"].ToString());
                 
                    DataRow[]  del_rows = from_dt.Select(expression);

                    foreach (DataRow  del_item in del_rows)
                    {
                        from_dt.Rows.Remove(del_item);
                    }
                }
                /// 요기까지 오면 from_dt에는 순수하게 root 노드에 연결되야 하는 line만 존재하게 됨 

                foreach (DataRow item in maxer_dt.Rows)
                {
                    //string expression = string.Format("FROM_LINE = '{0}'", item["FROM_LINE"].ToString());

                    //from_dt.Select(expression);

                    tree_dt.Rows.Add(item["FROM_LINE"], item["TO_LINE"].ToString().Trim(), item["FROM_LINE"], item["TO_LINE"].ToString().Trim());
                }

                treeList1.ParentFieldName = "PARENT";
                treeList1.KeyFieldName = "KEY";
                treeList1.DataSource = tree_dt;

                treeList1.PopulateColumns();


                return tree_dt;
            }
            catch (Exception ex)
            {
                throw ex;
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

        /// <summary>
        /// Pipe Tool  정보를 Maxer format으로 변환한다.
        /// </summary>
        /// <param name="PipeData"></param>
        private void MakeFLO(CPipeData PipeData)
        {

            //막서 데이터포 변환하기 위한 Table 생성
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

        /// <summary>
        /// 포장 정보를 찾는다.
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Dr"></param>
        /// <returns></returns>
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


        /// <summary>
        /// 파일로 저장한다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sDlg = new SaveFileDialog())
                {
                    sDlg.Filter = "FLO file|*.FLO";
                    sDlg.Title = "Save an FLO File";

                    if (sDlg.ShowDialog() == DialogResult.OK)
                    {
                        SaveFile(sDlg.FileName);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
               
            // gridControl1.ExportToText()
        }

        private void SaveFile(string FileName)
        {

            try
            {
                DataTable dt = (DataTable)gridControl1.DataSource;

                if (dt == null)
                {
                    MessageBox.Show("저장할 데이터가 없습니다.");
                    return;
                }

                string strLine;

                List<string> strData = new List<string>();

                foreach (DataRow item in dt.Rows)
                {
                    strLine = "";
                    string strTmp = "";
                    strLine += item["FROM_LINE"].ToString().Trim();
                    strLine += " ";
                    strLine += item["TO_LINE"].ToString().Trim();
                    strLine += " ";
                    strLine += strTmp.ToString().PadRight(9, ' ');
                    strLine += " ";
                    strLine += string.Format("{0:F1}", Convert.ToDouble(item["누가거리_차이"].ToString().Trim())).PadLeft(4, ' ');
                    strLine += " ";
                    strLine += item["DATA1"].ToString().Trim().PadLeft(8);
                    strLine += " ";
                    strLine += item["DATA2"].ToString().Trim().PadLeft(4);
                    strLine += " ";
                    strLine += string.Format("{0:F2}", Convert.ToDouble(item["F관저고"].ToString().Trim())).PadLeft(7, ' ');
                    strLine += " ";
                    strLine += string.Format("{0:F2}", Convert.ToDouble(item["T관저고"].ToString().Trim())).PadLeft(6, ' ');
                    strLine += " ";

                    strTmp = " ";
                    strLine += strTmp.ToString().PadRight(6, ' ');
                    strLine += " ";
                    strLine += string.Format("{0:F2}", Convert.ToDouble(item["지반고"].ToString().Trim())).PadLeft(6, ' ');
                    strLine += " ";
                    strTmp = " ";
                    strLine += strTmp.PadRight(18, ' ');
                    strLine += "0";
                    strLine += '\t';
                    strLine += item["관경"].ToString().PadLeft(4, ' ');
                    strLine += " ";
                    strLine += item["지장물"].ToString();

                    strData.Add(strLine);


                }

                // Stream st = new Stream();

                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    foreach (string item in strData)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
          
        }
    }
}
