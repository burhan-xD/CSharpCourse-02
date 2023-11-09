using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi: " + product.Name);
        }

        public void Add02(string name, string desc, double price, int stock)
        {
            Console.WriteLine("Sepete eklendi: " + name); ;
        }
    }
}
