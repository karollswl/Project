using System;
namespace ProjectSmartHouse.Models;

public class BusinessProcess
{
    public string Name { get; set; }

    public BusinessProcess()
    {
        Name = "Процес";
    }

    public BusinessProcess(string name)
    {
        Name = name;
    }

    public BusinessProcess(BusinessProcess other)
    {
        Name = other.Name;
    }

    public bool IsProcessActive()
    {
        return Name == "Керування освітленням";
    }

    public void ShowProcessInfo()
    {
        Console.WriteLine($"Процес: {Name}");
        Console.WriteLine($"Процес активний: {IsProcessActive()}");
    }
}