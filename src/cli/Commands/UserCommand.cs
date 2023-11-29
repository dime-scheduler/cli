using System;
using Dime.Scheduler.CLI.Options;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler.CLI.Commands
{
    public class UserCommand : ICommand<UserOptions>
    {
        public async Task ProcessAsync(UserOptions options)
        {
            try
            {
                Console.WriteLine($"Adding user with e-mail {options.Email}");

                DimeSchedulerClient client = new(options.Environment.GetDescription(), options.Key);
                await client.Users.CreateAsync(new(options.Email, options.Type, options.Email, options.Password, options.Language, options.TimeZone));

                Console.WriteLine("Finished successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}