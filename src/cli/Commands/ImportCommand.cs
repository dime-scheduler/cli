using System;
using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk;
using Dime.Scheduler.Sdk.Import;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public abstract class ImportCommand<TOptions, TImportable>
        where TOptions : BaseOptions, IImportConvertable
        where TImportable : class, IImportRequestable
    {
        protected abstract string WriteIntro(TOptions options);

        public virtual async Task ProcessAsync(TOptions options)
        {
            try
            {
                Console.WriteLine(WriteIntro(options));

                DimeSchedulerClient client = new(options);
                ImportSet result = await client.Import.ProcessAsync(options.ToImport(), options.Append ? TransactionType.Append : TransactionType.Delete);

                Console.WriteLine(result.Success ? "Completed successfully" : "Did not complete successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}