using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;
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
                SourceType = "Hello world",
                SourceApp = "Hello world",
                Key = "X-123",
                AppointmentGuid = System.Guid.NewGuid(),
                AppointmentId = 1,
                Importance = Importance.High,
                SentFromBackOffice = true
            };

            options.AssertEqualProperties((AppointmentImportance)options);
        }
    }
}