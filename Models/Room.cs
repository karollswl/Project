namespace ProjectSmartHouse.Models;

public class Room
{
    public string Name;

    public Room()
    {
        Name = "Кімната";
    }

    public Room(string name)
    {
        Name = name;
    }

    public Room(Room other)
    {
        Name = other.Name;
    }
}