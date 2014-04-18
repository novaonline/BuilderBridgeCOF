using BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstract
{
    class Business
    {
        protected Sale s;

        public Sale Sale
        { 
            set { Sale = value; } 
        }

        public virtual void Run()
        {
            s.buildProduct();
        }
    }
}
