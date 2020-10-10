using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary
{
    public sealed class Log : ILog
    {
        private Log()
        {
        }
        //private static readonly Lazy<Log> instance = new Lazy<Log>();
        private static Log instance = null;
        public static Log GetInstance
        {
            get
            {
                if(instance == null)
                 instance = new Log();
                return instance;
            }
        }
        public void LogException(string message)
        {
            string fileName = string.Format("{0} {1}.log", "Exception", DateTime.Now.ToShortDateString());
            string filePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);   
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine(DateTime.Now.ToShortTimeString());
            sb.AppendLine(message);
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.Write(sb.ToString());
                sw.Flush();
            }
        }
    }

    public class stsParent
    {
        public static void Print()
        {
            Console.WriteLine("print");
        }
    }
    public static class stsChild : Object
    {
        public static void PrintC()
        {
            Console.WriteLine("printC");
        }
    }
}
