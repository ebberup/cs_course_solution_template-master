using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            //w.Changed += W_Changed;
            w.Changed += (s,e)=> Console.WriteLine($"Filen {e.FullPath} er rettet. opdaget af "+s.ToString());
            System.Console.ReadKey();

            //do
            //{
            //} while (true);
        }

        //private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        //{
        //    Console.WriteLine($"Filen {e.FullPath} er rettet");
        //}


    }
}
