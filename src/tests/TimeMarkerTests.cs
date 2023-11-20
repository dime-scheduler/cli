using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class TimeMarkerTests
    {
        [Fact]
        public void Mapping_TimeMarker_TestProperties()
        {
            Options.TimeMarkerOptions options = new();
            options.AssertEqualProperties((Sdk.Models.TimeMarker)options);
        }
    }
}