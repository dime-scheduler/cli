using Dime.Scheduler.CLI.Options;
using Resource = Dime.Scheduler.Entities.Resource;

namespace Dime.Scheduler.CLI.Commands
{
    public class ResourceCommand :
        Command<ResourceOptions, Resource>,
        ICommand<ResourceOptions>
    {
        protected override string WriteIntro(ResourceOptions options) => $"Adding resource.";
    }
}