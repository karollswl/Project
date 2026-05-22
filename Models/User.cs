namespace ProjectSmartHouse.Models;

public class User
{
    public string UserName { get; set; }

    public User(string userName)
    {
        UserName = userName;
    }
}