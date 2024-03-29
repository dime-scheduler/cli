﻿using System;
using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Entities;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public abstract class Command<TOptions, TImportable>
        where TOptions : BaseOptions, IImportConvertable
        where TImportable : class, IImportRequestable
    {
        protected abstract string WriteIntro(TOptions options);

        public virtual async Task ProcessAsync(TOptions options)
        {
            try
            {
                Console.WriteLine(WriteIntro(options));

                DimeSchedulerClient client = new(options.Key, options.Environment.GetDescription());

                CrudAction action = options.Action.GetValueFromDescription<CrudAction>();
                ImportSet result = await client.Import.ProcessAsync(options.ToImport(), action != CrudAction.Delete ? TransactionType.Append : TransactionType.Delete);

                Console.WriteLine(result.Success ? "Completed successfully" : "Request failed: " + result.Message);
            }
            catch (ArgumentException argException)
            {
                Console.WriteLine("Action for this type was not recognized. Supported actions: add, update, delete");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}