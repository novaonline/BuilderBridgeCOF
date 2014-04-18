using BuilderPattern;
using BuilderPattern.Builder;
using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementor
{
    /// <summary>
    /// implements the Implementor interface 
    /// and defines its concrete implementation
    /// </summary>
    class VehicleProduct : Product
    {
        public VehicleProduct(VehicleBuilder theBuilder)
        {
            // Create director for the vehicle builders
            VehicleDirector director = new VehicleDirector();

            // theProductData was inherited
            theProductData = director.Construct(theBuilder);

        }

        // ignore
        public override void price()
        {
            throw new NotImplementedException();
        }
    }
}
