using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addContainer", HelpText = "Adds a container.")]
    public class AddContainerOptions : BaseOptions, IImportConvertable
    {
        [Option('n', "name", Required = true)]
        public string Name { get; set; }

        [Option('d', "date", Required = true)]
        public DateTime HandleDate { get; set; }

        [Option('l', "locked", Required = true)]
        public bool HandleLocked { get; set; }

        public IImportRequestable ToImport() => (Container)this;

        public static implicit operator Container(AddContainerOptions options)
          => new()
          {
              HandleDate = options.HandleDate,
              HandleLocked = options.HandleLocked,
              Name = options.Name
          };
    }
}