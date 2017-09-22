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
        /// <summary>
        /// Kun til test!!!
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <param name="i3"></param>
        /// <param name="i4"></param>
        /// <param name="i5"></param>
        public YatzyBæger(int i1,int i2,int i3,int i4,int i5)
        {
            terninger[0] = new Terning(i1);
            terninger[1] = new Terning(i2);
            terninger[2] = new Terning(i3);
            terninger[3] = new Terning(i4);
            terninger[4] = new Terning(i5);
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
            if (Yatzy)
            {
                Console.WriteLine("Yatzy! Point:" + isYatzy());
            }
            Console.WriteLine("Hus: " + Hus);
            Console.WriteLine("Lille Strait: " + LilleStrait);
            Console.WriteLine("Store Strait: " + StoreStrait);
            Console.WriteLine("Fire ens: " + FireEns);
            Console.WriteLine("Tre ens: " + TreEns);
            Console.WriteLine("To par: " + ToPar);
            Console.WriteLine("Et par: " + ToPar);

        }
    }
}
