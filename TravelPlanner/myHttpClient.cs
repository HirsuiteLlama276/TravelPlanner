using System.Net;
using System.Net.Http.Json;

namespace TravelPlanner;

public class myHttpClient: HttpClient
{
    private HttpClient _client = new HttpClient();
    private const string GetApiKey = "";

    public void AddHeader(string name, string value)
    {
        _client.DefaultRequestHeaders.Add(name,value);
    }
    public myHttpClient()
    {
    }
    
    public async Task<HttpResponseMessage> SearchForHotel(string hotelName)
    {
        _client.BaseAddress = new Uri("https://places.googleapis.com/v1/");
        _client.DefaultRequestHeaders.Add("X-Goog-Api-Key", GetApiKey);
        _client.DefaultRequestHeaders.Add("accept","application/json");
        _client.DefaultRequestHeaders.Add("X-Goog-FieldMask", "places.displayName,places.id,places.photos");
       HttpResponseMessage task = await _client.PostAsJsonAsync("./places:searchText",  new { textQuery = hotelName });
       return task;
    }
    public async Task<HttpResponseMessage> SearchForHotelPhotos(string placeId)
    {
        Console.WriteLine(placeId);
        _client.DefaultRequestHeaders.Add("accept","application/json");
        HttpResponseMessage response = await _client.GetAsync($"https://places.googleapis.com/v1/{placeId}/media?maxHeightPx=1920&maxWidthPx=1080&key={GetApiKey}&skipHttpRedirect=true");
        //HttpResponseMessage response = await _client.GetAsync("https://places.googleapis.com/v1/places/ChIJNTbAYao6F0cRGih4nWitIy4/photos/ATplDJbZOD5DInnAmH_WkQmMeBJHVooSb8DRbzIKWnYKGF886gZNHBXlENZlSMNgApBXBuXcIE4kTzlDcCf0eWE9fRcsyc2OK1fN4VM2Q-U-LCzMVVsDw7vgK1elV9iA1aFtrVzy77x9cmwPmSW2mEanZLky0nKZsXYqj7PN/media?maxHeightPx=1920&maxWidthPx=1080&key=AIzaSyDG4Nl7kgH0kri6TlLd6nsB162XHy-X_A0&skipHttpRedirect=true");
        return response;
    }
}