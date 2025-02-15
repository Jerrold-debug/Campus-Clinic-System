
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Inventory
    {
        public int Id { get; set; }
        public int CampusId { get; set; }
        public int CategoryId { get; set; }
        public int AssetDescriptionId { get; set; }

        [Display(Name = "Item Name")]
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public bool Warranty { get; set; }
        public bool Guarantee { get; set; }
        public int SupplierId { get; set; }
        public int UsageTypeId { get; set; }
        public string Location { get; set; }
        public string AssetColor { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int Quantity { get; set; }
    
        public virtual AssetCategory AssetCategory { get; set; }
        public virtual AssetDescription AssetDescription { get; set; }
        public virtual AssetUsageType AssetUsageType { get; set; }
        public virtual Campu Campu { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
