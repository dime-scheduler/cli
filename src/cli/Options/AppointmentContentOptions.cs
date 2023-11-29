using CommandLine;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("appointmentcontent", HelpText = "Sets the appointment's body and subject.")]
    public class AppointmentContentOptions : AppointmentAttributeOptions, IImportConvertable
    {
        [Option(HelpText = "The appointment's subject.")]
        public string Subject { get; set; }

        [Option(HelpText = "The appointment's body.")]
        public string Body { get; set; }

        public IImportRequestable ToImport() => (AppointmentContent)this;

        public static implicit operator AppointmentContent(AppointmentContentOptions options)
            => new()
            {
                AppointmentGuid = options.AppointmentGuid,
                AppointmentId = options.AppointmentId,
                Subject = options.Subject,
                Body = options.Body,
                SentFromBackOffice = options.SentFromBackOffice,
                SourceApp = options.SourceApp,
                SourceType = options.SourceType
            };
    }
}