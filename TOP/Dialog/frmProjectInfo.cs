using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.EditForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TOP.lib;
using TOP.Popup;

namespace TOP.Dialog
{
    public partial class frmProjectInfo : TOP.Parent.PForm
    {
        private CPrjInfo prjInfo;
        private bool b_Insert = false;

        internal CPrjInfo PrjInfo { get => prjInfo; set => prjInfo = value; }

        public frmProjectInfo()
        {
            InitializeComponent();

            PrjInfo = new CPrjInfo();

            
        }

        public void SetDlgType(int nType, DataRow dr)
        {
            ///등록 모드
            if (nType == 1 )
            {
                btnModify.Visible = false;
                btnModify.Enabled = false;

                lookUpEndYn.EditValue = "N";
            }
            else 
            {
                //정정모드
                btnAdd.Visible = false;
                btnAdd.Enabled = false;

                edtProjectCd.Text = dr["PROJECT_CD"].ToString();
                edtProjectNm.Text = dr["PROJECT_NM"].ToString();
                dateStart.DateTime = DateTime.ParseExact(dr["START_DT"].ToString(), "yyyyMMdd", null);
                dateEnd.DateTime = DateTime.ParseExact(dr["END_DT"].ToString(), "yyyyMMdd", null);
                edtUserId.Text = dr["USER_ID"].ToString();
                edtUserNm.Text = dr["USER_NM"].ToString();
                memoDesc.Text = dr["PROJECT_DESC"].ToString();

                edtClientNm.Text = dr["CLIENT_NM"].ToString();
                edtClientCd.Text = dr["CLIENT_CD"].ToString();
                edtClientId.Text = dr["CLIENT_ID"].ToString();
                edtClientIdNm.Text = dr["CLIENT_ID_NM"].ToString();
                lookUpEndYn.EditValue = dr["END_YN"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
           
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
          

        }

        /// <summary>
        /// 신규 프로젝트 등록을 처리한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void gridView1_ShowingPopupEditForm(object sender, DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs e)
        {
           
        }

        /// <summary>
        /// 담당자 정보를 찾는다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            PopAddProject dlg = new PopAddProject();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    edtClientNm.Text = dlg.Dr["CLIENT_NM"].ToString();
                    edtClientIdNm.Text = dlg.Dr["CLIENT_ID_NM"].ToString();
                    edtClientId.Text = dlg.Dr["CLIENT_ID"].ToString();
                    edtClientCd.Text = dlg.Dr["CLIENT_CD"].ToString();

                }
                catch (Exception ex)
                {

                    MsgCaption.Caption = ex.Message;

                }
            }
        }

        private void btnClientID_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void frmProjectInfo_Shown(object sender, EventArgs e)
        {
            dateStart.DateTime = DateTime.Now;
            dateEnd.DateTime = DateTime.Now;
        }

