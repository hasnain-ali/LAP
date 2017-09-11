using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP.Services.CreditScore
{
    public class CreditScoreResult
    {
        public CreditScoreResult()
        {
            this.Errors = new List<string>();
        }

        public int CreditScore { get; set; }

        public IList<string> Errors { get; set; }

        public bool Success
        {
            get
            {
                return !this.Errors.Any();
            }
        }

        public void AddError(string error)
        {
            this.Errors.Add(error);
        }
    }
}
