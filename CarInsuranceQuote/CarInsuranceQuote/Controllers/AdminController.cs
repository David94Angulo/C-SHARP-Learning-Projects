using CarInsuranceQuote.Models;
using CarInsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceQuote.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceEntities4 db = new CarInsuranceEntities4())
            {

                var submission = db.Submits.ToList();

                var submissionVm = new List<SubmissionVM>();

                foreach (var sub in  submission)
                {
                    var subVm = new SubmissionVM();

                    subVm.FirstNameVm = sub.firstName;
                    subVm.LastNameVm = sub.lastName;
                    subVm.EmailAddressVm = sub.emailAddress;
                    subVm.QuoteVm = sub.Quote;
                    submissionVm.Add(subVm);
                }
                return View(submissionVm);
            }






                
        }
    }
}