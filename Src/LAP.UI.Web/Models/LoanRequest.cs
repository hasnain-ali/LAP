using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAP.UI.Web.Models
{
    public class LoanRequest
    {
        [Required]
        public int Purpose { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public int TermYear { get; set; }

        [Required]
        public int HomeOwner { get; set; }

        [Required]
        public int Employed { get; set; }

        [Required]
        public int AnnualIncome { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required]
        public string TownCity { get; set; }

        [Required]
        public string Postcode { get; set; }
    }
}