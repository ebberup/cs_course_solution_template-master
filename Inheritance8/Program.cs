using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance8
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            
            Console.WriteLine(r.NextBool());
        }

        public class UdvidetRandom : System.Random
        {
            private static Random rnd = new Random();
            public bool NextBool()
            {
                return rnd.Next(1, 1000) < 500;
            }

        }
    }
}
