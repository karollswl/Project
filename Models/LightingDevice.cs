namespace ProjectSmartHouse.Models;

public class LightingDevice : Device
{
    public int Brightness { get; set; }

    public LightingDevice(string name, int brightness) : base(name)
    {
        Brightness = brightness;
    }
}