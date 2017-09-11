using System.Linq;
using LAP.Core.Domain;

namespace LAP.Services.Lending
{
    public class LoanSelector : ILoanSelector
    {
        LoanPurpose _loanPurpose;
        decimal _loanAmount;
        int _termYear;

        public LoanSelector(LoanPurpose loanPurpose, decimal loanAmount, int termYear)
        {
            _loanPurpose = loanPurpose;
            _loanAmount = loanAmount;
            _termYear = termYear;
        }

        public bool CanSelect(Loan loan)
        {
            if (
                (loan.MinAmount <= _loanAmount && _loanAmount <= loan.MaxAmount) &&
                (loan.MinTermYears <= _termYear && _termYear <= loan.MaxAmount) &&
                (loan.LoanPurposes.Contains(_loanPurpose))
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
