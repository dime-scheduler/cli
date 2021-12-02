using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class TaskContainerCommand :
        ImportCommand<TaskContainerOptions, TaskContainer>,
        ICommand<TaskContainerOptions>
    {
        protected override string WriteIntro(TaskContainerOptions options)
            => $"Assigning container {options.Name} to task {options.TaskNo}.";
    }
}