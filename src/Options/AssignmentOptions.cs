using CommandLine;
using Dime.Scheduler.Sdk.Import;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("assignment", HelpText = "Add or remove an assignment.")]
    public class AssignmentOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true)]
        public string SourceApp { get; set; }

        [Option(Required = true)]
        public string SourceType { get; set; }

        [Option(Required = true)]
        public long AppointmentId { get; set; }

        [Option]
        public Guid? AppointmentGuid { get; set; }

        [Option(Required = true)]
        public string ResourceNo { get; set; }

        [Option]
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