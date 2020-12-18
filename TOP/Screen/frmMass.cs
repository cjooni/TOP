using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TOP.lib;

namespace TOP.Screen
{
    public partial class frmMass : TOP.Parent.PForm
    {
        CPipeDataMngr PipeMngr = new CPipeDataMngr();
        CMassDataMngr MassMngr = new CMassDataMngr();

        DataTable BaseTable;
        public frmMass()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DATA1 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string filename = "";

            splashScreenManager1.SplashFormStartPosition = DevExpress.XtraSplashScreen.SplashFormStartPosition.Default;


            string sheetname = "";

            try
            {
               

                filename = CUtil.LoadExcel(spread1);
                splashScreenManager1.ShowWaitForm();
                IWorkbook workbook = spread1.Document;


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

                        CPipeData Data = new CPipeData();
                        Data.SheetName = item.Name;
                        Data.Data1Position = "B3:AN3";
                        Data.Data1RowIndex = 2;

                        Data.Data3Position = "AQ3:AR3";
                        Data.Data3RowIndex = 2;

                        strPos1 = string.Format("{0}{1}:{2}{3}", "B", 3, "AN", cell.RowIndex - 1);
                        strPos3 = string.Format("{0}{1}:{2}{3}", "AT", 3, "AW", cell.RowIndex - 1);
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

                        Data.Data1 = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos1);
                        Data.Data2 = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos2);
                        DataTable extend = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos3);
                        SetExtend(Data.Data1, extend);
                        // Data.Data3 = GetDataTable(item, strPos3);
                        //Data.ManholeDt = GetManholeData1(Data.Data1);


                        PipeMngr.Add(Data);
                    }

                }

                int nCnt = PipeMngr.Data.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(sheetname + "::" + ex.Message);
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }
           
        }

        private void SetExtend(DataTable orig, DataTable ext)
        {

          
            foreach (DataColumn item in ext.Columns)
            {
                
                orig.Columns.Add(item.ColumnName, typeof(string));
                
            }

            int nCnt = orig.Rows.Count;
            

            for (int i = 0; i < nCnt; i++)
            {
                orig.Rows[i]["맨홀규격"] = ext.Rows[i]["맨홀규격"];
                orig.Rows[i]["굴착공법"] = ext.Rows[i]["굴착공법"];
                //orig.Rows[i]["Column3"] = ext.Rows[i]["Column3"];
                orig.Rows[i]["굴착장비"] = ext.Rows[i]["굴착장비"];
                orig.Rows[i]["포장종류"] = ext.Rows[i]["포장종류"];
            }

        }




        //DATA2 ADD
        private void simpleButton2_Click(object sender, EventArgs e)
        {

            string filename = "";

            splashScreenManager1.SplashFormStartPosition = DevExpress.XtraSplashScreen.SplashFormStartPosition.Default;
            

            try
            {
                filename = CUtil.LoadExcel(spread2);
                splashScreenManager1.ShowWaitForm();
                IWorkbook workbook = spread2.Document;


                foreach (Worksheet item in workbook.Worksheets)
                {
                    int nRow = item.GetUsedRange().RowCount;


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

                        CPipeData Data = new CPipeData();
                        Data.SheetName = item.Name;
                        Data.Data1Position = "B3:AN3";
                        Data.Data1RowIndex = 2;

                        Data.Data3Position = "AQ3:AR3";
                        Data.Data3RowIndex = 2;

                        strPos1 = string.Format("{0}{1}:{2}{3}", "B", 3, "AN", cell.RowIndex - 1);
                        strPos3 = string.Format("{0}{1}:{2}{3}", "AT", 3, "AW", cell.RowIndex - 1);

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

                        Data.Data1 = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos1);
                        Data.Data2 = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos2);
                        DataTable extend = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos3);
                        SetExtend(Data.Data1, extend);
                        // Data.Data3 = GetDataTable(item, strPos3);
                        //Data.ManholeDt = GetManholeData1(Data.Data1);


                        PipeMngr.Add(Data);
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {


            string filename = "";

            splashScreenManager1.SplashFormStartPosition = DevExpress.XtraSplashScreen.SplashFormStartPosition.Default;
            

            try
            {
                filename = CUtil.LoadExcel(spread3);

                IWorkbook workbook = spread3.Document;

                splashScreenManager1.ShowWaitForm();
                foreach (Worksheet item in workbook.Worksheets)
                {
                    int nRow = item.GetUsedRange().RowCount;


                    IEnumerable<Cell> searchResult = ExcelDataSourceExtension.FindCell(item, "NO");

                    string strPos2;
                    string strPos1;
                    string strPos3;

                    foreach (Cell cell in searchResult)
                    {
                        if (cell.ColumnIndex != 1)
                        {
                            continue;
                        }

                        CMassData Data = new CMassData();
                        Data.SheetName = item.Name;

                        string strPos;


                        strPos1 = string.Format("{0}{1}:{2}{3}", "B", 1, "T", nRow);

                        Data.Data = ExcelDataSourceExtension.ExcelToDataSource(filename, item, strPos1);
                        /*
                         * 토적 데이터가 측점으로 정렬이 안 되어 있음 
                         */
                        if(Data.SheetName == "DE")
                        {
                            string aaa = "aaaa";
                        }
                        DataTable sortTable = 토적정렬(Data.Data);
                        Data.Data = sortTable;

                        MassMngr.Add(Data);
                    }

                }

                int nCnt = MassMngr.Data.Count;

                MakeBaseData();
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

        private  DataTable 토적정렬 (DataTable data)
        {
            data.Columns.Add("누가거리", typeof(decimal));
            data.Columns.Add("전후", typeof(decimal));


            foreach (DataRow Dr in data.Rows)
            {
                string[] sss = GetPoint(Dr["NO"].ToString());

                decimal dist = (Convert.ToDecimal(sss[0]) * 20) + Convert.ToDecimal(sss[2]);
                Dr["누가거리"] = dist;


                if (sss[3].ToString().Trim() == "")
                {
                    Dr["전후"] = 1;

                }
                else if (sss[3].ToString().Trim() == "(전)")
                {
                    Dr["전후"] = 2;


                }
                else if (sss[3].ToString().Trim() == "(후)")
                {
                    Dr["전후"] = 3;
                }
            }
            data.DefaultView.Sort = "누가거리 DESC, 전후 DESC";
            return data.DefaultView.ToTable();
        }


        private void MakeBaseData()
        {
            BaseTable = CGetTableType.GtMassData();

            ///전체 pipe Data가 들어있음 
            foreach (CPipeData item in PipeMngr.Data)
            {
                InsertManhole(item.Data1);

                int nPipeCnt = item.Data1.Rows.Count;

                foreach (DataRow pipeRow in item.Data1.Rows)
                {
                    if (item.SheetName == "A")
                    {
                        string sss = "aaaa";
                    }

                    if (item.SheetName == "A1")
                    {
                        string sss = "aaaa";
                    }

                    CMassData massData = MassMngr.Data.Find(x => x.SheetName == item.SheetName);

                    if (massData == null)
                    {
                        continue;
                    }

                    //string strSearch = string.Format("{0}='{1}'", "지반고", pipeRow["지반고"]);
                    //DataRow[] searchRow = massData.Data.Select(strSearch);

                    
                    nPipeCnt += -1;
                    // massData.Rows[nPipeCnt];
                    //LINENAME NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부	
                    //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 구간


                    DataRow dr = BaseTable.NewRow();
                    dr["LINE"] = item.SheetName;

                    string sfilter = pipeRow["맨홀"].ToString().Substring(0, 3);

                    if (sfilter == "M1-" || sfilter == "M2-" || sfilter == "M3-" || sfilter == "M4-" ||
                        sfilter == "E1-" || sfilter == "E2-" || sfilter == "E3-" || sfilter == "E4-")
                    {
                        dr["LINENAME"] = pipeRow["맨홀"].ToString().Remove(0, 3);

                    }
                    else
                    {
                        dr["LINENAME"] = pipeRow["맨홀"];

                    }

                    dr["누가거리"] = pipeRow["누가거리"];
                    dr["NO"] = massData.Data.Rows[nPipeCnt]["NO"];
                    dr["지반고"] = massData.Data.Rows[nPipeCnt]["지반고"];
                    dr["관저고"] = massData.Data.Rows[nPipeCnt]["관저고"];
                    dr["계획고"] = massData.Data.Rows[nPipeCnt]["계획고"];
                    dr["육상(토사)"] = massData.Data.Rows[nPipeCnt]["육상(토사)"];
                    dr["육상(풍화암)"] = massData.Data.Rows[nPipeCnt]["육상(풍화암)"];
                    dr["육상(연암)"] = massData.Data.Rows[nPipeCnt]["육상(연암)"];
                    dr["수중(토사)"] = massData.Data.Rows[nPipeCnt]["수중(토사)"];
                    dr["수중(풍화암)"] = massData.Data.Rows[nPipeCnt]["수중(풍화암)"];
                    dr["수중(연암)"] = massData.Data.Rows[nPipeCnt]["수중(연암)"];
                    dr["관상부"] = massData.Data.Rows[nPipeCnt]["관상부"];
                    dr["관주위"] = massData.Data.Rows[nPipeCnt]["관주위"];

                    dr["ASP"] = massData.Data.Rows[nPipeCnt]["ASP"];
                    dr["CONC"] = massData.Data.Rows[nPipeCnt]["CONC"];
                    dr["덧씌우기"] = massData.Data.Rows[nPipeCnt]["덧씌우기"];
                    dr["보도블럭"] = massData.Data.Rows[nPipeCnt]["보도블럭"];
                    dr["모래부설"] = massData.Data.Rows[nPipeCnt]["모래부설"];
                    dr["보조기층"] = massData.Data.Rows[nPipeCnt]["보조기층"];
                    dr["동상방지층"] = massData.Data.Rows[nPipeCnt]["동상방지층"];
                    dr["구간"] = pipeRow["구간"];
                    dr["관경"] = pipeRow["관경"];
                    dr["맨홀규격"] = pipeRow["맨홀규격"];
                    dr["굴착공법"] = pipeRow["굴착공법"];
                    //dr["Column3"] = pipeRow["Column3"];
                    dr["굴착장비"] = pipeRow["굴착장비"];
                    dr["포장종류"] = pipeRow["포장종류"];


                    BaseTable.Rows.Add(dr);

                }
            }
        }

        /// <summary>
        /// 토적표 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton5_Click(object sender, EventArgs e)
        {

            PrintMass(BaseTable);

        }

        private DataTable InsertManhole(DataTable Data)
        {
            string manhole = "";
            foreach (DataRow item in Data.Select())
            {

                if (item["누가거리"].ToString().Trim() == "")
                {
                    Data.Rows.Remove(item);
                   // Data.AcceptChanges();
                    continue;
                }

                if (item["맨홀"].ToString().Trim() == "")
                {
                    item["맨홀"] = manhole;
                }
                
                manhole = item["맨홀"].ToString();


            }
            

            return Data;
        }


        /// <summary>
        /// 토적표를 출력한다.
        /// </summary>
        /// <param name="dt"></param>
        private void PrintMass(DataTable dt)
        {
            

            IWorkbook workbook = spread4.Document;
            
            Worksheet sheet = workbook.Worksheets[0];
            
            spread4.BeginUpdate();

            //LINENAME NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부	
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층


            int nIndex = 1;
            int nCol = 0;

            string nLine = "";


            //Header 출력
            sheet.Rows[0]["C"].SetValue("LINENAME");
            sheet.Rows[0]["D"].SetValue("No.");
            sheet.Rows[0]["I"].SetValue("누가거리");
            sheet.Rows[0]["J"].SetValue("거리");
            sheet.Rows[0]["K"].SetValue("육상(토사)");
            sheet.Rows[0]["M"].SetValue("수중(토사)");
            sheet.Rows[0]["W"].SetValue("관주위");
            sheet.Rows[0]["Y"].SetValue("관상부");
            sheet.Rows[0]["AA"].SetValue("모래부설");

            sheet.Rows[0]["AJ"].SetValue("ASP절단");
            sheet.Rows[0]["AK"].SetValue("ASP");
            sheet.Rows[0]["AM"].SetValue("보조기층");
            sheet.Rows[0]["AR"].SetValue("CONC");
            sheet.Rows[0]["AT"].SetValue("보조기층");

            foreach (DataRow Row in dt.Rows)
            {
                nCol = 0;

                if (nLine != Row["LINE"].ToString())
                {
                    nLine = Row["LINE"].ToString();

                    sheet.Rows[nIndex]["C"].SetValue(Row["LINE"].ToString() + " LINE");
                    nIndex++;
                    
                }
              
                nLine = Row["LINE"].ToString();
                //sheet.Cells[nIndex, nCol].SetValue(Row["LINE"].ToString());


                sheet.Rows[nIndex]["C"].SetValue(Row["LINENAME"].ToString());
                    
                string[] sss = GetPoint(Row["NO"].ToString());

                //측점 출력
                sheet.Rows[nIndex]["D"].SetValue("No.");
                sheet.Rows[nIndex]["E"].SetValue(Convert.ToDecimal(sss[0]));
                sheet.Rows[nIndex]["F"].SetValue(sss[1]);
               
                sheet.Rows[nIndex]["G"].SetValue(Convert.ToDecimal(sss[2]));
                sheet.Rows[nIndex]["H"].SetValue(sss[3]);

                sheet.Rows[nIndex]["I"].SetValue(Convert.ToDecimal(Row["누가거리"])); //누가거리 I
                
                if (Convert.ToDecimal(Row["누가거리"]) == 0)
                {
                    sheet.Rows[nIndex]["J"].SetValue(0); //거리
                }
                else
                {
                   
                    sheet.Rows[nIndex]["J"].Formula = String.Format("= I{0} - I{1}", nIndex+1 , nIndex);
                }
               

                sheet.Rows[nIndex]["K"].SetValue(Convert.ToDecimal(Row["육상(토사)"]));
                sheet.Rows[nIndex]["L"].Formula = String.Format("= ROUND((K{0}+K{1})/2*$J{2}, 2)", nIndex , nIndex+1, nIndex+1);  //ROUND((K4+K5)/2*$J5,2)

                sheet.Rows[nIndex]["M"].SetValue(Convert.ToDecimal(Row["수중(토사)"]));
                sheet.Rows[nIndex]["N"].Formula = String.Format("= ROUND((M{0}+M{1})/2*$J{2}, 2)", nIndex, nIndex+1, nIndex+1);  //ROUND((K4+K5)/2*$J5,2)
                sheet.Rows[nIndex]["W"].SetValue(Convert.ToDecimal(Row["관주위"]));
                sheet.Rows[nIndex]["X"].Formula = String.Format("= ROUND((W{0}+W{1})/2*$J{2}, 2)", nIndex, nIndex+1, nIndex + 1);  //ROUND((K4+K5)/2*$J5,2)
                sheet.Rows[nIndex]["Y"].SetValue(Convert.ToDecimal(Row["관상부"]));
                sheet.Rows[nIndex]["Z"].Formula = String.Format("= ROUND((Y{0}+Y{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);  //ROUND((K4+K5)/2*$J5,2)
                sheet.Rows[nIndex]["AA"].SetValue(Convert.ToDecimal(Row["모래부설"]));
                sheet.Rows[nIndex]["AB"].Formula = String.Format("= ROUND((AA{0}+AA{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);  //ROUND((K4+K5)/2*$J5,2)


               

                //ASP절단    
                sheet.Rows[nIndex]["AJ"].Formula = String.Format("= IF(AK{0} = 0, 0, $J{1} *2)", nIndex + 1, nIndex + 1); // = IF(AD5 = 0, 0,$J5 * 2)

                if (Row["ASP"].ToString().Trim() != "")
                {
                    //ASP 깨기 및 복구
                    if (Convert.ToDecimal(Row["ASP"]) > 0)
                    {
                        sheet.Rows[nIndex]["AK"].SetValue(Convert.ToDecimal(Row["ASP"])); // ROUND((K4+K5)/2*$J5,2)
                        sheet.Rows[nIndex]["AL"].Formula = String.Format("= ROUND((AK{0}+AK{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);

                        sheet.Rows[nIndex]["AM"].SetValue(Convert.ToDecimal(Row["보조기층"]));
                        sheet.Rows[nIndex]["AN"].Formula = String.Format("= ROUND((AM{0}+AM{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);
                    }
                }
                //conc
                sheet.Rows[nIndex]["AQ"].Formula = String.Format("= IF(AR{0} = 0, 0, $J{1} *2)", nIndex + 1, nIndex + 1); // = IF(AD5 = 0, 0,$J5 * 2)

                if (Row["CONC"].ToString().Trim() != "")
                {
                    if (Convert.ToDecimal(Row["CONC"]) > 0)
                    {
                        sheet.Rows[nIndex]["AR"].SetValue(Convert.ToDecimal(Row["CONC"])); // ROUND((K4+K5)/2*$J5,2)
                        sheet.Rows[nIndex]["AS"].Formula = String.Format("= ROUND((AR{0}+AR{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);

                        sheet.Rows[nIndex]["AT"].SetValue(Convert.ToDecimal(Row["보조기층"]));
                        sheet.Rows[nIndex]["AU"].Formula = String.Format("= ROUND((AT{0}+AT{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);
                    }
                }

                sheet.Rows[0]["BH"].SetValue("보도블럭");
                sheet.Rows[0]["BL"].SetValue("보조기층");
                sheet.Rows[0]["BN"].SetValue("덧씌우기");
                sheet.Rows[0]["BS"].SetValue("굴착장비");


                //보도블럭
                if (Row["보도블럭"].ToString().Trim() != "")
                {
                    if (Convert.ToDecimal(Row["보도블럭"]) > 0)
                    {
                        sheet.Rows[nIndex]["BH"].SetValue(Convert.ToDecimal(Row["보도블럭"])); // ROUND((K4+K5)/2*$J5,2)
                        sheet.Rows[nIndex]["BI"].Formula = String.Format("= ROUND((BH{0}+BH{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);
                        sheet.Rows[nIndex]["BJ"].Formula = String.Format("= BH{0}*0.04", nIndex);
                        sheet.Rows[nIndex]["BK"].Formula = String.Format("= ROUND((BJ{0}+BJ{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);


                        sheet.Rows[nIndex]["BL"].SetValue(Convert.ToDecimal(Row["보조기층"]));
                        sheet.Rows[nIndex]["BM"].Formula = String.Format("= ROUND((BL{0}+BL{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);
                    }
                }

                //덧씌우기
                if (Row["덧씌우기"].ToString().Trim() != "")
                {
                    sheet.Rows[nIndex]["BN"].SetValue(Convert.ToDecimal(Row["덧씌우기"])); // ROUND((K4+K5)/2*$J5,2)
                    sheet.Rows[nIndex]["BO"].Formula = String.Format("= ROUND((BN{0}+BN{1})/2*$J{2}, 2)", nIndex, nIndex + 1, nIndex + 1);
                }
                //장비
                //sheet.Rows[nIndex]["BS"].SetValue(Row["Column3"].ToString());
                sheet.Rows[nIndex]["BS"].SetValue(Row["굴착장비"].ToString());

                //sheet.Cells[nIndex, nCol++].SetValue(Row["지반고"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["관저고"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["계획고"].ToString());

                //sheet.Cells[nIndex, nCol++].SetValue(Row["육상(풍화암)"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["육상(연암)"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["수중(토사)"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["수중(풍화암)"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["수중(연암)"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["관상부"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["관주위"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["ASP"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["CONC"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["덧씌우기"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["보도블럭"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["모래부설"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["보조기층"].ToString());
                //sheet.Cells[nIndex, nCol++].SetValue(Row["동상방지층"].ToString());
                //sheet.Cells[nIndex, nCol++].Formula = String.Format("ROUND((D{0}+D{1})/2*$D{2},2)", nIndex, nIndex, nIndex);

                nIndex++;

              
            }
            spread4.EndUpdate();
        }

        private string[] GetPoint(string data)
        {
            string[] sss = data.Split('+');
            int npos = data.IndexOf('(');


            string[] sRet = new string[4];
            sRet[0] = sss[0];
            sRet[1] = "+";
            

            if (npos < 0)
            {
                sRet[2] = sss[1];
                sRet[3] = "";
            }
            else
            {
                sRet[2] = sss[1].Replace(data.Substring(npos, data.Length - npos), "");
                sRet[3] = data.Substring(npos, data.Length - npos);
            }


            return sRet;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sDlg = new SaveFileDialog())
                {
                    sDlg.Filter = "EXCEL file|*.xlsx";
                    sDlg.Title = "Save an 엑셀 File";

                    if (sDlg.ShowDialog() == DialogResult.OK)
                    {
                        spread4.SaveDocument(sDlg.FileName);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 간이 흙막이 연장조서 만들기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            DataTable gaTable = BaseTable.Clone();

           // DataRow[] TmpRow = BaseTable.Select("SUBSTRING(구간, 0, 2) = 'GA' ");

            foreach (DataRow Row in BaseTable.Rows)
            {
                if (Row["구간"].ToString().Substring(0, 2).ToUpper() != "GA")
                {
                    continue;
                }

                gaTable.ImportRow(Row);
            }

            Print2(gaTable);

          
        }


        /// <summary>
        /// 간이 흙막이 조서를 출력한다.
        /// </summary>
        /// <param name="dt"></param>
        private void Print2(DataTable dt)
        {


            IWorkbook workbook = spread5.Document;

            Worksheet sheet = workbook.Worksheets[0];

            spread5.BeginUpdate();

            //LINENAME NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부	
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 , 구간, 관경


            int nIndex = 1;
            int nCol = 0;

            string nLine = "";

            foreach (DataRow Row in dt.Rows)
            {
                nCol = 0;


                if (nLine != Row["LINE"].ToString())
                {
                    nLine = Row["LINE"].ToString();

                    sheet.Rows[nIndex]["A"].SetValue(Row["LINE"].ToString() + " LINE");
                    nIndex++;

                }

                nLine = Row["LINE"].ToString();
                //sheet.Cells[nIndex, nCol].SetValue(Row["LINE"].ToString());


                if (Row["구간"].ToString().Substring(0, 2).ToUpper() != "GA")
                {
                    continue;
                }


                sheet.Rows[nIndex]["A"].SetValue(Row["LINENAME"].ToString());

                string[] sss = GetPoint(Row["NO"].ToString());

                //측점 출력
                sheet.Rows[nIndex]["B"].SetValue(Convert.ToDecimal(Row["관경"]));

                sheet.Rows[nIndex]["C"].SetValue(Convert.ToDecimal(sss[0]));

                sheet.Rows[nIndex]["D"].SetValue(sss[1]);

                sheet.Rows[nIndex]["E"].SetValue(Convert.ToDecimal(sss[2]));
                sheet.Rows[nIndex]["F"].SetValue(sss[3]);

                sheet.Rows[nIndex]["G"].SetValue(Convert.ToDecimal(Row["누가거리"])); //누가거리 I

                ///후단면이면 구간거리를 0으로 처리
                if (sss[3].ToString() == "(후)" )
                {
                    sheet.Rows[nIndex]["H"].SetValue(0);
                }
                else
                {
                    sheet.Rows[nIndex]["H"].Formula = String.Format("= G{0} - G{1}", nIndex + 1, nIndex); //구간거리
                }
                

                sheet.Rows[nIndex]["I"].SetValue(Convert.ToDecimal(Row["지반고"])); //
                sheet.Rows[nIndex]["J"].SetValue(Convert.ToDecimal(Row["관저고"])); //I
                sheet.Rows[nIndex]["K"].Formula = String.Format("= I{0} - J{1}", nIndex + 1, nIndex+1); //H
                sheet.Rows[nIndex]["L"].Formula = String.Format("= K{0} +0.1", nIndex + 1); //H
                sheet.Rows[nIndex]["M"].Formula = String.Format("= H{0} *L{1}", nIndex + 1, nIndex + 1); //H

                //= IF(AND(B21 >= 150, B21 <= 200), 1.2, B21 / 1000 + 1)
                sheet.Rows[nIndex]["N"].Formula = String.Format("= IF(AND(B{0} >= 150, B{1} <= 200), 1.2, B{2} / 1000 + 1)", nIndex + 1, nIndex + 1, nIndex + 1);


                //갑자기 수식에 의한 계산이 참조 되지 않음 (동일 행 처리시)
                decimal iVal = Convert.ToDecimal(sheet.Rows[nIndex]["I"].Value.ToString());
                decimal jVal = Convert.ToDecimal(sheet.Rows[nIndex]["J"].Value.ToString());
                decimal LVal = iVal - jVal + Convert.ToDecimal(0.1);

                //=IF(AND(L21>4,S21="가시설"),"조절식간이흙막이",IF(S21="가시설","조립식간이흙막이",""))
                //string as1 = sheet.Rows[nIndex]["L"].Value.ToString();

                if ( LVal > 4)
                {
                    sheet.Rows[nIndex]["O"].SetValue("조절식간이흙막이");
                }
                else
                {
                    sheet.Rows[nIndex]["O"].SetValue("조립식간이흙막이");
                }


                //=IFERROR(IF(FIND("흙막이",O21)>=1,IF(L21<=3,"300형",IF(AND(L21>3,L21<=4),"400형",IF(AND(L21>4,L21<=5),"500형",IF(AND(L21>5,L21<=6),"600형",IF(AND(L21>6,L21<=7),"700형")))))),"")

                //string as2 = sheet.Rows[nIndex]["L"].Value.ToString();
                //decimal rrr = Convert.ToDecimal(as2);

                if (LVal <= 3)
                {
                    sheet.Rows[nIndex]["P"].SetValue("300형");
                }
                else if (LVal > 3 && LVal <= 4)
                {
                    sheet.Rows[nIndex]["P"].SetValue("400형");
                }
                else if (LVal > 4 && LVal <= 5)
                {
                    sheet.Rows[nIndex]["P"].SetValue("500형");
                }
                else if (LVal > 5 && LVal <= 6)
                {
                    sheet.Rows[nIndex]["P"].SetValue("600형");

                }
                else if (LVal > 6 && LVal <= 7)
                {
                    sheet.Rows[nIndex]["P"].SetValue("700형");

                }

                nIndex++;


            }
            spread5.EndUpdate();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sDlg = new SaveFileDialog())
                {
                    sDlg.Filter = "EXCEL file|*.xlsx";
                    sDlg.Title = "Save an 엑셀 File";

                    if (sDlg.ShowDialog() == DialogResult.OK)
                    {
                        spread5.SaveDocument(sDlg.FileName);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// 맨홀 조서를 출력한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            DataTable gaTable = BaseTable.Clone();

            // DataRow[] TmpRow = BaseTable.Select("SUBSTRING(구간, 0, 2) = 'GA' ");

            foreach (DataRow Row in BaseTable.Rows)
            {
                //맨홀규격이 없다면 맨홀 조서를 만들 피요 없다.
                if (Row["맨홀규격"].ToString().Trim() == "")
                {
                    continue;
                }

                gaTable.ImportRow(Row);
            }

            Print3(gaTable);

        }


        /// <summary>
        /// 맨호 조서를 출력한다.
        /// </summary>
        /// <param name="dt"></param>
        private void Print3(DataTable dt)
        {


            IWorkbook workbook = spread6.Document;

            Worksheet sheet = workbook.Worksheets[0];

            spread6.BeginUpdate();

            //LINENAME NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부	
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 , 구간, 관경


            int nIndex = 1;
            int nCol = 0;

            string nLine = "";

            foreach (DataRow Row in dt.Rows)
            {
                nCol = 0;


                sheet.Rows[nIndex]["B"].SetValue(Row["LINENAME"].ToString());

                sheet.Rows[nIndex]["C"].SetValue(Convert.ToDecimal(Row["지반고"])); //
                sheet.Rows[nIndex]["D"].SetValue(Convert.ToDecimal(Row["관저고"])); //I
                //=IF(E3=0,C3-D3,C3-E3+0.5)
                //= IF(E3 = 0, F3 - 0.2 - 0.2, F3 - 0.5)
                sheet.Rows[nIndex]["F"].Formula = String.Format("=IF(E{0}=0,C{1}-D{2},C{3}-E{4}+0.5)", nIndex + 1, nIndex + 1, nIndex + 1, nIndex + 1, nIndex + 1); //H
                sheet.Rows[nIndex]["G"].Formula = String.Format("=IF(E{0} = 0, F{1} - 0.2 - 0.2, F{2} - 0.5)", nIndex + 1, nIndex + 1, nIndex + 1); //H
                sheet.Rows[nIndex]["H"].Formula = String.Format("=F{0}+0.4", nIndex + 1); //H
                sheet.Rows[nIndex]["I"].SetValue ( Row["맨홀규격"].ToString());
                sheet.Rows[nIndex]["J"].SetValue ( Row["굴착공법"].ToString());
                //sheet.Rows[nIndex]["K"].SetValue ( Row["Column3"].ToString());  //굴착장비
                sheet.Rows[nIndex]["K"].SetValue( Row["굴착장비"].ToString());  //굴착장비
                sheet.Rows[nIndex]["L"].SetValue ( Row["포장종류"].ToString());


                nIndex++;


            }
            spread6.EndUpdate();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sDlg = new SaveFileDialog())
                {
                    sDlg.Filter = "EXCEL file|*.xlsx";
                    sDlg.Title = "Save an 엑셀 File";

                    if (sDlg.ShowDialog() == DialogResult.OK)
                    {
                        spread6.SaveDocument(sDlg.FileName);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 구조물공 맨홀조서를 만든다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton11_Click(object sender, EventArgs e)
        {
            DataTable gaTable = BaseTable.Clone();

            // DataRow[] TmpRow = BaseTable.Select("SUBSTRING(구간, 0, 2) = 'GA' ");

            foreach (DataRow Row in BaseTable.Rows)
            {
                //맨홀규격이 없다면 맨홀 조서를 만들 피요 없다.
                if (Row["맨홀규격"].ToString().Trim() == "")
                {
                    continue;
                }

                gaTable.ImportRow(Row);
            }

            Print4(gaTable);
        }

        private void Print4(DataTable dt)
        {


            IWorkbook workbook = spread7.Document;

            Worksheet sheet = workbook.Worksheets[0];

            spread7.BeginUpdate();

            //LINENAME NO	지반고	관저고	계획고	육상(토사)	육상(풍화암)	육상(연암)	수중(토사)	수중(풍화암)	수중(연암)	관상부	
            //관주위	ASP	CONC	덧씌우기	보도블럭	모래부설	보조기층	동상방지층 , 구간, 관경


            int nIndex = 1;
            int nCol = 0;

            string nLine = "";

            int nSeq = 0; //맨홀 순서
            string newLine = "";
            bool bNewLine = false;


            sheet.Rows[0]["E"].SetValue("맨홀번호");
            sheet.Rows[0]["G"].SetValue("맨홀높이");
            sheet.Rows[0]["H"].SetValue("내부높이");
            sheet.Rows[0]["I"].SetValue("규격");


            foreach (DataRow Row in dt.Rows)
            {
                nCol = 0;


                if (newLine != Row["LINE"].ToString())
                {

                    bNewLine = true;
                    nSeq = 1;
                    sheet.Rows[nIndex]["E"].SetValue(Row["LINE"].ToString());
                }
                else
                {
                    bNewLine = false;
                    nSeq++;
                    sheet.Rows[nIndex]["E"].SetValue("");
                }

                //새로운 라인이면
                newLine = Row["LINE"].ToString();

                
                sheet.Rows[nIndex]["F"].SetValue(nSeq);
                sheet.Rows[nIndex]["G"].SetValue(Convert.ToDecimal(Row["지반고"]) - Convert.ToDecimal(Row["관저고"]));
                sheet.Rows[nIndex]["I"].SetValue(GetManholeType(Row["맨홀규격"].ToString()));

                decimal nnn = 0;
                try
                {
                     nnn = Convert.ToDecimal(GetManholeType(Row["맨홀규격"].ToString()).Substring(0, 1));
                }
                catch (Exception ex)
                {

                    nnn = 0;
                }
                

                sheet.Rows[nIndex]["J"].SetValue(nnn);



                //sheet.Rows[nIndex]["C"].SetValue(Convert.ToDecimal(Row["지반고"])); //
                //sheet.Rows[nIndex]["D"].SetValue(Convert.ToDecimal(Row["관저고"])); //I
                ////=IF(E3=0,C3-D3,C3-E3+0.5)
                ////= IF(E3 = 0, F3 - 0.2 - 0.2, F3 - 0.5)
                //sheet.Rows[nIndex]["F"].Formula = String.Format("=IF(E{0}=0,C{1}-D{2},C{3}-E{4}+0.5)", nIndex + 1, nIndex + 1, nIndex + 1, nIndex + 1, nIndex + 1); //H
                //sheet.Rows[nIndex]["G"].Formula = String.Format("=IF(E{0} = 0, F{1} - 0.2 - 0.2, F{2} - 0.5)", nIndex + 1, nIndex + 1, nIndex + 1); //H
                //sheet.Rows[nIndex]["H"].Formula = String.Format("=F{0}+0.4", nIndex + 1); //H
                //sheet.Rows[nIndex]["I"].SetValue(Row["맨홀규격"].ToString());
                //sheet.Rows[nIndex]["J"].SetValue(Row["굴착공법"].ToString());
                //sheet.Rows[nIndex]["K"].SetValue(Row["Column3"].ToString());  //굴착장비
                //sheet.Rows[nIndex]["L"].SetValue(Row["포장종류"].ToString());


                nIndex++;


            }
            spread7.EndUpdate();
        }


        private string GetManholeType(string strType)
        {
            int spos = strType.IndexOf("(");

            strType = strType.Substring(spos, strType.Length - spos);
            strType = strType.Replace("(", "");
            strType = strType.Replace(")", "");
            return strType;
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sDlg = new SaveFileDialog())
                {
                    sDlg.Filter = "EXCEL file|*.xlsx";
                    sDlg.Title = "Save an 엑셀 File";

                    if (sDlg.ShowDialog() == DialogResult.OK)
                    {
                        spread7.SaveDocument(sDlg.FileName);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMass_Shown(object sender, EventArgs e)
        {
            tabbedControlGroup1.SelectedTabPageIndex = 0;
        }
    }
}
