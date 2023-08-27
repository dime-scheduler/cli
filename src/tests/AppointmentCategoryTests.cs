using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AppointmentCategoryTests
    {
        [Fact]
        public void Mapping_AppointmentCategory_TestProperties()
        {
            AppointmentCategoryOptions options = new()
            {               
                SourceType = "Hello world",
                SourceApp = "Hello world",
                Key =  "Hello world",
                AppointmentGuid = System.Guid.NewGuid(),
                AppointmentId = 1,
                Category = "Hello world",
                SentFromBackOffice = true
            };

            options.AssertEqualProperties((AppointmentCategory)options);
        }
    }
}