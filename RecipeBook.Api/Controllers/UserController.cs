using BusinessLogicLayer.IServices;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace RecipeBook.Api.Controllers;
[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetUsers()
    {
        return Ok(_userService.GetAllUsers());
    }

    [HttpPost]
    public void AddNewUser(User user)
    {
        _userService.AddNewUser(user);
    }
}