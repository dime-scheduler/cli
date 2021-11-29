using CommandLine;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addAssignment", HelpText = "Adds an assignment.")]
    public class AddAssignmentOptions : BaseOptions
    {
        [Option(Required = true)]
        public string SourceApp { get; set; }

        [Option(Required = true)] public string SourceType { get; set; }

        [Option(Required = true)]
        public long AppointmentId { get; set; }

        [Option]
        public Guid? AppointmentGuid { get; set; }

        [Option(Required = true)]
        public string ResourceNo { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; } = true;

    }
}