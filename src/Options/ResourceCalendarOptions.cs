using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("resourcecalendar", HelpText = "Assigns a calendar to the resource.")]
    public class ResourceCalendarOptions : BaseOptions, IImportConvertable
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