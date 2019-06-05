using CarInsuranceQuote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, string hadDUI, int numberOfSpeedingTickets, string coverageOrLiable)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) 
                || dateOfBirth.Year == 0 || carYear == 0 || string.IsNullOrEmpty(carMake) 
                || string.IsNullOrEmpty(carModel) || numberOfSpeedingTickets < 0 || string.IsNullOrEmpty(coverageOrLiable) )
            {
                return View("~/Views/Shared/Error.cshtml");
            }

            else
            {

                using (CarInsuranceEntities4 db = new CarInsuranceEntities4())
                {
                    var submission = new Submit();
                    submission.firstName = firstName;
                    submission.lastName = lastName;
                    submission.emailAddress = emailAddress;
                    submission.dateOfBirth = dateOfBirth;
                    submission.carYear = carYear;
                    submission.carMake = carMake;
                    submission.carModel = carModel;
                    submission.hadDUI = hadDUI;
                    submission.numberOfSpeedingTicket = numberOfSpeedingTickets;
                    submission.coverageOrLiable = coverageOrLiable;

                    decimal Quote = 50.0m;

                    if (25 > (DateTime.Now.Year - dateOfBirth.Year)) Quote += 25;
                    if (18 > (DateTime.Now.Year - dateOfBirth.Year)) Quote += 100;
                    if (100 < (DateTime.Now.Year - dateOfBirth.Year)) Quote += 25;
                    if (carYear < 2000) Quote += 25;
                    if (carYear > 2015) Quote += 25;
                    if (carMake.ToLower() == "porsche") Quote += 25;
                    if ( carMake.ToLower() == "porsche" &&  carModel.ToLower() == "911 carrera") Quote += 25;
                    if (numberOfSpeedingTickets > 0) Quote += (numberOfSpeedingTickets * 10);
                    if (hadDUI.ToLower() == "yes") Quote += (Quote * 0.25m);
                    if (coverageOrLiable.ToLower() == "coverage") Quote += (Quote * 0.5m);

                    submission.Quote = Quote;

                    db.Submits.Add(submission);
                    db.SaveChanges();
                }

                return View("Submitted");
            }
            

        }
    }
}