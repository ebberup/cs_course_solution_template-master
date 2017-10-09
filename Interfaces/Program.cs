using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFundtioner[] o = new IDbFundtioner[2];
            o[0] = new Hund();
            o[1] = new Ubåd();
            foreach (var item in o)
            {
                item.Gem();
            }
        }

        interface IDbFundtioner
        {
            void Gem();

        }
        class Hund: IDbFundtioner
        {
            public string Navn { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer hund ...");
            }
        }
        class Ubåd : IDbFundtioner
        {
            public int Nummer { get; set; }
            public double Turbine { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer ubåd ...");
            }
        }


    }
}
