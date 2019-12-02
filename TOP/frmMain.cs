using DevExpress.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOP.Dialog;
using TOP.lib;
using TOP.Parent;
using TOP.Screen;

namespace TOP
{    

    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        

        private String m_UserId;

        private CUserInfo userInfo;

        public CUserInfo UserInfo { get => userInfo; set => userInfo = value; }

        public frmMain()
        {
            InitializeComponent();

            CUserInfo userInfo = new CUserInfo();
        }



        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string nameSpace = "TOP.Screen"; //네임스페이스 명


            Assembly cuasm = Assembly.GetExecutingAssembly();


            //string Format 의 따옴표와 마침표 주의!!
            Form frm = (Form)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, "frmChild"));

            frm.MdiParent = this;


            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //메인이 뜨면 로그인을 진행해야 한다.
            frmLogin login = new frmLogin();
            if ( login.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            UserInfo = login.UserInfo;
        }

        private void SetUserInfo()
        {
            
            try
            {


                foreach (QueryParameter item in sqlDataSource1.Queries["QRY_USER_INFO"].Parameters)
                {
                    if (item.Name == "P_USER_ID")
                    {
                        item.Value = m_UserId.PadRight(8);
                    }
                }

                sqlDataSource1.Fill();

                DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_USER_INFO"]);



            }
            catch (Exception ex)
            {

                //InfoMsg.Caption = ex.Message;
            }

        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
     
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            
        }

        /// <summary>
        /// 사용자 정보 관리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUserMngr frm = new frmUserMngr();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }


        
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }


        /// <summary>
        /// 화면관리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmScrnInfo frm = new frmScrnInfo();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        /// <summary>
        /// 프로젝트 관리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProjectInfo frm = new frmProjectInfo();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProjectMngr frm = new frmProjectMngr();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string nameSpace = "TOP.Screen"; //네임스페이스 명


            Assembly cuasm = Assembly.GetExecutingAssembly();


            //string Format 의 따옴표와 마침표 주의!!
            Form frm = (Form)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, "frmChild"));

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Text = "파이프 툴 변환";

            frm.Show();
        }

        /// <summary>
        /// 프로젝트를 선택한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProjectInfo frm = new frmProjectInfo();
            frm.StartPosition = FormStartPosition.CenterScreen;

            ///프로젝트 조회창에서 프로젝트를 선택하면 
            ///해당 프로젝트를 기반으로 한 MDI Child를 생성한다.
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMdiChildByProjectCd(frm.PrjInfo);
            }
        }


        private void LoadMdiChildByProjectCd(CPrjInfo PrjInfo)
        {
            string nameSpace = "TOP.Screen"; //네임스페이스 명
            Assembly cuasm = Assembly.GetExecutingAssembly();
            //string Format 의 따옴표와 마침표 주의!!
            frmChild frm = (frmChild)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, "frmChild"));
            frm.MdiParent = this;
            frm.PrjInfo = PrjInfo;
            frm.UserInfo = UserInfo;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }


        /// <summary>
        /// Project 선택창에서 선택 내용을 전달 받는다.
        /// </summary>
        /// <param name="PrjInfo"></param>
        private void SelectedPrjoect(CPrjInfo PrjInfo)
        {
            MessageBox.Show(PrjInfo.ProjectNm);
        }
    }
}
