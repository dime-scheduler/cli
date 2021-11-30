using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("appointmentimportance", HelpText = "Sets the appointment's priority.")]
    public class AppointmentImportanceOptions : AppointmentAttributeOptions, IImportConvertable
    {
        [Option(HelpText = "The appointment's priority.")]
        public int Importance { get; set; }

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