using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiskeMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregning.BeregnArealFirkant(10,10));
            Console.WriteLine(ArealBeregning.BeregnArealCirkel(10));
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
