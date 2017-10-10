using System;

namespace Module12_Delegates
{
    class Program
    {
        public delegate void MinFunktionspointer();
        public delegate int BeregnerD(int a, int b);
        static void Main(string[] args)
        {
            MinFunktionspointer m = new MinFunktionspointer(Test1);
            //der findes ikke en m.Add()

            m += Test2;
            m.Invoke();
            
            //short for m2 = new MinFunktionspointer(Test2);
            MinFunktionspointer m2 = Test2;
            m2();


            Action p1 = Test1;
            p1();

            //Build in delegates
            Action<string> w = Console.WriteLine;
            Func<int, int, int> ff = Test3;

            //Anonym funktion
            Action<string> pp6 = delegate (string txt) { Console.WriteLine("Noget:" + txt); };

            pp6("Hej ");
            //nu med lambda
            pp6 += t =>
            {
                Console.WriteLine("Lambda: "+t);
            };

            //med to parametre
            Action<string, string> p7 = (p, c) =>
            {
                System.IO.File.WriteAllText(p, c);
            };

            //delegate(action), implicitte typer, anonym func, lambda
            int[] a = { 4, 6, 34, 7, 9 };
            var b = Array.FindAll(a, e => e > 10);

            //shot for m2.Invoke();

            BeregnerD b = Test3;
            BeregnerD regn =  FindBeregner();
            int i = regn(3, 6);
            var r = FindBeregner()(4, 4);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
        static void Test1()
        {
            System.Console.WriteLine("Test1");
        }
        static void Test2()
        {
            System.Console.WriteLine("Test2");
        }

        static int Test3(int a, int b)
        {
            return a + b;
        }
        public static BeregnerD FindBeregner()
        {
            return Test3;
        }
    }
}
