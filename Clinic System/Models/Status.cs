
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PractitionerId { get; set; }
        public int AppointmentId { get; set; }
        public string Commobidity { get; set; }
        public string Symptoms { get; set; }
        public System.DateTime Date { get; set; }
        public int TimeId { get; set; }
        public bool IsApproved { get; set; }
        public string Message { get; set; }
    
        public virtual TimePreference TimePreference { get; set; }
    }
}
