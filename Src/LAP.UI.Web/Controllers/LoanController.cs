using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LAP.UI.Web.Models;
using LAP.Core.Domain;
using LAP.Services.Lending;

namespace LAP.UI.Web.Controllers
{
    public class LoanController : Controller
    {
        // GET: Loan
        public ActionResult Index(LoanRequest model)
        {
            return View(model);
        }

        [HttpPost]
        public ActionResult SearchResult(LoanRequest model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            var loans = new LendingService().GetLoans((LoanPurpose)model.Purpose, model.Amount, model.TermYear);
            var result = MapLoanSearchResult(loans, model);
            return View(result);
        }

        private LoanSearchResult MapLoanSearchResult(IEnumerable<Loan> loans, LoanRequest request)
        {
            var result = new LoanSearchResult(request);

            foreach (var loan in loans)
            {
                var loanInfo = new LoanInfo
                {
                    LoanId = loan.LoanId.ToString(),
                    ProviderName = loan.LoanProvider.Name,
                    ProviderLogo = loan.LoanProvider.LogoFile,
                    Apr = loan.RepresentativeApr,
                };

                new LoanPaymentCalculator().CalculatePayment(request.Amount, request.TermYear, loanInfo.Apr, out decimal monthlyAmount, out decimal totalPayableAmount);
                loanInfo.MonthlyAmount = monthlyAmount;
                loanInfo.TotalPayableAmount = totalPayableAmount;
                result.Loans.Add(loanInfo);
            }

            result.Loans = result.Loans.OrderBy(c => c.MonthlyAmount).ToList();
            return result;
        }
    }
}