using Domain.Entities;
using Infrastructure.ViewModels;

namespace Infrastructure.Services.Interfaces;

public interface ICustomerService
{
    Task<bool> CreateCustomerAsync(CreateCustomerViewModel model);
    Task<bool> DeleteCustomerAsync(Guid Id);
    Task<List<CustomersListViewModel>> GetAllAsync();
    Task<Customer> GetByIdAsync(Guid Id);
    Task<List<CustomersListForAddTransactionViewModel>> GetCustomersListForAddTransactionAsync();
    Task<List<CustomersListForAddTransactionViewModel>> GetCustomersListForAddTransactionByFilterAsync(string filter);
    Task<bool> UpdateCustomerAsync(UpdateCustomerViewModel model);
}
