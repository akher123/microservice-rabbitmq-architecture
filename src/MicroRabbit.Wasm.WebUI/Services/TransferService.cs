using MicroRabbit.Wasm.WebUI.Models;
using System.Net.Http.Json;
using System.Net.Http;

namespace MicroRabbit.Wasm.WebUI.Services
{
    public class TransferService : ITransferService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public TransferService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<TransferLogModel>> GetTransferLogsAsync()
        {
            var _httpClient = _httpClientFactory.CreateClient("transfer-microservice");
            return await _httpClient.GetFromJsonAsync<IEnumerable<TransferLogModel>>("api/microservice/transfer/get-transfer-logs");
        }
    }
}
