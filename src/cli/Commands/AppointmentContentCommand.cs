using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentContentCommand :
        Command<AppointmentContentOptions, AppointmentContent>,
        ICommand<AppointmentContentOptions>
    {
        protected override string WriteIntro(AppointmentContentOptions options)
        => $"Updating subject and body for appointment {options.AppointmentId}.";
    }
}