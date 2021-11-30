using System;
using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addAppointmentContent", HelpText = "Updates a part of the appointment.")]
    public class AddAppointmentContentOptions : BaseOptions
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public long AppointmentId { get; set; }

        [Option]
        public string Subject { get; set; }

        [Option]
        public string Body { get; set; }

        [Option]
        public Guid? AppointmentGuid { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; }
    }
}