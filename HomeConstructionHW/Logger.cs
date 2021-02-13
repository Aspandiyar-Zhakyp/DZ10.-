using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace HomeConstructionHW
{
    public class Logger
    {
        public Logger() { }
        private static object sync = new object();
        public void Write(Exception ex)
        {
            string UserName = Environment.UserName;
            string PathToIni = Path.Combine("Ini.txt");
            string FileName = Path.Combine("Logger.txt");
            using (var stream = new StreamReader(PathToIni))
            {
                string text = stream.ReadLine() + "\n";
                string FullText = string.Format(text, DateTime.Now, ex.TargetSite.DeclaringType,
                ex.TargetSite.Name, UserName, ex.Message);
                lock (sync)
                { File.AppendAllText(FileName, FullText, Encoding.GetEncoding("Windows-1251")); }
            }

        }
    }
}
