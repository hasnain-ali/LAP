using LAP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LAP.Services.Test
{
    public class LendingTests
    {
        [Theory]
        [InlineData(true, LoanPurpose.Car, 1000, 1)]
        [InlineData(false, LoanPurpose.Debts, 1000, 1)]
        [InlineData(false, LoanPurpose.Holiday, 1000, 1)]
        [InlineData(true, LoanPurpose.HomeImprovement, 1000, 1)]
        [InlineData(false, LoanPurpose.SomethingElse, 1000, 1)]
        [InlineData(true, LoanPurpose.Wedding, 1000, 1)]
        public void LoanSelectorTest(bool expectedResult, LoanPurpose loanPurpose, decimal loanAmount, int termYear)
        {
            var loan = GetLoan();
            var selector = new Lending.LoanSelector(loanPurpose, loanAmount, termYear);
            Assert.Equal(expectedResult, selector.CanSelect(loan));
        }

        [Theory]
        [InlineData(1000, 1, 3.4, 84.8760161584568, 1018.5121939014816)]
        [InlineData(1000, 1, 4.2, 85.2413099999013, 1022.8957199988156)]
        [InlineData(1000, 1, 5.3, 85.7450223637288, 1028.9402683647456)]
        public void CalculatePaymentTest(decimal loanAmount, int termYear, decimal Apr, decimal expectedMonthlyAmount, decimal expectedTotalPayableAmount)
        {
            new Lending.LoanPaymentCalculator().CalculatePayment(loanAmount, termYear, Apr, out decimal monthlyAmount, out decimal totalPayableAmount);
            Assert.Equal(expectedMonthlyAmount, monthlyAmount);
            Assert.Equal(totalPayableAmount, totalPayableAmount);
        }

        private Loan GetLoan()
        {
            var rbsLoan = new Loan();
            rbsLoan.LoanId = 2;
            rbsLoan.LoanProvider = new LoanProvider()
            {
                Id = "RBS",
                Name = "Royal Bank of Scotland",
                LogoFile = "RBS"
            };
            rbsLoan.LoanPurposes.Add(LoanPurpose.Car);
            //rbsLoan.LoanPurposes.Add(LoanPurpose.Debts);
            //rbsLoan.LoanPurposes.Add(LoanPurpose.Holiday);
            rbsLoan.LoanPurposes.Add(LoanPurpose.HomeImprovement);
            //rbsLoan.LoanPurposes.Add(LoanPurpose.SomethingElse);
            rbsLoan.LoanPurposes.Add(LoanPurpose.Wedding);
            rbsLoan.MinAmount = 1000;
            rbsLoan.MaxAmount = 7000;
            rbsLoan.MinTermYears = 1;
            rbsLoan.MaxTermYears = 5;
            rbsLoan.CreditScoreProviders.Add(new CreditScoreProvider()
            {
                Id = "Experian",
                Name = "Experian"
            });
            rbsLoan.RepresentativeApr = 4.2M;
            return rbsLoan;
        }
    }
}
