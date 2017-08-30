using System;

namespace Module03_ValueTypes
{
    enum Køn { mand,kvinde};
    struct Person
    {
        public string navn;
        public Køn køn;
    }
    class Program
    {
        static void Main(string[] args)
        {

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();

            }
            var dato = DateTime.Now;
            Console.WriteLine(dato.ToString());
            var person = Køn.mand;
            var nå = Enum.TryParse("1", out person);

            Person persons = new Person() {navn="henning",køn=Køn.mand };
    }
}
        }
