using CommandLine;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("appointmenturi", HelpText = "Appends an appointment URI.")]
    public class AppointmentUriOptions : AppointmentAttributeOptions, IImportConvertable
    {
        [Option(HelpText = "The URI.")]
        public string Link { get; set; }

        [Option(HelpText = "The description.")]
        public string Description { get; set; }

        public IImportRequestable ToImport() => (AppointmentUri)this;

        public static implicit operator AppointmentUri(AppointmentUriOptions options)
            => new()
            {
                AppointmentGuid = options.AppointmentGuid,
                AppointmentId = options.AppointmentId,
                Uri = options.Link,
                SourceApp = options.SourceApp,
                SourceType = options.SourceType,
                Description = options.Description
            };
    }
}