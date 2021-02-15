
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AssetCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssetCategory()
        {
            this.Inventories = new HashSet<Inventory>();
        }
    
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
