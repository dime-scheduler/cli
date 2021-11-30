using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("resourcecapacity", HelpText = "Allocates capacity to the resource.")]
    public class ResourceCapacityOptions : BaseOptions, IImportConvertable
    {
        [Option]
        public string ResourceNo { get; set; }

        [Option]
        public DateTime Date  { get; set; }

        [Option]
        public long? CapacityInSeconds { get; set; }

        [Option]
        public decimal? Quantity { get; set; }

        [Option]
        public string UnitOfMeasure { get; set; }  

        [Option]
        public decimal? UnitOfMeasureConversion { get; set; }

        public IImportRequestable ToImport() => (ResourceCapacity)this;

        public static implicit operator ResourceCapacity(ResourceCapacityOptions options)
          => new()
          {
              CapacityInSeconds = options.CapacityInSeconds,
              Date = options.Date,
              Quantity = options.Quantity,
              ResourceNo = options.ResourceNo,
              UnitOfMeasure = options.UnitOfMeasure,
              UnitOfMeasureConversion = options.UnitOfMeasureConversion
          };
    }
}