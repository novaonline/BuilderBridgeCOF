using BridgePattern.Implementor;
using BuilderPattern.Handler;
using BuilderPattern.Handler.Concrete_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction
{
    /// <summary>
    /// The base class for the interfaces
    /// Contains the Implementer
    /// Allows up to make multiple interfaces that use the implementor 
    /// </summary>
    class AbstractBusiness
    {
        // At the moment a Business can only create one specific product
        protected Product p;

        // Getter Method for Product
        public Product Product
        { 
            set { p = value; } 
        }

        /// <summary>
        /// Client Side for the Chain of Responsibility Pattern
        /// Using view here and setting each View's Successor
        /// </summary>
        public void Show()
        {
            // implemented the successor  link
            View v1 = new CompactView();
            View v2 = new MediumView();
            View v3 = new LargeView();
            v1.setSuccessor(v2);
            v2.setSuccessor(v3);
            
            // calling compact view to attempt first
            // I should have just passed in product p
            v1.show(p.theProductData.getTypee(), p.theProductData.getparts());

        }
    }
}