        private void p_btnUserNm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            PopupUserId dlg = new PopupUserId();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    edtUserId.Text = dlg.Dr["USER_ID"].ToString();
                    edtUserNm.Text = dlg.Dr["USER_NM"].ToString();
                    

                }
                catch (Exception ex)
                {

                    MsgCaption.Caption = ex.Message;

                }
            }

        }

        /// <summary>
        /// 프로젝트 정보를 등록한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {

            string strProjectCd = "";

            if (edtProjectCd.Text.Trim() != "")
            {
                MessageBox.Show(string.Format("프로젝트 번호가 있습니다.[{0}]", edtProjectCd.Text), "등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (edtProjectNm.Text.Trim() == "")
            {
                MessageBox.Show(string.Format("프로젝트 명이 없습니다."), "등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (edtUserNm.Text.Trim() == "")
            {
                MessageBox.Show(string.Format("프로젝트 담당자가 없습니다."), "등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (edtClientIdNm.Text.Trim() == "")
            {
                MessageBox.Show(string.Format("발주처 담당자가 없습니다."), "등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                //SqlDataSource.DisableCustomQueryValidation = true;
                //sqlDataSource1.Fill("QRY_PROJECT_CD");
                //DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_PROJECT_CD"]);

                //strProjectCd = dt.Rows[0]["PROJECT_CD"].ToString();


                //sqlDataSource1.Queries["INSERT_PROJECT"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = dt.Rows[0]["PROJECT_CD"].ToString();
                //sqlDataSource1.Queries["INSERT_PROJECT"].Parameters.Find(x => x.Name == "P_PROJECT_NM").Value = edtProjectNm.Text;
                //sqlDataSource1.Queries["INSERT_PROJECT"].Parameters.Find(x => x.Name == "P_START_DT").Value = dateStart.DateTime.ToString("yyyyMMdd");
                //sqlDataSource1.Queries["INSERT_PROJECT"].Parameters.Find(x => x.Name == "P_END_DT").Value = dateEnd.DateTime.ToString("yyyyMMdd");
                //sqlDataSource1.Queries["INSERT_PROJECT"].Parameters.Find(x => x.Name == "P_USER_ID").Value = edtUserId.Text;
                //sqlDataSource1.Queries["INSERT_PROJECT"].Parameters.Find(x => x.Name == "P_PROJECT_DESC").Value = memoDesc.Text;
                //sqlDataSource1.Queries["INSERT_PROJECT"].Parameters.Find(x => x.Name == "P_CLIENT_ID").Value = edtClientId.Text;
                //sqlDataSource1.Queries["INSERT_PROJECT"].Parameters.Find(x => x.Name == "P_CLIENT_CD").Value = edtClientCd.Text;

                //SqlDataSource.DisableCustomQueryValidation = true;

                //sqlDataSource1.Fill("INSERT_PROJECT");

               // edtProjectCd.Text = dt.Rows[0]["PROJECT_CD"].ToString();

                MsgCaption.Caption = string.Format("프로젝트 [{0}][{1}]이 생성되었습니다.", edtProjectNm.Text, edtProjectCd.Text);
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }


            
        }

        private void dateEnd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string strProjectCd = "";

            if (edtProjectCd.Text.Trim() == "")
            {
                MessageBox.Show(string.Format("프로젝트 번호가 없습니다."), "등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (edtProjectNm.Text.Trim() == "")
            {
                MessageBox.Show(string.Format("프로젝트 명이 없습니다."), "등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (edtUserNm.Text.Trim() == "")
            {
                MessageBox.Show(string.Format("프로젝트 담당자가 없습니다."), "등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (edtClientIdNm.Text.Trim() == "")
            {
                MessageBox.Show(string.Format("발주처 담당자가 없습니다."), "등록오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {


                //sqlDataSource1.Queries["UPDATE_PROJECT"].Parameters.Find(x => x.Name == "P_PROJECT_CD").Value = edtProjectCd.Text;
                //sqlDataSource1.Queries["UPDATE_PROJECT"].Parameters.Find(x => x.Name == "P_PROJECT_NM").Value = edtProjectNm.Text;
                //sqlDataSource1.Queries["UPDATE_PROJECT"].Parameters.Find(x => x.Name == "P_START_DT").Value = dateStart.DateTime.ToString("yyyyMMdd");
                //sqlDataSource1.Queries["UPDATE_PROJECT"].Parameters.Find(x => x.Name == "P_END_DT").Value = dateEnd.DateTime.ToString("yyyyMMdd");
                //sqlDataSource1.Queries["UPDATE_PROJECT"].Parameters.Find(x => x.Name == "P_USER_ID").Value = edtUserId.Text;
                //sqlDataSource1.Queries["UPDATE_PROJECT"].Parameters.Find(x => x.Name == "P_PROJECT_DESC").Value = memoDesc.Text;
                //sqlDataSource1.Queries["UPDATE_PROJECT"].Parameters.Find(x => x.Name == "P_CLIENT_ID").Value = edtClientId.Text;
                //sqlDataSource1.Queries["UPDATE_PROJECT"].Parameters.Find(x => x.Name == "P_CLIENT_CD").Value = edtClientCd.Text;
                //sqlDataSource1.Queries["UPDATE_PROJECT"].Parameters.Find(x => x.Name == "P_END_YN").Value = lookUpEndYn.EditValue;

                SqlDataSource.DisableCustomQueryValidation = true;

                //sqlDataSource1.Fill("UPDATE_PROJECT");

                MsgCaption.Caption = string.Format("프로젝트 [{0}][{1}]가 정정되었습니다.", edtProjectNm.Text, edtProjectCd.Text);
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }


        }
    }
}
