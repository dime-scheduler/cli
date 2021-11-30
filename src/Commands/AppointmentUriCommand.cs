using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentUriCommand : 
        ImportCommand<AppointmentUriOptions, AppointmentUri>,
        ICommand<AppointmentUriOptions>
    {
        protected override string WriteIntro(AppointmentUriOptions options)
            => "Adding URI to appointment.";
    }
}