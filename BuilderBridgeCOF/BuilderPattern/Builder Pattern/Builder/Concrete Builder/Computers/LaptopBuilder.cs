using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder.Concrete_Builder.Computers
{
    /// <summary>
    /// A 'ConcreteBuilder' class
    /// Potentially complex creation of a laptop
    /// </summary>
    class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
            computer = new ProductData("Laptop");
        }
        public override void BuildCase()
        {
            computer["case"] = "Laptop Casing";
        }

        public override void BuildMotherboard()
        {
            computer["motherboard"] = "Laptop Motherboard";

        }

        public override void BuildProcessor()
        {
            computer["processor"] = "Laptop processor";

        }

        public override void BuildPowerSupply()
        {
            computer["powersupply"] = "Laptop power supply";

        }

        public override void BuildHardDrive()
        {
            computer["harddrive"] = "Laptop harddrive";

        }

        public override void BuildRam()
        {
            computer["ram"] = "6 gb";

        }

        public override void BuildOperatingSystem()
        {
            computer["os"] = "Windows 8";

        }

        public override void BuildAdditionalHardware()
        {
            computer["network"] = "Wifi";

        }

        public override void BuildDisplay()
        {
            computer["display"] = "Built in lcd";

        }

        public override void BuildInput()
        {
            computer["input"] = "built in keyboard";

        }
    }
}
