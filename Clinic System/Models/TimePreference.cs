
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimePreference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimePreference()
        {
            this.Status = new HashSet<Status>();
            this.PatientAppointments = new HashSet<PatientAppointment>();
        }
    
        public int Id { get; set; }
        public string TimePreference1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Status> Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientAppointment> PatientAppointments { get; set; }
    }
}
