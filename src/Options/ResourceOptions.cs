using CommandLine;
using Dime.Scheduler.Sdk.Import;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("resource", HelpText = "Add or remove a resource.")]
    public class ResourceOptions : BaseOptions, IImportConvertable
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

        public IImportRequestable ToImport() => (Resource)this;

        public static implicit operator Resource(ResourceOptions options)
            => new()
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
    }
}