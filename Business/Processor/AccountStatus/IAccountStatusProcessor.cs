namespace University_Management_System_API.Business.Processor.AccountStatus
{
    using University_Management_System_API.Business.Convertor.AccountStatus;
    using University_Management_System_API.Business.Processor.Common;

    public interface IAccountStatusProcessor : IBaseProcessor<AccountStatusParam, AccountStatusResult, long>
    {
    }
}
