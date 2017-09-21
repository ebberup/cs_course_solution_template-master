using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuMedBæger
{
    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get {
                //Console.WriteLine($"Fra Værdi er læst værdien {værdi}");
                return værdi; }
            set
            {
                if (value<1|| value > 6)
                {
                    value = 1;
                }
                this.værdi = value;
                //Console.WriteLine($"Værdi er tilskrevet med: [{Værdi}]");
            }
        }

        public Terning()
        {
            Ryst();
        }
        public Terning(int initVærdi)
        {
            Værdi = initVærdi;
        }
        private static Random rnd = new Random();

        public void Ryst()
        {
            værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[{Værdi}]");
        }
    }
}
