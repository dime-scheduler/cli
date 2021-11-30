using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("appointmentlocked", HelpText = "Locks or unlocks the appointment.")]
    public class AppointmentLockedOptions : AppointmentAttributeOptions, IImportConvertable
    {
        [Option(HelpText = "True to lock the appointment, false to unlock it.")]
        public bool Locked { get; set; }

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