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

Console.WriteLine("Версія 5:");

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

Console.WriteLine("Перевірка операторів:");

Device device2 = new Device("Камера");

Device addDevice = device + device2;

Device removeDevice = device - device2;

Console.WriteLine($"Оператор + : {addDevice.Name}");

Console.WriteLine($"Оператор - : {removeDevice.Name}");

Console.WriteLine();

Console.WriteLine("Перевірка методів другого пріоритету:");

process.CheckLighting();

process.CheckTemperature();

process.CheckSecurity();

process.CheckFireAlarm();

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

Console.WriteLine($"Освітлення активне: {lightingDevice.IsActive()}");
Console.WriteLine($"Безпека активна: {securityDevice.IsActive()}");

Console.WriteLine("Фініш імітації");

Console.ReadKey();