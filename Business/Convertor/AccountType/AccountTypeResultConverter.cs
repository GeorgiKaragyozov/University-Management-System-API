namespace University_Management_System_API.Business.Convertor.AccountType
{
    using University_Management_System_API.Business.Convertor.Common;

    public class AccountTypeResultConverter
        : BaseResultConverter<Model.AccountType, AccountTypeResult>, IAccountTypeResultConverter
    {
        public override void ConvertSpecific(Model.AccountType entity, AccountTypeResult result) 
        {
        }

        public override AccountTypeResult GetResult()
        {
            return new AccountTypeResult();
        }
    }
}
