using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPA.PhoneBook.MultiTenancy.Dto;

namespace MPA.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
