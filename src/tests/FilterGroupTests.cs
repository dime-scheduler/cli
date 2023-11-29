using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class FilterGroupTests
    {
        [Fact]
        public void Mapping_FilterGroup_TestProperties()
        {
            Options.FilterGroupOptions options = new();
            options.AssertEqualProperties((Entities.FilterGroup)options);
        }
    }
}