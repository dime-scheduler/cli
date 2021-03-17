using System;
using CommandLine;

namespace Dime.Scheduler.DotNetTool
{
    [Verb("addAppointment", HelpText = "Adds an appointment to the planning board.")]
    public class AddAppointmentOptions : BaseOptions
    {
        [Option("sourceapp", Required = true)]
        public string SourceApp { get; set; }

        [Option("sourcetype", Required = true)]
        public string SourceType { get; set; }

        [Option("resourceno", Required = true)]
        public string ResourceNo { get; set; }

        [Option("jobno", Required = true)]
        public string JobNo { get; set; }

        [Option("taskno", Required = true)]
        public string TaskNo { get; set; }

        [Option("start", Required = true)]
        public DateTime Start { get; set; }

        [Option("end", Required = true)]
        public DateTime End { get; set; }

        [Option("subject")]
        public string Subject { get; set; }

        [Option("body")]
        public string Body { get; set; }

        [Option("timemarker")]
        public string TimeMarker { get; set; }

        [Option("category")]
        public string Category { get; set; }

        [Option("importance")]
        public int Importance { get; set; }

        [Option("locked")]
        public bool Locked { get; set; }

        [Option("uom")]
        public string UnitOfMeasure { get; set; }

        [Option("uomconversion")]
        public decimal UnitOfMeasureConversion { get; set; }

        [Option("usefixedplanningquantity")]
        public bool UseFixedPlanningQuantity { get; set; }

        [Option("planningquantity")]
        public decimal PlanningQuantity { get; set; }

        [Option("roundtounitofmeasure")]
        public bool RoundToUnitOfMeasure { get; set; }

        [Option("sentfrombackoffice")]
        public bool SentFromBackOffice { get; set; }
    }
}