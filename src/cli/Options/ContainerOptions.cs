using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("container", HelpText = "Add or remove a container.")]
    public class ContainerOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true, HelpText = "The name.")]
        public string Name { get; set; }

        [Option(Required = true, HelpText = "The date to dock the handle")]
        public DateTime HandleDate { get; set; }

        [Option(Required = true, HelpText = "True if the handle should be locked.")]
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