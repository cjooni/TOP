using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using TOP.lib;

namespace TOP.Dialog
{
    public partial class frmClient : TOP.Parent.PForm
    {
        private bool b_Insert = false;

        public frmClient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Client (업체) 정보를 조회한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQryClient_Click(object sender, EventArgs e)
        {
            QryClient();
        }

        private void QryClient()
        {
            try
            {
                sqlDataSource1.Queries["QRY_CLIENT"].Parameters.Find(x => x.Name == "P_CLIENT_NM").Value = edtClientNm.Text;
                sqlDataSource1.Queries["QRY_CLIENT"].Parameters.Find(x => x.Name == "P_ADDRESS").Value = edtAddress.Text;

                sqlDataSource1.Fill("QRY_CLIENT");

                DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_CLIENT"]);

                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            b_Insert = true;

            gridView1.AddNewRow();
            gridView1.ShowEditForm();
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
                if (b_Insert)
                {
                    //insert 버튼으로 열었으면 신규 추가를 시도하고

                    sqlDataSource1.Queries["INSERT_CLIENT"].Parameters.Find(x => x.Name == "P_CLIENT_NM").Value = dr["CLIENT_NM"].ToString();
                    sqlDataSource1.Queries["INSERT_CLIENT"].Parameters.Find(x => x.Name == "P_OFFICE").Value = dr["OFFICE"].ToString();
                    sqlDataSource1.Queries["INSERT_CLIENT"].Parameters.Find(x => x.Name == "P_ADDRESS").Value = dr["ADDRESS"].ToString();

                    SqlDataSource.DisableCustomQueryValidation = true;

                    sqlDataSource1.Fill("INSERT_CLIENT");
                }
                else
                {
                    //아닌 경우는 Update로 간주한다.

                    sqlDataSource1.Queries["UPDATE_CLIENT"].Parameters.Find(x => x.Name == "P_CLIENT_NM").Value = dr["CLIENT_NM"].ToString();
                    sqlDataSource1.Queries["UPDATE_CLIENT"].Parameters.Find(x => x.Name == "P_OFFICE").Value = dr["OFFICE"].ToString();
                    sqlDataSource1.Queries["UPDATE_CLIENT"].Parameters.Find(x => x.Name == "P_ADDRESS").Value = dr["ADDRESS"].ToString();
                    sqlDataSource1.Queries["UPDATE_CLIENT"].Parameters.Find(x => x.Name == "P_CLIENT_CD").Value = dr["CLIENT_CD"].ToString();

                    SqlDataSource.DisableCustomQueryValidation = true;

                    sqlDataSource1.Fill("UPDATE_CLIENT");
                }
            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.InnerException.InnerException.InnerException.Message;
            }
            finally
            {
                b_Insert = false;
            }
        }
    }
}