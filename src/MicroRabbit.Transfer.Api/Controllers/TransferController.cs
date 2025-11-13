
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route(MicroserviceRoutePrefix.Transfers)]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet("get-transfer-logs")]
        public async Task<IActionResult> GetTransferLogsAsync()
        {
            var transferLogs = await _transferService.GetTransferLogsAsync();
            return Ok(transferLogs);
        }

    }
    
}