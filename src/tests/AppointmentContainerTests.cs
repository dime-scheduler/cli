using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;
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
                Key = "Hello world",
                Container = "Hello world",
                Appointment = "15"
            };

            options.AssertEqualProperties((AppointmentContainer)options);
        }
    }
}