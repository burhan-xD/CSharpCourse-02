using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class GroceryLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi ödeme planı hesaplandı.");
        }
    }
}
