using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class ResourceCapacityTests
    {
        [Fact]
        public void Mapping_ResourceCapacity_TestProperties()
        {
            Options.ResourceCapacityOptions options = new();
            options.AssertEqualProperties((Sdk.Models.ResourceCapacity)options);
        }
    }
}