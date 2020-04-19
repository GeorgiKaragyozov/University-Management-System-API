
namespace University_Management_System_API.Authentication.AuthenticationProvider
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Authentication;
    using University_Management_System_API.Business.Convertor.User;

    public interface IBaseAuthenticationProvider
    {
        Task<UserResult> AuthenticateAsync(HttpRequest request);

        Task<List<string>> GetUserGroupsAsync(UserResult result);

        Task<AuthenticateResult> BuilderAuthenticationTicket(UserResult result, AuthenticationScheme scheme);
    }
}
