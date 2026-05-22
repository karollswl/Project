using System;
namespace ProjectSmartHouse.Models;

public class Device
{
    public string Name { get; set; }

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

    public bool IsDeviceActive()
    {
        return Name == "Освітлення";
    }

    public void ShowDeviceInfo()
    {
        Console.WriteLine($"Пристрій: {Name}");
        Console.WriteLine($"Пристрій активний: {IsDeviceActive()}");
    }
}