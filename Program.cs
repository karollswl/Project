using System;
using System.Text;
using System.Collections.Generic;

using ProjectSmartHouse.Models;
using ProjectSmartHouse.Exceptions;
using ProjectSmartHouse.Services;

namespace ProjectSmartHouse;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        RunMenu();
    }

    static void RunMenu()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();

            Console.WriteLine("SMART-HOUSE MENU");

            Console.WriteLine();

            Console.WriteLine("1 - Запустити Smart-house");

            Console.WriteLine("2 - Перевірити температуру");

            Console.WriteLine("0 - Вихід");

            Console.WriteLine();

            Console.Write("Ваш вибір: ");

            string choice =
                Console.ReadLine();

            switch (choice)
            {
                case "1":

                    RunScenario();

                    break;

                case "2":

                    CheckTemperature();

                    break;

                case "0":

                    exit = true;

                    break;

                default:

                    Console.WriteLine();

                    Console.WriteLine(
                        "Невірний вибір."
                    );

                    Pause();

                    break;
            }
        }
    }

    static void RunScenario()
    {
        ShowHeader();

        RunMainScenario();

        Pause();
    }

    static void ShowHeader()
    {
        TextLoader loader =
            new TextLoader();

        string text =
            loader.LoadText(
                "Data/appText.txt"
            );

        Console.WriteLine(
            text
        );

        Console.WriteLine();
    }

    static void RunMainScenario()
    {
        User user =
            new User("Кароліна");

        SmartHouse house =
            new SmartHouse("м. Київ");

        Room room =
            new Room("Вітальня");

        Device device =
            new Device("Освітлення");

        MessageLoader messageLoader =
            new MessageLoader();

        Dictionary<string, string> messages =
            messageLoader.LoadMessages(
                "Data/messages.json"
            );

        BusinessProcess process =
            new BusinessProcess(
                "Керування Smart-house",
                messages
            );

        Console.WriteLine(
            $"Користувач: {user.UserName}"
        );

        Console.WriteLine(
            $"Адреса: {house.Address}"
        );

        Console.WriteLine(
            $"Кімната: {room.Name}"
        );

        Console.WriteLine(
            $"Пристрій: {device.Name}"
        );

        Console.WriteLine(
            $"Процес: {process.Name}"
        );

        Console.WriteLine();

        process.CheckWaterLeak();

        process.CheckGasLeak();

        process.CheckFireAlarm();

        process.CheckDoorsAndWindows();

        process.CheckTemperature();

        process.CheckLighting();

        process.CheckMedia();

        process.CheckCamera();

        Console.WriteLine();

        RunOperators(
            device
        );

        Console.WriteLine();

        RunInheritance();
    }

    static void RunOperators(
        Device device
    )
    {
        Console.WriteLine(
            "Перевірка операторів:"
        );

        Device device2 =
            new Device(
                "Камера"
            );

        Console.WriteLine(
            (device + device2).Name
        );

        Console.WriteLine(
            (device - device2).Name
        );

        Console.WriteLine(
            device == device2
        );

        Console.WriteLine(
            device != device2
        );
    }

    static void RunInheritance()
    {
        Console.WriteLine();

        Console.WriteLine(
            "Перевірка успадкування:"
        );

        LightingDevice lighting =
            new LightingDevice(
                "Освітлення у вітальні",
                80
            );

        SecurityDevice security =
            new SecurityDevice(
                "Охоронна система",
                true
            );

        lighting.TurnOn();

        security.TurnOn();

        Console.WriteLine(
            lighting.Name
        );

        Console.WriteLine(
            security.Name
        );
    }

    static void CheckTemperature()
    {
        try
        {
            Console.Write(
                "Введіть температуру: "
            );

            int temp =
                int.Parse(
                    Console.ReadLine()
                );

            if (temp > 35)
            {
                throw new SmartHouseException(
                    "Небезпечна температура."
                );
            }

            Console.WriteLine(
                "Температура нормальна."
            );
        }

        catch (FormatException)
        {
            Console.WriteLine(
                "Помилка введення."
            );
        }

        catch (SmartHouseException ex)
        {
            Console.WriteLine(
                ex.Message
            );
        }

        finally
        {
            Console.WriteLine(
                "Система завершила перевірку."
            );
        }

        Pause();
    }

    static void Pause()
    {
        Console.WriteLine();

        Console.WriteLine(
            "Натисніть будь-яку клавішу..."
        );

        Console.ReadKey();
    }
}