using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] løn = new int[] { 10000, 20000, 15000, 20000, 30000, 15000 };

            for (int i = 0; i < løn.Length; i++)
            {
                Console.WriteLine(løn[i]);
            }
            double avg = (double)løn.Sum() / løn.Length;
            Console.WriteLine("Gennemsnit "+ avg.ToString("N2"));

            var løn2 = løn.OrderBy(f => f).GroupBy(g => g);
            foreach (var item in løn2)
            {
                Console.WriteLine(item.Key + " antal: " +item.Count());
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
