using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuMedBæger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terning t = new Terning();
            //t.Skriv();
            //t.Ryst();
            //t.Skriv();
            //t.Værdi = 7;
            //t.Skriv();
            //t = new Terning(6);
            //t.Skriv();

            YatzyBæger b = new YatzyBæger();
            b.Skriv();
            b.Ryst();
            b.Skriv();

            //YatzyBæger d = new YatzyBæger(2, 2, 2, 4, 4);
            //Console.WriteLine(d.Yatzy);
            //Console.WriteLine(d.Hus);
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
