using BuilderPattern;
using BuilderPattern.Builder;
using BuilderPattern.Builder.Concrete_Builder.Computers;
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
    class ComputerProduct : Product
    {
        public ComputerProduct(ComputerBuilder theBuilder)
        {
            // Create director for the computerBuilder
            ComputerDirector director = new ComputerDirector();

            theProductData = director.Construct(theBuilder);

        }

        // ignore
        public override void price()
        {
            throw new NotImplementedException();
        }
    }
}
