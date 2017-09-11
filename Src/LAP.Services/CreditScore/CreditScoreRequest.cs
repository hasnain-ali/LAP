using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP.Services.CreditScore
{
    public class CreditScoreRequest
    {
        public string FirstName { get; }

        public string LastName { get; }

        public DateTime DateOfBirth { get; }

        public string Postcode { get; }

        public CreditScoreRequest(string firstName, string lastName, DateTime dateofBirth, string postCode)
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
                throw new ArgumentNullException("dateofBirth");
            }

            if (string.IsNullOrWhiteSpace(postCode))
            {
                throw new ArgumentNullException("postCode");
            }

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateofBirth;
            Postcode = postCode;
        }
    }
}
