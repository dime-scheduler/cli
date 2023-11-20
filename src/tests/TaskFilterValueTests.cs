using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class TaskFilterValueTests
    {
        [Fact]
        public void Mapping_TaskFilterValue_TestProperties()
        {
            Options.TaskFilterValueOptions options = new();
            options.AssertEqualProperties((Sdk.Models.TaskFilterValue)options);
        }
    }
}