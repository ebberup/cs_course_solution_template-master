using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disposeNusing
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Navn = "Buller", Alder = 10 };
            hunde[1] = new Hund() { Navn = "Lady", Alder = 5 };

            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }

            using (StreamReader stream = File.OpenText(@"x:\dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn);
                }
            }
        }

        class Hund:IComparable
        {
            public string Navn { get; set; }
            public int Alder { get; set; }

            // jeg foretrækker denne metode
            //public int CompareTo(object obj)
            //{
            //    return Alder.CompareTo((obj as Hund).Alder);
            //}
            public int CompareTo(object obj)
            {
                if (this.Alder > (obj as Hund).Alder)
                    return 1;
                if (this.Alder < (obj as Hund).Alder)
                    return -1;
                return 0;
            }
        }
    }
}
