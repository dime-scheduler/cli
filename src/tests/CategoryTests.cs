using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class CategoryTests
    {
        [Fact]
        public void Mapping_Category_TestProperties()
        {
            Options.CategoryOptions options = new()
            {
                Key = "Hello world",
                Color = "GREEN",
                Name = "CATEGORY"
            };

            options.AssertEqualProperties((Sdk.Models.Category)options);
        }
    }
}