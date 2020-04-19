namespace University_Management_System_API.Authentication.AuthenticationProvider
{
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Authentication;
    using University_Management_System_API.Business.Convertor.User;
    using University_Management_System_API.Business.Processor.User;
    using University_Management_System_API.Business.Processor.UserUserGroup;

    public abstract class BaseAuthenticationProvider : IBaseAuthenticationProvider
    {
        private IUserProcessor _processorUser;
        public IUserProcessor ProcessorUser
        {
            get { return _processorUser; }
            set { _processorUser = value; }
        }


        private IUserUserGroupProcessor _processorUserUserGroup;
        public IUserUserGroupProcessor ProcessorUserUserGroup
        {
            get { return _processorUserUserGroup; }
            set { _processorUserUserGroup = value; }
        }

        public BaseAuthenticationProvider(
            IUserProcessor processorUser,
            IUserUserGroupProcessor processorUserUserGroup)
        {
            this.ProcessorUser = processorUser;
            this.ProcessorUserUserGroup = processorUserUserGroup;
        }


        /// <summary>
        /// Calls the findByField function and finds the user groups by Id
        /// </summary>
        /// <param name="result">user result</param>
        /// <returns>the user group</returns>
        public async Task<List<string>> GetUserGroupsAsync(UserResult result)
        {
            return await Task.Run(() =>
                ProcessorUserUserGroup.Find("UserId", result.Id.ToString())
                .Select(x => x.UserGroupName)
                .ToList());
        }

        public abstract Task<UserResult> AuthenticateAsync(HttpRequest request);

        public async Task<AuthenticateResult> BuilderAuthenticationTicket(
            UserResult result,
            AuthenticationScheme scheme)
        {
            List<string> listUserGroups = await GetUserGroupsAsync(result);

            var claims = new List<Claim>
            {   
                new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()),
                new Claim(ClaimTypes.Name, result.Username)
            };

            listUserGroups.ForEach(userGroups =>
                claims.Add(new Claim(ClaimTypes.Role, userGroups)));

            var identity = new ClaimsIdentity(claims, scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
