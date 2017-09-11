using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP.Services.CreditScore
{
    public class EquifaxCreditScoreProvider : CreditScoreProviderBase
    {
        public override string Name { get { return "Equifax"; } }

        public override CreditScoreResult GetCreditScore(CreditScoreRequest creditScoreRequest)
        {
            if (creditScoreRequest == null)
            {
                throw new ArgumentNullException("creditScoreRequest");
            }

            var result = new CreditScoreResult();

            // Simple logic for demo based on the date of birth
            if ((DateTime.Now.Year - creditScoreRequest.DateOfBirth.Year) <= 20)
            {
                result.CreditScore = 200;
            }
            else if ((DateTime.Now.Year - creditScoreRequest.DateOfBirth.Year) <= 30)
            {
                result.CreditScore = 350;
            }
            else if ((DateTime.Now.Year - creditScoreRequest.DateOfBirth.Year) <= 45)
            {
                result.CreditScore = 750;
            }
            else
            {
                result.CreditScore = 550;
            }

            return result;
        }
    }
}
