using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddTaskUriCommand : 
        ImportCommand<AddTaskUriOptions, TaskUri>,
        ICommand<AddTaskUriOptions>
    { 
        protected override string WriteIntro(AddTaskUriOptions options)
            => $"Adding task URI for job {options.JobNo} with number {options.TaskNo}.";
    }
}