namespace ProjectSmartHouse.Models;

public class SmartHouse
{
    public string Address { get; set; }

    public SmartHouse()
    {
        Address = "Невідома адреса";
    }

    public SmartHouse(string address)
    {
        Address = address;
    }

    public SmartHouse(SmartHouse other)
    {
        Address = other.Address;
    }
}