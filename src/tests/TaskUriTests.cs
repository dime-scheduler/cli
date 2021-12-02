using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class TaskUriTests
    {
        [Fact]
        public void Mapping_TaskUri_TestProperties()
        {
            Options.TaskUriOptions options = new();
            options.AssertEqualProperties((Sdk.Import.TaskUri)options);
        }
    }
}