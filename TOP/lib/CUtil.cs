﻿using DevExpress.DataAccess.Excel;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraWaitForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TOP.lib
{
    public static class ExcelDataSourceExtension
    {
        /// <summary>
        /// ExcelDataSource 를 데이터 테이블로 변환한다.
        /// </summary>
        /// <param name="excelDataSource"></param>
        /// <returns></returns>
        public static DataTable ToDataTable(ExcelDataSource excelDataSource)
        {
            IList list = ((IListSource)excelDataSource).GetList();
            DevExpress.DataAccess.Native.Excel.DataView dataView = (DevExpress.DataAccess.Native.Excel.DataView)list;
            List<PropertyDescriptor> props = dataView.Columns.ToList<PropertyDescriptor>();

            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (DevExpress.DataAccess.Native.Excel.ViewRow item in list)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        /// <summary>
        /// Excel 파일로부터 Excel Data를 추출한다.
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="item"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static ExcelDataSource GetExcelDataSoure(string FileName, Worksheet sheet, string range)
        {
            try
            {
                ExcelDataSource Eds = new ExcelDataSource();
                Eds.Name = sheet.Name;
                Eds.FileName = FileName;
                ExcelWorksheetSettings worksheetsetting = new ExcelWorksheetSettings(Eds.Name, range);
                Eds.SourceOptions = new ExcelSourceOptions(worksheetsetting);

                Eds.SourceOptions.SkipEmptyRows = true;
                Eds.SourceOptions.UseFirstRowAsHeader = true;
                Eds.Fill();

                return Eds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// EXCEL 데이터를 DataTable로 전환합니다.
        ///
        /// </summary>
        /// <param name="FileName">엑셀 파일명</param>
        /// <param name="sheet"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static DataTable ExcelToDataSource(string FileName, Worksheet sheet, string range)
        {
            try
            {
                ExcelDataSource Eds = GetExcelDataSoure(FileName, sheet, range);
                DataTable dt = ToDataTable(Eds);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// EXCEL sheet 에서 Serarch 옵션을 설정한다.
        /// </summary>
        /// <returns></returns>
        public static SearchOptions GetSearchOption()
        {
            SearchOptions options = new SearchOptions();
            options.SearchBy = SearchBy.Columns;
            options.SearchIn = SearchIn.Values;
            options.MatchEntireCellContents = true;

            return options;
        }

        /// <summary>
        /// Sheet 에서 키워드를 찾아 Cell 정보를 전달한다.
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static IEnumerable<Cell> FindCell(Worksheet sheet, string keyword)
        {
            IEnumerable<Cell> searchResult = sheet.Search(keyword, GetSearchOption());

            return searchResult;
        }
    }

    public static class CUtil
    {
        /// <summary>
        /// Enum Data를 DataTable로 만든다.
        /// DataTable dT = EnumToDataTable(typeof(ENUM_CURRENCY));
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static DataTable EnumToDataTable(Type enumType)
        {
            DataTable table = new DataTable();

            //Column that contains the Captions/Keys of Enum
            table.Columns.Add("명칭", typeof(string));
            //Get the type of ENUM for DataColumn
            table.Columns.Add("Id", Enum.GetUnderlyingType(enumType));
            //Add the items from the enum:
            foreach (string name in Enum.GetNames(enumType))
            {
                //Replace underscores with space from caption/key and add item to collection:
                table.Rows.Add(name.Replace('_', ' '), Enum.Parse(enumType, name));
            }

            return table;
        }

        public static DataTable GetTable(ITable result)
        {
            try
            {
                DataTable dt = new DataTable(result.Name);

                foreach (IColumn column in result.Columns)
                    dt.Columns.Add(column.Name, column.Type);
                foreach (IRow row in result)
                    dt.Rows.Add(row.ToArray());

                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<DataColumn> GetColumns(DataTable dt)
        {
            List<DataColumn> columns = new List<DataColumn>();

            foreach (DataColumn item in dt.Columns)
            {
                columns.Add(item);
            }

            return columns;
        }

        public static ProgressPanel GetProgress(string caption, string desc)
        {
            ProgressPanel progressPanel1 = new ProgressPanel();
            progressPanel1.Caption = "Loading";
            progressPanel1.Description = "Please wait...";
            progressPanel1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;

            progressPanel1.Top = 100;
            progressPanel1.Left = 100;

            return progressPanel1;

            //아래 항목은 호출하는 쪽에서 해줘야 함
            //progressPanel1.Parent = this;
            //this.Controls.Add(progressPanel1);

            //progressPanel1.Show();
            //progressPanel1.BringToFront();
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        }

        /// <summary>
        /// orig 데이터 Table 형태만 카피한 후 추가 Table의 컬럼을 추가한다.
        /// </summary>
        /// <param name="OrigDt"></param>
        /// <returns></returns>
        public static DataTable AddColumns(DataTable OrigDt, DataTable ExtDt)
        {
            DataTable OrigTmp = OrigDt.Clone();
            DataTable ExtTmp = ExtDt.Clone();

            foreach (DataColumn item in ExtDt.Columns)
            {
                OrigTmp.Columns.Add(item);
            }

            return OrigTmp;
        }

        public static string LoadExcel(string filename, SpreadsheetControl spreadsheet)
        {
            //SplashScreenManager ssManger = new SplashScreenManager();

            try
            {
                XtraOpenFileDialog Opendlg = new XtraOpenFileDialog();

                using (FileStream stream = new FileStream(filename, FileMode.Open))
                {
                    ///EXCEL DATA를 Load 한다.
                    spreadsheet.LoadDocument(stream, DocumentFormat.Xlsx);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // ssManger.CloseWaitForm();
            }

            return filename;
        }

        public static string OpenExcel()
        {
            string filename = "";
            try
            {
                XtraOpenFileDialog Opendlg = new XtraOpenFileDialog();

                Opendlg.Filter = "EXCEL 파일 (*.xlsx)|*.xlsx|모든파일(*.*)|*.*";

                if (Opendlg.ShowDialog() == DialogResult.OK)
                {
                    // ssManger.ShowWaitForm();
                    //ProgressPanel panel = CUtil.GetProgress("Data Loading", "EXCEL 파일을 읽는 중 입니다.");
                    //panel.Parent = this;
                    //this.Controls.Add(panel);
                    //panel.Show();
                    //panel.BringToFront();

                    filename = Opendlg.FileName;
                }

                return filename;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static string LoadExcel(SpreadsheetControl spreadsheet)
        {
            //SplashScreenManager ssManger = new SplashScreenManager();

            string filename = "";


            try
            {
                XtraOpenFileDialog Opendlg = new XtraOpenFileDialog();

                Opendlg.Filter = "EXCEL 파일 (*.xlsx)|*.xlsx|모든파일(*.*)|*.*";

                if (Opendlg.ShowDialog() == DialogResult.OK)
                {
                    // ssManger.ShowWaitForm();
                    //ProgressPanel panel = CUtil.GetProgress("Data Loading", "EXCEL 파일을 읽는 중 입니다.");
                    //panel.Parent = this;
                    //this.Controls.Add(panel);
                    //panel.Show();
                    //panel.BringToFront();

                    filename = Opendlg.FileName;

                    using (FileStream stream = new FileStream(filename, FileMode.Open))
                    {
                        //progressPanel1.Parent = this;
                        //this.Controls.Add(progressPanel1);

                        //progressPanel1.Show();
                        //progressPanel1.BringToFront();

                        ///EXCEL DATA를 Load 한다.
                        spreadsheet.LoadDocument(stream, DocumentFormat.Xlsx);
                        // spreadsheet.LoadDocument()
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // ssManger.CloseWaitForm();
            }

            return filename;
        }

        /// <summary>
        /// List 형태를 DataTable로 변환한다.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static DataTable LinqQueryToDataTable(IEnumerable<dynamic> v)
        {
            var firstRecord = v.FirstOrDefault();
            if (firstRecord == null)
            {
                return null;
            }

            PropertyInfo[] infos = firstRecord.GetType().GetProperties();

            DataTable table = new DataTable();

            foreach (var info in infos)
            {
                Type propType = info.PropertyType;

                if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    table.Columns.Add(info.Name, Nullable.GetUnderlyingType(propType));
                }
                else
                {
                    table.Columns.Add(info.Name, info.PropertyType);
                }
            }

            DataRow row;

            foreach (var record in v)
            {
                row = table.NewRow();
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    row[i] = infos[i].GetValue(record) != null ? infos[i].GetValue(record) : DBNull.Value;
                }
                table.Rows.Add(row);
            }

            table.AcceptChanges();

            return table;
        }

        /// <summary>
        /// EXCEL Header의 font를 설정한다.
        /// </summary>
        /// <param name="range"></param>
        /// <param name="font_name"></param>
        /// <param name="font_size"></param>
        public static void setSheetHeaderFormat(CellRange range, string font_name, int font_size)
        {
            Formatting rangeFormatting = range.BeginUpdateFormatting();
            rangeFormatting.Font.Name = font_name;
            rangeFormatting.Font.Color = Color.White;
            rangeFormatting.Font.Size = 10;
            rangeFormatting.Font.FontStyle = SpreadsheetFontStyle.Bold;

            rangeFormatting.Fill.BackgroundColor = Color.Green;

            rangeFormatting.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
            rangeFormatting.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;

            range.EndUpdateFormatting(rangeFormatting);
        }

        /// <summary>
        /// EXCEL Body의 Font를 설정한다.
        /// </summary>
        /// <param name="range"></param>
        /// <param name="font_name"></param>
        /// <param name="font_size"></param>
        public static void setSheetBodyFormat(CellRange range, string font_name, int font_size)
        {
            Formatting rangeFormatting = range.BeginUpdateFormatting();
            rangeFormatting.Font.Name = font_name;
            rangeFormatting.Font.Size = 9;

            range.EndUpdateFormatting(rangeFormatting);
        }

    }
}