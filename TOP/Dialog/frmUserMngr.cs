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
    public partial class frmUserMngr : TOP.Parent.PForm
    {
        private bool b_Insert = false;
        public frmUserMngr()
        {
            InitializeComponent();
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
         
            try
            {
                sqlDataSource1.Queries["QRY_USER_ID"].Parameters.Find(x => x.Name == "P_USER_ID").Value = edtUserID.Text;
                sqlDataSource1.Queries["QRY_USER_ID"].Parameters.Find(x => x.Name == "P_USER_NM").Value = edtUserNM.Text;

              

                sqlDataSource1.Fill("QRY_USER_ID");

                DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_USER_ID"]);

                gridControl1.DataSource = dt;
                //gridProjectInfo.DataSource

                //if (dt.Rows[0]["CNT"].ToString() != "1")
                //{
                //    InfoMsg.Caption = "등록된 사용자가 아닙니다.";
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
               
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            b_Insert = true;

            gridView1.AddNewRow();
            gridView1.ShowEditForm();


        }

        private void gridView1_EditFormShowing(object sender, DevExpress.XtraGrid.Views.Grid.EditFormShowingEventArgs e)
        {

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

        private void editFormUpdateButton_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();
            
            try
            {

                if (b_Insert )
                {
                    //insert 버튼으로 열었으면 신규 추가를 시도하고

                    sqlDataSource1.Queries["INSERT_USER_ID"].Parameters.Find(x => x.Name == "P_USER_ID").Value = dr["USER_ID"].ToString();
                    sqlDataSource1.Queries["INSERT_USER_ID"].Parameters.Find(x => x.Name == "P_USER_NM").Value = dr["USER_NM"].ToString();
                    sqlDataSource1.Queries["INSERT_USER_ID"].Parameters.Find(x => x.Name == "P_MNGR_GRADE").Value = dr["MNGR_GRADE"].ToString();
                    sqlDataSource1.Queries["INSERT_USER_ID"].Parameters.Find(x => x.Name == "P_HP_NO").Value = dr["HP_NO"].ToString();
                    sqlDataSource1.Queries["INSERT_USER_ID"].Parameters.Find(x => x.Name == "P_TEL_NO").Value = dr["TEL_NO"].ToString();
                    sqlDataSource1.Queries["INSERT_USER_ID"].Parameters.Find(x => x.Name == "P_OFFICE_NO").Value = dr["OFFICE_NO"].ToString();
                    sqlDataSource1.Queries["INSERT_USER_ID"].Parameters.Find(x => x.Name == "P_PSWD").Value = dr["PSWD"].ToString();

                    SqlDataSource.DisableCustomQueryValidation = true;

                    sqlDataSource1.Fill("INSERT_USER_ID");
                }
                else
                {
                    //아닌 경우는 Update로 간주한다.

                    sqlDataSource1.Queries["UPDATE_USER_ID"].Parameters.Find(x => x.Name == "P_USER_ID").Value = dr["USER_ID"].ToString();
                    sqlDataSource1.Queries["UPDATE_USER_ID"].Parameters.Find(x => x.Name == "P_USER_NM").Value = dr["USER_NM"].ToString();
                    sqlDataSource1.Queries["UPDATE_USER_ID"].Parameters.Find(x => x.Name == "P_MNGR_GRADE").Value = dr["MNGR_GRADE"].ToString();
                    sqlDataSource1.Queries["UPDATE_USER_ID"].Parameters.Find(x => x.Name == "P_HP_NO").Value = dr["HP_NO"].ToString();
                    sqlDataSource1.Queries["UPDATE_USER_ID"].Parameters.Find(x => x.Name == "P_TEL_NO").Value = dr["TEL_NO"].ToString();
                    sqlDataSource1.Queries["UPDATE_USER_ID"].Parameters.Find(x => x.Name == "P_OFFICE_NO").Value = dr["OFFICE_NO"].ToString();
                    sqlDataSource1.Queries["UPDATE_USER_ID"].Parameters.Find(x => x.Name == "P_PSWD").Value = dr["PSWD"].ToString();

                    SqlDataSource.DisableCustomQueryValidation = true;

                    sqlDataSource1.Fill("UPDATE_USER_ID");
                }

            }
            catch (Exception ex)
            {

                MsgCaption.Caption = ex.Message;
            }
            finally
            {
                b_Insert = false;
            }
          
        }
    }
}
