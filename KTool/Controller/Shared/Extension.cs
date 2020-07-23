using System.Collections.Generic;

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
