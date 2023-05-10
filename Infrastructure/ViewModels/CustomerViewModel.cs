namespace Infrastructure.ViewModels;

public class CreateCustomerViewModel
{
    public string FullName { get; set; } = string.Empty;
    public string Mobile { get; set; } = string.Empty;
    public string? Email { get; set; }
}

public class UpdateCustomerViewModel
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Mobile { get; set; } = string.Empty;
    public string? Email { get; set; }
}

public class CustomersListViewModel
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Mobile { get; set; } = string.Empty;
    public string? Email { get; set; }
}

public class CustomersListForAddTransactionViewModel
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
}