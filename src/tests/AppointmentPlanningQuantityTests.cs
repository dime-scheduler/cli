using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AppointmentPlanningQuantityTests
    {
        [Fact]
        public void Mapping_AppointmentPlanningQuantity_TestProperties()
        {
            AppointmentPlanningQuantityOptions options = new()
            {
                Append = true,
                User = "Hello world",
                Uri = "Hello world",
                SourceType = "Hello world",
                SourceApp = "Hello world",
                Password = "Hello world",
                AppointmentGuid = System.Guid.NewGuid(),
                AppointmentId = 1,
                Quantity = 25,
                Delete = true,
                SentFromBackOffice = true
            };

            options.AssertEqualProperties((AppointmentPlanningQuantity)options);
        }
    }
}