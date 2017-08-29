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
            Console.WriteLine("Velkommen "+navn.ToUpper());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
