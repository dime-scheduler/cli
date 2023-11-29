using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class NotificationTests
    {
        [Fact]
        public void Mapping_Notification_TestProperties()
        {
            Options.NotificationOptions options = new();
            options.AssertEqualProperties((Entities.Notification)options);
        }
    }
}