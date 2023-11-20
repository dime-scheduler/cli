using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class FilterValueCommand :
        Command<FilterValueOptions, FilterValue>,
        ICommand<FilterValueOptions>
    {
        protected override string WriteIntro(FilterValueOptions options)
            => $"Adding filter value for group {options.Group} and value {options.Value}";
    }
}