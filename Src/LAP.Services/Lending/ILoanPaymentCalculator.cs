namespace LAP.Services.Lending
{
    public interface ILoanPaymentCalculator
    {
        void CalculatePayment(decimal loanAmount, int termYear, decimal Apr, out decimal monthlyAmount, out decimal totalPayableAmount);
    }
}