using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class PinTests
    {
        [Fact]
        public void Mapping_Pin_TestProperties()
        {
            Options.PinOptions options = new();
            options.AssertEqualProperties((Sdk.Import.Pin)options);
        }
    }
}