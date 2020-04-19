namespace University_Management_System_API.Controller.Service.Account
{
    using University_Management_System_API.Business.Convertor.Account;
    using University_Management_System_API.Business.Processor.Account;
    using University_Management_System_API.Controller.Service.Common;

    public class AccountController 
        : BaseController<AccountParam, AccountResult, long, IAccountProcessor>
    {
        public AccountController(IAccountProcessor processor)
           : base(processor)
        {
        }
    }
}
