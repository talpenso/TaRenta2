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
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Rentals = new HashSet<Rental>();
        }
    
        public int CarNumber { get; set; }
        public int CarTypeID { get; set; }
        public int CurrentKilometrage { get; set; }
        public string CarPicture { get; set; }
        public bool IsServiceable { get; set; }
        public bool IsAvailable { get; set; }
        public int BranchID { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Car Cars1 { get; set; }
        public virtual Car Car1 { get; set; }
        public virtual CarType CarType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}