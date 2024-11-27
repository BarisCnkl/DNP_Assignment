using ApiContracts;

namespace BlazorApp.Services;

public interface IUserService
{
    public Task<UserDTO> AddUserAsync(CreateUserDto request);
    public Task UpdateUserAsync(int id, UpdateUserDto request);
    // ... more methods
}