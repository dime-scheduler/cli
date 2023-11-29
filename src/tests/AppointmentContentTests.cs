using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AppointmentContentTests
    {
        [Fact]
        public void Mapping_AppointmentContent_TestProperties()
        {
            AppointmentContentOptions options = new();
            options.AssertEqualProperties((AppointmentContent)options);
        }
    }
}