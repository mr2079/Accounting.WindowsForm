using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Transaction : BaseEntity
{
    public Guid CustomerId { get; set; }
    public string Type { get; set; } = string.Empty;
    public long Amount { get; set; }
    public string Description { get; set; } = string.Empty;


    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; set; } = null!;
}
