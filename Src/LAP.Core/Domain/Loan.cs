using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP.Core.Domain
{
    public class Loan
    {
        public int LoanId { get; set; }

        public LoanProvider LoanProvider { get; set; }

        public List<LoanPurpose> LoanPurposes { get; set; }

        public decimal MinAmount { get; set; }

        public decimal MaxAmount { get; set; }

        public int MinTermYears { get; set; }

        public int MaxTermYears { get; set; }

        public decimal RepresentativeApr { get; set; }

        public int MinCreditScore { get; set; }

        public int MaxCreditScore { get; set; }

        public List<CreditScoreProvider> CreditScoreProviders { get; set; }

        public Loan()
        {
            LoanPurposes = new List<LoanPurpose>();
            CreditScoreProviders = new List<CreditScoreProvider>();
        }
    }
}
