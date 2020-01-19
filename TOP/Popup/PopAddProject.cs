using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TOP.lib;

namespace TOP.Popup
{
    public partial class PopAddProject : TOP.Parent.PForm
    {
        DataRow m_Dr;

        public PopAddProject()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dialog 동작시 전달 데이터
        /// </summary>
        public DataRow Dr { get => m_Dr; set => m_Dr = value; }

        private void btnQry_Click(object sender, EventArgs e)
        {
            QryData();
        }


        private void QryData()
        {
            MsgCaption.Caption = "";

            try
            {
                sqlDataSource1.Queries["Query"].Parameters.Find(x => x.Name == "P_CLIENT_NM").Value = edtClientNm.Text;
                sqlDataSource1.Queries["Query"].Parameters.Find(x => x.Name == "P_CLIENT_ID_NM").Value = edtClientIdNm.Text;


                sqlDataSource1.Fill("Query");

                DataTable dt = CUtil.GetTable(sqlDataSource1.Result["Query"]);

                gridControl1.DataSource = dt;
                
            }
            catch (Exception ex)
            {

                MsgCaption.Caption = ex.Message;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void gridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            Dr = gridView1.GetFocusedDataRow();

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
