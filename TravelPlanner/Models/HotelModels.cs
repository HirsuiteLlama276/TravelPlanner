namespace TravelPlanner.Models
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public List<Day> DaysList { get; set; }
    }

    public class Day
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
