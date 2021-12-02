using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AppointmentImportanceTests
    {
        [Fact]
        public void Mapping_AppointmentImportance_TestProperties()
        {
            AppointmentImportanceOptions options = new()
            {
                Append = true,
                User = "Hello world",
                Uri = "Hello world",
                SourceType = "Hello world",
                SourceApp = "Hello world",
                Password = "Hello world",
                AppointmentGuid = System.Guid.NewGuid(),
                AppointmentId = 1,
                Importance = 1,
                Delete = true,
                SentFromBackOffice = true
            };

            options.AssertEqualProperties((AppointmentImportance)options);
        }
    }
}