using Entities;
using RepositoryContracts;
using InMemoryRepository;

namespace CLI.UI.ManageUsers;

public class CreateUserView
{
    private readonly IUserRepository userRepository;
    
    private async Task AddUserAsync()
    {
        string username = string.Empty;
        Console.Write("Enter username: ");
        username = Console.ReadLine();
        await userRepository.AddAsync(new User{Username = username});
        Console.WriteLine($"User {username} created!");
    }
}