namespace University_Management_System_API.Business.Processor.Account
{
    using University_Management_System_API.Business.Convertor.Account;
    using University_Management_System_API.Business.Processor.Common;

    public interface IAccountProcessor : IBaseProcessor<AccountParam, AccountResult, long>
    {
    }
}
