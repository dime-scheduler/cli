using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("tasklocked", HelpText = "Locks or unlocks a task.")]
    public class TaskLockedOptions : BaseOptions, IImportConvertable
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
        public bool Locked { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; } = true;

        public IImportRequestable ToImport() => (TaskLocked)this;

        public static implicit operator TaskLocked(TaskLockedOptions options)
          => new()
          {
              JobNo = options.JobNo,
              Locked = options.Locked,
              SentFromBackOffice = options.SentFromBackOffice,
              SourceApp = options.SourceApp,
              SourceType = options.SourceType,
              TaskNo = options.TaskNo
          };
    }
}