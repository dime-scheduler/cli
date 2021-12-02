using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AppointmentTimeMarkerTests
    {
        [Fact]
        public void Mapping_AppointmentTimeMarker_TestProperties()
        {
            AppointmentTimeMarkerOptions options = new()
            {
                Append = true,
                User = "Hello world",
                Uri = "Hello world",
                SourceType = "Hello world",
                SourceApp = "Hello world",
                Password = "Hello world",
                AppointmentGuid = System.Guid.NewGuid(),
                AppointmentId = 1,
                TimeMarker = "Hello world",
                Delete = true,
                SentFromBackOffice = true
            };

            options.AssertEqualProperties((AppointmentTimeMarker)options);
        }
    }
}