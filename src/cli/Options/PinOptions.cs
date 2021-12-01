using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("pin", HelpText = "Add or remove a pin.")]
    public class PinOptions : IndicatorOptions, IImportConvertable
    {
        public IImportRequestable ToImport() => (Pin)this;

        public static implicit operator Pin(PinOptions options)
          => new()
          {
              Color = options.Color,
              Name = options.Name
          };
    }
}