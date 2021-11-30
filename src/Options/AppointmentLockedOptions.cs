using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("appointmentlocked", HelpText = "Locks or unlocks the appointment.")]
    public class AppointmentLockedOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public long AppointmentId { get; set; }

        [Option]
        public bool Locked { get; set; }

        [Option]
        public Guid? AppointmentGuid { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; }

        public IImportRequestable ToImport() => (AppointmentLocked)this;

        public static implicit operator AppointmentLocked(AppointmentLockedOptions options)
            => new()
            {
                AppointmentGuid = options.AppointmentGuid,
                AppointmentId = options.AppointmentId,
                Locked = options.Locked,
                SentFromBackOffice = options.SentFromBackOffice,
                SourceApp = options.SourceApp,
                SourceType = options.SourceType
            };
    }
}