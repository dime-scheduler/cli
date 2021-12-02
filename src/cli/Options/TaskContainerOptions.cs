using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("taskcontainer", HelpText = "Adds or updates a task container.")]
    public class TaskContainerOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true, HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(Required = true, HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(Required = true, HelpText = "The job's unique identifier.")]
        public string JobNo { get; set; }

        [Option(Required = true, HelpText = "The task's unique identifier.")]
        public string TaskNo { get; set; }

        [Option(Required = true, HelpText = "The task container name")]
        public string Name { get; set; }

        [Option(HelpText = "The index")]
        public int Index { get; set; }

        public IImportRequestable ToImport() => (TaskContainer)this;

        public static implicit operator TaskContainer(TaskContainerOptions options)
          => new()
          {
              Index = options.Index,
              JobNo = options.JobNo,
              Name = options.Name,
              SourceApp = options.SourceApp,
              SourceType = options.SourceType,
              TaskNo = options.TaskNo             
          };
    }
}