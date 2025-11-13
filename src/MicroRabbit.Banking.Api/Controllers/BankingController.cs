using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route(MicroserviceRoutePrefix.Bankings)]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService accountService;
        public BankingController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpGet("get-accounts")]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccounts()
        {
            return Ok(await accountService.GetAccountsAsync());
        }

        [HttpPost("save-account-transfer")]
        public ActionResult SaveAccountTransfer([FromBody] AccountTransfer accountTransfer)
        {
            accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}