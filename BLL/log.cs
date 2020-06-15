using System;
using System.Configuration;
using System.IO;

namespace BLL
{
    public class log
    {
        private string Path = ConfigurationManager.AppSettings["PathLog"];

        public void Add(string sLog)
        {
            string nombre = GetNameFile();
            string cadena = "";

            cadena += DateTime.Now + " - " + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);
            sw.Write(cadena);
            sw.Close();

        }
        private string GetNameFile()
        {
            string nombre = "";

            nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";

            return nombre;
        }
    }

}
