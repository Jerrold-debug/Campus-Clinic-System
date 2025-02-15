
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientAppointment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int TimeId { get; set; }
        public int OptionId { get; set; }
        public int GenderId { get; set; }
        public int TitleId { get; set; }
        public System.DateTime Date { get; set; }
        public string Symptoms { get; set; }
        public string Cellphone { get; set; }
        public string Cellphone2 { get; set; }
        public string StudentNumber { get; set; }
        public string ID_Number { get; set; }
        public string Comorbidity { get; set; }
        public int PractId { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual HealthOption HealthOption { get; set; }
        public virtual TimePreference TimePreference { get; set; }
        public virtual UserTitle UserTitle { get; set; }
        public virtual MedicalPractitioner MedicalPractitioner { get; set; }
    }
}
