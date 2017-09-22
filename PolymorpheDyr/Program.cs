using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorpheDyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] dyrene = new Dyr[20];
            for (int i = 0; i < dyrene.Length; i++)
            {
                dyrene[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyrene)
            {
                item.SigNoget();
            }
        }

        public abstract class Dyr
        {
            static Random rnd = new Random();
            public static Dyr TilfældigtDyr()
            {
                string sti = @"X:\dyrenavne.txt";
                string[] navne = System.IO.File.ReadAllLines(sti);
                string n = navne[rnd.Next(0, navne.Length)];
                if (rnd.Next(0, 100)>50)
                {
                    return new Hund() { Navn = n };
                }
                else
                {
                    return new Kat() { Navn = n };
                }
            }

            public string Navn { get; set; }
            public abstract void SigNoget();
        }
        public class Hund : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine($"Jeg er en hund og hedder {Navn}");
            }
        }

        public class Kat : Dyr
        {

            public override void SigNoget()
            {
                Console.WriteLine($"Jeg er en kat og hedder {Navn}");
            }
        }
    }
}
