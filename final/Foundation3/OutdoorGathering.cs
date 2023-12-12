public class OutdoorGathering:Event
{
    private string _weather;

        public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
        {
            _type = "Outdoor Gathering";
            _weather = weather;
        }

        public string FullDetails()
        {
            return $"{StandardDetails()}\nWeather: {_weather}";
        }
}