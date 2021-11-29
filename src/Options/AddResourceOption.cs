using CommandLine;
using Dime.Scheduler.Sdk;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addResource", HelpText = "Adds a resource.")]
    public class AddResourceOptions : BaseOptions
    {
        [Option(Required = true)]
        public string ResourceNo { get; set; }

        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public string ResourceType { get; set; }

        [Option]
        public int? ResourceTypeId { get; set; }

        [Option]
        public string ResourceName { get; set; }

        [Option]
        public string DisplayName { get; set; }

        [Option]
        public string Department { get; set; }

        [Option]
        public string Email { get; set; }

        [Option]
        public string Phone { get; set; }

        [Option]
        public string MobilePhone { get; set; }

        [Option]
        public bool ReplacementResource { get; set; }

        [Option]
        public string FieldServiceEmail { get; set; }

        [Option]
        public string PersonalEmail { get; set; }

        [Option]
        public string GpsTrackingResourceNo { get; set; }

        [Option]
        public string HomeAddress { get; set; }

        [Option]
        public float? HomeAddressGeoLong { get; set; }

        [Option]
        public float? HomeAddressGeoLat { get; set; }

        [Option]
        public string HomePhone { get; set; }

        [Option]
        public string HomeEmail { get; set; }

        [Option]
        public string HomeStreet { get; set; }

        [Option]
        public string HomeStreetNo { get; set; }

        [Option]
        public string HomePostcode { get; set; }

        [Option]
        public string HomeCity { get; set; }

        [Option]
        public string HomeCounty { get; set; }

        [Option]
        public string HomeState { get; set; }

        [Option]
        public string HomeCountry { get; set; }

        [Option]
        public string HomeRegion { get; set; }

        [Option]
        public string TeamCode { get; set; }

        [Option]
        public string TeamName { get; set; }

        [Option]
        public string TeamType { get; set; }

        [Option]
        public int TeamSort { get; set; }

        [Option]
        public string TeamMemberType { get; set; }

        [Option]
        public int TeamMemberSort { get; set; }

        [Option]
        public bool DoNotShow { get; set; }

        [Option]
        public DateTime? InServiceFrom { get; set; }

        [Option]
        public DateTime? InServiceTill { get; set; }

        [Option]
        public bool ExchangeIntegrationEnabled { get; set; }

        [Option]
        public string Url1 { get; set; }

        [Option]
        public string UrlDescription1 { get; set; }

        [Option]
        public string Url2 { get; set; }

        [Option]
        public string UrlDescription2 { get; set; }

        [Option]
        public string Url3 { get; set; }

        [Option]
        public string UrlDescription3 { get; set; }

        [Option]
        public bool BulkPlanning { get; set; }

        [Option]
        public decimal BulkCapacity { get; set; }

        [Option]
        public bool ResourceGpsTrackingEnabled { get; set; }

        [Option]
        public string Pin { get; set; }

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
    }
}