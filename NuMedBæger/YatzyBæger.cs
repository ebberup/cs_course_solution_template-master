using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuMedBæger
{
    partial class YatzyBæger
    {
        private Terning[] terninger = new Terning[5];

        public YatzyBæger()
        {
            for (int i = 0; i < terninger.Length; i++)
            {
                terninger[i] = new Terning();
            }   
        }

        public void Ryst()
        {
            Console.WriteLine("Ryster...");
            for (int i = 0; i < terninger.Length; i++)
            {
                terninger[i].Ryst();
            }
        }

        public void Skriv()
        {
            for (int i = 0; i < terninger.Length; i++)
            {
                Console.Write($"[{terninger[i].Værdi}]");
            }
            Console.WriteLine();

        }
    }
}
