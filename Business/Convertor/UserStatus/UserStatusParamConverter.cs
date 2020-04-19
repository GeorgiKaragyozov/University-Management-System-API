using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.UserStatus
{
    public class UserStatusParamConverter 
        : BaseParamConverter<UserStatusParam, Model.UserStatus>, IUserStatusParamConverter
    {
        public override Model.UserStatus GetEntity(UserStatusParam param)
        {
            return new Model.UserStatus();
        }

        public override void ConvertSpecific(UserStatusParam param, Model.UserStatus entity)
        {
        }
    }
}
