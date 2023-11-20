using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentPlanningQuantityCommand :
        Command<AppointmentPlanningQuantityOptions, AppointmentPlanningQuantity>,
        ICommand<AppointmentPlanningQuantityOptions>
    {
        protected override string WriteIntro(AppointmentPlanningQuantityOptions options)
        => $"Updating the planning quantity of appointment {options.AppointmentId} to {options.Quantity}.";
    }
}