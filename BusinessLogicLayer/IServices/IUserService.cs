using DataAccessLayer;

namespace BusinessLogicLayer.IServices;

public interface IUserService
{
    IEnumerable<User> GetAllUsers();
    void AddNewUser(User user);
}