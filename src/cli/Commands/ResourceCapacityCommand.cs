using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class ResourceCapacityCommand :
        Command<ResourceCapacityOptions, ResourceCapacity>,
        ICommand<ResourceCapacityOptions>
    {
        protected override string WriteIntro(ResourceCapacityOptions options)
          => $"Add or remove a capacity entry for the requested resource.";
    }
}