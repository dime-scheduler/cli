using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentLockedCommand :
        ImportCommand<AddAppointmentLockedOptions, AppointmentLocked>,
        ICommand<AddAppointmentLockedOptions>
    {
        protected override string WriteIntro(AddAppointmentLockedOptions options)
            => options.Locked
            ? $"Locking appointment {options.AppointmentId}"
            : $"Unocking appointment {options.AppointmentId}";
    }
}