using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AppointmentTests
    {
        [Fact]
        public void Mapping_Appointment_TestProperties()
        {
            AppointmentOptions options = new();
            options.AssertEqualProperties((Appointment)options);
        }
    }
}