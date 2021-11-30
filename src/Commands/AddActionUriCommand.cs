using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddActionUriCommand : 
        ImportCommand<AddActionUriOptions, ActionUri>, 
        ICommand<AddActionUriOptions>
    {
        protected override string WriteIntro(AddActionUriOptions options) => $"Adding action URI.";
    }
}