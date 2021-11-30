using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddContainerCommand :
        ImportCommand<AddContainerOptions, Container>,
        ICommand<AddContainerOptions>
    {
        protected override string WriteIntro(AddContainerOptions options)
            => "Adding container";
    }
}