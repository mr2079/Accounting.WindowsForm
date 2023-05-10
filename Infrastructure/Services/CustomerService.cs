using Core.Context;
using Domain.Entities;
using Infrastructure.Services.Interfaces;
using Infrastructure.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class CustomerService : ICustomerService
{
	private readonly AccountingContext _context;

    public CustomerService(AccountingContext context)
    {
        _context = context;
    }

	public async Task<List<CustomersListViewModel>> GetAllAsync()
		=> await _context.Customers
		.Select(c => new CustomersListViewModel
		{
			Id = c.Id,
			FullName = c.FullName,
			Mobile = c.Mobile,
			Email = c.Email
		}).ToListAsync();

	public async Task<Customer> GetByIdAsync(Guid Id)
		=> await _context.Customers.FindAsync(Id);

    public async Task<bool> CreateCustomerAsync(CreateCustomerViewModel model)
    {
		try
		{
			var customer = new Customer
			{
				FullName = model.FullName,
				Mobile = model.Mobile,
				Email = model.Email,
				AddedAt = DateTime.Now
			};
			await _context.Customers.AddAsync(customer);
			await _context.SaveChangesAsync();

			return true;
		}
		catch { return false; }
    }

	public async Task<bool> UpdateCustomerAsync(UpdateCustomerViewModel model)
	{
		try
		{
			if(model.Id == Guid.Empty) return false;
			var customer = await _context.Customers.FindAsync(model.Id);
			if (customer == null) return false;
			customer.FullName = model.FullName;
			customer.Mobile = model.Mobile;
			customer.Email = model.Email;
			customer.ModifiedAt = DateTime.Now;
			_context.Customers.Update(customer);
			await _context.SaveChangesAsync();
			return true;
		}
		catch { return false; }
	}

	public async Task<bool> DeleteCustomerAsync(Guid Id)
	{
		try
		{
			if (Id == Guid.Empty) return false;
			var customer = await GetByIdAsync(Id);
			if (customer == null) return false;
			_context.Customers.Remove(customer);
			await _context.SaveChangesAsync();
			return true;
		}
		catch { return false; }
	}

	public async Task<List<CustomersListForAddTransactionViewModel>> 
		GetCustomersListForAddTransactionAsync()
		=> await _context.Customers
			.Select(c => new CustomersListForAddTransactionViewModel
			{
				Id = c.Id,
				FullName = c.FullName,
			})
			.ToListAsync();

    public async Task<List<CustomersListForAddTransactionViewModel>>
        GetCustomersListForAddTransactionByFilterAsync(string filter)
        => await _context.Customers
			.Where(c => c.FullName.Contains(filter))
            .Select(c => new CustomersListForAddTransactionViewModel
            {
                Id = c.Id,
                FullName = c.FullName,
            })
            .ToListAsync();
}
