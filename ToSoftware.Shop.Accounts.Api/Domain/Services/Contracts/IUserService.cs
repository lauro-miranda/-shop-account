using LM.Responses;
using System.Threading.Tasks;
using ToSoftware.Shop.Accounts.Api.Messages.Requests;

namespace ToSoftware.Shop.Accounts.Api.Domain.Services.Contracts
{
    public interface IUserService
    {
        Task<Response> CreateAsync(CreateUserRequestMessage requestMessage);

        Task<Response<User>> LoginAsync(LoginRequestMessage requestMessage);
    }
}