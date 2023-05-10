using Core.Context;
using Infrastructure.Services;
using Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace UI;

static class Program
{
    private static ServiceProvider ServiceProvider { get; set; } = null!;

    static void ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddDbContext<AccountingContext>();
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<ITransactionService, TransactionService>();

        ServiceProvider = services.BuildServiceProvider();
    }

    public static T? GetService<T>() where T : class
        => (T?)ServiceProvider.GetService<T>();

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        ConfigureServices();
        if (DbConfig.Create())
            GetService<AccountingContext>()?.Database.Migrate();
        Application.Run(new FormMain());
    }
}