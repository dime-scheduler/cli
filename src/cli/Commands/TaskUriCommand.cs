using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class TaskUriCommand : 
        ImportCommand<TaskUriOptions, TaskUri>,
        ICommand<TaskUriOptions>
    { 
        protected override string WriteIntro(TaskUriOptions options)
            => $"Adding task URI for job {options.JobNo} with number {options.TaskNo}.";
    }
}