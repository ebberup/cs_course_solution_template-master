using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < tal.Length; i++)
            {
                foreach (var item in tal)
                {
                    int res = item * (i + 1);
                    if (res>50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(res.ToString().PadLeft(4, ' '));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
