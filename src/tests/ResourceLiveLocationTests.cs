using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class ResourceLiveLocationTests
    {
        [Fact]
        public void Mapping_ResourceLiveLocation_TestProperties()
        {
            ResourceLiveLocationOptions options = new()
            {
                Key = "X-123",
                Latitude = 35.25M,
                Longitude = 15.15M,
                ResourceNo = "RESOURCENO"
            };

            options.AssertEqualProperties((ResourceGpsTracking)options);
        }
    }
}