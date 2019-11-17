using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOP.Parent;

namespace TOP.lib
{

    public class CPageData
    {
        string m_asmName; //assembly Name
        string m_caption; //화면명 
        XtraTabPage m_TabPag; //Page Control 자체
        PForm m_Form;
        public CPageData()
        {


        }

        public string AsmName { get => m_asmName; set => m_asmName = value; }
        public string Caption { get => m_caption; set => m_caption = value; }
        public XtraTabPage TabPag { get => m_TabPag; set => m_TabPag = value; }
        public PForm Form { get => m_Form; set => m_Form = value; }
    }

    public class CPageMngr
    {
        private List<CPageData> list;

        public CPageMngr()
        {
            list = new List<CPageData>();
        }

        public void AddPage(CPageData data)
        {
            list.Add(data);    
        }

        public CPageData GetPageByName(string Name)
        {
            return List.Find(x => x.AsmName.Equals(Name));
        }

        public CPageData GetPageByCaptoin(string Caption)
        {
            return List.Find(x => x.Caption.Equals(Caption));
        }

        public CPageData GetPageByTabPage(XtraTabPage page)
        {
            return List.Find(x => x.TabPag.Equals(page));
        }

        public void RemovePageByName(string Name)
        {
            List.Remove(List.Find(x => x.AsmName.Equals(Name)));
        }

        public void RemovePageByCaption(string Caption)
        {
            List.Remove(List.Find(x => x.Caption.Equals(Caption)));
        }

        public void RemovePageByPage(XtraTabPage page)
        {
            List.Remove(List.Find(x => x.TabPag.Equals(page)));
        }

        public List<CPageData> List { get => list; set => list = value; }
    }
}
