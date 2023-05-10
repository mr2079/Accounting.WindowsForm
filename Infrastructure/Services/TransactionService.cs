using Core.Context;
using Domain.Entities;
using Infrastructure.Converters;
using Infrastructure.Services.Interfaces;
using Infrastructure.Statics;
using Infrastructure.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class TransactionService : ITransactionService
{
    private readonly AccountingContext _context;

    public TransactionService(AccountingContext context)
    {
        _context = context;
    }

    public async Task<Transaction> GetByIdAsync(Guid id)
        => await _context.Transactions
        .Include(t => t.Customer)
        .FirstOrDefaultAsync(t => Equals(t.Id, id));

    public async Task<MainFormInfoViewModel> GetMainFormInfoAsync()
    {
        var endDate = DateTime.Now;
        var startDate = endDate.AddMonths(-1);

        var payments = await _context.Transactions
            .Where(t => t.Type == TransactionType.Payment &&
            t.AddedAt >= startDate &&
            t.AddedAt <= endDate)
            .SumAsync(t => t.Amount);

        var recieves = await _context.Transactions
            .Where(t => t.Type == TransactionType.Recieve &&
            t.AddedAt >= startDate &&
            t.AddedAt <= endDate)
            .SumAsync(t => t.Amount);

        var balance = recieves - payments;

        return new MainFormInfoViewModel { PaymentsCount = payments, RecievesCount = recieves, Balance = balance };
    }

    public async Task<bool> CreateTransactionAsync(CreateTransactionViewModel model)
    {
        try
        {
            var transaction = new Transaction
            {
                CustomerId = model.CustomerId,
                Amount = model.Amount,
                Description = model.Description,
                Type = model.TransactionType,
                AddedAt = DateTime.Now
            };

            await _context.Transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();

            return true;
        }
        catch { return false; }
    }

    public async Task<bool> UpdateTransactionAsync(Guid id, CreateTransactionViewModel model)
    {
        try
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null) return false;
            transaction.Type = model.TransactionType;
            transaction.Amount = model.Amount;
            transaction.Description = model.Description;
            transaction.ModifiedAt = DateTime.Now;
            _context.Transactions.Update(transaction);
            await _context.SaveChangesAsync();
            return true;
        }
        catch { return false; }
    }

    public async Task<bool> DeleteTransactionAsync(Guid transactionId)
    {
        try
        {
            var transaction = await _context.Transactions.FindAsync(transactionId);
            if (transaction == null) return false;
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
            return true;
        }
        catch { return false; }
    }

    public async Task<List<TransactionsReportViewModel>>
        GetTransactionsReportAsync(string? transactionType)
    {
        if (transactionType != null)
            return await _context.Transactions
            .Include(t => t.Customer)
            .Where(t => t.Type == transactionType)
            .OrderByDescending(t => t.AddedAt)
            .Select(t => new TransactionsReportViewModel
            {
                Id = t.Id,
                CustomerId = t.CustomerId,
                FullName = t.Customer.FullName,
                Amount = t.Amount.ToString("0,#"),
                Description = t.Description,
                AddedAt = t.AddedAt.ToShamsi()
            })
            .ToListAsync();

        return await _context.Transactions
            .Include(t => t.Customer)
            .OrderByDescending(t => t.AddedAt)
            .Select(t => new TransactionsReportViewModel
            {
                Id = t.Id,
                CustomerId = t.CustomerId,
                FullName = t.Customer.FullName,
                Amount = t.Amount.ToString("0,#"),
                Description = t.Description,
                AddedAt = t.AddedAt.ToShamsi()
            })
            .ToListAsync();
    }

    public async Task<List<TransactionsReportViewModel>>
        GetTransactionsReportByCustomerIdAsync(Guid customerId)
    {
        return await _context.Transactions
            .Include(t => t.Customer)
            .Where(t => Equals(t.CustomerId, customerId))
            .OrderByDescending(t => t.AddedAt)
            .Select(t => new TransactionsReportViewModel
            {
                Id = t.Id,
                CustomerId = t.CustomerId,
                FullName = t.Customer.FullName,
                Amount = t.Amount.ToString("0,#"),
                Description = t.Description,
                AddedAt = t.AddedAt.ToShamsi()
            })
            .ToListAsync();
    }
}
