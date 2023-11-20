using System;
using CommandLine;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("resourcecalendar", HelpText = "Assigns a calendar to the resource.")]
    public class ResourceCalendarOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The resource calendar code.")]
        public string Code { get; set; }

        [Option(HelpText = "The unique identifier to describe the resource.")]
        public string ResourceNo { get; set; }

        [Option(HelpText = "The unique identifier to describe the calendar.")]
        public string CalendarCode { get; set; }

        [Option(HelpText = "The start date.")]
        public DateTime StartDate { get; set; }

        [Option(HelpText = "The end date.")]
        public DateTime EndDate { get; set; }

        public IImportRequestable ToImport() => (ResourceCalendar)this;

        public static implicit operator ResourceCalendar(ResourceCalendarOptions options)
          => new()
          {
              CalendarCode = options.CalendarCode,
              Code = options.Code,
              EndDate = options.EndDate,
              ResourceNo = options.ResourceNo,
              StartDate = options.StartDate
          };
    }
}