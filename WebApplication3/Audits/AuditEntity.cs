using System.ComponentModel;
using WebApplication3.Bases;

namespace WebApplication3.Audits
{
    public class AuditEntity:BaseEntity
    {
        [DisplayName("who create this")]
        public string? CreatedBy { get; set; }
        [DisplayName("Created date")]
        public DateTime? CreatedDate { get; set; }
        [DisplayName("who last modify it")]
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
