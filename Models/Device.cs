using ProjectSmartHouse.Interfaces;

namespace ProjectSmartHouse.Models;

public class Device : SmartComponent, ISmartDevice
{
    public Device(string name) : base(name)
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

    public static Device operator +(Device d1, Device d2)
    {
        return new Device(d1.Name + " + " + d2.Name);
    }

    public static Device operator -(Device d1, Device d2)
    {
        return new Device(d1.Name + " без " + d2.Name);
    }

    public static bool operator ==(Device d1, Device d2)
    {
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