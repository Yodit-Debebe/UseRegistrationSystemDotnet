using UserRegistrationSystem.Domain;

namespace UserRegistrationSystem.Application.Interfaces;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task<User?> GetByEmailAsync(string email);
}