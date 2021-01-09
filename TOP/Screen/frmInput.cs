using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Data;
using System.Linq;
using TOP.lib;

namespace TOP.Screen
{
    public partial class frmInput : TOP.Parent.PForm
    {
        private CTopsData TopsData;

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

            InitControl();
        }

        private void InitControl()
        {
            ///굴착장비 Data Load
            repLookUp = new RepositoryItemGridLookUpEdit();
            repLookUp.DisplayMember = "명칭";
            repLookUp.ValueMember = "명칭";
            repLookUp.NullText = "";
            repLookUp.KeyMember = "명칭";
            repLookUp.DataSource = CGetTableType.Get굴착장비();
            gridControl1.RepositoryItems.Add(repLookUp);

            //
            repLookUp2 = new RepositoryItemGridLookUpEdit();
            repLookUp2.DisplayMember = "명칭";
            repLookUp2.ValueMember = "명칭";
            repLookUp2.NullText = "";
            repLookUp2.KeyMember = "ID";
            repLookUp2.DataSource = CGetTableType.Get맨홀규격();
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
            DataRow dr = gridView토적표.GetFocusedDataRow();

            DataTable dt = TopsData.MainData.Tables[dr["SheetName"].ToString()];

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

            DataTable dt2 = TopsData.MainData.Tables[dr["SheetName"].ToString() + "_토적"];
            gridControl3.DataSource = dt2;
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
            if (TopsData != null)
            {
                TopsData = null;
            }

            try
            {
                TopsData = new CTopsData();
                TopsData.LoadFromPipeTool();

                QrySheetInfo();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// SHEET INFO 정보를 조회한다. 
        /// </summary>
        private void QrySheetInfo()
        {
            var sql = from a in TopsData.MainData.Tables["SHEET_INFO"].AsEnumerable()
                      select new
                      {
                          SheetName = a.Field<string>("SHEET_NAME").ToString()
                      };

            DataTable dt = CUtil.LinqQueryToDataTable(sql);

            gridView토적표.OptionsBehavior.Editable = false;
            gridControl2.DataSource = dt;
        }

        /// <summary>
        /// 토적 데이터를 로드한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMassDataLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                TopsData.LoadFrom토적Data();

                Set토적Data();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            
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
                if (TopsData.MainData.Tables.Contains(CGetTableType.tbl_맨홀구간정보) == false)
                {
                    TopsData.MakeBidge();
                }
                
                TopsData.Print토적표(spread1.Document);
                TopsData.Print맨홀조서(spread1.Document);
                TopsData.Print간이흙막이연장조서(spread1.Document);
                TopsData.Proc오수관(spread1.Document);
                TopsData.Proc오수관실연장조서(spread1.Document);
                TopsData.Proc오수관접합및절단조서(spread1.Document);
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
    }
}