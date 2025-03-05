using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController()
    {
        var logger = new Logger();
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




}

