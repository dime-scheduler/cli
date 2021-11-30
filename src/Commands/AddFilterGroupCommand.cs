using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddFilterGroupCommand : 
        ImportCommand<AddFilterGroupOptions, FilterGroup>,
        ICommand<AddFilterGroupOptions>
    {
        protected override string WriteIntro(AddFilterGroupOptions options)
            => $"Adding filter group with name {options.Name}.";
    }
}