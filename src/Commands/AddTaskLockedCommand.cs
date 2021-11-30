using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddTaskLockedCommand :
        ImportCommand<AddTaskLockedOptions, TaskLocked>,
        ICommand<AddTaskLockedOptions>
    {
        protected override string WriteIntro(AddTaskLockedOptions options)
            => $"Locking or unlocking task with job {options.JobNo} with number {options.TaskNo}.";
    }
}