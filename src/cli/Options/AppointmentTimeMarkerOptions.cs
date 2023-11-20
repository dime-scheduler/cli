using CommandLine;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("appointmenttimemarker", HelpText = "Sets the appointment's time marker.")]
    public class AppointmentTimeMarkerOptions : AppointmentAttributeOptions, IImportConvertable
    {
        [Option(HelpText = "The time marker.")]
        public string TimeMarker { get; set; }

        public IImportRequestable ToImport() => (AppointmentTimeMarker)this;

        public static implicit operator AppointmentTimeMarker(AppointmentTimeMarkerOptions options)
            => new()
            {
                AppointmentGuid = options.AppointmentGuid,
                AppointmentId = options.AppointmentId,
                TimeMarker = options.TimeMarker,
                SentFromBackOffice = options.SentFromBackOffice,
                SourceApp = options.SourceApp,
                SourceType = options.SourceType
            };
    }
}