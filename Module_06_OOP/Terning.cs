using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_06_OOP
{
    public class Terning
    {
        private int value;
        public Terning()
        {
            this.value = 1;
        }
        public Terning(int startvalue)
        {
            if (startvalue < 1 || startvalue > 6)
            {
                throw new Exception("Must be between 1 and 6");
            }

            this.value = startvalue;
        }

        /// <summary>
        /// Skriver terning værdi
        /// </summary>
        public void Write()
        {
            Console.WriteLine("["+this.value+"]");
        }
    }
}
