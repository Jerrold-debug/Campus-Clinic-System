
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HealthClinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Physical_Address { get; set; }
        public string ResAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CampusId { get; set; }
        public Nullable<int> ClinicTypeId { get; set; }
    
        public virtual Campu Campu { get; set; }
        public virtual ClinicType ClinicType { get; set; }
    }
}
