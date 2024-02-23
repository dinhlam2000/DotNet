using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;

[ApiController]
[Route("[controller]")] // logic to reach in the class name and find its name and set the name to be everything before 'controller'
public class UserController : ControllerBase
{

    public UserController()
    {

    }

    [HttpGet("GetUsers/{testValue}")]
    public string[] GetUsers(string testValue)
    {
        string[] responseArray = new string[] {
            "test1", "test2", testValue
        };
        return responseArray;
    }
}
