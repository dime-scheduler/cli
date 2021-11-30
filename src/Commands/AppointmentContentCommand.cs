using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentContentCommand : 
        ImportCommand<AppointmentContentOptions, AppointmentContent>,
        ICommand<AppointmentContentOptions>
    {
        protected override string WriteIntro(AppointmentContentOptions options)
        => $"Updating subject and body for appointment {options.AppointmentId}.";
    }
}