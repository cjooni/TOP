using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TOP.lib;

namespace TOP.Screen
{
    public partial class frmModifyPrj : TOP.Parent.PForm
    {
        public CPrjInfo PrjInfo;

        public frmModifyPrj()
        {
            InitializeComponent();

            PrjInfo = new CPrjInfo();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }



        private void qry_project_info()
        {
            sqlDataSource1.Fill("QRY_PROJECT_INFO");
            DataTable dt = CUtil.GetTable(sqlDataSource1.Result["QRY_PROJECT_INFO"]);
            gridControl1.DataSource = dt;
        }

        private void frmSelectPrj_Load(object sender, EventArgs e)
        {
            qry_project_info();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetFocusedDataRow();

                PrjInfo.ProjectCd = dr["PROJECT_CD"].ToString();
                PrjInfo.ProjectNm = dr["PROJECT_NM"].ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MsgCaption.Caption = ex.Message;
            }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
