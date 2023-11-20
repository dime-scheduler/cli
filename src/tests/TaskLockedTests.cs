using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class TaskLockedTests
    {
        [Fact]
        public void Mapping_TaskLocked_TestProperties()
        {
            Options.TaskLockedOptions options = new();
            options.AssertEqualProperties((Sdk.Models.TaskLocked)options);
        }
    }
}