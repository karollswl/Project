namespace ProjectSmartHouse.Models;

public class SecurityDevice : Device
{
    public bool AlarmEnabled { get; set; }

    public SecurityDevice() : base("Сигналізація")
    {
        AlarmEnabled = true;
    }

    public SecurityDevice(string name, bool alarmEnabled) : base(name)
    {
        AlarmEnabled = alarmEnabled;
    }
}