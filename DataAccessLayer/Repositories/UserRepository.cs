using DataAccessLayer.IRepository;

namespace DataAccessLayer.Repository;

public class UserRepository : IUserRepository
{
    private readonly UserContext _context;

    public UserRepository(UserContext context)
    {
        _context = context;
    }

    public void CreateNewUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }
    public IEnumerable<User> GetAllUsers()
    {
        return _context.Users.ToList();
    }
}