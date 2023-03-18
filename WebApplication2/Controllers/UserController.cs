using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("createUser")]
        public UserModel CreateUser(UserModel model)
        {
            _userService.Create(model);
            return model;
        }
        [HttpGet]
        [Route("getUsers")]
        public IEnumerable<UserModel> GetUsers()
        {
            return _userService.GetAll();
        }
        [HttpGet]
        [Route("getUser/{id}")]
        public UserModel GetUrl(int id)
        {
            var url = _userService.GetById(id);
            return url;
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public void Delete(int id)
        {
            _userService.DeleteById(id);
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(UserLoginModel user)
        {
            var result = _userService.LogIn(user.Email, user.Password);
            return Ok(result);
        }
        [HttpPost]
        [Route("signup")]
        public UserModel Signup(UserSignUpModel userModel)
        {
            var user = new UserModel()
            {
                Email = userModel.Email,
                Username = userModel.UserName,
                Role = "User",
                Password = userModel.Password
            };
            _userService.SignUp(user);
            return user;
        }
    }
}
