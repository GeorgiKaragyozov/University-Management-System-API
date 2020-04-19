namespace University_Management_System_API.Business.Convertor.User
{
    using University_Management_System_API.Business.Convertor.Common;

    public interface IUserParamConverter : IBaseParamConverter<UserParam, Model.User>
    {
        Model.User HashPassword(Model.User entity);
    }
}
