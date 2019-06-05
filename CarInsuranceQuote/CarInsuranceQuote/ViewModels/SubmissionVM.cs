using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.ViewModels
{
    public class SubmissionVM
    {
        public decimal? QuoteVm { get; set; }
        public string FirstNameVm { get; set; }
        public string LastNameVm { get; set; }
        public string EmailAddressVm { get; set; }

    }
}