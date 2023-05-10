using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public abstract class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    public DateTime AddedAt { get; set; } = DateTime.Now;
    public DateTime? ModifiedAt { get; set; }
}
