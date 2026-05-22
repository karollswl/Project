using System;

namespace ProjectSmartHouse.Models;

public class BusinessProcess
{
    public string Name { get; set; }

    public BusinessProcess(string name)
    {
        Name = name;
    }

    public void CheckWaterLeak()
    {
        Console.WriteLine("Перевірка витоку води: витоку не виявлено.");
    }

    public void CheckGasLeak()
    {
        Console.WriteLine("Перевірка витоку газу: витоку не виявлено.");
    }

    public void CheckFireAlarm()
    {
        Console.WriteLine("Перевірка пожежної сигналізації: небезпеки немає.");
    }

    public void CheckDoorsAndWindows()
    {
        Console.WriteLine("Перевірка дверей та вікон: усе зачинено.");
    }

    public void CheckTemperature()
    {
        Console.WriteLine("Перевірка температури: температура контролюється.");
    }

    public void CheckLighting()
    {
        Console.WriteLine("Перевірка освітлення: освітлення працює.");
    }

    public void CheckMedia()
    {
        Console.WriteLine("Перевірка аудіо/відео: система працює.");
    }

    public void CheckCamera()
    {
        Console.WriteLine("Перевірка відеоспостереження: камери працюють.");
    }
}