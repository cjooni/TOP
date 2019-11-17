using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TOP.Screen
{
    public partial class frmLoadPipeTool : TOP.Parent.PForm
    {
        public frmLoadPipeTool()
        {
            InitializeComponent();
        }

        //Pipe Tool 데이터를 Load 한다.
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                XtraOpenFileDialog Opendlg = new XtraOpenFileDialog();

                Opendlg.Filter = "EXCEL 파일 (*.xlsx)|*.xlsx|모든파일(*.*)|*.*";


                if (Opendlg.ShowDialog() == DialogResult.OK)
                {
                    string filename = Opendlg.FileName;

                    using (FileStream stream = new FileStream(filename, FileMode.Open))
                    {
                        ///EXCEL DATA를 Load 한다.
                        spread1.LoadDocument(stream, DocumentFormat.Xlsx);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
    }
}
