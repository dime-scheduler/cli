using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class ContainerTests
    {
        [Fact]
        public void Mapping_Container_TestProperties()
        {
            Options.ContainerOptions options = new();
            options.AssertEqualProperties((Entities.Container)options);
        }
    }
}