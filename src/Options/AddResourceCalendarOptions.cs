using System;
using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addResourceCalendar", HelpText = "Updates a part of the resource.")]
    public class AddResourceCalendarOptions : BaseOptions
    {
        [Option]
        public string Code { get; set; }

        [Option]
        public string ResourceNo { get; set; }

        [Option]
        public string CalendarCode { get; set; }

        [Option]
        public DateTime StartDate { get; set; }

        [Option]
        public DateTime EndDate { get; set; }
    }
}