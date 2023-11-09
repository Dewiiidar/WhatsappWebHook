using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WhatsappWebHook.Models
{
    
    public class LogManager
    {
        public static void LogIntoLogFile(string msg)
        {
            try
            {
                string logpass = "";
                try
                {
                    //logpass = System.Web.Hosting.HostingEnvironment.MapPath("~/logs/" + DateTime.Now.ToString("MM-dd-yyyy"));
                    logpass = "c:/logs/" + DateTime.Now.ToString("MM - dd - yyyy");
                }
                catch (Exception)
                {
                    logpass = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/logs/" + DateTime.Now.ToString("MM-dd-yyyy");
                }
                Console.WriteLine(msg);
                if (!Directory.Exists(logpass))
                    Directory.CreateDirectory(logpass);
                FileStream fs = null;
                if (!File.Exists(logpass + "\\Log.txt"))
                {
                    fs = File.Create(logpass + "\\Log.txt");
                    fs.Close();
                }
                StreamWriter sw = File.AppendText(logpass + "\\log.txt");
                sw.WriteLine("============================" + DateTime.Now.ToString() + "==============================================");
                sw.WriteLine(msg);
                sw.WriteLine("==========================================================================");
                sw.Close();
            }
            catch
            {

            }
        }
    }
}