using TravelPlanner.Travel;

namespace TravelPlanner;
using MongoDB.Driver;
using MongoDB.Bson;

public class databaseConnection
{
    private MongoClient _client = new MongoClient("mongodb://localhost:27017\"");

    public IMongoCollection<hotel> GetHotel()
    {
        return _client.GetDatabase("TravelPlanner").GetCollection<hotel>("hotel");
    }
}