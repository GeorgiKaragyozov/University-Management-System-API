namespace University_Management_System_API.Business.Convertor.User
{
    using University_Management_System_API.Business.Convertor.Common;

    public class UserResultConverter : BaseResultConverter<Model.User, UserResult>, IUserResultConverter
    {
        public override void ConvertSpecific(Model.User entity, UserResult result)
        {
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
        }

        public override UserResult GetResult()
        {
            return new UserResult();
        }
    }
}
