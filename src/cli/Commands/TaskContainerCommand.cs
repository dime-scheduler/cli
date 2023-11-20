using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class TaskContainerCommand :
        Command<TaskContainerOptions, TaskContainer>,
        ICommand<TaskContainerOptions>
    {
        protected override string WriteIntro(TaskContainerOptions options)
            => $"Assigning container {options.Name} to task {options.TaskNo}.";
    }
}