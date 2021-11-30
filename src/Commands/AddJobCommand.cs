using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddJobCommand : 
        ImportCommand<AddJobOptions, Job>,
        ICommand<AddJobOptions>
    {  
        protected override string WriteIntro(AddJobOptions options) => $"Adding job with number {options.JobNo}.";
    }
}