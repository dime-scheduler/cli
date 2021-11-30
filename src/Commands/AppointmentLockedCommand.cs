using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentLockedCommand :
        ImportCommand<AppointmentLockedOptions, AppointmentLocked>,
        ICommand<AppointmentLockedOptions>
    {
        protected override string WriteIntro(AppointmentLockedOptions options)
            => options.Locked
            ? $"Locking appointment {options.AppointmentId}"
            : $"Unocking appointment {options.AppointmentId}";
    }
}