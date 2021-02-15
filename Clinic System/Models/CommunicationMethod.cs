
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommunicationMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommunicationMethod()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int Id { get; set; }
        public string Method { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
