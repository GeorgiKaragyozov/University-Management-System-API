namespace University_Management_System_API.Business.Convertor.UserUserGroup
{
    using University_Management_System_API.Business.Convertor.Common;

    public class UserUserGroupResultConverter
        : BaseResultConverter<Model.UserUserGroup, UserUserGroupResult>, IUserUserGroupResultConverter
    {
        public override void ConvertSpecific(Model.UserUserGroup entity, UserUserGroupResult result)
        {
            result.UserId = entity.User.Id;
            result.UserName = entity.User.Username;
            result.UserGroupId = entity.UserGroup.Id;
            result.UserGroupName = entity.UserGroup.Name;
        }

        public override UserUserGroupResult GetResult()
        {
            return new UserUserGroupResult();
        }
    }
}
