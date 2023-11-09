using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class ApplyManager
    {
        public void ApplyNow(ILoanManager loanManager, ILoggerService loggerService)
        {
            // Başvuru bilgilerini değerlendirme
            
            // bu şekilde kredi bağımlı oluyor
            //AutoLoanManager autoLoanManager2 = new AutoLoanManager();
            //autoLoanManager2.Calculate();

            //bu şekilde bağımsız olarak, gereken krediye uygun hesaplama yapılır.
            loanManager.Calculate();
            loggerService.Log();
        }

        public void LoanDisclosureDo(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }

        }
    }
}
