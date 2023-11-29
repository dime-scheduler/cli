using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class ResourceUriCommand :
        Command<ResourceUriOptions, ResourceUri>,
        ICommand<ResourceUriOptions>
    {
        protected override string WriteIntro(ResourceUriOptions options) => $"Creates a resource URI.";
    }
}