using System;
using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class TransientMessageCommand : ICommand<TransientMessageOptions>
    {
        public async Task ProcessAsync(TransientMessageOptions options)
        {
            try
            {
                Console.WriteLine("Adding transient message");

                DimeSchedulerClient client = new(options.Environment.GetDescription(), options.Key);
                await client.Messages.PostAsync(new Message(options.Text, options.To, options.Severity));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}