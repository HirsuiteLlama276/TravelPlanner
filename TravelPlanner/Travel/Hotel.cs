namespace TravelPlanner.Travel;

public abstract class Hotel
{
    public int TravelId;
    public string Name;
    public string FormattedAddress;
    public string Country;
    public string City;
    public string PhotoUrl;
    public string Description;

    public Hotel(int travelId, string name, string formattedAddress, string country, string city, string photoUrl, string description)
    {
        this.TravelId = travelId;
        Name = name;
        this.FormattedAddress = formattedAddress;
        this.Country = country;
        this.City = city;
        this.PhotoUrl = photoUrl;
        Description = description;
    }
}