using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP.Services.CreditScore
{
    public interface ICreditScoreProvider
    {
        string Name { get; }

        CreditScoreResult GetCreditScore(CreditScoreRequest request);
    }
}
