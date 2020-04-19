
namespace University_Management_System_API.Authentication.AuthenticationProvider
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using University_Management_System_API.Business.Convertor.User;
    using University_Management_System_API.Business.Processor.User;
    using University_Management_System_API.Business.Convertor.ApiSession;
    using University_Management_System_API.Business.Processor.ApiSession;
    using University_Management_System_API.Business.Processor.UserUserGroup;
    using University_Management_System_API.Authentication.AuthenticationProvider.TokenAuth;

    public class TokenAuthenticationProvider : BaseAuthenticationProvider, ITokenAuthenticationProvider
    {
        private IApiSessionProcessor _apiSessionProcessor;
        public IApiSessionProcessor ApiSessionProcessor
        {
            get { return this._apiSessionProcessor; }
            set { this._apiSessionProcessor = value; }
        }

        public TokenAuthenticationProvider(
            IUserProcessor processorUser,
            IUserUserGroupProcessor processorUserUserGroup,
            IApiSessionProcessor apiSessionProcessor)

            : base(processorUser, processorUserUserGroup)
        {
            this.ApiSessionProcessor = apiSessionProcessor;
        }

        public async override Task<UserResult> AuthenticateAsync(HttpRequest request)
        {
            //Get Headers Value
            string headerValue = request.Headers["Authorization"].ToString();
            ApiSessionResult resultSession = await ApiSessionProcessor.GetByAuthTokenAsync(headerValue);

            //Call FindById
            UserResult resultUser = ProcessorUser.Find(resultSession.UserId);

            return resultUser;
        }
    }
}
