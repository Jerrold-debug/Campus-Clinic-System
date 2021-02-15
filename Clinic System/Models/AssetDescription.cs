
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AssetDescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssetDescription()
        {
            this.Inventories = new HashSet<Inventory>();
        }
    
        public int Id { get; set; }

        [Display(Name = "Asset Description")]
        public string AssetDescr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
