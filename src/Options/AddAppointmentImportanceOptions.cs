using System;
using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addAppointmentImportance", HelpText = "Updates a part of the appointment.")]
    public class AddAppointmentImportanceOptions : BaseOptions
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public long AppointmentId { get; set; }

        [Option]
        public int Importance { get; set; }

        [Option]
        public Guid? AppointmentGuid { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; }
    }
}