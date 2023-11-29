using CommandLine;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("appointmentplanningquantity", HelpText = "Sets the appointment's planning quantity.")]
    public class AppointmentPlanningQuantityOptions : AppointmentAttributeOptions, IImportConvertable
    {
        [Option(HelpText = "The quantity.")]
        public decimal Quantity { get; set; }

        public IImportRequestable ToImport() => (AppointmentPlanningQuantity)this;

        public static implicit operator AppointmentPlanningQuantity(AppointmentPlanningQuantityOptions options)
            => new()
            {
                AppointmentGuid = options.AppointmentGuid,
                AppointmentId = options.AppointmentId,
                Quantity = options.Quantity,
                SentFromBackOffice = options.SentFromBackOffice,
                SourceApp = options.SourceApp,
                SourceType = options.SourceType
            };
    }
}