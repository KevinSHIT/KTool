using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTool.Controller.Shared
{
    static class Extension
    {
        public static string ToListString(this List<string> l)
        {
            string s = "";
            for (int i = 0; i < l.Count; ++i)
            {
                s += l[i] + "\r\n";
            }
            return s;
        }
    }
}
