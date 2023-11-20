using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class ActionUriCommand :
        Command<ActionUriOptions, ActionUri>,
        ICommand<ActionUriOptions>
    {
        protected override string WriteIntro(ActionUriOptions options) => $"Adding action URI.";
    }
}