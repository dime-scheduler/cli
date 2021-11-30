using CommandLine;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addNotification", HelpText = "Adds a notification.")]
    public class AddNotificationOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public long? AppointmentId { get; set; }

        [Option]
        public string ConnectorId { get; set; }

        [Option]
        public NotificationType Type { get; set; }

        [Option]
        public string Code { get; set; }

        [Option]
        public string Text { get; set; }

        [Option]
        public DateTime? Date { get; set; }

        [Option]
        public string JobNo { get; set; }

        [Option]
        public string TaskNo { get; set; }

        [Option]
        public Guid? AppointmentGuid { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; }

        public IImportRequestable ToImport() => (Notification)this;

        public static implicit operator Notification(AddNotificationOptions options)
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