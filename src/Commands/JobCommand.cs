using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class JobCommand : 
        ImportCommand<JobOptions, Job>,
        ICommand<JobOptions>
    {  
        protected override string WriteIntro(JobOptions options) 
            => $"Adding job with number {options.JobNo}.";
    }
}