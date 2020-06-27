using System;
using System.Collections.Generic;

namespace CovidWeb
{
    public interface ILocationService
    {
        IEnumerable<Location> Get();
        IEnumerable<Location> Get(string state);
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

        public IEnumerable<Location> Get(string state)
        {
            if(state.Equals(string.Empty) || state.Length != 2)
            {
                throw new ArgumentException("State must be 2 characters and not blank", "state");
            }

            return _data.Get(state);
        }
    }
}