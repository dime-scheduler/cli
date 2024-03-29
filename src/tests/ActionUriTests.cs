﻿using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class ActionUriTests
    {
        [Fact]
        public void Mapping_ActionUri_TestProperties()
        {
            ActionUriOptions options = new()
            {
                Default = true,
                Description = "Hello world",
                Link = "Hello world",
                SourceApp = "Hello world",
                SourceType = "Hello world",
                UriType = UriType.Appointment
            };

            options.AssertEqualProperties((ActionUri)options);
        }
    }
}