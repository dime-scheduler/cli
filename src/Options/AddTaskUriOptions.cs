using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addTaskUri", HelpText = "Adds a URI to a task.")]
    public class AddTaskUriOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public string JobNo { get; set; }

        [Option]
        public string TaskNo { get; set; }

        [Option]
        public string Link { get; set; }

        [Option]
        public string Description { get; set; }

        public IImportRequestable ToImport() => (TaskUri)this;

        public static implicit operator TaskUri(AddTaskUriOptions options)
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