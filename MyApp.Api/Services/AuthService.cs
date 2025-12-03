using MyApp.Infrastructure.Data;
using MyApp.Domain.Entities;

public class AuthService
{
    private readonly AppDbContext _db;
    public AuthService(AppDbContext db)
    {
        _db = db;
    }

    public bool ValidateUser(string email, string password)
    {
        var user = _db.Users.FirstOrDefault(u => u.Email == email && u.PasswordHash == password);
        return user != null;
    }
}
