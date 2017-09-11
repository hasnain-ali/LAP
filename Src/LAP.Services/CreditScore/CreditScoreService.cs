using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP.Services.CreditScore
{
    public class CreditScoreService : ICreditScoreService
    {
        public int GetCreditScore(string firstName, string lastName, DateTime dateofBirth, string postCode, IList<string> creditScoreProviders)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException("firstName");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentNullException("lastName");
            }

            if (new DateTime().Equals(dateofBirth))
            {
                throw new ArgumentNullException("dateOfBirth");
            }

            if (string.IsNullOrWhiteSpace(postCode))
            {
                throw new ArgumentNullException("postCode");
            }

            if (creditScoreProviders == null || !creditScoreProviders.Any())
            {
                throw new ArgumentNullException("creditScoreProviders");
            }

            var creditScoreRequest = new CreditScoreRequest(firstName, lastName, dateofBirth, postCode);

            List<int> creditScores = new List<int>();
            foreach (var provider in GetAllCreditScoreProviders().Where(p => creditScoreProviders.Contains(p.Name)))
            {
                var creditScoreResult = provider.GetCreditScore(creditScoreRequest);
                if (creditScoreResult.Success)
                    creditScores.Add(creditScoreResult.CreditScore);
            }

            return creditScores.Max();
        }

        public IList<ICreditScoreProvider> GetAllCreditScoreProviders()
        {
            var providers = new List<ICreditScoreProvider>();
            providers.Add(new ExperianCreditScoreProvider());
            providers.Add(new EquifaxCreditScoreProvider());
            return providers;
        }
    }
}
