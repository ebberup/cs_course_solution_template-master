using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05_brushup
{
    class Program
    {
        public struct ResultStruct
        {
            public int sum;
            public decimal avg;
        }

        static void Main(string[] args)
        {

            int[] v = { 2, 5, 4, 7, 4, 2, 5, 9 };
            ResultStruct r = ProcArray(v);
            Console.WriteLine(r.sum);
            Console.WriteLine(r.avg.ToString("N2"));
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
        public static ResultStruct ProcArray(int[] values)
        {
            ResultStruct res;
            res.sum = 0;
            res.avg = 0;
            for (int i = 0; i < values.Length; i++)
            {
                res.sum += values[i];
            }
            res.avg = res.sum / values.Length;
            values[0] = 10000;
            return res;
        }
    }
}
