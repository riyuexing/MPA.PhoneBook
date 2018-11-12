using Abp.Authorization;
using MPA.PhoneBook.Authorization.Roles;
using MPA.PhoneBook.Authorization.Users;

namespace MPA.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
