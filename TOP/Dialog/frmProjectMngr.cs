using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TOP.lib;

namespace TOP.Dialog
{
    public partial class frmProjectMngr : TOP.Parent.PForm
    {
        private bool b_Insert = false;
        public frmProjectMngr()
        {
            InitializeComponent();

            dateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateStart.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";

            dateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";

            repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy-MM-dd";
            repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit1.EditFormat.FormatString = "yyyy-MM-dd";
            repositoryItemDateEdit1.EditMask = "d";

            

            dateStart.DateTime = DateTime.Now;
            dateEnd.DateTime = DateTime.Now;
            chkDate.Checked = true;

        }


        /// <summary>
        /// PROJECT 정보를 조회한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QryProject();

        }


        private void QryProject()
        {

            try
            {

                string date = ((DateTime)dateStart.EditValue).ToString("yyyyMMdd");

                if (chkDate.Checked == true)
                {
                    //날짜를 무시한 전체 조회는 요기를 
                    sqlDataSource1.Queries["QRY_PROJECT"].Parameters.Find(x => x.Name == "P_START_DT").Value = "00000000";
                    sqlDataSource1.Queries["QRY_PROJECT"].Parameters.Find(x => x.Name == "P_END_DT").Value = "99999999";
                    sqlDataSource1.Queries["QRY_PROJECT"].Parameters.Find(x => x.Name == "P_PROJECT_NM").Value = edtProjectNm.Text;
                    sqlDataSource1.Queries["QRY_PROJECT"].Parameters.Find(x => x.Name == "P_USER_NM").Value = edtUserNm.Text;

                }
                else
                {
                    ///전체 조회가 아니면 요기를 
                    sqlDataSource1.Queries["QRY_PROJECT"].Parameters.Find(x => x.Name == "P_START_DT").Value = ((DateTime)dateStart.EditValue).ToString("yyyyMMdd");
                    sqlDataSource1.Queries["QRY_PROJECT"].Parameters.Find(x => x.Name == "P_END_DT").Value = ((DateTime)dateEnd.EditValue).ToString("yyyyMMdd");
                    sqlDataSource1.Queries["QRY_PROJECT"].Parameters.Find(x => x.Name == "P_PROJECT_NM").Value = edtProjectNm.Text;
                    sqlDataSource1.Queries["QRY_PROJECT"].Parameters.Find(x => x.Name == "P_USER_NM").Value = edtUserNm.Text;

                }

                sqlDataSource1.Fill("QRY_PROJECT");

                DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_PROJECT"]);

                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MsgCaption.Caption = ex.Message;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
  
        }

        private void gridView1_ShowingPopupEditForm(object sender, DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs e)
        {
  
        }



        /// <summary>
        /// PROECT 정보를 등록한다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {
          
            
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow Dr = gridView1.GetFocusedDataRow();

            QryProjectInfo(Dr);
        }

        /// <summary>
        /// 프로젝트 정보를 더블클릭 해불면 정정할수 있는 화면으로 변경
        /// </summary>
        /// <param name="Dr"></param>
        private void QryProjectInfo(DataRow Dr)
        {
          
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            frmProjectInfo frm = new frmProjectInfo();
            frm.SetDlgType(2, dr);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
