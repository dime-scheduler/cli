using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentContainerCommand :
        ImportCommand<AddAppointmentContainerOptions, AppointmentContainer>,
        ICommand<AddAppointmentContainerOptions>
    {
        protected override string WriteIntro(AddAppointmentContainerOptions options)
        => $"Assigning appointment {options.Appointment} to container {options.Container}.";
    }
}