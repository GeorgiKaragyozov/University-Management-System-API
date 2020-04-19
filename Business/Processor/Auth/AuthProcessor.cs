namespace University_Management_System_API.Business.Processor.Auth
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Security.Claims;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Options;
    using System.Text.RegularExpressions;
    using University_Management_System_API.Authentication.Common;
    using University_Management_System_API.Business.Processor.User;
    using University_Management_System_API.Business.Convertor.User;
    using University_Management_System_API.Business.Convertor.ApiSession;
    using University_Management_System_API.Business.Processor.ApiSession;
    using University_Management_System_API.Business.Processor.Account;
    using University_Management_System_API.Business.Convertor.Account;
    using University_Management_System_API.Business.Convertor.Auth;
    using University_Management_System_API.Business.Convertor.TrainingType;
    using University_Management_System_API.Business.Convertor.AccountType;
    using University_Management_System_API.Business.Processor.AccountType;

    public class AuthProcessor : IAuthProcessor
    {
        private IHttpContextAccessor _httpContextAccessor;
        public IHttpContextAccessor HttpContextAccessor
        {
            get { return this._httpContextAccessor; }
            set { this._httpContextAccessor = value; }
        }


        private IApiSessionProcessor _apiSessionProcessor;
        public IApiSessionProcessor ApiSessionProcessor
        {
            get { return this._apiSessionProcessor; }
            set { this._apiSessionProcessor = value; }
        }


        private IUserProcessor _userProcessor;
        public IUserProcessor UserProcessor
        {
            get { return this._userProcessor; }
            set { this._userProcessor = value; }
        }


        private IAccountProcessor _accountProcessor;
        public IAccountProcessor AccountProcessor
        {
            get { return this._accountProcessor; }
            set { this._accountProcessor = value; }
        }


        private IAccountTypeProcessor _accountTypeProcessor;
        public IAccountTypeProcessor AccountTypeProcessor
        {
            get { return this._accountTypeProcessor; }
            set { this._accountTypeProcessor = value; }
        }


        private IOptions<SecretKeySettings> _options;
        public IOptions<SecretKeySettings> Options
        {
            get { return _options; }
            set { _options = value; }
        }

        public AuthProcessor(
            IHttpContextAccessor httpContextAccessor,
            IApiSessionProcessor apiSessionProcessor,
            IUserProcessor userProcessor,
            IAccountProcessor accountProcessor,
            IOptions<SecretKeySettings> options,
            IAccountTypeProcessor accountTypeProcessor)
        {
            this.HttpContextAccessor = httpContextAccessor;
            this.ApiSessionProcessor = apiSessionProcessor;
            this.AccountProcessor = accountProcessor;
            this.AccountTypeProcessor = accountTypeProcessor;
            this.UserProcessor = userProcessor;
            this.Options = options;
        }

        public UserResult GetUser()
        {
            UserResult result;

            //Get user's id with claim type 
            var userId = HttpContextAccessor
                .HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            //Get user result with function find by field
            result = UserProcessor.Find("Id", userId).SingleOrDefault();
            return result;
        }

        public bool IsActiveUser(UserResult result)
        {
            if(result.Active == 0)
            {
                return false;
            }

            return true;
        }

        public bool IsActiveAccount(AccountResult result)
        {
            if (result.Active == 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Create new session for user and return token
        /// </summary>
        /// <returns>User's token</returns>
        public string GetAuthToken()
        {
            UserResult result;
            ApiSessionParam param = null;

            try
            {
                result = GetUser();

                if (IsActiveUser(result))
                {
                    //get secret value
                    var secret = this.Options.Value.Secret;
                    //to byte secret value
                    var key = Encoding.UTF8.GetBytes(secret);

                    //return random token for user
                    string randomToken = GenerateRandomToken.GenerateToken(key);

                    var regex = new Regex("[:!@#$%^&*()}{|\":?><\\]\\;'/.,~+-]");
                    randomToken = regex.Replace(randomToken, "-");

                    param = new ApiSessionParam()
                    {
                        AuthToken = randomToken,
                        UserId = result.Id,
                        Name = result.StatusName,
                        Code = result.Username,
                        Description = $"This is {result.Username} with session created on {System.DateTime.Now}",
                        Active = result.Active
                    };

                    //creta new session for user
                    ApiSessionProcessor.Create(param);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return param.AuthToken;
        }

        /// <summary>
        /// Erase User's Session
        /// </summary>
        public void EraseApiSession()
        {
            try
            {
                ApiSessionResult result = new ApiSessionResult();

                //Get Headers Value
                string authHeader = HttpContextAccessor.HttpContext.Request.Headers["Authorization"];

                if (!authHeader.StartsWith("Basic"))
                {
                    result = ApiSessionProcessor.Find("AuthToken", authHeader).SingleOrDefault();
                    ApiSessionProcessor.Erase(result.Id);
                }           
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }     
        }

        public AccountResult Register(RegisterParam param)
        {
            //Create user
            UserParam userParam = new UserParam
            {
                Username = param.Username,
                Password = param.Password,
                StatusId = 1
            };
            UserResult userResult = UserProcessor.Create(userParam);

            //Create accountType
            AccountTypeParam accountTypeParam = new AccountTypeParam
            {
                Name = param.Group
            };
            AccountTypeResult accountTypeResult = AccountTypeProcessor.Create(accountTypeParam);

            //Finally create account
            AccountParam accountParam = new AccountParam
            {
                StatusId = 1,
                SpecialityId = 1,
                DepartamentId = 1,
                UserId = userResult.Id,      
                TypeId = accountTypeResult.Id,
                FirstName = param.FirstName,
                MiddleName = param.MiddleName,
                LastName = param.LastName,
                Egn = param.Egn,
                Address = param.Address,
                City = param.City,
                Country = param.Country,
                MobilePhone = param.MobilePhone,
                HomePhone = param.HomePhone,
                Email = param.Email
            };
            AccountResult accountResult = AccountProcessor.Create(accountParam);

            return accountResult;
        }
    }
}
