using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    class Program
    {
        //static void AppendLog(string txt)
        //{
        //    System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        //}
        static void Main(string[] args)
        {
            Maskine machine = new Maskine();
            //machine.Log += AppendLog;
            //machine.Log += delegate (string txt) { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n"); };
            machine.Log += delegate (string txt) { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n"); };
            // fjern "delegate" og tilføj "=>"
            //machine.Log += (string txt) => { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n"); };
            // fjern type (den er bestemt af delegate'n)
            // fjern 
            machine.Log += t => System.IO.File.AppendAllText(@"c:\temp\log.txt", t + "\r\n"); 

            //machine.Log += Console.WriteLine;


            machine.Start();
            machine.Stop();
            Action<string> logging = t => System.IO.File.AppendAllText(@"c:\temp\log.txt", t + "\r\n");
            Maskine mm = new Maskine(logging);
            mm.Start();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
    public class Maskine
    {
        public Maskine()
        {

        }
        public Maskine(Action<string> log)
        {
            Log = log;
        }
        public Action<string> Log { get; set; }
        public void Start()
        {
            Log($"{DateTime.Now.ToLocalTime()} Starter");
        }
        public void Stop()
        {
            Log($"{DateTime.Now.ToLocalTime()} Stopper");
        }
    }
}
