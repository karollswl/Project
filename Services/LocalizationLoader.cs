using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ProjectSmartHouse.Services;

public class LocalizationLoader
{
    public Dictionary<string, string> LoadLocalization(string path)
    {
        string json = File.ReadAllText(path);

        Dictionary<string, string> localization =
            JsonSerializer.Deserialize<Dictionary<string, string>>(json);

        if (localization == null)
        {
            localization = new Dictionary<string, string>();
        }

        return localization;
    }
}