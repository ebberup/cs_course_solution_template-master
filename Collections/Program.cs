using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();
            personer.Add(new Person() { Id = 1, Navn = "Henning" });
            personer.Add(new Person() { Id = 2, Navn = "Henrik" });
            personer.Add(new Person() { Id = 3, Navn = "Helle" });

            foreach (var item in personer)
            {
                Console.WriteLine($"{item.Id}: {item.Navn}");
            }

            Dictionary<int, Person> dir = new Dictionary<int, Person>();
            dir.Add(11,new Person() { Id = 1, Navn = "Henning" });
            dir.Add(22, new Person() { Id = 2, Navn = "Henrik" });
            dir.Add(33,new Person() { Id = 3, Navn = "Helle" });

            Console.WriteLine($"{dir[22].Id}: {dir[22].Navn}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            try
            {
                var k = b.FjernKort();
                k = b.FjernKort();
                Console.WriteLine();
                Console.WriteLine(k);
                Console.WriteLine();
                k = b.FjernKort();
                k = b.FjernKort();
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }

            b.Vis();
      


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }


        class Person
        {
            public int Id { get; set; }
            public string Navn { get; set; }
        }

        public class Kort
        {
            public string Kulør { get; set; }
            public int Værdi { get; set; }
            public override string ToString()
            {
                return this.Kulør + " " + this.Værdi;
            }
        }

        public class Bunke
        {
            private Stack<Kort> kortbunke = new Stack<Kort>();
            public void TilføjKort(Kort k)
            {
                kortbunke.Push(k);
            }
            public Kort FjernKort()
            {
                if (kortbunke.Count==0)
                    throw new ApplicationException("Bunken er tom");
                return kortbunke.Pop();
            }

            public void Vis()
            {
                foreach (var item in kortbunke)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        } 
    }
}
