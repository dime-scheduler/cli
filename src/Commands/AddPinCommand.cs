using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddPinCommand :
        ImportCommand<AddPinOptions, Pin>,
        ICommand<AddPinOptions>
    {
        protected override string WriteIntro(AddPinOptions options)
            => $"Adding pin with name {options.Name} and color {options.Color}";
    }
}