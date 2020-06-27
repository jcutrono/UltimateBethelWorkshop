using System.Collections.Generic;

namespace CovidWeb
{
    public interface ILocationService
    {
        IEnumerable<Location> Get();
    }
    public class LocationService : ILocationService
    {
        private ILocationData _data;

        public LocationService(ILocationData data)
        {
            _data = data;
        }

        public IEnumerable<Location> Get()
        {
            return _data.Get();
        }
    }
}