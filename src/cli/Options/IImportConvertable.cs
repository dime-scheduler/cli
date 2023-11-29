using Dime.Scheduler.Entities;

namespace Dime.Scheduler.CLI.Options
{
    public interface IImportConvertable
    {
        IImportRequestable ToImport();
    }
}