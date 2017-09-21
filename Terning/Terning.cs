using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningProj
{
    class Terning
    {
        public int værdi;
        private bool snyd;
        private static System.Random rnd = new Random();

        public Terning():this(false)
        {
        }

        public Terning(bool snyd)
        {
            this.snyd = snyd;
            værdi = 1;
        }
        public void Skriv()
        {
            Console.WriteLine("["+this.værdi+"]");
        }

        public void Ryst()
        {
            if (snyd)
            {
                this.værdi = 6;
            }
            else
            {
                this.værdi = rnd.Next(1, 7);
            }

        }
    }
}
