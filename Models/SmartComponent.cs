namespace ProjectSmartHouse.Models;

public abstract class SmartComponent
{
    public string Name { get; set; }

    public SmartComponent(string name)
    {
        Name = name;
    }
}