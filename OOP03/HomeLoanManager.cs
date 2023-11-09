using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class HomeLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı.");
        }
    }
}
