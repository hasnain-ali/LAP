using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAP.Core.Domain;

namespace LAP.Services.Lending
{
    public class LendingService : ILendingService
    {
        public IEnumerable<Loan> GetLoans(LoanPurpose loanPurpose, decimal loanAmount, int termYear)
        {
            var loanSelector = new LoanSelector(loanPurpose, loanAmount, termYear);
            var allLoans = Data.DataRepository.GetAllLoans().Where(l => loanSelector.CanSelect(l)).ToList();
            return allLoans;
        }
    }
}
