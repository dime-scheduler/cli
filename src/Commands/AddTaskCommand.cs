using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddTaskCommand : ICommand<AddTaskOptions>
    {
        public async t.Task ProcessAsync(AddTaskOptions options)
        {
            try
            {
                Console.WriteLine($"Adding task for job {options.JobNo} with number {options.TaskNo}.");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();

                Task task = new()
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

                ImportSet result = await importEndpoint.ProcessAsync(task, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}