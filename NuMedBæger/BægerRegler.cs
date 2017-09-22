using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuMedBæger
{
    partial class YatzyBæger
    {
        public int isYatzy()
        {
                int[] res = Evaluate();
                if (res.Contains(5))
                    return 50;
                else
                    return 0;
        }


        public bool Yatzy
        {
            get
            {
                int[] res = Evaluate();
                return (res.Contains(5));
            }
        }

        public bool Hus
        {
            get
            {
                int[] res = Evaluate();
                return (res.Contains(3) && res.Contains(2));
            }
        }
        public bool FireEns
        {
            get
            {
                int[] res = Evaluate();
                return (res.Contains(4)||Yatzy);
            }
        }
        public bool TreEns
        {
            get
            {
                int[] res = Evaluate();
                return (res.Contains(3)||FireEns||Yatzy);
            }
        }
        public bool LilleStrait
        {
            get
            {
                int[] res = Evaluate();
                return (res.Max().Equals(1)&& res[5].Equals(0));
            }
        }
        public bool StoreStrait
        {
            get
            {
                int[] res = Evaluate();
                return (res.Max().Equals(1) && res[0].Equals(0));
            }
        }
        public bool ToPar
        {
            get
            {
                int[] res = Evaluate();
                return (res.Count(p => p==2)==2)||Hus || Yatzy;
            }
        }
        public bool EtPar
        {
            get
            {
                int[] res = Evaluate();
                return (res.Contains(2) || TreEns || FireEns || Yatzy);
            }
        }

        private int[] Evaluate()
        {
            int[] res = new int[6];
            for (int i = 1; i < 7; i++)
            {
               res[i-1]  = terninger.Count(t => t.Værdi.Equals(i));
            }
            return res;
        }
    }

}
