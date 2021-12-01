using System;
using CommandLine;

namespace Dime.Scheduler.CLI.Options
{
    public abstract class AppointmentAttributeOptions : BaseOptions
    {
        [Option(HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(HelpText = "The appointment's ID.")]
        public long AppointmentId { get; set; }

        [Option(HelpText = "The appointment's GUID.")]
        public Guid? AppointmentGuid { get; set; }

        [Option(HelpText = "Flag to indicate whether the record is sent from the back office.")]
        public bool SentFromBackOffice { get; set; }
    }
}