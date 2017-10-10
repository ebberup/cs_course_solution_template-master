using System.Collections.Generic;
using System.Linq;

namespace Module14_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(5);
            list1.Add(4);
            list1.Add(7);
            list1.Add(2);
            list1.Add(9);
            list1.Add(1);

            var res = (from i in list1 where (i > 3) select i);
            foreach (var item in res)
            {
                System.Console.WriteLine(item);
            }

            foreach (var item in list1.Where(i => i>3))
            {
                System.Console.WriteLine(item);
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
