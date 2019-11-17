using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public class column
    {
        private string fieldName;
        private string caption;
        private bool visible;
        

        public string FieldName { get => fieldName; set => fieldName = value; }
        public string Caption { get => caption; set => caption = value; }
        public bool Visible { get => visible; set => visible = value; }

    }
    public class CColumnProp
    {
        public List<column> m_list;

        GridColumnCollection m_gcc;
        public  CColumnProp()
        {
            m_list = new List<column>();
        }

        public void SetList(GridColumnCollection gcc)
        {
            m_list.Clear();
            foreach (GridColumn item in gcc)
            {
                column col = new column();
                col.FieldName = item.FieldName;
                col.Caption = item.Caption;
                col.Visible = item.Visible;

                m_list.Add(col);
            }
        }

        public List<column> GetList()
        {
            return m_list;
        }

 
    }
}
