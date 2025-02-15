
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string EmerName { get; set; }
        public string EmerLastName { get; set; }
        public string EmerAddress { get; set; }
        public string EmerCell { get; set; }
        public bool Insured { get; set; }
        public string InsurCompa { get; set; }
        public string InsurAddress { get; set; }
        public string InsurCell { get; set; }
        public bool IsVaccinated { get; set; }
        public string StudNum { get; set; }
        public string Email { get; set; }
    
        public virtual Country Country { get; set; }
    }
}
