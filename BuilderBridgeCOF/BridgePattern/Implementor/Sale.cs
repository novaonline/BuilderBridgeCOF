using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementor
{
    abstract class Sale
    {
        protected float price;

        public abstract void buildProduct();
        public abstract void sellProduct();
    }
}
