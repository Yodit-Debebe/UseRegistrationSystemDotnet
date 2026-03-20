using Microsoft.EntityFrameworkCore;
using UserRegistrationSystem.Domain;

namespace UserRegistrationSystem.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}