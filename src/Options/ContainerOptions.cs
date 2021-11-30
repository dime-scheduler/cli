using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("container", HelpText = "Add or remove a container.")]
    public class ContainerOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true)]
        public string Name { get; set; }

        [Option(Required = true)]
        public DateTime HandleDate { get; set; }

        [Option(Required = true)]
        public bool HandleLocked { get; set; }

        public IImportRequestable ToImport() => (Container)this;

        public static implicit operator Container(ContainerOptions options)
          => new()
          {
              HandleDate = options.HandleDate,
              HandleLocked = options.HandleLocked,
              Name = options.Name
          };
    }
}