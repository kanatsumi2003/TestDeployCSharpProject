using BusinessLogicLayer.IServices;
using DataAccessLayer;
using DataAccessLayer.IRepository;

namespace BusinessLogicLayer.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public IEnumerable<User> GetAllUsers()
    {
        return _userRepository.GetAllUsers();
    }

    public void AddNewUser(User user)
    {
        _userRepository.CreateNewUser(user);
    }
}