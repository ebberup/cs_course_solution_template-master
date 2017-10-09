using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigAgent
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValueConfigContainer container = new KeyValueConfigContainer();
            foreach (var line in container.LineCollection.Where(f => f.LineType==LineTypeEnum.KeyValue))
            {

            }
            //configuration.ConfigurationList
        }
    }
}
