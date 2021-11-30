using System;
using CommandLine;

namespace Dime.Scheduler.CLI
{
    [Verb("addResourceUri", HelpText = "Updates a part of the resource.")]
    public class AddResourceUriOptions : BaseOptions
    {
        [Option]
        public string ResourceNo { get; set; }

        [Option]
        public string Link { get; set; }

        [Option]
        public string Description { get; set; }
    }
}