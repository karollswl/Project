namespace ProjectSmartHouse.Models;

public class BusinessProcess
{
    public string Name;

    public BusinessProcess()
    {
        Name = "Процес";
    }

    public BusinessProcess(string name)
    {
        Name = name;
    }

    public BusinessProcess(BusinessProcess other)
    {
        Name = other.Name;
    }
}