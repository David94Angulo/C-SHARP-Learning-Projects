//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsuranceQuote.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Submit
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public Nullable<System.DateTime> dateOfBirth { get; set; }
        public Nullable<int> carYear { get; set; }
        public string carMake { get; set; }
        public string carModel { get; set; }
        public string hadDUI { get; set; }
        public Nullable<int> numberOfSpeedingTicket { get; set; }
        public string coverageOrLiable { get; set; }
        public Nullable<decimal> Quote { get; set; }
    }
}
