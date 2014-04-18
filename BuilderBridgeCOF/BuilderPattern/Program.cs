using BridgePattern.Abstraction;
using BridgePattern.Implementor;
using BuilderPattern.Builder;
using BuilderPattern.Builder.Concrete_Builder.Computers;
using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        //Side Note: At the moment a Shop can only produce 1 Product
        static void Main(string[] args)
        {
            // "Creating a Business" For Store A
            AbstractBusiness ShopABusiness = new ShopAProduction();
             
            //I'm setting Shop A to produduce a MotorCycle 
            ShopABusiness.Product = new VehicleProduct(new ScooterBuilder());
            
            // Show it
            ShopABusiness.Show();


            // Wait for user key input to terminate
            Console.ReadKey();
        }
    }
}
