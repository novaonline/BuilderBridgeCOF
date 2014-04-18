using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Handler.Concrete_Handler
{
    class CompactView : View
    {
        public override void show(string type, Dictionary<string, string> dict)
        {
            if (dict.Count <= 5)
            {
                Console.WriteLine("\n-{0}-", type);
                foreach (KeyValuePair<string, string> val in dict)
                {
                    Console.Write(" {0}: {1} \n", val.Key, val.Value);
                }
                Console.WriteLine("--");
            }
            else if (successor != null)
            {
                successor.show(type, dict);
            }
        }
    }
}
