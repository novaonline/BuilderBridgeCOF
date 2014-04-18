using BuilderPattern.Builder;
using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// The 'Director' Class
    /// Director class is not necessary,
    /// but it is recommended to make sure the important parts are built.
    /// constructs an object using the Builder interface
    /// </summary>
    class VehicleDirector
    {
        /// <summary>
        /// Builder uses a complex series of steps 
        /// </summary>
        /// <param name="vehicleBuilder"> The abstract builder class </param>
        public ProductData Construct(VehicleBuilder vehicleBuilder)
        {
            // The steps to "streamline" the building process
            // Director class is not neccassary 
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
            return vehicleBuilder.Vehicle;
        }

    }
}
