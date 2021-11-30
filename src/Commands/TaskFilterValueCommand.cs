using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class TaskFilterValueCommand :
        ImportCommand<TaskFilterValueOptions, TaskFilterValue>,
        ICommand<TaskFilterValueOptions>
    {
        protected override string WriteIntro(TaskFilterValueOptions options)
            => $"Adding task filter value for job {options.JobNo} with number {options.TaskNo}.";
    }
}