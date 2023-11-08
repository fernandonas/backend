using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool Active { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
