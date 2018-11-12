using System.Threading.Tasks;
using Abp.Application.Services;
using MPA.PhoneBook.Sessions.Dto;

namespace MPA.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
