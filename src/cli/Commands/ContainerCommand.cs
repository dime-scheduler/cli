using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

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