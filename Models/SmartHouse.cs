namespace ProjectSmartHouse.Models;

public class SmartHouse
{
    public string Address { get; set; }

    public SmartHouse(string address)
    {
        Address = address;
    }
}