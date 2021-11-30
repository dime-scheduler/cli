using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentTimeMarkerCommand :
        ImportCommand<AddAppointmentTimeMarkerOptions, AppointmentTimeMarker>,
        ICommand<AddAppointmentTimeMarkerOptions>
    {
        protected override string WriteIntro(AddAppointmentTimeMarkerOptions options)
          => $"Assigning time marker {options.TimeMarker} to appointment {options.AppointmentId}.";
    }
}