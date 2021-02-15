
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HealthOption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HealthOption()
        {
            this.PatientAppointments = new HashSet<PatientAppointment>();
        }
    
        public int Id { get; set; }
        public string CheckUpOption { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientAppointment> PatientAppointments { get; set; }
    }
}
