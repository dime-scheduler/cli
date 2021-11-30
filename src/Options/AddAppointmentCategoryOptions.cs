using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addAppointmentCategory", HelpText = "Sets the appointment's category.")]
    public class AddAppointmentCategoryOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public long AppointmentId { get; set; }

        [Option]
        public string Category { get; set; }

        [Option]
        public Guid? AppointmentGuid { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; }

        public IImportRequestable ToImport() => (AppointmentCategory)this;

        public static implicit operator AppointmentCategory(AddAppointmentCategoryOptions options)
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