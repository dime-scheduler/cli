using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class TaskFilterValueCommand :
        Command<TaskFilterValueOptions, TaskFilterValue>,
        ICommand<TaskFilterValueOptions>
    {
        protected override string WriteIntro(TaskFilterValueOptions options)
            => $"Adding task filter value for job {options.JobNo} with number {options.TaskNo}.";
    }
}