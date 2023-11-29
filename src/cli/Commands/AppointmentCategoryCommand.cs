using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Commands
{
    public class AppointmentCategoryCommand :
        Command<AppointmentCategoryOptions, AppointmentCategory>,
        ICommand<AppointmentCategoryOptions>
    {
        protected override string WriteIntro(AppointmentCategoryOptions options)
            => $"Assigning category {options.Category} to appointment {options.AppointmentId}.";
    }
}