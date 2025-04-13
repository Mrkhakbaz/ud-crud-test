using Domain.Aggregates.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context;

public class MyContext(DbContextOptions<MyContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }
}
