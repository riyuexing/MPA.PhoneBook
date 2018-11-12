using System.Threading.Tasks;
using Abp.Application.Services;
using MPA.PhoneBook.Authorization.Accounts.Dto;

namespace MPA.PhoneBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
