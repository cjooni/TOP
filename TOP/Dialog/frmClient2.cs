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
    public partial class frmClient2 : TOP.Parent.PForm
    {
        private bool b_Insert = false;
        public frmClient2()
        {
            InitializeComponent();
        }

        private void QryDutyCd()
        {
            try
            {
                sqlDataSource1.Fill("QRY_DUTY");

                DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_DUTY"]);

                repositoryItemLookUpEdit1.DataSource = dt;
                repositoryItemLookUpEdit1.DisplayMember = "CD_VAL";
                repositoryItemLookUpEdit1.ValueMember = "CD";
                repositoryItemLookUpEdit1.KeyMember = "CD";
               // gridControl2.DataSource = dt;
            }
            catch (Exception ex)
            {

                MsgCaption.Caption = ex.Message;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QryDutyCd();
            QryClient();
        }


        private void QryClient()
        {
            MsgCaption.Caption = "";

            try
            {
                sqlDataSource1.Queries["QRY_CLIENT"].Parameters.Find(x => x.Name == "P_CLIENT_NM").Value = edtClientNm.Text;
  

                sqlDataSource1.Fill("QRY_CLIENT");

                DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_CLIENT"]);

                gridControl1.DataSource = dt;
               // gridView1.PopulateColumns(dt);
            }
            catch (Exception ex)
            {

                MsgCaption.Caption = ex.Message;
            }

        }

        /// <summary>
        /// 회원사 항목을 따블클릭 했을때 회원을 조회한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            QryClient2();
        }


        /// <summary>
        /// 회원정보 또는 고객 정보를 조회한다. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {

            QryClient2();

        }

        private void QryClient2()
        {
            MsgCaption.Caption = "";

            DataRow dr = gridView1.GetFocusedDataRow();
            
            if (dr == null)
            {
                MessageBox.Show("선택된 고객사 항목이 없습니다.");
                return;
            }

            try
            {
                sqlDataSource1.Queries["QRY_CLIENT2"].Parameters.Find(x => x.Name == "P_CLIENT_CD").Value = dr["CLIENT_CD"];
                sqlDataSource1.Queries["QRY_CLIENT2"].Parameters.Find(x => x.Name == "P_CLIENT_ID_NM").Value = edtClientNm.Text;
                sqlDataSource1.Queries["QRY_CLIENT2"].Parameters.Find(x => x.Name == "P_HP").Value = edtHP.Text;
                sqlDataSource1.Queries["QRY_CLIENT2"].Parameters.Find(x => x.Name == "P_OFFICE").Value = edtOffice.Text;
                sqlDataSource1.Queries["QRY_CLIENT2"].Parameters.Find(x => x.Name == "P_EMAIL").Value = edtEMail.Text;

                sqlDataSource1.Fill("QRY_CLIENT2");

                DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_CLIENT2"]);

                gridControl2.DataSource = dt;
            }
            catch (Exception ex)
            {

                MsgCaption.Caption = ex.Message;
            }
        }

        /// <summary>
        /// 신규 회원을 등록한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MsgCaption.Caption = "";
            b_Insert = true;

            gridView2.AddNewRow();
            gridView2.ShowEditForm();
        }

        private void gridView2_ShowingPopupEditForm(object sender, DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs e)
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
            DataRow dr1 = gridView1.GetFocusedDataRow();
            DataRow dr2 = gridView2.GetFocusedDataRow();

            if (dr1 == null)
            {
                MsgCaption.Caption = "선택된 회원사 항목이 없습니다.";
                return;
            }
            try
            {

                if (b_Insert)
                {
                    //insert 버튼으로 열었으면 신규 추가를 시도하고

                   
                    sqlDataSource1.Queries["INSERT_CLIENT2"].Parameters.Find(x => x.Name == "P_CLIENT_CD").Value = dr1["CLIENT_CD"];
                    sqlDataSource1.Queries["INSERT_CLIENT2"].Parameters.Find(x => x.Name == "P_EMAIL").Value = dr2["OFFICE"].ToString();
                    sqlDataSource1.Queries["INSERT_CLIENT2"].Parameters.Find(x => x.Name == "P_HP").Value = dr2["HP"].ToString();
                    sqlDataSource1.Queries["INSERT_CLIENT2"].Parameters.Find(x => x.Name == "P_OFFICE").Value = dr2["OFFICE"].ToString();
                    sqlDataSource1.Queries["INSERT_CLIENT2"].Parameters.Find(x => x.Name == "P_CLIENT_ID_NM").Value = dr2["CLIENT_ID_NM"].ToString();
                    sqlDataSource1.Queries["INSERT_CLIENT2"].Parameters.Find(x => x.Name == "P_POSITION").Value = dr2["POSITION"].ToString();

                    SqlDataSource.DisableCustomQueryValidation = true;
                    
                    sqlDataSource1.Fill("INSERT_CLIENT2");
                }
                else
                {
                    //아닌 경우는 Update로 간주한다.

                    sqlDataSource1.Queries["UPDATE_CLIENT2"].Parameters.Find(x => x.Name == "P_CLIENT_CD").Value = dr1["CLIENT_CD"];
                    sqlDataSource1.Queries["UPDATE_CLIENT2"].Parameters.Find(x => x.Name == "P_CLIENT_ID").Value = dr2["CLIENT_ID"];
                    sqlDataSource1.Queries["UPDATE_CLIENT2"].Parameters.Find(x => x.Name == "P_EMAIL").Value = dr2["OFFICE"].ToString();
                    sqlDataSource1.Queries["UPDATE_CLIENT2"].Parameters.Find(x => x.Name == "P_HP").Value = dr2["HP"].ToString();
                    sqlDataSource1.Queries["UPDATE_CLIENT2"].Parameters.Find(x => x.Name == "P_OFFICE").Value = dr2["OFFICE"].ToString();
                    sqlDataSource1.Queries["UPDATE_CLIENT2"].Parameters.Find(x => x.Name == "P_CLIENT_ID_NM").Value = dr2["CLIENT_ID_NM"].ToString();
                    sqlDataSource1.Queries["UPDATE_CLIENT2"].Parameters.Find(x => x.Name == "P_POSITION").Value = dr2["POSITION"].ToString();


                    SqlDataSource.DisableCustomQueryValidation = true;

                    sqlDataSource1.Fill("UPDATE_CLIENT2");
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
