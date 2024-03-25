namespace APBD3;

public static class SerialNumberGenerator
{
    private static Dictionary<string, int> _lastNumbers = new Dictionary<string, int>
    {
        { "C", 0 },
        { "G", 0 },
        { "L", 0 }
    };

    public static string GenerateSerialNumber(string containerType)
    {
        _lastNumbers[containerType]++;
        return $"KON-{containerType}-{_lastNumbers[containerType]}";
    }
}