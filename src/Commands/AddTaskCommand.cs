using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddTaskCommand :
        ImportCommand<AddTaskOptions, Task>,
        ICommand<AddTaskOptions>
    {
        protected override string WriteIntro(AddTaskOptions options)
            => $"Adding task for job {options.JobNo} with number {options.TaskNo}.";
    }
}