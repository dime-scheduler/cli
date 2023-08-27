using System;
using CommandLine;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Options
{
    [Verb("task", HelpText = "Add or remove a task.")]
    public class TaskOptions : BaseOptions, IImportConvertable
    {
        [Option(HelpText = "Set to true to create a job for this task")]
        public bool CreateJob { get; set; }

        [Option(Required = true, HelpText = "The source app.")]
        public string SourceApp { get; set; }

        [Option(Required = true, HelpText = "The source type.")]
        public string SourceType { get; set; }

        [Option(Required = true, HelpText = "The job's unique identifier.")]
        public string JobNo { get; set; }

        [Option(Required = true, HelpText = "The task's unique identifier.")]
        public string TaskNo { get; set; }

        [Option(HelpText = "The task type.")]
        public TaskType TaskType { get; set; }

        [Option(HelpText = "A short text describing the task.")]
        public string ShortDescription { get; set; }

        [Option(HelpText = "A longer text to describe the task")]
        public string Description { get; set; }

        [Option(HelpText = "The name;")]
        public string Name { get; set; }

        [Option(HelpText = "The type.")]
        public string Type { get; set; }

        [Option(HelpText = "The category.")]
        public string Category { get; set; }

        [Option(HelpText = "The time marker.")]
        public string TimeMarker { get; set; }

        [Option(HelpText = "The pin.")]
        public string Pin { get; set; }

        [Option(HelpText = "The service number.")]
        public string ServiceNo { get; set; }

        [Option(HelpText = "The service group.")]
        public string ServiceGroup { get; set; }

        [Option(HelpText = "The service class.")]
        public string ServiceClass { get; set; }

        [Option(HelpText = "The service serial number.")]
        public string ServiceSerialNo { get; set; }

        [Option(HelpText = "The service name.")]
        public string ServiceName { get; set; }

        [Option(HelpText = "The IRIS fault.")]
        public string IrisFault { get; set; }

        [Option(HelpText = "The IRIS symptom.")]
        public string IrisSymptom { get; set; }

        [Option(HelpText = "The IRIS area.")]
        public string IrisArea { get; set; }

        [Option(HelpText = "The IRIS reason.")]
        public string IrisReason { get; set; }

        [Option(HelpText = "The IRIS resolution.")]
        public string IrisResolution { get; set; }

        [Option(HelpText = "Skill.")]
        public string Skill1 { get; set; }

        [Option(HelpText = "Skill.")]
        public string Skill2 { get; set; }

        [Option(HelpText = "Skill.")]
        public string Skill3 { get; set; }

        [Option(HelpText = "The contract number.")]
        public string ContractNo { get; set; }

        [Option(HelpText = "The contract type.")]
        public string ContractType { get; set; }

        [Option(HelpText = "The contract description.")]
        public string ContractDescription { get; set; }

        [Option(HelpText = "The contract start date.")]
        public DateTime? ContractStartDate { get; set; }

        [Option(HelpText = "The contract end date.")]
        public DateTime? ContractEndDate { get; set; }

        [Option(HelpText = "The warranty start date.")]
        public DateTime? PartsWarrantyStartDate { get; set; }

        [Option(HelpText = "The warranty end date.")]
        public DateTime? PartsWarrantyEndDate { get; set; }

        [Option(HelpText = "The labor warranty start date.")]
        public DateTime? LaborWarrantyStartDate { get; set; }

        [Option(HelpText = "The labor warranty end date.")]
        public DateTime? LaborWarrantyEndDate { get; set; }

        [Option(HelpText = "The task's priority.")]
        public Importance Importance { get; set; }

        [Option(HelpText = "The status.")]
        public string Status { get; set; }

        [Option(HelpText = "The expected response date.")]
        public DateTime? ExpectedResponseDateTime { get; set; }

        [Option(HelpText = "The actual response date.")]
        public DateTime? ActualResponseDateTime { get; set; }

        [Option(HelpText = "The requested start date.")]
        public DateTime? RequestedStartDate { get; set; }

        [Option(HelpText = "The requested end date.")]
        public DateTime? RequestedEndDate { get; set; }

        [Option(HelpText = "The requested start time.")]
        public TimeSpan? RequestedStartTime { get; set; }

        [Option(HelpText = "The requested end time.")]
        public TimeSpan? RequestedEndTime { get; set; }

        [Option(HelpText = "The confirmed start date.")]
        public DateTime? ConfirmedStartDate { get; set; }

        [Option(HelpText = "The confirmed end date.")]
        public DateTime? ConfirmedEndDate { get; set; }

        [Option(HelpText = "The actual start date.")]
        public DateTime? ActualStartDate { get; set; }

        [Option(HelpText = "The actual end date.")]
        public DateTime? ActualEndDate { get; set; }

        [Option(HelpText = "The location description.")]
        public string LocationDescription { get; set; }

        [Option(HelpText = "The duration.")]
        public TimeSpan? Duration { get; set; }

        [Option(HelpText = "The duration in seconds.")]
        public long DurationInSeconds { get; set; }

        [Option(HelpText = "The subject.")]
        public string Subject { get; set; }

        [Option(HelpText = "The body.")]
        public string Body { get; set; }

        [Option(HelpText = "True to mark it as an infinite task.")]
        public bool InfiniteTask { get; set; }

        [Option(HelpText = "The minimum date of the task.")]
        public DateTime? TaskOpenAsOf { get; set; }

        [Option(HelpText = "The maximum date of the task.")]
        public DateTime? TaskOpenTill { get; set; }

        [Option(HelpText = "The required total duration.")]
        public TimeSpan? RequiredTotalDuration { get; set; }

        [Option(HelpText = "The required amount of resources.")]
        public int RequiredNoResources { get; set; }

        [Option(HelpText = "The earliest date allowed.")]
        public DateTime? AppointmentEarliestAllowed { get; set; }

        [Option(HelpText = "The latest date allowed.")]
        public DateTime? AppointmentLatestAllowed { get; set; }

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

        [Option(HelpText = "The certificate number.")]
        public string CertificateNo { get; set; }

        [Option(HelpText = "The required total duration in seconds.")]
        public long RequiredTotalDurationInSeconds { get; set; }

        [Option(HelpText = "True to ignore assignments.")]
        public bool DoNotCountAppointmentResource { get; set; }

        [Option(HelpText = "True to mark the task as complete.")]
        public bool IsComplete { get; set; }

        [Option(HelpText = "The planning unit of measure.")]
        public string PlanningUOM { get; set; }

        [Option(HelpText = "The conversion rate.")]
        public decimal PlanningUOMConversion { get; set; }

        [Option(HelpText = "The planning quantity.")]
        public decimal PlanningQty { get; set; }

        [Option(HelpText = "True to use fix planning quantity.")]
        public bool UseFixPlanningQty { get; set; }

        [Option(HelpText = "True to round the unit of measure.")]
        public bool RoundToUOM { get; set; }

        [Option(HelpText = "The appointment template.")]
        public string AppointmentTemplate { get; set; }

        [Option(HelpText = "The bulk planning quantity.")]
        public decimal BulkPlanningQty { get; set; }

        [Option(HelpText = "The start date.")]
        public DateTime? StartDate { get; set; }

        [Option(HelpText = "The end date.")]
        public DateTime? EndDate { get; set; }

        [Option(HelpText = "The percentage of completion.")]
        public int PercentDone { get; set; }

        [Option(HelpText = "The scheduling mode.")]
        public SchedulingMode SchedulingMode { get; set; }

        [Option(HelpText = "The baseline start date.")]
        public DateTime? BaseLineStartDate { get; set; }

        [Option(HelpText = "The baseline end date.")]
        public DateTime? BaseLineEndDate { get; set; }

        [Option(HelpText = "The percentage of completion of the baseline.")]
        public int BaseLinePercentDone { get; set; }

        [Option(HelpText = "The deadline.")]
        public DateTime? DeadLine { get; set; }

        [Option(HelpText = "The index.")]
        public int Index { get; set; }

        [Option(HelpText = "The constraint type.")]
        public int ConstraintType { get; set; }

        [Option(HelpText = "The constraint date time.")]
        public DateTime? ConstraintDatetime { get; set; }

        [Option(HelpText = "The parent task number.")]
        public string ParentTaskNo { get; set; }

        [Option(HelpText = "The calendar code.")]
        public string CalendarCode { get; set; }

        [Option(HelpText = "The predecessor task number.")]
        public string PredecessorTaskNo { get; set; }

        [Option(HelpText = "The lag to the predecessor.")]
        public int PredecessorLag { get; set; }

        [Option(HelpText = "True to schedule the task manually.")]
        public bool ManuallyScheduled { get; set; }

        [Option(HelpText = "The task notes.")]
        public string Note { get; set; }

        [Option(HelpText = "True to overrule.")]
        public bool OverRuleGanttPlanning { get; set; }

        [Option(HelpText = "True to ignore calendars.")]
        public bool IgnoreCalendars { get; set; }

        [Option(HelpText = "The container name.")]
        public string ContainerName { get; set; }

        [Option(HelpText = "The container index.")]
        public int ContainerIndex { get; set; }

        [Option(HelpText = "True to check appointments.")]
        public bool CheckAppointments { get; set; }

        [Option(HelpText = "True to mark the record is sent from the back office.")]
        public bool SentFromBackOffice { get; set; } = true;

        public IImportRequestable ToImport() => (Task)this;

        public static implicit operator Task(TaskOptions options)
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
              ShortDescription = !string.IsNullOrEmpty(options.ShortDescription) ? options.ShortDescription : options.Description?[0..Math.Min(options.Description.Length, 50)],
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