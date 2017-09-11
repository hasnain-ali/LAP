using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP.Services.CreditScore
{
    public abstract class CreditScoreProviderBase : ICreditScoreProvider
    {
        public abstract string Name { get; }

        public abstract CreditScoreResult GetCreditScore(CreditScoreRequest request);
    }
}
