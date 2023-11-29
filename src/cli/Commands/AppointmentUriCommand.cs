using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentUriCommand :
        Command<AppointmentUriOptions, AppointmentUri>,
        ICommand<AppointmentUriOptions>
    {
        protected override string WriteIntro(AppointmentUriOptions options)
            => "Adding URI to appointment.";
    }
}