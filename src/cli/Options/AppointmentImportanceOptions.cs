using CommandLine;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("appointmentimportance", HelpText = "Sets the appointment's priority.")]
    public class AppointmentImportanceOptions : AppointmentAttributeOptions, IImportConvertable
    {
        [Option(HelpText = "The appointment's priority.")]
        public Importance Importance { get; set; }

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