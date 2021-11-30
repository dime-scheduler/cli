using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("addPin", HelpText = "Adds a pin.")]
    public class AddPinOptions : IndicatorOptions, IImportConvertable
    {
        public IImportRequestable ToImport() => (Pin)this;

        public static implicit operator Pin(AddPinOptions options)
          => new()
          {
              Color = options.Color,
              Name = options.Name
          };
    }
}