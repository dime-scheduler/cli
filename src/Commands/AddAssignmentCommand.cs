using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAssignmentCommand :
        ImportCommand<AddAssignmentOptions, Assignment>,
        ICommand<AddAssignmentOptions>
    {
        protected override string WriteIntro(AddAssignmentOptions options)
            => "Adding assignment.";
    }
}