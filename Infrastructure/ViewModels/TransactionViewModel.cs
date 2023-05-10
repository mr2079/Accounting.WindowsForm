namespace Infrastructure.ViewModels;

public class CreateTransactionViewModel
{
    public Guid CustomerId { get; set; }
    public string TransactionType { get; set; } = string.Empty;
    public string? Description { get; set; }
    public long Amount { get; set; }
}

public class TransactionsReportViewModel
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Amount { get; set; } = string.Empty;
    public string AddedAt { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class MainFormInfoViewModel
{
    public long PaymentsCount { get; set; }
    public long RecievesCount { get; set; }
    public long Balance { get; set; }
}
