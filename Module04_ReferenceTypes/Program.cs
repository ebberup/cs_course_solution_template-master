namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonStruct p1;
            p1.Id = 1;
            p1.ErILive = true;

            PersonStruct p2 = new PersonStruct();
            p2.Id = 2;
            p2.ErILive = true;

            PersonClass p3 = new PersonClass() { Id = 3, ErILive = true };
            System.Console.WriteLine(p3.Id);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

            bool s = true;
            if (!s)
            {
                System.Console.WriteLine("her");
            }
        }
    }
    struct PersonStruct
    {
        public int Id;
        public bool ErILive;
    }
    class PersonClass
    {
        public int Id;
        public bool ErILive;
    }
}
