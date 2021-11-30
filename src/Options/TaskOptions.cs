using CommandLine;
using Dime.Scheduler.Sdk.Import;
using System;

namespace Dime.Scheduler.CLI
{
    [Verb("task", HelpText = "Add or remove a task.")]
    public class TaskOptions : BaseOptions, IImportConvertable
    {
        [Option(Required = true)]
        public string SourceApp { get; set; }

        [Option(Required = true)]
        public string SourceType { get; set; }

        [Option(Required = true)]
        public string JobNo { get; set; }

        [Option(Required = true)]
        public string TaskNo { get; set; }

        [Option]
        public TaskType TaskType { get; set; }

        [Option(Required = true)]
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

        public IImportRequestable ToImport() => (Sdk.Import.Task)this;

        public static implicit operator Sdk.Import.Task(TaskOptions options)
          => new()
          {
              ActualEndDate = options.ActualEndDate,
              ActualResponseDateTime = options.ActualResponseDateTime,
              ActualStartDate = options.ActualStartDate,
              AppointmentEarliestAllowed = options.AppointmentEarliestAllowed,
              AppointmentLatestAllowed = options.AppointmentLatestAllowed,
              AppointmentTemplate = options.AppointmentTemplate,
              BaseLineEndDate = options.BaseLineEndDate,
              BaseLinePercentDone = options.BaseLinePercentDone,
              BaseLineStartDate = options.BaseLineStartDate,
              Body = options.Body,
              BulkPlanningQty = options.BulkPlanningQty,
              CalendarCode = options.CalendarCode,
              Category = options.Category,
              CertificateNo = options.CertificateNo,
              CheckAppointments = options.CheckAppointments,
              ConfirmedEndDate = options.ConfirmedEndDate,
              ConfirmedStartDate = options.ConfirmedStartDate,
              ConstraintDatetime = options.ConstraintDatetime,
              ConstraintType = options.ConstraintType,
              ContainerIndex = options.ContainerIndex,
              ContainerName = options.ContainerName,
              ContractDescription = options.ContractDescription,
              ContractEndDate = options.ContractEndDate,
              ContractNo = options.ContractNo,
              ContractStartDate = options.ContractStartDate,
              ContractType = options.ContractType,
              DeadLine = options.DeadLine,
              Description = options.Description,
              DoNotCountAppointmentResource = options.DoNotCountAppointmentResource,
              Duration = options.Duration,
              DurationInSeconds = options.DurationInSeconds,
              EndDate = options.EndDate,
              ExpectedResponseDateTime = options.ExpectedResponseDateTime,
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
              IgnoreCalendars = options.IgnoreCalendars,
              Importance = options.Importance,
              Index = options.Index,
              InfiniteTask = options.InfiniteTask,
              IrisArea = options.IrisArea,
              IrisFault = options.IrisFault,
              IrisReason = options.IrisReason,
              IrisResolution = options.IrisResolution,
              IrisSymptom = options.IrisSymptom,
              IsComplete = options.IsComplete,
              JobNo = options.JobNo,
              LaborWarrantyEndDate = options.LaborWarrantyEndDate,
              LaborWarrantyStartDate = options.LaborWarrantyStartDate,
              LocationDescription = options.LocationDescription,
              ManuallyScheduled = options.ManuallyScheduled,
              Name = options.Name,
              Note = options.Note,
              OverRuleGanttPlanning = options.OverRuleGanttPlanning,
              ParentTaskNo = options.ParentTaskNo,
              PartsWarrantyEndDate = options.PartsWarrantyEndDate,
              PartsWarrantyStartDate = options.PartsWarrantyStartDate,
              PercentDone = options.PercentDone,
              Pin = options.Pin,
              PlanningQty = options.PlanningQty,
              PlanningUOM = options.PlanningUOM,
              PlanningUOMConversion = options.PlanningUOMConversion,
              PredecessorLag = options.PredecessorLag,
              PredecessorTaskNo = options.PredecessorTaskNo,
              RequestedEndDate = options.RequestedEndDate,
              RequestedEndTime = options.RequestedEndTime,
              RequestedStartDate = options.RequestedStartDate,
              RequestedStartTime = options.RequestedStartTime,
              RequiredNoResources = options.RequiredNoResources,
              RequiredTotalDuration = options.RequiredTotalDuration,
              RequiredTotalDurationInSeconds = options.RequiredTotalDurationInSeconds,
              RoundToUOM = options.RoundToUOM,
              SchedulingMode = options.SchedulingMode,
              SentFromBackOffice = options.SentFromBackOffice,
              ServiceClass = options.ServiceClass,
              ServiceGroup = options.ServiceGroup,
              ServiceName = options.ServiceName,
              ServiceNo = options.ServiceNo,
              ServiceSerialNo = options.ServiceSerialNo,
              ShortDescription = options.ShortDescription,
              Skill1 = options.Skill1,
              Skill2 = options.Skill2,
              Skill3 = options.Skill3,
              SourceApp = options.SourceApp,
              SourceType = options.SourceType,
              StartDate = options.StartDate,
              Status = options.Status,
              Subject = options.Subject,
              TaskNo = options.TaskNo,
              TaskOpenAsOf = options.TaskOpenAsOf,
              TaskOpenTill = options.TaskOpenTill,
              TaskType = options.TaskType,
              TimeMarker = options.TimeMarker,
              Type = options.Type,
              Url1 = options.Url1,
              Url2 = options.Url2,
              Url3 = options.Url3,
              UrlDescription1 = options.UrlDescription1,
              UrlDescription2 = options.UrlDescription2,
              UrlDescription3 = options.UrlDescription3,
              UseFixPlanningQty = options.UseFixPlanningQty
          };
    }
}