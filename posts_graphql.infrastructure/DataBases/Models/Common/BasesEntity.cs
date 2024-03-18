using System.ComponentModel.DataAnnotations;

namespace Posts_graphql.Infrastructure.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime AddedDateTime { get; set; }
        public int AddedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? UpdatedBy { get; set; }
        public bool FlgDelete { get; set; }
    }
}
