namespace University_Management_System_API.Business.Processor.Account
{
    using University_Management_System_API.Business.Convertor.Account;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Account;

    public class AccountProcessor
        : BaseProcessor<IAccountParamConverter, IAccountResultConverter, AccountParam, AccountResult,
            IAccountDao, long, Model.Account>, IAccountProcessor
    {
        protected override long GetTPK(AccountParam param)
        {
            return param.Id;
        }

        public AccountProcessor(
            IAccountDao dao,
            IAccountParamConverter paramConverter,
            IAccountResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
