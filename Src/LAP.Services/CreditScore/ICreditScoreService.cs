using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP.Services.CreditScore
{
    public interface ICreditScoreService
    {
        int GetCreditScore(string firstName, string lastName, DateTime dateofBirth, string postCode, IList<string> creditScoreProviders);
    }
}
