namespace KTool.Controller
{
    //TODO: Log System
    class Log
    {
        public static void Error(string s) { }
        public static void Info(string s) { }
        public static void Warn(string s) { }
        public static void Debug(string s) { }

        public static void e(string s) => Error(s);
        public static void i(string s) => Info(s);
        public static void w(string s) => Warn(s);
        public static void d(string s) => Debug(s);
    }
}
