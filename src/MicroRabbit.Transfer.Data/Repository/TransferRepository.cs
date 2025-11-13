using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository: ITransferRepository
    {

        private readonly TransferDbContext _dbContext;
        public TransferRepository(TransferDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Task AddTransferLogAsync(TransferLog transferLog)
        {
           this._dbContext.TransferLogs.Add(transferLog);
           return this._dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TransferLog>> GetTransferLogsAsync()
        {
           return await _dbContext.TransferLogs.ToListAsync();
        }
    }
}
