using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AppointmentContainerTests
    {
        [Fact]
        public void Mapping_AppointmentContainer_TestProperties()
        {
            AppointmentContainerOptions options = new()
            {
                Append = true,
                Uri = "Hello world",
                Key =  "Hello world",
                Container = "Hello world",
                Delete = true,
                Appointment = "15"
            };

            options.AssertEqualProperties((AppointmentContainer)options);
        }
    }
}