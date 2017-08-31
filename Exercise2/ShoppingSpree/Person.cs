using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Person
    {
        private string personName;
        private decimal money;
        private List<string> bag;

        public Person(string name, decimal money)
        {
            this.PersonName = name;
            this.Money = money;
            this.bag = new List<string>();
        }

            public string PersonName
        {
            get { return this.personName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Name cannot be empty");
                }
                this.personName = value;
            }
        }
        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Money)} cannot be negative");
                }
                this.money = value;
            }
        }
       public IList<string> GetProducts()
        {
            return this.bag.AsReadOnly();
        }

        public void BuingProduct(Person person, Product productToBuy)
        {
            if (person.Money < productToBuy.Price)
            {
                throw new InvalidOperationException($"{this.PersonName} can't afford {productToBuy.ProductName}");
            }
            else
            {
                
                person.bag.Add(productToBuy.ProductName);
                person.Money -= productToBuy.Price;
            }
        }
    }
}
