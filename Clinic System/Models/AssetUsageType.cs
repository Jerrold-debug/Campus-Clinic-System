
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssetUsageType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssetUsageType()
        {
            this.Inventories = new HashSet<Inventory>();
        }
    
        public int Id { get; set; }
        public string UsageTypeDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
