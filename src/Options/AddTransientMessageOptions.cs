﻿using CommandLine;

namespace Dime.Scheduler.DotNetTool
{
    [Verb("addTransientMessage", HelpText = "Adds a fly-in message to the online users")]
    public class AddTransientMessageOptions : BaseOptions
    {
        [Option('t', "text", Required = true)]
        public string Text { get; set; }

        [Option('s', "severity", Required = true)]
        public int Severity { get; set; }

        [Option('a', "to", Required = true)]
        public string To { get; set; }
    }
}