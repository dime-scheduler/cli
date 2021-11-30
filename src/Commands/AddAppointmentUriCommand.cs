using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentUriCommand : 
        ImportCommand<AddAppointmentUriOptions, AppointmentUri>,
        ICommand<AddAppointmentUriOptions>
    {
        protected override string WriteIntro(AddAppointmentUriOptions options)
            => "Adding URI to appointment.";
    }
}