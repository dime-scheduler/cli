using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AppointmentLockedTests
    {
        [Fact]
        public void Mapping_AppointmentLocked_TestProperties()
        {
            Options.AppointmentLockedOptions options = new();
            options.AssertEqualProperties((Entities.AppointmentLocked)options);
        }
    }
}