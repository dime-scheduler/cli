using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class ContainerCommand :
        Command<ContainerOptions, Container>,
        ICommand<ContainerOptions>
    {
        protected override string WriteIntro(ContainerOptions options)
            => "Adding container";
    }
}