using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("appointmentcategory", HelpText = "Sets the appointment's category.")]
    public class AppointmentCategoryOptions : AppointmentAttributeOptions, IImportConvertable
    {
        [Option(HelpText = "The category name.")]
        public string Category { get; set; }

        public IImportRequestable ToImport() => (AppointmentCategory)this;

        public static implicit operator AppointmentCategory(AppointmentCategoryOptions options)
           => new()
           {
               AppointmentGuid = options.AppointmentGuid,
               AppointmentId = options.AppointmentId,
               Category = options.Category,
               SentFromBackOffice = options.SentFromBackOffice,
               SourceApp = options.SourceApp,
               SourceType = options.SourceType
           };
    }
}