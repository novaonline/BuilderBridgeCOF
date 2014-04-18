using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    /// <summary>
    /// A 'ConcreteBuilder' class
    /// Potentially complex creation of a Car
    /// </summary>
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new ProductData("Car");
        }
        public override void BuildFrame()
        {
            // Car specific frame build procedure
            vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            // Car specific Engine build procedure
            vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            // Car specific Wheel build
            vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            // Car specific door build
            vehicle["doors"] = "4";
        }
    }
}
