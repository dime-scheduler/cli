using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentTimeMarkerCommand :
        Command<AppointmentTimeMarkerOptions, AppointmentTimeMarker>,
        ICommand<AppointmentTimeMarkerOptions>
    {
        protected override string WriteIntro(AppointmentTimeMarkerOptions options)
          => $"Assigning time marker {options.TimeMarker} to appointment {options.AppointmentId}.";
    }
}