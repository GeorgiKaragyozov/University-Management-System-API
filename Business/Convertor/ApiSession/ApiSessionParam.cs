namespace University_Management_System_API.Business.Convertor.ApiSession
{
    public class ApiSessionParam : BaseParamNamed
    {
        public long UserId { get; set; }
        public string AuthToken { get; set; }
    }
}
