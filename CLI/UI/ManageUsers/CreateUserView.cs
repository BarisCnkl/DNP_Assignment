using Entities;
using RepositoryContracts;
using InMemoryRepository;

namespace CLI.UI.ManageUsers;

public class CreateUserView
{
    UserInMemoryRepository userRepository;
    User user;
    
    private async Task AddUserAsync(string name, string password)
    {
        // ...
        User created = await userRepository.AddAsync(user);
        // ...
    }
}