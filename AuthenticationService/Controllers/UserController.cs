using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private Ilogger _logger;
    public UserController(Ilogger logger)
    {
        _logger = logger;
        logger.WriteEvent("сообщение о событии в программе");
        logger.WriteError("сообщение об ошибке в программе");
    }
    [HttpGet]
    public User GetUser()
    {
        return new User
        {
            Id = new Guid(),
            FirstName = "Anton",
            LastName = "Antonov",
            Login = "anton",
            Password = "123",
            Email = "ant@mail.com"
        };
    }
    [HttpGet]
    [Route("viewmodel")]
    public UserViewModel GetUserViewModel()
    {
        User user = new User()
        {
            Id = Guid.NewGuid(),
            FirstName = "Иван",
            LastName = "Иванов",
            Email = "ivan@gmail.com",
            Password = "111",
            Login = "ivanov"
        };

        UserViewModel userViewModel = new UserViewModel(user);

        return userViewModel;
    }




}

