using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class TaskLockedCommand :
        ImportCommand<TaskLockedOptions, TaskLocked>,
        ICommand<TaskLockedOptions>
    {
        protected override string WriteIntro(TaskLockedOptions options)
            => $"Locking or unlocking task with job {options.JobNo} with number {options.TaskNo}.";
    }
}