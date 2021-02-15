
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Institution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CampusId { get; set; }
        public string Address { get; set; }
        public Nullable<int> TypeId { get; set; }
    
        public virtual Campu Campu { get; set; }
        public virtual InstitutionType InstitutionType { get; set; }
    }
}
