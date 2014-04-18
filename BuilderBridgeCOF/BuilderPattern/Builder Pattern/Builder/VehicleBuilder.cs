using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    /// <summary>
    /// The 'Builder' Class
    /// specifies an abstract interface 
    /// for creating parts of a Product data structure
    /// </summary>
    abstract class VehicleBuilder
    {
        protected ProductData vehicle;

        // Gets vehicle instance
        public ProductData Vehicle
        {

            get { return vehicle; }

        }

        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();

    }
}
