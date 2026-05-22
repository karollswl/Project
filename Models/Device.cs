namespace ProjectSmartHouse.Models;

public class Device
{
    public string Name;

    public Device()
    {
        Name = "Пристрій";
    }

    public Device(string name)
    {
        Name = name;
    }

    public Device(Device other)
    {
        Name = other.Name;
    }
}