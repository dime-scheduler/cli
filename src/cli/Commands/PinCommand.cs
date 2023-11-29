using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.CLI.Utils;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class PinCommand :
        Command<PinOptions, Pin>,
        ICommand<PinOptions>
    {
        protected override string WriteIntro(PinOptions options)
            => $"{options.GetOperationType()} pin with name {options.Name} and color {options.Color}";
    }
}