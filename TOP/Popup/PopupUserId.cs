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
    public partial class PopupUserId : TOP.Parent.PForm
    {
        private DataRow dr;

        public DataRow Dr { get => dr; set => dr = value; }

        public PopupUserId()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QryData();
        }


        private void QryData()
        {
            MsgCaption.Caption = "";

            try
            {
                sqlDataSource1.Queries["QUERY"].Parameters.Find(x => x.Name == "P_USER_NM").Value = edtUserNm.Text;

                sqlDataSource1.Fill("QUERY");

                DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QUERY"]);

                gridControl1.DataSource = dt;

            }
            catch (Exception ex)
            {

                MsgCaption.Caption = ex.Message;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Dr = gridView1.GetFocusedDataRow();

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
