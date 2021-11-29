using CommandLine;
using Dime.Scheduler.Sdk;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addTaskLocked", HelpText = "Locks or unlocks a task.")]
    public class AddTaskLockedOptions : BaseOptions
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
        public bool Locked { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; } = true;
    }
}