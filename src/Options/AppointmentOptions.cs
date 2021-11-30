using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("appointment", HelpText = "Add or remove an appointment to or from the planning board.")]
    public class AppointmentOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true)]
        public string SourceApp { get; set; }

        [Option(Required = true)]
        public string SourceType { get; set; }

        [Option(Required = true)]
        public string ResourceNo { get; set; }

        [Option(Required = true)]
        public string JobNo { get; set; }

        [Option(Required = true)]
        public string TaskNo { get; set; }

        [Option(Required = true)]
        public DateTime Start { get; set; }

        [Option(Required = true)]
        public DateTime End { get; set; }

        [Option]
        public string Subject { get; set; }

        [Option]
        public string Body { get; set; }

        [Option]
        public string TimeMarker { get; set; }

        [Option]
        public string Category { get; set; }

        [Option]
        public int Importance { get; set; }

        [Option]
        public bool Locked { get; set; }

        [Option]
        public string UnitOfMeasure { get; set; }

        [Option]
        public decimal UnitOfMeasureConversion { get; set; }

        [Option]
        public bool UseFixedPlanningQuantity { get; set; }

        [Option]
        public decimal PlanningQuantity { get; set; }

        [Option]
        public bool RoundToUnitOfMeasure { get; set; }

        [Option]
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