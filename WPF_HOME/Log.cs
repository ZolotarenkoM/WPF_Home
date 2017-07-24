using System;
using System.IO;

namespace Home_expenses
{
    /// <summary>
    /// Class for saved log file
    /// </summary>
    class Log
    {
        public void Write(string mes)
        {
            DateTime time = DateTime.Now;
            string path = String.Format(AppDomain.CurrentDomain.BaseDirectory + "log.txt");
            using (StreamWriter logfile = new StreamWriter(path, true))
            {
                string str = string.Format("{0:yyyy-MM-dd HH:mm:ss} {1}", time, mes);
                logfile.WriteLine(str);
                logfile.Close();
            }
        }
    }
}
