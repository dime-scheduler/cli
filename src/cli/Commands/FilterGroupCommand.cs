using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class FilterGroupCommand : 
        ImportCommand<FilterGroupOptions, FilterGroup>,
        ICommand<FilterGroupOptions>
    {
        protected override string WriteIntro(FilterGroupOptions options)
            => $"Adding filter group with name {options.Name}.";
    }
}