using System;
using System.Collections.Generic;
using System.Linq;

using Moq;
using Xunit;

using CovidWeb;

namespace Covid.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test()
        {
            var data = new Mock<ILocationData>();
            data.Setup(x => x.Get()).Returns(new List<Location>{ new Location { Name = "Test"}});
            var locationService = new LocationService(data.Object);

            var locations = locationService.Get().ToList();

            Assert.Equal("Test", locations[0].Name);
        }

        [Fact]
        public void Test_State_Is_Not_Blank()
        {
            var data = new Mock<ILocationData>();
            data.Setup(x => x.Get()).Returns(new List<Location>{ new Location { Name = "Test"}});
            var locationService = new LocationService(data.Object);            

            Assert.Throws<ArgumentException>(() => locationService.Get(""));
        }

        [Fact]
        public void Test_State_Is_Not_More_Than_2_Character()
        {
            var data = new Mock<ILocationData>();
            data.Setup(x => x.Get()).Returns(new List<Location>{ new Location { Name = "Test"}});
            var locationService = new LocationService(data.Object);            

            Assert.Throws<ArgumentException>(() => locationService.Get("aaa"));
        }
    }
}
