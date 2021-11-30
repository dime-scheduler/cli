using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentPlanningQuantityCommand :
        ImportCommand<AppointmentPlanningQuantityOptions, AppointmentPlanningQuantity>,
        ICommand<AppointmentPlanningQuantityOptions>
    {
        protected override string WriteIntro(AppointmentPlanningQuantityOptions options)
        => $"Updating the planning quantity of appointment {options.AppointmentId} to {options.Quantity}.";
    }
}