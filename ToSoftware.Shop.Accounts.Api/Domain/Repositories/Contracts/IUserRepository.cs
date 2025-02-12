﻿using LM.Responses;
using System.Threading.Tasks;

namespace ToSoftware.Shop.Accounts.Api.Domain.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task CreateOrUpdateAsync(User user);

        Task<Maybe<User>> FindAsync(string identification);
    }
}