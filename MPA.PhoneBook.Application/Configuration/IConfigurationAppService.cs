using System.Threading.Tasks;
using Abp.Application.Services;
using MPA.PhoneBook.Configuration.Dto;

namespace MPA.PhoneBook.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}