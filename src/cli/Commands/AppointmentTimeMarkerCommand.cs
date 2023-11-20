using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentTimeMarkerCommand :
        ImportCommand<AppointmentTimeMarkerOptions, AppointmentTimeMarker>,
        ICommand<AppointmentTimeMarkerOptions>
    {
        protected override string WriteIntro(AppointmentTimeMarkerOptions options)
          => $"Assigning time marker {options.TimeMarker} to appointment {options.AppointmentId}.";
    }
}