using CommandLine;
using Dime.Scheduler.Sdk.Import;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addJob", HelpText = "Adds a job.")]
    public class AddJobOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true)]
        public string SourceApp { get; set; }

        [Option(Required = true)]
        public string SourceType { get; set; }

        [Option(Required = true)]
        public string JobNo { get; set; }

        [Option(Required = true)]
        public string ShortDescription { get; set; }

        [Option]
        public string Description { get; set; }

        [Option]
        public string Type { get; set; }

        [Option]
        public string Name { get; set; }

        [Option]
        public string Category { get; set; }

        [Option]
        public string TimeMarker { get; set; }

        [Option]
        public string Pin { get; set; }

        [Option]
        public string CustomerNo { get; set; }

        [Option]
        public string CustomerName { get; set; }

        [Option]
        public string CustomerAddress { get; set; }

        [Option]
        public string CustomerAddressGeoLong { get; set; }

        [Option]
        public string CustomerAddressGeoLat { get; set; }

        [Option]
        public string CustomerPhone { get; set; }

        [Option]
        public string CustomerEmail { get; set; }

        [Option]
        public string ContactNo { get; set; }

        [Option]
        public string ContactName { get; set; }

        [Option]
        public string ContactAddress { get; set; }

        [Option]
        public string ContactAddressGeoLong { get; set; }

        [Option]
        public string ContactAddressGeoLat { get; set; }

        [Option]
        public string ContactPhone { get; set; }

        [Option]
        public string ContactEmail { get; set; }

        [Option]
        public string SiteNo { get; set; }

        [Option]
        public string SiteName { get; set; }

        [Option]
        public string SiteAddress { get; set; }

        [Option]
        public string SiteAddressGeoLong { get; set; }

        [Option]
        public string SiteAddressGeoLat { get; set; }

        [Option]
        public string SitePhone { get; set; }

        [Option]
        public string SiteEmail { get; set; }

        [Option]
        public string SiteRegion { get; set; }

        [Option]
        public string SiteStreet { get; set; }

        [Option]
        public string SiteStreetNo { get; set; }

        [Option]
        public string SitePostcode { get; set; }

        [Option]
        public string SiteCity { get; set; }

        [Option]
        public string SiteCounty { get; set; }

        [Option]
        public string SiteState { get; set; }

        [Option]
        public string SiteCountry { get; set; }

        [Option]
        public string SiteFromNo { get; set; }

        [Option]
        public string SiteFromName { get; set; }

        [Option]
        public string SiteFromAddress { get; set; }

        [Option]
        public string SiteFromAddressGeoLong { get; set; }

        [Option]
        public string SiteFromAddressGeoLat { get; set; }

        [Option]
        public string SiteFromPhone { get; set; }

        [Option]
        public string SiteFromEmail { get; set; }

        [Option]
        public string SiteFromRegion { get; set; }

        [Option]
        public string SiteFromStreet { get; set; }

        [Option]
        public string SiteFromStreetNo { get; set; }

        [Option]
        public string SiteFromPostcode { get; set; }

        [Option]
        public string SiteFromCity { get; set; }

        [Option]
        public string SiteFromCounty { get; set; }

        [Option]
        public string SiteFromState { get; set; }

        [Option]
        public string SiteFromCountry { get; set; }

        [Option]
        public string BillNo { get; set; }

        [Option]
        public string BillName { get; set; }

        [Option]
        public string BillAddress { get; set; }

        [Option]
        public string BillAddressGeoLong { get; set; }

        [Option]
        public string BillAddressGeoLat { get; set; }

        [Option]
        public string BillPhone { get; set; }

        [Option]
        public string BillEmail { get; set; }

        [Option]
        public string BillRegion { get; set; }

        [Option]
        public Importance Importance { get; set; }

        [Option]
        public DateTime? CreationDateTime { get; set; }

        [Option]
        public string CustomerReference { get; set; }

        [Option]
        public string Language { get; set; }

        [Option]
        public string Responsible { get; set; }

        [Option]
        public string Creator { get; set; }

        [Option]
        public string FreeText1 { get; set; }

        [Option]
        public string FreeText2 { get; set; }

        [Option]
        public string FreeText3 { get; set; }

        [Option]
        public string FreeText4 { get; set; }

        [Option]
        public string FreeText5 { get; set; }

        [Option]
        public string FreeText6 { get; set; }

        [Option]
        public string FreeText7 { get; set; }

        [Option]
        public string FreeText8 { get; set; }

        [Option]
        public string FreeText9 { get; set; }

        [Option]
        public string FreeText10 { get; set; }

        [Option]
        public string FreeText11 { get; set; }

        [Option]
        public string FreeText12 { get; set; }

        [Option]
        public string FreeText13 { get; set; }

        [Option]
        public string FreeText14 { get; set; }

        [Option]
        public string FreeText15 { get; set; }

        [Option]
        public string FreeText16 { get; set; }

        [Option]
        public string FreeText17 { get; set; }

        [Option]
        public string FreeText18 { get; set; }

        [Option]
        public string FreeText19 { get; set; }

        [Option]
        public string FreeText20 { get; set; }

        [Option]
        public decimal FreeDecimal1 { get; set; }

        [Option]
        public decimal FreeDecimal2 { get; set; }

        [Option]
        public decimal FreeDecimal3 { get; set; }

        [Option]
        public decimal FreeDecimal4 { get; set; }

        [Option]
        public decimal FreeDecimal5 { get; set; }

        [Option]
        public DateTime? FreeDate1 { get; set; }

        [Option]
        public DateTime? FreeDate2 { get; set; }

        [Option]
        public DateTime? FreeDate3 { get; set; }

        [Option]
        public DateTime? FreeDate4 { get; set; }

        [Option]
        public DateTime? FreeDate5 { get; set; }

        [Option]
        public bool FreeBit1 { get; set; }

        [Option]
        public bool FreeBit2 { get; set; }

        [Option]
        public bool FreeBit3 { get; set; }

        [Option]
        public bool FreeBit4 { get; set; }

        [Option]
        public bool FreeBit5 { get; set; }

        [Option]
        public bool EnableManualSelection { get; set; }

        [Option]
        public bool AvailableInGantt { get; set; }

        [Option]
        public DateTime? StartDate { get; set; }

        [Option]
        public DateTime? EndDate { get; set; }

        [Option]
        public bool AllowDependencies { get; set; } = true;

        [Option]
        public string Note { get; set; }

        [Option]
        public bool OverRuleGanttPlanning { get; set; }

        [Option]
        public bool CheckAppointments { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; } = true;

        public IImportRequestable ToImport() => (Sdk.Import.Job)this;

        public static implicit operator Sdk.Import.Job(AddJobOptions options)
          => new()
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
    }
}