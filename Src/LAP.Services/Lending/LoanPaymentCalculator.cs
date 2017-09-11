using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP.Services.Lending
{
    public class LoanPaymentCalculator : ILoanPaymentCalculator
    {
        public void CalculatePayment(decimal loanAmount, int termYear, decimal Apr, out decimal monthlyAmount, out decimal totalPayableAmount)
        {
            var rate = Convert.ToDouble(Apr) / 100 / 12;
            var denaminator = Math.Pow((1 + rate), (termYear * 12)) - 1;
            monthlyAmount = Convert.ToDecimal((rate + (rate / denaminator)) * Convert.ToDouble(loanAmount));
            totalPayableAmount = Convert.ToDecimal(monthlyAmount * (termYear * 12));
        }
    }
}
