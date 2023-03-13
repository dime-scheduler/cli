﻿using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class ResourceLiveLocationTests
    {
        [Fact]
        public void Mapping_ResourceLiveLocation_TestProperties()
        {
            ResourceLiveLocationOptions options = new()
            {
                Append = true,
                Key = "X-123",
                Uri = "Hello world",
                Delete = true,
                Latitude = 35.25M,
                Longitude = 15.15M,
                ResourceNo = "RESOURCENO"
            };

            options.AssertEqualProperties((ResourceGpsTracking)options);
        }
    }
}