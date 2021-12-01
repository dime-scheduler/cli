using CommandLine;
using Dime.Scheduler.Sdk.Import;
using System;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("resource", HelpText = "Add or remove a resource.")]
    public class ResourceOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true, HelpText = "The unique identifier to describe the resource.")]
        public string ResourceNo { get; set; }

        [Option(Required = true, HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(Required = true, HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(HelpText = "The resource type.")]
        public string ResourceType { get; set; }

        [Option(HelpText = "The resource type's identifier.")]
        public int? ResourceTypeId { get; set; }

        [Option(HelpText = "The resource's name.")]
        public string ResourceName { get; set; }

        [Option(HelpText = "The resource's display name.")]
        public string DisplayName { get; set; }

        [Option(HelpText = "The resource's department.")]
        public string Department { get; set; }

        [Option(HelpText = "The e-mail address.")]
        public string Email { get; set; }

        [Option(HelpText = "The phone number.")]
        public string Phone { get; set; }

        [Option(HelpText = "The mobile phone.")]
        public string MobilePhone { get; set; }

        [Option(HelpText = "True to mark it as a replacement resource.")]
        public bool ReplacementResource { get; set; }

        [Option(HelpText = "The field service mail.")]
        public string FieldServiceEmail { get; set; }

        [Option(HelpText = "The personal email address.")]
        public string PersonalEmail { get; set; }

        [Option(HelpText = "The tracking number.")]
        public string GpsTrackingResourceNo { get; set; }

        [Option(HelpText = "The home address.")]
        public string HomeAddress { get; set; }

        [Option(HelpText = "The home address longitude.")]
        public float? HomeAddressGeoLong { get; set; }

        [Option(HelpText = "The home address latitude.")]
        public float? HomeAddressGeoLat { get; set; }

        [Option(HelpText = "The home phone.")]
        public string HomePhone { get; set; }

        [Option(HelpText = "The home mail.")]
        public string HomeEmail { get; set; }

        [Option(HelpText = "The home street.")]
        public string HomeStreet { get; set; }

        [Option(HelpText = "The home street number.")]
        public string HomeStreetNo { get; set; }

        [Option(HelpText = "The home post code.")]
        public string HomePostcode { get; set; }

        [Option(HelpText = "The home city.")]
        public string HomeCity { get; set; }

        [Option(HelpText = "The home county.")]
        public string HomeCounty { get; set; }

        [Option(HelpText = "The home state.")]
        public string HomeState { get; set; }

        [Option(HelpText = "The home country")]
        public string HomeCountry { get; set; }

        [Option(HelpText = "The home region.")]
        public string HomeRegion { get; set; }

        [Option(HelpText = "The team code.")]
        public string TeamCode { get; set; }

        [Option(HelpText = "The team name.")]
        public string TeamName { get; set; }

        [Option(HelpText = "The team type.")]
        public string TeamType { get; set; }

        [Option(HelpText = "The team sort.")]
        public int TeamSort { get; set; }

        [Option(HelpText = "The team member type.")]
        public string TeamMemberType { get; set; }

        [Option(HelpText = "The team member sort.")]
        public int TeamMemberSort { get; set; }

        [Option(HelpText = "True to hide the resource.")]
        public bool DoNotShow { get; set; }

        [Option(HelpText = "The service from date")]
        public DateTime? InServiceFrom { get; set; }

        [Option(HelpText = "The service until date")]
        public DateTime? InServiceTill { get; set; }

        [Option(HelpText = "True to enable Exchange integration.")]
        public bool ExchangeIntegrationEnabled { get; set; }

        [Option(HelpText = "The URI.")]
        public string Url1 { get; set; }

        [Option(HelpText = "The URI description.")]
        public string UrlDescription1 { get; set; }

        [Option(HelpText = "The URI.")]
        public string Url2 { get; set; }

        [Option(HelpText = "The URI description.")]
        public string UrlDescription2 { get; set; }

        [Option(HelpText = "The URI.")]
        public string Url3 { get; set; }

        [Option(HelpText = "The URI description.")]
        public string UrlDescription3 { get; set; }

        [Option(HelpText = "True to plan in bulk.")]
        public bool BulkPlanning { get; set; }

        [Option(HelpText = "The bulk capacity.")]
        public decimal BulkCapacity { get; set; }

        [Option(HelpText = "True to enable GPS tracking.")]
        public bool ResourceGpsTrackingEnabled { get; set; }

        [Option(HelpText = "The pin's unique identifier.")]
        public string Pin { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText1 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText2 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText3 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText4 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText5 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText6 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText7 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText8 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText9 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText10 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText11 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText12 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText13 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText14 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText15 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText16 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText17 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText18 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText19 { get; set; }

        [Option(HelpText = "A free text field.")]
        public string FreeText20 { get; set; }

        [Option(HelpText = "A free decimal field.")]
        public decimal FreeDecimal1 { get; set; }

        [Option(HelpText = "A free decimal field.")]
        public decimal FreeDecimal2 { get; set; }

        [Option(HelpText = "A free decimal field.")]
        public decimal FreeDecimal3 { get; set; }

        [Option(HelpText = "A free decimal field.")]
        public decimal FreeDecimal4 { get; set; }

        [Option(HelpText = "A free decimal field.")]
        public decimal FreeDecimal5 { get; set; }

        [Option(HelpText = "A free date field.")]
        public DateTime? FreeDate1 { get; set; }

        [Option(HelpText = "A free date field.")]
        public DateTime? FreeDate2 { get; set; }

        [Option(HelpText = "A free date field.")]
        public DateTime? FreeDate3 { get; set; }

        [Option(HelpText = "A free date field.")]
        public DateTime? FreeDate4 { get; set; }

        [Option(HelpText = "A free date field.")]
        public DateTime? FreeDate5 { get; set; }

        [Option(HelpText = "A free boolean field.")]
        public bool FreeBit1 { get; set; }

        [Option(HelpText = "A free boolean field.")]
        public bool FreeBit2 { get; set; }

        [Option(HelpText = "A free boolean field.")]
        public bool FreeBit3 { get; set; }

        [Option(HelpText = "A free boolean field.")]
        public bool FreeBit4 { get; set; }

        [Option(HelpText = "A free boolean field.")]
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