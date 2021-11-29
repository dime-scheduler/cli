using CommandLine;
using Dime.Scheduler.Sdk.Import;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("addTask", HelpText = "Adds a task.")]
    public class AddTaskOptions : BaseOptions
    {
        [Option]
        public string SourceApp { get; set; }

        [Option]
        public string SourceType { get; set; }

        [Option]
        public string JobNo { get; set; }

        [Option]
        public string TaskNo { get; set; }

        [Option]
        public TaskType TaskType { get; set; }

        [Option]
        public string ShortDescription { get; set; }

        [Option]
        public string Description { get; set; }

        [Option]
        public string Name { get; set; }

        [Option]
        public string Type { get; set; }

        [Option]
        public string Category { get; set; }

        [Option]
        public string TimeMarker { get; set; }

        [Option]
        public string Pin { get; set; }

        [Option]
        public string ServiceNo { get; set; }

        [Option]
        public string ServiceGroup { get; set; }

        [Option]
        public string ServiceClass { get; set; }

        [Option]
        public string ServiceSerialNo { get; set; }

        [Option]
        public string ServiceName { get; set; }

        [Option]
        public string IrisFault { get; set; }

        [Option]
        public string IrisSymptom { get; set; }

        [Option]
        public string IrisArea { get; set; }

        [Option]
        public string IrisReason { get; set; }

        [Option]
        public string IrisResolution { get; set; }

        [Option]
        public string Skill1 { get; set; }

        [Option]
        public string Skill2 { get; set; }

        [Option]
        public string Skill3 { get; set; }

        [Option]
        public string ContractNo { get; set; }

        [Option]
        public string ContractType { get; set; }

        [Option]
        public string ContractDescription { get; set; }

        [Option]
        public DateTime? ContractStartDate { get; set; }

        [Option]
        public DateTime? ContractEndDate { get; set; }

        [Option]
        public DateTime? PartsWarrantyStartDate { get; set; }

        [Option]
        public DateTime? PartsWarrantyEndDate { get; set; }

        [Option]
        public DateTime? LaborWarrantyStartDate { get; set; }

        [Option]
        public DateTime? LaborWarrantyEndDate { get; set; }

        [Option]
        public Importance Importance { get; set; }

        [Option]
        public string Status { get; set; }

        [Option]
        public DateTime? ExpectedResponseDateTime { get; set; }

        [Option]
        public DateTime? ActualResponseDateTime { get; set; }

        [Option]
        public DateTime? RequestedStartDate { get; set; }

        [Option]
        public DateTime? RequestedEndDate { get; set; }

        [Option]
        public TimeSpan? RequestedStartTime { get; set; }

        [Option]
        public TimeSpan? RequestedEndTime { get; set; }

        [Option]
        public DateTime? ConfirmedStartDate { get; set; }

        [Option]
        public DateTime? ConfirmedEndDate { get; set; }

        [Option]
        public DateTime? ActualStartDate { get; set; }

        [Option]
        public DateTime? ActualEndDate { get; set; }

        [Option]
        public string LocationDescription { get; set; }

        [Option]
        public TimeSpan? Duration { get; set; }

        [Option]
        public long DurationInSeconds { get; set; }

        [Option]
        public string Subject { get; set; }

        [Option]
        public string Body { get; set; }

        [Option]
        public bool InfiniteTask { get; set; }

        [Option]
        public DateTime? TaskOpenAsOf { get; set; }

        [Option]
        public DateTime? TaskOpenTill { get; set; }

        [Option]
        public TimeSpan? RequiredTotalDuration { get; set; }

        [Option]
        public int RequiredNoResources { get; set; }

        [Option]
        public DateTime? AppointmentEarliestAllowed { get; set; }

        [Option]
        public DateTime? AppointmentLatestAllowed { get; set; }

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
        public string CertificateNo { get; set; }

        [Option]
        public long RequiredTotalDurationInSeconds { get; set; }

        [Option]
        public bool DoNotCountAppointmentResource { get; set; }

        [Option]
        public bool IsComplete { get; set; }

        [Option]
        public string PlanningUOM { get; set; }

        [Option]
        public decimal PlanningUOMConversion { get; set; }

        [Option]
        public decimal PlanningQty { get; set; }

        [Option]
        public bool UseFixPlanningQty { get; set; }

        [Option]
        public bool RoundToUOM { get; set; }

        [Option]
        public string AppointmentTemplate { get; set; }

        [Option]
        public decimal BulkPlanningQty { get; set; }

        [Option]
        public DateTime? StartDate { get; set; }

        [Option]
        public DateTime? EndDate { get; set; }

        [Option]
        public int PercentDone { get; set; }

        [Option]
        public SchedulingMode SchedulingMode { get; set; }

        [Option]
        public DateTime? BaseLineStartDate { get; set; }

        [Option]
        public DateTime? BaseLineEndDate { get; set; }

        [Option]
        public int BaseLinePercentDone { get; set; }

        [Option]
        public DateTime? DeadLine { get; set; }

        [Option]
        public int Index { get; set; }

        [Option]
        public int ConstraintType { get; set; }

        [Option]
        public DateTime? ConstraintDatetime { get; set; }

        [Option]
        public string ParentTaskNo { get; set; }

        [Option]
        public string CalendarCode { get; set; }

        [Option]
        public string PredecessorTaskNo { get; set; }

        [Option]
        public int PredecessorLag { get; set; }

        [Option]
        public bool ManuallyScheduled { get; set; }

        [Option]
        public string Note { get; set; }

        [Option]
        public bool OverRuleGanttPlanning { get; set; }

        [Option]
        public bool IgnoreCalendars { get; set; }

        [Option]
        public string ContainerName { get; set; }

        [Option]
        public int ContainerIndex { get; set; }

        [Option]
        public bool CheckAppointments { get; set; }

        [Option]
        public bool SentFromBackOffice { get; set; } = true;
    }
}