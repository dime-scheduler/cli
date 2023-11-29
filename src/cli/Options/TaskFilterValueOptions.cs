using CommandLine;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("taskfiltervalue", HelpText = "Add or remove a filter value to a task.")]
    public class TaskFilterValueOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(HelpText = "The job's unique identifier.")]
        public string JobNo { get; set; }

        [Option(HelpText = "The task's unique identifier.")]
        public string TaskNo { get; set; }

        [Option(HelpText = "The filter group name.")]
        public string FilterGroup { get; set; }

        [Option(HelpText = "The filter group value.")]
        public string FilterValue { get; set; }

        [Option(HelpText = "True to transfer to temp.")]
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