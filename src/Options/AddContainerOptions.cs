using System;
using CommandLine;

namespace Dime.Scheduler.DotNetTool
{
    [Verb("addContainer", HelpText = "Adds a container.")]
    public class AddContainerOptions : BaseOptions
    {
        [Option('n', "name", Required = true)]
        public string Name { get; set; }

        [Option('d', "date", Required = true)]
        public DateTime HandleDate { get; set; }

        [Option('l', "locked", Required = true)]
        public bool HandleLocked { get; set; }
    }
}