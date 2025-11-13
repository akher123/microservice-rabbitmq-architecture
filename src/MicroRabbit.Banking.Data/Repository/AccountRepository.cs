using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BnakingDbContext _dbContext;

        public AccountRepository(BnakingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<IEnumerable<Account>> GetAccountsAsync()
        {
           return await _dbContext.Accounts.ToListAsync();
        }
    }
}
