using MongoDB.Driver;

namespace TravelPlanner.Travel;

public class travel
{
    private hotel travelHotel;
    databaseConnection  data = new databaseConnection();

    void GetTravel(int travelId)
    {
        var hotel = data.GetHotel();
        var result = hotel.Find(task => travelHotel.TravelId == 1).ToList();
    }
}