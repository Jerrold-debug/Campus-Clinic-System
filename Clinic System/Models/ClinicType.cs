
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClinicType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClinicType()
        {
            this.HealthClinics = new HashSet<HealthClinic>();
        }
    
        public int Id { get; set; }
        public string TypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HealthClinic> HealthClinics { get; set; }
    }
}
