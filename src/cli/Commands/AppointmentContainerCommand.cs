using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentContainerCommand :
        Command<AppointmentContainerOptions, AppointmentContainer>,
        ICommand<AppointmentContainerOptions>
    {
        protected override string WriteIntro(AppointmentContainerOptions options)
        => $"Assigning appointment {options.Appointment} to container {options.Container}.";
    }
}