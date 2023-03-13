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
                Append = true,
                Uri = "Hello world",
                Key =  "Hello world",
                Delete = true,
                Color = "GREEN",
                Name = "CATEGORY"
            };

            options.AssertEqualProperties((Sdk.Import.Category)options);
        }
    }
}