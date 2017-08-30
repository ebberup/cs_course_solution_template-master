using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    enum FilTyper
    {
        csv,
        pdf,
        txt
    }

    public struct Person
    {
        public int Id;
        public string Navn;
    }

    class PersonObj:IDisposable
    {
        public int Id;
        public string Navn;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            DateTime nu = DateTime.Now;
            Console.WriteLine(nu.ToShortDateString());
            Console.WriteLine(nu.ToLongDateString());
            Console.WriteLine(nu.ToString("ddMMyy"));

            Person p = new Person() { Id = 1, Navn = "Mikkel" };
            Console.WriteLine("Person Id: {0}, Navn: {1}",p.Id,p.Navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

            PersonObj p1 = new PersonObj() {Id=2,Navn="Hansen" };

            using (var p2 = new PersonObj())
            {
                p2.Id = 2;

            }

        }
    }
}
