﻿using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class AppointmentTimeMarkerTests
    {
        [Fact]
        public void Mapping_AppointmentTimeMarker_TestProperties()
        {
            AppointmentTimeMarkerOptions options = new()
            {
                SourceType = "Hello world",
                SourceApp = "Hello world",
                Key = "Hello world",
                AppointmentGuid = System.Guid.NewGuid(),
                AppointmentId = 1,
                TimeMarker = "Hello world",
                SentFromBackOffice = true
            };

            options.AssertEqualProperties((AppointmentTimeMarker)options);
        }
    }
}