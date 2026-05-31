using System;
using System.Collections.Generic;

namespace ProjectSmartHouse.Models;

public class BusinessProcess
{
    public string Name { get; set; }

    private Dictionary<string, string> Localization;

    public BusinessProcess(string name, Dictionary<string, string> localization)
    {
        Name = name;
        Localization = localization;
    }

    public void CheckWaterLeak()
    {
        Console.WriteLine(Localization["WaterLeak"]);
    }

    public void CheckGasLeak()
    {
        Console.WriteLine(Localization["GasLeak"]);
    }

    public void CheckFireAlarm()
    {
        Console.WriteLine(Localization["FireAlarm"]);
    }

    public void CheckDoorsAndWindows()
    {
        Console.WriteLine(Localization["DoorsAndWindows"]);
    }

    public void CheckTemperature()
    {
        Console.WriteLine(Localization["Temperature"]);
    }

    public void CheckLighting()
    {
        Console.WriteLine(Localization["Lighting"]);
    }

    public void CheckMedia()
    {
        Console.WriteLine(Localization["Media"]);
    }

    public void CheckCamera()
    {
        Console.WriteLine(Localization["Camera"]);
    }
}