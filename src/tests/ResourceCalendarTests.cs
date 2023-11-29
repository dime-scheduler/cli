using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class ResourceCalendarTests
    {
        [Fact]
        public void Mapping_ResourceCalendar_TestProperties()
        {
            Options.ResourceCalendarOptions options = new();
            options.AssertEqualProperties((Entities.ResourceCalendar)options);
        }
    }
}