namespace University_Management_System_API.Authentication.AuthenticationHendler
{
    using System.Linq;
    using System.Threading.Tasks;
    using System.Text.Encodings.Web;
    using System.Collections.Generic;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Microsoft.AspNetCore.Authentication;
    using University_Management_System_API.Business.Convertor.User;
    using University_Management_System_API.Authentication.AuthenticationProvider;

    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IEnumerable<IBaseAuthenticationProvider> Providers;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            IEnumerable<IBaseAuthenticationProvider> providers,
            ILoggerFactory logger,
            ISystemClock clock,
            UrlEncoder encoder)
            : base(options, logger, encoder, clock)
        {
            this.Providers = providers;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Authorization Header not found");
            }

            UserResult resultUser = null;

            try
            {
                foreach (var providersItem in Providers)    
                {
                    if (resultUser == null)
                    {
                        resultUser = await providersItem.AuthenticateAsync(Request);
                    }
                }
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (resultUser == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            var providerAuthentication = Providers.First();

            var ticket = await providerAuthentication.BuilderAuthenticationTicket(resultUser, Scheme);

            return ticket;
        }
    }
}
