using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class FilterValueTests
    {
        [Fact]
        public void Mapping_FilterValue_TestProperties()
        {
            Options.FilterValueOptions options = new();
            options.AssertEqualProperties((Entities.FilterValue)options);
        }
    }
}