using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class ActionUriCommand : 
        ImportCommand<ActionUriOptions, ActionUri>, 
        ICommand<ActionUriOptions>
    {
        protected override string WriteIntro(ActionUriOptions options) => $"Adding action URI.";
    }
}