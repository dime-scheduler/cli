using System;
using CommandLine;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("assignment", HelpText = "Add or remove an assignment.")]
    public class AssignmentOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true, HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(Required = true, HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(Required = true, HelpText = "The appointment's ID.")]
        public long AppointmentId { get; set; }

        [Option(HelpText = "The appointment's GUID.")]
        public Guid? AppointmentGuid { get; set; }

        [Option(Required = true, HelpText = "The resource number.")]
        public string ResourceNo { get; set; }

        [Option(HelpText = "Flag to indicate whether the record is sent from the back office.")]
        public bool SentFromBackOffice { get; set; } = true;

        public IImportRequestable ToImport() => (Assignment)this;

        public static implicit operator Assignment(AssignmentOptions options)
          => new()
          {
              AppointmentGuid = options.AppointmentGuid,
              AppointmentId = options.AppointmentId,
              ResourceNo = options.ResourceNo,
              SentFromBackOffice = options.SentFromBackOffice,
              SourceApp = options.SourceApp,
              SourceType = options.SourceType
          };
    }
}