namespace University_Management_System_API.Business.Convertor.AccountStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class AccountStatusResultConverter 
        : BaseResultConverter<Model.AccountStatus, AccountStatusResult>, IAccountStatusResultConverter
    {
        public override void ConvertSpecific(Model.AccountStatus entity, AccountStatusResult result) 
        {
        }

        public override AccountStatusResult GetResult()
        {
            return new AccountStatusResult();
        }
    }
}
