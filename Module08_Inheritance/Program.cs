namespace Module08_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person o1 = new Person() { Navn = "Henning" };
            o1.Print();

            Student s1 = new Student() { Navn = "Birthe" };
            s1.Print();
            s1.BookEksamen();

            Instruktør i1 = new Instruktør { Navn = "Mikkel", Nøgle = 4 };
            o1.Print();
            i1.KørLøn();

            HjælpeInstruktør h1 = new HjælpeInstruktør { Navn = "Anders", MidlertidigNøgle = 2 };

            Person p1 = new HjælpeInstruktør() { MidlertidigNøgle = 32 };
            (p1 as HjælpeInstruktør).Nøgle = 3;
            System.Console.WriteLine(p1);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }

    class Person
    {
        public string Navn { get; set; }
        public void Print()
        {
            System.Console.WriteLine($"Jeg er en person der hedder {Navn}");
        }
    }
    class Student : Person
    {
        public int StudentId { get; set; }
        public void BookEksamen() { }
    }
    class Instruktør : Person {
        public int Nøgle { get; set; }
        public void KørLøn() { }
    }
    sealed class HjælpeInstruktør : Instruktør {
        public int MidlertidigNøgle { get; set; }
        public void FindKlasse() { }

    }
}
