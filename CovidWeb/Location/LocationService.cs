namespace CovidWeb
{
    public interface ILocationService
    {
        string Get();
    }
    public class LocationService : ILocationService
    {
        public LocationService()
        {
        }

        public string Get()
        {
            return "hello";
        }
    }
}