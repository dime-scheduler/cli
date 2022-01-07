using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentImportanceCommand :
        ImportCommand<AppointmentImportanceOptions, AppointmentImportance>,
        ICommand<AppointmentImportanceOptions>
    {
        protected override string WriteIntro(AppointmentImportanceOptions options)
            => $"Updating importance of appointment {options.AppointmentId} to {options.Importance}.";
    }
}