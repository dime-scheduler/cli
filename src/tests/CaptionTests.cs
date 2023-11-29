using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class CaptionTests
    {
        [Fact]
        public void Mapping_Caption_TestProperties()
        {
            Options.CaptionOptions options = new();
            options.AssertEqualProperties((Entities.Caption)options);
        }
    }
}