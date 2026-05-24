using System.IO;

namespace ProjectSmartHouse.Services;

public class TextLoader
{
    public string LoadText(
        string path
    )
    {
        return File.ReadAllText(
            path
        );
    }
}