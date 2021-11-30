using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddResourceUriCommand :
        ImportCommand<AddResourceUriOptions, ResourceUri>,
        ICommand<AddResourceUriOptions>
    {
        protected override string WriteIntro(AddResourceUriOptions options) => $"Creates a resource URI.";
    }
}