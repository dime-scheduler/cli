using System;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class AddAppointmentCommand : ICommand<AddAppointmentOptions>
    {
        public async Task ProcessAsync(AddAppointmentOptions options)
        {
            try
            {
                Console.WriteLine($"Adding appointment for resource {options.ResourceNo} between {options.Start} and {options.End}");

                IAuthenticator authenticator = new FormsAuthenticator(options.Uri, options.User, options.Password);
                DimeSchedulerClient client = new(options.Uri, authenticator);

                IImportEndpoint importEndpoint = await client.Import.Request();
                Appointment appointment = new()
                {
                    ResourceNo = options.ResourceNo,
                    Start = options.Start,
                    End = options.End,
                    SourceApp = options.SourceApp,
                    SourceType = options.SourceType,
                    TaskNo = options.TaskNo,
                    JobNo = options.JobNo,
                    Subject = options.Subject,
                    Body = options.Body,
                    Category = options.Category,
                    TimeMarker =  options.TimeMarker,
                    Importance =  options.Importance,
                    Locked =  options.Locked,
                    SentFromBackOffice =  options.SentFromBackOffice,
                    //PlanningQuantity =  options.PlanningQuantity,
                    UnitOfMeasure =  options.UnitOfMeasure,
                    UnitOfMeasureConversion = options.UnitOfMeasureConversion,
                    RoundToUnitOfMeasure =  options.RoundToUnitOfMeasure,
                    //UseFixedPlanningQuantity =  options.UseFixedPlanningQuantity
                };

                ImportSet result = await importEndpoint.ProcessAsync(appointment, TransactionType.Append);
                Console.WriteLine(result.Success ? "Finished successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}