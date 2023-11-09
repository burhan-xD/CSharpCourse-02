using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Id + " - " + product.ProductName);
            Console.WriteLine("Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Id + " - " + product.ProductName);
            Console.WriteLine("Güncellendi.");
        }
    }
}
