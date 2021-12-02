using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class ActionUriTests
    {
        [Fact]
        public void Mapping_ActionUri_TestProperties()
        {
            ActionUriOptions options = new()
            {
                Append = true,
                Default = true,
                Delete = true,
                Description = "Hello world",
                Link = "Hello world",
                Password = "Hello world",
                SourceApp = "Hello world",
                SourceType = "Hello world",
                Uri = "Hello world",
                UriType = 1,
                User = ""
            };

            options.AssertEqualProperties((ActionUri)options);
        }
    }
}