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
    
    public partial class CarType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarType()
        {
            this.Cars = new HashSet<Car>();
        }
    
        public int CarTypeID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal DailyCost { get; set; }
        public decimal DailyLateCost__DailyLateCost { get; set; }
        public int ManufactureYear { get; set; }
        public string GearType { get; set; }
        public string Category { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Cars { get; set; }
    }
}