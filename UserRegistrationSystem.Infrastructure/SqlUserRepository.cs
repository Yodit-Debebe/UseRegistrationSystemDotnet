using Microsoft.EntityFrameworkCore;
using UserRegistrationSystem.Application.Interfaces;
using UserRegistrationSystem.Domain;


namespace UserRegistrationSystem.Infrastructure;

public class SqlUserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public SqlUserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _context.Users
            .FirstOrDefaultAsync(u => u.Email == email);
    }
}