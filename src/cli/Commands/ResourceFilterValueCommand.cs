using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class ResourceFilterValueCommand :
        Command<ResourceFilterValueOptions, ResourceFilterValue>,
        ICommand<ResourceFilterValueOptions>
    {
        protected override string WriteIntro(ResourceFilterValueOptions options)
            => "Creates a resource filter value.";
    }
}