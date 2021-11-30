using System;
using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addResourceCapacity", HelpText = "Updates a part of the resource.")]
    public class AddResourceCapacityOptions : BaseOptions
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
    }
}