using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class TaskLockedCommand :
        Command<TaskLockedOptions, TaskLocked>,
        ICommand<TaskLockedOptions>
    {
        protected override string WriteIntro(TaskLockedOptions options)
            => $"Locking or unlocking task with job {options.JobNo} with number {options.TaskNo}.";
    }
}