using LAP.Core.Domain;

namespace LAP.Services.Lending
{
    public interface ILoanSelector
    {
        bool CanSelect(Loan loan);
    }
}