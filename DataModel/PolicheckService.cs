namespace EasyPolicheck.Data;

using System.Text.Json;

public class PolicheckService
{
    string locationFile = string.Empty;

    public PolicheckService()
    {
        locationFile = Path.Combine(@"wwwroot/data", "pcLocation.json");
    }

    public void SaveLocation(IEnumerable<PolicheckLocation> location)
    {
        File.WriteAllText(locationFile, JsonSerializer.Serialize(location));
    }

    public IEnumerable<PolicheckLocation> LoadLocation()
    {
        if (!File.Exists(locationFile))
            return Enumerable.Empty<PolicheckLocation>();

        var itemJson = File.ReadAllText(locationFile);
        return JsonSerializer.Deserialize<IEnumerable<PolicheckLocation>>(itemJson) ?? Enumerable.Empty<PolicheckLocation>();
    }

}