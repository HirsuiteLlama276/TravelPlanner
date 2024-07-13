using TravelPlanner.Travel;

namespace TravelPlanner;
using MongoDB.Driver;
using MongoDB.Bson;

public class databaseConnection
{
    private MongoClient _client = new MongoClient("mongodb://localhost:2701");

    public  IMongoCollection<Hotel> GetHotel()
    {
        return _client.GetDatabase("TravelPlanner").GetCollection<Hotel>("hotel");
    }

    void  SetHotel(BsonDocument hotel)
    { 
        _client.GetDatabase("TravelPlanner").GetCollection<BsonDocument>("hotel").InsertOne(hotel);
    }
}