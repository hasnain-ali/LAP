using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAP.UI.Web.Models
{
    public class LoanSearchResult
    {
        public LoanSearchResult(LoanRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            Request = request;
            Loans = new List<LoanInfo>();
        }

        public LoanRequest Request { get; }

        public List<LoanInfo> Loans { get; set; }
    }

    public class LoanInfo
    {
        public string LoanId { get; set; }

        public string ProviderName { get; set; }

        public string ProviderLogo { get; set; }

        public decimal Apr { get; set; }

        public decimal MonthlyAmount { get; set; }

        public decimal TotalPayableAmount { get; set; }

        public string TermsConditions { get; set; }
    }
}