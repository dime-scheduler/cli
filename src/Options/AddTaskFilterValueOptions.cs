using CommandLine;
using Dime.Scheduler.Sdk;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addTaskFilterValue", HelpText = "Adds a filter value to a task.")]
    public class AddTaskFilterValueOptions : BaseOptions
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
        public string FilterGroup { get; set; }

        [Option]
        public string FilterValue { get; set; }

        [Option]
        public bool TransferToTemp { get; set; }
    }
}