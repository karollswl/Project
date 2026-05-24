using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ProjectSmartHouse.Services;

public class MessageLoader
{
    public Dictionary<string, string> LoadMessages(string path)
    {
        string json = File.ReadAllText(path);

        Dictionary<string, string> messages =
            JsonSerializer.Deserialize<Dictionary<string, string>>(json);

        if (messages == null)
        {
            messages = new Dictionary<string, string>();
        }

        return messages;
    }
}