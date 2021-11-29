using CommandLine;
using Dime.Scheduler.Sdk.Import;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addTask", HelpText = "Adds a task.")]
    public class AddTaskOptions : BaseOptions
    {
        public string SourceApp { get; set; }

        public string SourceType { get; set; }

        public string JobNo { get; set; }

        public string TaskNo { get; set; }

        public TaskType TaskType { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Category { get; set; }

        public string TimeMarker { get; set; }

        public string Pin { get; set; }

        public string ServiceNo { get; set; }

        public string ServiceGroup { get; set; }

        public string ServiceClass { get; set; }

        public string ServiceSerialNo { get; set; }

        public string ServiceName { get; set; }

        public string IrisFault { get; set; }

        public string IrisSymptom { get; set; }

        public string IrisArea { get; set; }

        public string IrisReason { get; set; }

        public string IrisResolution { get; set; }

        public string Skill1 { get; set; }

        public string Skill2 { get; set; }

        public string Skill3 { get; set; }

        public string ContractNo { get; set; }

        public string ContractType { get; set; }

        public string ContractDescription { get; set; }

        public DateTime? ContractStartDate { get; set; }

        public DateTime? ContractEndDate { get; set; }

        public DateTime? PartsWarrantyStartDate { get; set; }

        public DateTime? PartsWarrantyEndDate { get; set; }

        public DateTime? LaborWarrantyStartDate { get; set; }

        public DateTime? LaborWarrantyEndDate { get; set; }

        public Importance Importance { get; set; }

        public string Status { get; set; }

        public DateTime? ExpectedResponseDateTime { get; set; }

        public DateTime? ActualResponseDateTime { get; set; }

        public DateTime? RequestedStartDate { get; set; }

        public DateTime? RequestedEndDate { get; set; }

        public TimeSpan? RequestedStartTime { get; set; }

        public TimeSpan? RequestedEndTime { get; set; }

        public DateTime? ConfirmedStartDate { get; set; }

        public DateTime? ConfirmedEndDate { get; set; }

        public DateTime? ActualStartDate { get; set; }

        public DateTime? ActualEndDate { get; set; }

        public string LocationDescription { get; set; }

        public TimeSpan? Duration { get; set; }

        public long DurationInSeconds { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool InfiniteTask { get; set; }

        public DateTime? TaskOpenAsOf { get; set; }

        public DateTime? TaskOpenTill { get; set; }

        public TimeSpan? RequiredTotalDuration { get; set; }

        public int RequiredNoResources { get; set; }

        public DateTime? AppointmentEarliestAllowed { get; set; }

        public DateTime? AppointmentLatestAllowed { get; set; }

        public string FreeText1 { get; set; }

        public string FreeText2 { get; set; }

        public string FreeText3 { get; set; }

        public string FreeText4 { get; set; }

        public string FreeText5 { get; set; }

        public string FreeText6 { get; set; }

        public string FreeText7 { get; set; }

        public string FreeText8 { get; set; }

        public string FreeText9 { get; set; }

        public string FreeText10 { get; set; }

        public string FreeText11 { get; set; }

        public string FreeText12 { get; set; }

        public string FreeText13 { get; set; }

        public string FreeText14 { get; set; }

        public string FreeText15 { get; set; }

        public string FreeText16 { get; set; }

        public string FreeText17 { get; set; }

        public string FreeText18 { get; set; }

        public string FreeText19 { get; set; }

        public string FreeText20 { get; set; }

        public decimal FreeDecimal1 { get; set; }

        public decimal FreeDecimal2 { get; set; }

        public decimal FreeDecimal3 { get; set; }

        public decimal FreeDecimal4 { get; set; }

        public decimal FreeDecimal5 { get; set; }

        public DateTime? FreeDate1 { get; set; }

        public DateTime? FreeDate2 { get; set; }

        public DateTime? FreeDate3 { get; set; }

        public DateTime? FreeDate4 { get; set; }

        public DateTime? FreeDate5 { get; set; }

        public bool FreeBit1 { get; set; }

        public bool FreeBit2 { get; set; }

        public bool FreeBit3 { get; set; }

        public bool FreeBit4 { get; set; }

        public bool FreeBit5 { get; set; }

        public string Url1 { get; set; }

        public string UrlDescription1 { get; set; }

        public string Url2 { get; set; }

        public string UrlDescription2 { get; set; }

        public string Url3 { get; set; }

        public string UrlDescription3 { get; set; }

        public string CertificateNo { get; set; }

        public long RequiredTotalDurationInSeconds { get; set; }

        public bool DoNotCountAppointmentResource { get; set; }

        public bool IsComplete { get; set; }

        public string PlanningUOM { get; set; }

        public decimal PlanningUOMConversion { get; set; }

        public decimal PlanningQty { get; set; }

        public bool UseFixPlanningQty { get; set; }

        public bool RoundToUOM { get; set; }

        public string AppointmentTemplate { get; set; }

        public decimal BulkPlanningQty { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int PercentDone { get; set; }

        public SchedulingMode SchedulingMode { get; set; }

        public DateTime? BaseLineStartDate { get; set; }

        public DateTime? BaseLineEndDate { get; set; }

        public int BaseLinePercentDone { get; set; }

        public DateTime? DeadLine { get; set; }

        public int Index { get; set; }

        public int ConstraintType { get; set; }

        public DateTime? ConstraintDatetime { get; set; }

        public string ParentTaskNo { get; set; }

        public string CalendarCode { get; set; }

        public string PredecessorTaskNo { get; set; }

        public int PredecessorLag { get; set; }

        public bool ManuallyScheduled { get; set; }

        public string Note { get; set; }

        public bool OverRuleGanttPlanning { get; set; }

        public bool IgnoreCalendars { get; set; }

        public string ContainerName { get; set; }

        public int ContainerIndex { get; set; }

        public bool CheckAppointments { get; set; }

        public bool SentFromBackOffice { get; set; } = true;
    }
}