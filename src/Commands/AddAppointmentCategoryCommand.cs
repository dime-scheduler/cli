using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentCategoryCommand :
        ImportCommand<AddAppointmentCategoryOptions, AppointmentCategory>, 
        ICommand<AddAppointmentCategoryOptions>
    {
        protected override string WriteIntro(AddAppointmentCategoryOptions options)
            => $"Assigning category {options.Category} to appointment {options.AppointmentId}.";
    }
}