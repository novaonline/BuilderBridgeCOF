using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementor
{
    class ComputerSale : Sale
    {
        public override void buildProduct()
        {
            throw new NotImplementedException();
        }

        public override void sellProduct()
        {
            throw new NotImplementedException();
        }
    }
}
