using Domain.Entities;
using Infrastructure.ViewModels;

namespace Infrastructure.Services.Interfaces;

public interface ITransactionService
{
    Task<bool> CreateTransactionAsync(CreateTransactionViewModel model);
    Task<bool> DeleteTransactionAsync(Guid transactionId);
    Task<Transaction> GetByIdAsync(Guid id);
    Task<MainFormInfoViewModel> GetMainFormInfoAsync();
    Task<List<TransactionsReportViewModel>> GetTransactionsReportAsync(string? transactionType);
    Task<List<TransactionsReportViewModel>> GetTransactionsReportByCustomerIdAsync(Guid customerId);
    Task<bool> UpdateTransactionAsync(Guid Id, CreateTransactionViewModel model);
}
