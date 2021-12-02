using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk.Import;
using System;
using Xunit;

namespace Dime.Scheduler.CLI.Tests
{
    public class JobTests
    {
        [Fact]
        public void Mapping_Job_TestProperties()
        {
            JobOptions options = new()
            {
                AllowDependencies = true,
                Append = true,
                AvailableInGantt = true,
                BillAddress = "ADDRESS",
                BillAddressGeoLat = "15.0",
                BillAddressGeoLong = "16.0",
                BillEmail = "TEST",
                BillName = "TEST",
                BillNo = "TEST",
                BillPhone = "TEST",
                BillRegion = "TEST",
                Category = "TEST",
                CheckAppointments = true,
                ContactAddress = "TEST",
                ContactAddressGeoLat = "TEST",
                ContactAddressGeoLong = "TEST",
                ContactEmail = "TEST",
                ContactName = "TEST",
                ContactNo = "TEST",
                ContactPhone = "TEST",
                CreationDateTime = new DateTime(2021, 01, 10, 10, 30, 0),
                Creator = "TEST",
                CustomerAddress = "TEST",
                CustomerAddressGeoLat = "TEST",
                CustomerAddressGeoLong = "TEST",
                CustomerEmail = "TEST",
                CustomerName = "TEST",
                CustomerNo = "TEST",
                CustomerPhone = "TEST",
                CustomerReference = "TEST",
                Delete = true,
                Description = "TEST",
                EnableManualSelection = true,
                EndDate = new DateTime(2021, 01, 10, 10, 30, 0),
                FreeBit1 = true,
                FreeBit2 = true,
                FreeBit3 = true,
                FreeBit4 = true,
                FreeBit5 = true,
                FreeDate1 = new DateTime(2021, 2, 10, 10, 30, 0),
                FreeDate2 = new DateTime(2021, 2, 10, 10, 30, 0),
                FreeDate3 = new DateTime(2021, 2, 10, 10, 30, 0),
                FreeDate4 = new DateTime(2021, 2, 10, 10, 30, 0),
                FreeDate5 = new DateTime(2021, 2, 10, 10, 30, 0),
                FreeDecimal1 = 10,
                FreeDecimal2 = 10,
                FreeDecimal3 = 10,
                FreeDecimal4 = 10,
                FreeDecimal5 = 10,
                FreeText1 = "FREE TEXT",
                FreeText10 = "FREE TEXT",
                FreeText11 = "FREE TEXT",
                FreeText12 = "FREE TEXT",
                FreeText13 = "FREE TEXT",
                FreeText14 = "FREE TEXT",
                FreeText15 = "FREE TEXT",
                FreeText16 = "FREE TEXT",
                FreeText17 = "FREE TEXT",
                FreeText18 = "FREE TEXT",
                FreeText19 = "FREE TEXT",
                FreeText2 = "FREE TEXT",
                FreeText20 = "FREE TEXT",
                FreeText3 = "FREE TEXT",
                FreeText4 = "FREE TEXT",
                FreeText5 = "FREE TEXT",
                FreeText6 = "FREE TEXT",
                FreeText7 = "FREE TEXT",
                FreeText8 = "FREE TEXT",
                FreeText9 = "FREE TEXT",
                Importance = Sdk.Import.Importance.High,
                JobNo = "TEST",
                Language = "TEST",
                Name = "TEST",
                Note = "TEST",
                OverRuleGanttPlanning = true,
                Password = "TEST",
                Pin = "TEST",
                Responsible = "TEST",
                SentFromBackOffice = true,
                ShortDescription = "TEST",
                SiteAddress = "TEST",
                SiteAddressGeoLat = "TEST",
                SiteAddressGeoLong = "TEST",
                SiteCity = "TEST",
                SiteCountry = "TEST",
                SiteCounty = "TEST",
                SiteEmail = "TEST",
                SiteFromAddress = "TEST",
                SiteFromAddressGeoLat = "TEST",
                SiteFromAddressGeoLong = "TEST",
                SiteFromCity = "TEST",
                SiteFromCountry = "TEST",
                SiteFromCounty = "TEST",
                SiteFromEmail = "TEST",
                SiteFromName = "TEST",
                SiteFromNo = "TEST",
                SiteFromPhone = "TEST",
                SiteFromPostcode = "TEST",
                SiteFromRegion = "TEST",
                SiteFromState = "TEST",
                SiteFromStreet = "TEST",
                SiteFromStreetNo = "TEST",
                SiteName = "TEST",
                SiteNo = "TEST",
                SitePhone = "TEST",
                SitePostcode = "TEST",
                SiteRegion = "TEST",
                SiteState = "TEST",
                SiteStreet = "TEST",
                SiteStreetNo = "TEST",
                SourceApp = "TEST",
                SourceType = "TEST",
                StartDate = new DateTime(2021, 1, 10, 10, 5, 0),
                TimeMarker = "TEST",
                Type = "TEST",
                Uri = "TEST",
                User = "TEST"
            };

            options.AssertEqualProperties((Job)options);
        }
    }
}