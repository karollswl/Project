using System;
using System.Collections.Generic;

namespace ProjectSmartHouse.Models;

public class BusinessProcess
{
    public string Name { get; set; }

    private Dictionary<string, string> Messages;

    public BusinessProcess(string name, Dictionary<string, string> messages)
    {
        Name = name;
        Messages = messages;
    }

    public void CheckWaterLeak()
    {
        Console.WriteLine(Messages["WaterLeak"]);
    }

    public void CheckGasLeak()
    {
        Console.WriteLine(Messages["GasLeak"]);
    }

    public void CheckFireAlarm()
    {
        Console.WriteLine(Messages["FireAlarm"]);
    }

    public void CheckDoorsAndWindows()
    {
        Console.WriteLine(Messages["DoorsAndWindows"]);
    }

    public void CheckTemperature()
    {
        Console.WriteLine(Messages["Temperature"]);
    }

    public void CheckLighting()
    {
        Console.WriteLine(Messages["Lighting"]);
    }

    public void CheckMedia()
    {
        Console.WriteLine(Messages["Media"]);
    }

    public void CheckCamera()
    {
        Console.WriteLine(Messages["Camera"]);
    }
}