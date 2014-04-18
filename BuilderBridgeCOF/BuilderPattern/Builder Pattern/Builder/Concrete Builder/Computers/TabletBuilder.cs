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
    /// Potentially complex creation of a tablet
    /// </summary>
    class TabletBuilder : ComputerBuilder
    {
        public TabletBuilder()
        {
            computer = new ProductData("Tablet");
        }
        public override void BuildCase()
        {
            computer["case"] = "Tablet Casing";
        }

        public override void BuildMotherboard()
        {
            computer["motherboard"] = "Tablet Motherboard";

        }

        public override void BuildProcessor()
        {
            computer["processor"] = "Tablet processor";

        }

        public override void BuildPowerSupply()
        {
            computer["powersupply"] = "Desktop power supply";

        }

        public override void BuildHardDrive()
        {
            computer["harddrive"] = "Tablet harddrive";

        }

        public override void BuildRam()
        {
            computer["ram"] = "4 gb";

        }

        public override void BuildOperatingSystem()
        {
            computer["os"] = "Windows 8 RT";

        }

        public override void BuildAdditionalHardware()
        {
            computer["network"] = "3G";
            computer["gps"] = "available";
            computer["tapsend"] = "available";

        }

        public override void BuildDisplay()
        {
            computer["display"] = "Built in";

        }

        public override void BuildInput()
        {
            computer["input"] = "Touch";

        }
    }
}
