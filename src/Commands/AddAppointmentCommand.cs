using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentCommand : 
        ImportCommand<AddAppointmentOptions, Appointment>, 
        ICommand<AddAppointmentOptions>
    {
        protected override string WriteIntro(AddAppointmentOptions options)
        => $"Adding appointment for resource {options.ResourceNo} between {options.Start} and {options.End}";
    }
}