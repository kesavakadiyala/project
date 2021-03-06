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
    using System.ComponentModel.DataAnnotations;
    public partial class FMS_tbl_FlightScheduleDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FMS_tbl_FlightScheduleDetails()
        {
            this.FMS_tbl_BonusMilesDEtails = new HashSet<FMS_tbl_BonusMilesDEtails>();
        }
        
        [Display(Name ="FlightSchedule ID")]
        public int FlightScheduleId { get; set; }
        [Display(Name = "Departure Place")]
        [Required(ErrorMessage ="Departure Place is Required")]
        public string DeparturePlace { get; set; }
        [Display(Name = "Destination Place")]
        [Required(ErrorMessage = "Destination Place is Required")]
        public string DestinationPlace { get; set; }
        [Display(Name = "Flight Name")]
        [Required(ErrorMessage = "Flight Name is Required")]
        public string Flight { get; set; }
        public Nullable<int> AirBusId { get; set; }
        [Display(Name = "Departure Date")]
        [Required(ErrorMessage = "Departure Date is Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DepartureDate { get; set; }
        [Display(Name = "Arrival Date")]
        [Required(ErrorMessage = "Arrival Date is Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        [Display(Name = "Premium Class Fare")]
        [Required(ErrorMessage = "Premium Class Fare is Required")]
        public Nullable<decimal> PremiumClassFare { get; set; }
        [Display(Name = "First Class Fare")]
        [Required(ErrorMessage = "First Class Fare is Required")]
        public Nullable<decimal> FirstClassFare { get; set; }
        [Display(Name = "Economy Class Fare")]
        [Required(ErrorMessage = "Economy Class Fare is Required")]
        public Nullable<decimal> EconomyClassFare { get; set; }
        [Display(Name = "Premium Class Seating Availability")]
        public Nullable<int> PremiumClassSeatingAvailability { get; set; }
        [Display(Name = "First Class Seating Availability")]
        public Nullable<int> FirstClassSeatingAvailability { get; set; }
        [Display(Name = "Economy Class Seating Availability")]
        public Nullable<int> EconomyClassSeatingAvailability { get; set; }
        [Display(Name = "VAT")]
        [Required(ErrorMessage = "VAT is Required")]
        public Nullable<decimal> VAT { get; set; }
        [Display(Name = "Tax")]
        [Required(ErrorMessage = "TAX is Required")]
        public Nullable<decimal> TAX { get; set; }
        [Display(Name = "Distance")]
        [Required(ErrorMessage = "Distance is Required")]
        public Nullable<int> Distance { get; set; }
        [Display(Name ="Status")]
        public Nullable<bool> stats { get; set; }
        [Display(Name = "Description")]
      
        public string Descriptions { get; set; }
    
        public virtual FMS_tbl_AirBusDetails FMS_tbl_AirBusDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FMS_tbl_BonusMilesDEtails> FMS_tbl_BonusMilesDEtails { get; set; }
    }
}
