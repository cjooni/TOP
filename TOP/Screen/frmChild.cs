using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;
using TOP.Parent;
using DevExpress.XtraTab;
using TOP.lib;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace TOP.Screen
{
    public delegate void LoadChkDataEventHandler(GridView gridview); //자식폼으로부터 그리드가 그려졌다는 수신 이벤트
    public delegate void ChkColumnEventHandler(DataRow DR); //자식폼의 그리드 컬럼의 Visible 여부가 변경되었다는 이벤트

        

    public partial class frmChild : DevExpress.XtraEditors.XtraForm
    {
        private CPageMngr pageMngr;

        /// <summary>
        /// 보내는 Event를 선언
        /// </summary>
        public ChkColumnEventHandler ChkColumnEvent;
      
        public CPageMngr PageMngr { get => pageMngr; set => pageMngr = value; }

        public frmChild()
        {
            InitializeComponent();
            PageMngr = new CPageMngr();
             
        }



        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            LoadScreen("frmTest1");
        }


        private int LoadScreen(string strScrnNm)
        {
            string nameSpace = "TOP.Screen"; //네임스페이스 명

            
            string frmName = string.Format("{0}.{1}", nameSpace, strScrnNm);
            PForm frm;

            try
            {
              
                if (PageMngr.GetPageByName(frmName) != null)
                {
                    XtraTabPage page = PageMngr.GetPageByName(frmName).TabPag;
                    xtraTabControl1.SelectedTabPage = page;

                   

                    return 0;
                }
                else
                {
                    Assembly assem = Assembly.GetExecutingAssembly();
                    frm = (PForm)assem.CreateInstance(frmName);
                    

                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;

                    frm.Dock = DockStyle.Fill;

                    XtraTabPage newTab;
                    //아니면 생성
                    newTab = xtraTabControl1.TabPages.Add(frm.Text);

                    newTab.Show();

                    newTab.Controls.Add(frm);
                    frm.Show();

                    CPageData pagedata = new CPageData();
                    pagedata.AsmName = frmName;
                    pagedata.Caption = frm.Text;
                    pagedata.TabPag = newTab;
                    pagedata.Form = frm;

                    this.ChkColumnEvent += new ChkColumnEventHandler(frm.ChkColumn);
                    frm.LoadChkDataEvent = new LoadChkDataEventHandler(this.LoadChkData);
                    PageMngr.AddPage(pagedata);

                   
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            return 0;
        }

        //그리드가 다 그려졌다는 내용을 전달받는 이벤트 처리 함수
        private void LoadChkData(GridView gridview)
        {
            try
            {

                gridView2.Columns.Clear();

                DataTable dt = new DataTable();

                dt.Columns.Add("CHECK", typeof(Boolean));
                dt.Columns.Add("CAPTION", typeof(string));
                dt.Columns.Add("FIELD", typeof(string));

                foreach (GridColumn item in gridview.Columns)
                {
                    DataRow dr = dt.Rows.Add();
                    dr["CHECK"] = item.Visible;
                    dr["CAPTION"] = item.Caption;
                    dr["FIELD"] = item.FieldName;
                }

                gridView2.GridControl.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }


        private Boolean chkDupScreen(string strScrNm)
        {
            

            return true;
        }

        private void NavigationPane1_SizeChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("aaaa");
        }

        private void NavigationPane1_StateChanged(object sender, DevExpress.XtraBars.Navigation.StateChangedEventArgs e)
        {
          
            splitContainer1.SplitterDistance = navigationPane1.Width + 1;
        }


        /// <summary>
        /// Page Header를 Close하면 Dictionary 를 지운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;


                XtraTabPage page = PageMngr.GetPageByCaptoin(arg.Page.Text).TabPag;

                PageMngr.RemovePageByPage(page);
                xtraTabControl1.TabPages.Remove(page);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           // m_dic_Scr
           // Assembly.GetAssembly()

        }

        private void pCtl1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmChild_Load(object sender, EventArgs e)
        {
            xtraTabControl1.TabPages.Remove(xtraTabPage1);
            xtraTabControl1.TabPages.Remove(xtraTabPage2);
        }


        /// <summary>
        /// Page가 바뀌면 해당 화면의 그리드 컬럼 리스트를 가져와 보자 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
              
        }

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void repositoryItemCheckEdit1_CheckStateChanged(object sender, EventArgs e)
        {
      
        }

        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
        
        }

        private void repositoryItemCheckEdit1_Click(object sender, EventArgs e)
        {
     
        }

        private void repositoryItemCheckEdit2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
          
        }

        private void gridChkList_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void repositoryItemCheckEdit2_CheckStateChanged(object sender, EventArgs e)
        {
   
        }

        private void repositoryItemCheckEdit2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
       
        }

        private void repositoryItemCheckEdit2_EditValueChanged(object sender, EventArgs e)
        {
    
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.Column.FieldName == "CHECK")
            {
                gridView2.RefreshRow(e.RowHandle);

                DataRow origRow = gridView2.GetFocusedDataRow();
                /*
                 * 실제로 값이 바뀌기 전이니까
                 * 미리 값을 바꾼다.
                 */
                DataTable dt = new DataTable();

                dt.Columns.Add("CHECK", typeof(Boolean));
                dt.Columns.Add("CAPTION", typeof(string));
                dt.Columns.Add("FIELD", typeof(string));


                DataRow dr = dt.Rows.Add();

                if(Convert.ToBoolean(origRow["CHECK"]) == true)
                {
                    dr["CHECK"] = false;
                }
                else
                {
                    dr["CHECK"] = true;
                }

                
                dr["CAPTION"] = origRow["CAPTION"];
                dr["FIELD"] = origRow["FIELD"];

                ChkColumnEvent(dr);

               
            }




        }

        private void gridChkList_Click(object sender, EventArgs e)
        {

        }

        private void frmChild_Shown(object sender, EventArgs e)
        {
           
;        }
    }
}