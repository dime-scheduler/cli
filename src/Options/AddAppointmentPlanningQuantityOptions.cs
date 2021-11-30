using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addAppointmentPlanningQuantity", HelpText = "Sets the appointment's planning quantity.")]
    public class AddAppointmentPlanningQuantityOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public long AppointmentId { get; set; }

        [Option]
        public decimal Quantity { get; set; }

        [Option]
        public Guid? AppointmentGuid { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; }

        public IImportRequestable ToImport() => (AppointmentPlanningQuantity)this;

        public static implicit operator AppointmentPlanningQuantity(AddAppointmentPlanningQuantityOptions options)
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