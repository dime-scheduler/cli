using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Resource = Dime.Scheduler.Sdk.Import.Resource;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddResourceCommand : ICommand<AddResourceOptions>
    {
        public async Task ProcessAsync(AddResourceOptions options)
        {
            try
            {
                Console.WriteLine($"Adding resource.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                Resource resource = new()
                {
                    BulkCapacity = options.BulkCapacity,
                    BulkPlanning = options.BulkPlanning,
                    Department = options.Department,
                    DisplayName = options.DisplayName,
                    DoNotShow = options.DoNotShow,
                    Email = options.Email,
                    ExchangeIntegrationEnabled = options.ExchangeIntegrationEnabled,
                    FieldServiceEmail = options.FieldServiceEmail,
                    FreeBit1 = options.FreeBit1,
                    FreeBit2 = options.FreeBit2,
                    FreeBit3 = options.FreeBit3,
                    FreeBit4 = options.FreeBit4,
                    FreeBit5 = options.FreeBit5,
                    FreeDate1 = options.FreeDate1,
                    FreeDate2 = options.FreeDate2,
                    FreeDate3 = options.FreeDate3,
                    FreeDate4 = options.FreeDate4,
                    FreeDate5 = options.FreeDate5,
                    FreeDecimal1 = options.FreeDecimal1,
                    FreeDecimal2 = options.FreeDecimal2,
                    FreeDecimal3 = options.FreeDecimal3,
                    FreeDecimal4 = options.FreeDecimal4,
                    FreeDecimal5 = options.FreeDecimal5,
                    FreeText1 = options.FreeText1,
                    FreeText10 = options.FreeText10,
                    FreeText11 = options.FreeText11,
                    FreeText12 = options.FreeText12,
                    FreeText13 = options.FreeText13,
                    FreeText14 = options.FreeText14,
                    FreeText15 = options.FreeText15,
                    FreeText16 = options.FreeText16,
                    FreeText17 = options.FreeText17,
                    FreeText18 = options.FreeText18,
                    FreeText19 = options.FreeText19,
                    FreeText20 = options.FreeText20,
                    FreeText2 = options.FreeText2,
                    FreeText3 = options.FreeText3,
                    FreeText4 = options.FreeText4,
                    FreeText5 = options.FreeText5,
                    FreeText6 = options.FreeText6,
                    FreeText7 = options.FreeText7,
                    FreeText8 = options.FreeText8,
                    FreeText9 = options.FreeText9,
                    GpsTrackingResourceNo = options.GpsTrackingResourceNo,
                    HomeAddress = options.HomeAddress,
                    HomeAddressGeoLat = options.HomeAddressGeoLat,
                    HomeAddressGeoLong = options.HomeAddressGeoLong,
                    HomeCity = options.HomeCity,
                    HomeCountry = options.HomeCountry,
                    HomeCounty = options.HomeCounty,
                    HomeEmail = options.HomeEmail,
                    HomePhone = options.HomePhone,
                    HomePostcode = options.HomePostcode,
                    HomeRegion = options.HomeRegion,
                    HomeState = options.HomeState,
                    HomeStreet = options.HomeStreet,
                    HomeStreetNo = options.HomeStreetNo,
                    InServiceFrom = options.InServiceFrom,
                    InServiceTill = options.InServiceTill,
                    MobilePhone = options.MobilePhone,
                    PersonalEmail = options.PersonalEmail,
                    Phone = options.Phone,
                    Pin = options.Pin,
                    ReplacementResource = options.ReplacementResource,
                    ResourceGpsTrackingEnabled = options.ResourceGpsTrackingEnabled,
                    ResourceName = options.ResourceName,
                    ResourceNo = options.ResourceNo,
                    ResourceType = options.ResourceType,
                    ResourceTypeId = options.ResourceTypeId,
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType,
                    TeamCode = options.TeamCode,
                    TeamMemberSort = options.TeamMemberSort,
                    TeamMemberType = options.TeamMemberType,
                    TeamName = options.TeamName,
                    TeamSort = options.TeamSort,
                    TeamType = options.TeamType,
                    Url1 = options.Url1,
                    Url2 = options.Url2,
                    Url3 = options.Url3,
                    UrlDescription1 = options.UrlDescription1,
                    UrlDescription2 = options.UrlDescription2,
                    UrlDescription3 = options.UrlDescription3
                };

                ImportSet result = await importEndpoint.ProcessAsync(resource, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}