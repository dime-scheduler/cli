using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class TaskTests
    {
        [Fact]
        public void Mapping_Task_TestProperties()
        {
            Options.TaskOptions options = new();
            options.AssertEqualProperties((Sdk.Import.Task)options);
        }
    }
}