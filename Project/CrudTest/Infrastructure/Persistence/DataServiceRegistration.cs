using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;

namespace Persistence;

public static class DataServiceRegistration
{
    public static IServiceCollection AddDataServices(this IServiceCollection services,
        IConfiguration _configuration)
    {
        services.AddDbContext<MyContext>(options =>
        {
            options.UseSqlServer(_configuration.GetConnectionString("MyConnection"));
        });


        return services;
    }
}