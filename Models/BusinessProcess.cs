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

    public void CheckLighting()
    {
        Console.WriteLine("Перевірка освітлення: освітлення працює.");
    }

    public void CheckTemperature()
    {
        Console.WriteLine("Перевірка температури: температура в нормі.");
    }

    public void CheckSecurity()
    {
        Console.WriteLine("Перевірка безпеки: двері та вікна зачинені.");
    }

    public void CheckFireAlarm()
    {
        Console.WriteLine("Перевірка пожежної сигналізації: небезпеки немає.");
    }
}