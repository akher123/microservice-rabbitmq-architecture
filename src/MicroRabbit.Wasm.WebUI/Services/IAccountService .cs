using MicroRabbit.Wasm.WebUI.Models;
using System.Net.Http;

namespace MicroRabbit.Wasm.WebUI.Services
{
    public interface IAccountService
    {
         Task<AccountTransferModel> SaveAccountTransferAsync(AccountTransferModel account);
         Task<IEnumerable<AccountModel>> GetAccountsAsync();
       
    }
}
