using System;
using System.Diagnostics;
using System.IO;

namespace Domain
{
    public class Log
    {
        public static void Save(object obj, Exception ex)
        {
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            string hora = DateTime.Now.ToString("HH:mm:ss");

            StreamWriter sw = new StreamWriter(Path.Combine(ConfigGlobal.Instance.LogPath, fecha + ".txt"), true);

            StackTrace stacktrace = new StackTrace();
            sw.WriteLine(obj.GetType().FullName + " " + fecha + " " + hora);
            sw.WriteLine(stacktrace.GetFrame(1).GetMethod().Name + " - " + ex.Message);
            sw.WriteLine("");

            sw.Flush();
            sw.Close();
        }
    }
}
