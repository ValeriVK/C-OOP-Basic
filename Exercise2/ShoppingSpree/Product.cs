using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Product
    {
        private string producName;
        private decimal price;

        public Product(string product, decimal price)
        {
            this.ProductName = product;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.producName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(ProductName)} cannot be empty");
                }
                this.producName = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }
                this.price = value;
            }
        }
       
    }
}
