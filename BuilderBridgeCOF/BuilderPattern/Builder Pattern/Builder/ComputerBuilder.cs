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
    abstract class ComputerBuilder
    {
        protected ProductData computer;

        // Getter function Computer
        public ProductData Computer
        {

            get { return computer; }

        }

        // Abstract build methods
        public abstract void BuildCase();
        public abstract void BuildMotherboard();
        public abstract void BuildProcessor();
        public abstract void BuildPowerSupply();
        public abstract void BuildDisplay();
        public abstract void BuildInput();
        public abstract void BuildHardDrive();
        public abstract void BuildRam();
        public abstract void BuildOperatingSystem();
        public abstract void BuildAdditionalHardware();

    }
}
