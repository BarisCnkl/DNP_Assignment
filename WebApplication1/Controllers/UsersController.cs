using ApiContracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using RepositoryContracts;

namespace WebApplication1.Controllers;

[ApiController]
[Route("controller")]

public class UsersController : ControllerBase
{
    private readonly IUserRepository userRepo;

    public UsersController(IUserRepository userRepo)
    {
        this.userRepo = userRepo;
    }
    [HttpPost]
    public async Task<ActionResult<UserDTO>> AddUser([FromBody] CreateUserDto request)
    {
        await VerifyUserNameIsAvailableAsync(request.UserName);

        User user = new(request.UserName, request.Password);
        User created = await userRepo.AddAsync(user);
        UserDTO dto = new()
        {
            Id = created.Id,
            UserName = created.Username
        };
        return Created($"/Users/{dto.Id}", created); 
    }

    private async Task VerifyUserNameIsAvailableAsync(string requestUserName)
    {
        throw new NotImplementedException();
    }
}
