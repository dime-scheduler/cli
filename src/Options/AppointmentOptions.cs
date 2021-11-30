using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("appointment", HelpText = "Add or remove an appointment to or from the planning board.")]
    public class AppointmentOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true, HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(Required = true, HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(Required = true, HelpText = "The resource number.")]
        public string ResourceNo { get; set; }

        [Option(Required = true, HelpText = "The job number.")]
        public string JobNo { get; set; }

        [Option(Required = true, HelpText = "The task number.")]
        public string TaskNo { get; set; }

        [Option(Required = true, HelpText = "The start date.")]
        public DateTime Start { get; set; }

        [Option(Required = true, HelpText = "The end date.")]
        public DateTime End { get; set; }

        [Option(HelpText = "The subject.")]
        public string Subject { get; set; }

        [Option(HelpText = "The body.")]
        public string Body { get; set; }

        [Option(HelpText = "The appointment's time marker.")]
        public string TimeMarker { get; set; }

        [Option(HelpText = "The appointment's category.")]
        public string Category { get; set; }

        [Option(HelpText = "The priority.")]
        public int Importance { get; set; }

        [Option(HelpText = "Set to true to lock the appointment.")]
        public bool Locked { get; set; }

        [Option(HelpText = "The unit of measure.")]
        public string UnitOfMeasure { get; set; }

        [Option(HelpText = "The conversion rate for the unit of measure.")]
        public decimal UnitOfMeasureConversion { get; set; }

        [Option(HelpText = "Set to true to use fixed planning quantity.")]
        public bool UseFixedPlanningQuantity { get; set; }

        [Option(HelpText = "The appointment's planning quantity.")]
        public decimal PlanningQuantity { get; set; }

        [Option(HelpText = "Flag to indicate whether to round up the unit of measure.")]
        public bool RoundToUnitOfMeasure { get; set; }

        [Option(HelpText = "Flag to indicate whether the record is sent from the back office.")]
        public bool SentFromBackOffice { get; set; }

        public IImportRequestable ToImport() => (Appointment)this;

        public static implicit operator Appointment(AppointmentOptions options)
            => new()
            {
                ResourceNo = options.ResourceNo,
                Start = options.Start,
                End = options.End,
                SourceApp = options.SourceApp,
                SourceType = options.SourceType,
                TaskNo = options.TaskNo,
                JobNo = options.JobNo,
                Subject = options.Subject,
                Body = options.Body,
                Category = options.Category,
                TimeMarker = options.TimeMarker,
                Importance = options.Importance,
                Locked = options.Locked,
                SentFromBackOffice = options.SentFromBackOffice,
                PlanningQuantity = options.PlanningQuantity,
                UnitOfMeasure = options.UnitOfMeasure,
                UnitOfMeasureConversion = options.UnitOfMeasureConversion,
                RoundToUnitOfMeasure = options.RoundToUnitOfMeasure,
                UseFixedPlanningQuantity = options.UseFixedPlanningQuantity
            };
    }
}