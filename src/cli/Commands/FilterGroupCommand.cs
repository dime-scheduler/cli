using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class FilterGroupCommand :
        Command<FilterGroupOptions, FilterGroup>,
        ICommand<FilterGroupOptions>
    {
        protected override string WriteIntro(FilterGroupOptions options)
            => $"Adding filter group with name {options.Name}.";
    }
}