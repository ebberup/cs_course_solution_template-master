using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            var navn = Console.ReadLine();
            var NAVN = navn.ToUpper();
            UdskrivVelkomst(NAVN);
        }
        public static void UdskrivVelkomst(string navn)
        {
            Console.WriteLine("Velkommen " + navn);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
