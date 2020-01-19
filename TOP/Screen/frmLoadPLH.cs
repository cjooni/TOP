using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TOP.lib;
using DevExpress.DataAccess.Excel;
using DevExpress.Spreadsheet;

namespace TOP.Screen
{
    public partial class frmLoadPLH : TOP.Parent.PForm
    {
        public frmLoadPLH()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ///marshal 로 처리 하려 하였으나
            ///원래 PLH파일의 처리가 잘 못되어 있어 Marshal 처리 불가능
            String FileName;
            String Extension;
            String RLine;
           
            


            CPLHMngr PLHMngr = new CPLHMngr();
            



            XtraOpenFileDialog Opendlg;
            using (Opendlg = new XtraOpenFileDialog())
            {
                //Opendlg.Filter = "PLH 파일 (*.PLH)|*.PLD|모든파일(*.*)|*.*";
                Opendlg.Filter = "모든파일(*.*)|*.*";
                Opendlg.Multiselect = true;

                if (Opendlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (string strFileName in Opendlg.FileNames)
                    {
                        FileName = Path.GetFileName(strFileName);
                        Extension = Path.GetExtension(strFileName);
                        using (StreamReader SR = new StreamReader(strFileName, Encoding.Default, true))
                        {

                            if (Extension.ToUpper() == ".PLH" )
                            {
                                CTrans<_st_typePLH> Trans_PLH = new CTrans<_st_typePLH>();
                                CMakeDataTable<_st_typePLH> MakeTable = new CMakeDataTable<_st_typePLH>();


                                while ((RLine = SR.ReadLine()) != null)
                                {
                                    if (RLine.Substring(0, 2) != "NO")
                                    {
                                        continue;
                                    }

                                    //RLine = RLine.Replace('+', ' ');
                                    _st_typePLH st_typePLH = Trans_PLH.ByteToStruct(RLine);
                                    MakeTable.AddData(st_typePLH);
                                }

                                if (MakeTable.DATATABLE != null)
                                {
                                    DataTable dt = MakeTable.DATATABLE;

                                    CPLHData PLHData = new CPLHData();
                                    PLHData.FileName = Path.GetFileNameWithoutExtension(strFileName);
                                    PLHData.PLHData = dt;
                                    PLHMngr.AddPLHData(PLHData);

                                }
                            }
                            else if (Extension.ToUpper() == ".PLD")
                            {
                                CTrans<_st_typePLD> Trans_PLD = new CTrans<_st_typePLD>();
                                CMakeDataTable<_st_typePLD> MakeTablePLD = new CMakeDataTable<_st_typePLD>();

                                while ((RLine = SR.ReadLine()) != null)
                                {
                                    if (RLine.Contains("CROSS") == false)
                                    {
                                        continue;
                                    }


                                    //RLine = RLine.Replace('+', ' ');
                                    _st_typePLD st_typePLD = Trans_PLD.ByteToStruct(RLine);
                                    MakeTablePLD.AddData(st_typePLD);
                                }

                                if (MakeTablePLD.DATATABLE != null)
                                {
                                    DataTable dt = MakeTablePLD.DATATABLE;

                                    CPLHData PLHData = new CPLHData();
                                    PLHData.FileName = Path.GetFileNameWithoutExtension(strFileName);
                                    PLHData.PLDData = dt;
                                    PLHMngr.AddPLDData(PLHData);

                                }
                            }
                            
                        }
                     
                        
                    }

                }

                CPLHDataProc DataProc = new CPLHDataProc(PLHMngr);
                DataProc.MakePipeToolData();

                gridControl2.DataSource = PLHMngr.GetData();

                ExportToSpreadSheet(DataProc);





            }
        }

