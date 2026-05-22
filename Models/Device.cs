using ProjectSmartHouse.Interfaces;
using System;
namespace ProjectSmartHouse.Models;

public class Device : SmartComponent, ISmartDevice
{
    public string Name { get; set; }

    public Device() : base("Пристрій")
    {
    }

    public Device(string name) : base(name)
    {
    }

    public Device(Device other) : base(other.Name)
    {
    }

    public void TurnOn()
    {
        Name = Name + " увімкнено";
    }

    public void TurnOff()
    {
        Name = Name + " вимкнено";
    }

    public override bool IsActive()
    {
        return Name != "";
    }

    public bool IsDeviceActive()
    {
        return Name == "Освітлення";
    }

    public void ShowDeviceInfo()
    {
        Console.WriteLine($"Пристрій: {Name}");
        Console.WriteLine($"Пристрій активний: {IsDeviceActive()}");
    }

    public static Device operator +(Device d1, Device d2)
    {
        return new Device(d1.Name + " + " + d2.Name);
    }

    public static Device operator -(Device d1, Device d2)
    {
        return new Device(d1.Name + " без " + d2.Name);
    }

    public static Device operator *(Device d, int count)
    {
        return new Device(d.Name + " x" + count);
    }

    public static Device operator /(Device d, int count)
    {
        return new Device(d.Name + " / " + count);
    }

    public static Device operator +(Device d)
    {
        return new Device(d.Name + " увімкнено");
    }

    public static Device operator -(Device d)
    {
        return new Device(d.Name + " вимкнено");
    }

    public static Device operator ++(Device d)
    {
        return new Device(d.Name + " режим збільшено");
    }

    public static Device operator --(Device d)
    {
        return new Device(d.Name + " режим зменшено");
    }

    public static bool operator !(Device d)
    {
        return string.IsNullOrWhiteSpace(d.Name);
    }

    public static bool operator true(Device d)
    {
        return !string.IsNullOrWhiteSpace(d.Name);
    }

    public static bool operator false(Device d)
    {
        return string.IsNullOrWhiteSpace(d.Name);
    }

    public static bool operator ==(Device d1, Device d2)
    {
        if (ReferenceEquals(d1, d2))
        {
            return true;
        }

        if (d1 is null || d2 is null)
        {
            return false;
        }

        return d1.Name == d2.Name;
    }

    public static bool operator !=(Device d1, Device d2)
    {
        return !(d1 == d2);
    }

    public static bool operator >(Device d1, Device d2)
    {
        return d1.Name.Length > d2.Name.Length;
    }

    public static bool operator <(Device d1, Device d2)
    {
        return d1.Name.Length < d2.Name.Length;
    }

    public static bool operator >=(Device d1, Device d2)
    {
        return d1.Name.Length >= d2.Name.Length;
    }

    public static bool operator <=(Device d1, Device d2)
    {
        return d1.Name.Length <= d2.Name.Length;
    }

    public override bool Equals(object obj)
    {
        if (obj is Device other)
        {
            return this == other;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}