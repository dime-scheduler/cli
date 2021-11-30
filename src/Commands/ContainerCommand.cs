using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class ContainerCommand :
        ImportCommand<ContainerOptions, Container>,
        ICommand<ContainerOptions>
    {
        protected override string WriteIntro(ContainerOptions options)
            => "Adding container";
    }
}