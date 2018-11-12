using Abp.AutoMapper;
using MPA.PhoneBook.Sessions.Dto;

namespace MPA.PhoneBook.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}