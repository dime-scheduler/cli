using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("tasklocked", HelpText = "Locks or unlocks a task.")]
    public class TaskLockedOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(HelpText = "The job's unique identifier.")]
        public string JobNo { get; set; }

        [Option(HelpText = "The task's unique identifier.")]
        public string TaskNo { get; set; }

        [Option(HelpText = "True to lock the task.")]
        public bool Locked { get; set; }

        [Option(HelpText = "True to mark the appointment is sent from the back office.")]
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