using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AppointmentUriTests
    {
        [Fact]
        public void Mapping_AppointmentUri_TestProperties()
        {

            Options.AppointmentUriOptions options = new();
            options.AssertEqualProperties((Sdk.Import.AppointmentUri)options);
        }
    }
}