using System;
using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addAppointmentUri", HelpText = "Updates a part of the appointment.")]
    public class AddAppointmentUriOptions : BaseOptions
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public long AppointmentId { get; set; }

        [Option]
        public string Link { get; set; }

        [Option]
        public string Description { get; set; }

        [Option]
        public Guid? AppointmentGuid { get; set; }
    }
}