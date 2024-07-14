using MongoDB.Driver;

namespace TravelPlanner.Travel;

public class Travel
{
    private Hotel travelHotel;
    databaseConnection  data = new databaseConnection();

    void GetTravel(int travelId)
    {
        var hotel = data.GetHotel();
        var result = hotel.Find(task => travelHotel.TravelId == 1).ToList();
    }

    void SaveTravel()
    {
        
    }
}