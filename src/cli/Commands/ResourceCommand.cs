using Dime.Scheduler.CLI.Options;
using Resource = Dime.Scheduler.Sdk.Import.Resource;

namespace Dime.Scheduler.CLI.Commands
{
    public class ResourceCommand :
        ImportCommand<ResourceOptions, Resource>,
        ICommand<ResourceOptions>
    {
        protected override string WriteIntro(ResourceOptions options) => $"Adding resource.";
    }
}