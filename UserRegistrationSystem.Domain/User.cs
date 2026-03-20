namespace UserRegistrationSystem.Domain;

public class User
{
    public Guid Id { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public User(string email, string password)
    {
        if (!email.Contains("@"))
            throw new ArgumentException("Invalid email");

        Id = Guid.NewGuid();
        Email = email;
        Password = password;
    }
}