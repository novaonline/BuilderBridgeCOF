using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Handler
{
    /// <summary>
    /// The 'Handler' Class
    /// defines an interface for handling the requests 
    /// (optional) implements the successor link
    /// In our case, the COF Client side implements the successor link 
    /// </summary>
    abstract class View
    {
        protected View successor;

        public void setSuccessor(View successor)
        {
            this.successor = successor;
        }

        // this is probably not the best way to do it, but I'll pass in a dictionary to show
        public abstract void show(string type, Dictionary<string, string> dict);
    }
}
