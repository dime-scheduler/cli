using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

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