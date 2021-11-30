using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddResourceCapacityCommand :
        ImportCommand<AddResourceCapacityOptions, ResourceCapacity>,
        ICommand<AddResourceCapacityOptions>
    {
        protected override string WriteIntro(AddResourceCapacityOptions options)
          => $"Adds a capacity entry for the requested resource.";
    }
}