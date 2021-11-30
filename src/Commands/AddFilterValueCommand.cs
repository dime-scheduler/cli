using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddFilterValueCommand :
        ImportCommand<AddFilterValueOptions, FilterValue>,
        ICommand<AddFilterValueOptions>
    {
        protected override string WriteIntro(AddFilterValueOptions options)
            => $"Adding filter value for group {options.Group} and value {options.Value}";
    }
}