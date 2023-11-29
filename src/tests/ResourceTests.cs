﻿using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class ResourceTests
    {
        [Fact]
        public void Mapping_Resource_TestProperties()
        {
            Options.ResourceOptions options = new();
            options.AssertEqualProperties((Entities.Resource)options);
        }
    }
}