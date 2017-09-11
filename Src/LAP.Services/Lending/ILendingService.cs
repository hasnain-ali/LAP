using System.Collections.Generic;
using LAP.Core.Domain;

namespace LAP.Services.Lending
{
    public interface ILendingService
    {
        IEnumerable<Loan> GetLoans(LoanPurpose loanPurpose, decimal loanAmount, int termYear);
    }
}