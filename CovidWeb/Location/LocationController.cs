using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CovidWeb
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {        
        private ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IEnumerable<Location> Get()
        {
            return _locationService.Get();
        }

        [HttpGet("{state}")]
        public IEnumerable<Location> Get(string state)
        {
            return _locationService.Get(state);
        }
    }
}
