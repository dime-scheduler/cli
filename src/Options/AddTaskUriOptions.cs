using CommandLine;
using Dime.Scheduler.Sdk;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addTaskUri", HelpText = "Adds a URI to a task.")]
    public class AddTaskUriOptions : BaseOptions
    {
        [Option]
        public string SourceApp { get; set; }

       [Option]
        public string SourceType { get; set; }

       [Option]
       public string JobNo { get; set; }

        [Option]
        public string TaskNo { get; set; }

       [Option]
        public string Uri { get; set; }

        [Option]
        public string Description { get; set; }
    }
}