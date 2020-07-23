namespace KTool.Controller
{
    class CoreControl
    {
        public static bool Set(int i)
        {
            if (i < 1) return Remove();
            var l = Shared.Cmd.GetOutput("bcdedit.exe", "/set {current} numproc " + i);
            if (l.Count > 0) return false;
            return true;
        }

        public static bool Remove()
        {
            var l = Shared.Cmd.GetOutput("bcdedit.exe", "/deletevalue {current} numproc");
            if (l.Count > 0) return false;
            return true;
        }

        public static int GetCurrentStatus()
        {
            var l = Shared.Cmd.GetOutput("bcdedit.exe", "/enum {current}");

            string x = "0";
            for (int i = 0; i < l.Count; ++i)
            {
                x = l[i].Trim();
                if (x.StartsWith("numproc"))
                {
                    x = x.Replace("numproc", "").Trim();
                    break;
                }
                x = "0";
            }
            return int.Parse(x);
        }
    }
}
