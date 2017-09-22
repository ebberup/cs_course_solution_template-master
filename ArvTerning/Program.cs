using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
            LudoTerning l = new LudoTerning();
            l.Skriv();
            LudoTerning l2 = new LudoTerning(5);
            l2.Skriv();



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }

        public class Terning
        {
            private static Random rnd;
            static Terning()
            {
                rnd = new Random();
            }

            private int værdi;

            public int Værdi
            {
                get {
                    Console.Write("læses ");
                    return værdi;
                }
                set
                {
                    Console.Write("tilskrives ");
                    if (value<1||value>6)
                    {
                        value = 1;
                    }
                    værdi = value;
                }
            }

            public Terning()
            {
                Ryst();
            }

            public Terning(int værdi)
            {
                this.Værdi = værdi;
            }
            public void Ryst()
            {
                 Værdi = rnd.Next(1, 7);
            }

            public virtual void Skriv()
            {
                Console.WriteLine($"[{Værdi}]");
            }

        }

        class LudoTerning : Terning
        {
            public LudoTerning():base()
            {

            }
            public LudoTerning(int værdi):base(værdi)
            {

            }
            public bool ErGlobus()
            {
                return Værdi == 5;
            }
            public bool ErStjerne()
            {
                return Værdi == 3;
            }
            public override void Skriv()
            {
                string v = Værdi.ToString();
                if (ErGlobus())
                {
                    v = "Globus";
                }
                if (ErStjerne())
                {
                    v = "Stjerne";
                }
                Console.WriteLine($"[{v}]");
            }
        }
    }
}