        /// <summary>
        /// 구조화된 내용을 Spread Sheet에 출력한다.
        /// </summary>
        /// <param name="Data"></param>
        private void ExportToSpreadSheet(CPLHDataProc Data)
        {
            
            

            //Spread1.Document.Worksheets.Add("xxxxx");

            IWorkbook workbook = Spread1.Document;
            workbook.Worksheets.Insert(0, "xxxxx");

            for (int i = 0; i < workbook.Worksheets.Count; i++)
            {
                if (workbook.Worksheets[i].Name != "xxxxx")
                {
                    Spread1.Document.Worksheets.Remove(workbook.Worksheets[i]);
                }
            }

            /////기존에 생성된 WorkSheet를 제거한다. 
            //foreach (Worksheet item in workbook.Worksheets)
            //{
            //    if (item.Name != "xxxxx")
            //    {
            //        Spread1.Document.Worksheets.Remove(item);
            //    }
            //}


            ///새로 생성한다.
            ///
            workbook.BeginUpdate();

            foreach ( CPipeToolData item in Data.PipeToolMngr.PipeToolDataList)
            {
                Worksheet sheet = Spread1.Document.Worksheets.Add(item.FileName);

                int nRowIndex = 2;
                int nCnt = 0;
                //PLH 컬럼 출력
                for (int i = 0; i < item.Data1.Columns.Count; i++)
                {
                    if (item.Data1.Columns[i].ColumnName == "manhole")
                    {
                        sheet.Cells[nRowIndex, i + 1].Value = "";
                    }
                    else
                    {
                        sheet.Cells[nRowIndex, i].Value = item.Data1.Columns[i].ColumnName;
                    }
                    
                    
                }

               

                nRowIndex++;
                //PLH DATA 출력
                for (int i = 0; i < item.Data1.Rows.Count; i++)
                {
                    for (int j = 0; j < item.Data1.Columns.Count; j++)
                    {
                        if (
                           item.Data1.Columns[j].ColumnName == "누가거리" ||
                           item.Data1.Columns[j].ColumnName == "지반고" ||
                           item.Data1.Columns[j].ColumnName == "관저고" ||
                           item.Data1.Columns[j].ColumnName == "관경" ||
                           item.Data1.Columns[j].ColumnName == "구배"
                           )
                        {
                          
                            sheet.Cells[nRowIndex + i, j].SetValue (Convert.ToDouble(item.Data1.Rows[i][j]));
                        }
                        else
                        {
                            sheet.Cells[nRowIndex + i, j].SetValue(item.Data1.Rows[i][j]);
                        }
                            
                    }

                    
                }

                nRowIndex += item.Data1.Rows.Count;
                nRowIndex++;


                //PLD Header 출력
                for (int i = 0; i < item.Data2.Columns.Count; i++)
                {
               
                    sheet.Cells[nRowIndex, i + 1].Value = item.Data2.Columns[i].ColumnName;
                    
                }
                nRowIndex++;

                for (int i = 0; i < item.Data2.Rows.Count; i++)
                {
                    for (int j = 0; j < item.Data2.Columns.Count; j++)
                    {
                        if (item.Data2.Columns[j].ColumnName == "측점")
                        {
                            if (item.Data2.Rows[i][j].ToString().Contains("+") )
                            {
                                sheet.Cells[nRowIndex + i, j + 1].SetValue(item.Data2.Rows[i][j]);
                            }
                            else
                            {
                                sheet.Cells[nRowIndex + i, j + 1].SetValue(item.Data2.Rows[i][j].ToString() + "  ");
                            }
                        }

                        if (
                            item.Data2.Columns[j].ColumnName == "INV"  ||
                            item.Data2.Columns[j].ColumnName == "SIZE" 
                            )
                        {
                            sheet.Cells[nRowIndex + i, j + 1].SetValue(Convert.ToDouble(item.Data2.Rows[i][j]));
                        }
                        else
                        {
                            sheet.Cells[nRowIndex + i, j + 1].SetValue(item.Data2.Rows[i][j]);
                        }
                        
                    }
                    
                }

            }
            workbook.EndUpdate();
            Spread1.Document.Worksheets.Remove(Spread1.Document.Worksheets["xxxxx"]);
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraOpenFileDialog Opendlg;
            XtraSaveFileDialog Savedlg;
            using (Savedlg = new XtraSaveFileDialog())
            {
                if (Savedlg.ShowDialog() == DialogResult.OK)
                {

                    Spread1.SaveDocument(Savedlg.FileName);
                }
            }
        }
    }
}
