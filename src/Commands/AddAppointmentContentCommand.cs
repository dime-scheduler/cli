using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentContentCommand : 
        ImportCommand<AddAppointmentContentOptions, AppointmentContent>,
        ICommand<AddAppointmentContentOptions>
    {
        protected override string WriteIntro(AddAppointmentContentOptions options)
        => $"Updating subject and body for appointment {options.AppointmentId}.";
    }
}