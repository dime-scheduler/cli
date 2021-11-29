using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddJobCommand : ICommand<AddJobOptions>
    {
        public async Task ProcessAsync(AddJobOptions options)
        {
            try
            {
                Console.WriteLine($"Adding job with no {options.JobNo}");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                Job Job = new()
                {
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType,
                    JobNo = options.JobNo,
                    ShortDescription = options.ShortDescription,
                    Description = options.Description,
                    AllowDependencies = options.AllowDependencies,
                    AvailableInGantt = options.AvailableInGantt,
                    BillAddress = options.BillAddress,
                    BillAddressGeoLat = options.BillAddressGeoLat,
                    BillAddressGeoLong = options.BillAddressGeoLong,
                    BillEmail = options.BillEmail,
                    BillName = options.BillName,
                    BillNo = options.BillNo,
                    BillPhone = options.BillPhone,
                    BillRegion = options.BillRegion,
                    Category = options.Category,
                    CheckAppointments = options.CheckAppointments,
                    ContactAddress = options.ContactAddress,
                    ContactAddressGeoLat = options.ContactAddressGeoLat,
                    ContactAddressGeoLong = options.ContactAddressGeoLong,
                    ContactEmail = options.ContactEmail,
                    ContactName = options.ContactName,
                    ContactNo = options.ContactNo,
                    ContactPhone = options.ContactPhone,
                    CreationDateTime = options.CreationDateTime,
                    Creator = options.Creator,
                    CustomerAddress = options.CustomerAddress,
                    CustomerAddressGeoLong = options.CustomerAddressGeoLong,
                    CustomerAddressGeoLat = options.CustomerAddressGeoLat,
                    CustomerEmail = options.CustomerEmail,
                    CustomerNo = options.CustomerNo,
                    CustomerName = options.CustomerName,
                    CustomerPhone = options.CustomerPhone,
                    CustomerReference = options.CustomerReference,
                    EnableManualSelection = options.EnableManualSelection,
                    EndDate = options.EndDate,
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
                    FreeText2 = options.FreeText2,
                    FreeText3 = options.FreeText3,
                    FreeText4 = options.FreeText4,
                    FreeText5 = options.FreeText5,
                    FreeText6 = options.FreeText6,
                    FreeText7 = options.FreeText7,
                    FreeText8 = options.FreeText8,
                    FreeText9 = options.FreeText9,
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
                    Importance = options.Importance,
                    Language = options.Language,
                    Name = options.Name,
                    Note = options.Note,
                    OverRuleGanttPlanning = options.OverRuleGanttPlanning,
                    Pin = options.Pin,
                    Responsible = options.Responsible,
                    SentFromBackOffice = options.SentFromBackOffice,
                    SiteAddress = options.SiteAddress,
                    SiteAddressGeoLat = options.SiteAddressGeoLat,
                    SiteAddressGeoLong = options.SiteAddressGeoLong,
                    SiteCity = options.SiteCity,
                    SiteCountry = options.SiteCountry,
                    SitePhone = options.SitePhone,
                    SiteCounty = options.SiteCounty,
                    SiteName = options.SiteName,
                    SiteEmail = options.SiteEmail,
                    SiteFromAddress = options.SiteFromAddress,
                    SiteFromAddressGeoLat = options.SiteFromAddressGeoLat,
                    SiteFromAddressGeoLong = options.SiteFromAddressGeoLong,
                    SiteFromCity = options.SiteCity,
                    SiteFromCountry = options.SiteCountry,
                    SiteFromCounty = options.SiteCounty,
                    SiteFromEmail = options.SiteEmail,
                    SiteFromName = options.SiteFromName,
                    SiteFromNo = options.SiteFromNo,
                    SiteFromPhone = options.SiteFromPhone,
                    SiteFromPostcode = options.SiteFromPostcode,
                    SiteFromRegion = options.SiteFromRegion,
                    SiteFromStreet = options.SiteFromStreet,
                    SiteFromState = options.SiteFromState,
                    SiteFromStreetNo = options.SiteFromStreetNo,
                    SiteNo = options.SiteNo,
                    SitePostcode = options.SitePostcode,
                    SiteRegion = options.SiteRegion,
                    SiteState = options.SiteState,
                    SiteStreetNo = options.SiteStreetNo,
                    SiteStreet = options.SiteStreet,
                    StartDate = options.StartDate,
                    TimeMarker = options.TimeMarker,
                    Type = options.Type
                };

                ImportSet result = await importEndpoint.ProcessAsync(Job, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}