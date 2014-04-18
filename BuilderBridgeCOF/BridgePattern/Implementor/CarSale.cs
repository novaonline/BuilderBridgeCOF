using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementor
{
    class CarSale : Sale
    {

        public override void buildProduct()
        {
            VehicleBuilder builder;

            // Create shop with vehicle builders
            VehicleShop shop = new VehicleShop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            Vehicle Scooter = shop.Construct(builder);
            Scooter.Show();

            builder = new CarBuilder();
            Vehicle Car = shop.Construct(builder);
            Car.Show();

            builder = new MotorCycleBuilder();
            Vehicle MotorCycle = shop.Construct(builder);
            MotorCycle.Show();
        }

        public override void sellProduct()
        {
            throw new NotImplementedException();
        }
    }
}
