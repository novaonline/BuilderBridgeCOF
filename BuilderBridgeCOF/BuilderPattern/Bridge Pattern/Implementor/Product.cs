using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementor
{
    /// <summary>
    /// The ConcreteImplementer's Base/Abstract Class - 
    /// ProductData vs. Product (this class)?
    /// ProductData = data Structure for products (dictionary of parts)
    /// Product = container for ProductData + Meta Data
    /// </summary>
    abstract class Product
    {
        public ProductData theProductData { get; set; }
        public DateTime Warrenty { get; set; }

        public abstract void price();

    }
}
