﻿using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Commands
{
    public class AssignmentCommand :
        ImportCommand<AssignmentOptions, Assignment>,
        ICommand<AssignmentOptions>
    {
        protected override string WriteIntro(AssignmentOptions options)
            => "Adding assignment.";
    }
}