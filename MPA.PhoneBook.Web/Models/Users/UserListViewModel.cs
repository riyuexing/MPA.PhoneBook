using System.Collections.Generic;
using MPA.PhoneBook.Roles.Dto;
using MPA.PhoneBook.Users.Dto;

namespace MPA.PhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}