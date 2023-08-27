using System;
using System.Linq;
using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.CLI.Commands
{
    public class TaskCommand :
        ImportCommand<TaskOptions, Task>,
        ICommand<TaskOptions>
    {
        public override async System.Threading.Tasks.Task ProcessAsync(TaskOptions options)
        {
            try
            {
                Console.WriteLine(WriteIntro(options));

                DimeSchedulerClient client = new(options);

                if (options.CreateJob)
                {
                    await client.Jobs.Create(new Job()
                    {
                        SourceApp = options.SourceApp,
                        SourceType = options.SourceType,
                        ShortDescription = !string.IsNullOrEmpty(options.ShortDescription) ? options.ShortDescription : options.Description?[0..Math.Min(options.Description.Length, 50)],
                        Description = options.Description,
                        JobNo = options.JobNo
                    });
                }

                _ = Enum.TryParse(options.Action, out CrudAction action);
                ImportSet result = await client.Import.ProcessAsync(options.ToImport(), action != CrudAction.Delete ? TransactionType.Append : TransactionType.Delete);
                Console.WriteLine(result.Success ? "Completed successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected override string WriteIntro(TaskOptions options)
            => $"Adding task for job {options.JobNo} with number {options.TaskNo}.";
    }
}