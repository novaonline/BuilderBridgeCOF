using BuilderPattern.Handler;
using BuilderPattern.Handler.Concrete_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Product
{
    /// <summary>
    /// The 'Product' class
    /// ProductData (this class) vs. Product?
    /// ProductData = data Structure for products (dictionary of parts)
    /// Product = container for ProductData + Meta Data
    /// </summary>
    class ProductData
    {
         private string _Type;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        // Constructor
        public ProductData(string productType)
        {
            this._Type = productType;
        }

        public Dictionary<string, string> getparts()
        { return this._parts; }

        public string getTypee()
        { return this._Type; }

        // Indexer
        // custom fields for parts
        public string this[string key]
        {
            get { return _parts[key]; }

            set { _parts[key] = value; }
        }

    }
}
