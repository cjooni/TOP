using DevExpress.DataAccess.Sql;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TOP.lib;

namespace TOP.Screen
{
    public partial class frmInput : TOP.Parent.PForm
    {
        private CTopsData TopsData;
        public CPrjInfo PrjInfo;

        /// <summary>
        /// 굴착장비
        /// </summary>
        private RepositoryItemGridLookUpEdit repLookUp;

        /// <summary>
        /// 맨홀규격
        /// </summary>
        private RepositoryItemGridLookUpEdit repLookUp2;

        public frmInput()
        {
            InitializeComponent();

            PrjInfo = new CPrjInfo();
            InitControl();
        }

        private void InitControl()
        {
            ///굴착장비 Data Load
            repLookUp = new RepositoryItemGridLookUpEdit();
            repLookUp.DisplayMember = "cd_nm";
            repLookUp.ValueMember = "cd_nm";
            repLookUp.NullText = "";
            repLookUp.KeyMember = "cd";
            repLookUp.DataSource = Qry_굴착장비();
            gridControl1.RepositoryItems.Add(repLookUp);

            //
            repLookUp2 = new RepositoryItemGridLookUpEdit();
            repLookUp2.DisplayMember = "cd_nm";
            repLookUp2.ValueMember = "cd";
            repLookUp2.NullText = "";
            repLookUp2.KeyMember = "cd";
            repLookUp2.DataSource = Qry_맨홀();
            //repLookUp2.DataSource = CGetTableType.Get맨홀규격();
            gridControl1.RepositoryItems.Add(repLookUp2);
        }

        /// <summary>
        /// pipeTOOL 데이터를 LOAD 한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                DataRow dr = gridView토적표.GetFocusedDataRow();

                //DataTable dt = TopsData.MainData.Tables[dr[CGetTableType.col_SHEET_NAME].ToString()];

                var qry = from a in TopsData.MainData.Tables[CGetTableType.tbl_PIPE_TOOL_INPUT].AsEnumerable()
                          where a.Field<string>(CGetTableType.col_LINENAME) == dr[CGetTableType.col_SHEET_NAME].ToString()
                          select a;

                DataTable dt = qry.CopyToDataTable();
                //DataTable dt = CUtil.LinqQueryToDataTable(qry.ToList());

                /////Sheet Name 만 추출하여 Table 화함
                //APipeData data = (APipeData)(from a in PipeDataMngr.Data
                //                             where a.SheetName == dr["SheetName"].ToString()
                //                             select a).Single();

                //APipeData pipedata = data;
                //DataTable dt = pipedata.Data1;

                //DataTable tmp_dt = dt.Clone();

                gridControl1.DataSource = dt;

                /////gridview의 Option 설정
                /// 요걸풀면 repository가 동작 안함
                //gridView1.OptionsBehavior.Editable = false;

                gridView1.Columns["굴착장비"].OptionsColumn.AllowEdit = true;
                gridView1.Columns["굴착장비"].ColumnEdit = repLookUp;

                /////gridview의 Option 설정
                gridView1.Columns["맨홀규격"].OptionsColumn.AllowEdit = true;
                gridView1.Columns["맨홀규격"].ColumnEdit = repLookUp2;

                ////////////////////////////////////////////////////
                ///토적데이터
                ///

                var qry2 = from a in TopsData.MainData.Tables[CGetTableType.tbl_토적표_INPUT].AsEnumerable()
                           where a.Field<string>(CGetTableType.col_LINENAME) == dr[CGetTableType.col_SHEET_NAME].ToString()
                           select a;

                DataTable dt2 = qry2.CopyToDataTable();
                gridControl3.DataSource = dt2;
            }
            catch (ArgumentNullException ex)
            {
                
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }


        /// <summary>
        /// 파이프 툴 데이터를 로드한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPipeToolLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string filename = "";

            if (TopsData != null)
            {
                TopsData = null;
            }

