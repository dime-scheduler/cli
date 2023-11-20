using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class ResourceFilterValueCommand :
        ImportCommand<ResourceFilterValueOptions, ResourceFilterValue>,
        ICommand<ResourceFilterValueOptions>
    {
        protected override string WriteIntro(ResourceFilterValueOptions options)
            => "Creates a resource filter value.";
    }
}