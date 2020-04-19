namespace University_Management_System_API.Business.Convertor.AccountType
{
    using University_Management_System_API.Business.Convertor.Common;

    public class AccountTypeParamConverter
        : BaseParamConverter<AccountTypeParam, Model.AccountType>, IAccountTypeParamConverter
    {
        public override Model.AccountType GetEntity(AccountTypeParam param)
        {
            return new Model.AccountType();
        }

        public override void ConvertSpecific(AccountTypeParam param, Model.AccountType entity)
        {
        }
    }
}
