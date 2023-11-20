using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.CLI.Utils;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class PinCommand :
        ImportCommand<PinOptions, Pin>,
        ICommand<PinOptions>
    {
        protected override string WriteIntro(PinOptions options)
            => $"{options.GetOperationType()} pin with name {options.Name} and color {options.Color}";
    }
}