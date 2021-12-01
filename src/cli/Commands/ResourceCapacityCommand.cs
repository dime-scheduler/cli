using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class ResourceCapacityCommand :
        ImportCommand<ResourceCapacityOptions, ResourceCapacity>,
        ICommand<ResourceCapacityOptions>
    {
        protected override string WriteIntro(ResourceCapacityOptions options)
          => $"Add or remove a capacity entry for the requested resource.";
    }
}