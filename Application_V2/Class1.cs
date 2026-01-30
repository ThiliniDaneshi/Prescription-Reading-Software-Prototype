using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Threading;
using System.Xml;

namespace Application_V2
{
    public class Class1
    {
        //public List<List<string>> medsubList = new List<List<string>>();
        
        public List<string> Noduplicates(List<string> alist)
        {
            for (int x =1; x < alist.Count; x++)      //remove duplicate names
            {
                if (alist[x - 1] == alist[x])
                {
                    alist.Remove(alist[x]);
                }
            }
            return alist;

        }
        public void Displaynames(List<string> nlist, ListView v)
        {
            for (int x = 1; x < nlist.Count; x++)      //remove duplicate names
            {
                v.Items.Add(nlist[x]);
            }
        }
    }
}
