using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using TOP.Dialog;
using TOP.lib;
using TOP.MngFrm;
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
            try
            {

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);

                return; ;
            }
            


            //메인이 뜨면 로그인을 진행해야 한다.
            //frmLogin login = new frmLogin();
            //if ( login.ShowDialog() != DialogResult.OK)
            //{
            //    this.Close();
            //}
            //UserInfo = login.UserInfo;
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
            frm.SetDlgType(1, null);
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mFrmProject frm = new mFrmProject();
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
        /// Project 선택창에서 선택 내용을 전달 받는다.
        /// </summary>
        /// <param name="PrjInfo"></param>
        private void SelectedPrjoect(CPrjInfo PrjInfo)
        {
            MessageBox.Show(PrjInfo.ProjectNm);
        }

        /// <summary>
        /// 업체관리 화면을 띄워봐봐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mFrmClient frm = new mFrmClient();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmClient2 frm = new frmClient2();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
        }



        /// <summary>
        /// 데이터 Upload를 위해 프로젝트를 선택한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSelectPrj frm = new frmSelectPrj();
            frm.StartPosition = FormStartPosition.CenterScreen;

            ///프로젝트 조회창에서 프로젝트를 선택하면
            ///해당 프로젝트를 기반으로 한 MDI Child를 생성한다.
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMdiChildByProjectCd(frm.PrjInfo);
            }
        }

        /// <summary>
        /// 수정을 위해 프로젝트 정보창을 연다. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyPrj frm = new frmModifyPrj();
            frm.StartPosition = FormStartPosition.CenterScreen;

            ///프로젝트 조회창에서 프로젝트를 선택하면
            ///해당 프로젝트를 기반으로 한 MDI Child를 생성한다.
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMdiChildByModifyFrm(frm.PrjInfo);
            }
        }

        private void LoadMdiChildByProjectCd(CPrjInfo PrjInfo)
        {
            string nameSpace = "TOP.Screen"; //네임스페이스 명
            Assembly cuasm = Assembly.GetExecutingAssembly();
            //string Format 의 따옴표와 마침표 주의!!
            frmInput frm = (frmInput)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, "frmInput"));
            frm.MdiParent = this;
            frm.PrjInfo = PrjInfo;

            frm.Text = PrjInfo.ProjectNm;
            //frm.UserInfo = UserInfo;
            frm.WindowState = FormWindowState.Maximized;
            frm.Text = PrjInfo.ProjectNm;
            frm.Show();
        }

        private void LoadMdiChildByModifyFrm(CPrjInfo PrjInfo)
        {
            string nameSpace = "TOP.Screen"; //네임스페이스 명
            Assembly cuasm = Assembly.GetExecutingAssembly();
            //string Format 의 따옴표와 마침표 주의!!
            frmModify frm = (frmModify)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, "frmModify"));
            frm.MdiParent = this;
            frm.PrjInfo = PrjInfo;

            frm.Text = PrjInfo.ProjectNm;
            //frm.UserInfo = UserInfo;
            frm.WindowState = FormWindowState.Maximized;
            frm.Text = PrjInfo.ProjectNm;
            frm.Show();
        }

        private void LoadMdiChildBy관로토공(CPrjInfo PrjInfo)
        {
            string nameSpace = "TOP.Screen"; //네임스페이스 명
            Assembly cuasm = Assembly.GetExecutingAssembly();
            //string Format 의 따옴표와 마침표 주의!!
            frm관로토공 frm = (frm관로토공)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, "frm관로토공"));
            frm.MdiParent = this;
            frm.PrjInfo = PrjInfo;

            frm.Text = PrjInfo.ProjectNm;
            //frm.UserInfo = UserInfo;
            frm.WindowState = FormWindowState.Maximized;
            frm.Text = PrjInfo.ProjectNm;
            frm.Show();
        }

        /// <summary>
        /// 관로토공보고서 화면 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyPrj frm = new frmModifyPrj();
            frm.StartPosition = FormStartPosition.CenterScreen;

            ///프로젝트 조회창에서 프로젝트를 선택하면
            ///해당 프로젝트를 기반으로 한 MDI Child를 생성한다.
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMdiChildBy관로토공(frm.PrjInfo);
            }
        }

        /// <summary>
        /// 맨홀토공보고서 화면 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyPrj frm = new frmModifyPrj();
            frm.StartPosition = FormStartPosition.CenterScreen;

            ///프로젝트 조회창에서 프로젝트를 선택하면
            ///해당 프로젝트를 기반으로 한 MDI Child를 생성한다.
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMdiChildBy맨홀토공(frm.PrjInfo);
            }
        }

        private void LoadMdiChildBy맨홀토공(CPrjInfo PrjInfo)
        {
            string nameSpace = "TOP.Screen"; //네임스페이스 명
            Assembly cuasm = Assembly.GetExecutingAssembly();
            //string Format 의 따옴표와 마침표 주의!!
            frm맨홀토공 frm = (frm맨홀토공)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, "frm맨홀토공"));
            frm.MdiParent = this;
            frm.PrjInfo = PrjInfo;

            frm.Text = PrjInfo.ProjectNm;
            //frm.UserInfo = UserInfo;
            frm.WindowState = FormWindowState.Maximized;
            frm.Text = PrjInfo.ProjectNm;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyPrj frm = new frmModifyPrj();
            frm.StartPosition = FormStartPosition.CenterScreen;

            ///프로젝트 조회창에서 프로젝트를 선택하면
            ///해당 프로젝트를 기반으로 한 MDI Child를 생성한다.
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMdiChildBy관로공(frm.PrjInfo);
            }
        }

        private void LoadMdiChildBy관로공(CPrjInfo PrjInfo)
        {
            string nameSpace = "TOP.Screen"; //네임스페이스 명
            Assembly cuasm = Assembly.GetExecutingAssembly();
            //string Format 의 따옴표와 마침표 주의!!
            frm관로공 frm = (frm관로공)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, "frm관로공"));
            frm.MdiParent = this;
            frm.PrjInfo = PrjInfo;

            frm.Text = PrjInfo.ProjectNm;
            //frm.UserInfo = UserInfo;
            frm.WindowState = FormWindowState.Maximized;
            frm.Text = PrjInfo.ProjectNm;
            frm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmModifyPrj frm = new frmModifyPrj();
            frm.StartPosition = FormStartPosition.CenterScreen;

            ///프로젝트 조회창에서 프로젝트를 선택하면
            ///해당 프로젝트를 기반으로 한 MDI Child를 생성한다.
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMdiChildBy가시설공(frm.PrjInfo);
            }
        }

        private void LoadMdiChildBy가시설공(CPrjInfo PrjInfo)
        {
            string nameSpace = "TOP.Screen"; //네임스페이스 명
            Assembly cuasm = Assembly.GetExecutingAssembly();
            //string Format 의 따옴표와 마침표 주의!!
            frm가시설공 frm = (frm가시설공)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, "frm가시설공"));
            frm.MdiParent = this;
            frm.PrjInfo = PrjInfo;

            frm.Text = PrjInfo.ProjectNm;
            //frm.UserInfo = UserInfo;
            frm.WindowState = FormWindowState.Maximized;
            frm.Text = PrjInfo.ProjectNm;
            frm.Show();
        }


        /// <summary>
        /// 포장별 공정 List 관리화면을 호출한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMngr포장공정 frm = new frmMngr포장공정();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }



        /// <summary>
        /// 맨홀구조물 설정창을 띄운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMngr맨홀구조물  frm = new frmMngr맨홀구조물();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMngr관로구조 frm = new frmMngr관로구조();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMngr포장구조 frm = new frmMngr포장구조();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}