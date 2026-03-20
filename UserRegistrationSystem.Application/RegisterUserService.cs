using UserRegistrationSystem.Domain;
using UserRegistrationSystem.Application.Interfaces;

namespace UserRegistrationSystem.Application;

public class RegisterUserService
{
    private readonly IUserRepository _repository;

    public RegisterUserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task RegisterAsync(string email, string password)
    {
        var existingUser = await _repository.GetByEmailAsync(email);

        if (existingUser != null)
            throw new Exception("User already exists");

        var user = new User(email, password);

        await _repository.AddAsync(user);
    }
}