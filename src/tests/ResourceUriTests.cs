using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class ResourceUriTests
    {
        [Fact]
        public void Mapping_ResourceUri_TestProperties()
        {
            Options.ResourceUriOptions options = new();
            options.AssertEqualProperties((Sdk.Models.ResourceUri)options);
        }
    }
}