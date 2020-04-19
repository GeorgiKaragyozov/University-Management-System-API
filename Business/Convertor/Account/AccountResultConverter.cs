namespace University_Management_System_API.Business.Convertor.Account
{
    using University_Management_System_API.Business.Convertor.Common;

    public class AccountResultConverter : BaseResultConverter<Model.Account, AccountResult>, IAccountResultConverter
    {
        public override void ConvertSpecific(Model.Account entity, AccountResult result)
        {
            result.UserId = entity.User.Id;
            result.UserName = entity.User.Username;
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
            result.SpecialityId = entity.Speciality.Id;
            result.SpecialityName = entity.Speciality.Name;
            if(entity.Departament != null)
            {
                result.DepartamentId = entity.Departament.Id;
                result.DepartamentName = entity.Departament.Name;
            }      
            result.TypeId = entity.TypeAccount.Id;
            result.TypeName = entity.TypeAccount.Name;
        }

        public override AccountResult GetResult()
        {
            return new AccountResult();
        }
    }
}
