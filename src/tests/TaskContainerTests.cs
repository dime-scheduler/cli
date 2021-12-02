using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class TaskContainerTests
    {
        [Fact]
        public void Mapping_TaskContainer_TestProperties()
        {
            TaskContainerOptions options = new()
            {
                Append = true,
                Delete = true,
                Password = "Hello world",
                SourceApp = "Hello world",
                SourceType = "Hello world",
                Uri = "Hello world",
                User = "Hello world",
                TaskNo = "Hello world",
                Name = "Hello world",
                JobNo = "Hello world",
                Index = 5
            };

            options.AssertEqualProperties((TaskContainer)options);
        }
    }
}