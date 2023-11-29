using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class AssignmentCommand :
        Command<AssignmentOptions, Assignment>,
        ICommand<AssignmentOptions>
    {
        protected override string WriteIntro(AssignmentOptions options)
            => "Adding assignment.";
    }
}