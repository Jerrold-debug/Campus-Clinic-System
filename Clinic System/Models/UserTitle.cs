
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserTitle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserTitle()
        {
            this.PatientAppointments = new HashSet<PatientAppointment>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string TitleName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientAppointment> PatientAppointments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
