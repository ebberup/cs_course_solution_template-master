using Module_06_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person i;
            i = new Person("Henning",60,true);
            Console.WriteLine(i.ToString());
            Person u = new Person("Kirsti",54,true);
            Terning t = new Terning(4);
            t.Write();

        }
    }
}
