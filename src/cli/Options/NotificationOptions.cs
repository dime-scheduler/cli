using System;
using CommandLine;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("notification", HelpText = "Add or remove a notification.")]
    public class NotificationOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(HelpText = "The appointment's identifier.")]
        public long? AppointmentId { get; set; }

        [Option(HelpText = "The connector's identifier.")]
        public string ConnectorId { get; set; }

        [Option(HelpText = "The notification type.")]
        public NotificationType Type { get; set; }

        [Option(HelpText = "The code.")]
        public string Code { get; set; }

        [Option(HelpText = "The text.")]
        public string Text { get; set; }

        [Option(HelpText = "The notification's date.")]
        public DateTime? Date { get; set; }

        [Option(HelpText = "Optional reference to a job.")]
        public string JobNo { get; set; }

        [Option(HelpText = "Optional reference to a task.")]
        public string TaskNo { get; set; }

        [Option(HelpText = "The appointment's GUID.")]
        public Guid? AppointmentGuid { get; set; }

        [Option(HelpText = "Flag to indicate whether the record is sent from the back office.")]
        public bool SentFromBackOffice { get; set; }

        public IImportRequestable ToImport() => (Notification)this;

        public static implicit operator Notification(NotificationOptions options)
          => new()
          {
              AppointmentGuid = options.AppointmentGuid,
              AppointmentId = options.AppointmentId,
              Code = options.Code,
              ConnectorId = options.ConnectorId,
              Date = options.Date,
              JobNo = options.JobNo,
              SentFromBackOffice = options.SentFromBackOffice,
              SourceApp = options.SourceApp,
              SourceType = options.SourceType,
              TaskNo = options.TaskNo,
              Text = options.Text,
              Type = options.Type
          };
    }
}