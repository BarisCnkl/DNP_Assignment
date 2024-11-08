namespace Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public User(string Username, string password )
    {
        this.Username = Username;
        this.Password = password;
    }
}