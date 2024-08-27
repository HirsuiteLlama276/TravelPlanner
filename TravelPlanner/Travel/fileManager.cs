namespace TravelPlanner.Travel;

public class fileManager
{
    private static string filePath = "hotels.json";

    public async Task saveHotel(string hotel)
    {
        await File.WriteAllTextAsync(filePath, hotel + Environment.NewLine);
        Console.WriteLine(hotel);
    }
}
