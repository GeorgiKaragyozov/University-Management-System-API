namespace University_Management_System_API.Business.Convertor.UserGroup
{
    using University_Management_System_API.Business.Convertor.Common;

    public class UserGroupResultConverter
        : BaseResultConverter<Model.UserGroup, UserGroupResult>, IUserGroupResultConverter
    {
        public override void ConvertSpecific(Model.UserGroup entity, UserGroupResult result)
        {
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
        }

        public override UserGroupResult GetResult()
        {
            return new UserGroupResult();
        }
    }
}
