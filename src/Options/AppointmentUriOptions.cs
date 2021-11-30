using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("appointmenturi", HelpText = "Appends an appointment URI.")]
    public class AppointmentUriOptions : BaseOptions, IImportConvertable
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

        public IImportRequestable ToImport() => (AppointmentUri)this;

        public static implicit operator AppointmentUri(AppointmentUriOptions options)
            => new()
            {
                AppointmentGuid = options.AppointmentGuid,
                AppointmentId = options.AppointmentId,
                Uri = options.Uri,
                SourceApp = options.SourceApp,
                SourceType = options.SourceType,
                Description = options.Description
            };
    }
}