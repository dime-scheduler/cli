using CommandLine;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("taskuri", HelpText = "Add or remove a URI to or from a task.")]
    public class TaskUriOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(HelpText = "The job's unique identifier.")]
        public string JobNo { get; set; }

        [Option(HelpText = "The task's unique identifier.")]
        public string TaskNo { get; set; }

        [Option(HelpText = "The URI.")]
        public string Link { get; set; }

        [Option(HelpText = "The URI's text.")]
        public string Description { get; set; }

        public IImportRequestable ToImport() => (TaskUri)this;

        public static implicit operator TaskUri(TaskUriOptions options)
          => new()
          {
              Description = options.Description,
              JobNo = options.JobNo,
              SourceApp = options.SourceApp,
              SourceType = options.SourceType,
              TaskNo = options.TaskNo,
              Uri = options.Link
          };
    }
}