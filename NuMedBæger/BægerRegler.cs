using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuMedBæger
{
    partial class YatzyBæger
    {
        public bool Yatzy
        {
            get
            {
                int[] res = Evaluate();
                return (res.Max() == 5);
            }
        }

        //public bool Hus { get
        //    {
        //        int[] res = Evaluate();

        //        for (int i = 0; i < res.Length; i++)
        //        {
        //            int antal = terninger.Count(t => t.Værdi.Equals(i));

                    
                    
        //        }
        //        return 

        //    }
        //}

        private int[] Evaluate()
        {
            int[] res = new int[5];
            for (int i = 1; i < 7; i++)
            {
               res[i]  = terninger.Count(t => t.Værdi.Equals(i));
            }
            return res;
        }
    }

}
