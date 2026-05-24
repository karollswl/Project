using System;
using System.Text;
using ProjectSmartHouse.Models;
using ProjectSmartHouse.Exceptions;
using ProjectSmartHouse.Services;
using System.Collections.Generic;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

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

User user = new User("Кароліна");
SmartHouse house = new SmartHouse("м. Київ");
Room room = new Room("Вітальня");
Device device = new Device("Освітлення");

MessageLoader messageLoader = new MessageLoader();

Dictionary<string, string> messages =
    messageLoader.LoadMessages("Data/messages.json");

BusinessProcess process = new BusinessProcess("Керування Smart-house", messages);

Console.WriteLine($"Користувач: {user.UserName}");
Console.WriteLine($"Адреса: {house.Address}");
Console.WriteLine($"Кімната: {room.Name}");
Console.WriteLine($"Пристрій: {device.Name}");
Console.WriteLine($"Процес: {process.Name}");

Console.WriteLine();

Console.WriteLine("Перевірка процесів Smart-house:");

process.CheckWaterLeak();  // перевірка витоку води
process.CheckGasLeak();  // перевірка витоку газу
process.CheckFireAlarm();  // пожежна сигналізація
process.CheckDoorsAndWindows();  // перевірка дверей та вікон
process.CheckTemperature();  // перевірка температури
process.CheckLighting();  // перевірка освітлення
process.CheckMedia();  // перевірка аудіо/відео
process.CheckCamera();  // перевірка відеоспостереження

Console.WriteLine();

Console.WriteLine("Перевірка операторів:");

Device device2 = new Device("Камера");
Device addDevice = device + device2;
Device removeDevice = device - device2;

Console.WriteLine($"Оператор + : {addDevice.Name}");
Console.WriteLine($"Оператор - : {removeDevice.Name}");
Console.WriteLine($"Оператор == : {device == device2}");
Console.WriteLine($"Оператор != : {device != device2}");
Console.WriteLine($"Оператор > : {device > device2}");
Console.WriteLine($"Оператор < : {device < device2}");

Console.WriteLine();

Console.WriteLine("Перевірка успадкування:");

LightingDevice lightingDevice = new LightingDevice("Освітлення у вітальні", 80);
SecurityDevice securityDevice = new SecurityDevice("Охоронна система", true);

Console.WriteLine($"Пристрій освітлення: {lightingDevice.Name}");
Console.WriteLine($"Яскравість: {lightingDevice.Brightness}");

Console.WriteLine();

Console.WriteLine($"Пристрій безпеки: {securityDevice.Name}");
Console.WriteLine($"Сигналізація активна: {securityDevice.AlarmEnabled}");

Console.WriteLine();

lightingDevice.TurnOn();
securityDevice.TurnOn();

Console.WriteLine($"Після увімкнення: {lightingDevice.Name}");
Console.WriteLine($"Після увімкнення: {securityDevice.Name}");

lightingDevice.TurnOff();
securityDevice.TurnOff();

Console.WriteLine($"Після вимкнення: {lightingDevice.Name}");
Console.WriteLine($"Після вимкнення: {securityDevice.Name}");

Console.WriteLine();

Console.WriteLine("Перевірка критичних ситуацій:");

try
{
    Console.Write("Введіть температуру будинку: ");
    int temperature = int.Parse(Console.ReadLine());

    if (temperature > 35)
    {
        throw new SmartHouseException("Небезпечна температура в будинку.");
    }

    Console.WriteLine("Температура в нормі.");
}
catch (FormatException)
{
    Console.WriteLine("Помилка: температуру введено неправильно.");
}
catch (SmartHouseException ex)
{
    Console.WriteLine($"Критична ситуація: {ex.Message}");
}
finally
{
    Console.WriteLine("Система завершила перевірку.");
}

Console.WriteLine();

Console.WriteLine("Фініш імітації");

Console.ReadKey();