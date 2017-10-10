using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    class Program
    {

        public class Kunde
        {
            public event EventHandler KreditOverskredet;
            public string Navn { get; set; }
            public int Saldo { get; set; }
            public int KreditMax { get; set; }

            public void Køb(int værdi)
            {
                Console.WriteLine("Kunde {0} køber for {1}",Navn,værdi);
                this.Saldo -= værdi;
                if (Saldo < KreditMax)
                {
                    KreditOverskredet?.Invoke(this, new EventArgs());
                }
            }

            
        }
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) => { Console.WriteLine("Kredit overskredet"); };

            Console.WriteLine(k.Saldo);
            k.Køb(100);
            Console.WriteLine(k.Saldo);
            k.Køb(100);
            Console.WriteLine(k.Saldo);
            k.Køb(100);
            Console.WriteLine(k.Saldo);
            k.Køb(100);
            Console.WriteLine(k.Saldo);
            k.Køb(100);
            Console.WriteLine(k.Saldo);
            k.Køb(100);
        }
    }
}
