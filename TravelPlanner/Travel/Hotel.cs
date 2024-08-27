namespace TravelPlanner.Travel;

public class Hotel
{
    public string Name;
    public string PhotoUrl;
    public string website;

    public Hotel(string name, string photoUrl, string website)
    {
        Name = name;
        this.PhotoUrl = photoUrl;
        this.website = website;
    }
}