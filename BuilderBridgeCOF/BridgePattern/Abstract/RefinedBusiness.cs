using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstract
{
    class RefinedBusiness : Business
    {
        public override void Run()
        {
            s.buildProduct();
        }
    }
}
