namespace University_Management_System_API.Controller.Service.AccountType
{
    using University_Management_System_API.Business.Convertor.AccountType;
    using University_Management_System_API.Business.Processor.AccountType;
    using University_Management_System_API.Controller.Service.Common;

    public class AccountTypeController
          : BaseController<AccountTypeParam, AccountTypeResult, long, IAccountTypeProcessor>
    {
        public AccountTypeController(IAccountTypeProcessor processor)
            : base(processor)
        {
        }
    }
}
