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
    
    public async Task<HttpResponseMessage> SearchForHotel(string hotelName)
    {
        _client.BaseAddress = new Uri("https://places.googleapis.com/v1/");
        _client.DefaultRequestHeaders.Add("X-Goog-Api-Key", GetApiKey);
        _client.DefaultRequestHeaders.Add("accept","application/json");
        _client.DefaultRequestHeaders.Add("X-Goog-FieldMask", "places.displayName,places.id,places.photos,places.websiteUri");
       HttpResponseMessage task = await _client.PostAsJsonAsync("./places:searchText",  new { textQuery = hotelName });
       return task;
    }
    public async Task<HttpResponseMessage> SearchForHotelPhotos(string placeId)
    {
        _client.DefaultRequestHeaders.Add("accept","application/json");
        HttpResponseMessage task = await _client.GetAsync($"https://places.googleapis.com/v1/{placeId}/media?maxHeightPx=1920&maxWidthPx=1080&key={GetApiKey}&skipHttpRedirect=true");
        return task;
    }
}