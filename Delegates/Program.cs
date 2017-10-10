using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate int Beregn(int a, int b);
        
        static void Main(string[] args)
        {
            int res = Beregner(1, 1, Plus);
            Console.WriteLine(res);
            res = Beregner(1, 1, Minus);
            Console.WriteLine(res);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }

        public static int Beregner(int a, int b, Beregn f)
        {
            return f(a, b);
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}
