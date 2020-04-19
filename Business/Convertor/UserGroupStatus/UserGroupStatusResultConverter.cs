namespace University_Management_System_API.Business.Convertor.UserGroupStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class UserGroupStatusResultConverter 
        : BaseResultConverter<Model.UserGroupStatus, UserGroupStatusResult>, IUserGroupStatusResultConverter
    {
        public override void ConvertSpecific(Model.UserGroupStatus entity, UserGroupStatusResult result)
        {
        }

        public override UserGroupStatusResult GetResult()
        {
            return new UserGroupStatusResult();
        }
    }
}
