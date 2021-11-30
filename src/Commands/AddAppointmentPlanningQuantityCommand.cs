using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentPlanningQuantityCommand :
        ImportCommand<AddAppointmentPlanningQuantityOptions, AppointmentPlanningQuantity>,
        ICommand<AddAppointmentPlanningQuantityOptions>
    {
        protected override string WriteIntro(AddAppointmentPlanningQuantityOptions options)
        => $"Updating the planning quantity of appointment {options.AppointmentId} to {options.Quantity}.";
    }
}