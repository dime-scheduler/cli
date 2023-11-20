﻿using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class JobCommand :
        Command<JobOptions, Job>,
        ICommand<JobOptions>
    {
        protected override string WriteIntro(JobOptions options)
            => $"Adding job with number {options.JobNo}.";
    }
}