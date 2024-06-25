using System.Net.Http.Json;

namespace TravelPlanner;

public class myHttpClient: HttpClient
{
    private HttpClient _client = new HttpClient();
    private const string GetApiKey = "AIzaSyDG4Nl7kgH0kri6TlLd6nsB162XHy-X_A0";

    public void AddHeader(string name, string value)
    {
        _client.DefaultRequestHeaders.Add(name,value);
    }
    public myHttpClient()
    {
        _client.BaseAddress = new Uri("https://places.googleapis.com/v1/");
        _client.DefaultRequestHeaders.Add("X-Goog-Api-Key", GetApiKey);
        _client.DefaultRequestHeaders.Add("accept","application/json");
    }



    
    public async Task<HttpResponseMessage> SearchForHotel(string hotelName)
    {
       HttpResponseMessage task = await _client.PostAsJsonAsync("./places:searchText",  new { textQuery = hotelName });
       return task;
    }


}