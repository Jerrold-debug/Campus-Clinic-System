
namespace Clinic_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Comment
    {
        public int Id { get; set; }
        public int CampusId { get; set; }
        public int CommentTypeId { get; set; }
        public int PriorityId { get; set; }
        public string Phone { get; set; }
        public int CommentMethodID { get; set; }

        [DataType(DataType.MultilineText)]
        public string Complaint { get; set; }
        public int AttendedBy { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    
        public virtual Campu Campu { get; set; }
        public virtual CommentType CommentType { get; set; }
        public virtual CommunicationMethod CommunicationMethod { get; set; }
        public virtual MedicalPractitioner MedicalPractitioner { get; set; }
        public virtual Priority Priority { get; set; }
    }
}
