using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            var persons = new List<Person>();
            var products = new List<Product>();
            var personInfo = Console.ReadLine().Split(';');
            var productInfo = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                for (int i = 0; i < personInfo.Length; i++)
                {
                    var info = personInfo[i].Split('=');
                    var person = new Person(info[0], decimal.Parse(info[1]));
                    persons.Add(person);
                }
                for (int i = 0; i < productInfo.Length; i++)
                {
                    var info = productInfo[i].Split('=');
                    var product = new Product(info[0], decimal.Parse(info[1]));
                    products.Add(product);
                }


                string commands;
                while ((commands = Console.ReadLine()) != "END")
                {
                    var commandInfo = commands.Split();
                    var buyer = persons.FirstOrDefault(b => b.PersonName == commandInfo[0]);
                    var productToBuy = products.FirstOrDefault(bp => bp.ProductName == commandInfo[1]);
                    try
                    {
                        buyer.BuingProduct(buyer, productToBuy);
                        Console.WriteLine($"{buyer.PersonName} bought {productToBuy.ProductName}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
                    foreach (var p in persons)
                    {
                    var boughtPr = p.GetProducts();
                    if (boughtPr.Any())
                    {
                        Console.WriteLine($"{p.PersonName} - {string.Join(", ", boughtPr)}");
                    }
                    else
                    {
                        Console.WriteLine($"{p.PersonName} - Nothing bought");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
