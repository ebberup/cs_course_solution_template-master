using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            Console.WriteLine(fornavn);
            string efternavn = "Cronberg";
            Console.WriteLine(efternavn);

            string samletnavn = fornavn + " " + efternavn;
            Console.WriteLine(samletnavn);

            string navnStort = samletnavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletnavn.ToLower();
            Console.WriteLine(navnLille);
            string del = samletnavn.Substring(samletnavn.IndexOf("C"),4);
            Console.WriteLine(del);
            string[] split = samletnavn.Split(' ');
            for (int i = 0; i < split.Length; i++)
            {
                Console.WriteLine(split[i]);
            }
            Console.WriteLine("Fornavn: {0} \t Efternavn: {1}",split[0], split[1]);

            System.IO.File.WriteAllText(@"C:\Users\admin\Documents\navne.txt", samletnavn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
