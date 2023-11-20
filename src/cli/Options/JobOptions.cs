using System;
using CommandLine;
using Dime.Scheduler.Sdk.Models;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("job", HelpText = "Add or remove a job.")]
    public class JobOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true, HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(Required = true, HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(Required = true, HelpText = "The unique job number.")]
        public string JobNo { get; set; }

        [Option(Required = false, HelpText = "A short text describing the job.")]
        public string ShortDescription { get; set; }

        [Option(HelpText = "A longer text to describe the job.")]
        public string Description { get; set; }

        [Option(HelpText = "The type of job.")]
        public string Type { get; set; }

        [Option(HelpText = "The job name.")]
        public string Name { get; set; }

        [Option(HelpText = "The job's category.")]
        public string Category { get; set; }

        [Option(HelpText = "The job's time marker.")]
        public string TimeMarker { get; set; }

        [Option(HelpText = "The job's name.")]
        public string Pin { get; set; }

        [Option(HelpText = "The customer's unique number.")]
        public string CustomerNo { get; set; }

        [Option(HelpText = "The customer name.")]
        public string CustomerName { get; set; }

        [Option(HelpText = "The customer's address.")]
        public string CustomerAddress { get; set; }

        [Option(HelpText = "The customer's longitude.")]
        public decimal? CustomerAddressGeoLong { get; set; }

        [Option(HelpText = "The customer's latitude.")]
        public decimal? CustomerAddressGeoLat { get; set; }

        [Option(HelpText = "The customer's phone number.")]
        public string CustomerPhone { get; set; }

        [Option(HelpText = "The customer's email.")]
        public string CustomerEmail { get; set; }

        [Option(HelpText = "The job's contact number.")]
        public string ContactNo { get; set; }

        [Option(HelpText = "The job's contact name.")]
        public string ContactName { get; set; }

        [Option(HelpText = "The job's contact address.")]
        public string ContactAddress { get; set; }

        [Option(HelpText = "The job's contact address longitude.")]
        public decimal? ContactAddressGeoLong { get; set; }

        [Option(HelpText = "The job's contact address latitude.")]
        public decimal? ContactAddressGeoLat { get; set; }

        [Option(HelpText = "The job's contact phone number.")]
        public string ContactPhone { get; set; }

        [Option(HelpText = "The job's contact email.")]
        public string ContactEmail { get; set; }

        [Option(HelpText = "The job site number.")]
        public string SiteNo { get; set; }

        [Option(HelpText = "The job site name.")]
        public string SiteName { get; set; }

        [Option(HelpText = "The job site address.")]
        public string SiteAddress { get; set; }

        [Option(HelpText = "The job site address longitude.")]
        public decimal? SiteAddressGeoLong { get; set; }

        [Option(HelpText = "The job site address latitude.")]
        public decimal? SiteAddressGeoLat { get; set; }

        [Option(HelpText = "The job site phone.")]
        public string SitePhone { get; set; }

        [Option(HelpText = "The job site email.")]
        public string SiteEmail { get; set; }

        [Option(HelpText = "The job site region.")]
        public string SiteRegion { get; set; }

        [Option(HelpText = "The job site street.")]
        public string SiteStreet { get; set; }

        [Option(HelpText = "The job site street number.")]
        public string SiteStreetNo { get; set; }

        [Option(HelpText = "The job site zip code.")]
        public string SitePostcode { get; set; }

        [Option(HelpText = "The job site city.")]
        public string SiteCity { get; set; }

        [Option(HelpText = "The job site county.")]
        public string SiteCounty { get; set; }

        [Option(HelpText = "The job site state.")]
        public string SiteState { get; set; }

        [Option(HelpText = "The job site country.")]
        public string SiteCountry { get; set; }

        [Option(HelpText = "The job site from unique number.")]
        public string SiteFromNo { get; set; }

        [Option(HelpText = "The job site from name.")]
        public string SiteFromName { get; set; }

        [Option(HelpText = "The job site from address.")]
        public string SiteFromAddress { get; set; }

        [Option(HelpText = "The job site from address longitude.")]
        public decimal? SiteFromAddressGeoLong { get; set; }

        [Option(HelpText = "The job site from address latitude.")]
        public decimal? SiteFromAddressGeoLat { get; set; }

        [Option(HelpText = "The job site from phone number.")]
        public string SiteFromPhone { get; set; }

        [Option(HelpText = "The job site from email.")]
        public string SiteFromEmail { get; set; }

        [Option(HelpText = "The job site from region.")]
        public string SiteFromRegion { get; set; }

        [Option(HelpText = "The job site from street.")]
        public string SiteFromStreet { get; set; }

        [Option(HelpText = "The job site from street number.")]
        public string SiteFromStreetNo { get; set; }

        [Option(HelpText = "The job site from post code.")]
        public string SiteFromPostcode { get; set; }

        [Option(HelpText = "The job site from city.")]
        public string SiteFromCity { get; set; }

        [Option(HelpText = "The job site from county.")]
        public string SiteFromCounty { get; set; }

        [Option(HelpText = "The job site from state.")]
        public string SiteFromState { get; set; }

        [Option(HelpText = "The job site from country.")]
        public string SiteFromCountry { get; set; }

        [Option(HelpText = "The unique bill number.")]
        public string BillNo { get; set; }

        [Option(HelpText = "The unique bill name.")]
        public string BillName { get; set; }

        [Option(HelpText = "The bill address.")]
        public string BillAddress { get; set; }

        [Option(HelpText = "The bill address longitude.")]
        public decimal? BillAddressGeoLong { get; set; }

        [Option(HelpText = "The bill address latitude.")]
        public decimal? BillAddressGeoLat { get; set; }

        [Option(HelpText = "The bill address phone.")]
        public string BillPhone { get; set; }

        [Option(HelpText = "The bill address email.")]
        public string BillEmail { get; set; }

        [Option(HelpText = "The bill address region.")]
        public string BillRegion { get; set; }

        [Option(HelpText = "The job's importance.")]
        public Importance Importance { get; set; }

        [Option(HelpText = "The job's creation date")]
        public DateTime? CreationDateTime { get; set; }

        [Option(HelpText = "The job's customer reference.")]
        public string CustomerReference { get; set; }

        [Option(HelpText = "The language.")]
        public string Language { get; set; }

        [Option(HelpText = "The job's responsible.")]
        public string Responsible { get; set; }

        [Option(HelpText = "The creator.")]
        public string Creator { get; set; }

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

        [Option(HelpText = "True to enable manual selection.")]
        public bool EnableManualSelection { get; set; }

        [Option(HelpText = "True to make it available in the Gantt chart.")]
        public bool AvailableInGantt { get; set; }

        [Option(HelpText = "The project's start date.")]
        public DateTime? StartDate { get; set; }

        [Option(HelpText = "The project's end date.")]
        public DateTime? EndDate { get; set; }

        [Option(HelpText = "True to allow dependencies.")]
        public bool AllowDependencies { get; set; } = true;

        [Option(HelpText = "The project's notes.")]
        public string Note { get; set; }

        [Option(HelpText = "True to allow the planning to be overridden.")]
        public bool OverRuleGanttPlanning { get; set; }

        [Option(HelpText = "True to check appointments.")]
        public bool CheckAppointments { get; set; }

        [Option(HelpText = "True to indicate whether the record is sent from the back office.")]
        public bool SentFromBackOffice { get; set; } = true;

        public IImportRequestable ToImport() => (Job)this;

        public static implicit operator Job(JobOptions options)
          => new()
          {
              SourceApp = options.SourceApp,
              SourceType = options.SourceType,
              JobNo = options.JobNo,
              ShortDescription = !string.IsNullOrEmpty(options.ShortDescription) ? options.ShortDescription : options.Description?[0..Math.Min(options.Description.Length, 50)],
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