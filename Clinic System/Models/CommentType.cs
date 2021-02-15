
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommentType()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int Id { get; set; }
        public string Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
