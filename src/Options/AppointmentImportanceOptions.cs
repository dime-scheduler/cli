using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("appointmentimportance", HelpText = "Sets the appointment's priority.")]
    public class AppointmentImportanceOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public long AppointmentId { get; set; }

        [Option]
        public int Importance { get; set; }

        [Option]
        public Guid? AppointmentGuid { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; }

        public IImportRequestable ToImport() => (AppointmentImportance)this;

        public static implicit operator AppointmentImportance(AppointmentImportanceOptions options)
            => new()
            {
                AppointmentGuid = options.AppointmentGuid,
                AppointmentId = options.AppointmentId,
                Importance = options.Importance,
                SentFromBackOffice = options.SentFromBackOffice,
                SourceApp = options.SourceApp,
                SourceType = options.SourceType
            };
    }
}