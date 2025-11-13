using MicroRabbit.Wasm.WebUI.Models;

namespace MicroRabbit.Wasm.WebUI.Services
{
    public interface ITransferService
    {
        Task<IEnumerable<TransferLogModel>> GetTransferLogsAsync();

    }
}
