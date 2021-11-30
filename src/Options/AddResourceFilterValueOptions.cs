using System;
using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addResourceFilterValue", HelpText = "Updates a part of the resource.")]
    public class AddResourceFilterValueOptions : BaseOptions
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public string ResourceNo { get; set; }

        [Option]
        public string FilterGroup { get; set; }

        [Option]
        public string FilterValue { get; set; }

        [Option]
        public bool TransferToTemp { get; set; }
    }
}