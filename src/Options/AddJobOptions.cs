using CommandLine;
using Dime.Scheduler.Sdk.Import;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addJob", HelpText = "Adds a job.")]
    public class AddJobOptions : BaseOptions
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
    }
}