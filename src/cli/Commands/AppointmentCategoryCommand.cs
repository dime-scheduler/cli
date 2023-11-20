using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentCategoryCommand :
        ImportCommand<AppointmentCategoryOptions, AppointmentCategory>,
        ICommand<AppointmentCategoryOptions>
    {
        protected override string WriteIntro(AppointmentCategoryOptions options)
            => $"Assigning category {options.Category} to appointment {options.AppointmentId}.";
    }
}