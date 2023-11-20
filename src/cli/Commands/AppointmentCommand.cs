using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentCommand :
        Command<AppointmentOptions, Appointment>,
        ICommand<AppointmentOptions>
    {
        protected override string WriteIntro(AppointmentOptions options)
            => $"Adding appointment for resource {options.ResourceNo} " +
            $"between {options.Start} and {options.End}";
    }
}