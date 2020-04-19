namespace University_Management_System_API.Business.Convertor.UserStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class UserStatusResultConverter 
        : BaseResultConverter<Model.UserStatus, UserStatusResult>, IUserStatusResultConverter
    {
        public override void ConvertSpecific(Model.UserStatus entity, UserStatusResult result) 
        {
        }

        public override UserStatusResult GetResult()
        {
            return new UserStatusResult();
        }
    }
}
