using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentImportanceCommand : 
        ImportCommand<AddAppointmentImportanceOptions, AppointmentImportance>,
        ICommand<AddAppointmentImportanceOptions>
    {
        protected override string WriteIntro(AddAppointmentImportanceOptions options)
            => $"Updating importance of appointment {options.AppointmentId} to {options.Importance}.";
    }
}