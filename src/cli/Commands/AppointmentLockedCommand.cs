using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentLockedCommand :
        Command<AppointmentLockedOptions, AppointmentLocked>,
        ICommand<AppointmentLockedOptions>
    {
        protected override string WriteIntro(AppointmentLockedOptions options)
            => options.Locked
            ? $"Locking appointment {options.AppointmentId}"
            : $"Unocking appointment {options.AppointmentId}";
    }
}