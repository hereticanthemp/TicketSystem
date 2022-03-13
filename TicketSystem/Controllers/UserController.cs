using Microsoft.AspNetCore.Mvc;
using TicketSystem.Models;
using TicketSystem.Services;

namespace TicketSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ICollection<User> GetUsers()
        {
            return _userService.GetUsers();
        }

        [HttpPost]
        public void AddUser(User user)
        {
            _userService.AddUser(user);
        }

        [HttpPost]
        public void ModifyUser(User user)
        {
            _userService.ModifyUser(user);
        }
    }
}
