
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicalPractitioner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalPractitioner()
        {
            this.Comments = new HashSet<Comment>();
            this.PatientAppointments = new HashSet<PatientAppointment>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Nullable<int> RaceId { get; set; }
        public Nullable<int> GenderId { get; set; }
        public bool IsRegistered { get; set; }
        public int SpecialityId { get; set; }
        public int PractitionerTypeId { get; set; }
        public int EmpTypeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual MedicalPractitioner MedicalPractitioner1 { get; set; }
        public virtual MedicalPractitioner MedicalPractitioner2 { get; set; }
        public virtual Race Race { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual Type Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientAppointment> PatientAppointments { get; set; }
    }
}
