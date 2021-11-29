using CommandLine;
using Dime.Scheduler.Sdk;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addNotification", HelpText = "Adds a notification.")]
    public class AddNotificationOptions : BaseOptions
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
    }
}