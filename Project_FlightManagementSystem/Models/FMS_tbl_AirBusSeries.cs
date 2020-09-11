//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_FlightManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FMS_tbl_AirBusSeries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FMS_tbl_AirBusSeries()
        {
            this.FMS_tbl_AirBusDetails = new HashSet<FMS_tbl_AirBusDetails>();
        }
    
        public int AirBusSeriesId { get; set; }
        public string Series { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> AirBusLength { get; set; }
        public Nullable<decimal> MaxTakeOffWeight { get; set; }
        public Nullable<decimal> StandardFuelCapacity { get; set; }
        public Nullable<decimal> MaxSpeed { get; set; }
        public Nullable<decimal> CabinLength { get; set; }
        public Nullable<int> PremiumClassSeatingCapacity { get; set; }
        public Nullable<int> FirstClassSeatingCapacity { get; set; }
        public Nullable<int> EconomyClassSeatingCapacity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FMS_tbl_AirBusDetails> FMS_tbl_AirBusDetails { get; set; }
    }
}