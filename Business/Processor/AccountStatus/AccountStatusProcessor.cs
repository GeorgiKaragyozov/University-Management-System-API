namespace University_Management_System_API.Business.Processor.AccountStatus
{
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.Business.Convertor.AccountStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.AccountStatus;

    public class AccountStatusProcessor
         : BaseProcessor<IAccountStatusParamConverter, IAccountStatusResultConverter, AccountStatusParam,
             AccountStatusResult, IAccountStatusDao, long, Model.AccountStatus>, IAccountStatusProcessor
    {
        protected override long GetTPK(AccountStatusParam param)
        {
            return param.Id;
        }

        public AccountStatusProcessor(
            IAccountStatusDao dao,
            IAccountStatusParamConverter paramConverter,
            IAccountStatusResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
