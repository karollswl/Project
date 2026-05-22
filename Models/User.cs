namespace ProjectSmartHouse.Models;

public class User
{
    public string UserName { get; set; }

    public User()
    {
        UserName = "Користувач";
    }

    public User(string userName)
    {
        UserName = userName;
    }

    public User(User other)
    {
        UserName = other.UserName;
    }
}