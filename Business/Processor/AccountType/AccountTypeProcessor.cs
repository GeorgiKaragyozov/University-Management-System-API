namespace University_Management_System_API.Business.Processor.AccountType
{
    using University_Management_System_API.Business.Convertor.AccountType;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.AccountType;

    public class AccountTypeProcessor
        : BaseProcessor<IAccountTypeParamConverter, IAccountTypeResultConverter, AccountTypeParam,
            AccountTypeResult, IAccountTypeDao, long, Model.AccountType>, IAccountTypeProcessor
    {
        protected override long GetTPK(AccountTypeParam param)
        {
            return param.Id;
        }

        public AccountTypeProcessor(
            IAccountTypeDao dao,
            IAccountTypeParamConverter paramConverter,
            IAccountTypeResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
