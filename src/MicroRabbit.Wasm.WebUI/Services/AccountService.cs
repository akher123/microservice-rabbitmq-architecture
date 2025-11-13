namespace MicroRabbit.Wasm.WebUI.Services
{
    using MicroRabbit.Wasm.WebUI.Models;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;

    public class AccountService: IAccountService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AccountService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<AccountTransferModel> SaveAccountTransferAsync(AccountTransferModel accuntTransfer)
        {
            var _httpClient = _httpClientFactory.CreateClient("banking-microservice");
            var response = await _httpClient.PostAsJsonAsync("api/microservice/bankings/save-account-transfer", accuntTransfer);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<AccountTransferModel>();
        }

        public async Task<IEnumerable<AccountModel>> GetAccountsAsync()
        {
            var _httpClient = _httpClientFactory.CreateClient("banking-microservice");
            return await _httpClient.GetFromJsonAsync<IEnumerable<AccountModel>>("api/microservice/bankings/get-accounts");
        }
    }

}
