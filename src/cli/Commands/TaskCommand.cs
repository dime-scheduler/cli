using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class TaskCommand :
        ImportCommand<TaskOptions, Task>,
        ICommand<TaskOptions>
    {
        protected override string WriteIntro(TaskOptions options)
            => $"Adding task for job {options.JobNo} with number {options.TaskNo}.";
    }
}