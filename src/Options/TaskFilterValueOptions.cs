using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("taskfiltervalue", HelpText = "Add or remove a filter value to a task.")]
    public class TaskFilterValueOptions : BaseOptions, IImportConvertable
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
        public string FilterGroup { get; set; }

        [Option]
        public string FilterValue { get; set; }

        [Option]
        public bool TransferToTemp { get; set; }

        public IImportRequestable ToImport() => (TaskFilterValue)this;

        public static implicit operator TaskFilterValue(TaskFilterValueOptions options)
          => new()
          {
              FilterGroup = options.FilterGroup,
              FilterValue = options.FilterValue,
              JobNo = options.JobNo,
              SourceApp = options.SourceApp,
              SourceType = options.SourceType,
              TaskNo = options.TaskNo,
              TransferToTemp = options.TransferToTemp
          };
    }
}