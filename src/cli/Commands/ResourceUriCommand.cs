using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class ResourceUriCommand :
        ImportCommand<ResourceUriOptions, ResourceUri>,
        ICommand<ResourceUriOptions>
    {
        protected override string WriteIntro(ResourceUriOptions options) => $"Creates a resource URI.";
    }
}