
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InstitutionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InstitutionType()
        {
            this.Institutions = new HashSet<Institution>();
        }
    
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
