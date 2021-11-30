using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentCommand :
        ImportCommand<AppointmentOptions, Appointment>,
        ICommand<AppointmentOptions>
    {
        protected override string WriteIntro(AppointmentOptions options)
            => $"Adding appointment for resource {options.ResourceNo} " +
            $"between {options.Start} and {options.End}";
    }
}