            try
            {
                filename = CUtil.OpenExcel();
                splashScreenManager1.ShowWaitForm();

                TopsData = new CTopsData();
                TopsData.LoadFromPipeTool(filename);

                QrySheetInfo();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();

            }
        }


        /// <summary>
        /// 토적 데이터를 로드한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMassDataLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string filename = "";
            try
            {

                filename = CUtil.OpenExcel();

                splashScreenManager1.ShowWaitForm();

                TopsData.LoadFrom토적Data(filename);

                Set토적Data();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();

            }

        }

        /// <summary>
        /// SHEET INFO 정보를 조회한다. 
        /// </summary>
        private void QrySheetInfo()
        {
            var sql = from a in TopsData.MainData.Tables[CGetTableType.tbl_SHEET_INFO].AsEnumerable()
                      select new
                      {
                          SHEET_NAME = a.Field<string>(CGetTableType.col_SHEET_NAME).ToString()
                      };

            DataTable dt = CUtil.LinqQueryToDataTable(sql);

            gridView토적표.OptionsBehavior.Editable = false;
            gridControl2.DataSource = dt;
        }

    

        private void Set토적Data()
        {
            grid토적표.DataSource = TopsData.MainData.Tables["토적표기초데이터"];
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Xml.Serialization.XmlSerializer writer =
           new System.Xml.Serialization.XmlSerializer(typeof(DataSet));

            var path = @"D:\test.xml";// Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, TopsData.MainData);
            file.Close();
        }

        /// <summary>
        /// 일괄출력
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AllPrint();
        }

        public void AllPrint()
        {
            try
            {
                

                TopsData.MakeInterData();
                
                
                TopsData.Print토적표(spread1.Document);
                TopsData.Print맨홀조서(spread1.Document);
                TopsData.Print간이흙막이연장조서(spread1.Document);
                TopsData.Proc오수관(spread1.Document);
                //TopsData.Proc오수관실연장조서(spread1.Document);
                //TopsData.Proc오수관접합및절단조서(spread1.Document);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void frmInput_Load(object sender, EventArgs e)
        {

            tabbedControlGroup1.SelectedTabPage = layoutControlGroup5;
            tabbedControlGroup2.SelectedTabPage = layoutControlGroup2;
            tabbedControlGroup5.SelectedTabPage = layoutControlGroup1;


            SetTree();

            
        }


        private void SetTree()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("P_KEY", typeof(string));
            dt.Columns.Add("CAPTION", typeof(string));
            dt.Columns.Add("NAME", typeof(string));

            dt.Columns.Add("VALUE_TP", typeof(string));
            dt.Columns.Add("VALUE", typeof(double));



            dt.Rows.Add("", "구조물", "구조물", 0);

            dt.Rows.Add("구조물", "1호맨홀", "1호맨홀", "0", 0);
            dt.Rows.Add("1호맨홀", "맨홀규격", "1호맨홀맨홀규격", "1", 0.9);
            dt.Rows.Add("1호맨홀", "상부슬라브", "1호맨홀상부슬라브", "1", 0.2);
            dt.Rows.Add("1호맨홀", "하브슬라브", "1호맨홀하브슬라브", "1", 0.2);
            dt.Rows.Add("1호맨홀", "벽체두께", "1호맨홀벽체두께", "1", 0.2);
            dt.Rows.Add("1호맨홀", "인버트", "1호맨홀인버트", "1", 0.1);
            dt.Rows.Add("1호맨홀", "맨홀뚜껑", "1호맨홀맨홀뚜껑", "1", 1);
            dt.Rows.Add("1호맨홀", "터파기여유폭", "1호맨홀터파기여유폭", "1", 0.4);

            dt.Rows.Add("구조물", "2호맨홀", "2호맨홀", "0", 0);
            dt.Rows.Add("2호맨홀", "맨홀규격", "2호맨홀맨홀규격", "1", 1.2);
            dt.Rows.Add("2호맨홀", "상부슬라브", "2호맨홀상부슬라브", "1", 0.2);
            dt.Rows.Add("2호맨홀", "하브슬라브", "2호맨홀하브슬라브", "1", 0.2);
            dt.Rows.Add("2호맨홀", "벽체두께", "2호맨홀벽체두께", "1", 0.2);
            dt.Rows.Add("2호맨홀", "버림높이", "2호맨홀버림높이", "1", 0);
            dt.Rows.Add("2호맨홀", "잡석높이", "2호맨홀잡석높이", "1", 0.1);
            dt.Rows.Add("2호맨홀", "구배", "2호맨홀구배", "1", 0.3);


            dt.Rows.Add("구조물", "3호맨홀", "3호맨홀", "0", 0);
            dt.Rows.Add("3호맨홀", "맨홀규격", "3호맨홀맨홀규격", "1", 1.5);
            dt.Rows.Add("3호맨홀", "상부슬라브", "3호맨홀상부슬라브", "1", 0.2);
            dt.Rows.Add("3호맨홀", "하브슬라브", "3호맨홀하브슬라브", "1", 0.2);
            dt.Rows.Add("3호맨홀", "벽체두께", "3호맨홀벽체두께", "1", 0.2);
            dt.Rows.Add("3호맨홀", "버림폭", "3호맨홀버림폭", "1", 0);
            dt.Rows.Add("3호맨홀", "토피", "3호맨홀토피", "1", 0.2);


            dt.Rows.Add("", "관로", "관로", 0);
            dt.Rows.Add("관로", "관기초", "관로관기초", "1", 0.1);
            dt.Rows.Add("관로", "관여유폭", "관로관여유폭", "1", 0.2);
            dt.Rows.Add("관로", "관로구배", "관로관로구배", "1", 0.3);
            dt.Rows.Add("관로", "가시설폭", "관로가시설폭", "1", 1.4);


            dt.Rows.Add("", "포장", "포장", 0);
            dt.Rows.Add("포장", "ASP포장", "ASP포장", "0", 0);
            dt.Rows.Add("ASP포장", "표층", "ASP포장표층", "1", 0.05);
            dt.Rows.Add("ASP포장", "기층", "ASP포장기층", "1", 0.1);
            dt.Rows.Add("ASP포장", "보조기층", "ASP포장보조기층", "1", 0.3);
            dt.Rows.Add("ASP포장", "동상방지층", "ASP포장동상방지층", "1", 0);


            dt.Rows.Add("포장", "ASP포장(국도)", "ASP포장(국도)", "0", 0);
            dt.Rows.Add("ASP포장(국도)", "표층", "ASP포장(국도)표층", "1", 0.05);
            dt.Rows.Add("ASP포장(국도)", "기층", "ASP포장(국도)기층", "1", 0.14);
            dt.Rows.Add("ASP포장(국도)", "보조기층", "ASP포장(국도)보조기층", "1", 0.3);
            dt.Rows.Add("ASP포장(국도)", "동상방지층", "ASP포장(국도)동상방지층", "1", 0);

            dt.Rows.Add("포장", "CON'C", "CON'C", "0", 0);
            dt.Rows.Add("CON'C", "콘크리트", "CON'C콘크리트", "1", 0.15);
            dt.Rows.Add("CON'C", "보조기층", "CON'C보조기층", "1", 0.3);


            dt.Rows.Add("포장", "A+C", "A+C", "0", 0);
            dt.Rows.Add("A+C", "표층", "A+C표층", "0", 0.05);
            dt.Rows.Add("A+C", "콘크리트", "A+C콘크리트", "1", 0.1);
            dt.Rows.Add("A+C", "보조기층", "A+C보조기층", "1", 0.3);


            dt.Rows.Add("포장", "투수콘", "투수콘", "0", 0);
            dt.Rows.Add("투수콘", "투수콘", "투수콘투수콘", "1", 0.07);
            dt.Rows.Add("투수콘", "보조기층", "투수콘보조기층", "1", 0.15);
            dt.Rows.Add("투수콘", "모래", "투수콘모래", "1", 0.05);


            dt.Rows.Add("포장", "보도블럭", "보도블럭", "0", 0);
            dt.Rows.Add("보도블럭", "보도블럭", "보도블럭보도블럭", "1", 0.06);
            dt.Rows.Add("보도블럭", "모래", "보도블럭모래", "1", 0.04);

            treeList1.ParentFieldName = "P_KEY";
            treeList1.KeyFieldName = "NAME";

            TreeListColumn tc = treeList1.Columns.Add();
            tc.FieldName = "P_KEY";
            tc.Caption = "P_KEY";
            //tc.Visible = true;

            tc = treeList1.Columns.Add();
            tc.FieldName = "CAPTION";
            tc.Caption = "CAPTION";
            tc.Visible = true;

            tc = treeList1.Columns.Add();
            tc.FieldName = "NAME";
            tc.Caption = "NAME";
            tc.Visible = true;

            tc = treeList1.Columns.Add();
            tc.FieldName = "VALUE_TP";
            tc.Caption = "값구분";
            tc.Visible = true;

            tc = treeList1.Columns.Add();
            tc.FieldName = "VALUE";
            tc.Caption = "값";
            tc.Visible = true;

            treeList1.DataSource = dt;
            //treeList1.PopulateColumns();
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (TopsData != null)
            {
                TopsData = null;
            }
            TopsData = new CTopsData();

            try
            {
                TopsData.MainData.ReadXml(@"D:\test.xml");

                QrySheetInfo();
                Set토적Data();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            TreeListNode node = treeList1.FindNodeByFieldValue("CAPTION", "1호맨홀");
            if (node.HasChildren == true)
            {
                //node.Nodes
            }

        }


        /// <summary>
        /// Procedure호출을 처리한다.
        /// </summary>
        private int CallProcedure()
        {
            MsgCaption.Caption = "";

            CMySql mysql = new CMySql();
            mysql.Connect();

            using (MySqlCommand mycommand = mysql.Connection.CreateCommand() )
            {

                try
                {
                    mycommand.CommandText = "P_PROC_PIPE01T00";
                    mycommand.CommandType = CommandType.StoredProcedure;

                    mycommand.Parameters.AddWithValue("@I_PROJECT_CD", PrjInfo.ProjectCd);
                    mycommand.Parameters["@I_PROJECT_CD"].Direction = ParameterDirection.Input;

                    mycommand.Parameters.Add("@O_RESULT_CD", MySqlDbType.Int32);
                    mycommand.Parameters["@O_RESULT_CD"].Direction = ParameterDirection.Output;

                    mycommand.ExecuteNonQuery();

                    int nCd = Convert.ToInt32(mycommand.Parameters["@O_RESULT_CD"].Value);

                    if (nCd == -1)
                    {
                        MsgCaption.Caption = "P_PROC_PIPE01T00 처리중 오류발생";
                        return -1;
                    }


                    ////////////P_PROC_PIPE01T10

                    mycommand.CommandText = "P_PROC_PIPE01T10";
                    mycommand.CommandType = CommandType.StoredProcedure;

                    mycommand.Parameters.Clear();
                    mycommand.Parameters.AddWithValue("@I_PROJECT_CD", PrjInfo.ProjectCd);
                    mycommand.Parameters["@I_PROJECT_CD"].Direction = ParameterDirection.Input;

                    mycommand.Parameters.Add("@O_RESULT_CD", MySqlDbType.Int32);
                    mycommand.Parameters["@O_RESULT_CD"].Direction = ParameterDirection.Output;

                    mycommand.ExecuteNonQuery();

                    nCd = Convert.ToInt32(mycommand.Parameters["@O_RESULT_CD"].Value);

                    if (nCd == -1)
                    {
                        MsgCaption.Caption = "P_PROC_PIPE01T10 처리중 오류발생";
                        return -1;
                    }




                    MsgCaption.Caption = "처리되었습니다.";


                    return 0;

                }
                catch (Exception ex)
                {
                    MsgCaption.Caption = ex.Message;
                }
                finally
                {
                    mysql.Connection.Close();
                }


                return 0;
            }
        }




        /// <summary>
        /// EXCEL 내용을 DB에 저장해요
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InsertBaseData();
                CallProcedure();
            }
            catch (Exception ex)
            {

                MsgCaption.Caption = ex.Message;
            }
        }

        private int InsertBaseData()
        {
            CMySql mysql = new CMySql();
            mysql.Connect();

            using (MySqlCommand mycommand = mysql.Connection.CreateCommand())
            {

                MySqlTransaction mytrans;

                mytrans = mysql.Connection.BeginTransaction();
                mycommand.Connection = mysql.Connection;
                mycommand.Transaction = mytrans;


                try
                {
                    //DELETE PIPE01M00
                    CustomSqlQuery query = sqlDataSource1.Queries["DELETE_PIPE01M00"] as CustomSqlQuery;
                    mycommand.CommandText = query.Sql;
                    mycommand.Parameters.Clear();

                    mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                    mycommand.ExecuteNonQuery();

                    ///DELETE PIPE02M00
                    query = sqlDataSource1.Queries["DELETE_PIPE02M00"] as CustomSqlQuery;
                    mycommand.CommandText = query.Sql;
                    mycommand.Parameters.Clear();

                    mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                    mycommand.ExecuteNonQuery();

                    ///DELETE PIPE03M00
                    query = sqlDataSource1.Queries["DELETE_PIPE03M00"] as CustomSqlQuery;
                    mycommand.CommandText = query.Sql;
                    mycommand.Parameters.Clear();

                    mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                    mycommand.ExecuteNonQuery();




                    DataTable dt = TopsData.MainData.Tables[CGetTableType.tbl_PIPE_TOOL_INPUT];

                    foreach (DataRow item in dt.Rows)
                    {

                        query = sqlDataSource1.Queries["INSERT_PIPE01M00"] as CustomSqlQuery;
                        string sss = query.Sql;

                        mycommand.CommandText = query.Sql;
                        mycommand.Parameters.Clear();

                        mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                        mycommand.Parameters.AddWithValue("@P_LINENAME", item["LINENAME"]);
                        mycommand.Parameters.AddWithValue("@P_SEQ", item[CGetTableType.col_INDEX]);
                        mycommand.Parameters.AddWithValue("@P_누가거리", item["누가거리"]);
                        mycommand.Parameters.AddWithValue("@P_지반고", item["지반고"]);
                        mycommand.Parameters.AddWithValue("@P_관저고", item["관저고"]);
                        mycommand.Parameters.AddWithValue("@P_관경", item["관경"]);
                        mycommand.Parameters.AddWithValue("@P_맨홀", item["맨홀"]);
                        mycommand.Parameters.AddWithValue("@P_TEXT1", item["TEXT1"]);
                        mycommand.Parameters.AddWithValue("@P_TEXT2", item["TEXT2"]);
                        mycommand.Parameters.AddWithValue("@P_구간", item["구간"]);
                        mycommand.Parameters.AddWithValue("@P_구배", item["구배"]);
                        mycommand.Parameters.AddWithValue("@P_INV", item["INV"]);
                        mycommand.Parameters.AddWithValue("@P_SIZE", item["SIZE"]);
                        mycommand.Parameters.AddWithValue("@P_라인명", item["라인명"]);
                        mycommand.Parameters.AddWithValue("@P_지하수위", item["지하수위"]);
                        mycommand.Parameters.AddWithValue("@P_맨홀_INVERT", item["맨홀INVERT"]);
                        //mycommand.Parameters.AddWithValue("@P_맨홀규격", "");
                        //mycommand.Parameters.AddWithValue("@P_맨홀규격", item["맨홀규격"]);
                        //mycommand.Parameters.AddWithValue("@P_굴착공법", item["굴착공법"]);
                        //mycommand.Parameters.AddWithValue("@P_굴착장비", "");
                        //mycommand.Parameters.AddWithValue("@P_굴착장비", item["굴착장비"]);
                        //mycommand.Parameters.AddWithValue("@P_포장종류", "");
                        //mycommand.Parameters.AddWithValue("@P_포장종류", item["포장종류"]);

                        mycommand.ExecuteNonQuery();

                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_LINENAME").Value = item["LINENAME"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_SEQ").Value = item[CGetTableType.col_INDEX];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_누가거리").Value = item["누가거리"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_지반고").Value = item["지반고"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_관저고").Value = item["관저고"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_관경").Value = item["관경"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_맨홀").Value = item["맨홀"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_TEXT1").Value = item["TEXT1"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_TEXT2").Value = item["TEXT2"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_구간").Value = item["구간"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_구배").Value = item["구배"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_INV").Value = item["INV"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_SIZE").Value =  item["SIZE"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_라인명").Value =  item["라인명"];                 
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_지하수위").Value = item["지하수위"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_맨홀_INVERT").Value = item["맨홀INVERT"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_맨홀규격").Value = item["맨홀규격"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_굴착공법").Value = item["굴착공법"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_굴착장비").Value = item["굴착장비"];
                        //sqlDataSource1.Queries["INSERT_PIPE01M00"].Parameters.Find(x => x.Name == "P_포장종류").Value = item["포장종류"];

                        //SqlDataSource.DisableCustomQueryValidation = true;
                        //sqlDataSource1.Fill("INSERT_PIPE01M00");

                    }

                    DataTable dt2 = TopsData.MainData.Tables[CGetTableType.tbl_토적표_INPUT];
                    foreach (DataRow item in dt2.Rows)
                    {

                        query = sqlDataSource1.Queries["INSERT_PIPE02M00"] as CustomSqlQuery;
                        string sss = query.Sql;

                        mycommand.CommandText = query.Sql;
                        mycommand.Parameters.Clear();

                        mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                        mycommand.Parameters.AddWithValue("@P_LINENAME", item["LINENAME"]);
                        mycommand.Parameters.AddWithValue("@P_SEQ", item[CGetTableType.col_INDEX]);
                        mycommand.Parameters.AddWithValue("@P_전후단면", item["전후단면"]);
                        mycommand.Parameters.AddWithValue("@P_전후단면_IDX", item["전후단면_IDX"]);
                        mycommand.Parameters.AddWithValue("@P_누가거리", item["누가거리"]);
                        mycommand.Parameters.AddWithValue("@P_거리", item["거리"]);
                        mycommand.Parameters.AddWithValue("@P_지반고", item["지반고"]);
                        mycommand.Parameters.AddWithValue("@P_관저고", item["관저고"]);
                        mycommand.Parameters.AddWithValue("@P_계획고", item["계획고"]);
                        mycommand.Parameters.AddWithValue("@P_육상_토사", item["육상(토사)"]);
                        mycommand.Parameters.AddWithValue("@P_육상_풍화암", item["육상(풍화암)"]);
                        mycommand.Parameters.AddWithValue("@P_육상_연암", item["육상(연암)"]);
                        mycommand.Parameters.AddWithValue("@P_수중_토사", item["수중(토사)"]);
                        mycommand.Parameters.AddWithValue("@P_수중_풍화암", item["수중(풍화암)"]);
                        mycommand.Parameters.AddWithValue("@P_수중_연암", item["수중(연암)"]);
                        mycommand.Parameters.AddWithValue("@P_관상부", item["관상부"]);
                        mycommand.Parameters.AddWithValue("@P_관주위", item["관주위"]);
                        mycommand.Parameters.AddWithValue("@P_ASP", item["ASP"]);
                        mycommand.Parameters.AddWithValue("@P_CONC", item["CONC"]);
                        mycommand.Parameters.AddWithValue("@P_덧씌우기", item["덧씌우기"]);
                        mycommand.Parameters.AddWithValue("@P_보도블럭", item["보도블럭"]);
                        mycommand.Parameters.AddWithValue("@P_모래부설", item["모래부설"]);
                        mycommand.Parameters.AddWithValue("@P_보조기층", item["보조기층"]);
                        mycommand.Parameters.AddWithValue("@P_동상방지층", item["동상방지층"]);

                        mycommand.ExecuteNonQuery();

                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_LINENAME").Value = item["LINENAME"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_SEQ").Value = item[CGetTableType.col_INDEX];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_전후단면").Value = item["전후단면"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_전후단면_IDX").Value = item["전후단면_IDX"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_누가거리").Value = item["누가거리"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_거리").Value = item["거리"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_지반고").Value = item["지반고"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_관저고").Value = item["관저고"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_계획고").Value = item["계획고"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_육상_토사").Value = item["육상(토사)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_육상_풍화암").Value = item["육상(풍화암)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_육상_연암").Value = item["육상(연암)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_수중_토사").Value = item["수중(토사)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_수중_풍화암").Value = item["수중(풍화암)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_수중_연암").Value = item["수중(연암)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_관상부").Value = item["관상부"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_관주위").Value = item["관주위"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_ASP").Value = item["ASP"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_CONC").Value = item["CONC"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_덧씌우기").Value = item["덧씌우기"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_보도블럭").Value = item["보도블럭"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_모래부설").Value = item["모래부설"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_보조기층").Value = item["보조기층"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_동상방지층").Value = item["동상방지층"];

                        //SqlDataSource.DisableCustomQueryValidation = true;
                        //sqlDataSource1.Fill("INSERT_PIPE02M00");
                    }


                    DataTable dt3 = TopsData.MainData.Tables[CGetTableType.tbl_SHEET_INFO];
                    foreach (DataRow item in dt3.Rows)
                    {

                        query = sqlDataSource1.Queries["INSERT_PIPE03M00"] as CustomSqlQuery;
                        string sss = query.Sql;

                        mycommand.CommandText = query.Sql;
                        mycommand.Parameters.Clear();

                        mycommand.Parameters.AddWithValue("@P_PROJECT_CD", PrjInfo.ProjectCd);
                        mycommand.Parameters.AddWithValue("@P_LINENAME", item["SHEET_NAME"]);
                        mycommand.Parameters.AddWithValue("@P_PIPE_TYPE", item["PIPE_TYPE"]);

                        mycommand.ExecuteNonQuery();

                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_LINENAME").Value = item["LINENAME"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_SEQ").Value = item[CGetTableType.col_INDEX];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_전후단면").Value = item["전후단면"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_전후단면_IDX").Value = item["전후단면_IDX"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_누가거리").Value = item["누가거리"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_거리").Value = item["거리"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_지반고").Value = item["지반고"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_관저고").Value = item["관저고"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_계획고").Value = item["계획고"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_육상_토사").Value = item["육상(토사)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_육상_풍화암").Value = item["육상(풍화암)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_육상_연암").Value = item["육상(연암)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_수중_토사").Value = item["수중(토사)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_수중_풍화암").Value = item["수중(풍화암)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_수중_연암").Value = item["수중(연암)"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_관상부").Value = item["관상부"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_관주위").Value = item["관주위"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_ASP").Value = item["ASP"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_CONC").Value = item["CONC"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_덧씌우기").Value = item["덧씌우기"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_보도블럭").Value = item["보도블럭"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_모래부설").Value = item["모래부설"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_보조기층").Value = item["보조기층"];
                        //sqlDataSource1.Queries["INSERT_PIPE02M00"].Parameters.Find(x => x.Name == "P_동상방지층").Value = item["동상방지층"];

                        //SqlDataSource.DisableCustomQueryValidation = true;
                        //sqlDataSource1.Fill("INSERT_PIPE02M00");
                    }

                    MsgCaption.Caption = "등록 되었습니다.";

                    mytrans.Commit();

                   
                }
                catch (Exception ex)
                {
                    mytrans.Rollback();
                    MsgCaption.Caption = ex.Message;
                    throw ex;
                }
                finally
                {
                    mysql.Connection.Close();
                }

                return 0;
            }
        }

        private void afterProc()
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void gridControl4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            OutDataSource.Queries["QRY_토적표"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = PrjInfo.ProjectCd;

            OutDataSource.Fill("QRY_토적표");

            DataTable dt = CUtil.GetTable(OutDataSource.Result["QRY_토적표"]);

            gridControl4.DataSource = dt;
        }

       
        /// <summary>
        /// 맨홀 규격을 조회한다.
        /// </summary>
        /// <returns></returns>
        private DataTable Qry_맨홀()
        {
            try
            {
                sqlDataQry.Fill("QRY_MANHOLE");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_MANHOLE"]);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 굴착장비를 조회한다.
        /// </summary>
        /// <returns></returns>
        private DataTable Qry_굴착장비()
        {
            try
            {
                sqlDataQry.Fill("QRY_굴착장비");

                DataTable dt = CUtil.GetTable(sqlDataQry.Result["QRY_굴착장비"]);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        private void editFormUpdateButton_Click(object sender, EventArgs e)
        {
            //DataRow dr = gridView1.GetFocusedDataRow();

            //try
            //{

            //    if (dr.RowState == DataRowState.Added)
            //    {
            //        //insert 버튼으로 열었으면 신규 추가를 시도하고

            //        sqlDataSource1.Queries["INSERT_COD01M00"].Parameters.Find(x => x.Name == "P_CLIENT_NM").Value = dr["CLIENT_NM"].ToString();
            //        sqlDataSource3.Queries["INSERT_COD01M00"].Parameters.Find(x => x.Name == "P_TEL_NO").Value = dr["TEL_NO"].ToString();
            //        sqlDataSource3.Queries["INSERT_COD01M00"].Parameters.Find(x => x.Name == "P_FAX_NO").Value = dr["FAX_NO"].ToString();
            //        sqlDataSource3.Queries["INSERT_COD01M00"].Parameters.Find(x => x.Name == "P_DESCRIPT").Value = dr["DESCRIPT"].ToString();


            //        SqlDataSource.DisableCustomQueryValidation = true;

            //        sqlDataSource3.Fill("INSERT_COD01M00");
            //    }
            //    else
            //    {
            //        sqlDataSource3.Queries["UPDATE_COD01M00"].Parameters.Find(x => x.Name == "P_CLIENT_CD").Value = dr["CLIENT_CD"].ToString();

            //        sqlDataSource3.Queries["UPDATE_COD01M00"].Parameters.Find(x => x.Name == "P_CLIENT_NM").Value = dr["CLIENT_NM"].ToString();
            //        sqlDataSource3.Queries["UPDATE_COD01M00"].Parameters.Find(x => x.Name == "P_TEL_NO").Value = dr["TEL_NO"].ToString();
            //        sqlDataSource3.Queries["UPDATE_COD01M00"].Parameters.Find(x => x.Name == "P_FAX_NO").Value = dr["FAX_NO"].ToString();
            //        sqlDataSource3.Queries["UPDATE_COD01M00"].Parameters.Find(x => x.Name == "P_DESCRIPT").Value = dr["DESCRIPT"].ToString();


            //        SqlDataSource.DisableCustomQueryValidation = true;

            //        sqlDataSource3.Fill("UPDATE_COD01M00");
            //    }

            //}
            //catch (Exception ex)
            //{

            //    MsgCaption.Caption = ex.InnerException.InnerException.InnerException.Message;
            //}
            //finally
            //{
            //    //   b_Insert = false;
            //}

        }

        private void gridView1_ShowingPopupEditForm(object sender, DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs e)
        {
            foreach (Control control in e.EditForm.Controls)
            {
                if (!(control is EditFormContainer))
                {
                    continue;
                }
                foreach (Control nestedControl in control.Controls)
                {
                    if (!(nestedControl is PanelControl))
                    {
                        continue;
                    }
                    foreach (Control button in nestedControl.Controls)
                    {
                        if (!(button is SimpleButton))
                        {
                            continue;
                        }
                        var simpleButton = button as SimpleButton;
                        simpleButton.Click -= editFormUpdateButton_Click;
                        simpleButton.Click += editFormUpdateButton_Click;
                    }
                }
            }
        }
    }
}