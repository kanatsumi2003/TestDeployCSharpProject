namespace DataAccessLayer.IRepository;

public interface IUserRepository
{
    IEnumerable<User> GetAllUsers();
    void CreateNewUser(User user);
}