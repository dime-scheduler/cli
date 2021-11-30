using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddResourceFilterValueCommand :
        ImportCommand<AddResourceFilterValueOptions, ResourceFilterValue>,
        ICommand<AddResourceFilterValueOptions>
    {
        protected override string WriteIntro(AddResourceFilterValueOptions options) => "Creates a resource filter value.";
    }
}