using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AssignmentTests
    {
        [Fact]
        public void Mapping_Assignment_TestProperties()
        {
            Options.AssignmentOptions options = new();
            options.AssertEqualProperties((Sdk.Models.Assignment)options);
        }
    }
}