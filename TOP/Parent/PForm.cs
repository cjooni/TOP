using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using TOP.Screen;
using DevExpress.XtraTab;

namespace TOP.Parent
{
    public partial class PForm : DevExpress.XtraEditors.XtraForm
    {
        private GridView gridView;
        private GridControl gridControl;

        public LoadChkDataEventHandler LoadChkDataEvent;
             

        public GridView GridView { get => gridView; set => gridView = value; }
        public GridControl GridControl { get => gridControl; set => gridControl = value; }
        public void ChkColumn(DataRow DR)
        {


            GridView.Columns.ColumnByFieldName(DR["FIELD"].ToString()).Visible = Convert.ToBoolean(DR["CHECK"]);

            //GridColumnCollection gcc = (GridColumnCollection)GridView.Columns.Where(x => x.Visible == true);

            int i = 0;
            
            foreach (GridColumn item in GridView.Columns.Where(x=> x.Visible == true).OrderBy(x => x.AbsoluteIndex))
            {

                item.VisibleIndex = i;
                i++;
            }

        }


        public PForm()
        {

            
            InitializeComponent();

           
        }

        private void PForm_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.Parent.GetType() == typeof(XtraTabPage))
                {
                    LoadChkDataEvent(GridView);
                }
            }
            catch (Exception ex)
            {

            }
        }


        /// <summary>
        /// check 해서 숨기거나 나타낼 그리드 컬럼을 나타낸다.
        /// </summary>
        /// <param name="page"></param>
        private void DrawChkColumns()
        {

            //try
            //{
               
            //    m_chkView.Columns.Clear();

            //    DataTable dt = new DataTable();

            //    dt.Columns.Add("CHECK", typeof(bool));
            //    dt.Columns.Add("CAPTION", typeof(string));
            //    dt.Columns.Add("FIELD", typeof(string));

            //    foreach (GridColumn item in GridView.Columns)
            //    {
            //        DataRow dr = dt.Rows.Add();
            //        dr["CHECK"] = item.Visible;
            //        dr["CAPTION"] = item.Caption;
            //        dr["FIELD"] = item.FieldName;
            //    }

            //    m_chkView.GridControl.DataSource = dt;
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message); ;
            //}
        }
    }
}