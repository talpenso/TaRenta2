//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRental
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int RentID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime PlannedReturnDate { get; set; }
        public System.DateTime EffectiveReturnDate { get; set; }
        public int UserID { get; set; }
        public int CarNumber { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual Rental Rentals1 { get; set; }
        public virtual Rental Rental1 { get; set; }
        public virtual Rental Rentals11 { get; set; }
        public virtual Rental Rental2 { get; set; }
        public virtual User User { get; set; }
    }
}
