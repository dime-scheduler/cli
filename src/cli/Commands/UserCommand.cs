using System;
using Dime.Scheduler.CLI.Options;
using Dime.Scheduler.Sdk;
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

                await client.Users.CreateAsync(new()
                {
                    Email = options.Email,
                    Password = options.Password,
                    Language = options.Language,
                    TimeZone = options.TimeZone,
                    Type = options.Type
                });

                Console.WriteLine("Finished successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}