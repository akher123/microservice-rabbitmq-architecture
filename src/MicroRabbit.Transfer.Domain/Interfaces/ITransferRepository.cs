using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        Task<IEnumerable<TransferLog>> GetTransferLogsAsync();
        Task AddTransferLogAsync(TransferLog transferLog);
    }
}
