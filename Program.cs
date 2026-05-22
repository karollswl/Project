using System;
using System.Text;
using ProjectSmartHouse.Models;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("ПІБ: Кохан Кароліна Сергіївна");
Console.WriteLine("Курс: 1");
Console.WriteLine("Група: ІПЗ-11");

Console.WriteLine();

Console.WriteLine("Тема: Моделювання бізнес-процесів в системі Smart-house");

Console.WriteLine();

Console.WriteLine("Версія 3:");

Console.WriteLine();

Console.WriteLine("Старт імітації");

Console.WriteLine();

User user = new User("Кароліна");

SmartHouse house = new SmartHouse("м. Київ");

Room room = new Room("Вітальня");

Device device = new Device("Освітлення");

BusinessProcess process = new BusinessProcess("Керування освітленням");

Console.WriteLine($"Користувач: {user.UserName}");

Console.WriteLine($"Адреса: {house.Address}");

Console.WriteLine($"Кімната: {room.Name}");

Console.WriteLine($"Пристрій: {device.Name}");

Console.WriteLine($"Процес: {process.Name}");

Console.WriteLine();

Console.WriteLine("Перевірка методів версії 3:");

device.ShowDeviceInfo();

process.ShowProcessInfo();

Console.WriteLine();

Console.WriteLine("Фініш імітації");

Console.ReadKey();