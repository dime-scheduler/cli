using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI
{
    [Verb("resourcecapacity", HelpText = "Allocates capacity to the resource.")]
    public class ResourceCapacityOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "The unique identifier to describe the resource.")]
        public string ResourceNo { get; set; }

        [Option(HelpText = "The capacity entry's date.")]
        public DateTime Date  { get; set; }

        [Option(HelpText = "The capacity entry in seconds.")]
        public long? CapacityInSeconds { get; set; }

        [Option(HelpText = "The entry.")]
        public decimal? Quantity { get; set; }

        [Option(HelpText = "The unit of measure.")]
        public string UnitOfMeasure { get; set; }  

        [Option(HelpText = "The conversion rate.")]
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