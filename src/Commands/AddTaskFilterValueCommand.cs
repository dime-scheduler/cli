using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddTaskFilterValueCommand :
        ImportCommand<AddTaskFilterValueOptions, TaskFilterValue>,
        ICommand<AddTaskFilterValueOptions>
    {
        protected override string WriteIntro(AddTaskFilterValueOptions options)
            => $"Adding task filter value for job {options.JobNo} with number {options.TaskNo}.";
    }
}