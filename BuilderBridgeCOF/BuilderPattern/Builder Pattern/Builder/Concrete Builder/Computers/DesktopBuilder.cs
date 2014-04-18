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
    /// Potentially complex creation of a Desktop
    /// </summary>
    class DesktopBuilder : ComputerBuilder
    {
        public DesktopBuilder()
        {
            computer = new ProductData("Desktop");
        }
        public override void BuildCase()
        {
            computer["case"] = "Desktop Casing";
        }

        public override void BuildMotherboard()
        {
            computer["motherboard"] = "Desktop Motherboard";

        }

        public override void BuildProcessor()
        {
            computer["processor"] = "Desktop processor";

        }

        public override void BuildPowerSupply()
        {
            computer["powersupply"] = "Desktop power supply";

        }

        public override void BuildHardDrive()
        {
            computer["harddrive"] = "Desktop harddrive";

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
            computer["network"] = "Ethernet";

        }

        public override void BuildDisplay()
        {
            computer["display"] = "Monitor";

        }

        public override void BuildInput()
        {
            computer["input"] = "keyboard";

        }
    }
}
